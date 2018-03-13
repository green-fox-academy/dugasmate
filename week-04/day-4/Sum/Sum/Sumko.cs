using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class Sumko
    {
        public int Summer(List<int> numbers)
        {
            int output = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                output += numbers[i];
            }
            return output;

        }

    }
}
