using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            Thing first = new Thing ("1. [ ] Get milk");
            Thing second = new Thing("2. [ ] Remove the obstacles");
            Thing third = new Thing("3. [x] Stand up");
            Thing fourth = new Thing("4. [x] Eat lunch");
            fleet.Add(first);
            fleet.Add(second);
            fleet.Add(third);
            fleet.Add(fourth);
            Console.ReadLine();

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
        }

    }
}