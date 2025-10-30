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
}