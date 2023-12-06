using Lab5.Zad2;
using System.Diagnostics;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zad1();
            zad2();
        }

        static void zad1()
        {
            Shape shape = new Circle(5);
            shape = new Square() { X = 2 };
            Console.WriteLine(shape.Calculate());
        }

        static void zad2()
        {
            var konto = new Account();

            konto.Add(new IncomeTransaction() { Amount = 645 });
            konto.Add(new ExpenseTranstaction() { Amount = 50 });
            konto.Add(new IncomeTransaction() { Amount = 654 });

            konto.DisplaySummary();
        }
    }
}
