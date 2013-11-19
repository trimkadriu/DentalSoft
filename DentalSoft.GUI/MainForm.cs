using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmMain : Form
    {
        public static Dentist loggedInDentist;
        private Utilities utilities;
        private DentistService dentistService;
        private AppointmentService appointmentService;
        private ReportService reportService;

        public frmMain(Dentist dentist)
        {
            loggedInDentist = dentist;
            InitializeComponent();
            utilities = new Utilities();
            dentistService = new DentistService();
            appointmentService = new AppointmentService();
            reportService = new ReportService();
            Init();
        }

        private void Init()
        {
            // Load profile
            lblEmriPlote.Text = "( " + loggedInDentist.getEmri() + " )";
            lblDataKoha.Text = loggedInDentist.getQasjaFundit().ToString();
            if (loggedInDentist.getFotoProfilit() == null)
                pctUserProfile.Image = Properties.Resources.Ska_foto;
            else
                pctUserProfile.Image = utilities.convertByteToImage(loggedInDentist.getFotoProfilit());

            // Load Dentists
            List<Dentist> dentists = dentistService.getDentistsForDashboard(2);
            BindingSource dentistBindingSource = dentistService.getBindingSource(dentists);
            dgvDentistet.DataSource = dentistBindingSource;
            dgvDentistet.Columns["Id"].Visible = false;
            dgvDentistet.Columns["Fjalekalimi"].Visible = false;
            dgvDentistet.Columns["Foto profilit"].Visible = false;
            dgvDentistet.Columns["Email"].Visible = false;
            dgvDentistet.Columns["Perdoruesi"].Visible = false;

            // Load Appointments
            List<Appointment> appointments = appointmentService.getAppointmentsForDashboard(loggedInDentist);
            BindingSource appointmentsBindingSource = appointmentService.getBindingSource(loggedInDentist, appointments);
            dgvTakimetSot.DataSource = appointmentsBindingSource;
            dgvTakimetSot.Columns["Id"].Visible = false;
            dgvTakimetSot.Columns["Dentisti"].Visible = false;
            dgvTakimetSot.Columns["Email"].Visible = false;
            dgvTakimetSot.Columns["Mosha"].Visible = false;
            dgvTakimetSot.Columns["Komenti"].Visible = false;

            // Load "Te dhena" Panel data
            lblSotRaportet.Text = reportService.getReportsForDashboard(loggedInDentist).Count.ToString();
            lblSotPagesat.Text = reportService.getSumPagesat(loggedInDentist) + " €";
            lblSotTakimet.Text = appointments.Count.ToString();
        }

        private void miRrethDentalSoft_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void miDalje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shkyquToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnProfili_Click(object sender, EventArgs e)
        {
            frmAddDentist addDentistForm = new frmAddDentist(true);
            addDentistForm.ShowDialog();
            if (addDentistForm.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void btnShtoDentist_Click(object sender, EventArgs e)
        {
            frmAddDentist addDentistForm = new frmAddDentist();
            addDentistForm.ShowDialog();
            if (addDentistForm.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void btnListoDentistet_Click(object sender, EventArgs e)
        {
            frmListDentists listDentistsForm = new frmListDentists();
            listDentistsForm.ShowDialog();
            if (listDentistsForm.DialogResult.Equals(DialogResult.OK))
                Init();
            else if (listDentistsForm.DialogResult.Equals(DialogResult.Yes))
                logout();
        }

        private void menaxhoDentistetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDentist addDentistForm = new frmAddDentist();
            addDentistForm.ShowDialog();
            if (addDentistForm.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void listoDentistetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDentists listDentistsForm = new frmListDentists();
            listDentistsForm.ShowDialog();
            if (listDentistsForm.DialogResult.Equals(DialogResult.OK))
                Init();
            else if (listDentistsForm.DialogResult.Equals(DialogResult.Yes))
                logout();
        }

        private void btnShtoTakim_Click(object sender, EventArgs e)
        {
            frmAddAppointment addAppointment = new frmAddAppointment();
            addAppointment.ShowDialog();
            if (addAppointment.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void btnListoTakimet_Click(object sender, EventArgs e)
        {
            frmListAppointments listAppointments = new frmListAppointments();
            listAppointments.ShowDialog();
            if (listAppointments.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void menaxhoTakimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAppointment addAppointment = new frmAddAppointment();
            addAppointment.ShowDialog();
            if (addAppointment.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void listoTakimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAppointments listAppointments = new frmListAppointments();
            listAppointments.ShowDialog();
            if (listAppointments.DialogResult.Equals(DialogResult.OK))
                Init();
        }

        private void miGjeneroRaport_Click(object sender, EventArgs e)
        {
            //frmGenerateReport generateReport = new frmGenerateReport();
            //generateReport.ShowDialog();
        }

        private void miListoRaportet_Click(object sender, EventArgs e)
        {
            frmListReports listReports = new frmListReports();
            listReports.ShowDialog();
        }

        private void btnListoRaportet_Click(object sender, EventArgs e)
        {
            frmListReports listReports = new frmListReports();
            listReports.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            Application.Restart();
        }

        private void clearDataGridSelection()
        {
            dgvDentistet.ClearSelection();
            dgvTakimetSot.ClearSelection();
        }

        private void dgvDentistet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clearDataGridSelection();
        }

        private void btnGjeneroRaport_Click(object sender, EventArgs e)
        {
            if (dgvTakimetSot.SelectedRows.Count == 1)
            {
                string id = dgvTakimetSot.SelectedRows[0].Cells[0].Value.ToString();
                Appointment appointment = appointmentService.getAppointmentById(id);
                Report report = reportService.getReportByAppointmentId(id);
                frmGenerateReport generateReportForm;
                if (report != null)
                {
                    //Update report
                    generateReportForm = new frmGenerateReport(appointment, report);
                }
                else
                {
                    //Create new report
                    generateReportForm = new frmGenerateReport(appointment);
                }
                generateReportForm.ShowDialog();
                if (generateReportForm.DialogResult.Equals(DialogResult.OK))
                    Init();
            }
        }
    }
}
