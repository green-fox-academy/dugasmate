﻿using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[] nimals = { "kuty", "macsk", "cic" };
            foreach (var animals in nimals)
            {
                Console.WriteLine(animals + "a");
            }

            Console.ReadLine();
        }
    }
}