using DentalSoft.Domain;
using DentalSoft.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmListAppointments : Form
    {
        private AppointmentService appointmentService;
        private ReportService reportService;
        private BindingSource bindingSource;
        private bool firstLoad;
        private bool refreshOnClose;

        public frmListAppointments()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            reportService = new ReportService();
            bindingSource = new BindingSource();
            Init();
            firstLoad = true;
            refreshOnClose = false;
            resetDates();
        }

        private void Init()
        {
            bindingSource.DataSource = appointmentService.getBindingSource(frmMain.loggedInDentist);
            dgvTakimet.DataSource = bindingSource;
            dgvTakimet.Columns["Id"].Visible = false;
            dgvTakimet.Columns["Dentisti"].Visible = false;
        }

        private void btnMbylle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            editAppointment();
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            if (dgvTakimet.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("A jeni i sigurte qe deshironi te fshini kete takim ?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.Equals(DialogResult.Yes))
                {
                    string id = dgvTakimet.SelectedRows[0].Cells[0].Value.ToString();
                    Appointment appointment = new Appointment(id);
                    appointmentService.removeAppointment(appointment);
                    this.DialogResult = DialogResult.OK;
                    Init();
                }
            }
        }
        
        private void editAppointment()
        {
            if (dgvTakimet.SelectedRows.Count == 1)
            {
                string id = dgvTakimet.SelectedRows[0].Cells[0].Value.ToString();
                Appointment appointment = appointmentService.getAppointmentById(id);
                frmAddAppointment editAppointmentForm = new frmAddAppointment(appointment);
                if (editAppointmentForm.ShowDialog() == DialogResult.Yes)
                    Init();
                refreshOnClose = true;
            }
            this.DialogResult = DialogResult.None;
        }

        private void dgvTakimet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editAppointment();
        }

        private void txtEmriPacientit_TextChanged(object sender, EventArgs e)
        {
            bindingSource.Filter = "[Emri pacientit] like '%" + txtEmriPacientit.Text + "%'";
        }

        private void resetDates()
        {
            dtpDataETakimitPrej.CustomFormat = " ";
            dtpDataETakimitDeri.CustomFormat = " ";
            //
            dtpDataETakimitPrej.MinDate = DateTime.Now.AddYears(-3);
            dtpDataETakimitPrej.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitPrej.Value = DateTime.Now.AddDays(-3);
            //
            dtpDataETakimitDeri.MinDate = DateTime.Now.AddYears(-1);
            dtpDataETakimitDeri.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitDeri.Value = DateTime.Now;
        }

        private void datesValuesChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            firstLoad = false;
            if (dtpDataETakimitPrej.Value > dtpDataETakimitDeri.Value)
            {
                MessageBox.Show("Datat e perzgjedhura jane kontradiktore. Ju lutem zgjedhni datat perseri", "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetDates();
            }
            else
            {
                dtpDataETakimitPrej.CustomFormat = "dd MMMM yyyy - hh:mm tt";
                dtpDataETakimitDeri.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            }
        }

        private void btnGjeneroRaport_Click(object sender, EventArgs e)
        {
            if (dgvTakimet.SelectedRows.Count == 1)
            {
                string id = dgvTakimet.SelectedRows[0].Cells[0].Value.ToString();
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
                this.DialogResult = DialogResult.None;
                refreshOnClose = true;
                Init();
            }
        }

        private void dgvTakimet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTakimet.ClearSelection();
        }

        private void frmListAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refreshOnClose)
                this.DialogResult = DialogResult.OK;
        }
    }
}
