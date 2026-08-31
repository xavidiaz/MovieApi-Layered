namespace Movie.Core.Entities;

public class ReviewEntity
{
    public int Id { get; set; }
    public string ReviewerName { get; set; } = string.Empty;
    public string Commment { get; set; } = string.Empty;
    public double Rating { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    public int MovieId { get; set; }
    public MovieEntity Movie { get; set; } = null!;

}

