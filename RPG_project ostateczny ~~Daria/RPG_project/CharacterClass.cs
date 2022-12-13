using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class CharacterClass
    {

        public static int[] characterClassSelection()
        {
            // hp atack moc gold wendka
            while (true)
            {
                
                Console.WriteLine($"Jesteś postacią w bardzo dziwnym świecie. Zarabiasz pieniądze chodząc do lasu, aby zabić biesy.Twoja postać posiada moc, którą może zużyć na zaklęcia, aby sobie pomóc .");
                Console.WriteLine($"wybierz klasę postaci!");
                Console.WriteLine("1 - czarodziejopodobny \t 2 - Wiedźmin \t 3 - Assassin");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    int[] m = { 200, 10, 300, 30, 0 };
                    return m;
                }
                else if (inp == "2")
                {
                    int[] w = { 500, 30, 0, 30, 0 };
                    return w;
                }
                else if (inp == "3")
                {
                    int[] w = { 350, 15, 150, 30, 0 };
                    return w;
                }
                else
                {
                    Console.WriteLine("nie ma takiej postaci");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
