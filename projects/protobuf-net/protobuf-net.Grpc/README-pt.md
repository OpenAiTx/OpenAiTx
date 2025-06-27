# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` adiciona suporte code-first para serviços via gRPC utilizando tanto a API nativa `Grpc.Core`, quanto a API totalmente gerenciada `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Deve funcionar em todas as linguagens .NET que possam gerar algo *mesmo que remotamente parecido* com um modelo de tipo .NET regular.

- [Começando](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Toda a Documentação](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/uso disponível via `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

O uso é tão simples quanto declarar uma interface para o seu contrato de serviço:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

e então implementar essa interface para um servidor:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

ou pedir ao sistema por um cliente:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Isso seria equivalente ao serviço em .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Obviamente, você precisa informar a URI etc - veja [Começando](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Normalmente a configuração é baseada em convenção, mas
se preferir: existem [várias opções de configuração](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Como obter

Tudo está disponível como pacotes pré-compilados no nuget; em particular, você provavelmente vai querer um dos seguintes:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) para servidores usando ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) para clientes ou servidores usando a API nativa/não gerenciada
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) e [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) para clientes usando `HttpClient` no .NET Core 3.1

[Exemplos de uso estão disponíveis em C#, VB e F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Mais alguma coisa?

`protobuf-net.Grpc` é criado e mantido por [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), o autor do `protobuf-net`.

Faz uso de ferramentas do [grpc](https://github.com/grpc/), mas não é oficialmente associado, afiliado ou endossado por esse projeto.

Aguardo seu feedback e, se isso puder te poupar muito tempo, você está sempre convidado a [![Me pague um café](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---