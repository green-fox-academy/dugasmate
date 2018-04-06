using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi.Models
{
    public class Trick
    {
        public string image;
        public string description;

        public Trick (string image, string description)
        {
            this.image = image;
            this.description = description;
        }
    }
}
