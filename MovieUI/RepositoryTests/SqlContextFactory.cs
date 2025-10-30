using Microsoft.EntityFrameworkCore;
using Repository;

namespace RepositoryTests;

public static class SqlContextFactory
{
    public static SqlContext Create()
    {
        var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
        optionsBuilder.UseInMemoryDatabase("MovieDB");
        return new SqlContext(optionsBuilder.Options);
    }
}