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
    public partial class SecretariaFrm : MetroFramework.Forms.MetroForm
    {
        Secretary _secretary = new Secretary();
        bool _secretaryArealyExistsInDataBase;
        LoginDapperRepository _loginDapperRepository = new LoginDapperRepository();
        AddressDapperRepository _addressDapperRepository = new AddressDapperRepository();
        ContactDapperRepository _contactDapperRepository = new ContactDapperRepository();
        SecretaryDapperRepository _secretaryDapperRepository = new SecretaryDapperRepository();
        ViaCepServices _viaCepServices = new ViaCepServices();

        public SecretariaFrm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _secretary.Name = NameTxt.Text;
            _secretary.Cpf = CpfTxt.Text.NumbersOnly();
            _secretary.Login.User = UserTxt.Text;
            _secretary.Login.Password = SenhaTxt.Text;
            _secretary.Login.Access = 's';
            _secretary.Address.Cep = (int)CepTxt.Text.NumbersOnly();
            _secretary.Address.Complemento = AddressCompTxt.Text;
            _secretary.Address.Number = (int)NumberTxt.Text.NumbersOnly();
            _secretary.Contacts.Add(new Contact() { ContactValue = TelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.residential });
            _secretary.Contacts.Add(new Contact() { ContactValue = CelTxt.Text.NumbersOnlyString(), Type = PhoneTypeEnum.mobile });

            if (_secretary.Login.Id == 0)
                _secretary.Login.Id = (int)_loginDapperRepository.Add(_secretary.Login);
            else
                _loginDapperRepository.Update(_secretary.Login);
            _secretary.LoginId = _secretary.Login.Id;

            if (_secretary.Address.Id == 0)
                _secretary.Address.Id = (int)_addressDapperRepository.Add(_secretary.Address);
            else
                _addressDapperRepository.Update(_secretary.Address);
            _secretary.AddressId = _secretary.Address.Id;

            if (_secretaryArealyExistsInDataBase)
                _secretaryDapperRepository.Update(_secretary);
            else
                _secretaryDapperRepository.Add(_secretary);

            foreach (var contact in _secretary.Contacts)
            {
                if (String.IsNullOrEmpty(contact.ContactValue))
                    break;
                if (contact.Id == 0)
                    _contactDapperRepository.InsetSecretaryContacts(_secretary.Cpf, contact);
                else
                    _contactDapperRepository.Update(contact);
            }
            _secretaryArealyExistsInDataBase = true;
            MessageBox.Show("Secretário Salvo!");
        }
        public void OpenDoctor(int crm)
        {
            _secretaryArealyExistsInDataBase = true;
            _secretary = _secretaryDapperRepository.GetById(crm);
            _secretary.Address = _viaCepServices.GetAddress(_addressDapperRepository.GetById(_secretary.AddressId));
            _secretary.Login = _loginDapperRepository.GetById(_secretary.LoginId);
            _secretary.Contacts = _contactDapperRepository.GetSecretaryContacts(_secretary.Cpf).ToList();

            NameTxt.Text = _secretary.Name;
            CpfTxt.Text = _secretary.Cpf.ToString();
            UserTxt.Text = _secretary.Login.User;
            SenhaTxt.Text = _secretary.Login.Password;
            CepTxt.Text = _secretary.Address.Cep.ToString();
            AddressCompTxt.Text = _secretary.Address.Complemento;
            NumberTxt.Text = _secretary.Address.Number.ToString();
            AddressTxt.Text = _secretary.Address.AddressValue;
            foreach (var contact in _secretary.Contacts)
            {
                if (contact.Type == PhoneTypeEnum.mobile)
                    CelTxt.Text = contact.ContactValue;
                if (contact.Type == PhoneTypeEnum.residential)
                    TelTxt.Text = contact.ContactValue;
            }

        }

        private void CepTxt_Leave(object sender, EventArgs e)
        {
            _secretary.Address.Cep = (int)CepTxt.Text.NumbersOnly();
            _secretary.Address = _viaCepServices.GetAddress(_secretary.Address);
            AddressTxt.Text = _secretary.Address.AddressValue;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PesquisaSecretariaForm pesquisaSecretariaForm = new PesquisaSecretariaForm(this);
            pesquisaSecretariaForm.ShowDialog();
        }
    }
}
