# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Stato build](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` aggiunge il supporto code-first per i servizi tramite gRPC utilizzando sia l’API nativa `Grpc.Core`, sia l’API completamente gestita `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Dovrebbe funzionare con tutti i linguaggi .NET che possono generare qualcosa *anche solo lontanamente simile* a un normale modello di tipo .NET.

- [Guida introduttiva](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Tutta la documentazione](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/uso disponibile tramite `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

L’utilizzo è semplice come dichiarare un’interfaccia per il tuo contratto di servizio:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

poi implementando quell’interfaccia per un server:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

oppure chiedendo al sistema un client:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Questo sarebbe equivalente al servizio in .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Ovviamente devi specificare l’uri ecc. - vedi [Guida introduttiva](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Di solito la configurazione si basa sulle convenzioni, ma
se preferisci: ci sono [varie opzioni di configurazione](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Come ottenerlo

Tutto è disponibile come pacchetti precompilati su nuget; in particolare, probabilmente vorrai uno dei seguenti:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) per server che usano ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) per client o server che usano l’API nativa/non gestita
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) e [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) per client che usano `HttpClient` su .NET Core 3.1

[Esempi d’uso sono disponibili in C#, VB e F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Qualcos’altro?

`protobuf-net.Grpc` è creato e mantenuto da [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), l’autore di `protobuf-net`.

Fa uso di strumenti da [grpc](https://github.com/grpc/), ma non è ufficialmente associato, affiliato o approvato da quel progetto.

Attendo con interesse il tuo feedback, e se questo ti facesse risparmiare un sacco di tempo, sei sempre il benvenuto a [![Offrimi un caffè](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---