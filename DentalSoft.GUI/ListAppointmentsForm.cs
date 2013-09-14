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
        private BindingSource bindingSource;
        private bool firstLoad;

        public frmListAppointments()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            bindingSource = new BindingSource();
            Init();
            firstLoad = true;
            resetDates();
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
    }
}
