namespace ENG3.Consultorio.View
{
    partial class ExameForm
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
            this.MateriaisList = new System.Windows.Forms.ListBox();
            this.MaterialTxt = new MetroFramework.Controls.MetroTextBox();
            this.AddMaterial = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.DataIniDt = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.ExameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CodTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MateriaisList);
            this.metroPanel1.Controls.Add(this.MaterialTxt);
            this.metroPanel1.Controls.Add(this.AddMaterial);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.DataIniDt);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.ExameTxt);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.CodTxt);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(470, 303);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MateriaisList
            // 
            this.MateriaisList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MateriaisList.FormattingEnabled = true;
            this.MateriaisList.ItemHeight = 16;
            this.MateriaisList.Location = new System.Drawing.Point(100, 132);
            this.MateriaisList.Name = "MateriaisList";
            this.MateriaisList.Size = new System.Drawing.Size(340, 100);
            this.MateriaisList.TabIndex = 30;
            // 
            // MaterialTxt
            // 
            // 
            // 
            // 
            this.MaterialTxt.CustomButton.Image = null;
            this.MaterialTxt.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.MaterialTxt.CustomButton.Name = "";
            this.MaterialTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MaterialTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MaterialTxt.CustomButton.TabIndex = 1;
            this.MaterialTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MaterialTxt.CustomButton.UseSelectable = true;
            this.MaterialTxt.CustomButton.Visible = false;
            this.MaterialTxt.Lines = new string[0];
            this.MaterialTxt.Location = new System.Drawing.Point(100, 234);
            this.MaterialTxt.MaxLength = 32767;
            this.MaterialTxt.Name = "MaterialTxt";
            this.MaterialTxt.PasswordChar = '\0';
            this.MaterialTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MaterialTxt.SelectedText = "";
            this.MaterialTxt.SelectionLength = 0;
            this.MaterialTxt.SelectionStart = 0;
            this.MaterialTxt.ShortcutsEnabled = true;
            this.MaterialTxt.Size = new System.Drawing.Size(270, 23);
            this.MaterialTxt.TabIndex = 28;
            this.MaterialTxt.UseSelectable = true;
            this.MaterialTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MaterialTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddMaterial
            // 
            this.AddMaterial.Location = new System.Drawing.Point(368, 234);
            this.AddMaterial.Name = "AddMaterial";
            this.AddMaterial.Size = new System.Drawing.Size(72, 23);
            this.AddMaterial.TabIndex = 29;
            this.AddMaterial.Text = "Adicionar";
            this.AddMaterial.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(30, 132);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(65, 19);
            this.metroLabel10.TabIndex = 27;
            this.metroLabel10.Text = "Materiais:";
            // 
            // DataIniDt
            // 
            this.DataIniDt.CustomFormat = "dd/MM/yy hh:mm | dddd";
            this.DataIniDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataIniDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataIniDt.Location = new System.Drawing.Point(100, 54);
            this.DataIniDt.Name = "DataIniDt";
            this.DataIniDt.Size = new System.Drawing.Size(238, 23);
            this.DataIniDt.TabIndex = 24;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(365, 263);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "Salvar";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(43, 98);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Exame:";
            // 
            // ExameTxt
            // 
            // 
            // 
            // 
            this.ExameTxt.CustomButton.Image = null;
            this.ExameTxt.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.ExameTxt.CustomButton.Name = "";
            this.ExameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ExameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExameTxt.CustomButton.TabIndex = 1;
            this.ExameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExameTxt.CustomButton.UseSelectable = true;
            this.ExameTxt.CustomButton.Visible = false;
            this.ExameTxt.Lines = new string[0];
            this.ExameTxt.Location = new System.Drawing.Point(100, 94);
            this.ExameTxt.MaxLength = 32767;
            this.ExameTxt.Name = "ExameTxt";
            this.ExameTxt.PasswordChar = '\0';
            this.ExameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExameTxt.SelectedText = "";
            this.ExameTxt.SelectionLength = 0;
            this.ExameTxt.SelectionStart = 0;
            this.ExameTxt.ShortcutsEnabled = true;
            this.ExameTxt.Size = new System.Drawing.Size(340, 23);
            this.ExameTxt.TabIndex = 19;
            this.ExameTxt.UseSelectable = true;
            this.ExameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ExameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Código:";
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
            this.CodTxt.Location = new System.Drawing.Point(100, 18);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Data e Hora:";
            // 
            // ExameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 359);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ExameForm";
            this.Text = "ExameForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox MateriaisList;
        private MetroFramework.Controls.MetroTextBox MaterialTxt;
        private MetroFramework.Controls.MetroButton AddMaterial;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DateTimePicker DataIniDt;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox ExameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CodTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}