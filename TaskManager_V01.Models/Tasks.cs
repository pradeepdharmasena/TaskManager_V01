using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }
        public string Title { get; set; } = string.Empty;
        public required Projects Project { get; set; }
        public required AppUser Reporter { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime DeadLine {  get; set; } = DateTime.UtcNow;
        public decimal EstimatedTime { get; set; } = 1;
        public ICollection<Comments> Comments { get; set; } = [];
        public ICollection<Medias> Medias { get; set; } = [];

    }
}
