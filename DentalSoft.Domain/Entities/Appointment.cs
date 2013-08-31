using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Domain
{
    public class Appointment
    {
        private IDGenerator idGenerator = new IDGenerator();
        private string id;
        private string emriPacientit;
        private int mosha;
        private string email;
        private string telefoni;
        private DateTime dataTakimit;
        private int kohezgjatjaTakimit;
        private string problemi;
        private string komenti;

        public string getId()
        {
            return id;
        }

        public void setId(string id = null)
        {
            if (id != null)
                this.id = id;
            else
                this.id = idGenerator.newID();
        }

        public string getEmriPacientit()
        {
            return emriPacientit;
        }

        public void setEmriPacientit(string emriPacientit)
        {
            this.emriPacientit = emriPacientit;
        }

        public int getMosha()
        {
            return mosha;
        }

        public void setMosha(int mosha)
        {
            this.mosha = mosha;
        }
        
        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getTelefoni()
        {
            return telefoni;
        }

        public void setTelefoni(string telefoni)
        {
            this.telefoni = telefoni;
        }

        public DateTime getDataTakimit()
        {
            return dataTakimit;
        }

        public void setDataTakimit(DateTime dataTakimit)
        {
            this.dataTakimit = dataTakimit;
        }

        public int getKohezgjatjaTakimit()
        {
            return kohezgjatjaTakimit;
        }

        public void setKohezgjatjaTakimit(int kohezgjatjaTakimit)
        {
            this.kohezgjatjaTakimit = kohezgjatjaTakimit;
        }

        public string getProblemi()
        {
            return problemi;
        }

        public void setProblemi(string problemi)
        {
            this.problemi = problemi;
        }

        public string getKomenti()
        {
            return komenti;
        }

        public void setKomenti(string komenti)
        {
            this.komenti = komenti;
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
