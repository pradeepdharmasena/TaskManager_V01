namespace TaskManager_V01.Models
{
    public class Projects
    {
        public int ProjectId { get; set; }
        public string Tittle { get; set; } = string.Empty;
        public required AppUser Owner { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime DeadLine { get; set; } = DateTime.UtcNow.AddDays(1);
        public ICollection<Tasks> Tasks { get; set; } = [];

    }
}
