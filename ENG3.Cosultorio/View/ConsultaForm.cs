using ENG3.Consultorio.ApplicationService.Extensions;
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
    public partial class ConsultaForm : MetroFramework.Forms.MetroForm
    {
        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        SecretaryDapperRepository _secretaryDapperRepository = new SecretaryDapperRepository();
        PatientDapperRepository _patientDapperRepository = new PatientDapperRepository();
        ConvenioDapperRepository _convenioDapperRepository = new ConvenioDapperRepository();
        ConsultaDapperRepository _consultaDapperRepository = new ConsultaDapperRepository();
        Patient _patient;

        public ConsultaForm()
        {
            InitializeComponent();
            carregaCbos();
            SecretariaCbo.SelectedIndex = -1;
            MedicoCbo.SelectedIndex = -1;
        }
        private void carregaCbos()
        {
            MedicoCbo.DataSource =_doctorDapperRepository.GetAll().ToList();

            MedicoCbo.DisplayMember = "Name";
            MedicoCbo.ValueMember = "Crm";

            SecretariaCbo.DataSource = _secretaryDapperRepository.GetAll();
            SecretariaCbo.DisplayMember = "Name";
            SecretariaCbo.ValueMember = "Cpf";
        }

        private void CpfPacTxt_MouseLeave(object sender, EventArgs e)
        {
            long cpf = CpfPacTxt.Text.NumbersOnly();

                _patient = _patientDapperRepository.GetById(cpf);
                if (_patient != null &&_patient.ConvenioId != 0)
                {
                    _patient.Convenio = _convenioDapperRepository.GetById(_patient.ConvenioId);
                    PgmtTxt.Text = _patient.Convenio.Name;
                }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.DateStart = DataIniDt.Value;
            DataFimDt.Value = DataIniDt.Value.Date.AddHours( DataFimDt.Value.Hour).AddMinutes(DataFimDt.Value.Minute);
            consulta.DateEnd = DataFimDt.Value;
            consulta.ConsultaType = TipoConsuTxt.Text;
            consulta.DoctorId = Convert.ToInt32(MedicoCbo.SelectedValue.ToString());
            consulta.SecretaryId = Convert.ToInt64(SecretariaCbo.SelectedValue.ToString());
            consulta.Quitado = QuitadoChk.Checked;
            consulta.Price = Convert.ToDouble(ValorTxt.Text);
            consulta.Id = (int)CodTxt.Text.NumbersOnly();
            consulta.PagamentType = PgmtTxt.Text;
            consulta.PatientId = CpfPacTxt.Text.NumbersOnly();
            if(consulta.Id == 0)
            {
                CodTxt.Text=_consultaDapperRepository.Add(consulta).ToString();
            }
            else
            {
                _consultaDapperRepository.Update(consulta);
            }
        }
    }
}
