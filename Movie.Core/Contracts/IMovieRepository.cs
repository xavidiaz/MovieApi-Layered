using Movie.Core.Entities;

namespace Movie.Core.Contracts;

public interface IMovieRepository
{
    Task<IEnumerable<MovieEntity>> GetAllAsync();
    Task<MovieEntity?> GetByIdAsync(int id);
    Task<bool> ExistAsync(int id);
    void Add(MovieEntity movie);
    void Update(MovieEntity movie);
    void Remove(MovieEntity movie);
}
