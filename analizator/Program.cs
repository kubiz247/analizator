using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nie ma algortmu eukaliptusa to sie nie skracaja
            //korzysci: krotszy, przejrzysty, szybszy i bardziej zrozumialy kod

            wyswietlUlamek(48, 18);
            wyswietlUlamek(100, 25);
            wyswietlUlamek(17, 13);
        }

        /*
        nazwa funkcji: wyswietlUlamek
        opis funkcji: wypisuje ulamek i skrocony ulamek, tworzy algorytm eukaliptusa
        parametry: 
            int licznik - liczba odpowiadajaca za licznik
            int mianownik - liczba odpowiadajaca za mianownik
        zwracany typ i opis: zwracany jest skrocony ulamek przez algorytm
        */
        public static void wyswietlUlamek(int licznik, int mianownik)
        {

            Console.WriteLine("Ułamek: " + licznik + "/" + mianownik);
            Console.WriteLine("Skrócony: " + licznik/nwd(mianownik, licznik) + "/" + mianownik/nwd(licznik, mianownik));
            Console.WriteLine("—");

            int nwd(int a, int b)
            {
                if (b == 0)
                {
                    return a;
                }
                return nwd(b, a % b);
            }
            Console.WriteLine(nwd(18, 6));

        }

    }
}
