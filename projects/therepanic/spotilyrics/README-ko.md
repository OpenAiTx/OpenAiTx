<div align="center">
  <br/>
  <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/logo.png" width="350" alt="Spotilyrics logo"/>
  <p><i>코딩하는 동안 VS Code 내에서 동기화된 Spotify 가사를 확인하세요.</i></p>
<p>
  <a href="https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics"><img src="https://img.shields.io/badge/VS%20Code-Extension-blue?style=flat&logo=visualstudiocode" /></a>
  <a href="https://developer.spotify.com/documentation/web-api"><img src="https://img.shields.io/badge/Spotify-API-1DB954?style=flat&logo=spotify" /></a>
  <a href="https://lrclib.net"><img src="https://img.shields.io/badge/Lyrics-LRClib-orange?style=flat" /></a>
  <a href="https://news.ycombinator.com/item?id=45087905"><img src="https://img.shields.io/badge/Hacker%20News-Discuss-orange?style=flat&logo=ycombinator" /></a>
  <a href="https://unlicense.org/"><img src="https://img.shields.io/badge/License-Unlicensed-red?style=flat" /></a>
</p>
</div>

---

## ✨ 기능

- 📌 **라이브 가사 동기화** Spotify 재생과 함께.
- 🎨 앨범 커버에서 자동 테마 적용된 가사 색상 (`colorthief` 사용).
- 🖥️ 부드러운 **사이드 패널 뷰** – 왼쪽에 코드, 오른쪽에 가사.
- 📱 **모바일 모드** – 재생 전 검은색 줄, 재생된 흰색 줄 (Spotify 모바일 앱과 유사).
- 🔑 간단한 **일회성 로그인** 본인 Spotify 클라이언트 ID로.
- 🚪 세션 초기화를 위한 빠른 로그아웃 명령.
- ⚡ 가사 동기화를 위한 **최대 트랙 캐시 크기** 설정.

---

## 📸 데모

## <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/demo.png"/>

## ⚡️ 설치

1. **VS Code** 열기 → 확장 → `spotilyrics` 검색 또는 [VS Code 마켓플레이스에서 설치](https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics).

2. 명령어 실행:

```
Show Spotify Lyrics via Spotilyrics
```

---

## 🔑 인증 (한 번 설정)

1. [Spotify 개발자 대시보드](https://developer.spotify.com/dashboard)로 이동합니다.
2. 앱을 생성 → **Client ID** 복사.
3. **중요:** 앱의 **Redirect URI**를 `http://127.0.0.1:8000/callback`으로 설정하세요.
4. `Show Spotify Lyrics via Spotilyrics` 명령어를 실행합니다.
5. 패널에 **Client ID**를 붙여넣고 로그인합니다.
6. 코딩하면서 동기화된 가사를 즐기세요! 🎶

> ℹ️ 이유? – Spotify API 호출 제한을 준수하려면 자신의 ID가 필요합니다.

---

## ⌨️ 명령어

- `Show Spotify Lyrics via Spotilyrics` (`spotilyrics.lyrics`) – 동기화된 가사 패널 열기.
- `Toggle Mobile Mode` (`spotilyrics.toggleMobileMode`) – 일반 모드와 모바일 모드 전환.
- `Logout from Spotilyrics` (`spotilyrics.logout`) – 세션 삭제 및 재인증 필요 시.
- `Set Tracks Cache Max Size` (`spotilyrics.setTracksCacheMaxSize`) – 가사 캐시할 최대 트랙 수 설정.

---

## ⚙️ 기술 스택

- [Spotify Web API](https://developer.spotify.com/documentation/web-api/)
- 타이밍 있는 가사를 위한 [LRClib](https://lrclib.net/)
- 커버 기반 테마를 위한 [colorthief](https://lokeshdhakar.com/projects/color-thief/)
- TypeScript + VS Code WebView

---

## 📜 라이선스

이 프로젝트는 **Unlicensed** 라이선스입니다.  
자유롭게 사용, 수정, 리믹스 가능 – 단, 보증 없음 😉

---

<div align="center">
<sub>therepanic이 ❤️를 담아 제작했습니다. 코딩은 열심히, 분위기는 더 열심히 🎧</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---