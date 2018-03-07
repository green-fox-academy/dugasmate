using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings = 4, string name = "Violin") : base(numberOfStrings, name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("screeches");
        }
    }
}
