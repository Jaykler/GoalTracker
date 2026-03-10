using GoalTracker.Application.Interfaces;
using GoalTracker.Domain.Entities;
using GoalTracker.Infrastructure.Data;

namespace GoalTracker.Infrastructure.Repositories
{
    public class GoalRepository : IGoalRepository
    {

        private readonly AppDbContext _context;

        public GoalRepository(AppDbContext context)=> _context = context;

        public Task<Goal> AddAsync(Goal goal)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Goal>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Goal?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Goal goal)
        {
            throw new NotImplementedException();
        }
    }
}
