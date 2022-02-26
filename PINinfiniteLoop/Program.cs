using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma PIN-kood;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!";
            //katsete arv in piiramatu;

            bool loopActive = true;
            int i = 0;
            
            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;

                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN, proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud!");

                }


            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
