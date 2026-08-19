using Microsoft.EntityFrameworkCore;
namespace Backend.Data;

public class AppDbContext :  DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Exposure> Exposures { get; set; }

    public DbSet<MaxExposure> MaxExposures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MaxExposure>()
            .HasIndex(x => new { x.SkinType, x.UvIndex })
            .IsUnique();
    }
}