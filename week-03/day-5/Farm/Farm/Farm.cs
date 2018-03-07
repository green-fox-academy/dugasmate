using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Farm
    {
        public static List<Animal> Animals = new List<Animal>();
        public static List<Animal> LivingAnimals = new List<Animal>();
        public static void Breed(Animal animal)
        {

            if (Animals.Count > 4)
            {
                Console.WriteLine("No More Space");
            }
            else
            {
                Animals.Add(animal);
            }

        }
       public static void Slaughter()
        {
            int hungerValue = Animals[0].hunger;
            int index = 0;

            for (int i = 0; i < Animals.Count; i++)
            {
                
                if (hungerValue > Animals[i].hunger)
                {
                    hungerValue = Animals[i].hunger;
                    index = i;
                }
               
            }
            Animals.Remove(Animals[index]);


        } 
    }
}
