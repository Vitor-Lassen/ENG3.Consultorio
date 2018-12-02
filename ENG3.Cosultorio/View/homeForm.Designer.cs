namespace ENG3.Consultorio.View
{
    partial class HomeForm
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
            this.PacienteTile = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AgendaTile = new MetroFramework.Controls.MetroTile();
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
            this.SecretariaTile.Text = "Secretário";
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
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // PacienteTile
            // 
            this.PacienteTile.ActiveControl = null;
            this.PacienteTile.Location = new System.Drawing.Point(3, 3);
            this.PacienteTile.Name = "PacienteTile";
            this.PacienteTile.Size = new System.Drawing.Size(150, 150);
            this.PacienteTile.TabIndex = 3;
            this.PacienteTile.Text = "Paciente ";
            this.PacienteTile.UseSelectable = true;
            this.PacienteTile.Click += new System.EventHandler(this.PacienteTile_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.PacienteTile);
            this.flowLayoutPanel1.Controls.Add(this.SecretariaTile);
            this.flowLayoutPanel1.Controls.Add(this.MedicoTile);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.AgendaTile);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 339);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // AgendaTile
            // 
            this.AgendaTile.ActiveControl = null;
            this.AgendaTile.Location = new System.Drawing.Point(3, 159);
            this.AgendaTile.Name = "AgendaTile";
            this.AgendaTile.Size = new System.Drawing.Size(150, 150);
            this.AgendaTile.TabIndex = 5;
            this.AgendaTile.Text = "Agênda";
            this.AgendaTile.UseSelectable = true;
            this.AgendaTile.Click += new System.EventHandler(this.AgendaTile_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HomeForm";
            this.Text = "Clinica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile SecretariaTile;
        private MetroFramework.Controls.MetroTile MedicoTile;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile PacienteTile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile AgendaTile;
    }
}