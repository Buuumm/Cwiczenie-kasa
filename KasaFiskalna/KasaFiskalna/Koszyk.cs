using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Koszyk: Produkt
    {
        List<Produkt> zakupy;

        public void Dodaj()
        {
            zakupy.Add(new Produkt()
            {

            });
        }

        public void Pokaz()
        {
            foreach(Produkt zakupylist in zakupy)
            {
                Console.WriteLine(zakupylist);
            }
        }

    }
}
