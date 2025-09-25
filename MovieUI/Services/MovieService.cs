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

    public void UpdateMovie(Movie movieWithUpdatedData)
    {
        //Logica para validar que este correcto contra la db
        _movieRepository.UpdateMovie(movieWithUpdatedData);
    }
    
    public Movie GetMovieByTitle(string title)
    {
        return _movieRepository.GetMovieByTitle(title);
    }
    

}