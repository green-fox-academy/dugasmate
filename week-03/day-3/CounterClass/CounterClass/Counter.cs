using System;
using System.Collections.Generic;
using System.Text;

namespace CounterClass
{
    public class Counter
    {
        public int value;
        public int number;
        public int kezd;
        public Counter(int value = 0)
        {
            this.value = value;
            kezd = value;
        }
        public int Add(int number = 1)
        {
            return value = value + number;
        }
        public string Get()
        {
            return value.ToString();
        }
        public int Reset()
        {
            value = kezd;
            return value;
        }
    }
}
