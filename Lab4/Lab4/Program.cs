using Lab4.Persons;
using Lab4.ShapesClasses;
using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad2();
        }

        static void Zad1()
        {
            var shapes = new List<Shape>();
            var shape1 = new Rectangle()
            {
                x = 5,
                width = 2
            };

            shape1.height = 3;

            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    shapes[i].Draw();
            //}
        }

        private static void Zad2()
        {
            var idnums = new List<long>()
            {
                13292313574,
                11272558326,
                11252623556,
                14222195514,
                13260515371,
                14281248851,
                13211445544,
                13290928392,
                14240472824,
                12310555824
            };

            var teacher = new Teacher();

            teacher.SetFN("Nauczyciel");
            teacher.SetLN("Nauczyciel");
            teacher.Title = "Dr";

            var students = new List<Student>();

            var i = 0;
            foreach (var idn in idnums)
            {
                var student = new Student();
                student.SetID(idn.ToString());
                student.SetFN("Student");
                student.SetLN(i.ToString());
                if (i == 4)
                    student.SetCanGoHomeAlone(true);
                students.Add(student);
                i++;
            }

            teacher.Students.AddRange(students);

            teacher.WhichStudentCanGoHomeAlone();

            teacher.DisplayClass(DateTime.Today);
        }
    }
}