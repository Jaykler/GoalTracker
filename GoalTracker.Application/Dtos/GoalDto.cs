using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalTracker.Application.Dtos
{
    public class GoalDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal TargetValue { get; set; }
        public decimal CurrentValue { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ProgressPercentage { get; set; }
        public bool IsCompleted { get; set; }
    }
}
