using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;
        public Student(string name , int age, string gender, string previousOrganization) : base(name, age, gender)
        {

            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }
        public Student(string previousOrganization = "The School of Life")
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course.");
        }
        public void SkipDays(int numberAdded)
        {
         skippedDays = skippedDays + numberAdded;
        }
    }
}

