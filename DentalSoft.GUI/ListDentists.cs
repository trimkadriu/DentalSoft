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
        private DataTable dataTable;

        public frmListDentists()
        {
            InitializeComponent();
            dentistService = new DentistService(); 
            dataTable = new DataTable();
            Init();
        }

        private void Init()
        {
            List<Dentist> dentists = dentistService.getAllDentists();
            dataTable.Columns.AddRange(null);
        }
    }
}
