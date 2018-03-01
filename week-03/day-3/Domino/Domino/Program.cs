using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            for (int i = 0; i < dominoes.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j % 2 == 0 )
                    {
                        Console.Write("[" + dominoes[i].GetValues()[j] + " + ");
                        
                    }
                    if (j % 2 != 0)
                    {
                        Console.Write(dominoes[i].GetValues()[j] + "] ");
                    }
                }   


            }





            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            Console.ReadLine();

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}
