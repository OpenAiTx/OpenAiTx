# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Estado de la compilación](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` agrega soporte code-first para servicios sobre gRPC usando tanto la API nativa `Grpc.Core`, como la API completamente administrada `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Debería funcionar en todos los lenguajes .NET que puedan generar algo *aunque sea remotamente parecido* a un modelo de tipo .NET regular.

- [Comenzando](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Toda la documentación](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Compilación/uso disponible vía `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

El uso es tan simple como declarar una interfaz para tu contrato de servicio:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

luego implementar esa interfaz para un servidor:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

o pedirle al sistema un cliente:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Esto sería equivalente al servicio en .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Obviamente necesitas indicarle el URI, etc. — consulta [Comenzando](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Usualmente la configuración se basa en convenciones, pero
si lo prefieres: existen [diversas opciones de configuración](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Cómo obtenerlo

Todo está disponible como paquetes precompilados en nuget; en particular, probablemente quieras uno de estos:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) para servidores que usen ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) para clientes o servidores que usen la API nativa/no administrada
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) y [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) para clientes que usen `HttpClient` en .NET Core 3.1

[Ejemplos de uso están disponibles en C#, VB y F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## ¿Algo más?

`protobuf-net.Grpc` es creado y mantenido por [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), el autor de `protobuf-net`.

Hace uso de herramientas de [grpc](https://github.com/grpc/), pero no está oficialmente asociado, afiliado ni respaldado por ese proyecto.

Espero tus comentarios, y si esto puede ahorrarte mucho tiempo, siempre eres bienvenido a [![Invítame un café](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---