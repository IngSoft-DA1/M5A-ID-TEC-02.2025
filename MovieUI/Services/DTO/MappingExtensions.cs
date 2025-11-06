using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Services.DTO;

public static class MappingExtensions
{
    public static MovieDto ToDto(this Movie movie)
    {
        var dto = new MovieDto
        {
            Id = movie.Id,
            Title = movie.Title,
            Director = movie.Director,
            ReleaseDate = movie.ReleaseDate,
            Actors = movie.Actors?
                .Select(actor => actor.ToDto())
                .ToList() ?? new List<ActorDto>()
        };

        return dto;
    }

    public static ActorDto ToDto(this Actor actor)
    {
        return new ActorDto
        {
            Id = actor.Id,
            Name = actor.Name,
            Character = actor.Character
        };
    }

    public static Movie ToEntity(this MovieDto movieDto)
    {
        var movie = new Movie(movieDto.Title, movieDto.Director, movieDto.ReleaseDate)
        {
            Id = movieDto.Id,
            Actors = movieDto.Actors?
                .Select(actorDto => actorDto.ToEntity())
                .ToList() ?? new List<Actor>()
        };

        foreach (var actor in movie.Actors)
        {
            actor.Movie = movie;
        }

        return movie;
    }

    public static Actor ToEntity(this ActorDto actorDto)
    {
        return new Actor
        {
            Id = actorDto.Id,
            Name = actorDto.Name,
            Character = actorDto.Character
        };
    }
}
