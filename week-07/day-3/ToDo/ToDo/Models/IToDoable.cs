using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public interface IToDoable
    {
        void Add(string task);
        void Remove(int index);
        void Check(int index);
    }
}
