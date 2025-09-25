using Domain;
using Repository;

namespace Services;

public class MovieService
{
    private MovieRepository _movieRepository;

    public MovieService(MovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void AddMovie(Movie movie)
    {
        _movieRepository.AddMovie(movie);
    }
    
}