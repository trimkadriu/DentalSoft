namespace DentalSoft
{
    partial class frmListAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListAppointments));
            this.dgvTakimet = new System.Windows.Forms.DataGridView();
            this.btnMbylle = new System.Windows.Forms.Button();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnEdito = new System.Windows.Forms.Button();
            this.lblHorizontalDivider = new System.Windows.Forms.Label();
            this.lblEmriPacientit = new System.Windows.Forms.Label();
            this.txtEmriPacientit = new System.Windows.Forms.TextBox();
            this.lblTitulli = new System.Windows.Forms.Label();
            this.lblDataETakimitPrej = new System.Windows.Forms.Label();
            this.dtpDataETakimitPrej = new System.Windows.Forms.DateTimePicker();
            this.lblDataETakimitDeri = new System.Windows.Forms.Label();
            this.dtpDataETakimitDeri = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakimet
            // 
            this.dgvTakimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakimet.Location = new System.Drawing.Point(15, 145);
            this.dgvTakimet.Name = "dgvTakimet";
            this.dgvTakimet.Size = new System.Drawing.Size(948, 375);
            this.dgvTakimet.TabIndex = 0;
            // 
            // btnMbylle
            // 
            this.btnMbylle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbylle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMbylle.Location = new System.Drawing.Point(15, 541);
            this.btnMbylle.Name = "btnMbylle";
            this.btnMbylle.Size = new System.Drawing.Size(75, 23);
            this.btnMbylle.TabIndex = 32;
            this.btnMbylle.Text = "Mbylle";
            this.btnMbylle.UseVisualStyleBackColor = true;
            this.btnMbylle.Click += new System.EventHandler(this.btnMbylle_Click);
            // 
            // btnFshij
            // 
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFshij.Location = new System.Drawing.Point(807, 541);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(75, 23);
            this.btnFshij.TabIndex = 31;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            // 
            // btnEdito
            // 
            this.btnEdito.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdito.Location = new System.Drawing.Point(888, 541);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.Size = new System.Drawing.Size(75, 23);
            this.btnEdito.TabIndex = 30;
            this.btnEdito.Text = "Edito";
            this.btnEdito.UseVisualStyleBackColor = true;
            // 
            // lblHorizontalDivider
            // 
            this.lblHorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalDivider.Location = new System.Drawing.Point(15, 39);
            this.lblHorizontalDivider.Name = "lblHorizontalDivider";
            this.lblHorizontalDivider.Size = new System.Drawing.Size(948, 2);
            this.lblHorizontalDivider.TabIndex = 36;
            // 
            // lblEmriPacientit
            // 
            this.lblEmriPacientit.AutoSize = true;
            this.lblEmriPacientit.Location = new System.Drawing.Point(12, 55);
            this.lblEmriPacientit.Name = "lblEmriPacientit";
            this.lblEmriPacientit.Size = new System.Drawing.Size(78, 13);
            this.lblEmriPacientit.TabIndex = 35;
            this.lblEmriPacientit.Text = "Emri i pacientit:";
            // 
            // txtEmriPacientit
            // 
            this.txtEmriPacientit.Location = new System.Drawing.Point(132, 52);
            this.txtEmriPacientit.Name = "txtEmriPacientit";
            this.txtEmriPacientit.Size = new System.Drawing.Size(198, 20);
            this.txtEmriPacientit.TabIndex = 34;
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Location = new System.Drawing.Point(12, 15);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(528, 13);
            this.lblTitulli.TabIndex = 33;
            this.lblTitulli.Text = "Si parametra per kerkim mund te perdorni Emrin e pacientit dhe/ose datat prej dhe" +
    " deri kur eshte caktuar takimi";
            // 
            // lblDataETakimitPrej
            // 
            this.lblDataETakimitPrej.AutoSize = true;
            this.lblDataETakimitPrej.Location = new System.Drawing.Point(12, 85);
            this.lblDataETakimitPrej.Name = "lblDataETakimitPrej";
            this.lblDataETakimitPrej.Size = new System.Drawing.Size(92, 13);
            this.lblDataETakimitPrej.TabIndex = 38;
            this.lblDataETakimitPrej.Text = "Data e takimit prej";
            // 
            // dtpDataETakimitPrej
            // 
            this.dtpDataETakimitPrej.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataETakimitPrej.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataETakimitPrej.Location = new System.Drawing.Point(132, 79);
            this.dtpDataETakimitPrej.Name = "dtpDataETakimitPrej";
            this.dtpDataETakimitPrej.Size = new System.Drawing.Size(197, 20);
            this.dtpDataETakimitPrej.TabIndex = 37;
            this.dtpDataETakimitPrej.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            // 
            // lblDataETakimitDeri
            // 
            this.lblDataETakimitDeri.AutoSize = true;
            this.lblDataETakimitDeri.Location = new System.Drawing.Point(12, 112);
            this.lblDataETakimitDeri.Name = "lblDataETakimitDeri";
            this.lblDataETakimitDeri.Size = new System.Drawing.Size(92, 13);
            this.lblDataETakimitDeri.TabIndex = 40;
            this.lblDataETakimitDeri.Text = "Data e takimit deri";
            // 
            // dtpDataETakimitDeri
            // 
            this.dtpDataETakimitDeri.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.dtpDataETakimitDeri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataETakimitDeri.Location = new System.Drawing.Point(132, 106);
            this.dtpDataETakimitDeri.Name = "dtpDataETakimitDeri";
            this.dtpDataETakimitDeri.Size = new System.Drawing.Size(197, 20);
            this.dtpDataETakimitDeri.TabIndex = 39;
            this.dtpDataETakimitDeri.Value = new System.DateTime(2013, 8, 28, 22, 43, 0, 0);
            // 
            // frmListAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMbylle;
            this.ClientSize = new System.Drawing.Size(975, 576);
            this.Controls.Add(this.lblDataETakimitDeri);
            this.Controls.Add(this.dtpDataETakimitDeri);
            this.Controls.Add(this.lblDataETakimitPrej);
            this.Controls.Add(this.dtpDataETakimitPrej);
            this.Controls.Add(this.lblHorizontalDivider);
            this.Controls.Add(this.lblEmriPacientit);
            this.Controls.Add(this.txtEmriPacientit);
            this.Controls.Add(this.lblTitulli);
            this.Controls.Add(this.btnMbylle);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnEdito);
            this.Controls.Add(this.dgvTakimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listo takimet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakimet;
        private System.Windows.Forms.Button btnMbylle;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnEdito;
        private System.Windows.Forms.Label lblHorizontalDivider;
        private System.Windows.Forms.Label lblEmriPacientit;
        private System.Windows.Forms.TextBox txtEmriPacientit;
        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.Label lblDataETakimitPrej;
        private System.Windows.Forms.DateTimePicker dtpDataETakimitPrej;
        private System.Windows.Forms.Label lblDataETakimitDeri;
        private System.Windows.Forms.DateTimePicker dtpDataETakimitDeri;
    }
}