# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` 为 gRPC 服务添加了代码优先的支持，可以使用原生的 `Grpc.Core` API，或完全托管的 `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API。

它应当可以在所有能够生成*哪怕只是类似*常规 .NET 类型模型的 .NET 语言上工作。

- [快速入门](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [全部文档](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [通过 `protobuf-net.BuildTools` 获取构建/用法](https://protobuf-net.github.io/protobuf-net/build_tools)

用法非常简单，只需为你的服务契约声明一个接口：

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

然后为服务器实现该接口：

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

或者向系统请求一个客户端：

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

这等同于 .proto 文件中的服务：

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

显然你需要告诉它 uri 等信息——请参见[快速入门](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)。通常情况下配置是基于约定的，但如果你更喜欢，也可以使用[各种配置选项](https://protobuf-net.github.io/protobuf-net.Grpc/configuration)。

## 如何获取

所有内容都可以作为预编译包在 nuget 上获得；特别是，你可能需要以下其中之一：

- [适用于 ASP.NET Core 3.1 服务器的 `protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore)
- [适用于使用原生/非托管 API 的客户端或服务器的 `protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native)
- [适用于 .NET Core 3.1 上使用 `HttpClient` 的客户端的 `protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) 和 [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/)

[提供了 C#、VB 和 F# 的用法示例](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)。

## 还有其他内容吗？

`protobuf-net.Grpc` 由 [Marc Gravell](https://github.com/mgravell)（[@marcgravell](https://twitter.com/marcgravell)），即 `protobuf-net` 的作者创建并维护。

它使用了 [grpc](https://github.com/grpc/) 项目的一些工具，但并非该项目官方相关、附属或认可。

期待您的反馈，如果它能为您节省大量时间，欢迎[![请我喝咖啡](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---