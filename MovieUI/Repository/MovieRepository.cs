using Domain;

namespace Repository;

public class MovieRepository
{
    public List<Movie> MovieDatabase { get; set; }

    public MovieRepository()
    {
        MovieDatabase = new List<Movie>();

        LoadMoviesExamples();
    }
    
    public void AddMovie(Movie movie)
    {
        MovieDatabase.Add(movie);
    }

    public List<Movie> GetMovies()
    {
        return MovieDatabase.ToList();
    }

    public void UpdateMovie(Movie movieWithUpdatedData)
    {
        int indexOfMovie = MovieDatabase.FindIndex(m => m.Title == movieWithUpdatedData.Title);
        MovieDatabase[indexOfMovie] = movieWithUpdatedData;
    }

    public void LoadMoviesExamples()
    {
        Movie movieExample = new Movie("Peli 1", "Director 1", DateTime.Now);
        MovieDatabase.Add(movieExample);
    }
    
    public Movie GetMovieByTitle(string title)
    {
        return MovieDatabase.First(m => m.Title == title);
    }

}