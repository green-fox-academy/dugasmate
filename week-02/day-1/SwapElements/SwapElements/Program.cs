using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = { "first", "second", "third" };
            abc[0] = "third";
            abc[2] = "first";
            foreach (var abcPrint in abc)
            {
                Console.WriteLine(abcPrint);
            }
            Console.ReadLine();
        }
    }
}