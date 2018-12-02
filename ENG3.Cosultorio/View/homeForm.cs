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
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
            ENG3.Consultorio.Persistence.Configurations.RegisterMappings.Register();
        }

        private void PacienteTile_Click(object sender, EventArgs e)
        {
            PacienteForm pacienteForm = new PacienteForm();
            pacienteForm.Show();
        }

        private void MedicoTile_Click(object sender, EventArgs e)
        {
            MedicoForm medico = new MedicoForm();
            medico.ShowDialog();
        }

        private void SecretariaTile_Click(object sender, EventArgs e)
        {
            SecretariaFrm secretariaFrm = new SecretariaFrm();
            secretariaFrm.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ConsultaForm consultaForm = new ConsultaForm();
            consultaForm.ShowDialog();
        }

        private void AgendaTile_Click(object sender, EventArgs e)
        {
            AgendaForm agendaForm = new AgendaForm();
            agendaForm.ShowDialog();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
