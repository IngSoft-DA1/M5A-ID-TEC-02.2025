using System.Data.Common;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class SqlContext : DbContext
{
    public DbSet<Movie> Movie { get; set; }
    
    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    {
       if(!Database.IsInMemory()) Database.Migrate();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Movie>().HasMany(m => m.Actors).WithOne(a => a.Movie).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Movie>().HasOne(m => m.LeadActor).WithMany();   
    }
}
