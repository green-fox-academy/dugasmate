using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet.Models
{
    public interface IGreetable
    {
        string Greet(string name);
    }
}
