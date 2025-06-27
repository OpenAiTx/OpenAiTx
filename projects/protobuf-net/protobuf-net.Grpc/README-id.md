# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` menambahkan dukungan code-first untuk layanan melalui gRPC menggunakan baik API native `Grpc.Core`, atau API sepenuhnya managed `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Ini seharusnya dapat berjalan di semua bahasa .NET yang dapat menghasilkan sesuatu *yang bahkan sedikit pun mirip* dengan model tipe .NET reguler.

- [Memulai](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Semua Dokumentasi](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/penggunaan tersedia melalui `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Penggunaannya semudah mendeklarasikan sebuah antarmuka untuk kontrak layanan Anda:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

kemudian baik mengimplementasikan antarmuka tersebut untuk server:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

atau meminta sistem untuk membuat klien:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Ini akan setara dengan layanan di .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Tentu saja Anda perlu memberitahu URI dan sebagainya - lihat [Memulai](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Biasanya konfigurasi berbasis konvensi, tetapi
jika Anda lebih suka: ada [berbagai opsi konfigurasi](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Cara Mendapatkannya

Semuanya tersedia sebagai paket pre-built di nuget; khususnya, Anda mungkin ingin salah satu dari:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) untuk server yang menggunakan ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) untuk klien atau server yang menggunakan API native/unmanaged
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) dan [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) untuk klien yang menggunakan `HttpClient` pada .NET Core 3.1

[Contoh penggunaan tersedia dalam C#, VB, dan F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Ada lagi?

`protobuf-net.Grpc` dibuat dan dipelihara oleh [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), penulis `protobuf-net`.

Ini menggunakan alat dari [grpc](https://github.com/grpc/), tetapi tidak secara resmi diasosiasikan dengan, berafiliasi dengan, atau didukung oleh proyek tersebut.

Saya menantikan masukan Anda, dan jika ini dapat menghemat banyak waktu Anda, Anda selalu dipersilakan untuk [![Buy me a coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---