using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            // program od korisnika unosi 10 brojeva
            // program ispisuje zbroj svih unesenih brojeva
            // i nakon toga ispisuje unesene brojeve jedno ispod drugog

            // primjer
            // 10
            // 1
            // 3
            // 0
            // 0
            // 1
            // 1
            // 1
            // 1
            // 1
            // 1


            int ub = 10; //ovo može i korisnik unijeti
            int[] brojevi = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesi {0}. broj: ", 1+1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }

            int zbroj = 0;
            foreach(var b in brojevi)
            {
                zbroj += b;
            }
            Console.WriteLine(zbroj);
            int index = 0;
            while (index < ub)
            {
                Console.WriteLine(brojevi[index++]);
            }


            /*

                int i;

            while (true)
            {
                Console.WriteLine("Unesi cijeli pozitivni broj: ");
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i > 0 && i < 100)
                    {
                        break;
                    }
                    Console.WriteLine("Uneseni broj nije veći od 0 i manji od 100");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Niste unijeli cijeli pozitivni broj.");
                }
            }
            // ovdje si 100 % siguran da je unešen cijeli broj
            Console.WriteLine("Unijeli ste broj " + i);

            */
        }
    }
}
