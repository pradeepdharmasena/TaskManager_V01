using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V01.Dtos
{
    public class UserAccountDto
    {
        public required  string Email { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public string? ProfileImageURL { get; set; }
        public  string? Password { get; set; }
        public string? NewPassword { get; set; }
    }
}
