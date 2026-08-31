using Movie.Core.Entities;

namespace Movie.Core.Contracts;

public interface IActorRepository
{
    Task<IEnumerable<ActorEntity>> GetAllAsync();
    Task<ActorEntity?> GetByIdAsync(int id);
    Task<bool> ExistAsync(int id);
    void Add(ActorEntity actor);
    void Update(ActorEntity actor);
    void Remove(ActorEntity actor);
}
