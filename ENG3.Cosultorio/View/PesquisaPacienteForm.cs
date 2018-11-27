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
    public partial class PesquisaPacienteForm : MetroFramework.Forms.MetroForm
    {
        PatientDapperRepository _patientDapperRepository = new PatientDapperRepository();
        PacienteForm _pacienteForm;
        public PesquisaPacienteForm(PacienteForm pacienteForm)
        {
            InitializeComponent();
            _pacienteForm = pacienteForm;
            List<Patient> patients = _patientDapperRepository.GetAll().ToList();
            List<object> formated = new List<object>();

            foreach (var patient in patients)
            {
                formated.Add(new
                {
                    CRM = patient.Cpf,
                    Nome = patient.Name,

                });
            }

            Grid.DataSource = formated;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _pacienteForm.OpenDoctor(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString()));
            Close();
        }
    }
}
