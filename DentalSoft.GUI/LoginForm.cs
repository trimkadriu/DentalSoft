using DentalSoft.Domain;
using DentalSoft.Service;
using System;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmLogin : Form
    {
        LoginService loginService;
        public Dentist loggedInDentist { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dentist dentist = loginService.doLogin(txtUsername.Text, txtPassword.Text);
            if (dentist != null)
            {
                this.DialogResult = DialogResult.OK;
                this.loggedInDentist = dentist;
                this.Close();
            }
            else
            {
                MessageBox.Show("Perdoruesi ose Fjalekalimi eshte gabim.\nJu lutem provoni perseri.", "Gabim!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
