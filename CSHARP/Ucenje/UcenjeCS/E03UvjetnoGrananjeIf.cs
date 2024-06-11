using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {


        public static void Izvedi()
        {

            int i = 8; // Nisam koristio Console.ReadLine kako bi bili brži

            // uvjetno granjanje if radi s bool tipom podataka

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            //minimalna if sintaksa
            if (uvjet) // u if granu se ulazi ako je vrijednost uvjeta true
            {
                Console.WriteLine("1. Ušao sam u if granu");
            }
            // dodatak (neobavezni dio) if grananja
            else
            {
                Console.WriteLine("2. Uvjet nije zaodovljen, otišao u else granu");
            }

            // uobičajena sintaksa što se tiče uvjeta
            if (i > 2) // ako ne postoje {} if se odnosi samo na 1. sljedeću liniju
                Console.WriteLine("3. Ušao u if bez vitičastih zagrada");
                Console.WriteLine("4. ovo se izvodi bez obzira na gornji if");

            var j = 2;

            // dodatni operatori & (and), &&, | (or), || (AltGr + W), ! (not)
            if (i<2 & j== 2)
            {
                Console.WriteLine("5. logičko &");                    
                    }

            if (j == 2 || i < 2)
            {
                Console.WriteLine("6. logičko or | ");

            }
                
                if(i != 5)
                {
                    Console.WriteLine("7. i nema vrijednost 5"); 
                }


            var ocjena = 4;

            if (ocjena == 1) 
            {
                Console.WriteLine("8. nedovoljan");
            }else if(ocjena == 2)
            {
                Console.WriteLine("9. dovoljan");
            }
            else
            {
                Console.WriteLine("10. Ocjena nije dobra");
            }


            // inline if 
            if(ocjena == 4)
            {
                Console.WriteLine("11. Vrlo dobar si");
            }
            else
            {
                Console.WriteLine("12. Ok si");
            }

            Console.WriteLine(ocjena==4 ? "11. Vrlo dobar si" : "12. Ok s");


            if (i > 0) 
            {
                if (ocjena==4) { 
                Console.WriteLine("12. Gnježđenje se može zapravo zamjeniti s &&");

                    }
            }



        }




    }
}
