﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Monsters
    {

        public static int[] genrateMonster()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(25, 40);
            }
            return monsterStatystic;
        }

        // hp atack moc gold 

        public static int[] faight(int[] player)
        {
            Console.WriteLine("Spotykasz biesa");
            int[] monster = genrateMonster();
            while (monster[0] > 0)
            {
                player[0] -= monster[1];
                monster[0] -= player[1];
                if (player[0] <= 0)
                {
                    Console.WriteLine("Umierasz!!!");
                    break;

                }
                Thread.Sleep(900);
                Console.WriteLine($"Walka playerHp {player[0]} dostjesz {monster[1]} obr = monster {monster[0]} zadajesz {player[1]}");
            }
            player[3] += monster[3];
            return player;
        }



    }
}

