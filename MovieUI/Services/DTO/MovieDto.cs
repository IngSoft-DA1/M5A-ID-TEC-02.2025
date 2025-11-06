using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO;

public class MovieDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Director is required")]
    public string Director { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; } = DateTime.Now;

    public List<ActorDto> Actors { get; set; } = new List<ActorDto>();
}
