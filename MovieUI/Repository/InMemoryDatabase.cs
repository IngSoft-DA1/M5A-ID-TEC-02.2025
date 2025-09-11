using Domain;

namespace Repository;

public class InMemoryDatabase
{
    public List<Movie> MovieDatabase { get; set; }

    public InMemoryDatabase()
    {
        MovieDatabase = new List<Movie>();
    }
    
}