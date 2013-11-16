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

        public frmMain(Dentist dentist)
        {
            loggedInDentist = dentist;
            InitializeComponent();
            utilities = new Utilities();
            dentistService = new DentistService();
            appointmentService = new AppointmentService();
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
            List<Appointment> appointments = appointmentService.getAppointmentsForDashboard();
            BindingSource appointmentsBindingSource = appointmentService.getBindingSource(loggedInDentist, appointments);
            dgvNextAppointments.DataSource = appointmentsBindingSource;
            dgvNextAppointments.Columns["Id"].Visible = false;
            dgvNextAppointments.Columns["Dentisti"].Visible = false;
            dgvNextAppointments.Columns["Email"].Visible = false;
            dgvNextAppointments.Columns["Mosha"].Visible = false;
            dgvNextAppointments.Columns["Komenti"].Visible = false;
            lblSotTakimet.Text = appointments.Count.ToString();
        }

        private void miRrethDentalSoft_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
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
        }

        private void btnListoDentistet_Click(object sender, EventArgs e)
        {
            frmListDentists listDentistsForm = new frmListDentists();
            DialogResult dr = listDentistsForm.ShowDialog();
            if (dr == DialogResult.Yes)
                logout();
        }

        private void menaxhoDentistetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDentist addDentistForm = new frmAddDentist();
            addDentistForm.ShowDialog();
        }

        private void listoDentistetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDentists listDentistsForm = new frmListDentists();
            listDentistsForm.ShowDialog();
        }

        private void btnShtoTakim_Click(object sender, EventArgs e)
        {
            frmAddAppointment addAppointment = new frmAddAppointment();
            addAppointment.ShowDialog();
        }

        private void btnListoTakimet_Click(object sender, EventArgs e)
        {
            frmListAppointments listAppointments = new frmListAppointments();
            listAppointments.ShowDialog();
        }

        private void menaxhoTakimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAppointment addAppointment = new frmAddAppointment();
            addAppointment.ShowDialog();
        }

        private void listoTakimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAppointments listAppointments = new frmListAppointments();
            listAppointments.ShowDialog();
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
            dgvNextAppointments.ClearSelection();
        }

        private void dgvDentistet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clearDataGridSelection();
        }
    }
}
