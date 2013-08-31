using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Domain
{
    class Appointment
    {
        private IDGenerator idGenerator;

        public string id
        {
            get { return id; }
            set { id = idGenerator.newID(); }
        }

        public string emriPacientit
        {
            get { return emriPacientit; }
            set { emriPacientit = value; }
        }

        public int mosha 
        {
            get { return mosha; }
            set { mosha = value; }
        }

        public string email
        {
            get { return email; }
            set { email = value; }
        }

        public string telefoni
        {
            get { return telefoni; }
            set { telefoni = value; }
        }

        public DateTime dataTakimit
        {
            get { return dataTakimit; }
            set { dataTakimit = value; }
        }

        public int kohezgjatjaTakimit
        {
            get { return kohezgjatjaTakimit; }
            set { kohezgjatjaTakimit = value; }
        }

        public string problemi
        {
            get { return problemi; }
            set { problemi = value; }
        }

        public string komenti
        {
            get { return komenti; }
            set { komenti = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Appointment c = obj as Appointment;
                if (id.Equals(c.id))
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
            return "Takimi: ID[" + id + "]";
        }
    }
}
