using DentalSoft.Domain;
using DentalSoft.Library;
using System;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmMain : Form
    {
        private Dentist loggedInDentist;
        private Utilities utilities;

        public frmMain(Dentist loggedInDentist)
        {
            InitializeComponent();

            this.loggedInDentist = loggedInDentist;
            utilities = new Utilities();

            loadMainFormData();
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
            frmAddDentist addDentistForm = new frmAddDentist(loggedInDentist);
            addDentistForm.ShowDialog();
            if (addDentistForm.DialogResult.Equals(DialogResult.OK))
                loadMainFormData();
        }

        private void btnShtoDentist_Click(object sender, EventArgs e)
        {
            frmAddDentist addDentistForm = new frmAddDentist();
            addDentistForm.ShowDialog();
        }

        private void btnListoDentistet_Click(object sender, EventArgs e)
        {
            frmListDentists listDentistsForm = new frmListDentists();
            listDentistsForm.ShowDialog();
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
            frmGenerateReport generateReport = new frmGenerateReport();
            generateReport.ShowDialog();
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

        private void loadMainFormData()
        {
            lblEmriPlote.Text = "( " + loggedInDentist.getEmri() + " )";
            lblDataKoha.Text = loggedInDentist.getQasjaFundit().ToString();
            if (loggedInDentist.getFotoProfilit() == null)
                pctUserProfile.Image = Properties.Resources.Ska_foto;
            else
                pctUserProfile.Image = utilities.convertByteToImage(loggedInDentist.getFotoProfilit());
        }
    }
}
