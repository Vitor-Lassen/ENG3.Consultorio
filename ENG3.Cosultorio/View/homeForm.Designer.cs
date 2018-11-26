namespace ENG3.Consultorio.View
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecretariaTile = new MetroFramework.Controls.MetroTile();
            this.MedicoTile = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecretariaTile
            // 
            this.SecretariaTile.ActiveControl = null;
            this.SecretariaTile.Location = new System.Drawing.Point(159, 3);
            this.SecretariaTile.Name = "SecretariaTile";
            this.SecretariaTile.Size = new System.Drawing.Size(150, 150);
            this.SecretariaTile.TabIndex = 0;
            this.SecretariaTile.Text = "Secretária";
            this.SecretariaTile.UseSelectable = true;
            this.SecretariaTile.Click += new System.EventHandler(this.SecretariaTile_Click);
            // 
            // MedicoTile
            // 
            this.MedicoTile.ActiveControl = null;
            this.MedicoTile.Location = new System.Drawing.Point(315, 3);
            this.MedicoTile.Name = "MedicoTile";
            this.MedicoTile.Size = new System.Drawing.Size(150, 150);
            this.MedicoTile.TabIndex = 1;
            this.MedicoTile.Text = "Medico";
            this.MedicoTile.UseSelectable = true;
            this.MedicoTile.Click += new System.EventHandler(this.MedicoTile_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(471, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(150, 150);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Consulta";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(3, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(150, 150);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Paciente ";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.metroTile4);
            this.flowLayoutPanel1.Controls.Add(this.SecretariaTile);
            this.flowLayoutPanel1.Controls.Add(this.MedicoTile);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.metroTile5);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 339);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(3, 159);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(150, 150);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Convênio";
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(159, 159);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(150, 150);
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "Agênda";
            this.metroTile6.UseSelectable = true;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "homeForm";
            this.Text = "Clinica";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile SecretariaTile;
        private MetroFramework.Controls.MetroTile MedicoTile;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}