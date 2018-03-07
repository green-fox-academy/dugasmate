using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings = 6, string name = "Electric guitar") : base(numberOfStrings, name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("twangs");
        }
    }
}
