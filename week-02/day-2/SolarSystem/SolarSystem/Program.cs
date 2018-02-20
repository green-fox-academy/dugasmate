using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {

            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };



            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list.

            Console.WriteLine(PutSaturn(planetList));
            Console.ReadLine();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }
        static string PutSaturn(List<string> planetList)
        {
       
            planetList.Add("Saturn");
            string output = "";
            foreach (var planets in planetList)
            {
                output += ("\"" + planets + "\" ");
                
            }
            return output;
        }
    }
}