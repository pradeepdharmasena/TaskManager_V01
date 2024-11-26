using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    public class AppUser
    {
        public int AccountID { get; set; }
        [Required]
        public required string Email { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public ICollection<Projects> Projects { get; set; } = [];
    }
}
