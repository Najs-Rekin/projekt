using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class mistrz
    {

        public static int[] mistrzu(int[] character)
        {
            Console.WriteLine("Witaj w pieciarze pradawnego mistrza, wybierz szkolenie !");
            Console.WriteLine("Lecz pamiętaj, aby zapłacić (starcy nie pracują za darmo)!");
            Console.WriteLine("1 - trening wytrzymałościowy 20 coin \t 2 - trening podstawowy 15 coin  \t 3 - trening mistrzowski 100 coin \t ");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return wytrz(character);
                case 2:
                    return podst(character);
                case 3:
                    return mis(character);



            }
            Console.WriteLine("Opuszczasz pieczare pradawnego mistrza, lecz znajdziesz ją za każdym razem, gdy udasz się w podróż");
            return character;
        }

        public static int[] wytrz(int[] character)
        {
            if (character[3] >= 20)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz + 60 mocy, wydajesz 20 coinów");
                character[3] -= 20;
                character[2] += 60;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }

        public static int[] podst(int[] character)
        {
            if (character[3] >= 15)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz + 40 mocy, wydajesz 15 coinów");
                character[3] -= 15;
                character[2] += 40;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }

        public static int[] mis(int[] character)
        {
            if (character[3] >= 100)
            {
                Console.WriteLine("Twój trening się zakończył, zyskujesz + 140 mocy, wydajesz 100 coinów");
                character[3] -= 100;
                character[2] += 140;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }






    }
}
