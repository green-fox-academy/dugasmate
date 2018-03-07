using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings = 4, string name = "Bass guitar") : base(numberOfStrings, name)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duums");
        }
    }
}
