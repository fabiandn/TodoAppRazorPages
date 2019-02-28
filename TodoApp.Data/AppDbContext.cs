using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

namespace TodoApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}