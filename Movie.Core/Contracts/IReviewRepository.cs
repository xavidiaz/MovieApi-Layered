using Movie.Core.Entities;

namespace Movie.Core.Contracts;

public interface IReviewRepository
{
    Task<IEnumerable<ReviewEntity>> GetAllAsync();
    Task<ReviewEntity?> GetByIdAsync(int id);
    Task<bool> ExistAsync(int id);
    void Add(ReviewEntity review);
    void Update(ReviewEntity review);
    void Remove(ReviewEntity review);
}
