using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new[] { 'N', 'a', 'm', 'i' };
            string joined = String.Join("", charArray);
            Console.WriteLine(joined);
            Console.ReadLine();
        }
    }
}
