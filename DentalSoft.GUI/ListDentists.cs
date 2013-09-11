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

        public frmListDentists()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            Init();
        }

        private void Init()
        {
            dentistService = new DentistService(); 
            bindingSource.DataSource = dentistService.getBindingSource();
            dgvListaEDentisteve.DataSource = bindingSource;
            dgvListaEDentisteve.Columns["Fjalekalimi"].Visible = false;
            dgvListaEDentisteve.Columns["Foto e profilit"].Visible = false;
        }

        private void txtKerkoEmriMbiemri_TextChanged(object sender, System.EventArgs e)
        {
            bindingSource.Filter = "Emri like '%" + txtKerkoEmriMbiemri.Text + "%'";
        }

        private void btnFshij_Click(object sender, System.EventArgs e)
        {
            string id = dgvListaEDentisteve.SelectedRows[0].Cells[0].Value.ToString();
            string perdoruesi = dgvListaEDentisteve.SelectedRows[0].Cells[3].Value.ToString();
            DialogResult dr = MessageBox.Show("A jeni i sigurte qe deshironi ta fshini dentistin me emrin e perdorusit: " + perdoruesi,
                                              "Konfirmo ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dentist dentist = new Dentist(id);
                dentistService.removeDentist(dentist);
                Init();
            }
        }
    }
}
