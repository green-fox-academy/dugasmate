using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public interface IRepo
    {
        void Create(TodoC todo);
        void Update();
        List<TodoC> Read();
        void Delete(int id);
    }
}
