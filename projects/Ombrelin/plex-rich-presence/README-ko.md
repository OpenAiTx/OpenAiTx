> [!경고]  
>  **프로젝트 상태**
> 이 프로젝트는 유지보수 전용 모드입니다. 제가 더 이상 PLEX 사용자가 아니기 때문에, 이 프로젝트에 새로운 기능을 추가하지 않을 것입니다.
> 하지만, 기여는 계속 검토하고 통합할 예정이니, 특정 기능을 개발하고 싶다면 PR을 보내주세요.

# Plex 리치 프레즌스

Plex 리치 프레즌스는 현재 PLEX 세션을 Discord 리치 프레즌스 상태에 표시할 수 있는 멀티플랫폼 .NET 6 GUI 앱입니다.

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">

버전 2.1의 새로운 기능 :

- 리치 프레즌스에 미디어 썸네일을 동적으로 표시

버전 2.0의 새로운 기능 : 

- 비관리자 사용자 지원
- 서버 선택 지원
- CLI 버전
- PLEX SSO 로그인

## 릴리스 버전

윈도우 및 리눅스용 릴리스는 [여기](https://github.com/Ombrelin/plex-rich-presence/releases/latest)에서 확인할 수 있습니다.

## 스크린샷

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)

## 소스에서 빌드 및 실행

.NET 8+ SDK 필요

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```
## 사용된 라이브러리

- AvaloniaUI
- .NET MVVM 툴킷
- Microsoft DI
- Moq
- PlexApi
- Discord RPC .NET
- FluentAssertions

## 특별 감사

로고 제작에 [@GrandKhan]께 감사드립니다.

[Discord](https://discord.com/) 및 [PLEX 미디어 서버](https://plex.tv)에 감사드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---