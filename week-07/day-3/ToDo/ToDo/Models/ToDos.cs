using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ToDos : IToDoable
    {
        public List<OneToDo> toDoList = new List<OneToDo>
        {
            new OneToDo("Enni kaját"),
            new OneToDo("Lopni pénzt", true),
            new OneToDo("Költeni a pénzt")
        };
        public void Add(string task)
        {
            toDoList.Add(new OneToDo(task));
        }

        public void Remove(int index)
        {
            toDoList.RemoveAt(index);
        }

        public void Check(int index)
        {
            toDoList[index].isDone = true;

        }
    }
}
