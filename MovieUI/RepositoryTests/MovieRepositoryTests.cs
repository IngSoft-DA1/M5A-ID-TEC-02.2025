using Domain;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace RepositoryTests;

[TestClass]
public class MovieRepositoryTests
{
    private SqlContext context = SqlContextFactory.Create();
    private MovieRepository repository;

    [TestInitialize]
    public void SetUp()
    {
        repository = new MovieRepository(context);
    }
    
    [TestMethod]
    public void AddMovie_WhenValidParameters_ShouldAddMovie()
    {
        var movie = new Movie("Oppenheimer", "Nolan", DateTime.Now);
        repository.AddMovie(movie);
        Assert.AreEqual(1, context.Movie.ToList().Count);
    }
}