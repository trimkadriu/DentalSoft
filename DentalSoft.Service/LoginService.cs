using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Repositories;
using System.Collections.Generic;

namespace DentalSoft.Service
{
    public class LoginService
    {
        private DentistsRepository dentistsRepository;
        private Encryptor encryptor;

        public LoginService()
        {
            dentistsRepository = new DentistsRepository();
            encryptor = new Encryptor();
        }

        public bool doLogin(string username, string password)
        {
            List<Dentist> result = dentistsRepository.selectStatement(null, null, null, username, encryptor.encrypt(password));
            if (result.Count == 1)
                return true;
            return false;
        }
    }
}
