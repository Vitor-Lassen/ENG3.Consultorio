using ENG3.Consultorio.ApplicationService.Extensions;
using ENG3.Consultorio.ApplicationService.Services;
using ENG3.Consultorio.Doman.Entities;
using ENG3.Consultorio.Doman.Enums;
using ENG3.Consultorio.Doman.ValueObjects;
using ENG3.Consultorio.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENG3.Consultorio.View
{
    public partial class PacienteForm : MetroFramework.Forms.MetroForm
    {
        Patient _patient = new Patient();
        bool _doctorArealyExistsInDataBase;
        LoginDapperRepository _loginDapperRepository = new LoginDapperRepository();
        AddressDapperRepository _addressDapperRepository = new AddressDapperRepository();
        ContactDapperRepository _contactDapperRepository = new ContactDapperRepository();
        PatientDapperRepository _patientDapperRepository = new PatientDapperRepository();
        ViaCepServices _viaCepServices = new ViaCepServices();
        public PacienteForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _patient.Name = NameTxt.Text;
            _patient.Cpf = CpfTxt.Text.NumbersOnly();
            _patient.Address.Cep = CepTxt.Text.NumbersOnly();
            _patient.Address.Complemento = AddressCompTxt.Text;
            _patient.Address.Number = NumberTxt.Text.NumbersOnly();
            _patient.Contacts.Add(new Contact() { ContactValue = TelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.residential });
            _patient.Contacts.Add(new Contact() { ContactValue = CelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.mobile });


            if (_patient.Address.Id == 0)
                _patient.Address.Id = (int)_addressDapperRepository.Add(_patient.Address);
            else
                _addressDapperRepository.Update(_patient.Address);
            _patient.AddressId = _patient.Address.Id;

            if (_doctorArealyExistsInDataBase)
                _patientDapperRepository.Update(_patient);
            else
                _patientDapperRepository.Add(_patient);

            foreach (var contact in _patient.Contacts)
            {
                if (String.IsNullOrEmpty(contact.ContactValue))
                    break;
                if (contact.Id == 0)
                    _contactDapperRepository.InsetPatientContacts(_patient.Cpf, contact);
                else
                    _contactDapperRepository.Update(contact);
            }
            _doctorArealyExistsInDataBase = true;
            MessageBox.Show("Paciente Salvo!");
        }
        public void OpenDoctor(int crm)
        {
            _doctorArealyExistsInDataBase = true;
            _patient = _patientDapperRepository.GetById(crm);
            _patient.Address = _viaCepServices.GetAddress(_addressDapperRepository.GetById(_patient.AddressId));
            _patient.Contacts = _contactDapperRepository.GetPatientContacts(_patient.Cpf).ToList();

            NameTxt.Text = _patient.Name;
            CpfTxt.Text = _patient.Cpf.ToString();
            CepTxt.Text = _patient.Address.Cep.ToString();
            AddressCompTxt.Text = _patient.Address.Complemento;
            NumberTxt.Text = _patient.Address.Number.ToString();
            AddressTxt.Text = _patient.Address.AddressValue;
            foreach (var contact in _patient.Contacts)
            {
                if (contact.Type == PhoneTypeEnum.mobile)
                    CelTxt.Text = contact.ContactValue;
                if (contact.Type == PhoneTypeEnum.residential)
                    TelTxt.Text = contact.ContactValue;
            }

        }

        private void CepTxt_Leave(object sender, EventArgs e)
        {
            _patient.Address.Cep = CepTxt.Text.NumbersOnly();
            _patient.Address = _viaCepServices.GetAddress(_patient.Address);
            AddressTxt.Text = _patient.Address.AddressValue;
        }
    }
}
