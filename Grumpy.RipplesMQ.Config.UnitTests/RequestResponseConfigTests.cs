using FluentAssertions;
using Xunit;

namespace Grumpy.RipplesMQ.Config.UnitTests
{
    public class RequestResponseConfigTests
    {
        [Fact]
        public void CanCreateConfig()
        {
            var cut = new RequestResponseConfig
            {
                Name = "MyRequest",
                MillisecondsTimeout = 1000
            };

            cut.Name.Should().Be("MyRequest");
            cut.MillisecondsTimeout.Should().Be(1000);
        }
    }
}