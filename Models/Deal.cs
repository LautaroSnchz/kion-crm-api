namespace KionCRM.API.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public string Stage { get; set; } = "lead";
        public int Probability { get; set; } = 20;
        public string Client { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public string Assignee { get; set; } = string.Empty;
        public DateTime ExpectedCloseDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}