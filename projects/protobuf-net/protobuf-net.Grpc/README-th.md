# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` เพิ่มการรองรับแบบ code-first สำหรับบริการผ่าน gRPC โดยใช้ทั้ง `Grpc.Core` API แบบ native หรือ `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API ที่เป็น fully-managed

สามารถทำงานได้กับภาษา .NET ทุกภาษา ที่สามารถสร้าง type model ของ .NET ได้ *แม้จะคล้ายคลึงเพียงเล็กน้อยก็ตาม*

- [เริ่มต้นใช้งาน](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [เอกสารทั้งหมด](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [การ build/ใช้งานผ่าน `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

การใช้งานง่ายเพียงแค่ประกาศ interface สำหรับ service-contract ของคุณ:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

จากนั้นสามารถ implement interface นี้สำหรับ server ได้:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

หรือขอ client จากระบบ:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

ซึ่งจะเทียบเท่ากับบริการใน .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

แน่นอนว่าคุณต้องระบุ uri เป็นต้น - ดูได้ที่ [เริ่มต้นใช้งาน](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted) โดยปกติการตั้งค่าจะใช้ตาม convention แต่
หากคุณต้องการ: มี [ตัวเลือกการตั้งค่าหลากหลาย](https://protobuf-net.github.io/protobuf-net.Grpc/configuration)

## การติดตั้ง

ทุกอย่างมีให้ในรูปแบบแพ็คเกจสำเร็จรูปบน nuget; โดยเฉพาะ คุณอาจต้องการตัวใดตัวหนึ่งต่อไปนี้:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) สำหรับเซิร์ฟเวอร์ที่ใช้ ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) สำหรับ client หรือ server ที่ใช้ native/unmanaged API
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) และ [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) สำหรับ client ที่ใช้ `HttpClient` บน .NET Core 3.1

[ตัวอย่างการใช้งานมีให้ในภาษา C#, VB และ F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)

## มีอะไรอีกไหม?

`protobuf-net.Grpc` ถูกสร้างและดูแลโดย [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)) ผู้เขียน `protobuf-net`

มีการใช้เครื่องมือจาก [grpc](https://github.com/grpc/), แต่ไม่ได้เป็นโครงการอย่างเป็นทางการ, ไม่ได้มีความเกี่ยวข้องหรือได้รับการรับรองโดยโครงการนั้น

ผมรอคอยความคิดเห็นจากคุณ และหากสิ่งนี้ช่วยประหยัดเวลาให้คุณได้มาก คุณยินดีที่จะ [![Buy me a coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---