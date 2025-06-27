# ASP.NET SignalR 

**중요**: 이 제품에는 새로운 기능이 추가되지 않습니다. 현재는 유지보수 모드이며, 치명적인 이슈만 수정하고 있습니다. 자세한 내용은 [블로그 포스트](https://devblogs.microsoft.com/aspnet/the-future-of-asp-net-signalr/)를 참고하세요.
이 리포지토리는 System.Web 또는 Katana를 사용하는 .NET Framework 애플리케이션용 ASP.NET SignalR의 코드와 프로젝트 관리를 호스팅합니다. ASP.NET Core SignalR에 대한 정보를 찾으신다면, https://github.com/aspnet/AspNetCore/tree/main/src/SignalR 리포지토리를 참고하세요.

ASP.NET SignalR은 ASP.NET 개발자가 애플리케이션에 실시간 웹 기능을 매우 쉽게 추가할 수 있도록 해주는 라이브러리입니다. "실시간 웹" 기능이란 무엇일까요? 서버 측 코드가 연결된 클라이언트로 컨텐츠를 발생 즉시, 실시간으로 푸시할 수 있는 기능입니다.

## 어떤 용도로 사용할 수 있나요?
서버에서 클라이언트(브라우저 클라이언트뿐만 아니라)로 데이터를 푸시하는 것은 항상 어려운 문제였습니다. SignalR은 이를 매우 쉽게 만들어주며, 모든 복잡한 작업을 대신 처리해줍니다.

## 문서
[문서](https://docs.microsoft.com/aspnet/signalr/overview/getting-started/introduction-to-signalr)를 참고하세요.

## NuGet에서 받아보세요!

    Install-Package Microsoft.AspNet.SignalR

## 샘플을 NuGet으로 바로 앱에 추가해보세요!

    Install-Package Microsoft.AspNet.SignalR.Sample
	
## 라이선스
[Apache 2.0 라이선스](https://raw.githubusercontent.com/SignalR/SignalR/main/LICENSE.txt)

## 기여하기

[기여 가이드라인](https://raw.githubusercontent.com/SignalR/SignalR/main/CONTRIBUTING.md)을 참고하세요.

## 소스 빌드하기

```
git clone git@github.com:SignalR/SignalR.git (https를 사용하는 경우 https로)
```

### Windows
리포지토리를 클론한 후, `build.cmd`를 실행하세요.

**참고:** 솔루션을 열기 위해서는 VS 2017이 필요합니다.

## 질문이 있으신가요?
* [signalr](https://stackoverflow.com/questions/tagged/signalr) 태그로 StackOverflow에 질문하세요.
* [이슈 트래커](https://github.com/SignalR/SignalR/issues)에 이슈를 등록하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---