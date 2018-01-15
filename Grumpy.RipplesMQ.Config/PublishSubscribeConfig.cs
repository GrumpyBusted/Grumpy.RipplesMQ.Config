using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Config
{
    /// <summary>
    /// Publish/Subscribe Configuration
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class PublishSubscribeConfig
    {
        /// <summary>
        /// Message Topic (Subject)
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Should Message be Persistent
        /// </summary>
        public bool Persistent { get; set; }
    }
}