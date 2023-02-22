using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return Ok("OK");
        }


    }
}
