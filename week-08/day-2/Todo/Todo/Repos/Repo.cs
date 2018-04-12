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
            TodoC todo = context.Todos.FirstOrDefault(x => x.Id == id);
            context.Remove(todo);
            context.SaveChanges();
        }

        public void MakeTrue(int id)
        {
            TodoC todo = context.Todos.FirstOrDefault(x => x.Id == id);
            todo.IsDone = true;
            context.SaveChanges();
        }

        public List<TodoC> Read()
        {
            return context.Todos.ToList();
        }

        public List<TodoC> Search(string title)
        {
            List<TodoC> searchResult = context.Todos.Where(x => x.Title.Contains(title)).ToList();
            context.SaveChanges();
            return searchResult;

        }

        public void Update(int id, string description)
        {
            TodoC todo = context.Todos.FirstOrDefault(x => x.Id == id);
            if (description != null)
            {
                todo.Title = description;
            }

            context.SaveChanges();
        }
    }
}
