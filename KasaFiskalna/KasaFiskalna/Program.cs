﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja konsola=new Aplikacja();

            konsola.WczytajKlawisz();

            Console.ReadKey();
        }
    }
}
