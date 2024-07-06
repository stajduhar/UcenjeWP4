using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class raspored
    {
        public raspored()
        {
            // u ljetnim mjesecima svakih mjesec dana a u zimskim svaka 2 tjedna

            // 08. 07. 2024. - 14. 07. 2024.,Stan1
            // 15. 07. 2024. - 21. 07. 2024.,Stan2
            // 22. 07. 2024. - 28. 07. 2024.,Stan3

            DateTime datumOd = DateTime.Parse("2024-07-08");
            DateTime datumDo=datumOd;
            DateTime tjedan = datumOd;
            int broj = 0;

            while (datumOd.Year < 2028)
            {
                if (tjedan.Month >= 4 && tjedan.Month <= 10)
                {
                    datumDo = datumOd.AddDays(27);
                }
                else
                {
                    datumDo = datumOd.AddDays(13);
                }
                tjedan = datumOd.AddDays(6);

                //datumDo = datumOd.AddDays(7);
                Console.WriteLine("{0} - {1}, Stan {2}",
                    datumOd.ToString("dd.MM.yyyy."),
                    tjedan.ToString("dd.MM.yyyy."),++broj %3 +1);
                //    datumDo.AddDays(7).ToString("dd.MM.yyyy."));
                datumOd = datumDo.AddDays(1);
            }


        }
    }
}
