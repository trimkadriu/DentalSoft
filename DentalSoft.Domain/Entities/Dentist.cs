using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Domain
{
    public class Dentist
    {
        private IDGenerator idGenerator;

        public string id
        {
            get { return id; }
            set { id = idGenerator.newID(); }
        }

        public string emri
        {
            get { return emri; }
            set { emri = value; }
        }

        public string email
        {
            get { return email; }
            set { email = value; }
        }

        public string perdoruesi
        {
            get { return perdoruesi; }
            set { perdoruesi = value; }
        }

        public string fjalekalimi
        {
            get { return fjalekalimi; }
            set { fjalekalimi = value; }
        }

        public byte[] fotoProfilit
        {
            get { return fotoProfilit; }
            set { fotoProfilit = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Dentist c = obj as Dentist;
                if (id.Equals(c.id) || perdoruesi.Equals(c.perdoruesi))
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return "Dentist: perdoruesi[" + perdoruesi + "]";
        }
    }
}
