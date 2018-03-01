using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        public List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

    }
}