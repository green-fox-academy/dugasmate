using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            fleet.Add(new Thing("1. [ ] Get milk"));
            fleet.Add(new Thing("2. [ ] Remove the obstacles"));
            fleet.Add(new Thing("3. [x] Stand up"));
            fleet.Add(new Thing("4. [x] Eat lunch"));
            for (int i = 0; i < Fleet.Things.Count; i++)
            {
                Console.WriteLine(Fleet.Things[i]);
            }
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