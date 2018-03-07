using System;

namespace ZooZoo
{
    class Program
    {
        static void Main(string[] args)
        {


                var reptile = new Reptile("Frog");
                var mammal = new Mammal("Koala");
                var bird = new Bird("Parrot");

                Console.WriteLine("Who wants a baby?");
                Console.WriteLine(reptile.Greet() + ", " + reptile.WantChild());
                Console.WriteLine(mammal.Greet() + ", " + mammal.WantChild());
                Console.WriteLine(bird.Greet() + ", " + bird.WantChild());


            Console.ReadLine();
        }
    }
}
