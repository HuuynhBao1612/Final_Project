using Final_Project_2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_2024.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}
