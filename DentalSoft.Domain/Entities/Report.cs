using DentalSoft.Domain.Enums;
using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Domain
{
    class Report
    {
        private IDGenerator idGenerator;

        public string id
        {
            get { return id; }
            set { id = idGenerator.newID(); }
        }

        public int mosha
        {
            get { return mosha; }
            set { mosha = value; }
        }

        public Gender gjinia
        {
            get { return gjinia; }
            set { gjinia = value; }
        }

        public string problemi
        {
            get { return problemi; }
            set { problemi = value; }
        }

        public int pagesa
        {
            get { return pagesa; }
            set { pagesa = value; }
        }

        public Status perseritKontrollin
        {
            get { return perseritKontrollin; }
            set { perseritKontrollin = value; }
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
