namespace ENG3.Consultorio.View
{
    partial class ConvenioForm
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
            this.AddBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ConvenioTxt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(361, 73);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseSelectable = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Novo Convênio:";
            // 
            // ConvenioTxt
            // 
            // 
            // 
            // 
            this.ConvenioTxt.CustomButton.Image = null;
            this.ConvenioTxt.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.ConvenioTxt.CustomButton.Name = "";
            this.ConvenioTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConvenioTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConvenioTxt.CustomButton.TabIndex = 1;
            this.ConvenioTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConvenioTxt.CustomButton.UseSelectable = true;
            this.ConvenioTxt.CustomButton.Visible = false;
            this.ConvenioTxt.Lines = new string[0];
            this.ConvenioTxt.Location = new System.Drawing.Point(132, 73);
            this.ConvenioTxt.MaxLength = 32767;
            this.ConvenioTxt.Name = "ConvenioTxt";
            this.ConvenioTxt.PasswordChar = '\0';
            this.ConvenioTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConvenioTxt.SelectedText = "";
            this.ConvenioTxt.SelectionLength = 0;
            this.ConvenioTxt.SelectionStart = 0;
            this.ConvenioTxt.ShortcutsEnabled = true;
            this.ConvenioTxt.Size = new System.Drawing.Size(223, 23);
            this.ConvenioTxt.TabIndex = 2;
            this.ConvenioTxt.UseSelectable = true;
            this.ConvenioTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConvenioTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConvenioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 127);
            this.Controls.Add(this.ConvenioTxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AddBtn);
            this.Name = "ConvenioForm";
            this.Text = "Convênio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton AddBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ConvenioTxt;
    }
}