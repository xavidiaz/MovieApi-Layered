using Microsoft.EntityFrameworkCore;
using Movie.Core.Contracts;
using Movie.Core.Entities;

namespace Movie.Data.Repositories;

public class ReviewRepository(MovieContext context) : IReviewRepository
{
    public async Task<IEnumerable<ReviewEntity>> GetAllAsync() => await context.Reviews.ToListAsync();
    public async Task<ReviewEntity?> GetByIdAsync(int id) => await context.Reviews.FindAsync(id);
    public async Task<bool> ExistsAsync(int id) => await context.Reviews.AnyAsync(r => r.Id == id);

    public void Add(ReviewEntity review) => context.Reviews.Add(review);
    public void Update(ReviewEntity review) => context.Reviews.Update(review);
    public void Remove(ReviewEntity review) => context.Reviews.Remove(review);
}
