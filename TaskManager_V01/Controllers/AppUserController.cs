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
        public IActionResult Get()
        {
            return Ok("Server is up snd runing");
        }

        [HttpPost]
        public IActionResult Create(UserAccountInDTO userAccountInDTO)
        {
            var result = userAccountService.Create(userAccountInDTO);
            return Ok(result);
        }
    }
}
