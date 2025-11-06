using System.Collections.Generic;

namespace Domain;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    public Actor? LeadActor { get; set; }
    public List<Actor> Actors { get; set; } = new List<Actor>();

    public Movie(string title, string director, DateTime releaseDate)
    {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
    }
}
