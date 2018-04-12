using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public interface IRepo
    {
        void Create(TodoC todo);
        void Update(int id, string updated);
        List<TodoC> Read();
        void Delete(int id);
        void MakeTrue(int id);
        List<TodoC> Search(string title);
    }
}
