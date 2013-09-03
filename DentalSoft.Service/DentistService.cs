using DentalSoft.Domain;
using DentalSoft.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DentalSoft.Service
{
    public class DentistService
    {
        private DentistsRepository dentistsRepository;

        public DentistService()
        {
            dentistsRepository = new DentistsRepository();
        }

        public bool editDentist(Dentist dentist)
        {
            List<Dentist> dentists = dentistsRepository.selectStatement(null, null, dentist.getEmail());
            if (dentists.Count == 1 && !dentists[0].getPerdoruesi().Equals(dentist.getPerdoruesi()))
            {
                MessageBox.Show("Ky email eshte duke u perdorur. Ju lutem zgjedhni email tjeter.", "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                dentistsRepository.updateStatement(dentist);
            return true;
        }
    }
}
