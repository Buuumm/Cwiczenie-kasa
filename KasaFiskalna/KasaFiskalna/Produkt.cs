using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Produkt
    {
        string nazwa;
        double cenaJednostkowa;
        int ilosc;

        public void Produkty(string naz, double ce, int il)
        {
            this.nazwa = naz;
            this.cenaJednostkowa = ce;
            this.ilosc = il;
        }
    }
}
