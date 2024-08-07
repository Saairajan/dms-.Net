using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.UserService.Models;

namespace WebApplication1.dbConfig;

public class AppDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Order> Orders { get; set; }

    
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
}