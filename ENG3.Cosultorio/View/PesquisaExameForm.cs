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
    public partial class PesquisaExameForm : MetroFramework.Forms.MetroForm
    {
        ExameDapperRepository _exameDapperRepository = new ExameDapperRepository();
        int _consultaId;
        public PesquisaExameForm(int consultaId)
        {
            InitializeComponent();
            _consultaId = consultaId;
        }

        private void PesquisaExame_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        public void CarregaGrid()
        {
            Grid.DataSource = _exameDapperRepository.GetExamesByConsultaId(_consultaId).ToList();
            Grid.Columns[1].Visible = false;
            Grid.Columns[2].Visible = false;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ExameForm exameForm = new ExameForm(this,_consultaId);
            exameForm.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ExameForm exameForm = new ExameForm(this,_consultaId);
            exameForm.ShowDialog();
        }
    }
}
