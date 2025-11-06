using System.ComponentModel.DataAnnotations;

namespace Services.DTO;

public class ActorDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Actor name is required")]
    [MinLength(3, ErrorMessage = "Actor name must be at least 3 characters long")]
    public string Name { get; set; } = string.Empty;

    public string Character { get; set; } = string.Empty;
}
