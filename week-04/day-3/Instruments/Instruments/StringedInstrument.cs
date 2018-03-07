using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        int numberOfStrings;
        public StringedInstrument(int numberOfStrings, string name) : base(name)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public override void Play()
        {
            Console.Write(name + ", is a " + numberOfStrings + " stringed instrument that ");
            Sound();
        }
        public abstract void Sound();
    }
}
