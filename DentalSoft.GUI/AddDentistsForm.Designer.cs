namespace DentalSoft
{
    partial class frmAddDentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDentist));
            this.btnShtoDentist = new System.Windows.Forms.Button();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.lblEmri = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.lblFjalekalimi = new System.Windows.Forms.Label();
            this.lblPerdoruesi = new System.Windows.Forms.Label();
            this.txtRishkruajFjalekalimin = new System.Windows.Forms.TextBox();
            this.lblRishkruajFjalekalimin = new System.Windows.Forms.Label();
            this.pctFotoProfil = new System.Windows.Forms.PictureBox();
            this.ofdShfletoFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnShfletoFoto = new System.Windows.Forms.Button();
            this.lblEmriFajllit = new System.Windows.Forms.Label();
            this.lblPassowrdInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShtoDentist
            // 
            this.btnShtoDentist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoDentist.Location = new System.Drawing.Point(185, 237);
            this.btnShtoDentist.Name = "btnShtoDentist";
            this.btnShtoDentist.Size = new System.Drawing.Size(91, 23);
            this.btnShtoDentist.TabIndex = 0;
            this.btnShtoDentist.Text = "Shto dentist";
            this.btnShtoDentist.UseVisualStyleBackColor = true;
            this.btnShtoDentist.Click += new System.EventHandler(this.btnShtoDentist_Click);
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnulo.Location = new System.Drawing.Point(104, 237);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(75, 23);
            this.btnAnulo.TabIndex = 1;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Location = new System.Drawing.Point(16, 24);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(27, 13);
            this.lblEmri.TabIndex = 2;
            this.lblEmri.Text = "Emri";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(87, 21);
            this.txtEmri.MaxLength = 32;
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(189, 20);
            this.txtEmri.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 56);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Location = new System.Drawing.Point(87, 127);
            this.txtFjalekalimi.MaxLength = 32;
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(189, 20);
            this.txtFjalekalimi.TabIndex = 11;
            this.txtFjalekalimi.UseSystemPasswordChar = true;
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.Location = new System.Drawing.Point(87, 91);
            this.txtPerdoruesi.MaxLength = 32;
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.Size = new System.Drawing.Size(189, 20);
            this.txtPerdoruesi.TabIndex = 10;
            // 
            // lblFjalekalimi
            // 
            this.lblFjalekalimi.AutoSize = true;
            this.lblFjalekalimi.Location = new System.Drawing.Point(16, 130);
            this.lblFjalekalimi.Name = "lblFjalekalimi";
            this.lblFjalekalimi.Size = new System.Drawing.Size(55, 13);
            this.lblFjalekalimi.TabIndex = 9;
            this.lblFjalekalimi.Text = "Fjalekalimi";
            // 
            // lblPerdoruesi
            // 
            this.lblPerdoruesi.AutoSize = true;
            this.lblPerdoruesi.Location = new System.Drawing.Point(16, 94);
            this.lblPerdoruesi.Name = "lblPerdoruesi";
            this.lblPerdoruesi.Size = new System.Drawing.Size(57, 13);
            this.lblPerdoruesi.TabIndex = 8;
            this.lblPerdoruesi.Text = "Perdoruesi";
            // 
            // txtRishkruajFjalekalimin
            // 
            this.txtRishkruajFjalekalimin.Location = new System.Drawing.Point(87, 163);
            this.txtRishkruajFjalekalimin.MaxLength = 32;
            this.txtRishkruajFjalekalimin.Name = "txtRishkruajFjalekalimin";
            this.txtRishkruajFjalekalimin.Size = new System.Drawing.Size(189, 20);
            this.txtRishkruajFjalekalimin.TabIndex = 13;
            this.txtRishkruajFjalekalimin.UseSystemPasswordChar = true;
            // 
            // lblRishkruajFjalekalimin
            // 
            this.lblRishkruajFjalekalimin.AutoSize = true;
            this.lblRishkruajFjalekalimin.Location = new System.Drawing.Point(16, 166);
            this.lblRishkruajFjalekalimin.Name = "lblRishkruajFjalekalimin";
            this.lblRishkruajFjalekalimin.Size = new System.Drawing.Size(58, 26);
            this.lblRishkruajFjalekalimin.TabIndex = 12;
            this.lblRishkruajFjalekalimin.Text = "Rishkruaj\r\nfjalekalimin";
            // 
            // pctFotoProfil
            // 
            this.pctFotoProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotoProfil.Image = global::DentalSoft.Properties.Resources.Ska_foto;
            this.pctFotoProfil.Location = new System.Drawing.Point(295, 21);
            this.pctFotoProfil.Name = "pctFotoProfil";
            this.pctFotoProfil.Size = new System.Drawing.Size(118, 125);
            this.pctFotoProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotoProfil.TabIndex = 16;
            this.pctFotoProfil.TabStop = false;
            // 
            // ofdShfletoFoto
            // 
            this.ofdShfletoFoto.FileName = "profilePhoto";
            this.ofdShfletoFoto.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // btnShfletoFoto
            // 
            this.btnShfletoFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShfletoFoto.Location = new System.Drawing.Point(295, 169);
            this.btnShfletoFoto.Name = "btnShfletoFoto";
            this.btnShfletoFoto.Size = new System.Drawing.Size(118, 23);
            this.btnShfletoFoto.TabIndex = 17;
            this.btnShfletoFoto.Text = "Shfleto";
            this.btnShfletoFoto.UseVisualStyleBackColor = true;
            this.btnShfletoFoto.Click += new System.EventHandler(this.btnShfletoFoto_Click);
            // 
            // lblEmriFajllit
            // 
            this.lblEmriFajllit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmriFajllit.Location = new System.Drawing.Point(295, 149);
            this.lblEmriFajllit.Name = "lblEmriFajllit";
            this.lblEmriFajllit.Size = new System.Drawing.Size(118, 17);
            this.lblEmriFajllit.TabIndex = 18;
            this.lblEmriFajllit.Text = "N/A";
            // 
            // lblPassowrdInformation
            // 
            this.lblPassowrdInformation.Location = new System.Drawing.Point(84, 192);
            this.lblPassowrdInformation.Name = "lblPassowrdInformation";
            this.lblPassowrdInformation.Size = new System.Drawing.Size(192, 29);
            this.lblPassowrdInformation.TabIndex = 19;
            this.lblPassowrdInformation.Text = "*Nese nuk doni te nderroni fjalekalimin leni fushat e zbrazeta";
            this.lblPassowrdInformation.Visible = false;
            // 
            // frmAddDentist
            // 
            this.AcceptButton = this.btnShtoDentist;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(430, 272);
            this.Controls.Add(this.lblPassowrdInformation);
            this.Controls.Add(this.lblEmriFajllit);
            this.Controls.Add(this.btnShfletoFoto);
            this.Controls.Add(this.pctFotoProfil);
            this.Controls.Add(this.txtRishkruajFjalekalimin);
            this.Controls.Add(this.lblRishkruajFjalekalimin);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.lblFjalekalimi);
            this.Controls.Add(this.lblPerdoruesi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnShtoDentist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddDentist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto dentist";
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShtoDentist;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalimi;
        private System.Windows.Forms.Label lblPerdoruesi;
        private System.Windows.Forms.TextBox txtRishkruajFjalekalimin;
        private System.Windows.Forms.Label lblRishkruajFjalekalimin;
        private System.Windows.Forms.PictureBox pctFotoProfil;
        private System.Windows.Forms.OpenFileDialog ofdShfletoFoto;
        private System.Windows.Forms.Button btnShfletoFoto;
        private System.Windows.Forms.Label lblEmriFajllit;
        private System.Windows.Forms.Label lblPassowrdInformation;

    }
}