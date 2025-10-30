using Domain;

namespace Repository;

public class MovieRepository
{
    private SqlContext _context;
    
    public MovieRepository(SqlContext context)
    {
        _context = context;
    }
    
    public void AddMovie(Movie movie)
    {
        _context.Movie.Add(movie);
        _context.SaveChanges();
    }

    public void DeleteMovie(int movieId)
    {
        Movie? movie = _context.Movie.Find(movieId);
        if(movie == null) throw new KeyNotFoundException();
        _context.Movie.Remove(movie);
        _context.SaveChanges();
    }

    public List<Movie> GetMovies()
    {
        return _context.Movie.ToList();
    }

    public void UpdateMovie(Movie movieWithUpdatedData)
    {
        _context.Movie.Update(movieWithUpdatedData);
        _context.SaveChanges();
    }
    
    public Movie? GetMovie(Func<Movie, bool> predicate)
    {
        return _context.Movie.FirstOrDefault(predicate);
    }

}