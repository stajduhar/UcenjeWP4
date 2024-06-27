using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.NewFolder
{
    internal class Book
    {
        public int? Id { get; set; }

        public string? TheTitleOfTheBook { get; set; }

        public Author? AuthorOfTheBook { get; set; }

        public Genre? BookGenre { get; set; }
    }
}
