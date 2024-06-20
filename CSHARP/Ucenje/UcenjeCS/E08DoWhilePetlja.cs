using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhilePetlja
    {
        public static void Izvedi()
        {

            // do while izddvaja činjenica da će se on barem jednom izvesti

            int i = 0;


            // uvijet je nakon Console.WriteLine što znaći da će se Console.WriteLine izvesti barem jednom
            do
            {
                Console.WriteLine("u do while " + i);
            } while (i > 0);



            // provjer uvjeta je na ulazu i zato se ne mora izvesti
            while (i > 0)
            {
                Console.WriteLine("u while " + i);
            }


        }
    }
}
