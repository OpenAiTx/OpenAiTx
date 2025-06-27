# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Statut de la build](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` ajoute une prise en charge code-first des services sur gRPC en utilisant soit l'API native `Grpc.Core`, soit l'API entièrement managée `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Cela devrait fonctionner sur tous les langages .NET capables de générer quelque chose *même vaguement similaire* à un modèle de type .NET classique.

- [Commencer](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Toute la documentation](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/utilisation disponible via `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

L'utilisation est aussi simple que de déclarer une interface pour votre contrat de service :

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

puis soit d'implémenter cette interface pour un serveur :

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

soit de demander au système un client :

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Cela serait équivalent au service dans un .proto :

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Évidemment, vous devez lui indiquer l'URI, etc. — voir [Commencer](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Généralement, la configuration est basée sur des conventions, mais
si vous préférez : il existe [diverses options de configuration](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Pour l’obtenir

Tout est disponible sous forme de packages précompilés sur nuget ; en particulier, vous voudrez probablement l’un de ceux-ci :

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) pour les serveurs utilisant ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) pour les clients ou serveurs utilisant l’API native/non gérée
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) et [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) pour les clients utilisant `HttpClient` sur .NET Core 3.1

[Des exemples d’utilisation sont disponibles en C#, VB et F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Autre chose ?

`protobuf-net.Grpc` est créé et maintenu par [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), l’auteur de `protobuf-net`.

Il utilise des outils de [grpc](https://github.com/grpc/), mais n’est ni officiellement associé, ni affilié, ni approuvé par ce projet.

J’attends vos retours avec impatience, et si cela peut vous faire gagner un temps précieux, vous êtes toujours le bienvenu pour [![M’offrir un café](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---