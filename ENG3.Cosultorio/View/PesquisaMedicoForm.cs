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
    public partial class PesquisaMedicoForm : MetroFramework.Forms.MetroForm
    {
        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        MedicoForm _medicoForm;
        public PesquisaMedicoForm(MedicoForm medicoForm)
        {
            InitializeComponent();
            _medicoForm = medicoForm;
            List<Doctor> doctors = _doctorDapperRepository.GetAll().ToList();
            List<object> formated = new List<object>();

            foreach(var doctor in doctors)
            {
                formated.Add(new
                {
                    CRM = doctor.Crm,
                    Nome = doctor.Name,
                    Especialidade = doctor.Specialty
                });
            }

            Grid.DataSource = formated;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _medicoForm.OpenDoctor(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString()));
            Close();
        }
    }
}
