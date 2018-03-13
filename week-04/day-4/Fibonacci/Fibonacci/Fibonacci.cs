using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        

        public int Fibonaccer(int p)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < p; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
