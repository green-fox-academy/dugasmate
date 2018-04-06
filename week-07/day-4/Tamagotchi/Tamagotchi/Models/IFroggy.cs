using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi.Models
{
    public interface IFroggy
    {
        void SetName(string name);
        void DoTrick(int i);
        void AddFood(int i);
        void AddDrink(int i);
        void AddTrick(int i);
    }
}
