using System.Net.Mime;
using BTH2003.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
        public DbSet<Employee> Employee {get; set; }

    }
}