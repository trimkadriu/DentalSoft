namespace DentalSoft
{
    partial class frmAddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAppointment));
            this.lblMosha = new System.Windows.Forms.Label();
            this.txtTelefoni = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefoni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmriPacientit = new System.Windows.Forms.TextBox();
            this.lblEmriPacientit = new System.Windows.Forms.Label();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.btnShtoTakim = new System.Windows.Forms.Button();
            this.txtProblemi = new System.Windows.Forms.TextBox();
            this.lblProblemi = new System.Windows.Forms.Label();
            this.txtKomenti = new System.Windows.Forms.TextBox();
            this.lblKomenti = new System.Windows.Forms.Label();
            this.dtpDataETakimit = new System.Windows.Forms.DateTimePicker();
            this.lblKohaETakimit = new System.Windows.Forms.Label();
            this.lblKohezgjatjaETakimit = new System.Windows.Forms.Label();
            this.nudKohezgjatjaETakimit = new System.Windows.Forms.NumericUpDown();
            this.lblMinNjehsia = new System.Windows.Forms.Label();
            this.pcbDhembetSiper = new System.Windows.Forms.PictureBox();
            this.pcbDhembetPoshte = new System.Windows.Forms.PictureBox();
            this.lblTitullDhembetSiper = new System.Windows.Forms.Label();
            this.lblTitullDhembetPoshte = new System.Windows.Forms.Label();
            this.lblHorizontalDivider = new System.Windows.Forms.Label();
            this.nudMosha = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatjaETakimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDhembetSiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDhembetPoshte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMosha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMosha
            // 
            this.lblMosha.AutoSize = true;
            this.lblMosha.Location = new System.Drawing.Point(12, 203);
            this.lblMosha.Name = "lblMosha";
            this.lblMosha.Size = new System.Drawing.Size(39, 13);
            this.lblMosha.TabIndex = 24;
            this.lblMosha.Text = "Mosha";
            // 
            // txtTelefoni
            // 
            this.txtTelefoni.Location = new System.Drawing.Point(126, 258);
            this.txtTelefoni.Name = "txtTelefoni";
            this.txtTelefoni.Size = new System.Drawing.Size(239, 20);
            this.txtTelefoni.TabIndex = 23;
            this.txtTelefoni.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // lblTelefoni
            // 
            this.lblTelefoni.AutoSize = true;
            this.lblTelefoni.Location = new System.Drawing.Point(12, 261);
            this.lblTelefoni.Name = "lblTelefoni";
            this.lblTelefoni.Size = new System.Drawing.Size(45, 13);
            this.lblTelefoni.TabIndex = 21;
            this.lblTelefoni.Text = "Telefoni";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmriPacientit
            // 
            this.txtEmriPacientit.Location = new System.Drawing.Point(126, 171);
            this.txtEmriPacientit.Name = "txtEmriPacientit";
            this.txtEmriPacientit.Size = new System.Drawing.Size(239, 20);
            this.txtEmriPacientit.TabIndex = 18;
            // 
            // lblEmriPacientit
            // 
            this.lblEmriPacientit.AutoSize = true;
            this.lblEmriPacientit.Location = new System.Drawing.Point(12, 174);
            this.lblEmriPacientit.Name = "lblEmriPacientit";
            this.lblEmriPacientit.Size = new System.Drawing.Size(75, 13);
            this.lblEmriPacientit.TabIndex = 16;
            this.lblEmriPacientit.Text = "Emri i pacientit";
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnulo.Location = new System.Drawing.Point(580, 373);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(75, 23);
            this.btnAnulo.TabIndex = 15;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
            // 
            // btnShtoTakim
            // 
            this.btnShtoTakim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoTakim.Location = new System.Drawing.Point(661, 373);
            this.btnShtoTakim.Name = "btnShtoTakim";
            this.btnShtoTakim.Size = new System.Drawing.Size(75, 23);
            this.btnShtoTakim.TabIndex = 14;
            this.btnShtoTakim.Text = "Shto takim";
            this.btnShtoTakim.UseVisualStyleBackColor = true;
            this.btnShtoTakim.Click += new System.EventHandler(this.btnShtoTakim_Click);
            // 
            // txtProblemi
            // 
            this.txtProblemi.Location = new System.Drawing.Point(497, 171);
            this.txtProblemi.Multiline = true;
            this.txtProblemi.Name = "txtProblemi";
            this.txtProblemi.Size = new System.Drawing.Size(239, 70);
            this.txtProblemi.TabIndex = 27;
            this.txtProblemi.UseSystemPasswordChar = true;
            // 
            // lblProblemi
            // 
            this.lblProblemi.Location = new System.Drawing.Point(381, 174);
            this.lblProblemi.Name = "lblProblemi";
            this.lblProblemi.Size = new System.Drawing.Size(107, 67);
            this.lblProblemi.TabIndex = 26;
            this.lblProblemi.Text = "Problemi\r\n(pershkruaj problemin dental)";
            // 
            // txtKomenti
            // 
            this.txtKomenti.Location = new System.Drawing.Point(497, 248);
            this.txtKomenti.Multiline = true;
            this.txtKomenti.Name = "txtKomenti";
            this.txtKomenti.Size = new System.Drawing.Size(239, 90);
            this.txtKomenti.TabIndex = 29;
            this.txtKomenti.UseSystemPasswordChar = true;
            // 
            // lblKomenti
            // 
            this.lblKomenti.Location = new System.Drawing.Point(381, 251);
            this.lblKomenti.Name = "lblKomenti";
            this.lblKomenti.Size = new System.Drawing.Size(107, 87);
            this.lblKomenti.TabIndex = 28;
            this.lblKomenti.Text = "Komenti shtese\r\n(pershkruaj nese keni ndonje semundje tjeter, alergji ose nese je" +
    "ni duke marre terapi)";
            // 
            // dtpDataETakimit
            // 
            this.dtpDataETakimit.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataETakimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataETakimit.Location = new System.Drawing.Point(126, 287);
            this.dtpDataETakimit.Name = "dtpDataETakimit";
            this.dtpDataETakimit.Size = new System.Drawing.Size(197, 20);
            this.dtpDataETakimit.TabIndex = 30;
            this.dtpDataETakimit.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            // 
            // lblKohaETakimit
            // 
            this.lblKohaETakimit.AutoSize = true;
            this.lblKohaETakimit.Location = new System.Drawing.Point(12, 293);
            this.lblKohaETakimit.Name = "lblKohaETakimit";
            this.lblKohaETakimit.Size = new System.Drawing.Size(72, 13);
            this.lblKohaETakimit.TabIndex = 31;
            this.lblKohaETakimit.Text = "Data e takimit";
            // 
            // lblKohezgjatjaETakimit
            // 
            this.lblKohezgjatjaETakimit.AutoSize = true;
            this.lblKohezgjatjaETakimit.Location = new System.Drawing.Point(12, 318);
            this.lblKohezgjatjaETakimit.Name = "lblKohezgjatjaETakimit";
            this.lblKohezgjatjaETakimit.Size = new System.Drawing.Size(104, 13);
            this.lblKohezgjatjaETakimit.TabIndex = 32;
            this.lblKohezgjatjaETakimit.Text = "Kohezgjatja e takimit";
            // 
            // nudKohezgjatjaETakimit
            // 
            this.nudKohezgjatjaETakimit.Location = new System.Drawing.Point(126, 316);
            this.nudKohezgjatjaETakimit.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudKohezgjatjaETakimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKohezgjatjaETakimit.Name = "nudKohezgjatjaETakimit";
            this.nudKohezgjatjaETakimit.Size = new System.Drawing.Size(85, 20);
            this.nudKohezgjatjaETakimit.TabIndex = 33;
            this.nudKohezgjatjaETakimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMinNjehsia
            // 
            this.lblMinNjehsia.AutoSize = true;
            this.lblMinNjehsia.Location = new System.Drawing.Point(217, 320);
            this.lblMinNjehsia.Name = "lblMinNjehsia";
            this.lblMinNjehsia.Size = new System.Drawing.Size(35, 13);
            this.lblMinNjehsia.TabIndex = 34;
            this.lblMinNjehsia.Text = "( min )";
            // 
            // pcbDhembetSiper
            // 
            this.pcbDhembetSiper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbDhembetSiper.Image = global::DentalSoft.Properties.Resources.Dhembet_lart;
            this.pcbDhembetSiper.Location = new System.Drawing.Point(10, 37);
            this.pcbDhembetSiper.Name = "pcbDhembetSiper";
            this.pcbDhembetSiper.Size = new System.Drawing.Size(365, 103);
            this.pcbDhembetSiper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDhembetSiper.TabIndex = 35;
            this.pcbDhembetSiper.TabStop = false;
            // 
            // pcbDhembetPoshte
            // 
            this.pcbDhembetPoshte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbDhembetPoshte.Image = global::DentalSoft.Properties.Resources.Dhembet_poshte;
            this.pcbDhembetPoshte.Location = new System.Drawing.Point(371, 37);
            this.pcbDhembetPoshte.Name = "pcbDhembetPoshte";
            this.pcbDhembetPoshte.Size = new System.Drawing.Size(365, 103);
            this.pcbDhembetPoshte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDhembetPoshte.TabIndex = 36;
            this.pcbDhembetPoshte.TabStop = false;
            // 
            // lblTitullDhembetSiper
            // 
            this.lblTitullDhembetSiper.AutoSize = true;
            this.lblTitullDhembetSiper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitullDhembetSiper.Location = new System.Drawing.Point(110, 10);
            this.lblTitullDhembetSiper.Name = "lblTitullDhembetSiper";
            this.lblTitullDhembetSiper.Size = new System.Drawing.Size(165, 24);
            this.lblTitullDhembetSiper.TabIndex = 37;
            this.lblTitullDhembetSiper.Text = "Dhembet e siperm";
            // 
            // lblTitullDhembetPoshte
            // 
            this.lblTitullDhembetPoshte.AutoSize = true;
            this.lblTitullDhembetPoshte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitullDhembetPoshte.Location = new System.Drawing.Point(463, 10);
            this.lblTitullDhembetPoshte.Name = "lblTitullDhembetPoshte";
            this.lblTitullDhembetPoshte.Size = new System.Drawing.Size(181, 24);
            this.lblTitullDhembetPoshte.TabIndex = 38;
            this.lblTitullDhembetPoshte.Text = "Dhembet e poshtem";
            // 
            // lblHorizontalDivider
            // 
            this.lblHorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalDivider.Location = new System.Drawing.Point(10, 155);
            this.lblHorizontalDivider.Name = "lblHorizontalDivider";
            this.lblHorizontalDivider.Size = new System.Drawing.Size(726, 2);
            this.lblHorizontalDivider.TabIndex = 39;
            // 
            // nudMosha
            // 
            this.nudMosha.Location = new System.Drawing.Point(126, 201);
            this.nudMosha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudMosha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMosha.Name = "nudMosha";
            this.nudMosha.Size = new System.Drawing.Size(85, 20);
            this.nudMosha.TabIndex = 40;
            this.nudMosha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmAddAppointment
            // 
            this.AcceptButton = this.btnShtoTakim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(748, 408);
            this.Controls.Add(this.nudMosha);
            this.Controls.Add(this.lblHorizontalDivider);
            this.Controls.Add(this.lblTitullDhembetPoshte);
            this.Controls.Add(this.lblTitullDhembetSiper);
            this.Controls.Add(this.pcbDhembetPoshte);
            this.Controls.Add(this.pcbDhembetSiper);
            this.Controls.Add(this.lblMinNjehsia);
            this.Controls.Add(this.nudKohezgjatjaETakimit);
            this.Controls.Add(this.lblKohezgjatjaETakimit);
            this.Controls.Add(this.lblKohaETakimit);
            this.Controls.Add(this.dtpDataETakimit);
            this.Controls.Add(this.txtKomenti);
            this.Controls.Add(this.lblKomenti);
            this.Controls.Add(this.txtProblemi);
            this.Controls.Add(this.lblProblemi);
            this.Controls.Add(this.lblMosha);
            this.Controls.Add(this.txtTelefoni);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefoni);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmriPacientit);
            this.Controls.Add(this.lblEmriPacientit);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnShtoTakim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto takim";
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatjaETakimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDhembetSiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDhembetPoshte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMosha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMosha;
        private System.Windows.Forms.TextBox txtTelefoni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefoni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmriPacientit;
        private System.Windows.Forms.Label lblEmriPacientit;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Button btnShtoTakim;
        private System.Windows.Forms.TextBox txtProblemi;
        private System.Windows.Forms.Label lblProblemi;
        private System.Windows.Forms.TextBox txtKomenti;
        private System.Windows.Forms.Label lblKomenti;
        private System.Windows.Forms.DateTimePicker dtpDataETakimit;
        private System.Windows.Forms.Label lblKohaETakimit;
        private System.Windows.Forms.Label lblKohezgjatjaETakimit;
        private System.Windows.Forms.NumericUpDown nudKohezgjatjaETakimit;
        private System.Windows.Forms.Label lblMinNjehsia;
        private System.Windows.Forms.PictureBox pcbDhembetSiper;
        private System.Windows.Forms.PictureBox pcbDhembetPoshte;
        private System.Windows.Forms.Label lblTitullDhembetSiper;
        private System.Windows.Forms.Label lblTitullDhembetPoshte;
        private System.Windows.Forms.Label lblHorizontalDivider;
        private System.Windows.Forms.NumericUpDown nudMosha;
    }
}