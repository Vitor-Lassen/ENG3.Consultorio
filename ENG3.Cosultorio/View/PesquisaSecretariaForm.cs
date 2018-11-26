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
    public partial class PesquisaSecretariaForm : MetroFramework.Forms.MetroForm
    {
        SecretaryDapperRepository _secretaryDapperRepository = new SecretaryDapperRepository();
        SecretariaFrm _secretariaForm;
        public PesquisaSecretariaForm(SecretariaFrm secretariaFrm)
        {
            InitializeComponent();
            _secretariaForm = secretariaFrm;
            List<Secretary> secretaries = _secretaryDapperRepository.GetAll().ToList();
            List<object> formated = new List<object>();

            foreach (var secretary in secretaries)
            {
                formated.Add(new
                {
                    CRM = secretary.Cpf,
                    Nome = secretary.Name,

                });
            }

            Grid.DataSource = formated;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _secretariaForm.OpenDoctor(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString()));
            Close();
        }
    }
}
