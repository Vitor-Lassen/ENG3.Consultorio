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
    public partial class homeForm : MetroFramework.Forms.MetroForm
    {
        public homeForm()
        {
            InitializeComponent();
            ENG3.Consultorio.Persistence.Configurations.RegisterMappings.Register();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ENG3.Consultorio.Persistence.Configurations.RegisterMappings.Register();
            Login login = new Login() { User = "teste", Password = "ola", Access = 's' };
            LoginDapperRepository dapperRepository = new LoginDapperRepository();
            dapperRepository.Add(login);
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
    }
}
