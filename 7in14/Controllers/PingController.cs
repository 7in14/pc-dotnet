using Microsoft.AspNetCore.Mvc;

namespace _7in14.Controllers
{
    [Route("api/[controller]")]
    public class PingController
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "ponger";
        }
    }
}
