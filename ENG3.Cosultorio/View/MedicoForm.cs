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

namespace ENG3.Consultorio.View
{
    public partial class MedicoForm : MetroFramework.Forms.MetroForm
    {
        Doctor _doctor;
        LoginDapperRepository _loginDapperRepository = new LoginDapperRepository();
        AddressDapperRepository _addressDapperRepository = new AddressDapperRepository();
        ContactDapperRepository _contactDapperRepository = new ContactDapperRepository();
        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        public MedicoForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (_doctor == null)
                _doctor = new Doctor();

            _doctor.Name = NameTxt.Text;
            _doctor.Crm = CrmTxt.Text.NumbersOnly();
            _doctor.Specialty = SpecialityTxt.Text;
            _doctor.Login.User = UserTxt.Text;
            _doctor.Login.Senha = SenhaTxt.Text;
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
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PesquisaMedicoForm pesquisaMedico = new PesquisaMedicoForm(this);
            pesquisaMedico.ShowDialog();
        }
        public void OpenDoctor(int crm)
        {
            Doctor doctor = _doctorDapperRepository.GetById(crm);
            doctor.Address = _addressDapperRepository.GetById(doctor.AddressId);
            doctor.Login = _loginDapperRepository.GetById(doctor.LoginId);
        }
    }
}
