﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {
        public static void Izvedi()
        {
            // Program od korisnika traži unos broj godina koje ima korisnik
            // Program ispisuje da li je korisnik punoljetna osoba ili ne

            int godine;
            Console.Write("Unesite svoje godine: ");
            godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("Vi ste punoljetna osoba");
            }
            else
            {
                Console.WriteLine("Ti nisi punoljetan ");
            }
        }
    }
}
