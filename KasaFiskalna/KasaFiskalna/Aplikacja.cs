using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Aplikacja
    {
        public char klawisz;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry !\n");
            Console.WriteLine("Co chcesz zrobic ? Wciśnij odpowiedni klawisz\n");
            Console.WriteLine("Legenda:\n");
            Console.WriteLine("P - dodaj produkt do koszyka \n");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt \n");
            Console.WriteLine("Z - pokaz zawartosc koszyka \n");
            Console.WriteLine("S - pokaz sume do zaplaty \n");
            Console.WriteLine("X - skasuj produkt z list (musisz znac wczesniej numer na liscie\n");
            Console.WriteLine("W - wydrukuj paragon\n");
            Console.WriteLine("N - dodaj nowy koszyk\n");
            Console.WriteLine("E - zakoncz dzialnie programu\n");
            
            this.klawisz = Convert.ToChar(Console.ReadLine());
            WykonajDzialanie(klawisz);
        }

        public void WykonajDzialanie(char klawisz)
        {
            switch (klawisz)
            {
                case 'P':
                    Console.WriteLine("PP");
                    break;

                case 'K':
                    Console.WriteLine("K");
                    break;
                case 'Z':
                    Console.WriteLine("Z");
                    break;
                case 'S':
                    Console.WriteLine("S");
                    break;
                case 'X':
                    Console.WriteLine("X");
                    break;
                case 'W':
                    Console.WriteLine("W");
                    break;
                case 'N':
                    Console.WriteLine("N");
                    break;
                case 'E':
                    Environment.Exit(1);
                    break;
            }
        }
    }
}