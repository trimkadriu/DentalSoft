namespace DentalSoft
{
    partial class frmGenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateReport));
            this.lblMosha = new System.Windows.Forms.Label();
            this.txtEmriPacientit = new System.Windows.Forms.TextBox();
            this.lblEmriPacientit = new System.Windows.Forms.Label();
            this.txtProblemi = new System.Windows.Forms.TextBox();
            this.lblProblemi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKohaETakimit = new System.Windows.Forms.Label();
            this.dtpDataETakimit = new System.Windows.Forms.DateTimePicker();
            this.lblMinNjehsia = new System.Windows.Forms.Label();
            this.nudKohezgjatjaETakimit = new System.Windows.Forms.NumericUpDown();
            this.nudMosha = new System.Windows.Forms.NumericUpDown();
            this.lblGjinia = new System.Windows.Forms.Label();
            this.cbGjinia = new System.Windows.Forms.ComboBox();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.btnGjeneroRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatjaETakimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMosha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMosha
            // 
            this.lblMosha.AutoSize = true;
            this.lblMosha.Location = new System.Drawing.Point(13, 44);
            this.lblMosha.Name = "lblMosha";
            this.lblMosha.Size = new System.Drawing.Size(39, 13);
            this.lblMosha.TabIndex = 28;
            this.lblMosha.Text = "Mosha";
            // 
            // txtEmriPacientit
            // 
            this.txtEmriPacientit.Location = new System.Drawing.Point(127, 14);
            this.txtEmriPacientit.Name = "txtEmriPacientit";
            this.txtEmriPacientit.Size = new System.Drawing.Size(239, 20);
            this.txtEmriPacientit.TabIndex = 27;
            // 
            // lblEmriPacientit
            // 
            this.lblEmriPacientit.AutoSize = true;
            this.lblEmriPacientit.Location = new System.Drawing.Point(13, 17);
            this.lblEmriPacientit.Name = "lblEmriPacientit";
            this.lblEmriPacientit.Size = new System.Drawing.Size(75, 13);
            this.lblEmriPacientit.TabIndex = 26;
            this.lblEmriPacientit.Text = "Emri i pacientit";
            // 
            // txtProblemi
            // 
            this.txtProblemi.Location = new System.Drawing.Point(127, 95);
            this.txtProblemi.Multiline = true;
            this.txtProblemi.Name = "txtProblemi";
            this.txtProblemi.Size = new System.Drawing.Size(239, 70);
            this.txtProblemi.TabIndex = 31;
            this.txtProblemi.UseSystemPasswordChar = true;
            // 
            // lblProblemi
            // 
            this.lblProblemi.Location = new System.Drawing.Point(13, 98);
            this.lblProblemi.Name = "lblProblemi";
            this.lblProblemi.Size = new System.Drawing.Size(107, 67);
            this.lblProblemi.TabIndex = 30;
            this.lblProblemi.Text = "Problemi\r\n(pershkruaj problemin dental)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pagesa (ne vlere)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Duhet te vije ne \r\nkontroll perseri";
            // 
            // lblKohaETakimit
            // 
            this.lblKohaETakimit.AutoSize = true;
            this.lblKohaETakimit.Location = new System.Drawing.Point(13, 246);
            this.lblKohaETakimit.Name = "lblKohaETakimit";
            this.lblKohaETakimit.Size = new System.Drawing.Size(84, 26);
            this.lblKohaETakimit.TabIndex = 37;
            this.lblKohaETakimit.Text = "Data e kontrollit \r\nte ardhshem";
            this.lblKohaETakimit.Visible = false;
            // 
            // dtpDataETakimit
            // 
            this.dtpDataETakimit.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataETakimit.Enabled = false;
            this.dtpDataETakimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataETakimit.Location = new System.Drawing.Point(127, 249);
            this.dtpDataETakimit.Name = "dtpDataETakimit";
            this.dtpDataETakimit.Size = new System.Drawing.Size(197, 20);
            this.dtpDataETakimit.TabIndex = 36;
            this.dtpDataETakimit.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            this.dtpDataETakimit.Visible = false;
            // 
            // lblMinNjehsia
            // 
            this.lblMinNjehsia.AutoSize = true;
            this.lblMinNjehsia.Location = new System.Drawing.Point(259, 179);
            this.lblMinNjehsia.Name = "lblMinNjehsia";
            this.lblMinNjehsia.Size = new System.Drawing.Size(25, 13);
            this.lblMinNjehsia.TabIndex = 39;
            this.lblMinNjehsia.Text = "( € )";
            // 
            // nudKohezgjatjaETakimit
            // 
            this.nudKohezgjatjaETakimit.DecimalPlaces = 2;
            this.nudKohezgjatjaETakimit.Location = new System.Drawing.Point(127, 177);
            this.nudKohezgjatjaETakimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudKohezgjatjaETakimit.Name = "nudKohezgjatjaETakimit";
            this.nudKohezgjatjaETakimit.Size = new System.Drawing.Size(126, 20);
            this.nudKohezgjatjaETakimit.TabIndex = 38;
            this.nudKohezgjatjaETakimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKohezgjatjaETakimit.ThousandsSeparator = true;
            // 
            // nudMosha
            // 
            this.nudMosha.Location = new System.Drawing.Point(127, 42);
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
            this.nudMosha.TabIndex = 41;
            this.nudMosha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGjinia
            // 
            this.lblGjinia.AutoSize = true;
            this.lblGjinia.Location = new System.Drawing.Point(13, 71);
            this.lblGjinia.Name = "lblGjinia";
            this.lblGjinia.Size = new System.Drawing.Size(33, 13);
            this.lblGjinia.TabIndex = 42;
            this.lblGjinia.Text = "Gjinia";
            // 
            // cbGjinia
            // 
            this.cbGjinia.FormattingEnabled = true;
            this.cbGjinia.Location = new System.Drawing.Point(127, 68);
            this.cbGjinia.Name = "cbGjinia";
            this.cbGjinia.Size = new System.Drawing.Size(157, 21);
            this.cbGjinia.TabIndex = 43;
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnulo.Location = new System.Drawing.Point(181, 287);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(75, 23);
            this.btnAnulo.TabIndex = 45;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            // 
            // btnGjeneroRaport
            // 
            this.btnGjeneroRaport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGjeneroRaport.Location = new System.Drawing.Point(262, 287);
            this.btnGjeneroRaport.Name = "btnGjeneroRaport";
            this.btnGjeneroRaport.Size = new System.Drawing.Size(104, 23);
            this.btnGjeneroRaport.TabIndex = 44;
            this.btnGjeneroRaport.Text = "Gjenero raport";
            this.btnGjeneroRaport.UseVisualStyleBackColor = true;
            // 
            // frmGenerateReport
            // 
            this.AcceptButton = this.btnGjeneroRaport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(381, 324);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnGjeneroRaport);
            this.Controls.Add(this.cbGjinia);
            this.Controls.Add(this.lblGjinia);
            this.Controls.Add(this.nudMosha);
            this.Controls.Add(this.lblMinNjehsia);
            this.Controls.Add(this.nudKohezgjatjaETakimit);
            this.Controls.Add(this.lblKohaETakimit);
            this.Controls.Add(this.dtpDataETakimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProblemi);
            this.Controls.Add(this.lblProblemi);
            this.Controls.Add(this.lblMosha);
            this.Controls.Add(this.txtEmriPacientit);
            this.Controls.Add(this.lblEmriPacientit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gjenero raport";
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatjaETakimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMosha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMosha;
        private System.Windows.Forms.TextBox txtEmriPacientit;
        private System.Windows.Forms.Label lblEmriPacientit;
        private System.Windows.Forms.TextBox txtProblemi;
        private System.Windows.Forms.Label lblProblemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKohaETakimit;
        private System.Windows.Forms.DateTimePicker dtpDataETakimit;
        private System.Windows.Forms.Label lblMinNjehsia;
        private System.Windows.Forms.NumericUpDown nudKohezgjatjaETakimit;
        private System.Windows.Forms.NumericUpDown nudMosha;
        private System.Windows.Forms.Label lblGjinia;
        private System.Windows.Forms.ComboBox cbGjinia;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Button btnGjeneroRaport;
    }
}