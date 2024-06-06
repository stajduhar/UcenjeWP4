namespace UcenjeCS
{
    internal class E01Z3
    {

        public static void Izvedi()
        {
            //zadatak
            // Za uneseni cijeli broj ispisati True ako je parni ili False ako je neparni
                int broj;
                Console.WriteLine("Unesi broj: ");
                broj = int.Parse(Console.ReadLine());
                int modulo = broj % 2;
                Console.WriteLine(modulo < 1);
        }

    }
}
