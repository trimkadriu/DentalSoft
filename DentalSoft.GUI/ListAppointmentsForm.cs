using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Service;
using System;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmListAppointments : Form
    {
        private AppointmentService appointmentService;
        private BindingSource bindingSource;
        private Utilities utilities;
        private bool dateFilter;

        public frmListAppointments()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            bindingSource = new BindingSource();
            utilities = new Utilities();
            dateFilter = false;
            Init();
        }

        private void Init()
        {
            bindingSource.DataSource = appointmentService.getBindingSource();
            dgvTakimet.DataSource = bindingSource;
        }

        private void btnMbylle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            editAppointment();
            this.DialogResult = DialogResult.None;
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void dgvTakimet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editAppointment();
            this.DialogResult = DialogResult.None;
        }

        private void txtEmriPacientit_TextChanged(object sender, EventArgs e)
        {
            dataGridFilter();
        }

        private void datesValuesChanged(object sender, EventArgs e)
        {
            if (dtpDataETakimitPrej.Value > dtpDataETakimitDeri.Value)
            {
                MessageBox.Show("Datat e perzgjedhura jane kontradiktore. Ju lutem zgjedhni datat perseri", "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataETakimitPrej.Value = dtpDataETakimitDeri.Value.AddMinutes(-1);
                dtpDataETakimitDeri.Value = DateTime.Now;
                dtpDataETakimitPrej.CustomFormat = " ";
                dtpDataETakimitDeri.CustomFormat = " ";
                dateFilter = false;
            }
            else
            {
                dtpDataETakimitPrej.CustomFormat = "dd MMMM yyyy - hh:mm tt";
                dtpDataETakimitDeri.CustomFormat = "dd MMMM yyyy - hh:mm tt";
                dateFilter = true;
            }
            dataGridFilter();
        }

        private void dataGridFilter()
        {
            string filter = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtEmriPacientit.Text) && dateFilter)
                filter = string.Format("[Emri pacientit] like '%{0}%' AND [Data takimit] >= '{1}' AND [Data takimit] <= '{2}'",
                                        txtEmriPacientit.Text,
                                        utilities.convertDateForBindingSource(dtpDataETakimitPrej.Value),
                                        utilities.convertDateForBindingSource(dtpDataETakimitDeri.Value));
            else
            {
                if (!string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
                    filter = string.Format("[Emri pacientit] like '%{0}%'", txtEmriPacientit.Text);
                else if (dateFilter)
                    filter = string.Format("[Data takimit] >= '{0}' AND [Data takimit] <= '{1}'", 
                                            utilities.convertDateForBindingSource(dtpDataETakimitPrej.Value),
                                            utilities.convertDateForBindingSource(dtpDataETakimitDeri.Value));
            }
            bindingSource.Filter = filter;
        }
    }
}
