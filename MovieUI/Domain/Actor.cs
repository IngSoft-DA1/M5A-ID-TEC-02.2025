namespace Domain;

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Character { get; set; } = string.Empty;
    public Movie? Movie { get; set; }
}
