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
            // Aplikacja przyjmuje ułamki i wyświetla je 

            wyswietlUlamek(48, 18);
            wyswietlUlamek(100, 25);
            wyswietlUlamek(17, 13);
        }
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
