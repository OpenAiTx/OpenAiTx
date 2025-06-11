<h1 align="center">ModernZ - mpv용 세련된 대체 OSC</h1>

세련되고 현대적인 [mpv](https://mpv.io/)용 OSC로, 이 프로젝트는 ModernX를 포크하여 기능을 확장하면서도 mpv의 OSC 기본 표준을 유지하도록 설계되었습니다.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>설치 »</strong></a>
  <br>
  <a href="#configuration">설정</a>
  ·
  <a href="#controls">컨트롤</a>
  ·
  <a href="#interactive-menus">인터랙티브 메뉴</a>
  ·
  <a href="#translations">OSC 언어</a>
  ·
  <a href="#extras">추가 스크립트</a>
</p>

## 주요 기능

- 🎨 현대적이고 사용자 정의 가능한 인터페이스 [[옵션](#configuration)]
- 📷 줌 컨트롤이 있는 이미지 뷰어 모드 [[상세](/docs/IMAGE_VIEWER.md)]
- 🎛️ 버튼: 다운로드, 재생목록, 속도 조절, 스크린샷, 고정, 반복, 캐시 등 [[상세](/docs/CONTROLS.md)]
- 📄 재생목록, 자막, 챕터, 오디오 트랙 및 오디오 장치용 인터랙티브 메뉴 [[상세](#interactive-menus)]
- 🌐 JSON [locale](#translations) 통합으로 다국어 지원
- ⌨️ 구성 가능한 컨트롤 [[상세](#controls)]
- 🖼️ [thumbfast](https://github.com/po5/thumbfast)를 이용한 비디오 썸네일 미리보기

## 사용자 정의

`modernz.conf`에서 `icon_theme` 옵션을 사용하여 아이콘 테마를 `fluent` 또는 `material`로 변경해 취향과 스타일에 맞출 수 있습니다.

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

하얀 버튼과 텍스트가 마음에 들지 않나요? 색상과 버튼 배치를 완전히 제어하여 당신만의 스타일에 완벽하게 맞출 수 있습니다.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

색상과 버튼 사용자 정의 방법은 구성 가이드의 [Color Customization](docs/USER_OPTS.md#colors-and-style) 섹션을 참조하세요.

## 인터랙티브 메뉴

ModernZ는 mpv의 내장 콘솔/선택 기능([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0))을 지원하며, 재생목록, 자막, 챕터 탐색 등에서 활용할 수 있습니다.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](/docs/INTERACTIVE_MENUS.md)

## 설치

1. **기본 OSC 비활성화**

   - `mpv.conf`에 `osc=no` 추가

2. **파일 복사**

   - `modernz.lua`를 mpv 스크립트 디렉토리에 넣기
   - `fluent-system-icons.ttf` 및 `material-design-icons.ttf`를 mpv 폰트 디렉토리에 넣기
   - (선택 사항) `thumbfast.lua`를 mpv 스크립트 디렉토리에 넣기

3. **위치**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **폴더 구조** [[mpv 매뉴얼](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (선택 사항)
   ```

## 설정

1. `/script-opts` 폴더에 `modernz.conf` 생성 후 설정 커스터마이징

   - 기본 modernz.conf 다운로드: [./modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. 간단한 설정 예시:

   ```EditorConfig
   # 시크바 색상 (16진수 형식)
   seekbarfg_color=#B7410E

   # 인터페이스 옵션
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

전체 옵션 목록은 [여기](docs/USER_OPTS.md)에서 확인하세요.

## 컨트롤

### 버튼 상호작용

- 좌클릭: 기본 동작
- 우클릭: 보조 동작
- 중간 클릭/Shift+좌클릭: 대체 동작

> [!NOTE]
> 중간 클릭은 `Shift+좌클릭`과 동일한 기능을 하여 한 손 조작이 가능합니다.

전체 상호작용 목록은 [버튼 상호작용 가이드](docs/CONTROLS.md)를 참고하세요.

### 키 바인딩

ModernZ는 기본적으로 키 바인딩을 설정하지 않아 현재 설정과 충돌하지 않습니다. 원하면 `input.conf`에 다음과 같이 추가할 수 있습니다:

```
w   script-binding modernz/progress-toggle           # 진행 바 토글
x   script-message-to modernz osc-show               # OSC 표시
y   script-message-to modernz osc-visibility cycle   # 가시성 모드 순환
z   script-message-to modernz osc-idlescreen         # 대기 화면 토글
```

## 번역

ModernZ는 현재 영어로 제공되지만, 원하는 언어로 쉽게 전환할 수 있습니다! 방법은 다음과 같습니다:

1. **로케일 팩 다운로드:**

이 저장소에서 [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) 파일을 받으세요. 이 파일에는 다양한 언어 번역이 포함되어 있습니다.

2. **mpv에 로케일 추가:**

다운로드한 `modernz-locale.json` 파일을 mpv의 `/script-opts` 폴더에 복사하세요.

3. **언어 선택:**

선호하는 언어를 설정하는 두 가지 방법:

- **권장:** `modernz.conf` 파일 사용

  ```ini
  # modernz.conf 예시 설정
  # 언어를 간체 중국어로 설정
  language=zh
  ```

- **대안:** `modernz.lua` 스크립트 수정

  `modernz.lua` 파일을 열고 초반의 `user_opts` 섹션에서 `language` 값을 원하는 언어 코드로 변경하세요:

  ```lua
  local user_opts = {
      -- 일반
      language = "en",  -- 원하는 언어 코드로 변경
      ...
  }
  ```

**더 많은 정보가 필요하신가요?**

사용 가능한 언어 목록, 기여 가이드라인, 상세 번역 문서는 [TRANSLATIONS.md](docs/TRANSLATIONS.md)를 참고하세요.

## 추가 스크립트

제가 작성하고 관리하는 다음 스크립트들을 필요에 따라 자유롭게 사용하세요.

- [Pause-Indicator-Lite](/extras/pause-indicator-lite) - 일시정지 시 표시되는 간단한 인디케이터 스크립트

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - 특정 도메인에 대해 `ytdl-format`(yt-dlp)를 자동으로 변경하는 mpv 스크립트

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - 4:3 비디오 파일/스트림을 자동으로 16:9로 변경하는 mpv 스크립트

더 많은 유용한 스크립트는 [mpv 사용자 스크립트 위키](https://github.com/mpv-player/mpv/wiki/User-Scripts)를 확인하세요. 다양한 커뮤니티 기여 스크립트가 mpv 경험을 향상시켜줍니다.

## 히스토리

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)에서 포크
    - [cyl0/ModernX](https://github.com/cyl0/ModernX)에서 포크
    - [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)에서 포크

**왜 다시 포크했나요?**

- [Color Customization](docs/USER_OPTS.md#colors-and-style), [옵션](docs/USER_OPTS.md), [로케일 통합](docs/TRANSLATIONS.md) 등 다양한 기능 추가를 위해
- 콘솔과 선택 기능을 osc에 통합하여 mpv 기본 osc에도 적용되도록 영감을 줌. [참조 [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- 이미지 전용 레이아웃 추가 [[상세](/docs/IMAGE_VIEWER.md)]
- mpv 기본 osc 표준에 맞게 프로젝트 전면 재구성하여 호환성 확보
- 오래된 버그 및 코드 중복 제거
    - 이를 통해 다른 `Modern` 포크들이 ModernZ를 기반으로 사용할 수 있게 됨, 예: [zydezu/ModernX](https://github.com/zydezu/ModernX). [[참조](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

본질적으로 `modern-osc`의 원형을 유지하고 부활시키기 위함입니다.
그렇긴 하지만, ModernZ는 여전히 오래된 코드의 일부를 사용하며, 이전과 현재의 모든 포크 작성자 및 기여자(여기에는 mpv의 기본 osc도 포함됨)에게 공로를 인정해야 하므로 자세히 언급되어 있습니다.

#### 크레딧:

- 글꼴: UI Fluent System Icons [[상세](https://github.com/microsoft/fluentui-system-icons)] [[글꼴 파일](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- ModernZ osc에서 사용하기 위해 [Xurdejl](https://github.com/Xurdejl)이 수정한 글꼴
- [mpv](https://github.com/mpv-player/mpv) 및 그들의 [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua), ModernZ osc는 기본 osc 표준을 기반으로 다시 작성되었으며 그로부터 업데이트를 적용함
- [히스토리](#history)에서 언급된 모든 현대 osc 원본 및 그들의 포크
- ModernZ osc에 직접적 또는 간접적으로 도움을 준 모든 [기여자](https://github.com/Samillion/ModernZ/graphs/contributors), 테스터 및 사용자 여러분 ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---