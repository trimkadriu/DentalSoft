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
    }
}
