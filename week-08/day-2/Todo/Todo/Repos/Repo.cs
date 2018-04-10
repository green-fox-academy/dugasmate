using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Repo : IRepo
    {
        private TodoContext context;

        public Repo(TodoContext context)
        {
            this.context = context;
        }


        public void Create(TodoC todo)
        {
            context.Add(todo);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.RemoveAt(id) ;
        }

        public List<TodoC> Read()
        {
            return context.Todos.ToList();
        }

        public void Update()
        {
            
        }

    }
}
