using FinalExams.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace FinalExams.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CustomServices> CustomServices { get; set; }
       
    }
}
