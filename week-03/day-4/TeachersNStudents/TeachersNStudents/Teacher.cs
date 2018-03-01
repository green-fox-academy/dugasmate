using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersNStudents
{
    public class Teacher
    {
        public string Answer()
        {
            return  "Answer";
        }
        public string Teach(Student student)
        {
            return student.Learn();
        }
    }
}
