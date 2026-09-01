using Movie.Core.Entities;

namespace Movie.Contracts;

public interface IActorService
{
    Task<IEnumerable<ActorEntity>> GetAllAsync();
    Task<ActorEntity?> GetByIdAsync(int id);

    Task<ActorEntity> CreateAsync(ActorEntity actor);
    Task UpdateAsync(int id, ActorEntity actor);
    Task DeleteAsync(int id);
}

