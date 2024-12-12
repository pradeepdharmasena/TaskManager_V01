using System.ComponentModel.DataAnnotations;
using TaskManager_V01.Models;

namespace TaskManager_V01.Dtos
{
    public class UserAccountInDTO
    {
        public required string Email { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProfileImageURL { get; set; } = string.Empty;

    }
}
