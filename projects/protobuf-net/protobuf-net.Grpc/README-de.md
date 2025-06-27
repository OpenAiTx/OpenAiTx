# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` fügt Code-First-Unterstützung für Dienste über gRPC hinzu, entweder über die native `Grpc.Core` API oder die vollständig verwaltete `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API.

Es sollte mit allen .NET-Sprachen funktionieren, die *auch nur annähernd* ein reguläres .NET-Typmodell erzeugen können.

- [Erste Schritte](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Alle Dokumentationen](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/Nutzung verfügbar über `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Die Verwendung ist so einfach wie das Deklarieren eines Interfaces für Ihren Servicevertrag:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

dann entweder die Implementierung dieses Interfaces für einen Server:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

oder das System nach einem Client fragen:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Dies wäre äquivalent zu dem Service in .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Natürlich müssen Sie die URI usw. angeben – siehe [Erste Schritte](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). In der Regel ist die Konfiguration konventionsbasiert, aber
wenn Sie möchten: Es gibt [verschiedene Konfigurationsoptionen](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Wie bekomme ich es?

Alles ist als vorgefertigte Pakete auf NuGet verfügbar; insbesondere möchten Sie wahrscheinlich eines der folgenden:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) für Server mit ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) für Clients oder Server, die die native/unmanaged API verwenden
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) und [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) für Clients, die `HttpClient` auf .NET Core 3.1 verwenden

[Beispielanwendungen sind verfügbar in C#, VB und F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Noch etwas?

`protobuf-net.Grpc` wird erstellt und gepflegt von [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), dem Autor von `protobuf-net`.

Es nutzt Werkzeuge von [grpc](https://github.com/grpc/), ist jedoch nicht offiziell mit diesem Projekt assoziiert, verbunden oder von ihm empfohlen.

Ich freue mich auf Ihr Feedback, und wenn Ihnen dies viel Zeit sparen sollte, sind Sie herzlich eingeladen, [![Buy me a coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---