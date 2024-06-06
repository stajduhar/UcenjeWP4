namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        // Formatiranje koda CTRL + K + D
        public static void Izvedi()
        {

            
            // Deklaracija varijabli 
            int broj;

            // dodjelivanje vrijednosti 
            broj = 7;

            Console.WriteLine("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());
            // korištenje varijable     
            Console.WriteLine(broj + 1);

            Console.WriteLine("Unesi decimalni broj: ");
            decimal db = decimal.Parse(Console.ReadLine());

            Console.WriteLine(db/10);

            // runtime error --> kada skripta pukne prilikom izvođenja ali sami kod nema error nego se erorr javi prilikom izvođenja


            Console.WriteLine(decimal.Parse(Console.ReadLine()));

            // modulo: Ostatak nakon cjelobrojnog djelenja
            int modulo = 5 % 2;
            Console.WriteLine(modulo);


            int i = 5;
            int j = 3;

            Console.WriteLine(i/(float)j); // (float) je cast 

            bool LogickaVrijednost = true; // to je u SQL bit 

            // Do sada prikazani operator:
            // = dodjeljivanje
            // % modulo 

            // == provjera jednakosti 

            Console.WriteLine(i==j);

            int k = 5, l = j; //

            var ime = "Edunova"; // desna strana određuje tip 

            // increment decrement 

            int b = 0;
            // uvećati za 1
            b = b + 1; // 1 
            b += 1; //2
            b++; //3
            ++b; //4

            Console.WriteLine(++b); // 5
            Console.WriteLine(b++); // 5
            Console.WriteLine(b); // 6

            // isto vrijedi i za decrement --b b--

            // Primjeri zadataka 

            int x=1, y = 2;
            Console.WriteLine("---------");
            x = ++y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            //Console.WriteLine("x={0}, y={1}", x y);
            Console.WriteLine("*********");

            y = x - --y; // 1
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("*********");

            Console.WriteLine(x+y); //4




        }

    }
}
