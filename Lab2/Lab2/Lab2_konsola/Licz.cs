namespace Lab2_konsola
{
    class Licz
    {
        private int wartość;

        public Licz(int początkowaWartość)
        {
            wartość = początkowaWartość;
        }

        public void Dodaj(int liczba)
        {
            wartość += liczba;
        }

        public void Odejmij(int liczba)
        {
            wartość -= liczba;
        }

        public void WypiszStan()
        {
            Console.WriteLine("Aktualna wartość: " + wartość);
        }
    }

}
