using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;
        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            hiredStudents = 0;
        }
        public Sponsor(string company = "Google")
        {
            this.company = company;
            hiredStudents = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " who represents " + company + " and hired " + hiredStudents + " students so far." );
        }
        public void Hire()
        {
            hiredStudents++;
        }
    }
}
