<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## 이미지 예시

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## 항상 최신 안정화 버전(LSR)을 다운로드하세요! 최신/LFR가 아닙니다! 현재 LSR: 2.4.9

`pip install winup==2.4.9`

**아주 파이썬답고 강력한, 아름다운 데스크톱 애플리케이션 제작 프레임워크입니다.**

WinUp은 Python용 최신 UI 프레임워크로, PySide6 (Qt)의 강력함을 간단하고 선언적이며 개발자 친화적인 API로 감쌉니다. 더 빠르게 앱을 만들고, 코드를 더 깔끔하게 작성하며, 개발 과정을 즐길 수 있도록 설계되었습니다.

### ✨ 이제 웹 지원도 추가되었습니다!
WinUp은 이제 동일한 Python 중심, 컴포넌트 기반 접근법을 사용하여 완전히 상호작용적이고 상태를 가진 웹 애플리케이션 빌드도 지원합니다. 웹 모듈은 내부적으로 FastAPI와 WebSocket을 사용하여 WinUp의 단순함을 브라우저로 확장합니다.

[웹 문서](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **면책사항:** 웹 지원은 선택 기능입니다. 사용하려면 웹 의존성을 설치해야 합니다:
> ```bash
> pip install "winup[web]"
> ```

[기여하기](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[변경 로그](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[라이선스](LICENSE)

---

## 왜 WinUp인가? (순수 PySide6나 Tkinter 대신에)

파이썬에서 데스크톱 개발은 종종 번거롭습니다. WinUp은 이를 해결하기 위해 만들어졌습니다.

| 기능                      | WinUp 방식 ✨                                                                     | 순수 PySide6 / Tkinter 방식 😟                                                           |
| ----------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------- |
| **레이아웃**               | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`              |
| **스타일링**               | `props={"background-color": "blue", "font-size": "16px"}`                      | 직접 QSS 문자열, `widget.setStyleSheet(...)`, 복잡한 스타일 객체.                       |
| **상태 관리**              | `state.bind(widget, "prop", "key")`                                            | 수동 콜백 함수, getter/setter, `StringVar()`, 보일러플레이트 코드가 난무.                |
| **양방향 바인딩**           | `state.bind_two_way(input_widget, "key")`                                      | 없음. 수동 `on_change` 핸들러로 상태와 UI를 모두 갱신해야 함.                           |
| **개발자 도구**             | **내장 핫 리로딩**, 코드 프로파일러, 창 도구 기본 제공.                        | 없음. UI 변경마다 앱 전체를 재시작해야 함.                                                |
| **코드 구조**               | `@component`로 재사용 가능한 독립 컴포넌트.                                    | 대형 클래스 또는 절차적 스크립트로 귀결되는 경우가 많음.                                 |

**즉, WinUp은 현대 웹 프레임워크(React, Vue 등)의 "킬러 기능"을 데스크톱에 제공하여 시간을 아끼고, 중요한 애플리케이션 로직에 집중할 수 있게 해줍니다.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit 사용자 요청)

| 기능                             | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 아키텍처                      | React 스타일 + 상태            | React 스타일 + 상태             |
| 🌐 내장 라우팅                   | ✅ 예 (`Router(routes={...})`)      | ❌ 내장 라우팅 없음               |
| ♻️ 생명주기 후크                 | ✅ `on_mount`, `on_unmount` 등      | ⚠️ 제한적 (`did_mount` 등)        |
| 🎨 테마/스타일 시스템            | ✅ 전역 & 개별 테마 지원             | ❌ 수동 CSS 삽입                   |
| 🔲 레이아웃 옵션                  | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ 주로 Box & HBox/VBox           |
| 🎞️ 애니메이션                   | ✅ 내장 (fade, scale 등)             | ❌ 내장 없음                       |
| 🔁 핫 리로딩 (LHR)               | ✅ 안정적 + 빠름 (`loadup dev`)      | ⚠️ 실험적, 제한적 지원             |
| 📦 패키징                        | ✅ LoadUp(PiInstaller 기반)로 가능   | ❌ 직접 PyInstaller 통합 필요       |
| 🧩 컴포넌트 재사용성             | ✅ 높음, 선언적                      | ✅ 높음                            |

| 🛠 개발자 도구                | ✅ DevTools 계획됨, Inspector 곧 제공  | ❌ 아직 없음                         |
| 📱 모바일 지원                 | ❌ 아직 지원되지 않음                   | ❌ 지원되지 않음                    |
| 🧠 학습 곡선                   | ✅ Python+React 사용자에게 쉬움         | ✅ 쉬우나 도구가 적음               |

> ✅ = 내장 또는 강력함  
> ⚠️ = 부분적 또는 제한적  
> ❌ = 완전히 없음
---

## 핵심 기능

*   **선언적 & 파이썬 스타일 UI:** 복잡한 레이아웃을 번거로운 박스 레이아웃 대신 간단한 `Row`와 `Column` 객체로 구축하세요.
*   **컴포넌트 기반 아키텍처:** `@component` 데코레이터로 간단한 함수로부터 모듈식이며 재사용 가능한 UI 위젯을 만드세요.
*   **강력한 스타일링 시스템:** `props`를 활용한 파이썬 딕셔너리로 위젯을 스타일링하고, `style.add_style_dict`로 전역 "CSS 유사" 클래스를 만드세요.
*   **완전한 애플리케이션 셸:** `MenuBar`, `ToolBar`, `StatusBar`, `SystemTrayIcon`에 대한 선언적 API로 전문적인 애플리케이션을 만드세요.
*   **비동기 작업 실행기:** 간단한 `@tasks.run` 데코레이터로 UI가 멈추지 않고 백그라운드에서 장시간 작업을 실행하세요.
*   **기본 성능 최적화:** `@memo` 데코레이터로 컴포넌트 렌더링을 캐시하고 불필요한 재계산을 방지할 수 있습니다.
*   **고급 확장성:**
    *   **위젯 팩토리:** `ui.register_widget()`으로 기본 위젯을 직접 구현한 커스텀(예: C++ 기반) 위젯으로 대체하세요.
    *   **다중 창:** 툴 팔레트, 음악 플레이어 등 복잡한 앱을 위한 독립적인 여러 창을 생성 및 관리하세요.
*   **반응형 상태 관리:**
    *   **단방향 바인딩:** `state.bind()`로 데이터 변경 시 UI를 자동으로 업데이트하세요.
    *   **양방향 바인딩:** `state.bind_two_way()`로 입력 위젯과 상태를 손쉽게 동기화하세요.
    *   **구독:** `state.subscribe()`로 상태 변경 시 함수 실행을 트리거하세요.
*   **개발자 친화적 도구:**
    *   **핫 리로딩:** 앱을 재시작하지 않고도 UI 변경을 즉시 확인하세요.
    *   **프로파일러:** `@profiler.measure()` 데코레이터로 함수 성능을 손쉽게 측정하세요.
    *   **윈도우 도구:** 앱 창을 중앙에 배치, 깜빡임 등 손쉽게 관리하세요.
*   **내장 라우팅:** 직관적이고 상태 기반 라우터로 멀티 페이지 앱을 쉽게 만드세요.
*   **유연한 데이터 계층:** SQLite, PostgreSQL, MySQL, MongoDB, Firebase용 일관된 커넥터를 제공합니다.

---

# 문서

WinUp의 다양한 기능을 자세히 알아보세요:

## 핵심 개념
- [**컴포넌트 모델 및 스타일링**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**상태 관리**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**생명주기 훅**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**라우팅**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**절대 위치 지정(고급)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 개발자 도구
- [**라이브 핫 리로딩(LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**성능 프로파일러**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**메모이제이션**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**비동기 작업 실행기**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI 컴포넌트
- [**전체 컴포넌트 라이브러리**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## 기여하기

WinUp은 오픈소스 프로젝트입니다. 누구나 기여할 수 있습니다!

## 라이선스

이 프로젝트는 MIT 라이선스로 배포됩니다. 자세한 내용은 **LICENSE**를 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---