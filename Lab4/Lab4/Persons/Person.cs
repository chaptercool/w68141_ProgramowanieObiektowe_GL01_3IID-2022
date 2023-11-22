using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Persons
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string idnumber;

        public void SetFN(string fn)
        {
            fn = FirstName;
        }

        public void SetLN(string ln)
        {
            ln = LastName;
        }

        public void SetID(string id)
        {
            id = idnumber;
        }

        public string GetGender()
        {
            return int.Parse(idnumber[9].ToString()) / 2 == 0 ? "Woman" : "Man";
        }

        public int GetAge()
        {
            return 1; //DateTime.Now - GetBirthDay()).Days / 365;
        }

        private DateTime GetBirthDay()
        {
            var year = int.Parse(idnumber.Substring(0, 2));
            var month = int.Parse(idnumber.Substring(2, 2));
            var day = int.Parse(idnumber.Substring(4, 2));

        }

    }
}
