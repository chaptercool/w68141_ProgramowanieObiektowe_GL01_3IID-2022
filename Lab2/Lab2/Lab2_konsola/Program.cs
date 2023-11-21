using Lab2_konsola;
using System.Security.Cryptography;
// Uwaga! Część kodu jest z lab1!!

// menu
Console.WriteLine("Witamy w programie 'Program'! Wybierz jedną z opcji poprzez wpisanie liczby:");
Console.WriteLine("1. Sprawdzenie parzystości liczby");
Console.WriteLine("2. Wypisywanie ciągu liczb na ekranie");
Console.WriteLine("3. Obliczenie silni");
Console.WriteLine("4. Gra");
Console.WriteLine("5. Konwerter stopni \n");
Console.WriteLine("LAB2");
Console.WriteLine("6. Klasa licz");
Console.WriteLine("7. Klasa sumator \n");
Console.WriteLine("Wpisz poniżej numer opcji: ");
int option = Convert.ToInt32(Console.ReadLine());

// (lab1)zadanie 3 (łącznie z zadaniami 1, 2, 4, 5 oraz 6)
switch (option)
{
    case 1:
        Odd_even_number();
        break;
    case 2:
        Line_of_numbers();
        break;
    case 3:
        Factorial_method();
        break;
    case 4:
        Guess_the_number();
        break;
    case 5:
        Converter();
        break;
    case 6:
        Calculator();
        break;
    case 7:
        Sumator();
        break;
    default:
        Console.WriteLine("Wybrana opcja jest niedostępna lub nie istnieje. Uruchom ponownie program aby zacząć ponownie.");
        break;

}

//(lab1)Zadanie 1
static void Odd_even_number()
{
    Console.WriteLine("Podaj liczbę do sprawdzenia: ");
    int checknum = Convert.ToInt32(Console.ReadLine());
    if (checknum == 0)
    {
        Console.WriteLine("Liczba 0 jest neutralna.");
    }
    else if (checknum % 2 == 0)
    {
        Console.WriteLine("Liczba " + checknum + " jest parzysta.");
    }
    else
    {
        Console.WriteLine("Liczba " + checknum + " jest nieparzysta.");
    }
}


//(lab1)Zadanie 2
static void Line_of_numbers()
{
    Console.WriteLine("Napisz, ile parzystych liczb chcesz widzieć na ekranie? ");
    int range = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < range; i++)
    {
        Console.Write(i + " ");
    }
    Console.Write(range);
}

//(lab1)Zadanie 4 (przez rekurencję)

static void Factorial_method()
{
    int Factorial_function(int a)
    {
        if (a == 0) return 1;
        return Factorial_function(a - 1) * a;
    }

    Console.WriteLine("Podaj liczbę do obliczenia silini: ");
    int fact_num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wynik obliczeń: " + Factorial_function(fact_num));
}

//(lab1)Zadanie 5
static void Guess_the_number()
{
    Console.WriteLine("Zagrajmy w grę! Komputer wymyśli sobie jakąś liczbę, a ty spróbujesz ją odgadnąć w jak najmniejszy sposób :D");
    var random = RandomNumberGenerator.GetInt32(1, 100);
    //Console.WriteLine(random); dla sprawdzenia działania programu
    Console.WriteLine("Komputer wymyślił sobie liczbę!");
    int i = 1;
    while (true)
    {
        Console.WriteLine("Jaka to może być liczba? Wpisz swoją odpowiedź w zakresie od 1 do 100: ");
        int user_answer = Convert.ToInt32(Console.ReadLine());
        if (user_answer == random)
        {
            Console.WriteLine("Jest to! Udało ci odgadnąć liczbę " + random + " z " + i + " próby!");
            break;
        }
        else
        {
            Console.WriteLine("Niestety, nie jest to ta liczba. Spróbuj ponownie:( \n");
            i++;
            continue;
        }
    }
}

//(lab1)Zadanie 6
static void Converter()
{
    Console.WriteLine("Podaj jednostkę w którą chcesz przekonwertować stopni Celsjusza: \n" + "\n" + "Dostępne opcję: \n" + "1. Fahrenheit \n" + "2. Kelvin \n" + "3. Rankine \n");
    int user_choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wpisz wartość: \n");
    int value = Convert.ToInt32(Console.ReadLine());
    switch (user_choice)
    {
        case 1:
            Console.WriteLine("Wynik: " + (value * 1.8 + 32));
            break;
        case 2:
            Console.WriteLine("Wynik: " + (value + 273.15));
            break;
        case 3:
            Console.WriteLine("Wynik: " + (value * 9 / 5 + 491.67));
            break;
        default:
            Console.WriteLine("Wybrana opcja jest niedostępna lub nie istnieje. Uruchom ponownie program aby zacząć ponownie.");
            break;
    }


}

//(lab2) Licz
static void Calculator()
{
    Console.WriteLine("Wpisz początkową wartość: \n");
    int number = Convert.ToInt32(Console.ReadLine());

    Licz mojaLiczba = new Licz(number);

    mojaLiczba.WypiszStan();

    while (true)
    {
        Console.WriteLine("Co aktualnie chcesz zrobić z liczbą? ");
        Console.WriteLine("1. Dodać \n 2. Odejmić \n 3. Wyjść z programu");
        int calc_option = Convert.ToInt32(Console.ReadLine());
        int calc_value;
        switch (calc_option)
        {
            case 1:
                Console.WriteLine("Wpisz wartość którą chcesz dodać niżej \n");
                calc_value = Convert.ToInt32(Console.ReadLine());
                mojaLiczba.Dodaj(calc_value);
                mojaLiczba.WypiszStan();
                break;
            case 2:
                Console.WriteLine("Wpisz wartość którą chcesz odjąć niżej \n");
                calc_value = Convert.ToInt32(Console.ReadLine());
                mojaLiczba.Odejmij(calc_value);
                mojaLiczba.WypiszStan();
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Nieznana opcja");
                break;

        }
    }
}

//(lab2)Sumator
static void Sumator()
{
    int[] liczby = { 36, 15, 87, 96, 56, 51, 78, 16, 5, 45, 35, 24, 2 };
    Sumator sumator = new Sumator(liczby);
    Console.WriteLine("Utworzono przykładowy zbiór danych \n");
    while (true)
    {
        Console.WriteLine("Co aktualnie chcesz zrobić?");
        Console.WriteLine("1. Zsumować dane z tablicy \n 2. Zsumować liczby które są podzielne na 3 \n 3. Wypisać ile elementów znajduje się w tablicę \n 4. Wypisać wszystkie elementy \n 5. Wypisać elementy zgodzie zakresu \n 6. Wyjść z programu");
        int sum_option = Convert.ToInt32(Console.ReadLine());
        switch (sum_option)
        {
            case 1:
                Console.WriteLine("Suma zbioru: " + sumator.Suma());
                break;
            case 2:
                Console.WriteLine("Suma liczb podzielnych przez 3: " + sumator.SumaPodziel3());
                break;
            case 3:
                Console.WriteLine(sumator.IleElementów() + " elementa/ów w tablice.");
                break;
            case 4:
                //Console.WriteLine(sumator.WypiszElementy()); nie działa
                break;
            case 5:
                Console.WriteLine("Wpisz początek: ");
                int low = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wpisz koniec: ");
                int high = Convert.ToInt32(Console.ReadLine());
                sumator.WypiszElementyWedługZakresu(low, high);
                break;
            case 6:
                Environment.Exit(0);
                break;
        }

    }
}
