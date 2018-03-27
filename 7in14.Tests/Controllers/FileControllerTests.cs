using _7in14.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using System.IO;
using System.Net.Http;
using Xunit;

namespace _7in14.Tests.Controllers
{
    public class FileControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public FileControllerTests()
        {
            var contentRoot = Path.Combine(Directory.GetCurrentDirectory(), "../../../");
            var webHost = new WebHostBuilder()
                .UseStartup<Startup>()
                .UseContentRoot(contentRoot);

            _server = new TestServer(webHost);
            _client = _server.CreateClient();
        }

        [Fact, Trait("Category", "Integration")]
        public async void File_Get_ReturnsReadmeFileContent()
        {
            // when
            var result = await _client.GetAsync("/api/file");

            // then
            result.Should().BeOfType<HttpResponseMessage>();
            var content = await (result as HttpResponseMessage).Content.ReadAsStringAsync();
            content.Should().Contain("pc-dotnet");
        }
    }
}
