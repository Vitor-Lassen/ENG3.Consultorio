using ENG3.Consultorio.Doman.Entities;
using System;
using ENG3.Consultorio.ApplicationService.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENG3.Consultorio.Doman.ValueObjects;
using ENG3.Consultorio.Doman.Enums;
using ENG3.Consultorio.Repository.Dapper;
using ENG3.Consultorio.ApplicationService.Services;

namespace ENG3.Consultorio.View
{
    public partial class MedicoForm : MetroFramework.Forms.MetroForm
    {
        Doctor _doctor = new Doctor();
        bool _doctorArealyExistsInDataBase;
        LoginDapperRepository _loginDapperRepository = new LoginDapperRepository();
        AddressDapperRepository _addressDapperRepository = new AddressDapperRepository();
        ContactDapperRepository _contactDapperRepository = new ContactDapperRepository();
        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        ViaCepServices _viaCepServices = new ViaCepServices();

        public MedicoForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _doctor.Name = NameTxt.Text;
            _doctor.Crm = CrmTxt.Text.NumbersOnly();
            _doctor.Specialty = SpecialityTxt.Text;
            _doctor.Login.User = UserTxt.Text;
            _doctor.Login.Password = SenhaTxt.Text;
            _doctor.Login.Access = 'd';
            _doctor.Address.Cep = CepTxt.Text.NumbersOnly();
            _doctor.Address.Complemento = AddressCompTxt.Text;
            _doctor.Address.Number = NumberTxt.Text.NumbersOnly();
            _doctor.Contacts.Add(new Contact() { ContactValue = TelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.residential });
            _doctor.Contacts.Add(new Contact() { ContactValue = CelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.mobile });

            if (_doctor.Login.Id == 0)
                _doctor.Login.Id = (int)_loginDapperRepository.Add(_doctor.Login);      
            else
                _loginDapperRepository.Update(_doctor.Login);
            _doctor.LoginId = _doctor.Login.Id;

            if (_doctor.Address.Id == 0)
                _doctor.Address.Id = (int)_addressDapperRepository.Add(_doctor.Address);
            else
                _addressDapperRepository.Update(_doctor.Address);
            _doctor.AddressId = _doctor.Address.Id;

            if (_doctorArealyExistsInDataBase)
                _doctorDapperRepository.Update(_doctor);
            else 
                _doctorDapperRepository.Add(_doctor);

            foreach(var contact in _doctor.Contacts)
            {
                if (String.IsNullOrEmpty(contact.ContactValue))
                    break;
                if (contact.Id == 0)
                    _contactDapperRepository.InsetDoctorContacts(_doctor.Crm, contact);
                else
                    _contactDapperRepository.Update(contact);
            }
            _doctorArealyExistsInDataBase = true;
            MessageBox.Show("Médico Salvo!");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PesquisaMedicoForm pesquisaMedico = new PesquisaMedicoForm(this);
            pesquisaMedico.ShowDialog();
        }
        public void OpenDoctor(int crm)
        {
            _doctorArealyExistsInDataBase = true;
            _doctor = _doctorDapperRepository.GetById(crm);
            _doctor.Address = _viaCepServices.GetAddress(_addressDapperRepository.GetById(_doctor.AddressId));
            _doctor.Login = _loginDapperRepository.GetById(_doctor.LoginId);
            _doctor.Contacts = _contactDapperRepository.GetDoctorContacts(_doctor.Crm).ToList();
            
            NameTxt.Text = _doctor.Name;
            CrmTxt.Text = _doctor.Crm.ToString()  ;
            SpecialityTxt.Text = _doctor.Specialty;
            UserTxt.Text = _doctor.Login.User;
            SenhaTxt.Text = _doctor.Login.Password;
            CepTxt.Text = _doctor.Address.Cep.ToString();
            AddressCompTxt.Text = _doctor.Address.Complemento;
            NumberTxt.Text = _doctor.Address.Number.ToString();
            AddressTxt.Text = _doctor.Address.AddressValue;
            foreach(var contact in _doctor.Contacts)
            {
                if (contact.Type == PhoneTypeEnum.mobile)
                    CelTxt.Text = contact.ContactValue;
                if (contact.Type == PhoneTypeEnum.residential)
                    TelTxt.Text = contact.ContactValue;
            }
            
        }

        private void CepTxt_Leave(object sender, EventArgs e)
        {
            _doctor.Address.Cep = CepTxt.Text.NumbersOnly();
            _doctor.Address = _viaCepServices.GetAddress(_doctor.Address);
            AddressTxt.Text = _doctor.Address.AddressValue;
        }
    }
}
