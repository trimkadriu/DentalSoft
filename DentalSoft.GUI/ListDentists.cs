using DentalSoft.Service;
using DentalSoft.Domain;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace DentalSoft
{
    public partial class frmListDentists : Form
    {
        private DentistService dentistService;
        private BindingSource bindingSource;
        private Dentist loggedInDentist;

        public frmListDentists(Dentist dentist = null)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dentistService = new DentistService();
            loggedInDentist = dentist;
            Init();
        }

        private void Init()
        {
            bindingSource.DataSource = dentistService.getBindingSource();
            dgvListaEDentisteve.DataSource = bindingSource;
            dgvListaEDentisteve.Columns["Fjalekalimi"].Visible = false;
            dgvListaEDentisteve.Columns["Foto profilit"].Visible = false;
        }

        private void txtKerkoEmriMbiemri_TextChanged(object sender, System.EventArgs e)
        {
            bindingSource.Filter = "Emri like '%" + txtKerkoEmriMbiemri.Text + "%'";
        }

        private void btnFshij_Click(object sender, System.EventArgs e)
        {
            if (dgvListaEDentisteve.SelectedRows.Count == 1)
            {
                string id = dgvListaEDentisteve.SelectedRows[0].Cells[0].Value.ToString();
                string perdoruesi = dgvListaEDentisteve.SelectedRows[0].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("A jeni i sigurte qe deshironi ta fshini\ndentistin me emrin e perdorusit: [ " + perdoruesi.ToUpper() + " ]",
                                                  "Konfirmo ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Dentist dentist = new Dentist(id);
                    dentistService.removeDentist(dentist);
                    if (loggedInDentist.Equals(dentist))
                    {
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    Init();
                }
            }
        }
    }
}
