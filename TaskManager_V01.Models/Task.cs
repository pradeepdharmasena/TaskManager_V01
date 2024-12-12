using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    
    public class Task
    {
        public int TaskId { get; set; }
        public int ProjectID {  get; set; } 
        public string Title { get; set; } = string.Empty;
        public required int ReporterAccountID { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime DeadLine {  get; set; } = DateTime.UtcNow;
        public decimal EstimatedTime { get; set; } = 1;
        public ICollection<Comment> Comments { get; set; } = [];
        public ICollection<Media> Medias { get; set; } = [];
        public required Project Project { get; set; }
        public required UserAccount Reporter { get; set; }

    }
}
