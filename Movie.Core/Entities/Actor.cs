namespace Movie.Core.Entities;

public class ActorEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly? BirthDate { get; set; }

    public ICollection<ActorEntity> Actors = [];
}
