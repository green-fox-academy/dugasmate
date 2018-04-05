using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet.Models
{
    public class Greeter : IGreetable
    {
        public string koszones;
        public Greeter (string koszones = " ")
        {
            this.koszones = koszones;
        }
        public string Greet(string name)
        {
            return koszones = "Szevasz " + name + "!!!!!!!!";
        }
    }
}
