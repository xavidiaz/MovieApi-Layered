using Microsoft.EntityFrameworkCore;
using Movie.Core.Contracts;

namespace Movie.Data.Repositories;

public class UnitOfWork(MovieContext context) : IUnitOfWork
{
    public IMovieRepository Movies { get; } = new MovieRepository(context);
    public IActorRepository Actors { get; } = new ActorRepository(context);
    public IReviewRepository Reviews { get; } = new ReviewRepository(context);

    public Task<int> CompleteAsync() => context.SaveChangesAsync();
}
