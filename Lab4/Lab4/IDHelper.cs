using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class IDHelper
    {
        public static DateTime GetBirthDay(string idnumber)
        {
            var year = int.Parse(idnumber.Substring(0, 2));
            var month = int.Parse(idnumber.Substring(2, 2));
            var day = int.Parse(idnumber.Substring(4, 2));

            if (month > 80)
            {
                year = year + 1800;
                month = month - 80;
            }
            else if (month > 60)
            {
                year = year + 2200;
                month = month - 60;
            }
            else if (month > 40)
            {
                year = year + 2100;
                month = month - 40;
            }
            else if (month > 20)
            {
                year = year + 2000;
                month = month - 20;
            }
            else
            {
                year += 1900;
            }

            return new DateTime(year, month, day);
        }
    }
}
