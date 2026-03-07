namespace GoalTracker.Domain.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal TargetValue { get; set; }
        public decimal CurrentValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted => CurrentValue >= TargetValue;

        // Calculated property for UI
        public decimal ProgressPercentage
        {
            get
            {
                if (TargetValue == 0) return 0;
                return Math.Min(100, CurrentValue / TargetValue * 100);
            }
        }
    }
}
