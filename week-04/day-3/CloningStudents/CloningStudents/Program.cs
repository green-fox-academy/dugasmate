using System;
using System.Collections.Generic;

namespace CloningStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Student("John", 20, "male", "BME");
            Console.WriteLine(john.name);
            Student cloned = john.Clone() as Student;
            Console.WriteLine(cloned.name);
            Console.ReadLine();

        }
    }
}
