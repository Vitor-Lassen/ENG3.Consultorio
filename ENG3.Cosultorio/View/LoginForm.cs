using ENG3.Consultorio.Doman.Entities;
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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        LoginDapperRepository _loginDapperRepository = new LoginDapperRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = _loginDapperRepository.Login(txtLogin.Text, txtSenha.Text);
            if (login != null)
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
        }
    }
}
