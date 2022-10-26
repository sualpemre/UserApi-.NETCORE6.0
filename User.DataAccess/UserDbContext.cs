using Microsoft.EntityFrameworkCore;

namespace User.DataAccess;

public class UserDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=Esualp98.;Database=Users");
    }

    public DbSet<Entities.User> Users { get; set; }
}