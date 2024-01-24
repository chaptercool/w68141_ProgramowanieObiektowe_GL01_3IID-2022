using System;

namespace powtorzenie_kolos
{
    class ksiazka
    {
        private string title;
        private string author;
        private int publ_date;

        public ksiazka(string title, string author, int publ_date)
        {
            this.title = title;
            this.author = author;
            this.publ_date = publ_date;
        }

        public void info()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Publication date: {publ_date}\n");
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PublishingYear
        {
            get { return publ_date; }
            set { publ_date = value; }
        }
    }
}

