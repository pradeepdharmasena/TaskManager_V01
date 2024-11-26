using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public required Task Task { get; set; }
        public required AppUser Writer { get; set; }
        public string Header { get; set; }   = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDateTime { get; set; } = DateTime.UtcNow;
    }
}
