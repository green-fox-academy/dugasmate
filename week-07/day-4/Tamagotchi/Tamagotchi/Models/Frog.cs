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
        public List<Trick> tricks = new List<Trick>
        {
            new Trick ("http://rs279.pbsrc.com/albums/kk138/Shidou_Master/tumblr_inline_mnjz5hev0l1qz4rgp.gif~c200" , "Hula dance!" ),
            new Trick ("http://rs4.pbsrc.com/albums/y108/kazaf_10/Keroro%20Emoticons/8fd8dd.gif~c200" , "Do something weird!" ),
            new Trick ("https://thumbs.gfycat.com/IncompatibleConstantIndianrhinoceros-max-1mb.gif" , "Pump it!" )
        };
        public List<Trick> unlearnedTricks = new List<Trick>
        {
            new Trick ("https://vignette.wikia.nocookie.net/keroro/images/6/67/Tumblr_m4lru46JUU1qmmau8o1_400.gif/revision/latest?cb=20121021024950" , "Jump around!" ),
            new Trick ("http://rs4.pbsrc.com/albums/y108/kazaf_10/Keroro%20Emoticons/8dd8d88.gif~c200" , "Shake your booty!" ),
            new Trick ("http://rs4.pbsrc.com/albums/y108/kazaf_10/Keroro%20Emoticons/8dO88.gif~c200" , "Mental breakdown!" ),
            new Trick ("http://rs4.pbsrc.com/albums/y108/kazaf_10/Keroro%20Emoticons/88d8P8dd.gif~c200" , "Clean!" )
        };
        public List<string> foodList = new List<string>
        {
            "flies", "spaghetti", "cabbage", "potato", "beetroot", "onion", "radish"
        };
        public List<string> drinkList = new List<string>
        {
            "water", "beer", "coke", "orange juice", "vodka", "milk", "coffee"
        };
        public Frog(string name = "", string food = "flies", string drink = "water (I guess...)", string image = "https://thumbs.gfycat.com/IncompatibleConstantIndianrhinoceros-max-1mb.gif")
        {
            this.name = name;
            this.food = food;
            this.drink = drink;
            this.image = image;
        }

        public void AddDrink(int i)
        {
            drink = drinkList[i];
        }

        public void AddFood(int i)
        {
            food = foodList[i];
        }

        public void AddTrick(int i)
        {
            tricks.Add(unlearnedTricks[i]);
            unlearnedTricks.RemoveAt(i);
        }

        public void DoTrick(int i)
        {
            image = tricks[i].image;
        }

        public void SetName(string givenName)
        {
            name = givenName;
        }
    }
}
