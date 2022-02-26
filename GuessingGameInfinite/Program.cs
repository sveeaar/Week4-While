using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri vahemikus 1-10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitja;
            //katsete arv on piiramatu;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;


            while (i == 0)
            {
                Console.WriteLine($"Teie valitud number vahemikust 1-10 on:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne, arvasite õige numbri ära!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti!");
                }

            }
            Console.WriteLine("Kena päeva!");
            
        }
    }
}
