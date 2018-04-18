using Microsoft.EntityFrameworkCore;
using RedditBackEndApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackEndApp.Entities
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }
    }

}
