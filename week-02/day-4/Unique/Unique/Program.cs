using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            int[] numbersList = new int[] { 1, 11, 34, 11, 52, 61, 1, 34 };
            UniqueFunction(numbersList);
            Console.ReadLine();
            //  should print: `[1, 11, 34, 52, 61]`
            //MUKODIK DE NEM IGY KENE MEGCSINALNI
        }
        static void UniqueFunction(int[]numbersList)
        { 
            Array.Sort(numbersList);
            
            foreach (var item in numbersList.Distinct())
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
