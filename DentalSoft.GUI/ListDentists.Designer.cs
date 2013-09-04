namespace DentalSoft
{
    partial class frmListDentists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDentists));
            this.lblTitulli = new System.Windows.Forms.Label();
            this.txtKerkoEmriMbiemri = new System.Windows.Forms.TextBox();
            this.lblKerkoEmri = new System.Windows.Forms.Label();
            this.dgvListaEDentisteve = new System.Windows.Forms.DataGridView();
            this.lblHorizontalDivider = new System.Windows.Forms.Label();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnMbylle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEDentisteve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Location = new System.Drawing.Point(12, 16);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(164, 13);
            this.lblTitulli.TabIndex = 0;
            this.lblTitulli.Text = "Kerkoni dentistet ne baze te emrit";
            // 
            // txtKerkoEmriMbiemri
            // 
            this.txtKerkoEmriMbiemri.Location = new System.Drawing.Point(48, 57);
            this.txtKerkoEmriMbiemri.Name = "txtKerkoEmriMbiemri";
            this.txtKerkoEmriMbiemri.Size = new System.Drawing.Size(204, 20);
            this.txtKerkoEmriMbiemri.TabIndex = 0;
            // 
            // lblKerkoEmri
            // 
            this.lblKerkoEmri.AutoSize = true;
            this.lblKerkoEmri.Location = new System.Drawing.Point(12, 60);
            this.lblKerkoEmri.Name = "lblKerkoEmri";
            this.lblKerkoEmri.Size = new System.Drawing.Size(30, 13);
            this.lblKerkoEmri.TabIndex = 2;
            this.lblKerkoEmri.Text = "Emri:";
            // 
            // dgvListaEDentisteve
            // 
            this.dgvListaEDentisteve.AllowUserToAddRows = false;
            this.dgvListaEDentisteve.AllowUserToDeleteRows = false;
            this.dgvListaEDentisteve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaEDentisteve.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaEDentisteve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEDentisteve.Location = new System.Drawing.Point(15, 89);
            this.dgvListaEDentisteve.MultiSelect = false;
            this.dgvListaEDentisteve.Name = "dgvListaEDentisteve";
            this.dgvListaEDentisteve.ReadOnly = true;
            this.dgvListaEDentisteve.RowHeadersVisible = false;
            this.dgvListaEDentisteve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEDentisteve.Size = new System.Drawing.Size(546, 239);
            this.dgvListaEDentisteve.TabIndex = 3;
            // 
            // lblHorizontalDivider
            // 
            this.lblHorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalDivider.Location = new System.Drawing.Point(15, 40);
            this.lblHorizontalDivider.Name = "lblHorizontalDivider";
            this.lblHorizontalDivider.Size = new System.Drawing.Size(546, 2);
            this.lblHorizontalDivider.TabIndex = 26;
            // 
            // btnFshij
            // 
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFshij.Location = new System.Drawing.Point(486, 339);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(75, 23);
            this.btnFshij.TabIndex = 2;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            // 
            // btnMbylle
            // 
            this.btnMbylle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbylle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMbylle.Location = new System.Drawing.Point(15, 339);
            this.btnMbylle.Name = "btnMbylle";
            this.btnMbylle.Size = new System.Drawing.Size(75, 23);
            this.btnMbylle.TabIndex = 3;
            this.btnMbylle.Text = "Mbylle";
            this.btnMbylle.UseVisualStyleBackColor = true;
            // 
            // frmListDentists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMbylle;
            this.ClientSize = new System.Drawing.Size(576, 375);
            this.Controls.Add(this.btnMbylle);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.lblHorizontalDivider);
            this.Controls.Add(this.dgvListaEDentisteve);
            this.Controls.Add(this.lblKerkoEmri);
            this.Controls.Add(this.txtKerkoEmriMbiemri);
            this.Controls.Add(this.lblTitulli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListDentists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listo dentistet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEDentisteve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.TextBox txtKerkoEmriMbiemri;
        private System.Windows.Forms.Label lblKerkoEmri;
        private System.Windows.Forms.DataGridView dgvListaEDentisteve;
        private System.Windows.Forms.Label lblHorizontalDivider;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnMbylle;
    }
}