using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = { 3, 4, 5, 6, 7};
            int aiSum = 0;
            for (int i = 0; i < ai.Length; i++)
            {
                aiSum += ai[i];
            }
            Console.WriteLine(aiSum);
            Console.ReadLine();
        }
    }
}