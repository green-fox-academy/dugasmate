using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            float dailyHours = 6;
            float workDays = 5;
            float semester = 17;
            float workHoursInAWeek = 52;

            Console.WriteLine("Hours spent with coding in a semester: " + workDays * semester * dailyHours);
            Console.WriteLine("Percentage of coding hours in the semester: " + dailyHours * workDays / workHoursInAWeek * 100 + "%");

            Console.ReadLine();
        }
    }
}