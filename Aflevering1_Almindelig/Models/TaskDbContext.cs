using Microsoft.EntityFrameworkCore;

namespace Aflevering1_Almindelig.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options) { }
        public DbSet<Task> Tasks { get; set; }
    }
}
