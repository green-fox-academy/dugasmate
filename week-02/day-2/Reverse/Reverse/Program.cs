using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            
            Console.WriteLine(Reversal(reversed));
            Console.ReadLine();
        }
        static string Reversal(string reversed)
        {
        
            string output = "";
            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                output += reversed[i];
                
             
            }
            return output;
        }
    }
}