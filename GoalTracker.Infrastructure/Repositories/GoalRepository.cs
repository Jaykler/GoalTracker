using GoalTracker.Application.Interfaces;
using GoalTracker.Domain.Entities;
using GoalTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GoalTracker.Infrastructure.Repositories
{
    public class GoalRepository : IGoalRepository
    {

        private readonly AppDbContext _context;

        public GoalRepository(AppDbContext context) => _context = context;
        public async Task<IEnumerable<Goal>> GetAllAsync()
        => await _context.Goals.ToListAsync();

        public async Task<Goal?> GetByIdAsync(int id)
        => await _context.Goals.FindAsync(id);
        
        public async Task<Goal> AddAsync(Goal goal)
        {
             _context.Goals.AddAsync(goal);
            await _context.SaveChangesAsync();
            return goal;

        }
        public async Task UpdateAsync(Goal goal)
        {
             _context.Goals.Update(goal);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var goal = await _context.Goals.FindAsync(id);

            if (goal != null)
            {
                 _context.Goals.Remove(goal);
                 await _context.SaveChangesAsync();
            }
        }

        
    }
}
