using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi.Models 
{
    public class Frog : IFroggy
    {
        public string name;
        public string food;
        public string drink;
        public string image;
        public List<string> tricks = new List<string>
        {
            "Do something weird",
            "Dance"
        };
        public Frog(string name = "", string food = "flies", string drink = "water (I guess...)", string image = "https://thumbs.gfycat.com/IncompatibleConstantIndianrhinoceros-max-1mb.gif")
        {
            this.name = name;
            this.food = food;
            this.drink = drink;
            this.image = image;
        }

        public void DoTrick()
        {
            image = "http://rs279.pbsrc.com/albums/kk138/Shidou_Master/tumblr_inline_mnjz5hev0l1qz4rgp.gif~c200";
        }

        public void SetName(string givenName)
        {
            name = givenName;
        }
    }
}
