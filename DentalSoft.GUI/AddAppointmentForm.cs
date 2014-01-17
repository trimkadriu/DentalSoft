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
    public partial class frmAddAppointment : Form
    {
        private AppointmentService appointmentService;
        private Appointment appointment;

        public frmAddAppointment(Appointment appointment = null)
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            this.appointment = appointment;
            Init();
        }

        public void Init()
        {
            if (appointment != null)
            {
                btnShtoTakim.Text = "Ruaj ndryshimet";
                this.Text = "Ndrysho takimin";
                txtEmriPacientit.Text = appointment.getEmriPacientit();
                nudMosha.Text = appointment.getMosha().ToString();
                txtEmail.Text = appointment.getEmail();
                txtTelefoni.Text = appointment.getTelefoni();
                dtpDataETakimit.Value = appointment.getDataTakimit();
                dtpDataETakimit.MinDate = appointment.getDataTakimit();
                nudKohezgjatjaETakimit.Text = appointment.getKohezgjatjaTakimit().ToString();
                txtProblemi.Text = appointment.getProblemi();
                txtKomenti.Text = appointment.getKomenti();
            }
            else
            {
                dtpDataETakimit.MinDate = DateTime.Now;
            }
            dtpDataETakimit.MaxDate = DateTime.Now.AddYears(1);
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShtoTakim_Click(object sender, EventArgs e)
        {
            if (validoAppointmentForm())
            {
                if (appointment != null)
                {
                    appointment.setEmriPacientit(txtEmriPacientit.Text);
                    appointment.setMosha(int.Parse(nudMosha.Text));
                    appointment.setEmail(txtEmail.Text);
                    appointment.setTelefoni(txtTelefoni.Text);
                    appointment.setDataTakimit(dtpDataETakimit.Value);
                    appointment.setKohezgjatjaTakimit(int.Parse(nudKohezgjatjaETakimit.Text));
                    appointment.setProblemi(txtProblemi.Text);
                    appointment.setKomenti(txtKomenti.Text);
                    if (appointmentService.editAppointment(appointment))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    Appointment newAppointment = new Appointment(null, frmMain.loggedInDentist.getId(), txtEmriPacientit.Text, int.Parse(nudMosha.Text), 
                                                                 txtEmail.Text, txtTelefoni.Text, dtpDataETakimit.Value, int.Parse(nudKohezgjatjaETakimit.Text), 
                                                                 txtProblemi.Text, txtKomenti.Text);
                    if (appointmentService.insertAppointment(newAppointment))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private bool validoAppointmentForm()
        {
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(nudMosha.Text))
            {
                nudMosha.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefoni.Text))
            {
                txtTelefoni.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpDataETakimit.Text))
            {
                dtpDataETakimit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(nudKohezgjatjaETakimit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProblemi.Text))
            {
                txtProblemi.Focus();
                return false;
            }
            return true;
        }

        private void nudKohezgjatjaETakimit_ValueChanged(object sender, EventArgs e)
        {
            llogaritMinutatNeOre();
        }

        private void llogaritMinutatNeOre()
        {
            TimeSpan ts = TimeSpan.FromMinutes(double.Parse(nudKohezgjatjaETakimit.Text));
            txtOret.Text = ts.ToString();
        }
    }
}