# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc`는 네이티브 `Grpc.Core` API 또는 완전 관리형 `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API를 사용하여 gRPC를 통한 서비스에 코드 우선 지원을 추가합니다.

일반적인 .NET 타입 모델과 *약간이라도 비슷한* 무언가를 생성할 수 있는 모든 .NET 언어에서 동작해야 합니다.

- [시작하기](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [전체 문서](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [`protobuf-net.BuildTools`를 통한 빌드/사용법](https://protobuf-net.github.io/protobuf-net/build_tools)

사용법은 서비스 계약에 대한 인터페이스를 선언하는 것만큼 간단합니다:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

그런 다음 서버용으로 해당 인터페이스를 구현하거나:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

시스템에 클라이언트를 요청할 수도 있습니다:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

이는 .proto에서의 서비스와 동일합니다:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

당연히 uri 등을 지정해야 합니다 - 자세한 내용은 [시작하기](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)를 참조하세요. 일반적으로 구성은 규약 기반이지만,
원한다면 [다양한 구성 옵션](https://protobuf-net.github.io/protobuf-net.Grpc/configuration)이 있습니다.

## 입수 방법

모든 것은 nuget에서 미리 빌드된 패키지로 제공됩니다. 특히 다음 중 하나가 필요할 것입니다:

- ASP.NET Core 3.1을 사용하는 서버용 [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore)
- 네이티브/비관리 API를 사용하는 클라이언트 또는 서버용 [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native)
- .NET Core 3.1에서 `HttpClient`를 사용하는 클라이언트용 [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) 및 [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/)

[C#, VB, F#의 사용 예제](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)도 제공됩니다.

## 기타

`protobuf-net.Grpc`는 `protobuf-net`의 저자 [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell))이 만들고 유지 관리하고 있습니다.

이 프로젝트는 [grpc](https://github.com/grpc/)의 도구를 사용하지만, 해당 프로젝트와 공식적으로 연관되어 있거나, 제휴되어 있거나, 승인받은 것은 아닙니다.

여러분의 피드백을 기대합니다. 만약 이 프로젝트가 여러분의 시간을 크게 절약해준다면, 언제든지 [![Buy me a coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell) 커피 한 잔을 환영합니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---