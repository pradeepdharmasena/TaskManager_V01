namespace TaskManager_V01.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Tittle { get; set; } = string.Empty;
        public int OwnerAccountID { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime DeadLine { get; set; } = DateTime.UtcNow.AddDays(1);
        public ICollection<Task> Tasks { get; set; } = [];
        public required UserAccount Owner { get; set; } = null!;

    }
}
