using Formtask.Model;
using Microsoft.EntityFrameworkCore;

namespace Formtask.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        { }
        public DbSet<Student> Student { get; set; }
    }
}