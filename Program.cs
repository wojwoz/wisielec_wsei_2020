using System;

namespace wisielec_wsei_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w grze wisielec");
            Console.WriteLine("Podaj imię: ");

            string name = Console.ReadLine();
          
            Console.WriteLine("Cześć " + name);
            Console.WriteLine("czy znasz zasady gry?");
            Console.WriteLine("Wybierz  (T)tak lub (N)nie.");


            Console.ReadKey();
        }
    }


}
