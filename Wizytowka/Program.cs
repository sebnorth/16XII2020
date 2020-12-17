using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizytowka
{
    class Program
    {
        struct Osoba {

            public string imie;
            public string nazwisko;
            public string adres;
            public string nr_telefonu;
        }
        static void Main(string[] args)
        {
            Osoba osoba;
            Console.WriteLine("Podaj imię: ");
            osoba.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            osoba.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj adres: ");
            osoba.adres = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu: ");
            osoba.nr_telefonu = Console.ReadLine();

            // wydruk wizytówki
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("*");
            Console.Write("*{0} {1}*", osoba.imie, osoba.nazwisko);
            Console.WriteLine();
            Console.Write("*{0}*", osoba.adres);
            Console.WriteLine();
            Console.Write("*{0}*", osoba.nr_telefonu);
            Console.WriteLine();
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();

        }
    }
}
