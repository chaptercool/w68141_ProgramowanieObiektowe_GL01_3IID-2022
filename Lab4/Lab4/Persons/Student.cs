using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Persons
{
    public class Student : Person
    {
        public string School { get; set; }
        public bool CanGoHomeAlone { get; set; }

        public void SetSchool(string school)
        {
            if (string.IsNullOrEmpty(School))
                School = school;
            else
                throw new Exception("Cannot set school");
        }

        public void ChangeSchool(string school)
        {
            School = school;
        }

        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            CanGoHomeAlone = canGoHomeAlone;
        }

        public string Info()
        {
            if (GetAge() >= 12)
                return "Ma wiecej niż 12 lat";
            if (CanGoHomeAlone)
                return "Ma zgodę";
            return "Nie ma zgody i ma mniej niż 12 lat";
        }


        public override bool CanGoAloneToHome()
        {
            return CanGoHomeAlone || GetAge() >= 12;
        }

        public override string GetEducationInfo()
        {
            return School;
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
