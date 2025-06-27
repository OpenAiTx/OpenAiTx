# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` voegt code-first ondersteuning toe voor services over gRPC met gebruik van ofwel de native `Grpc.Core` API, of de volledig beheerde `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API.

Het zou moeten werken op alle .NET-talen die iets kunnen genereren dat *ook maar enigszins lijkt* op een regulier .NET-type model.

- [Aan de slag](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Alle documentatie](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Bouwen/gebruiken beschikbaar via `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Het gebruik is net zo eenvoudig als het declareren van een interface voor je servicecontract:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

daarna kun je deze interface implementeren voor een server:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

of het systeem vragen om een client:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Dit zou gelijkwaardig zijn aan de service in .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Uiteraard moet je de uri enz. opgeven - zie [Aan de slag](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Meestal is de configuratie conventie-gebaseerd, maar
als je dat liever hebt: er zijn [verschillende configuratieopties](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Hoe kom je eraan

Alles is beschikbaar als vooraf gebouwde pakketten op nuget; in het bijzonder wil je waarschijnlijk een van de volgende:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) voor servers die ASP.NET Core 3.1 gebruiken
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) voor clients of servers die de native/unmanaged API gebruiken
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) en [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) voor clients die `HttpClient` gebruiken op .NET Core 3.1

[Voorbeelden van gebruik zijn beschikbaar in C#, VB en F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Nog iets anders?

`protobuf-net.Grpc` is gemaakt en wordt onderhouden door [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), de auteur van `protobuf-net`.

Het maakt gebruik van tools van [grpc](https://github.com/grpc/), maar is niet officieel geassocieerd met, verbonden aan of goedgekeurd door dat project.

Ik kijk uit naar je feedback, en als dit je veel tijd zou kunnen besparen, ben je altijd welkom om [![Koop een koffie voor me](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---