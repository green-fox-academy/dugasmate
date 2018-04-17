using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class LogContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {

        }
    }
}
