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
    public partial class ConvenioForm : MetroFramework.Forms.MetroForm
    {
        PacienteForm _pacienteForm;
        ConvenioDapperRepository _covenioDapperRepository = new ConvenioDapperRepository();
        public ConvenioForm(PacienteForm pacienteForm)
        {
            InitializeComponent();
            _pacienteForm = pacienteForm;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio() { Name= ConvenioTxt.Text};

            _covenioDapperRepository.Add(convenio);
            _pacienteForm.LoadConvenioCbo();
            Close();
        }
    }
}
