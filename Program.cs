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
            while(true)
            {
                string decyzja = Console.ReadLine();



                while (decyzja.ToLower() == "t")
                {

                    if (decyzja.ToLower() == "t")
                    {
                        Console.WriteLine("Zaczynamy grę!");
                        bool start = true;
                        while (start)
                        {
                            Console.WriteLine("Losuj słowo - naciśnij dowolny klawisz");
                            Console.ReadKey();
                            Console.Clear();
                            Random los = new Random();


                            string[] words = {
                "alaska",
                "altana",
                "arbuz",
                "arystokracja",
                "ameba",
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
                "etiopia",
                "egipt",
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

                            var test = Console.ReadLine(); // sprawdzanie litery
                            ;
                            int maxMistake = ileLiterWslowie + 3;

                            int sum = 0;

                            bool start2 = true;
                            while (start2 == true)
                            {



                                Console.WriteLine();
                                Console.WriteLine(" pozostało Ci  " + (maxMistake -= 1) + " prób");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine(litery);
                                Console.Write("Podaj literę: ");
                                string znak = Console.ReadLine();

                                char litera;

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
                                Console.Clear();


                                if (mistakes == 1)
                                {
                                    Console.WriteLine($"Popełniłeś {mistakes} błąd");

                                }

                                else if (mistakes > 1)
                                {
                                    Console.WriteLine($"Popełniłeś {mistakes} błędy");

                                }


                                if (maxMistake == 0)
                                {
                                    Console.WriteLine("przegrałeś");
                                    Console.WriteLine();
                                    start2 = false;


                                }
                                if (caleSlowo)
                                {
                                    Console.WriteLine("\nZgadłeś słowo");
                                    Console.WriteLine();
                                    Console.WriteLine("Twoje słowo to : " + haslo + "!!!");
                                    start2 = false;
                                }

                                if (start2 == false)
                                {
                                    start = false;
                                    break;
                                }
                            }

                        }

                    }
                    break;
                }
                Console.WriteLine(name); //wyświetla powitanie gracza
                Console.WriteLine("czy cgcesz zagrać jeszcze raz? (t/m)"); //weryfikacja znajomości zasad gry
                                                                           //string answer = Console.ReadLine(); //odpowiedź udzielona przez gracza
                if (decyzja.ToLower() == "n")
                {
                    Console.WriteLine("koniec gry !!!");
                    break;

                }
            }









        }
    }


}
