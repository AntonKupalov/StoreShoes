using AddDataBaseForProject.DbStuff.Models;
using Microsoft.EntityFrameworkCore;

namespace AddDataBaseForProject.DbStuff;

public class StoreDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public StoreDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("Store"));
    } 
    
    public DbSet<User> Users { get; set; } 
}