using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Anagramm.Models
{
    public class Anagramma : IAnagrammable
    {
        public bool IsAnagramm(string firstWord, string secondWord)
        {
            firstWord = firstWord.ToUpper();
            secondWord = secondWord.ToUpper();
            char[] arrFirstWord = firstWord.ToCharArray();
            char[] arrSecondWord = secondWord.ToCharArray();
            Array.Sort(arrFirstWord);
            Array.Sort(arrSecondWord);
            for (int i = 0; i < arrFirstWord.Length; i++)
            {
                if (arrFirstWord[i] != arrSecondWord[i])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
