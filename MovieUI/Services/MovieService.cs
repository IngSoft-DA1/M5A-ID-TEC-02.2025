using System.Collections.Generic;
using System.Linq;
using Repository;
using Services.DTO;

namespace Services;

public class MovieService
{
    private readonly MovieRepository _movieRepository;

    public MovieService(MovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void AddMovie(MovieDto movieDto)
    {
        _movieRepository.AddMovie(movieDto.ToEntity());
    }

    public List<MovieDto> GetMovies()
    {
        return _movieRepository
            .GetMovies()
            .Select(movie => movie.ToDto())
            .ToList();
    }

    public void DeleteMovie(int id)
    {
        _movieRepository.DeleteMovie(id);
    }

    public void UpdateMovie(MovieDto movieWithUpdatedData)
    {
        var movieOriginal = _movieRepository.GetMovie(m => m.Id == movieWithUpdatedData.Id);
        if(movieOriginal == null) throw new KeyNotFoundException($"Movie was not found.");
        movieOriginal.Title = movieWithUpdatedData.Title;
        movieOriginal.Director = movieWithUpdatedData.Director;
        movieOriginal.ReleaseDate = movieWithUpdatedData.ReleaseDate;
        _movieRepository.UpdateMovie(movieOriginal);
    }
    
    public MovieDto? GetMovieByTitle(string title)
    {
        return _movieRepository
            .GetMovie(movie => movie.Title == title)
            ?.ToDto();
    }

    public MovieDto? GetMovieById(int id)
    {
        return _movieRepository
            .GetMovie(movie => movie.Id == id)
            ?.ToDto();
    }

    public void AddActor(int movieId, ActorDto actorDto)
    {
        var movie = _movieRepository
            .GetMovie(m => m.Id == movieId);

        if (movie is null)
        {
            throw new KeyNotFoundException($"Movie with id {movieId} was not found.");
        }

        movie.Actors.Add(actorDto.ToEntity());
        _movieRepository.UpdateMovie(movie);
    }

}
