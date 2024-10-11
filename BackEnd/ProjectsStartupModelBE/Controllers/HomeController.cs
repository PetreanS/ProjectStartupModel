using Microsoft.AspNetCore.Mvc;
using ProjectsStartupModelBE.Data;

namespace ProjectsStartupModelBE.Controllers
{
    //After implementing a new Controller you can delete this one.

    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Welcome!" });
        }
    }
}
