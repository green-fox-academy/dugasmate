using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            //  Example:
            bool sortSwitch = false;
            int[] list = new int[] { 34, 12, 24, 9, 5 };
            Bubble(list, sortSwitch);
            sortSwitch = true;
            Bubble(list, sortSwitch);


            Console.ReadLine();
            //  should print [5, 9, 12, 24, 34]
            //  should print [34, 24, 12, 9, 5]
        }
        static void Bubble(int[] list, bool sortSwitch)
        {
            Array.Sort(list);
            if (sortSwitch == true)
            {
                Array.Reverse(list);
                foreach (int sortedNumber in list)
                {
                    Console.Write(sortedNumber + " ");
                }
            }
            else
            {
                foreach (int sortedNumber in list)
                {
                    Console.Write(sortedNumber + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
