using System;
using System.Collections.Generic;
using System.Text;

namespace ZooZoo
{
    abstract class Animal
    {
        public string name, color, gender;
        public int age, numberOfLegs;

        public Animal(string name)
        {
            this.name = name;

        }
        public abstract string Greet();
        public abstract string WantChild();
    }
}
