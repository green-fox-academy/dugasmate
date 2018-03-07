using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Animal
    {
        public int hunger, thirst;
        public string name;
        public Animal(string name, int hunger = 50, int thirst = 50)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;

        }
        public int Eat()
        {
            return hunger--;
        }
        public int Drink()
        {
            return thirst--;
        }
        public int Play()
        {
            thirst++;
            hunger++;
            return thirst;

        }
    }
}
