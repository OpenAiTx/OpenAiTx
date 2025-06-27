# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` bổ sung hỗ trợ code-first cho các dịch vụ trên gRPC sử dụng API gốc `Grpc.Core`, hoặc API hoàn toàn managed `Grpc.Net.Client` / `Grpc.AspNetCore.Server`.

Nó có thể hoạt động trên tất cả các ngôn ngữ .NET có thể sinh ra thứ gì đó *tương tự* như một mô hình kiểu .NET thông thường.

- [Bắt đầu sử dụng](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [Tất cả tài liệu](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [Build/sử dụng qua `protobuf-net.BuildTools`](https://protobuf-net.github.io/protobuf-net/build_tools)

Cách sử dụng đơn giản như khai báo một interface cho hợp đồng dịch vụ của bạn:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

sau đó hoặc hiện thực interface đó cho server:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

hoặc yêu cầu hệ thống tạo client:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

Điều này tương đương với dịch vụ trong .proto:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

Rõ ràng bạn cần chỉ định uri, v.v. - xem [Bắt đầu sử dụng](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted). Thông thường cấu hình sẽ dựa trên quy ước, nhưng
nếu bạn muốn: có [nhiều tùy chọn cấu hình](https://protobuf-net.github.io/protobuf-net.Grpc/configuration).

## Làm thế nào để lấy nó

Tất cả đều có sẵn dưới dạng các gói pre-built trên nuget; cụ thể, bạn có thể sẽ muốn một trong số:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) cho server sử dụng ASP.NET Core 3.1
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) cho client hoặc server sử dụng API gốc/unmanaged
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) và [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) cho client sử dụng `HttpClient` trên .NET Core 3.1

[Ví dụ sử dụng có sẵn bằng C#, VB và F#](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc).

## Còn gì nữa không?

`protobuf-net.Grpc` được tạo và duy trì bởi [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)), tác giả của `protobuf-net`.

Nó sử dụng các công cụ từ [grpc](https://github.com/grpc/), nhưng không chính thức liên kết, liên quan hay được xác nhận bởi dự án đó.

Tôi rất mong nhận được phản hồi của bạn, và nếu công cụ này giúp bạn tiết kiệm được rất nhiều thời gian, bạn luôn được chào đón [![Mua cho tôi một ly cà phê](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---