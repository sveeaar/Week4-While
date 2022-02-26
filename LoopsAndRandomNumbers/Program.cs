using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma PIN-kood;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN, proovi uuesti!";
            //kasutajal on kolm katset, i < 3;

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1;
                    i++;
                    Console.WriteLine($"Vale PIN, {3 -i} katset jäänud.");
                }

                
            }

           Console.WriteLine("Kena päeva!");

        }
    }
}
