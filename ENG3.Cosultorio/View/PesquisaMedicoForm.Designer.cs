namespace ENG3.Consultorio.View
{
    partial class PesquisaMedicoForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SecretariaCbo = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new MetroFramework.Controls.MetroButton();
            this.TipoConsuTxt = new MetroFramework.Controls.MetroTextBox();
            this.Crmtext = new MetroFramework.Controls.MetroLabel();
            this.CodTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.NomeMedico = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.SecretariaCbo);
            this.metroPanel1.Controls.Add(this.SearchBtn);
            this.metroPanel1.Controls.Add(this.TipoConsuTxt);
            this.metroPanel1.Controls.Add(this.Crmtext);
            this.metroPanel1.Controls.Add(this.CodTxt);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.NomeMedico);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(59, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(646, 376);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SecretariaCbo
            // 
            this.SecretariaCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SecretariaCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SecretariaCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SecretariaCbo.FormattingEnabled = true;
            this.SecretariaCbo.Location = new System.Drawing.Point(103, 116);
            this.SecretariaCbo.Name = "SecretariaCbo";
            this.SecretariaCbo.Size = new System.Drawing.Size(520, 24);
            this.SecretariaCbo.TabIndex = 23;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(284, 235);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 21;
            this.SearchBtn.Text = "Procurar";
            this.SearchBtn.UseSelectable = true;
            // 
            // TipoConsuTxt
            // 
            // 
            // 
            // 
            this.TipoConsuTxt.CustomButton.Image = null;
            this.TipoConsuTxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TipoConsuTxt.CustomButton.Name = "";
            this.TipoConsuTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TipoConsuTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TipoConsuTxt.CustomButton.TabIndex = 1;
            this.TipoConsuTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TipoConsuTxt.CustomButton.UseSelectable = true;
            this.TipoConsuTxt.CustomButton.Visible = false;
            this.TipoConsuTxt.Lines = new string[0];
            this.TipoConsuTxt.Location = new System.Drawing.Point(85, 157);
            this.TipoConsuTxt.MaxLength = 32767;
            this.TipoConsuTxt.Name = "TipoConsuTxt";
            this.TipoConsuTxt.PasswordChar = '\0';
            this.TipoConsuTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TipoConsuTxt.SelectedText = "";
            this.TipoConsuTxt.SelectionLength = 0;
            this.TipoConsuTxt.SelectionStart = 0;
            this.TipoConsuTxt.ShortcutsEnabled = true;
            this.TipoConsuTxt.Size = new System.Drawing.Size(120, 23);
            this.TipoConsuTxt.TabIndex = 19;
            this.TipoConsuTxt.UseSelectable = true;
            this.TipoConsuTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TipoConsuTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Crmtext
            // 
            this.Crmtext.AutoSize = true;
            this.Crmtext.Location = new System.Drawing.Point(38, 39);
            this.Crmtext.Name = "Crmtext";
            this.Crmtext.Size = new System.Drawing.Size(41, 19);
            this.Crmtext.TabIndex = 0;
            this.Crmtext.Text = "CRM:";
            this.Crmtext.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // CodTxt
            // 
            // 
            // 
            // 
            this.CodTxt.CustomButton.Image = null;
            this.CodTxt.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.CodTxt.CustomButton.Name = "";
            this.CodTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CodTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodTxt.CustomButton.TabIndex = 1;
            this.CodTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodTxt.CustomButton.UseSelectable = true;
            this.CodTxt.CustomButton.Visible = false;
            this.CodTxt.Lines = new string[0];
            this.CodTxt.Location = new System.Drawing.Point(85, 35);
            this.CodTxt.MaxLength = 32767;
            this.CodTxt.Name = "CodTxt";
            this.CodTxt.PasswordChar = '\0';
            this.CodTxt.ReadOnly = true;
            this.CodTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodTxt.SelectedText = "";
            this.CodTxt.SelectionLength = 0;
            this.CodTxt.SelectionStart = 0;
            this.CodTxt.ShortcutsEnabled = true;
            this.CodTxt.Size = new System.Drawing.Size(148, 23);
            this.CodTxt.TabIndex = 1;
            this.CodTxt.UseSelectable = true;
            this.CodTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(413, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 4;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 157);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Telefone:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSize = true;
            this.NomeMedico.Location = new System.Drawing.Point(6, 73);
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.Size = new System.Drawing.Size(117, 19);
            this.NomeMedico.TabIndex = 7;
            this.NomeMedico.Text = "Nome do Médico:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 116);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Especialidade:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(472, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(126, 73);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(494, 23);
            this.metroTextBox1.TabIndex = 30;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PesquisaMedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PesquisaMedicoForm";
            this.Text = "Pesquisa Médico";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ComboBox SecretariaCbo;
        private MetroFramework.Controls.MetroButton SearchBtn;
        private MetroFramework.Controls.MetroTextBox TipoConsuTxt;
        private MetroFramework.Controls.MetroLabel Crmtext;
        private MetroFramework.Controls.MetroTextBox CodTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel NomeMedico;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}