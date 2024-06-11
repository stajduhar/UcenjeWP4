using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {
        public static void Izvedi()
        {
            // Korisnik unosi dva decimalna broja
            // Program ispisuje veći ili Jednaki su ako su uneseni brojevi jednaki

            int broj1;
            Console.Write("Unesite prvi broj: ");
            broj1 = int.Parse(Console.ReadLine());
            int broj2;
            Console.Write("Unesite drugi broj: ");
            broj2 = int.Parse(Console.ReadLine());
            if (broj1 > broj2)
            {
                Console.WriteLine("" + broj1);
            }
            else if (broj1 < broj2)
            {
                Console.WriteLine("" + broj2);
            }
            else
            {
                Console.WriteLine("Brojevi su jednaki");
            }
        }
    }
}
