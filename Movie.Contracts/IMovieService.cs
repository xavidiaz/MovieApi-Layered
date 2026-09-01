using Movie.Core.Entities;

namespace Movie.Contracts;

public interface IMovieService
{
    Task<IEnumerable<MovieEntity>> GetAllAsync();
    Task<MovieEntity?> GetByIdAsync(int id);

    Task<MovieEntity> CreateAsync(MovieEntity movie);
    Task UpdateAsync(int id, MovieEntity movie);
    Task DeleteAsync(int id);
}
