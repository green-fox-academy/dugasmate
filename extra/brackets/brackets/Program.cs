using System;
using System.Collections.Generic;
using System.Linq;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Number of players?");
            var players = new List<string>();
            string numberOfPlayers = Console.ReadLine();
            int playerNum = Int32.Parse(numberOfPlayers);
            Console.WriteLine(numberOfPlayers + " players! Nice!\nWho's playing?");
            for (int i = 0; i < playerNum; i++)
            {
                string name = Console.ReadLine();
                players.Add(name);
            }
            var randomPlayers = players.OrderBy(x => rnd.Next());
            int index = 0;
            foreach (var player in randomPlayers)
            {
                if (index == players.Count - 1)
                {
                    Console.Write(player);
                }
                else if (index % 2 == 0)
                {
                    Console.Write(player + "-----");
                }
                else if (index % 2 != 0)
                {
                    Console.Write(player + "     ");
                }
                index++;
            }
            

            
            Console.ReadLine();
        }
    }
}
