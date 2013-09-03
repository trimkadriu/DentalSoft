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

        public bool insertDentist(Dentist dentist)
        {
            //VALIDOJE EMAILIN
            List<Dentist> dentistsByEmail = dentistsRepository.selectStatement(null, null, dentist.getEmail());
            if (dentistsByEmail.Count == 1)
            {
                MessageBox.Show("Ky email eshte duke u perdorur. Ju lutem zgjedhni email tjeter.", "Gabim!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            List<Dentist> dentistsByPerdoruesi = dentistsRepository.selectStatement(null, null, null, dentist.getPerdoruesi());
            if (dentistsByPerdoruesi.Count == 1)
            {
                MessageBox.Show("Ky emer i perdoruesit (per qasje) eshte duke u perdorur. Ju lutem zgjedhni emer tjeter.", "Gabim!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            dentistsRepository.insertStatement(dentist);
            return true;
        }
    }
}
