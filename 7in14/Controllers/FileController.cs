using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading.Tasks;

namespace _7in14.Controllers
{
    [Route("api/[controller]")]
    public class FileController
    {
        private readonly IHostingEnvironment _environment;

        public FileController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // GET api/file
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var path = Directory.GetCurrentDirectory();

            var readmeContent = await File.ReadAllTextAsync(Path.Combine(_environment.ContentRootPath, "../README.md"));

            var jObject = new JObject
            {
                { "data", readmeContent }
            };

            return new JsonResult(jObject);
        }
    }
}
