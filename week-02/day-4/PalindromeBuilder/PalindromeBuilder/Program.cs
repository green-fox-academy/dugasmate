using System;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Reverse(input);
            Console.ReadLine();
        }
        static void Reverse(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }

        }
    }
}
