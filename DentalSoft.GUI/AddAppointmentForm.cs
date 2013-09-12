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
        public frmAddAppointment()
        {
            InitializeComponent();
            dtpDataETakimit.MinDate = DateTime.Now;
            dtpDataETakimit.MaxDate = DateTime.Now.AddYears(1);
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShtoTakim_Click(object sender, EventArgs e)
        {

        }

        private bool validoDentistForm()
        {
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (nudMosha.Value > 0)
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmriPacientit.Text))
            {
                txtEmriPacientit.Focus();
                return false;
            }

        }
    }
}
