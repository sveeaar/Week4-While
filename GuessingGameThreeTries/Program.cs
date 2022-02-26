using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri vahemikus 1-10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitja;
            //katseta arv on 3, kui kasutaja ei suuda kolme katsega numbrit ära arvata;
            //on arvuti mängu võitja;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Teie valitud number vahemikust 1-10 on:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(cpuNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne, arvasite õige numbri ära!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number, teil on {3 - i} katset jäänud.");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
