using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace Rate_Limiting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("Fixed")]
    public class ValuesController : Controller
    { 
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
