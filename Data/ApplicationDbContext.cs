using Microsoft.EntityFrameworkCore;
using SofumerMarble.Models;

namespace SofumerMarble.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
           : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
