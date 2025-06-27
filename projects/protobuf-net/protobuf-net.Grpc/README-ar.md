# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="شعار protobuf-net" width="45" height="45"> protobuf-net.Grpc

[![حالة البناء](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` يضيف دعم تصميم الكود أولاً للخدمات عبر gRPC باستخدام إما واجهة برمجة التطبيقات الأصلية `Grpc.Core`، أو واجهة برمجة التطبيقات المدارة بالكامل `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

ينبغي أن يعمل على جميع لغات .NET التي يمكنها توليد شيء *حتى وإن كان شبيهاً* بنموذج نوع .NET عادي.

- [البدء السريع](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [كل الوثائق](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [البناء/الاستخدام متوفر عبر `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

الاستخدام ببساطة يكون عبر إعلان واجهة لعقد الخدمة الخاصة بك:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

ثم إما تنفيذ تلك الواجهة للخادم:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

أو الطلب من النظام إنشاء عميل:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

هذا سيكون مكافئاً للخدمة في ملف .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

من الواضح أنك بحاجة لإعلامه بعنوان uri وما إلى ذلك - راجع [البدء السريع](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). عادةً ما يكون التكوين قائماً على القواعد، ولكن
إذا كنت تفضل: هناك [خيارات تكوين متعددة](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## كيفية الحصول عليه

كل شيء متوفر كحزم جاهزة البناء على nuget؛ على وجه الخصوص، ربما ترغب في أحد الخيارات التالية:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) للخوادم التي تستخدم ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) للعملاء أو الخوادم التي تستخدم الواجهة البرمجية الأصلية/غير المدارة
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) و [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) للعملاء الذين يستخدمون `HttpClient` على .NET Core 3.1

[أمثلة الاستخدام متوفرة بـ C# وVB وF#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## أي شيء آخر؟

`protobuf-net.Grpc` تم إنشاؤه وصيانته بواسطة [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell))، مؤلف `protobuf-net`.

يستخدم أدوات من [grpc](https://github.com/grpc/)، لكنه ليس مرتبطاً رسمياً أو معتمداً أو موصى به من قبل هذا المشروع.

أتطلع إلى ملاحظاتكم، وإذا كان هذا بإمكانه توفير الكثير من الوقت لكم، فأنتم دائماً مرحب بكم [![اشترِ لي قهوة](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---