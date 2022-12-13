using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {
            // hp atack moc coin 
            int[] character = CharacterClass.characterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMoc = character[2];

            while (CharacterClass.isAlive(character))
            {
                // opcje co gracz moze zrobic
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "w":
                        Console.WriteLine("---------------");
                        Monsters.faight(character);
                        break;
                    case "z":
                        Console.WriteLine("---------------");
                        Spels.SpelsBook(character, maxHp, maxMoc);
                        break;
                    case "s":
                        Shop.shop(character, maxHp, maxMoc);
                        Console.WriteLine("---------------");
                        break;
                    case "m":
                        mistrz.mistrzu(character);
                        Console.WriteLine("---------------");
                        break;
                    case "k":
                        rzemioslo.kowal(character);
                        Console.WriteLine("---------------");
                        break;
                    case "b":
                        karczma.baaar(character, maxHp);
                        Console.WriteLine("---------------");
                        break;
                    default:
                        Console.WriteLine("Nie ma tak");
                        break;
                }
                round += 1;
            }



            Console.WriteLine("Dziekuje za grę");
            Console.ReadKey();
        }
    }
}

