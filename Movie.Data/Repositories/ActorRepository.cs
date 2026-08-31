using Microsoft.EntityFrameworkCore;
using Movie.Core.Contracts;
using Movie.Core.Entities;

namespace Movie.Data.Repositories;

public class ActorRepository(MovieContext context) : IActorRepository
{
    public async Task<IEnumerable<ActorEntity>> GetAllAsync() => await context.Actors.ToListAsync();
    public async Task<ActorEntity?> GetByIdAsync(int id) => await context.Actors.FindAsync(id);
    public async Task<bool> ExistAsync(int id) => await context.Actors.AnyAsync(a => a.Id == id);

    public void Add(ActorEntity actor) => context.Actors.Add(actor);
    public void Update(ActorEntity actor) => context.Actors.Update(actor);
    public void Remove(ActorEntity actor) => context.Actors.Remove(actor);
}
