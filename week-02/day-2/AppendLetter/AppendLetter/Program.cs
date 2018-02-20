using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine();
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }
        static string AppendA(List<string> far)
        {
            string output = "";
            foreach (var farA in far)
            {
                output += ("\"" + farA + "a\" ");
            }
            return output;
        }
    }
}
