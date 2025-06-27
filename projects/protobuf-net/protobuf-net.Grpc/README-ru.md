# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` добавляет поддержку сервисов по gRPC в стиле code-first, используя либо нативный API `Grpc.Core`, либо полностью управляемый API `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Должно работать во всех языках .NET, которые могут сгенерировать *хотя бы отдалённо похожую* на обычную модель типа .NET.

- [Начало работы](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Вся документация](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Сборка/использование доступно через `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Использование настолько просто, как объявление интерфейса для вашего сервисного контракта:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

затем либо реализовать этот интерфейс на сервере:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

либо запросить у системы клиента:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Это будет эквивалентно сервису в .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Очевидно, необходимо указать uri и другие параметры — смотрите [Начало работы](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Обычно конфигурация основана на соглашениях, но
если вам удобнее — доступны [различные варианты конфигурации](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Как получить

Всё доступно как готовые пакеты на nuget; в частности, скорее всего вам потребуется один из следующих:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) для серверов на ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) для клиентов или серверов, использующих нативный/неуправляемый API
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) и [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) для клиентов на `HttpClient` в .NET Core 3.1

[Примеры использования доступны на C#, VB и F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Что-нибудь ещё?

`protobuf-net.Grpc` создан и поддерживается [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), автором `protobuf-net`.

Использует инструменты из [grpc](https://github.com/grpc/), но официально не связан, не аффилирован и не одобрен этим проектом.

Буду рад вашим отзывам, и если это может сэкономить вам кучу времени, вы всегда можете [![Купить мне кофе](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---