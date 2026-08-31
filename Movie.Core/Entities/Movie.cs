namespace Movie.Core.Entities;

public class MovieEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }
    public int DurationMinutes { get; set; }
    public string? Description { get; set; }

    public ICollection<ActorEntity> Actors = [];
    public ICollection<ReviewEntity> Reviews = [];
}
