using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class OneToDo
    {
        public int id;
        public bool isDone;
        public string description;
        private static int m_Counter = 0;
        public OneToDo(string description, bool isDone = false)
        {
            id = System.Threading.Interlocked.Increment(ref m_Counter);
            this.isDone = isDone;
            this.description = description;
        }
    }
}
