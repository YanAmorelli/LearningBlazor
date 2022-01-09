using Microsoft.EntityFrameworkCore;

namespace LearningBlazor.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}