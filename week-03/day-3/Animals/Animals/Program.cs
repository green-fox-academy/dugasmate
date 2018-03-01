using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pig = new Animal();
            Animal cat = new Animal();
            Animal hippo = new Animal();

            Console.WriteLine("Pig\nHunger: {0}\nThirst: {1}", pig.hunger, pig.thirst);
            pig.Eat();
            pig.Drink();
            pig.Play();
            pig.Play();
            Console.WriteLine("Pig\nHunger: {0}\nThirst: {1}", pig.hunger, pig.thirst);
            Console.ReadLine();
        }

    }
}
