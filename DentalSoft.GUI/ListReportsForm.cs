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
    public partial class frmListReports : Form
    {
        public frmListReports()
        {
            InitializeComponent();
            dtpDataERaporteveDeri.MinDate = DateTime.Now.AddYears(-1);
            dtpDataERaportevePrej.MaxDate = DateTime.Now.AddYears(1);
            dtpDataERaporteveDeri.MinDate = DateTime.Now.AddYears(-1);
            dtpDataERaporteveDeri.MaxDate = DateTime.Now.AddYears(1);
            dtpDataERaportevePrej.Value = DateTime.Now.AddDays(-3);
            dtpDataERaporteveDeri.Value = DateTime.Now;
        }

        private void btnMbylle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
