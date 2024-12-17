using System.ComponentModel.DataAnnotations;
using TaskManager_V01.Models;

namespace TaskManager_V01.Dtos
{
    public class UserRegisterDTO
    {
        public  string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
