using System;
using System.Collections.Generic;
using System.Text;

namespace SharpiiSet
{
    public class SharpieSet
    {
        public static List<Sharpie> Sharpies = new List<Sharpie>();
        public static List<Sharpie> SharpiesUsable = new List<Sharpie>();
        public static void AddSharpieToList(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }

        public static int CountUsable()
        {
            int count = 0;
            foreach (var sharpie in Sharpies)
            {
                if (sharpie.inkAmount > 0)
                {
                    count++;
                }
                
            }
            return count;
        }
        public static void RemoveTrash()
        {
            

            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].inkAmount > 0)
                {
                    SharpiesUsable.Add(Sharpies[i]);
                }
            }
        }
    }

}
