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

        public string GetGender() => int.Parse(idnumber[9].ToString()) % 2 == 0 ? "Woman" : "Man";

        public int GetAge()
        {
            //return DateTime.Now.Year - GetBirthDay().Year;
            return (DateTime.Now - IDHelper.GetBirthDay(idnumber)).Days / 365;
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();

    }
}
