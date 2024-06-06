namespace UcenjeCS
{
    internal class E01Z1
    {

        public static void Izvedi()
        {
            // Program unosi dva cijela broja i ispisuje njihov zbroj
            int broj;
            int broj2;
            Console.WriteLine("Unesi prvi broj: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + broj2);
        }

    }
}
