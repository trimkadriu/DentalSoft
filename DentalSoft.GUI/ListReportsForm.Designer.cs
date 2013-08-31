namespace DentalSoft
{
    partial class frmListReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListReports));
            this.btnMbylle = new System.Windows.Forms.Button();
            this.lblDataETakimitDeri = new System.Windows.Forms.Label();
            this.dtpDataERaporteveDeri = new System.Windows.Forms.DateTimePicker();
            this.lblDataETakimitPrej = new System.Windows.Forms.Label();
            this.dtpDataERaportevePrej = new System.Windows.Forms.DateTimePicker();
            this.lblHorizontalDivider = new System.Windows.Forms.Label();
            this.lblEmriPacientit = new System.Windows.Forms.Label();
            this.txtEmriPacientit = new System.Windows.Forms.TextBox();
            this.lblTitulli = new System.Windows.Forms.Label();
            this.dgvRaportet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMbylle
            // 
            this.btnMbylle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbylle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMbylle.Location = new System.Drawing.Point(12, 533);
            this.btnMbylle.Name = "btnMbylle";
            this.btnMbylle.Size = new System.Drawing.Size(75, 23);
            this.btnMbylle.TabIndex = 33;
            this.btnMbylle.Text = "Mbylle";
            this.btnMbylle.UseVisualStyleBackColor = true;
            this.btnMbylle.Click += new System.EventHandler(this.btnMbylle_Click);
            // 
            // lblDataETakimitDeri
            // 
            this.lblDataETakimitDeri.AutoSize = true;
            this.lblDataETakimitDeri.Location = new System.Drawing.Point(12, 113);
            this.lblDataETakimitDeri.Name = "lblDataETakimitDeri";
            this.lblDataETakimitDeri.Size = new System.Drawing.Size(107, 13);
            this.lblDataETakimitDeri.TabIndex = 48;
            this.lblDataETakimitDeri.Text = "Data e raporteve deri";
            // 
            // dtpDataERaporteveDeri
            // 
            this.dtpDataERaporteveDeri.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataERaporteveDeri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataERaporteveDeri.Location = new System.Drawing.Point(132, 107);
            this.dtpDataERaporteveDeri.Name = "dtpDataERaporteveDeri";
            this.dtpDataERaporteveDeri.Size = new System.Drawing.Size(197, 20);
            this.dtpDataERaporteveDeri.TabIndex = 47;
            this.dtpDataERaporteveDeri.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            // 
            // lblDataETakimitPrej
            // 
            this.lblDataETakimitPrej.AutoSize = true;
            this.lblDataETakimitPrej.Location = new System.Drawing.Point(12, 86);
            this.lblDataETakimitPrej.Name = "lblDataETakimitPrej";
            this.lblDataETakimitPrej.Size = new System.Drawing.Size(107, 13);
            this.lblDataETakimitPrej.TabIndex = 46;
            this.lblDataETakimitPrej.Text = "Data e raporteve prej";
            // 
            // dtpDataERaportevePrej
            // 
            this.dtpDataERaportevePrej.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataERaportevePrej.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataERaportevePrej.Location = new System.Drawing.Point(132, 80);
            this.dtpDataERaportevePrej.Name = "dtpDataERaportevePrej";
            this.dtpDataERaportevePrej.Size = new System.Drawing.Size(197, 20);
            this.dtpDataERaportevePrej.TabIndex = 45;
            this.dtpDataERaportevePrej.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            // 
            // lblHorizontalDivider
            // 
            this.lblHorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalDivider.Location = new System.Drawing.Point(15, 40);
            this.lblHorizontalDivider.Name = "lblHorizontalDivider";
            this.lblHorizontalDivider.Size = new System.Drawing.Size(948, 2);
            this.lblHorizontalDivider.TabIndex = 44;
            // 
            // lblEmriPacientit
            // 
            this.lblEmriPacientit.AutoSize = true;
            this.lblEmriPacientit.Location = new System.Drawing.Point(12, 56);
            this.lblEmriPacientit.Name = "lblEmriPacientit";
            this.lblEmriPacientit.Size = new System.Drawing.Size(78, 13);
            this.lblEmriPacientit.TabIndex = 43;
            this.lblEmriPacientit.Text = "Emri i pacientit:";
            // 
            // txtEmriPacientit
            // 
            this.txtEmriPacientit.Location = new System.Drawing.Point(132, 53);
            this.txtEmriPacientit.Name = "txtEmriPacientit";
            this.txtEmriPacientit.Size = new System.Drawing.Size(198, 20);
            this.txtEmriPacientit.TabIndex = 42;
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Location = new System.Drawing.Point(12, 16);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(535, 13);
            this.lblTitulli.TabIndex = 41;
            this.lblTitulli.Text = "Si parametra per kerkim mund te perdorni Emrin e pacientit dhe/ose datat prej dhe" +
    " deri kur eshtegjeneruar raporti";
            // 
            // dgvRaportet
            // 
            this.dgvRaportet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaportet.Location = new System.Drawing.Point(12, 142);
            this.dgvRaportet.Name = "dgvRaportet";
            this.dgvRaportet.Size = new System.Drawing.Size(948, 375);
            this.dgvRaportet.TabIndex = 49;
            // 
            // frmListReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMbylle;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.dgvRaportet);
            this.Controls.Add(this.lblDataETakimitDeri);
            this.Controls.Add(this.dtpDataERaporteveDeri);
            this.Controls.Add(this.lblDataETakimitPrej);
            this.Controls.Add(this.dtpDataERaportevePrej);
            this.Controls.Add(this.lblHorizontalDivider);
            this.Controls.Add(this.lblEmriPacientit);
            this.Controls.Add(this.txtEmriPacientit);
            this.Controls.Add(this.lblTitulli);
            this.Controls.Add(this.btnMbylle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmListReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listo raportet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMbylle;
        private System.Windows.Forms.Label lblDataETakimitDeri;
        private System.Windows.Forms.DateTimePicker dtpDataERaporteveDeri;
        private System.Windows.Forms.Label lblDataETakimitPrej;
        private System.Windows.Forms.DateTimePicker dtpDataERaportevePrej;
        private System.Windows.Forms.Label lblHorizontalDivider;
        private System.Windows.Forms.Label lblEmriPacientit;
        private System.Windows.Forms.TextBox txtEmriPacientit;
        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.DataGridView dgvRaportet;
    }
}