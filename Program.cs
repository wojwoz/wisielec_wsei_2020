using System;
using System.Runtime.CompilerServices;

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


           
            // do przebudowy
            if (answer.ToLower() == "t")
            {
                Console.WriteLine("Zaczynamy grę!");
                Console.Clear();
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("\tPierwszy gracz wymyśla słowo, ujawniając na przykład za pomocą poziomych kresek liczbę tworzących je liter. \nDrugi z graczy stara się odgadnąć litery słowa. Za każdym razem, gdy mu się to uda, pierwszy gracz wstawia literę w odpowiednie miejsce; \nw przeciwnym wypadku rysuje element symbolicznej szubienicy i wiszącego na niej ludzika. Jeżeli pierwszy gracz narysuje kompletnego „wisielca” zanim drugi odgadnie słowo, wówczas wygrywa. \nW zależności od wcześniej ustalonego stopnia skomplikowania rysunku „wisielca” (liczba elementów potrzebna do jego narysowania), gra pozwala na mniej lub więcej pomyłek odgadującego[1].");
            }

            else
            {
                Console.WriteLine("błędna odpowiedź");
            }

            Console.WriteLine("Losuj słowo - naciśnij dowolny klawisz");
            Console.ReadKey();
            Console.Clear();
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

            string[] prompt =
            { "sprzedana przez rosję do USA","można się w niej schronić latem", "inaczej kawon", "błękitna krew",
            "pierwotniak",
            "inaczej figa rajska",
            "pierwszy astrologiczny znak zodiaku",
            "człowiek ze śniegu",
            "spodnie i wyspy",
            "może być wieprzowy",
            "lata na miotle",
            "ciągle ucieka",
            "rozmówca hamleta",
            "roślina z rodziny rutowatych",
            "grzeje w zimie osłania latem",
            "moja twierdza",
            "wieloletnia roślina  o zdrewniały jednym pędzie głównym np. bonsai",
            "może być kolczasty",
            "np.Jakubowa lub tytuł piosenki led zeppelin",
            "Latał na nim Alladyn",
            "w czasie pożaru",
            "inaczej poemat",
            "stary kontynent",
            "kraj w Afryce",
            "państwo Ozyrysa",
            "instrument np. poprzeczny",
            "mały nożyk", "służy do malowania", "każdy kraj  ma swoją", "w sukience", "rośnie po deszczu", "zostaje po zawalonym budynku", "hydra miała ich siedem", "typowy ptak na rynku Krakowskim", "smaczny owoc"};


            int wordID = los.Next(words.Length);

            string haslo = words[wordID]; // losowanie słowa
            int ileLiterWslowie = haslo.Length;
            char[] litery = new char[haslo.Length];

            for(int i = 0; i < ileLiterWslowie; i++)
            {
                litery[i] = "*";
            }
           




           // Console.WriteLine(haslo + " -Twoje hasło ma 6 liter"); // wylosowane słowo do odgadnięcia. 

            Console.WriteLine("     Podpowiedź     ");

            Console.WriteLine(prompt.GetValue(wordID)); // podpowiedź


            string test = Console.ReadLine(); // sprawdzanie litery
                                              // bool a = haslo.Contains(test);
            Console.ReadKey();
            Console.Clear();

            int sum = 0;

            if (haslo.Contains(test))
            {
                Console.WriteLine(test + " -zgadłeś");
                Console.WriteLine("otrzymujesz 1pkt!");
                sum++;
                Console.WriteLine("Twoje punty: " + sum);


            }
            else
            {
                Console.WriteLine("zadane słowo nie zawiera tej litery - brak punktów");

            }
            // Console.WriteLine(a);

            /*
            var replacement = haslo.Replace(haslo, "*");
            Console.WriteLine(replacement);
            */

            Console.ReadLine();
            Console.ReadKey();
        }
    }


}
