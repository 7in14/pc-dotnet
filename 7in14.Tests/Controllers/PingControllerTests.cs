using _7in14.Controllers;
using FluentAssertions;
using Xunit;

namespace _7in14.Tests.Controllers
{
    public class PingControllerTests
    {
        [Fact]
        public void Ping_ReturnsPong()
        {
            // given
            var controller = new PingController();

            // when
            var result = controller.Get();

            // then
            result.Should().Be("pong");
        }
    }
}
