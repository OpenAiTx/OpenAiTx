# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` 為 gRPC 服務提供了基於程式碼優先（code-first）的方法，支援原生的 `Grpc.Core` API 及純託管的 `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API。

它應該可在所有能產生*類似*標準 .NET 型別模型的 .NET 語言上運作。

- [快速上手](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [所有文件](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [可透過 `protobuf-net.BuildTools` 取得建置/用法](https://protobuf-net.github.io/protobuf-net/build_tools)

使用方式非常簡單，只需為您的服務合約宣告一個介面：

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

然後在伺服器端實作該介面：

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

或向系統請求一個用戶端：

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

這等同於 .proto 中的服務宣告：

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

顯然，您需要指定 uri 等詳細資訊——請參見[快速上手](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)。通常配置是基於慣例的，但
如果您有需要，也有[多種配置選項](https://protobuf-net.github.io/protobuf-net.Grpc/configuration)。

## 如何取得

所有元件皆可在 nuget 以預建套件取得；您可能會需要以下其中之一：

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) 適用於 ASP.NET Core 3.1 的伺服器
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) 適用於使用原生/非託管 API 的用戶端或伺服器
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) 及 [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) 適用於 .NET Core 3.1 上使用 `HttpClient` 的用戶端

[使用範例提供 C#、VB 及 F# 版本](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)。

## 還有其他嗎？

`protobuf-net.Grpc` 由 `protobuf-net` 作者 [Marc Gravell](https://github.com/mgravell)（[@marcgravell](https://twitter.com/marcgravell)）建立與維護。

本專案使用了 [grpc](https://github.com/grpc/) 的工具，但並未與該專案有官方合作、關聯或背書。

期待您的回饋，如果這個專案能幫您節省大量時間，也歡迎[![請我喝杯咖啡](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---