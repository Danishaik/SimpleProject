using Microsoft.EntityFrameworkCore;
using SimpleProject.Models;

namespace SimpleProject.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
