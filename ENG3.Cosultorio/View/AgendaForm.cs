using ENG3.Consultorio.Doman.Entities;
using ENG3.Consultorio.Model;
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
    public partial class AgendaForm : MetroFramework.Forms.MetroForm
    {

        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        ConsultaDapperRepository _consultaDapperRepository = new ConsultaDapperRepository();
      

        public AgendaForm()
        {
            InitializeComponent();
            carregaCbos();
        }
        private void carregaCbos()
        {
            MedicoCbo.DataSource = _doctorDapperRepository.GetAll().ToList();

            MedicoCbo.DisplayMember = "Name";
            MedicoCbo.ValueMember = "Crm";

        }

        private void SearchAllBtn_Click(object sender, EventArgs e)
        {
            ShowResults( _consultaDapperRepository.GetAll().ToList());
        }

        private void ShowResults(List<Consulta> consultas)
        {
            List<SearchConsulta> searchConsultas = new List<SearchConsulta>();
            foreach (var consulta in consultas)
            {
                consulta.Doctor = _doctorDapperRepository.GetById(consulta.DoctorId);
                searchConsultas.Add(new SearchConsulta()
                {
                    Codigo = consulta.Id,
                    Data = consulta.DateStart.ToShortDateString(),
                    Doutor = consulta.Doctor.Name,
                    PacienteCPF = consulta.PatientId.ToString()
                });
                Grid.DataSource = searchConsultas;

            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Grid.DataSource = null ;
            List<Consulta> consultas = new List<Consulta>();
            if(MedicoCbo.SelectedIndex != -1)
            {
                consultas= _consultaDapperRepository.GetConsultasByDoctorId(Convert.ToInt32(MedicoCbo.SelectedValue)).ToList();

            }
            else
            {
                consultas = _consultaDapperRepository.GetConsultasByDate(DataIniDt.Value).ToList();
            }
            ShowResults(consultas);
        }

        private void DesfazerBtn_Click(object sender, EventArgs e)
        {
            MedicoCbo.SelectedIndex = -1;
        }
    }
}
