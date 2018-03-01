using System;

namespace TeachersNStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Console.WriteLine(student.Question(teacher));
            Console.WriteLine(teacher.Teach(student));
            Console.ReadLine();
        }
    }
}
