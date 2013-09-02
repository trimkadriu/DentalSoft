using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Library
{
    public class Utilities
    {
        public string convertDateForDB(DateTime dateTime)
        {
            string format = "yyyy-MM-dd HH-MM-ss";
            System.Diagnostics.Debug.WriteLine(Convert.ToDateTime(dateTime).ToString(format));
            return Convert.ToDateTime(dateTime).ToString(format);
        }
    }
}