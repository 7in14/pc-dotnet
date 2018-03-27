using Microsoft.AspNetCore.Mvc;

namespace _7in14.Controllers
{
    [Route("api/[controller]")]
    public class PingController
    {
        // GET api/ping
        [HttpGet]
        public string Get()
        {
            return "pong";
        }
    }
}
