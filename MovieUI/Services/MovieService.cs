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

    public List<Movie> GetMovies()
    {
        return _movieRepository.GetMovies();
    }

    public void DeleteMovie(int id)
    {
        _movieRepository.DeleteMovie(id);
    }

    public void UpdateMovie(Movie movieWithUpdatedData)
    {
        _movieRepository.UpdateMovie(movieWithUpdatedData);
    }
    
    public Movie? GetMovie(Func<Movie, bool> predicate)
    {
        return _movieRepository.GetMovie(predicate);
    }
    

}