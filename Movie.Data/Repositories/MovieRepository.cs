using Microsoft.EntityFrameworkCore;
using Movie.Core.Contracts;
using Movie.Core.Entities;

namespace Movie.Data.Repositories;

public class MovieRepository(MovieContext context) : IMovieRepository
{
    public async Task<IEnumerable<MovieEntity>> GetAllAsync() => await context.Movies.ToListAsync();
    public async Task<MovieEntity?> GetByIdAsync(int id) => await context.Movies.FindAsync(id);
    public async Task<bool> ExistsAsync(int id) => await context.Movies.AnyAsync(m => m.Id == id);

    public void Add(MovieEntity movie) => context.Movies.Add(movie);
    public void Update(MovieEntity movie) => context.Movies.Update(movie);
    public void Remove(MovieEntity movie) => context.Movies.Remove(movie);
}
