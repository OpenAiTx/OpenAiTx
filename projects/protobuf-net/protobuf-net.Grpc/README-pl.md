# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` dodaje wsparcie dla usług w stylu code-first przez gRPC, wykorzystując natywne API `Grpc.Core` lub w pełni zarządzane API `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Powinno działać we wszystkich językach .NET, które potrafią wygenerować coś *choćby zbliżonego* do typowego modelu typu .NET.

- [Pierwsze kroki](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Cała dokumentacja](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Budowanie/użycie dostępne przez `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Użycie jest tak proste, jak zadeklarowanie interfejsu kontraktu usługi:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

następnie albo zaimplementowanie tego interfejsu po stronie serwera:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

albo poproszenie systemu o klienta:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

To byłoby równoważne usłudze w .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Oczywiście musisz podać uri itp. – zobacz [Pierwsze kroki](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Zazwyczaj konfiguracja oparta jest na konwencjach, ale
jeśli wolisz: dostępne są [różne opcje konfiguracji](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Jak to zdobyć

Wszystko jest dostępne jako gotowe paczki na nuget; w szczególności, prawdopodobnie będziesz chciał jedną z:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) dla serwerów używających ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) dla klientów lub serwerów używających natywnego/niezarządzanego API
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) oraz [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) dla klientów używających `HttpClient` na .NET Core 3.1

[Przykłady użycia dostępne są w C#, VB i F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Coś jeszcze?

`protobuf-net.Grpc` jest tworzony i utrzymywany przez [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), autora `protobuf-net`.

Wykorzystuje narzędzia z projektu [grpc](https://github.com/grpc/), ale nie jest oficjalnie powiązany, stowarzyszony ani zatwierdzony przez ten projekt.

Czekam na Twoją opinię, a jeśli to narzędzie może zaoszczędzić Ci mnóstwo czasu, zawsze możesz [![Postaw mi kawę](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---