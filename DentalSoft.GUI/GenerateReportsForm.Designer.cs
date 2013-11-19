using DentalSoft.Domain.Enums;
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
            this.lblPagesa = new System.Windows.Forms.Label();
            this.cmbTakimiTjeterStatus = new System.Windows.Forms.ComboBox();
            this.lblTakimiTjeterStatus = new System.Windows.Forms.Label();
            this.lblMonedha = new System.Windows.Forms.Label();
            this.nudPagesa = new System.Windows.Forms.NumericUpDown();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.btnGjeneroRaport = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.nudKohezgjatja = new System.Windows.Forms.NumericUpDown();
            this.lblKohezgjatjaETakimit = new System.Windows.Forms.Label();
            this.lblKohaETakimit = new System.Windows.Forms.Label();
            this.dtpDataETakimitTjeter = new System.Windows.Forms.DateTimePicker();
            this.txtProblemi = new System.Windows.Forms.TextBox();
            this.lblProblemi = new System.Windows.Forms.Label();
            this.txtOret = new System.Windows.Forms.TextBox();
            this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
            this.rtbRaport = new System.Windows.Forms.RichTextBox();
            this.lblVerticalDivider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPagesa
            // 
            this.lblPagesa.AutoSize = true;
            this.lblPagesa.Location = new System.Drawing.Point(12, 15);
            this.lblPagesa.Name = "lblPagesa";
            this.lblPagesa.Size = new System.Drawing.Size(43, 13);
            this.lblPagesa.TabIndex = 32;
            this.lblPagesa.Text = "Pagesa";
            // 
            // cmbTakimiTjeterStatus
            // 
            this.cmbTakimiTjeterStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTakimiTjeterStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTakimiTjeterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTakimiTjeterStatus.Items.AddRange(new object[] {
            DentalSoft.Domain.Enums.TakimiRiStatus.Po,
            DentalSoft.Domain.Enums.TakimiRiStatus.Jo,
            DentalSoft.Domain.Enums.TakimiRiStatus.Pacaktuar});
            this.cmbTakimiTjeterStatus.Location = new System.Drawing.Point(125, 48);
            this.cmbTakimiTjeterStatus.Name = "cmbTakimiTjeterStatus";
            this.cmbTakimiTjeterStatus.Size = new System.Drawing.Size(198, 21);
            this.cmbTakimiTjeterStatus.TabIndex = 1;
            this.cmbTakimiTjeterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbTakimiTjeterStatus_SelectedIndexChanged);
            // 
            // lblTakimiTjeterStatus
            // 
            this.lblTakimiTjeterStatus.Location = new System.Drawing.Point(12, 51);
            this.lblTakimiTjeterStatus.Name = "lblTakimiTjeterStatus";
            this.lblTakimiTjeterStatus.Size = new System.Drawing.Size(101, 26);
            this.lblTakimiTjeterStatus.TabIndex = 35;
            this.lblTakimiTjeterStatus.Text = "Duhet te caktoje takim tjeter";
            // 
            // lblMonedha
            // 
            this.lblMonedha.AutoSize = true;
            this.lblMonedha.Location = new System.Drawing.Point(256, 15);
            this.lblMonedha.Name = "lblMonedha";
            this.lblMonedha.Size = new System.Drawing.Size(25, 13);
            this.lblMonedha.TabIndex = 39;
            this.lblMonedha.Text = "( € )";
            // 
            // nudPagesa
            // 
            this.nudPagesa.DecimalPlaces = 2;
            this.nudPagesa.Location = new System.Drawing.Point(125, 13);
            this.nudPagesa.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPagesa.Name = "nudPagesa";
            this.nudPagesa.Size = new System.Drawing.Size(126, 20);
            this.nudPagesa.TabIndex = 0;
            this.nudPagesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPagesa.ThousandsSeparator = true;
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnulo.Location = new System.Drawing.Point(142, 239);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(75, 23);
            this.btnAnulo.TabIndex = 6;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            // 
            // btnGjeneroRaport
            // 
            this.btnGjeneroRaport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGjeneroRaport.Location = new System.Drawing.Point(223, 239);
            this.btnGjeneroRaport.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.btnGjeneroRaport.Name = "btnGjeneroRaport";
            this.btnGjeneroRaport.Size = new System.Drawing.Size(100, 23);
            this.btnGjeneroRaport.TabIndex = 5;
            this.btnGjeneroRaport.Text = "Gjenero raport";
            this.btnGjeneroRaport.UseVisualStyleBackColor = true;
            this.btnGjeneroRaport.Click += new System.EventHandler(this.btnGjeneroRaport_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(128, 122);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(35, 13);
            this.lblMin.TabIndex = 50;
            this.lblMin.Text = "( min )";
            this.lblMin.Visible = false;
            // 
            // nudKohezgjatja
            // 
            this.nudKohezgjatja.Location = new System.Drawing.Point(125, 119);
            this.nudKohezgjatja.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudKohezgjatja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKohezgjatja.Name = "nudKohezgjatja";
            this.nudKohezgjatja.Size = new System.Drawing.Size(92, 20);
            this.nudKohezgjatja.TabIndex = 3;
            this.nudKohezgjatja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKohezgjatja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKohezgjatja.Visible = false;
            this.nudKohezgjatja.ValueChanged += new System.EventHandler(this.nudKohezgjatja_ValueChanged);
            // 
            // lblKohezgjatjaETakimit
            // 
            this.lblKohezgjatjaETakimit.AutoSize = true;
            this.lblKohezgjatjaETakimit.Location = new System.Drawing.Point(12, 121);
            this.lblKohezgjatjaETakimit.Name = "lblKohezgjatjaETakimit";
            this.lblKohezgjatjaETakimit.Size = new System.Drawing.Size(104, 13);
            this.lblKohezgjatjaETakimit.TabIndex = 49;
            this.lblKohezgjatjaETakimit.Text = "Kohezgjatja e takimit";
            this.lblKohezgjatjaETakimit.Visible = false;
            // 
            // lblKohaETakimit
            // 
            this.lblKohaETakimit.AutoSize = true;
            this.lblKohaETakimit.Location = new System.Drawing.Point(12, 90);
            this.lblKohaETakimit.Name = "lblKohaETakimit";
            this.lblKohaETakimit.Size = new System.Drawing.Size(72, 13);
            this.lblKohaETakimit.TabIndex = 48;
            this.lblKohaETakimit.Text = "Data e takimit";
            this.lblKohaETakimit.Visible = false;
            // 
            // dtpDataETakimitTjeter
            // 
            this.dtpDataETakimitTjeter.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataETakimitTjeter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataETakimitTjeter.Location = new System.Drawing.Point(125, 84);
            this.dtpDataETakimitTjeter.Name = "dtpDataETakimitTjeter";
            this.dtpDataETakimitTjeter.Size = new System.Drawing.Size(198, 20);
            this.dtpDataETakimitTjeter.TabIndex = 2;
            this.dtpDataETakimitTjeter.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            this.dtpDataETakimitTjeter.Visible = false;
            // 
            // txtProblemi
            // 
            this.txtProblemi.Location = new System.Drawing.Point(125, 154);
            this.txtProblemi.MaxLength = 512;
            this.txtProblemi.Multiline = true;
            this.txtProblemi.Name = "txtProblemi";
            this.txtProblemi.Size = new System.Drawing.Size(198, 70);
            this.txtProblemi.TabIndex = 4;
            this.txtProblemi.UseSystemPasswordChar = true;
            this.txtProblemi.Visible = false;
            // 
            // lblProblemi
            // 
            this.lblProblemi.Location = new System.Drawing.Point(12, 157);
            this.lblProblemi.Name = "lblProblemi";
            this.lblProblemi.Size = new System.Drawing.Size(107, 67);
            this.lblProblemi.TabIndex = 52;
            this.lblProblemi.Text = "Problemi\r\n(pershkruaj problemin dental)";
            this.lblProblemi.Visible = false;
            // 
            // txtOret
            // 
            this.txtOret.Location = new System.Drawing.Point(223, 119);
            this.txtOret.Name = "txtOret";
            this.txtOret.ReadOnly = true;
            this.txtOret.Size = new System.Drawing.Size(100, 20);
            this.txtOret.TabIndex = 54;
            this.txtOret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOret.Visible = false;
            // 
            // ItemTemplate
            // 
            this.ItemTemplate.Size = new System.Drawing.Size(232, 136);
            // 
            // rtbRaport
            // 
            this.rtbRaport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbRaport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRaport.Location = new System.Drawing.Point(354, 15);
            this.rtbRaport.Name = "rtbRaport";
            this.rtbRaport.ReadOnly = true;
            this.rtbRaport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbRaport.Size = new System.Drawing.Size(367, 520);
            this.rtbRaport.TabIndex = 56;
            this.rtbRaport.Text = "";
            // 
            // lblVerticalDivider
            // 
            this.lblVerticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVerticalDivider.Location = new System.Drawing.Point(338, 13);
            this.lblVerticalDivider.Name = "lblVerticalDivider";
            this.lblVerticalDivider.Size = new System.Drawing.Size(2, 520);
            this.lblVerticalDivider.TabIndex = 57;
            // 
            // frmGenerateReport
            // 
            this.AcceptButton = this.btnGjeneroRaport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(734, 547);
            this.Controls.Add(this.lblVerticalDivider);
            this.Controls.Add(this.rtbRaport);
            this.Controls.Add(this.txtOret);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnGjeneroRaport);
            this.Controls.Add(this.txtProblemi);
            this.Controls.Add(this.lblProblemi);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudKohezgjatja);
            this.Controls.Add(this.lblKohezgjatjaETakimit);
            this.Controls.Add(this.lblKohaETakimit);
            this.Controls.Add(this.dtpDataETakimitTjeter);
            this.Controls.Add(this.lblMonedha);
            this.Controls.Add(this.nudPagesa);
            this.Controls.Add(this.lblTakimiTjeterStatus);
            this.Controls.Add(this.cmbTakimiTjeterStatus);
            this.Controls.Add(this.lblPagesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gjenero raport";
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKohezgjatja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagesa;
        private System.Windows.Forms.ComboBox cmbTakimiTjeterStatus;
        private System.Windows.Forms.Label lblTakimiTjeterStatus;
        private System.Windows.Forms.Label lblMonedha;
        private System.Windows.Forms.NumericUpDown nudPagesa;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Button btnGjeneroRaport;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudKohezgjatja;
        private System.Windows.Forms.Label lblKohezgjatjaETakimit;
        private System.Windows.Forms.Label lblKohaETakimit;
        private System.Windows.Forms.DateTimePicker dtpDataETakimitTjeter;
        private System.Windows.Forms.TextBox txtProblemi;
        private System.Windows.Forms.Label lblProblemi;
        private System.Windows.Forms.TextBox txtOret;
        private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
        private System.Windows.Forms.RichTextBox rtbRaport;
        private System.Windows.Forms.Label lblVerticalDivider;
    }
}