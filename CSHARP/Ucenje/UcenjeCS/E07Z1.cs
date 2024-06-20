using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        public static void Izvedi()
        {

            int broj;
            int i = 1;
            int b;
            Console.WriteLine("Unesi cijeli broj: ");
            broj = int.Parse(Console.ReadLine());

            while (++i <= broj) // može ići i || te !
            {
                b = i % 2;
                if (b == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        // Program od korisnika unosi cijeli broj
        // Koristeći while petlju program ispisuje
        // zbroj svih parnih brojeva od 1 do unesenog broja

    }
}
