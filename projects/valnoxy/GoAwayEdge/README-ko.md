<div align="center">

  <!-- PROJECT LOGO -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="GoAwayEdge 배너">
    </a>
  <br />

  [![버전][version-shield]][version-url]
  [![다운로드 횟수][downloads-shield]][downloads-url]
  [![라이선스][license-shield]][license-url]
  [![Weblate][weblate-shield]][weblate-url]
</div>

[version-shield]: https://img.shields.io/github/v/release/valnoxy/GoAwayEdge?color=9565F6
[version-url]: https://github.com/valnoxy/GoAwayEdge/releases

[weblate-shield]: http://translate.valnoxy.dev/widget/goawayedge/svg-badge.svg
[weblate-url]: https://translate.valnoxy.dev/engage/goawayedge/

[downloads-shield]: https://img.shields.io/github/downloads/valnoxy/GoAwayEdge/total.svg?color=431D93
[downloads-url]: https://github.com/valnoxy/GoAwayEdge/releases

[license-shield]: https://img.shields.io/github/license/valnoxy/GoAwayEdge?color=9565F6
[license-url]: https://img.shields.io/github/license/valnoxy/GoAwayEdge

<div align="center">
  <h3 align="center">GoAwayEdge</h3>
  <p align="center">
    <p>Microsoft Edge가 마음에 들지 않나요? 저도 그렇습니다. 모든 Edge 호출을 좋아하는 브라우저로 리디렉션하세요!</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">지금 다운로드</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">버그 신고</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">토론</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">번역 도움</a>
    <br />
    <br />
    🎉 버전 2.0.1이 출시되었습니다. 릴리즈 노트를 확인하세요
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">여기</a>.
    <br />
    <br />
  </p>
</div>

---

> [!NOTE]
> 이 애플리케이션은 시스템을 변경합니다. 이 애플리케이션을 사용하면서 발생한 손상에 대해서는 책임지지 않습니다.

# 🚀소개
GoAwayEdge는 저처럼 Microsoft Edge나 Windows Copilot을 좋아하지 않는 분들을 위해 설계되었습니다. 갑자기 Edge가 튀어나와서 짜증이 나신다면 걱정 마세요! 이 똑똑한 유틸리티는 모든 Edge 관련 호출을 선호하는 브라우저로 리디렉션하여 원활한 브라우징 경험을 보장합니다.

GoAwayEdge에 대한 주요 내용은 다음과 같습니다:

- 목적: GoAwayEdge의 주요 목적은 원래 Microsoft Edge를 실행하도록 하는 모든 요청이나 동작을 가로채서 선호하는 브라우저로 우회시키는 것입니다.
- 작동 방식: GoAwayEdge는 Image File Execution Options를 통해 Edge 프로세스 실행을 차단합니다. 그런 다음 인수를 읽고 파싱하여 기본 브라우저로 리디렉션합니다.
- 호환성: Windows 10 / 11 시스템에서 작동하며 Edge를 완전히 피하고 싶은 분들을 위한 간단한 솔루션을 제공합니다.

코드를 자유롭게 탐색하고, 기여하거나, 예기치 않은 Edge 만남 없이 브라우저를 즐기세요! 🚀

# 🤸 설치 방법
## 💿 1. 기본 설치
1. [GitHub](https://github.com/valnoxy/GoAwayEdge/releases)에서 최신 버전을 다운로드하세요.
2. 애플리케이션을 시작하세요.
3. 라이선스를 수락하세요.
4. GoAwayEdge를 원하는 대로 설정하세요.
5. 완료!

## 📦 2. 패키지 관리자
| 패키지 관리자           | 명령어                                   |
| ------------------------ | ------------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br/>`--custom` 옵션으로 GoAwayEdge를 사전 설정할 수도 있습니다: `winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. 무음 설치
다음 인수를 파싱하여 GoAwayEdge를 무음 설치할 수 있습니다:

| 스위치                   | 설명                                                                                                                    |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | 무음 설치                                                                                                                       |
| `-e:<Engine>`            | 검색 엔진 지정: `Google` (기본값), `Bing`, `DuckDuckGo`, `Yahoo`, `Yandex`, `Ecosia`, `Ask`, `Qwant`, `Perplexity`                |
| `-a:<AI Service>`        | AI 서비스 지정: `Default`, `Copilot`, `ChatGPT`, `Gemini`, `GitHub_Copilot`, `Grok`                                              |
| `-w:<Weather Service>`   | 날씨 서비스 지정: `Default`, `WeatherCom`, `AccuWeather`                                                                        |
| `--search-url:<Url>`     | 사용자 정의 검색 쿼리 URL (예: `https://google.com/search?q=`)                                                                   |
| `--ai-url:<Url>`         | 사용자 정의 AI 웹사이트 (예: `https://chatgpt.com`)                                                                             |
| `--weather-url:<Url>`    | 사용자 정의 날씨 쿼리 URL (예: `https://my-weather.com/{country-code}/{latitude},{longitude}`)                                   |

<b>예제</b>:

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ GoAwayEdge 제거하기
GoAwayEdge는 다른 애플리케이션과 마찬가지로 제거할 수 있습니다. 또는 다음 방법을 사용할 수도 있습니다: 
1. [GitHub](https://github.com/valnoxy/GoAwayEdge/releases)에서 최신 버전을 다운로드합니다.
2. 애플리케이션을 시작합니다.
3. ```Uninstall```을 클릭합니다.
4. 완료!

다음 인수를 사용하여 GoAwayEdge를 조용히 제거할 수도 있습니다:
```bat
GoAwayEdge.exe -u
```

# 🖼️ 스크린샷
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="GoAwayEdge 설정" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="코파일럿 대체" width=300>

# 🙏 라이브러리
이 프로젝트는 다음 라이브러리를 사용합니다:
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 라이선스
GoAwayEdge는 [MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE) 라이선스로 배포됩니다. 따라서 자유롭게 사용 및 수정할 수 있습니다. 어떠한 결과에 대해서도 책임지지 않습니다. 모든 조치는 본인 책임 하에 진행하십시오.

<hr>
<h6 align="center">© 2018 - 2026 valnoxy. 판권 소유. 
<br>
By Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=License&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---