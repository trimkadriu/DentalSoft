using DentalSoft.Domain.Enums;
using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Domain
{
    public class Report
    {
        private IDGenerator idGenerator = new IDGenerator();
        private string id;
        private string emriPacientit;
        private int mosha;
        private Gender gjinia;
        private string problemi;
        private int pagesa;
        private Status perseritKontrollin;

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

        public Gender getGjinia()
        {
            return gjinia;
        }

        public void setGjinia(Gender gjinia)
        {
            this.gjinia = gjinia;
        }

        public string getProblemi()
        {
            return problemi;
        }

        public void setProblemi(string problemi)
        {
            this.problemi = problemi;
        }

        public int getPagesa()
        {
            return pagesa;
        }

        public void setPagesa(int pagesa)
        {
            this.pagesa = pagesa;
        }

        public Status getPerseritKontrollin()
        {
            return perseritKontrollin;
        }

        public void setPerseritKontrollin(Status perseritKontrollin)
        {
            this.perseritKontrollin = perseritKontrollin;
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Report c = obj as Report;
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
            return "Raporti: ID[" + id + "]";
        }
    }
}
