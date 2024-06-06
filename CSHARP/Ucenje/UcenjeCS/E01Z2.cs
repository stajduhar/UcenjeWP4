namespace UcenjeCS
{
    internal class E01Z2
    {

        public static void Izvedi()
        {
            // zadatak
            // korisnik će unijeti dvoznamenkasti broj
            // Ispisuje se prva znamenka
            // 56 => 5
            // 11 => 1

            int broj;
            int broj_nakon_djeljenja;
            Console.WriteLine("Unesite dvoznamenkasti cijeli broj: ");
            broj = int.Parse(Console.ReadLine());
            broj_nakon_djeljenja = broj / 10;
            Console.WriteLine(broj_nakon_djeljenja);

        }

    }
}
