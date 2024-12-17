using Microsoft.AspNetCore.Mvc;
using TaskManager_V01.Dtos;
using TaskManager_V01.Models;
using TaskManager_V01.Services;

namespace TaskManager_V01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController(IUserService userAccountService) : ControllerBase
    {
        public static User user = new User();

        [HttpGet]
        public IActionResult GetByEmail(string email, string password)
        {
            return Ok("Server is up snd runing");
        }

        [HttpPost]
        public IActionResult Create(UserRegisterDTO userAccountInDTO)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userAccountInDTO.Password);
            UserOutDTO? userAccountOutDTO = userAccountService.Create(userAccountInDTO);
            if (userAccountOutDTO == null)
            {
                return BadRequest();
            }
            return Ok(userAccountOutDTO);
        }

        [HttpPut]
        public IActionResult Update(UserDto userAccountUpdateDto)
        {
            UserOutDTO? userAccountOutDTO = userAccountService.Update(userAccountUpdateDto);
            if (userAccountOutDTO == null)
            {
                return BadRequest(userAccountOutDTO);
            }

            return Ok(userAccountOutDTO);
        }
    }
}
