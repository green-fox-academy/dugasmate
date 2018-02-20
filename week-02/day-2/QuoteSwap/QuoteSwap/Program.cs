using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var listed = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwapper(listed));
            // Expected output: "What I cannot create I do not understand." 
            Console.ReadLine();
        }
        static string QuoteSwapper(List<string> listed)
        {
            listed[2] = "cannot";
            listed[5] = "do";
            string output = "";
            foreach (var word in listed)
            {
                output += word + " ";
            }

        return output;
        }
        

    }
}