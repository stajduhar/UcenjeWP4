using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal class Smjer: Entitet
    {
        public string? Naziv { get; set; }

        // prepisavenj (override) metode je kada u podklasi definiramo 
        //metodu istog naziva u nadklasi
        public override string ToString()
        {
            Console.WriteLine(VidiSeUPodKlasi);
            return this.Naziv; // .this znaći ova klasa, .base znaći bilo koja klasa iznad nje
        }





    }
}
