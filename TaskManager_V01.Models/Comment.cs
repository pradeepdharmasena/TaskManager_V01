using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int TaskId { get; set; }
        public required int WriterAccountID { get; set; }
        public string Header { get; set; }   = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDateTime { get; set; } = DateTime.UtcNow;
        public required Task Task { get; set; } = null!;
        public required User Writer { get; set; } = null!;
    }
}
