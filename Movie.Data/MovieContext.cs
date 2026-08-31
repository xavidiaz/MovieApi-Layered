
using Microsoft.EntityFrameworkCore;
using Movie.Core.Entities;

namespace Movie.Data;

public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
{
    public DbSet<MovieEntity> Movies => Set<MovieEntity>();
    public DbSet<ActorEntity> Actors => Set<ActorEntity>();
    public DbSet<ReviewEntity> Reviews => Set<ReviewEntity>();
}
