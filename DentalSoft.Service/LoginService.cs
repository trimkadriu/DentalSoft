using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Repositories;
using System;
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

        public Dentist doLogin(string username, string password)
        {
            List<Dentist> result = dentistsRepository.selectStatement(null, null, null, username, encryptor.encrypt(password));
            if (result.Count == 1)
            {
                Dentist dentist = (Dentist)result[0].Clone();
                updateLastLogin(result[0]);
                return dentist;
            }
            return null;
        }

        public void updateLastLogin(Dentist dentist)
        {
            dentist.setQasjaFundit(DateTime.Now);
            dentistsRepository.updateStatement(dentist);
        }
    }
}
