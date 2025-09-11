using Domain;
using Repository;

namespace Services;

public class MovieService
{
    private readonly InMemoryDatabase _inMemoryDatabase;

    public MovieService(InMemoryDatabase inMemoryDatabase)
    {
        _inMemoryDatabase = inMemoryDatabase;
    }

    public void AddMovie(Movie movie)
    {
        _inMemoryDatabase.MovieDatabase.Add(movie);
    }
    
}