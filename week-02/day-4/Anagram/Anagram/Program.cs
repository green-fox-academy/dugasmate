﻿using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "szotyi";
            string secondWord = "szotyi";
            Console.WriteLine(IsAnagram(firstWord, secondWord));
            Console.ReadLine();


        }
        static bool IsAnagram(string firstWord, string secondWord)
        {
            bool output = true;

            char[] arrFirstWord = firstWord.ToCharArray();
            char[] arrSecondWord = secondWord.ToCharArray();
            Array.Sort(arrFirstWord);
            Array.Sort(arrSecondWord);
            for (int i = 0; i < arrFirstWord.Length; i++)
            {
                if (arrFirstWord[i] == arrSecondWord[i])
                {
                    output = true;
                }
                else
                {
                    output = false;
                    break;
                }
            }
            return output;
        }
    }
}
