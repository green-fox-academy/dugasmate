using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class OneToDo
    {
        public bool isDone;
        public string description;
        public OneToDo(string description, bool isDone = false)
        {
            this.isDone = isDone;
            this.description = description;
        }
    }
}
