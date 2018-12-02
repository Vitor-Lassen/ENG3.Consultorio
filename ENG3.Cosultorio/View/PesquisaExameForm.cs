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
            Grid.DataSource = _exameDapperRepository.GetExamesByConsultaId(_consultaId).ToList();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ExameForm exameForm = new ExameForm();
            exameForm.ShowDialog();
        }
    }
}
