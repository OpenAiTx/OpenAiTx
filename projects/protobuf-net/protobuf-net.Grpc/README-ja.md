# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` は、ネイティブの `Grpc.Core` API または完全マネージドの `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API を使用して、gRPC 上でサービスにコードファーストサポートを追加します。

これは、*通常の .NET 型モデルに少しでも似たもの* を生成できるすべての .NET 言語で動作するはずです。

- [はじめに](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [全ドキュメント](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [`protobuf-net.BuildTools` 経由で利用可能なビルド/使用方法](https://protobuf-net.github.io/protobuf-net/build_tools)

使用方法は、サービスコントラクト用のインターフェースを宣言するだけでとても簡単です:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

そしてサーバー用にそのインターフェースを実装するか:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

または、クライアントをシステムに依頼します:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

これは .proto でのサービスと同等です:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

もちろん、URI などを指定する必要があります — 詳しくは [はじめに](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted) をご覧ください。通常、構成は規約ベースですが、
必要に応じて[さまざまな構成オプション](https://protobuf-net.github.io/protobuf-net.Grpc/configuration)もあります。

## 入手方法

すべてのパッケージは nuget でプレビルドパッケージとして利用可能です。特に、以下のいずれかが必要になるでしょう:

- ASP.NET Core 3.1 用サーバーには [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore)
- ネイティブ/アンマネージ API を使用するクライアントまたはサーバーには [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native)
- .NET Core 3.1 上で `HttpClient` を使用するクライアントには [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) および [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/)

[C#, VB, F# での使用例はこちら](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)。

## その他

`protobuf-net.Grpc` は [`protobuf-net`](https://github.com/protobuf-net/protobuf-net) の作者である [Marc Gravell](https://github.com/mgravell)（[@marcgravell](https://twitter.com/marcgravell)）によって作成・メンテナンスされています。

これは [grpc](https://github.com/grpc/) のツールを利用していますが、そのプロジェクトと公式に関連・提携・承認されているわけではありません。

皆様のフィードバックをお待ちしております。また、もしこのツールがあなたの多くの時間を節約できた場合は、いつでも [![コーヒーをごちそうしてください](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---