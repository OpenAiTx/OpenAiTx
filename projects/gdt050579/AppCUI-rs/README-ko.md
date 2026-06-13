
<div align="right">
  <details>
    <summary>🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# AppCUI-rs

<img src="https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/docs/chapter-1/img/logo.png" align="center" />

```                                                              
⯈ 𝗔𝗽𝗽𝗖𝗨𝗜-𝗿𝘀 🖳
```

![Windows 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![macOS 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![코드 커버리지](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![라이선스](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs는 빠르고, 크로스 플랫폼을 지원하는 Rust 라이브러리로, 풍부한 위젯과 테마, 완전한 유니코드 지원을 제공하며, ncurses 및 기타 터미널 UI 프레임워크의 대안인 현대적인 텍스트 기반 사용자 인터페이스(TUI)를 구축할 수 있습니다.
* [Book](https://gdt050579.github.io/AppCUI-rs/)
* [Documentation](https://docs.rs/appcui)
* [Gallery](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 기능
- [x] 다양한 기본 제공 컨트롤(버튼, 라벨, 텍스트 박스, 체크 박스, 라디오 버튼, 리스트 뷰, 트리 뷰, 콤보 박스, 날짜/시간 선택기, 색상 선택기, 탭, 아코디언 등). 전체 컨트롤 목록은 [여기](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)에서 확인할 수 있습니다.
- [x] 강력한 레이아웃 시스템으로, 절대 좌표, 상대 좌표, 도킹, 정렬, 앵커 또는 피벗 위치를 사용하여 컨트롤 배치 가능([자세히 보기](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] 메뉴 및 툴바 지원
- [x] 다중 플랫폼 지원(Windows: API 및 가상 터미널, Linux: ncurses, macOS: termios)
- [x] 백그라운드 작업을 위한 멀티스레딩 지원
- [x] 타이머 지원
- [x] 마우스 지원
- [x] 클립보드 지원
- [x] 색상 테마 지원
- [x] 유니코드 문자 지원
- [x] 미리 정의된 대화 상자(메시지 박스, 입력 박스, 색상 선택기, 저장 및 열기 대화상자, 폴더 탐색기 등)
- [x] 터미널이 지원하는 경우 진정한 컬러(24비트 픽셀) 지원

## 📸 스크린샷 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **모든 컨트롤의 전체 데모는 [Gallery](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)에서 확인하세요!**

## 🖥️ 백엔드

AppCUI는 운영체제에 따라 다양한 백엔드를 지원합니다:

* **Windows 콘솔** - Win32 저수준 API를 기반으로 하며, 고전적인 Windows 콘솔을 위해 설계됨
* **Windows VT** - ANSI 시퀀스를 기반으로 하며, 최신 Windows 가상 터미널을 위해 설계됨
* **NCurses** - Linux 환경을 위한 NCurses API를 기반으로 함
* **Termios** - macOS용 ANSI 시퀀스 및 저수준 API를 기반으로 함
* **웹 터미널** - 웹 구현을 위해 설계됨(WebGL 기반)
* **크로스텀** - `crossterm` 크레이트를 기반으로 하며, 기능 플래그로 활성화됨

지원되는 백엔드에 대한 자세한 내용은 [여기](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)에서 확인할 수 있습니다.


## 🚀 빠른 시작

다음 내용을 `Cargo.toml`에 추가하세요:

```toml
[dependencies]
appcui = "*"
```

그런 다음 새 Rust 프로젝트를 생성하고 다음 코드를 추가하십시오:

```rust
use appcui::prelude::*;

fn main() -> Result<(), appcui::system::Error> {
    let mut app = App::new().build()?;
    let mut win = Window::new(
        "Test",
        LayoutBuilder::new().alignment(Alignment::Center).width(30).height(9).build(),
        window::Flags::Sizeable,
    );
    win.add(Label::new(
        "Hello World !",
        LayoutBuilder::new().alignment(Alignment::Center).width(13).height(1).build(),
    ));
    app.add_window(win);
    app.run();
    Ok(())
}
```

혹은 proc-macros를 사용한 더 간결한 버전:

```rs
use appcui::prelude::*;

fn main() -> Result<(), appcui::system::Error> {
    let mut app = App::new().build()?;
    let mut win = window!("Test,a:c,w:30,h:9");
    win.add(label!("'Hello World !',a:c,w:13,h:1"));
    app.add_window(win);
    app.run();
    Ok(())
}
```

그런 다음 `cargo run`으로 프로젝트를 실행하세요. `Test`라는 제목의 창과 중앙에 `Hello World !` 텍스트가 표시되는 것을 볼 수 있습니다.

## 🧪 예제

AppCUI-rs에는 시작하는 데 도움이 되는 다양한 예제가 포함되어 있습니다. [examples](examples) 폴더에서 확인하실 수 있으며, 다음과 같은 내용이 있습니다:
- **게임**: [틱택토](examples/tic-tac-toe/), [스네이크](examples/snake/), [플래피 버드](examples/flappy), [지뢰찾기](examples/minesweeper/), [Ram it](examples/ramit/), [팩맨](examples/games/), [체스](examples/games/), [커넥트 포](examples/games/), [2048](examples/games/), 또는 [테트리스](examples/games/)
- **유틸리티**: [계산기](examples/calculator/), [CSV 뷰어](examples/csv_viewer/), [온도 변환기](examples/temperature_convertor/), 또는 [타이머](examples/timer/)
- **애니메이션**: [매트릭스](examples/matrix/), [프랙탈](examples/fractals/), 또는 [스파이럴](examples/spiral/)
- **컨트롤**/**위젯**: [버튼](examples/buttons/), [체크박스](examples/checkboxes/), [콤보박스](examples/combobox/), [데이트피커](examples/datepicker/), [리스트뷰](examples/listview/), [트리뷰](examples/treeview/) 등 다양한 위젯이 있습니다.
- **다이얼로그**: [알림](examples/notification_dialogs/) 또는 [입력](examples/input_dialog/)

## 🛠️ 좀 더 복잡한 예제

버튼이 있는 창을 만들고, 버튼을 누르면 카운터가 증가하는 예제입니다.

```rust
use appcui::prelude::*;

// Create a window that handles button events and has a counter
#[Window(events = ButtonEvents)]
struct CounterWindow {
    counter: i32
}

impl CounterWindow {
    fn new() -> Self {
        let mut w = Self {
            // set up the window title and position
            base: window!("'Counter window',a:c,w:30,h:5"),
            // initial counter is 1
            counter: 1            
        };
        // add a single button with the caption "1" (like the counter)
        w.add(button!("'1',d:b,w:20"));
        w
    }
}
impl ButtonEvents for CounterWindow {
    // When the button is pressed, this function will be called
    // with the handle of the button that was pressed
    // Since we only have one button, we don't need to store its handle 
    // in the struct, as we will receive the handle via the on_pressed method
    fn on_pressed(&mut self, handle: Handle<Button>) -> EventProcessStatus {
        // increase the counter
        self.counter += 1;
        // create a text that contains the new counter
        let text = format!("{}",self.counter);
        // acquire a mutable reference to the button using its handle
        if let Some(button) = self.control_mut(handle) {
            // set the caption of the button to the new text
            button.set_caption(&text);
        }
        // Tell the AppCUI framework that we have processed this event
        // This allows AppCUI to repaint the button
        EventProcessStatus::Processed
    }
}

fn main() -> Result<(), appcui::system::Error> {
    // create a new application
    let mut a = App::new().build()?;
    // add a new window (of type CounterWindow) to the application
    a.add_window(CounterWindow::new());
    // Run AppCUI framework (this will start the window loop and message passing)
    a.run();
    Ok(())
}
```

## 🛣️ 로드맵

- [x] 기본 위젯 세트 및 Windows, Linux, macOS 지원
- [x] WebGL 지원
- [ ] OpenGL / SDL / Vulkan 지원
- [ ] 코드 하이라이팅을 위한 TextArea 지원

## 🤝 기여하기

기여, 이슈, 기능 요청 모두 환영합니다!  
시작하려면 [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md)를 확인하세요.

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions)에서 논의에 참여하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---