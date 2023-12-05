using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Persons
{
    public class Teacher : Student
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public override string GetFullName()
        {
            return $"{Title} {base.GetFullName()}";
        }

        public void WhichStudentCanGoHomeAlone()
        {
            foreach (var student in Students.Where(x => x.CanGoAloneToHome()))
            {
                Console.WriteLine(student.GetFullName());
            }
        }

        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Day {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel {GetFullName()}");
            Console.WriteLine(GetEducationInfo());
            var i = 0;
            foreach (var student in Students)
            {
                i++;
                Console.WriteLine($"{i}. {student.GetFullName()} {student.GetGender()} {student.CanGoAloneToHome()} {student.Info()}");
            }
        }
    }
}
