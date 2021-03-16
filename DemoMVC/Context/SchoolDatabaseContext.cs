using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Context
{
    public class SchoolDatabaseContext : DbContext
    {
        public SchoolDatabaseContext(DbContextOptions<SchoolDatabaseContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students{ get; set; }
    }
}