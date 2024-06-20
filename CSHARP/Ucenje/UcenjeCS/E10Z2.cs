using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z2
    {
        public static void Izvedi()
        {
            
            // Za unesenu riječ provjerite da li je palindrom?
            // Palindrom je riječ koja se jednako čita sa lijeve i desne strane
            // anavolimilovana, 02022020, ananabraparbanana, evolove, evoove

                Console.Write("Unesi riječ: ");
                string rijec = Console.ReadLine();
                bool palindrom = true;
                for(int i = 0; i<rijec.Length/2; i++)
                {
                    if(rijec[i] != rijec[rijec.Length - 1 - i]) 
                    {
                        palindrom = false;
                    Console.WriteLine("Ovo nije palindrom");
                    break;
                }
            }
        }
    }
}
