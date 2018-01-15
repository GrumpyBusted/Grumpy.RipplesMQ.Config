using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Config
{
    /// <summary>
    /// Request/Response Configuration
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class RequestResponseConfig
    {
        /// <summary>
        /// Request Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Timeout interval in milliseconds
        /// </summary>
        public int MillisecondsTimeout { get; set; }
    }
}