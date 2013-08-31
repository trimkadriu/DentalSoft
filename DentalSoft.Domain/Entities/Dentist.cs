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
        private IDGenerator idGenerator = new IDGenerator();
        private string id;
        private string emri;
        private string email;
        private string perdoruesi;
        private string fjalekalimi;
        private byte[] fotoProfilit;

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

        public string getEmri()
        {
            return emri;
        }

        public void setEmri(string emri)
        {
            this.emri = emri;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPerdoruesi()
        {
            return perdoruesi;
        }

        public void setPerdoruesi(string perdoruesi)
        {
            this.perdoruesi = perdoruesi;
        }

        public string getFjalekalimi()
        {
            return fjalekalimi;
        }

        public void setFjalekalimi(string fjalekalimi)
        {
            this.fjalekalimi = fjalekalimi;
        }

        public byte[] getFotoProfilit()
        {
            return fotoProfilit;
        }

        public void setFotoProfilit(byte[] fotoProfilit)
        {
            this.fotoProfilit = fotoProfilit;
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
