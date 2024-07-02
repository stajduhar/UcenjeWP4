using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{

    // apstraktna klasa je ona klasa koja nema implementaciju
    // kreira s kako bi sadržavala zajednička svojstva i metode koje će koristiti
    // sve klase koje ju nasljeđuju
    internal abstract class Entitet: object // sve klase, dijele htjele one to ili ne, nasljeđuju klasu object
    {
        public int? Sifra { get; set; }

        protected int VidiSeUPodKlasi = 7;

        private int VidiSeSamoUKlasiUKojojJeDefinirano = 2;

        public override string ToString()
        {
            return Sifra.ToString();
        }

    }
}
