using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoC> Todos { get; set; }
        public TodoContext(DbContextOptions <TodoContext> options) : base(options)
        {
            
        }
        
    }
}
