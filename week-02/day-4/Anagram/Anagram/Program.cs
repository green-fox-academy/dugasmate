using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram());
            Console.ReadLine();

        }
        static bool IsAnagram()
        {
            bool output = true;
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
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
