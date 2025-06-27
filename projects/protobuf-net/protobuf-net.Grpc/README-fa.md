# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` پشتیبانی از خدمات مبتنی بر کد را برای سرویس‌ها بر بستر gRPC با استفاده از API بومی `Grpc.Core` یا API کاملاً مدیریت‌شده `Grpc.Net.Client` / `Grpc.AspNetCore.Server` اضافه می‌کند.

این ابزار باید بر روی همه زبان‌های .NET که می‌توانند چیزی حتی کمی مشابه مدل نوع معمولی .NET تولید کنند، کار کند.

- [شروع کار](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [تمام مستندات](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [ابزار ساخت/استفاده در دسترس از طریق `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

استفاده از آن به سادگی اعلام یک اینترفیس برای قرارداد سرویس شماست:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

سپس یا آن اینترفیس را برای سرور پیاده‌سازی می‌کنید:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

یا از سیستم یک کلاینت می‌خواهید:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

این معادل سرویس در .proto خواهد بود:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

بدیهی است که باید uri و غیره را به آن بدهید - به [شروع کار](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted) مراجعه کنید. معمولاً پیکربندی مبتنی بر قرارداد است، اما
در صورت تمایل: [گزینه‌های پیکربندی مختلفی](https://protobuf-net.github.io/protobuf-net.Grpc/configuration) وجود دارد.

## نحوه تهیه

همه چیز به صورت بسته‌های از پیش ساخته شده در nuget موجود است؛ به طور خاص، احتمالاً یکی از این‌ها را می‌خواهید:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) برای سرورهایی که از ASP.NET Core 3.1 استفاده می‌کنند
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) برای کلاینت‌ها یا سرورهایی که از API بومی/مدیریت‌نشده استفاده می‌کنند
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) و [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) برای کلاینت‌هایی که از `HttpClient` روی .NET Core 3.1 استفاده می‌کنند

[نمونه‌های استفاده در C#، VB و F# در دسترس است](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## چیز دیگری هست؟

`protobuf-net.Grpc` توسط [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell))، نویسنده `protobuf-net`، ایجاد و نگهداری می‌شود.

این ابزار از ابزارهای [grpc](https://github.com/grpc/) استفاده می‌کند، اما رسماً با آن پروژه ارتباط، همکاری یا تایید نشده است.

منتظر بازخورد شما هستم و اگر این ابزار می‌تواند مقدار زیادی از وقت شما را صرفه‌جویی کند، همیشه خوشحال می‌شوم که [![برای من یک قهوه بخر](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---