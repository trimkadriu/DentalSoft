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
        public frmListAppointments()
        {
            InitializeComponent();
            dtpDataETakimitPrej.MinDate = DateTime.Now.AddYears(-1);
            dtpDataETakimitPrej.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitDeri.MinDate = DateTime.Now.AddYears(-1);
            dtpDataETakimitDeri.MaxDate = DateTime.Now.AddYears(1);
            dtpDataETakimitPrej.Value = DateTime.Now.AddDays(-3);
            dtpDataETakimitDeri.Value = DateTime.Now;
        }

        private void btnMbylle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
