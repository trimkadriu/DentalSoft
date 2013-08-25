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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void miRrethDentalSoft_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }

        private void miDalje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shkyquToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
