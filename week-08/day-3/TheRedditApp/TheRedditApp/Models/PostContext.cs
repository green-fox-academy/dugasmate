using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditApp.Models
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }
    }
}
