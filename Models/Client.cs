namespace KionCRM.API.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Status { get; set; } = "active";
        public DateTime LastContact { get; set; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}