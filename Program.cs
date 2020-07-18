using System;
using System.Linq;

namespace wisielec_wsei_2020
{
    class Program
    {

        static void Main(string[] args)
        {
            //nic  nie wnosząca do gry "grafika
            Console.WriteLine("Witam w grze wisielec!");
            Console.WriteLine("          ********************");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                *   *");
            Console.WriteLine("          *                *   *");
            Console.WriteLine("          *            *     *     *");
            Console.WriteLine("          *              *   *   *");
            Console.WriteLine("          *                * * *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  *");
            Console.WriteLine("          *                  * *");
            Console.WriteLine("          *                 *   *");
            Console.WriteLine("          *                *     *");
            Console.WriteLine("          *               *       *");
            Console.WriteLine("          *              *          *");
            Console.WriteLine("          *");
            Console.WriteLine("          *");
            Console.WriteLine("          *");
            Console.WriteLine("          **********************************");
            Console.WriteLine("          **********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Podaj imię: ");
            Console.WriteLine();
            Console.WriteLine();

            string name = Console.ReadLine();

            Console.WriteLine("Cześć " + name); //wyświetla powitanie gracza
            Console.WriteLine("czy znasz zasady gry? (t/m)"); //weryfikacja znajomości zasad gry
                                                              //string answer = Console.ReadLine(); //odpowiedź udzielona przez gracza

            string decyzja = Console.ReadLine();

            while (decyzja.ToLower() == "t")
            {

                if (decyzja.ToLower() == "t")
                {
                    Console.WriteLine("Zaczynamy grę!");

                    break;
                }
                else if (decyzja.ToLower() == "n")
                {
                    Console.WriteLine("Zapoznaj się z zasadami gry!");
                    Console.WriteLine("zasady");
                    Console.WriteLine("Czy możemy zaczynać? Odp:  (T)ak lub (N)ie");



                }


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


            int wordID = los.Next(words.Length); //losowanie indeksu słowa

            string haslo = words[wordID]; // losowanie słowa
            int ileLiterWslowie = haslo.Length; // zasłonięcie liter
            char[] litery = new char[haslo.Length];

            for (int i = 0; i < ileLiterWslowie; i++)
            {
                litery[i] = '*';
            }

            int mistakes = 0;  // ilość błędnych odpowiedzi

            Console.Write("Twoje słowo to: ");
            Console.Write(litery);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(
                $"-Twoje hasło ma {ileLiterWslowie} liter"); // wylosowane słowo do odgadnięcia. 
            Console.WriteLine();
            Console.Write("     Podpowiedź:     ");
            Console.Write(prompt.GetValue(wordID)); // podpowiedź

            Console.WriteLine();
            //Console.WriteLine("Podaj literę: ");
            string test = Console.ReadLine(); // sprawdzanie litery
            // bool a = haslo.Contains(test);
            int maxMistake = ileLiterWslowie + 3;
            bool start = true;
            int sum = 0;


            while (start && sum < (ileLiterWslowie + 3))
            {



                Console.WriteLine();
                Console.WriteLine(" pozostało Ci  " + (maxMistake -= 1) + " prób");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(litery);
                Console.Write("Podaj literę: ");
                string znak = Console.ReadLine();

                char litera;
                bool trafiony;
                bool caleSlowo;
                caleSlowo = false;


                if (znak.Length > 0)
                {
                    litera = znak.ElementAt(0);
                    sum += 1;
                }
                else
                {
                    continue;
                }

                for (int i = 0; i < ileLiterWslowie; i++)
                {
                    if (litera == haslo.ElementAt(i))
                    {
                        litery[i] = litera;
                        trafiony = true;
                    }
                }
                if (!haslo.Contains(znak))
                {
                    mistakes += 1;
                }
                for (int i = 0; i < ileLiterWslowie; i++)
                {
                    if (litery[i] == '*')
                    {
                        caleSlowo = false;
                        break;
                    }
                    caleSlowo = true;
                }


                if (maxMistake == 0)
                {
                    Console.WriteLine("przegrałeś");
                    break;
                }



                if (mistakes == 1)
                {
                    Console.WriteLine($"Popełniłeś {mistakes} błąd");

                }

                else if (mistakes > 1)
                {
                    Console.WriteLine($"Popełniłeś {mistakes} błędy");

                }

                if (caleSlowo)
                {
                    Console.WriteLine("\nZgadłeś słowo");
                    Console.ReadLine();
                    start = false;
                }

            }




            /*
            if (haslo.Contains(test))
            {
                Console.WriteLine(test + " -zgadłeś");
                Console.WriteLine("otrzymujesz 1pkt!");
                mistakes++;
                Console.WriteLine("Twoje punty: " + mistakes);
            }
            else
            {
                Console.WriteLine("zadane słowo nie zawiera tej litery - brak punktów");
            }
            // Console.WriteLine(a);           
            var replacement = haslo.Replace(haslo, "*");
            Console.WriteLine(replacement);
            Console.ReadLine();
            Console.ReadKey();
            */
        }
    }


}
