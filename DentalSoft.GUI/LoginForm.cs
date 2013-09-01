using DentalSoft.Service;
using System;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmLogin : Form
    {
        LoginService loginService;

        public frmLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool status = loginService.doLogin(txtUsername.Text, txtPassword.Text);
            if (status)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Perdoruesi ose Fjalekalimi eshte gabim.\nJu lutem provoni perseri.", "Gabim!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
