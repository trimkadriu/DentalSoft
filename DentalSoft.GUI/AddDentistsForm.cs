using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Service;
using System;
using System.IO;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmAddDentist : Form
    {
        private bool edito = false;
        private Utilities utilities;
        private Dentist dentist;
        private DentistService dentistService;
        private byte[] fotoProfilit;

        public frmAddDentist(Dentist dentist = null)
        {
            InitializeComponent();
            utilities = new Utilities();
            this.dentist = dentist;
            dentistService = new DentistService();
            fotoProfilit = new byte[2000000];
            Init();
        }

        private void Init()
        {
            if (dentist != null)
            {
                edito = true;
                btnShtoDentist.Text = "Ruaj ndryshimet";
                this.Text = "Edito dentist";

                txtEmri.Text = dentist.getEmri();
                txtEmail.Text = dentist.getEmail();
                txtPerdoruesi.Enabled = false;
                txtPerdoruesi.Text = dentist.getPerdoruesi();
                lblPassowrdInformation.Visible = true;
                if (dentist.getFotoProfilit() == null)
                    pctFotoProfil.Image = Properties.Resources.Ska_foto;
                else
                    pctFotoProfil.Image = utilities.convertByteToImage(dentist.getFotoProfilit());
            }
        }

        private void btnShfletoFoto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdShfletoFoto.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                lblEmriFajllit.Text = ofdShfletoFoto.SafeFileName;
                try
                {
                    fotoProfilit = File.ReadAllBytes(ofdShfletoFoto.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabimi: " + ex.Message, "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(edito)
                    dentist.setFotoProfilit(fotoProfilit);
                pctFotoProfil.Image = utilities.convertByteToImage(fotoProfilit);
            }
        }

        private void btnShtoDentist_Click(object sender, EventArgs e)
        {
            if (validoDentistForm())
            {
                Encryptor encryptor = new Encryptor();
                if (edito)
                {
                    dentist.setEmri(txtEmri.Text);
                    dentist.setEmail(txtEmail.Text);
                    if (!string.IsNullOrWhiteSpace(txtFjalekalimi.Text))
                    {
                        dentist.setFjalekalimi(encryptor.encryptMd5(txtFjalekalimi.Text));
                    }
                    if (dentistService.editDentist(dentist))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    Dentist dentistNew = new Dentist(null, txtEmri.Text, txtEmail.Text, txtPerdoruesi.Text, 
                                                     encryptor.encryptMd5(txtFjalekalimi.Text), fotoProfilit);
                    if (dentistService.insertDentist(dentistNew))
                    {
                        MessageBox.Show("Dentisti u shtua me sukses.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private bool validoDentistForm()
        {
            if (string.IsNullOrWhiteSpace(txtEmri.Text))
            {
                txtEmri.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPerdoruesi.Text))
            {
                txtPerdoruesi.Focus();
                return false;
            }
            else if (!edito && string.IsNullOrWhiteSpace(txtFjalekalimi.Text))
            {
                txtFjalekalimi.Focus();
                return false;
            }
            else if (!edito && string.IsNullOrWhiteSpace(txtRishkruajFjalekalimin.Text))
            {
                txtRishkruajFjalekalimin.Focus();
                return false;
            }
            else if (!txtFjalekalimi.Text.Equals(txtRishkruajFjalekalimin.Text))
            {
                txtRishkruajFjalekalimin.Focus();
                MessageBox.Show("Fjalekalimi dhe rishkrimi i fjalekalimit nuk eshte i njejte. Ju lutem permiresoni fjalekalimin.", "Gabim!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
