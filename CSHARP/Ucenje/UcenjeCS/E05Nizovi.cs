using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {

            // eng. Arrays
            // još na HR polja

            // jednodimenzionalni niz
            int[] godine = new int[17];

            godine[0] = 43; // Element na indexu 0 poprima vrijednost 43
            //...
            godine[godine.Length - 1] = 23; // na zadnji element postavljam vrijednost 23

            Console.WriteLine(godine);
            Console.WriteLine(string.Join(",", godine));


            // skraćena sintaksa definiranja niza skupa s zadanim vrijednostima 

            int[] niz = { 2, 5, 3, 4, 1, 62, 42, 22, 12, 62, 27, 28, 2, };

            //Ispiši broj 8
            Console.WriteLine(niz[1]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo" };


            // dvodimenzionalni niz
            // tablica, matrica

            int[,] tablica = {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
                };

            // ispiši broj 3
            Console.WriteLine(tablica[0,2]);



            // zvjezdane staze
            int[,,,,] multiverse = new int[10, 10, 10, 10,10];

            // smisao nizova u CSHARP je da budu istog tipa

            object[] objekti = { 1, "Pero", true, 2.2 };

        }

    }
}
