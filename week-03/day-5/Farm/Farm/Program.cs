
using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
           Farm.Breed(new Animal("Pig"));
           Farm.Breed(new Animal("Cat"));
           Farm.Breed(new Animal("Dog"));
           Farm.Breed(new Animal("Panda"));
            for (int i = 0; i < Farm.Animals.Count; i++)
            {
                Console.WriteLine(Farm.Animals[i].name);
            }

            Console.WriteLine("{0}\nHunger: {1}\nThirst: {2}", Farm.Animals[0].name, Farm.Animals[0].hunger, Farm.Animals[0].thirst);
            Farm.Animals[1].Eat();
            Console.WriteLine("{0}\nHunger: {1}\nThirst: {2}", Farm.Animals[1].name, Farm.Animals[1].hunger, Farm.Animals[1].thirst);
            Farm.Slaughter();
            for (int i = 0; i < Farm.Animals.Count; i++)
            {
                Console.WriteLine(Farm.Animals[i].name);
            }



            Console.ReadLine();

        }
    }
}
