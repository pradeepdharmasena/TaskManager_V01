using Microsoft.AspNetCore.Mvc;
using TaskManager_V01.Dtos;
using TaskManager_V01.Services;

namespace TaskManager_V01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController(IUserAccountService userAccountService) : ControllerBase
    {

        [HttpGet]
        public IActionResult GetByEmail(string email, string password)
        {
            return Ok("Server is up snd runing");
        }

        [HttpPost]
        public IActionResult Create(UserAccountInDTO userAccountInDTO)
        {
            UserAccountOutDTO? userAccountOutDTO = userAccountService.Create(userAccountInDTO);
            if (userAccountOutDTO == null)
            {
                return BadRequest();
            }
            return Ok(userAccountOutDTO);
        }

        [HttpPut]
        public IActionResult Update(UserAccountDto userAccountUpdateDto)
        {
            UserAccountOutDTO? userAccountOutDTO = userAccountService.Update(userAccountUpdateDto);
            if (userAccountOutDTO == null)
            {
                return BadRequest(userAccountOutDTO);
            }

            return Ok(userAccountOutDTO);
        }
    }
}
