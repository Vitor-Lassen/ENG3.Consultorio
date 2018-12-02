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
    public partial class ExameForm : MetroFramework.Forms.MetroForm
    {
        private int _consultaId;
        private ExameDapperRepository _exameDapperRepository = new ExameDapperRepository();
        private PesquisaExameForm _pesquisaExameForm;
        public ExameForm(PesquisaExameForm pesquisaExameForm,int consultaId)
        {
            InitializeComponent();
            _pesquisaExameForm = pesquisaExameForm;
            _consultaId = consultaId;
        }


        public void CarregaExame(int exameId)
        {
            Exame exame = _exameDapperRepository.GetById(exameId);
            _consultaId = exame.ConsultaId;
            CodTxt.Text = exame.Id.ToString();
            DataIniDt.Value = exame.Date;
            ExameTxt.Text = exame.Name;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            exame.ConsultaId = _consultaId;
            exame.Date = DataIniDt.Value;
            exame.Name = ExameTxt.Text;
            exame.Id = (int)CodTxt.Text.NumbersOnly();
            if (exame.Id == 0)
            {
                _exameDapperRepository.Add(exame);
            }
            else
            {
                _exameDapperRepository.Update(exame);
            }
            _pesquisaExameForm.CarregaGrid();
            Close();

        }
    }
}
