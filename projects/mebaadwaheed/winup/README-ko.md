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

## 반드시 최신 안정 버전(LSR)을 다운로드하세요, 최신/LFR가 아닙니다! 현재 LSR: 2.4.9

`pip install winup==2.4.9`

**아주 파이써닉하고 강력한 아름다운 데스크탑 애플리케이션 구축 프레임워크입니다.**

WinUp은 PySide6(Qt)의 강력함을 간단하고 선언적이며 개발자 친화적인 API로 감싼 현대적인 Python UI 프레임워크입니다. 더 빠르게 애플리케이션을 구축하고, 코드를 더 깔끔하게 작성하며, 개발 과정을 즐기도록 설계되었습니다.

### ✨ 이제 웹 지원도 제공합니다!
WinUp은 이제 동일한 Python 중심의 컴포넌트 기반 접근법으로 완전한 인터랙티브 상태 기반 웹 애플리케이션도 빌드할 수 있습니다. 웹 모듈은 FastAPI와 WebSockets를 내부적으로 사용하여 WinUp의 간결함을 브라우저에 제공합니다.

[웹 문서](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **면책 조항:** 웹 지원은 선택적 기능입니다. 사용하려면 웹 종속성을 설치해야 합니다:
> ```bash
> pip install "winup[web]"
> ```

[기여하기](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[변경 로그](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[라이선스](LICENSE)

---

## 왜 WinUp인가? (원시 PySide6 또는 Tkinter 대신)

Python에서 데스크탑 개발은 답답할 수 있습니다. WinUp은 이를 해결하기 위해 만들어졌습니다.

| 기능                      | WinUp 방식 ✨                                                              | 원시 PySide6 / Tkinter 방식 😟                                                      |
| ------------------------ | ------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| **레이아웃**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                     | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`         |
| **스타일링**             | `props={"background-color": "blue", "font-size": "16px"}`                 | 수동 QSS 문자열, `widget.setStyleSheet(...)`, 복잡한 스타일 객체들                  |
| **상태 관리**            | `state.bind(widget, "prop", "key")`                                       | 수동 콜백 함수, 게터/세터, `StringVar()`, 여기저기 보일러플레이트                   |
| **양방향 바인딩**         | `state.bind_two_way(input_widget, "key")`                                 | 없음. 상태와 UI를 업데이트하기 위한 수동 `on_change` 핸들러 필요                   |
| **개발자 도구**          | **내장 핫 리로딩**, 코드 프로파일러, 윈도우 도구 기본 제공                   | 없음. UI 변경마다 앱 전체를 재시작해야 함                                         |
| **코드 구조**            | `@component`로 재사용 가능하고 독립적인 컴포넌트                            | 종종 거대하고 단일 클래스 또는 절차적 스크립트로 이어짐                            |

**요약하면, WinUp은 현대 웹 프레임워크(React, Vue 등)의 "킬러 기능"을 데스크탑에 제공하여 시간을 절약하고 애플리케이션 로직에 집중할 수 있도록 합니다.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit 사용자 요청)

| 기능                           | WinUp                                | PyEdifice                           |
|-------------------------------|------------------------------------|-----------------------------------|
| 🧱 아키텍처                   | React 스타일 + 상태                 | React 스타일 + 상태                |
| 🌐 내장 라우팅                | ✅ 있음 (`Router(routes={...})`)   | ❌ 내장 라우팅 없음                |
| ♻️ 라이프사이클 훅            | ✅ `on_mount`, `on_unmount` 등      | ⚠️ 제한적 (`did_mount` 등)          |
| 🎨 테마 / 스타일링 시스템    | ✅ 전역 및 범위 테마                | ❌ 수동 CSS 주입                   |
| 🔲 레이아웃 옵션             | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ 주로 Box 및 HBox/VBox           |
| 🎞️ 애니메이션               | ✅ 내장(fade, scale 등)             | ❌ 내장 애니메이션 없음             |
| 🔁 핫 리로딩 (LHR)           | ✅ 안정적 + 빠름 (`loadup dev`)     | ⚠️ 실험적, 제한적 지원             |
| 📦 패키징                   | ✅ LoadUp(PyInstaller 기반) 포함    | ❌ PyInstaller 수동 통합 필요       |
| 🧩 컴포넌트 재사용성        | ✅ 높음, 선언적                    | ✅ 높음                           |
| 🛠 개발자 도구              | ✅ DevTools 예정, 곧 Inspector 출시  | ❌ 아직 없음                      |
| 📱 모바일 지원              | ❌ 아직 지원 안 함                 | ❌ 지원 안 함                     |
| 🧠 학습 곡선                | ✅ Python+React 사용자에 쉬움       | ✅ 쉬우나 도구는 적음              |

> ✅ = 내장 또는 견고함  
> ⚠️ = 부분적 또는 제한적  
> ❌ = 전혀 없음
---

## 핵심 기능

*   **선언적이고 파이써닉한 UI:** 복잡한 레이아웃을 어색한 박스 레이아웃 대신 간단한 `Row`와 `Column` 객체로 구축하세요.
*   **컴포넌트 기반 아키텍처:** `@component` 데코레이터로 간단한 함수에서 모듈식 재사용 UI 위젯을 만드세요.
*   **강력한 스타일링 시스템:** `props`로 간단한 파이썬 딕셔너리를 사용해 위젯을 스타일링하세요. `style.add_style_dict`로 전역 "CSS 같은" 클래스도 만드세요.
*   **완전한 애플리케이션 셸:** `MenuBar`, `ToolBar`, `StatusBar`, `SystemTrayIcon`을 위한 선언적 API로 전문적인 애플리케이션을 빌드하세요.
*   **비동기 작업 실행기:** 간단한 `@tasks.run` 데코레이터로 UI를 멈추지 않고 백그라운드에서 장시간 작업을 실행하세요.
*   **기본 제공 성능 최적화:** 컴포넌트 렌더링을 캐시하고 불필요한 재계산을 방지하는 선택적 `@memo` 데코레이터 포함.
*   **고급 확장성:**
    *   **위젯 팩토리:** `ui.register_widget()`로 기본 위젯을 사용자 정의 구현(예: C++ 기반)으로 교체 가능.
    *   **다중 창:** 툴 팔레트나 음악 플레이어 같은 복잡한 애플리케이션을 위해 독립 창 여러 개 생성 및 관리 가능.
*   **반응형 상태 관리:**
    *   **단방향 바인딩:** `state.bind()`으로 데이터 변경 시 UI 자동 업데이트.
    *   **양방향 바인딩:** `state.bind_two_way()`로 입력 위젯과 상태를 손쉽게 동기화.
    *   **구독:** `state.subscribe()`로 상태 변경에 따라 함수 트리거.
*   **개발자 친화적 도구:**
    *   **핫 리로딩:** 앱 재시작 없이 UI 변경 즉시 반영.
    *   **프로파일러:** `@profiler.measure()` 데코레이터로 함수 성능 측정 용이.
    *   **윈도우 도구:** 앱 창 중앙 배치, 깜박임, 관리 간편.
*   **내장 라우팅:** 직관적이고 상태 기반 라우터로 다중 페이지 앱 쉽게 생성.
*   **유연한 데이터 레이어:** SQLite, PostgreSQL, MySQL, MongoDB, Firebase용 간단하고 일관된 커넥터 포함.

---

# 문서

WinUp의 기능을 더 깊이 탐구하세요:

## 핵심 개념
- [**컴포넌트 모델 및 스타일링**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**상태 관리**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**라이프사이클 훅**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**라우팅**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**절대 위치 지정(고급)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 개발자 도구
- [**라이브 핫 리로드 (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**성능 프로파일러**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**메모이제이션**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**비동기 작업 실행기**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI 컴포넌트
- [**전체 컴포넌트 라이브러리**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## 기여하기

WinUp은 오픈 소스 프로젝트입니다. 기여를 환영합니다!

## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 **LICENSE**를 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---