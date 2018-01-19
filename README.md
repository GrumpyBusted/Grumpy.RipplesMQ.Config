[![Build status](https://ci.appveyor.com/api/projects/status/9ruc2kl844jacdjx?svg=true)](https://ci.appveyor.com/project/GrumpyBusted/grumpy-ripplesmq-config)
[![codecov](https://codecov.io/gh/GrumpyBusted/Grumpy.RipplesMQ.Config/branch/master/graph/badge.svg)](https://codecov.io/gh/GrumpyBusted/Grumpy.RipplesMQ.Config)
[![nuget](https://img.shields.io/nuget/v/Grumpy.RipplesMQ.Config.svg)](https://www.nuget.org/packages/Grumpy.RipplesMQ.Config/)
[![downloads](https://img.shields.io/nuget/dt/Grumpy.RipplesMQ.Config.svg)](https://www.nuget.org/packages/Grumpy.RipplesMQ.Config/)

# Grumpy.RipplesMQ.Config
Configuration for RipplesMQ messages used to define API for Services using RipplesMQ as Message Broker.

Use the PublishSubscribeConfig and RequestResponseConfig classes to define your API for your service.

For more information about the RipplesMQ project see [Grumpy.RipplesMQ.Client](https://github.com/GrumpyBusted/Grumpy.RipplesMQ.Client).

```csharp
namespace Grumpy.MyService.Api
{
    public static class MyServiceConfig
    {
        public static readonly PublishSubscribeConfig MyPublishConfig = new PublishSubscribeConfig
        {
            Topic = "MyTopic",
            Persistent = false
        };

        public static readonly RequestResponseConfig MyRequestConfig = new RequestResponseConfig
        {
            Name = "MyRequest", 
            MillisecondsTimeout = 1000
        };
    }
}
```