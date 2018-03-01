using System;

namespace CounterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter(50);
            count.Add(123);
            count.Add(555);
            Console.WriteLine(count.Get());
            count.Reset();
            Console.WriteLine(count.Get());
            count.Add();
            Console.WriteLine(count.Get());
            Console.ReadLine();
        }
    }
}
