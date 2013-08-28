namespace DentalSoft
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFillimi = new System.Windows.Forms.ToolStripMenuItem();
            this.shkyquToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDalje = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menaxhoDentistetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoDentistetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takimetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menaxhoTakimetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoTakimetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjeneroDiagnozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoDiagnozatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNdihma = new System.Windows.Forms.ToolStripMenuItem();
            this.miRrethDentalSoft = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDataKoha = new System.Windows.Forms.Label();
            this.pctUserProfile = new System.Windows.Forms.PictureBox();
            this.lblQasjaEFundit = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfili = new System.Windows.Forms.Button();
            this.dgvNextAppointments = new System.Windows.Forms.DataGridView();
            this.btnListoTakimet = new System.Windows.Forms.Button();
            this.btnShtoTakim = new System.Windows.Forms.Button();
            this.btnListoDentistet = new System.Windows.Forms.Button();
            this.btnShtoDentist = new System.Windows.Forms.Button();
            this.dgvDentistet = new System.Windows.Forms.DataGridView();
            this.grbTeDhena = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSotPagesat = new System.Windows.Forms.Label();
            this.lblSotDiagnozat = new System.Windows.Forms.Label();
            this.lblSotTakimet = new System.Windows.Forms.Label();
            this.lblFitimiSot = new System.Windows.Forms.Label();
            this.lblGjithsejDiagnozatSot = new System.Windows.Forms.Label();
            this.lblGjithsejTakimeSot = new System.Windows.Forms.Label();
            this.pctHeader = new System.Windows.Forms.PictureBox();
            this.lblVerticalDivider = new System.Windows.Forms.Label();
            this.grbTakimet = new System.Windows.Forms.GroupBox();
            this.grbDentistet = new System.Windows.Forms.GroupBox();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistet)).BeginInit();
            this.grbTeDhena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHeader)).BeginInit();
            this.grbTakimet.SuspendLayout();
            this.grbDentistet.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFillimi,
            this.dentistetToolStripMenuItem,
            this.takimetToolStripMenuItem,
            this.raportetToolStripMenuItem,
            this.miNdihma});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(706, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "mainMenu";
            // 
            // miFillimi
            // 
            this.miFillimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shkyquToolStripMenuItem,
            this.miDalje});
            this.miFillimi.Name = "miFillimi";
            this.miFillimi.Size = new System.Drawing.Size(51, 20);
            this.miFillimi.Text = "&Fillimi";
            // 
            // shkyquToolStripMenuItem
            // 
            this.shkyquToolStripMenuItem.Name = "shkyquToolStripMenuItem";
            this.shkyquToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.shkyquToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.shkyquToolStripMenuItem.Text = "&Shkyqu";
            this.shkyquToolStripMenuItem.Click += new System.EventHandler(this.shkyquToolStripMenuItem_Click);
            // 
            // miDalje
            // 
            this.miDalje.Name = "miDalje";
            this.miDalje.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.miDalje.Size = new System.Drawing.Size(153, 22);
            this.miDalje.Text = "&Dalje";
            this.miDalje.Click += new System.EventHandler(this.miDalje_Click);
            // 
            // dentistetToolStripMenuItem
            // 
            this.dentistetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menaxhoDentistetToolStripMenuItem,
            this.listoDentistetToolStripMenuItem});
            this.dentistetToolStripMenuItem.Name = "dentistetToolStripMenuItem";
            this.dentistetToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dentistetToolStripMenuItem.Text = "Dentistet";
            // 
            // menaxhoDentistetToolStripMenuItem
            // 
            this.menaxhoDentistetToolStripMenuItem.Name = "menaxhoDentistetToolStripMenuItem";
            this.menaxhoDentistetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.menaxhoDentistetToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.menaxhoDentistetToolStripMenuItem.Text = "Shto nje dentist";
            this.menaxhoDentistetToolStripMenuItem.Click += new System.EventHandler(this.menaxhoDentistetToolStripMenuItem_Click);
            // 
            // listoDentistetToolStripMenuItem
            // 
            this.listoDentistetToolStripMenuItem.Name = "listoDentistetToolStripMenuItem";
            this.listoDentistetToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listoDentistetToolStripMenuItem.Text = "Listo dentistet";
            // 
            // takimetToolStripMenuItem
            // 
            this.takimetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menaxhoTakimetToolStripMenuItem,
            this.listoTakimetToolStripMenuItem});
            this.takimetToolStripMenuItem.Name = "takimetToolStripMenuItem";
            this.takimetToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.takimetToolStripMenuItem.Text = "Takimet";
            // 
            // menaxhoTakimetToolStripMenuItem
            // 
            this.menaxhoTakimetToolStripMenuItem.Name = "menaxhoTakimetToolStripMenuItem";
            this.menaxhoTakimetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.menaxhoTakimetToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.menaxhoTakimetToolStripMenuItem.Text = "Shto nje takim";
            // 
            // listoTakimetToolStripMenuItem
            // 
            this.listoTakimetToolStripMenuItem.Name = "listoTakimetToolStripMenuItem";
            this.listoTakimetToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listoTakimetToolStripMenuItem.Text = "Listo takimet";
            // 
            // raportetToolStripMenuItem
            // 
            this.raportetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gjeneroDiagnozeToolStripMenuItem,
            this.listoDiagnozatToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.raportetToolStripMenuItem.Name = "raportetToolStripMenuItem";
            this.raportetToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.raportetToolStripMenuItem.Text = "Raportet";
            // 
            // gjeneroDiagnozeToolStripMenuItem
            // 
            this.gjeneroDiagnozeToolStripMenuItem.Name = "gjeneroDiagnozeToolStripMenuItem";
            this.gjeneroDiagnozeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gjeneroDiagnozeToolStripMenuItem.Text = "Gjenero diagnoze";
            // 
            // listoDiagnozatToolStripMenuItem
            // 
            this.listoDiagnozatToolStripMenuItem.Name = "listoDiagnozatToolStripMenuItem";
            this.listoDiagnozatToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listoDiagnozatToolStripMenuItem.Text = "Listo diagnozat";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // miNdihma
            // 
            this.miNdihma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRrethDentalSoft});
            this.miNdihma.Name = "miNdihma";
            this.miNdihma.Size = new System.Drawing.Size(62, 20);
            this.miNdihma.Text = "&Ndihma";
            // 
            // miRrethDentalSoft
            // 
            this.miRrethDentalSoft.Name = "miRrethDentalSoft";
            this.miRrethDentalSoft.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miRrethDentalSoft.Size = new System.Drawing.Size(185, 22);
            this.miRrethDentalSoft.Text = "&Rreth aplikacionit";
            this.miRrethDentalSoft.Click += new System.EventHandler(this.miRrethDentalSoft_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(16, 144);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(122, 15);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "( Emri Mbiemri )";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDataKoha
            // 
            this.lblDataKoha.Location = new System.Drawing.Point(14, 348);
            this.lblDataKoha.Name = "lblDataKoha";
            this.lblDataKoha.Size = new System.Drawing.Size(125, 15);
            this.lblDataKoha.TabIndex = 15;
            this.lblDataKoha.Text = "08/08/2013 11:45 AM";
            this.lblDataKoha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctUserProfile
            // 
            this.pctUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctUserProfile.Location = new System.Drawing.Point(16, 162);
            this.pctUserProfile.Name = "pctUserProfile";
            this.pctUserProfile.Size = new System.Drawing.Size(122, 137);
            this.pctUserProfile.TabIndex = 10;
            this.pctUserProfile.TabStop = false;
            // 
            // lblQasjaEFundit
            // 
            this.lblQasjaEFundit.Location = new System.Drawing.Point(14, 333);
            this.lblQasjaEFundit.Name = "lblQasjaEFundit";
            this.lblQasjaEFundit.Size = new System.Drawing.Size(125, 15);
            this.lblQasjaEFundit.TabIndex = 14;
            this.lblQasjaEFundit.Text = "Qasja e fundit:";
            this.lblQasjaEFundit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Location = new System.Drawing.Point(80, 305);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(58, 23);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Shkyqu";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnProfili
            // 
            this.btnProfili.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfili.Location = new System.Drawing.Point(16, 305);
            this.btnProfili.Name = "btnProfili";
            this.btnProfili.Size = new System.Drawing.Size(58, 23);
            this.btnProfili.TabIndex = 13;
            this.btnProfili.Text = "Profili";
            this.btnProfili.UseVisualStyleBackColor = true;
            this.btnProfili.Click += new System.EventHandler(this.btnProfili_Click);
            // 
            // dgvNextAppointments
            // 
            this.dgvNextAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextAppointments.Location = new System.Drawing.Point(13, 19);
            this.dgvNextAppointments.Name = "dgvNextAppointments";
            this.dgvNextAppointments.Size = new System.Drawing.Size(485, 132);
            this.dgvNextAppointments.TabIndex = 16;
            // 
            // btnListoTakimet
            // 
            this.btnListoTakimet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListoTakimet.Location = new System.Drawing.Point(13, 161);
            this.btnListoTakimet.Name = "btnListoTakimet";
            this.btnListoTakimet.Size = new System.Drawing.Size(116, 23);
            this.btnListoTakimet.TabIndex = 17;
            this.btnListoTakimet.Text = "Listo takimet";
            this.btnListoTakimet.UseVisualStyleBackColor = true;
            this.btnListoTakimet.Click += new System.EventHandler(this.btnListoTakimet_Click);
            // 
            // btnShtoTakim
            // 
            this.btnShtoTakim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoTakim.Location = new System.Drawing.Point(136, 161);
            this.btnShtoTakim.Name = "btnShtoTakim";
            this.btnShtoTakim.Size = new System.Drawing.Size(116, 23);
            this.btnShtoTakim.TabIndex = 18;
            this.btnShtoTakim.Text = "Shto takim";
            this.btnShtoTakim.UseVisualStyleBackColor = true;
            this.btnShtoTakim.Click += new System.EventHandler(this.btnShtoTakim_Click);
            // 
            // btnListoDentistet
            // 
            this.btnListoDentistet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListoDentistet.Location = new System.Drawing.Point(12, 99);
            this.btnListoDentistet.Name = "btnListoDentistet";
            this.btnListoDentistet.Size = new System.Drawing.Size(88, 23);
            this.btnListoDentistet.TabIndex = 20;
            this.btnListoDentistet.Text = "Listo dentistet";
            this.btnListoDentistet.UseVisualStyleBackColor = true;
            this.btnListoDentistet.Click += new System.EventHandler(this.btnListoDentistet_Click);
            // 
            // btnShtoDentist
            // 
            this.btnShtoDentist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoDentist.Location = new System.Drawing.Point(106, 99);
            this.btnShtoDentist.Name = "btnShtoDentist";
            this.btnShtoDentist.Size = new System.Drawing.Size(88, 23);
            this.btnShtoDentist.TabIndex = 21;
            this.btnShtoDentist.Text = "Shto dentist";
            this.btnShtoDentist.UseVisualStyleBackColor = true;
            this.btnShtoDentist.Click += new System.EventHandler(this.btnShtoDentist_Click);
            // 
            // dgvDentistet
            // 
            this.dgvDentistet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDentistet.Location = new System.Drawing.Point(12, 21);
            this.dgvDentistet.Name = "dgvDentistet";
            this.dgvDentistet.Size = new System.Drawing.Size(264, 69);
            this.dgvDentistet.TabIndex = 19;
            // 
            // grbTeDhena
            // 
            this.grbTeDhena.Controls.Add(this.button1);
            this.grbTeDhena.Controls.Add(this.label1);
            this.grbTeDhena.Controls.Add(this.button2);
            this.grbTeDhena.Controls.Add(this.lblSotPagesat);
            this.grbTeDhena.Controls.Add(this.lblSotDiagnozat);
            this.grbTeDhena.Controls.Add(this.lblSotTakimet);
            this.grbTeDhena.Controls.Add(this.lblFitimiSot);
            this.grbTeDhena.Controls.Add(this.lblGjithsejDiagnozatSot);
            this.grbTeDhena.Controls.Add(this.lblGjithsejTakimeSot);
            this.grbTeDhena.Location = new System.Drawing.Point(177, 144);
            this.grbTeDhena.Name = "grbTeDhena";
            this.grbTeDhena.Size = new System.Drawing.Size(206, 135);
            this.grbTeDhena.TabIndex = 22;
            this.grbTeDhena.TabStop = false;
            this.grbTeDhena.Text = "Te dhena";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(95, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Listo diagnozat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 2);
            this.label1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(13, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Statistika";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblSotPagesat
            // 
            this.lblSotPagesat.Location = new System.Drawing.Point(138, 64);
            this.lblSotPagesat.Name = "lblSotPagesat";
            this.lblSotPagesat.Size = new System.Drawing.Size(55, 13);
            this.lblSotPagesat.TabIndex = 5;
            this.lblSotPagesat.Text = "12346";
            this.lblSotPagesat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSotDiagnozat
            // 
            this.lblSotDiagnozat.Location = new System.Drawing.Point(138, 43);
            this.lblSotDiagnozat.Name = "lblSotDiagnozat";
            this.lblSotDiagnozat.Size = new System.Drawing.Size(55, 13);
            this.lblSotDiagnozat.TabIndex = 4;
            this.lblSotDiagnozat.Text = "12346";
            this.lblSotDiagnozat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSotTakimet
            // 
            this.lblSotTakimet.Location = new System.Drawing.Point(138, 22);
            this.lblSotTakimet.Name = "lblSotTakimet";
            this.lblSotTakimet.Size = new System.Drawing.Size(55, 13);
            this.lblSotTakimet.TabIndex = 3;
            this.lblSotTakimet.Text = "12346";
            this.lblSotTakimet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFitimiSot
            // 
            this.lblFitimiSot.AutoSize = true;
            this.lblFitimiSot.Location = new System.Drawing.Point(10, 64);
            this.lblFitimiSot.Name = "lblFitimiSot";
            this.lblFitimiSot.Size = new System.Drawing.Size(110, 13);
            this.lblFitimiSot.TabIndex = 2;
            this.lblFitimiSot.Text = "Pagesat (ne vlere) sot";
            // 
            // lblGjithsejDiagnozatSot
            // 
            this.lblGjithsejDiagnozatSot.AutoSize = true;
            this.lblGjithsejDiagnozatSot.Location = new System.Drawing.Point(10, 43);
            this.lblGjithsejDiagnozatSot.Name = "lblGjithsejDiagnozatSot";
            this.lblGjithsejDiagnozatSot.Size = new System.Drawing.Size(107, 13);
            this.lblGjithsejDiagnozatSot.TabIndex = 1;
            this.lblGjithsejDiagnozatSot.Text = "Gjithsej diagnozat sot";
            // 
            // lblGjithsejTakimeSot
            // 
            this.lblGjithsejTakimeSot.AutoSize = true;
            this.lblGjithsejTakimeSot.Location = new System.Drawing.Point(10, 22);
            this.lblGjithsejTakimeSot.Name = "lblGjithsejTakimeSot";
            this.lblGjithsejTakimeSot.Size = new System.Drawing.Size(95, 13);
            this.lblGjithsejTakimeSot.TabIndex = 0;
            this.lblGjithsejTakimeSot.Text = "Gjithsej takimet sot";
            // 
            // pctHeader
            // 
            this.pctHeader.BackColor = System.Drawing.Color.White;
            this.pctHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctHeader.Image = global::DentalSoft.Properties.Resources.Logo;
            this.pctHeader.Location = new System.Drawing.Point(0, 24);
            this.pctHeader.Name = "pctHeader";
            this.pctHeader.Size = new System.Drawing.Size(706, 102);
            this.pctHeader.TabIndex = 24;
            this.pctHeader.TabStop = false;
            // 
            // lblVerticalDivider
            // 
            this.lblVerticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVerticalDivider.Location = new System.Drawing.Point(157, 148);
            this.lblVerticalDivider.Name = "lblVerticalDivider";
            this.lblVerticalDivider.Size = new System.Drawing.Size(2, 335);
            this.lblVerticalDivider.TabIndex = 25;
            // 
            // grbTakimet
            // 
            this.grbTakimet.Controls.Add(this.dgvNextAppointments);
            this.grbTakimet.Controls.Add(this.btnShtoTakim);
            this.grbTakimet.Controls.Add(this.btnListoTakimet);
            this.grbTakimet.Location = new System.Drawing.Point(177, 287);
            this.grbTakimet.Name = "grbTakimet";
            this.grbTakimet.Size = new System.Drawing.Size(512, 199);
            this.grbTakimet.TabIndex = 28;
            this.grbTakimet.TabStop = false;
            this.grbTakimet.Text = "Takimet";
            // 
            // grbDentistet
            // 
            this.grbDentistet.Controls.Add(this.btnShtoDentist);
            this.grbDentistet.Controls.Add(this.dgvDentistet);
            this.grbDentistet.Controls.Add(this.btnListoDentistet);
            this.grbDentistet.Location = new System.Drawing.Point(401, 144);
            this.grbDentistet.Name = "grbDentistet";
            this.grbDentistet.Size = new System.Drawing.Size(288, 135);
            this.grbDentistet.TabIndex = 28;
            this.grbDentistet.TabStop = false;
            this.grbDentistet.Text = "Dentistet";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 502);
            this.Controls.Add(this.grbDentistet);
            this.Controls.Add(this.grbTakimet);
            this.Controls.Add(this.lblVerticalDivider);
            this.Controls.Add(this.pctHeader);
            this.Controls.Add(this.grbTeDhena);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDataKoha);
            this.Controls.Add(this.pctUserProfile);
            this.Controls.Add(this.lblQasjaEFundit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnProfili);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fillimi";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistet)).EndInit();
            this.grbTeDhena.ResumeLayout(false);
            this.grbTeDhena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHeader)).EndInit();
            this.grbTakimet.ResumeLayout(false);
            this.grbDentistet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miFillimi;
        private System.Windows.Forms.ToolStripMenuItem miDalje;
        private System.Windows.Forms.ToolStripMenuItem miNdihma;
        private System.Windows.Forms.ToolStripMenuItem miRrethDentalSoft;
        private System.Windows.Forms.ToolStripMenuItem shkyquToolStripMenuItem;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDataKoha;
        private System.Windows.Forms.PictureBox pctUserProfile;
        private System.Windows.Forms.Label lblQasjaEFundit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfili;
        private System.Windows.Forms.ToolStripMenuItem dentistetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menaxhoDentistetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takimetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menaxhoTakimetToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNextAppointments;
        private System.Windows.Forms.ToolStripMenuItem raportetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjeneroDiagnozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoDiagnozatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoDentistetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoTakimetToolStripMenuItem;
        private System.Windows.Forms.Button btnListoTakimet;
        private System.Windows.Forms.Button btnShtoTakim;
        private System.Windows.Forms.Button btnListoDentistet;
        private System.Windows.Forms.Button btnShtoDentist;
        private System.Windows.Forms.DataGridView dgvDentistet;
        private System.Windows.Forms.GroupBox grbTeDhena;
        private System.Windows.Forms.Label lblFitimiSot;
        private System.Windows.Forms.Label lblGjithsejDiagnozatSot;
        private System.Windows.Forms.Label lblGjithsejTakimeSot;
        private System.Windows.Forms.PictureBox pctHeader;
        private System.Windows.Forms.Label lblSotPagesat;
        private System.Windows.Forms.Label lblSotDiagnozat;
        private System.Windows.Forms.Label lblSotTakimet;
        private System.Windows.Forms.Label lblVerticalDivider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbTakimet;
        private System.Windows.Forms.GroupBox grbDentistet;
    }
}