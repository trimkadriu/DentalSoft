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
        private bool refreshOnClose;
        private bool filterEmri;
        private bool filterData;

        public frmListAppointments()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            reportService = new ReportService();
            bindingSource = new BindingSource();
            Init();
            refreshOnClose = false;
            filterEmri = false;
            filterData = false;
            resetDates();
        }

        private void Init()
        {
            bindingSource.DataSource = appointmentService.getBindingSource(frmMain.loggedInDentist);
            dgvTakimet.DataSource = bindingSource;
            dgvTakimet.Columns["Id"].Visible = false;
            dgvTakimet.Columns["Dentisti"].Visible = false;
            dgvTakimet.Sort(this.dgvTakimet.Columns["Data Takimit"], ListSortDirection.Descending);
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
            if (!string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
                filterEmri = true;
            else
                filterEmri = false;
            dataGridViewFilter();
        }

        private void resetDates()
        {
            dtpDataETakimitPrej.CustomFormat = " ";
            dtpDataETakimitDeri.CustomFormat = " ";
            filterData = false;
        }

        private void datesValuesChanged(object sender, EventArgs e)
        {
            if (dtpDataETakimitPrej.Value > dtpDataETakimitDeri.Value)
            {
                MessageBox.Show("Datat e perzgjedhura jane kontradiktore. Ju lutem zgjedhni datat perseri", "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataETakimitPrej.Value = DateTime.Now.AddDays(-3);
                dtpDataETakimitDeri.Value = DateTime.Now;
                resetDates();
            }
            else
            {
                dtpDataETakimitPrej.CustomFormat = "dd/MMMM/yyyy hh:mm tt";
                dtpDataETakimitDeri.CustomFormat = "dd/MMMM/yyyy hh:mm tt";
                filterData = true;
                dataGridViewFilter();
            }
        }

        private void dataGridViewFilter()
        {
            string filter = string.Empty;
            if (filterEmri && !filterData)
            {
                filter = "[Emri pacientit] like '%" + txtEmriPacientit.Text + "%'";
            }
            else if (filterData && !filterEmri)
            {
                filter = string.Format("[Data takimit] >= '{0}' AND [Data takimit] <= '{1}'", 
                                        dtpDataETakimitPrej.Value, dtpDataETakimitDeri.Value);
            }
            else if (filterData && filterEmri)
            {
                filter = string.Format("[Emri pacientit] like '%{0}%' AND [Data takimit] >= '{1}' AND [Data takimit] <= '{2}'",
                                        txtEmriPacientit.Text,
                                        dtpDataETakimitPrej.Value,
                                        dtpDataETakimitDeri.Value);
            }
            bindingSource.Filter = filter;
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

        private void btnFshijDatat_Click(object sender, EventArgs e)
        {
            dtpDataETakimitPrej.Value = DateTime.Now.AddDays(-3);
            dtpDataETakimitDeri.Value = DateTime.Now;
            resetDates();
            dataGridViewFilter();
        }
    }
}
