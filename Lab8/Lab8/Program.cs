using System;
using System.Collections.Generic;

namespace powtorzenie_kolos

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ksiazka> booklist = new List<ksiazka>();
            booklist.Add(new ksiazka("Atomowe nawyki", "Autor kto?", 2022));
            booklist.Add(new ksiazka("Co ze mną nie tak?", "Autor kto?", 2022));
            booklist.Add(new ksiazka("Cieszę się, że moja mama umarła", "Jennete McCurdy", 2023)); //jak coś, to jest prawdziwa książka, proszę nie dziwić się z nazwy :)
            booklist.Add(new ksiazka("Mój ukochany syn", "Amanda Prowsley", 2023));

            static void WriteByAuthor(List<ksiazka> spis, string author)
            {
                Console.WriteLine($"Books of author {author}: ");
                foreach (var book in spis)
                {
                    if (book.Author == author)
                    {
                        book.info();
                    }
                }
            }

            static void WriteByYear(List<ksiazka> spis, int year)
            {
                Console.WriteLine($"Books published in year {year}: ");
                foreach (var book in spis)
                {
                    if (book.PublishingYear == year)
                    {
                        book.info();
                    }
                }
            }

            static void EditAuthor(List<ksiazka> spis, string title, string newauthor)
            {
                foreach (var book in spis)
                {
                    if (book.info() == title)
                    {
                        book.Author = newauthor;
                        Console.WriteLine($"Changed the author of the book {title} to {newauthor}.");
                        return;

                    }
                }
                Console.WriteLine($"Error while finding the book with title {title}.");
            }

            static void Delete(List<ksiazka> spis, string title)
            {
                ksiazka bookToDelete = spis.Find(k => k.info() == title);
                if (bookToDelete != null)
                {
                    spis.Remove(bookToDelete);
                    Console.WriteLine($"Successfully deleted book {title}.");
                }
                else
                {
                    Console.WriteLine($"Error while finding the book with title {title}");
                }
            }

            WriteByAuthor(booklist, "Autor kto?");
            WriteByYear(booklist, 2022);

            booklist.Add(new ksiazka("Computer engineering for babies", "Autor?", 2019));

        }
    }
}
