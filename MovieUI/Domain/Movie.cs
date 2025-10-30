namespace Domain;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Movie(string title, string director, DateTime releaseDate)
    {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
    }
}