using Formtask.Model;
using Microsoft.EntityFrameworkCore;

namespace Formtask.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Mark> Mark { get; set; }

    }
}