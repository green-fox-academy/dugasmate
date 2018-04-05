using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Models
{
    public interface IAnagrammable
    {
        bool IsAnagramm(string firstWord, string secondWord);
    }
}
