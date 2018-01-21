using FluentAssertions;
using Xunit;

namespace Grumpy.RipplesMQ.Config.UnitTests
{
    public class PublishSubScribeConfigTests
    {
        [Fact]
        public void CanCreateConfig()
        {
            var cut = new PublishSubscribeConfig
            {
                Persistent = true,
                Topic = "MyTopic"
            };

            cut.Persistent.Should().BeTrue();
            cut.Topic.Should().Be("MyTopic");
        }
    }
}
