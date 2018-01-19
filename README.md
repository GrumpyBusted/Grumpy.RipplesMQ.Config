# Grumpy.RipplesMQ.Config
Configuration for RipplesMQ Client

[![grumpybusted MyGet Build Status](https://www.myget.org/BuildSource/Badge/grumpybusted?identifier=fcb37c37-9355-4552-80d9-c158a1f99e50)](https://www.myget.org/feed/grumpybusted/package/nuget/Grumpy.RipplesMQ.Config)  
[![NuGet](https://img.shields.io/nuget/v/Grumpy.RipplesMQ.Config.svg)](https://www.nuget.org/packages/Grumpy.RipplesMQ.Config/)
[![Downloads](https://img.shields.io/nuget/dt/Grumpy.RipplesMQ.Config.svg)](https://www.nuget.org/packages/Grumpy.RipplesMQ.Config)

Use the PublishSubscribeConfig and RequestResponseConfig classes to define your API for your service

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
