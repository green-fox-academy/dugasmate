using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class Counterke : ICountable
    {
        public int number { get; set; }
        public Counterke (int number = 0)
        {
            this.number = number;
        }
        public void Count()
        {
            number++;
        }
    }
}
