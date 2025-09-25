using Domain;

namespace Repository;

public class MovieRepository
{
    public List<Movie> MovieDatabase { get; set; }

    public MovieRepository()
    {
        MovieDatabase = new List<Movie>();
    }
    
    public void AddMovie(Movie movie)
    {
        MovieDatabase.Add(movie);
    }
    
}