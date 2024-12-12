using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Models
{
    public class UserAccount
    {
        public int AccountID { get; set; }
        public required string Email { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public ICollection<Project> Projects { get; set; } = [];
    }
}
