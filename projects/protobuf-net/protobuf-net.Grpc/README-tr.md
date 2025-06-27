# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc`, ister yerel `Grpc.Core` API'sini, ister tamamen yönetilen `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API'sini kullanarak gRPC üzerinden hizmetler için kod-öncelikli destek ekler.

*Düzenli bir .NET tür modeli* gibi bir şey üretebilen tüm .NET dilleriyle çalışmalıdır.

- [Başlarken](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Tüm Dokümantasyon](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Yapı/kullanım `protobuf-net.BuildTools` ile erişilebilir](https://protobuf-net.github.io/protobuf-net/build_tools)

Kullanımı, hizmet sözleşmeniz için bir arayüz tanımlamak kadar basittir:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

sonra ya bu arayüzü bir sunucu için uygularsınız:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

ya da istemci için sistemden bir örnek istersiniz:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Bu, .proto'daki servise eşdeğer olurdu:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Elbette, ona uri vb. bilgileri vermeniz gerekir - bkz. [Başlarken](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Genellikle yapılandırma geleneklere dayalıdır, ancak
isterseniz: [çeşitli yapılandırma seçenekleri](https://protobuf-net.github.io/protobuf-net.Grpc/configuration) mevcuttur.

## Nasıl edinebilirim?

Her şey nuget'te hazır paketler olarak mevcuttur; özellikle, muhtemelen aşağıdakilerden birini isteyeceksiniz:

- ASP.NET Core 3.1 kullanan sunucular için [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore)
- Yerel/yönetilmeyen API kullanan istemci veya sunucular için [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native)
- .NET Core 3.1 üzerinde `HttpClient` kullanan istemciler için [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) ve [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/)

[Kullanım örnekleri C#, VB ve F# dillerinde mevcuttur](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Başka bir şey var mı?

`protobuf-net.Grpc`, `protobuf-net` yazarı [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)) tarafından oluşturulmuş ve bakımına devam edilmektedir.

[grpc](https://github.com/grpc/) projesinden araçlar kullanır, ancak bu proje ile resmî olarak ilişkili, bağlantılı veya onaylı değildir.

Geri bildiriminizi bekliyorum ve eğer bu size çok zaman kazandıracaksa, her zaman [![Bana bir kahve ısmarla](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell) ile destek olabilirsiniz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---