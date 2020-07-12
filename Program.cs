using System;

namespace wisielec_wsei_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w grze wisielec!");
            Console.WriteLine("********************");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                *   *");
            Console.WriteLine("*                *   *");
            Console.WriteLine("*            *     *     *");
            Console.WriteLine("*              *   *   *");
            Console.WriteLine("*                * * *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  *");
            Console.WriteLine("*                  * *");
            Console.WriteLine("*                 *   *");
            Console.WriteLine("*                *     *");
            Console.WriteLine("*               *       *");
            Console.WriteLine("*              *          *");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("**********************************");
            Console.WriteLine("**********************************");



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Podaj imię: ");

            string name = Console.ReadLine();

            Console.WriteLine("Cześć " + name);
            Console.WriteLine("czy znasz zasady gry? (t/m)");
            string answer = Console.ReadLine();
            if (answer == "t")
            {
                Console.WriteLine("Zaczynamy grę!");
            }
            else
            {
                Console.WriteLine("\tPierwszy gracz wymyśla słowo, ujawniając na przykład za pomocą poziomych kresek liczbę tworzących je liter. \nDrugi z graczy stara się odgadnąć litery słowa. Za każdym razem, gdy mu się to uda, pierwszy gracz wstawia literę w odpowiednie miejsce; \nw przeciwnym wypadku rysuje element symbolicznej szubienicy i wiszącego na niej ludzika. Jeżeli pierwszy gracz narysuje kompletnego „wisielca” zanim drugi odgadnie słowo, wówczas wygrywa. \nW zależności od wcześniej ustalonego stopnia skomplikowania rysunku „wisielca” (liczba elementów potrzebna do jego narysowania), gra pozwala na mniej lub więcej pomyłek odgadującego[1].");
            }

            Console.WriteLine("Losuj słowo");
            Console.ReadKey();
            Random los = new Random();

            string[] words = {
                "Alaska",
                "Altana",
                "Arbuz",
                "Arystokracja",
                "Ameba",
                "banan",
                "baran",
                "bałwan",
                "bermudy",
                "boczek",
                "czrownica",
                "czas",
                "czaszka",
                "cytryna",
                "czapka",
                "dom",
                "drzewo",
                "drut",
                "drabina",
                "dywan",
                "ewakuacja",
                "epopeja",
                "europa",
                "Etiopia",
                "Egipt",
                "flet",
                "finka",
                "farba",
                "flaga",
                "falbana"
            };


            int wordID = los.Next(words.Length);
            Console.WriteLine(words[wordID]);
           
          



            Console.ReadKey();
        }
    }


}
