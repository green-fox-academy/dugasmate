using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            Console.WriteLine("What's your name?");
            string al = Console.ReadLine();
            Greet(al);
            Console.ReadLine();

        }
        static void Greet(string al)
        {
            Console.WriteLine("Greetings dear, " + al);
        }

    }
}