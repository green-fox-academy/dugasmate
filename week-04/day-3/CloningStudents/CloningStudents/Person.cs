using System;
using System.Collections.Generic;
using System.Text;

namespace CloningStudents
{
    public class Person
    {
        public string name, gender;
        public int age;
        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + ".");
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
