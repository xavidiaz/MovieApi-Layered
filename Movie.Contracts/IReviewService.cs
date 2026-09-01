using Movie.Core.Entities;

namespace Movie.Contracts;

public interface IReviewService
{
    Task<IEnumerable<ReviewEntity>> GetAllAsync();
    Task<ReviewEntity?> GetByIdAsync(int id);

    Task<ReviewEntity> CreateAsync(ReviewEntity review);
    Task UpdateAsync(int id, ReviewEntity review);
    Task DeleteAsync(int id);
}
