# Muzika

> [!CAUTION]
> Muzika는 현재 유지 관리되지 않으며, 향후 아카이브될 예정입니다. 자세한 내용은 https://github.com/vixalien/muzika/issues/220 을 참조하세요.

Muzika는 우아한 음악 스트리밍 앱입니다.

![Muzika 홈 페이지](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/home.png)

![Muzika가 "My Queen is Angela Davis"를 재생 중](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/playing.png)

> 참고: 이것은 진행 중인 작업입니다. 앱은 아직 프로덕션 준비가 되지 않았습니다.

## 기능

- 개인화된 홈 화면
- 노래, 앨범, 아티스트, 라디오 및 재생목록 검색
- Google로 로그인하고 라이브러리에서 재생목록 등 액세스
- 개인화된 라디오 및 믹스 재생
- 노래 가사 및 관련 정보 보기
- 아티스트, 앨범 및 재생목록 등 탐색

## 설치

### 최신 Nightly Flatpak 사용

[최신 Nightly flatpak](https://vixalien.github.io/muzika/muzika.flatpakref)을 다운로드할 수 있습니다.

### 소스에서 설치

필수 조건:

- GNOME Builder

1. 저장소를 클론하세요

```bash
git clone https://github.com/vixalien/muzika.git --recurse-submodules
```
2. GNOME Builder에서 프로젝트를 열고 "Build"를 사용하여 프로젝트를 빌드합니다.

> 참고: Muzika는 최신(출시되지 않은) libadwaita 컴포넌트를 사용하므로 Meson과 Ninja를 직접 사용하는 것은 더 이상 지원되지 않습니다.

## 탐색

Muzika는 muzika URI를 사용하여 다양한 페이지를 탐색할 수 있는 강력한 내비게이터를 제공합니다. 일부는 아래에 문서화되어 있습니다.

muzika URI는 `muzika:endpoint:data` 형식을 가집니다. URI에는 쿼리 매개변수도 포함될 수 있습니다. 예를 들어, `muzika:library?view=grid`는 그리드 뷰로 라이브러리 페이지를 엽니다.

검색창에 muzika URI를 직접 입력하면 검색 대신 해당 페이지로 직접 이동합니다.

또한 내비게이터 동작을 수동으로 트리거하여 특정 엔드포인트로 이동할 수 있습니다:

1. `Ctrl+Shift+I`를 눌러 GTK 인스펙터를 엽니다.
2. 오른쪽의 `Actions` 탭을 클릭합니다.
3. `navigator.visit`라는 이름의 동작을 찾고 `Parameter` 필드에 URI를 입력한 다음 `Activate`를 클릭합니다.

### 엔드포인트

모든 엔드포인트 목록은 [여기](https://raw.githubusercontent.com/vixalien/muzika/main/src/pages.ts)에 있습니다.

- `muzika:home` - 홈 페이지
- `muzika:playlist:<playlistId>` - 플레이리스트 페이지. 예:
  `muzika:playlist:PL4fGSI1pDJn6puJdseH2Rt9sMvt9E2M4i`/
- `muzika:album:<albumId>` - 앨범 페이지.
- `muzika:artist:<channelId>` - 아티스트 또는 채널 페이지.
- `search:<query>` - 검색. 쿼리는 URL 인코딩되어야 합니다. 예:
  `search:hello%20world`는 `hello world`를 검색합니다.
- `muzika:library` - 라이브러리.

Muzika가 더 많은 기능을 지원함에 따라 더 많은 엔드포인트가 추가될 예정입니다.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---