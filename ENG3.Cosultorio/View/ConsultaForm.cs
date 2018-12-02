using ENG3.Consultorio.ApplicationService.Extensions;
using ENG3.Consultorio.Doman.Entities;
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
    public partial class ConsultaForm : MetroFramework.Forms.MetroForm
    {
        DoctorDapperRepository _doctorDapperRepository = new DoctorDapperRepository();
        SecretaryDapperRepository _secretaryDapperRepository = new SecretaryDapperRepository();
        PatientDapperRepository _patientDapperRepository = new PatientDapperRepository();
        ConvenioDapperRepository _convenioDapperRepository = new ConvenioDapperRepository();
        ConsultaDapperRepository _consultaDapperRepository = new ConsultaDapperRepository();
        MaterialDapperRepository _materialDapperRepository = new MaterialDapperRepository();
        Patient _patient;
        List<Material> _materiais = new List<Material>();

        public ConsultaForm()
        {
            Initialize();
        }
        public ConsultaForm(int consultaId) 
        {
            Initialize();
            OpenConsulta(consultaId);
        }
        private void Initialize()
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
                consulta.Id=(int)_consultaDapperRepository.Add(consulta);
                CodTxt.Text = consulta.Id.ToString();
            }
            else
            {
                _consultaDapperRepository.Update(consulta);
            }
            foreach (var material in _materiais)
            {
                if (material.Id == 0)
                {
                    material.Id =_materialDapperRepository.InsetConsultaMaterial(consulta.Id, material).Id;
                }
            }
            MessageBox.Show("Consulta Salva!");
        }
        private void OpenConsulta(int consultaId)
        {
            Consulta consulta = _consultaDapperRepository.GetById(consultaId);
            CodTxt.Text = consulta.Id.ToString();
            DataFimDt.Value = consulta.DateStart;
            DataIniDt.Value = consulta.DateEnd;
            MedicoCbo.SelectedValue = consulta.DoctorId;
            SecretariaCbo.SelectedValue = consulta.SecretaryId;
            CpfPacTxt.Text = consulta.PatientId.ToString();
            TipoConsuTxt.Text = consulta.ConsultaType;
            PgmtTxt.Text = consulta.PagamentType;
            ValorTxt.Text = consulta.Price.ToString();
            QuitadoChk.Checked = consulta.Quitado;

            _materiais = _materialDapperRepository.GetMateriaisByConsultaId(consulta.Id).ToList();
            ReloadMateriaisList();

        }

        private void AddMaterial_Click(object sender, EventArgs e)
        {
            _materiais.Add(new Material() { Name = MaterialTxt.Text });
            ReloadMateriaisList();
            MaterialTxt.Clear();
        }
        private void ReloadMateriaisList()
        {
            MateriaisList.Items.Clear();
            foreach(var material in _materiais)
            {
                MateriaisList.Items.Add(material.Name);
            }
        }

        private void CpfPacTxt_Leave(object sender, EventArgs e)
        {
            long cpf = CpfPacTxt.Text.NumbersOnly();

            _patient = _patientDapperRepository.GetById(cpf);
            if (_patient != null)
            {
                ClientNameLbl.Text = _patient.Name;
                if (_patient.ConvenioId != 0)
                {
                    _patient.Convenio = _convenioDapperRepository.GetById(_patient.ConvenioId);
                    PgmtTxt.Text = _patient.Convenio.Name;
                }
            }
            else
            {
                ClientNameLbl.Text = "Paciente Não Encontrado";
            }
           
        }

        private void ExameBtn_Click(object sender, EventArgs e)
        {
            int codConsultaId ;
            if( Int32.TryParse(CodTxt.Text, out codConsultaId)) 
            {
                PesquisaExameForm pesquisaExameForm = new PesquisaExameForm(codConsultaId);
                pesquisaExameForm.ShowDialog();
            }
            else{
                MessageBox.Show("selecione uma consulta antes");
            }
        }
    }
}
