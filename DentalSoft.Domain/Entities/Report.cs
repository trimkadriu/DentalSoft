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
        private string dentistId;
        private string takimiId;
        private string takimiArdhshem;
        private decimal pagesa;
        private TakimiRiStatus takimiArdhshemStatus;
        private DateTime dataKrijimit;

        public Report()
        {
            setId();
        }

        public Report(string id = null, string dentistId = null, string takimiId = null, string takimiArdhshem = null, decimal pagesa = 0,
                      TakimiRiStatus? takimiArdhshemStatus = null, DateTime? dataKrijimit = null)
        {
            setId(id);
            if (dentistId != null)
                this.dentistId = dentistId;
            if (takimiId != null)
                this.takimiId = takimiId;
            if (takimiArdhshem != null)
                this.takimiArdhshem = takimiArdhshem;
            if (pagesa != 0)
                this.pagesa = pagesa;
            if (takimiArdhshemStatus.HasValue)
                this.takimiArdhshemStatus = takimiArdhshemStatus.Value;
            else
                this.takimiArdhshemStatus = TakimiRiStatus.Pacaktuar;
            if (dataKrijimit.HasValue)
                this.dataKrijimit = dataKrijimit.Value;

        }

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

        public string getDentistId()
        {
            return dentistId;
        }

        public void setDentistId(string dentistId)
        {
            this.dentistId = dentistId;
        }

        public string getTakimiId()
        {
            return takimiId;
        }

        public void setTakimiId(string takimiId)
        {
            this.takimiId = takimiId;
        }

        public string getTakimiArdhshem()
        {
            return takimiArdhshem;
        }

        public void setTakimiArdhshem(string takimiArdhshem)
        {
            this.takimiArdhshem = takimiArdhshem;
        }

        public decimal getPagesa()
        {
            return pagesa;
        }

        public void setPagesa(decimal pagesa)
        {
            this.pagesa = pagesa;
        }

        public TakimiRiStatus getTakimiArdhshemStatus()
        {
            return takimiArdhshemStatus;
        }

        public void setTakimiArdhshemStatus(TakimiRiStatus takimiArdhshemStatus)
        {
            this.takimiArdhshemStatus = takimiArdhshemStatus;
        }

        public void setTakimiArdhshemStatus(string takimiArdhshemStatus)
        {
            this.takimiArdhshemStatus = (TakimiRiStatus)Enum.Parse(typeof(TakimiRiStatus), takimiArdhshemStatus);
        }

        public void setDataKrijimit(DateTime dataKrijimit)
        {
            this.dataKrijimit = dataKrijimit;
        }

        public DateTime getDataKrijimit()
        {
            return dataKrijimit;
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
