using System.ComponentModel.DataAnnotations;

namespace TaskManager_V01.Dtos
{
    public class AppUserInDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public required string Email { get; set; }
        public string ProfileImageURL { get; set; } = string.Empty;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}
