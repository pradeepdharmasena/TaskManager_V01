using Microsoft.AspNetCore.Mvc;

namespace TaskManager_V01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Server is up snd runing");
        }
    }
}
