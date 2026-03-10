using GoalTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoalTracker.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options){}
        
        public DbSet<Goal> Goals { get; set; }
    }
}
