using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersNStudents
{
    public class Student
    {
        public string Question(Teacher teacher)
        {
            return teacher.Answer();
        }
        public string Learn()
        {
            return "Learn";
        }

    }
}
