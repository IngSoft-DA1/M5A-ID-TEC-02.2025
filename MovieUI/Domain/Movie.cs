namespace Domain;

public class Movie
{
    public string Title { get; set; } // Primary key
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Movie(string title, string director, DateTime releaseDate)
    {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
    }
    
    //Validaciones sobre las misma properties
    //Metodo= validarLargoTitulo
}