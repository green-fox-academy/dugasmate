using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elso.Models
{
    public class Greeting
    {
        public long id { get; set; }
        public string content { get; set; }
        public static long counter = 0;

        public Greeting(string content)
        {
            this.id = counter++;
            this.content = content;
        }

    }
}
