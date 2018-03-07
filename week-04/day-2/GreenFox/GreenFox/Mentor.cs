using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Mentor : Person
    {
        string level;
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }
        public Mentor(string level = "intermediate")
        {
            this.level = level;
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " " + level +  " mentor.");
        }
    }
}
