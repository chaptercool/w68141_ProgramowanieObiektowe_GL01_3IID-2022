using System;

class Sumator
{
    private int[] Liczby;

    // Konstruktor z jednym parametrem
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    // Metoda zwracająca sumę wszystkich liczb z pola Liczby
    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    // Metoda zwracająca sumę liczb z pola Liczby podzielnych przez 3
    public int SumaPodziel3()
    {
        int sumaPodziel3 = 0;
        foreach (int liczba in Liczby)
        {
            if (liczba % 3 == 0)
            {
                sumaPodziel3 += liczba;
            }
        }
        return sumaPodziel3;
    }

    // Metoda zwracająca liczbę elementów w tablicy
    public int IleElementów()
    {
        return Liczby.Length;
    }

    // Metoda wypisująca wszystkie elementy tablicy
    public void WypiszElementy()
    {
        Console.Write("Elementy tablicy: ");
        foreach (int liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    // Metoda wypisująca elementy o indeksach >= lowIndex i <= highIndex
    public void WypiszElementyWedługZakresu(int lowIndex, int highIndex)
    {
        Console.Write("Elementy w zakresie [{0}, {1}]: ", lowIndex, highIndex);

        for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
        {
            Console.Write(Liczby[i] + " ");
        }

        Console.WriteLine();
    }
}