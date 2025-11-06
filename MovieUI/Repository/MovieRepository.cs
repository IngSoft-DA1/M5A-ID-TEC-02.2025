using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

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
        Movie? movie = _context.Movie
            .FirstOrDefault(m => m.Id == movieId);
        if(movie == null) throw new KeyNotFoundException();

        _context.Movie.Remove(movie);
        _context.SaveChanges();
    }

    public List<Movie> GetMovies()
    {
        return _context.Movie
            .AsNoTracking()
            .Include(movie => movie.Actors)
            .ToList();
    }

    public void UpdateMovie(Movie movieWithUpdatedData)
    {
        _context.Movie.Update(movieWithUpdatedData);
        _context.SaveChanges();
    }
    
    public Movie? GetMovie(Func<Movie, bool> predicate)
    {
        return _context.Movie
            .Include(movie => movie.Actors)
            .FirstOrDefault(predicate);
    }

}
