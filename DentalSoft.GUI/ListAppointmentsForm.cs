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

        public frmListAppointments()
        {
            InitializeComponent();
            dtpDataETakimitPrej.MinDate = DateTime.Now.AddYears(-1);
            dtpDataETakimitPrej.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitDeri.MinDate = DateTime.Now.AddYears(-1);
            dtpDataETakimitDeri.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitPrej.Value = DateTime.Now.AddDays(-3);
            dtpDataETakimitDeri.Value = DateTime.Now;
            appointmentService = new AppointmentService();
            bindingSource = new BindingSource();
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
            if (dgvTakimet.SelectedRows.Count == 1)
            {
                string id = dgvTakimet.SelectedRows[0].Cells[0].Value.ToString();
                Appointment appointment = appointmentService.getAppointmentById(id);
                frmAddAppointment editAppointmentForm = new frmAddAppointment(appointment);
                editAppointmentForm.ShowDialog(); 
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {

        }
    }
}
