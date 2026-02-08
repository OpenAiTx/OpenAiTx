# AppCUI-rs

<img src="https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/docs/chapter-1/img/logo.png" align="center" />

```                                                              
⯈ 𝗔𝗽𝗽𝗖𝗨𝗜-𝗿𝘀 🖳
```
![Windows 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS 빌드 상태](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![코드 커버리지](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![라이선스](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![갤러리](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs는 풍부한 위젯, 테마, 완전한 유니코드 지원을 갖춘 현대적인 텍스트 기반 사용자 인터페이스(TUI)를 구축하기 위한 빠르고 크로스 플랫폼 Rust 라이브러리입니다—ncurses 및 기타 터미널 UI 프레임워크의 대안입니다.
* [책](https://gdt050579.github.io/AppCUI-rs/)
* [문서](https://docs.rs/appcui)
* [갤러리](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 기능
- [x] 즉시 사용 가능한 다수의 컨트롤(버튼, 라벨, 텍스트 박스, 체크 박스, 라디오 버튼, 리스트 뷰, 트리 뷰, 콤보 박스, 날짜/시간 선택기, 색상 선택기, 탭, 아코디언 등). 전체 컨트롤 목록은 [여기](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)에서 확인할 수 있습니다.
- [x] 절대 좌표, 상대 좌표, 도킹, 정렬, 앵커 또는 피벗 위치 지정 등을 사용해 컨트롤을 배치할 수 있는 강력한 레이아웃 시스템(자세한 내용은 [여기](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html) 참조)
- [x] 메뉴 및 툴바
- [x] 다중 플랫폼 지원(Windows는 API 및 가상 터미널, Linux는 ncurses, MacOS는 termios를 통해 지원)
- [x] 백그라운드 작업을 위한 다중 스레딩 지원
- [x] 타이머
- [x] 마우스 지원
- [x] 클립보드 지원
- [x] 컬러 테마
- [x] 유니코드 문자 지원
- [x] 미리 정의된 대화상자(메시지 박스, 입력 박스, 색상 선택기, 저장 및 열기 대화상자, 폴더 탐색기 등)
- [x] 지원하는 터미널에 대해 진정한 컬러 지원(픽셀당 24비트)

## 📸 스크린샷

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **모든 컨트롤의 전체 데모는 [갤러리](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)에서 확인하세요!**

## 🖥️ 백엔드

AppCUI는 사용되는 운영 체제에 따라 다양한 백엔드를 지원합니다:

* **Windows Console** - Win32 저수준 API를 기반으로 한 고전적인 윈도우 콘솔용 설계  
* **Windows VT** - ANSI 시퀀스를 기반으로 한 현대 윈도우 가상 터미널용 설계  
* **NCurses** - 리눅스 환경용 NCurses API 기반  
* **Termios** - MAC OSX용 ANSI 시퀀스 및 저수준 API 기반  
* **Web Terminal** - 웹 구현용 설계 (webgl 기반)  
* **CrossTerm** - `crossterm` 크레이트 기반이며 기능 플래그를 통해 활성화됨  

지원되는 백엔드에 대한 자세한 내용은 [여기](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)에서 확인할 수 있습니다  


## 🚀 빠른 시작  

`Cargo.toml`에 다음을 추가하세요:


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
proc-매크로를 사용한 더 간결한 버전:


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
그런 다음 `cargo run`으로 프로젝트를 실행하세요. 제목이 `Test`이고 중앙에 `Hello World !`라는 텍스트가 있는 창이 표시됩니다.

## 🧪 예제

AppCUI-rs는 시작하는 데 도움이 되는 여러 예제를 제공합니다. [examples](examples) 폴더에서 다음과 같은 예제를 찾을 수 있습니다:
- [틱택토](examples/tic-tac-toe/), [스네이크](examples/snake/), [플래피 버드](examples/flappy), [지뢰찾기](examples/minesweeper/), [램 잇](examples/ramit/), [팩맨](examples/games/), [치즈](examples/games/), [커넥트 포](examples/games/), [2048](examples/games/), [테트리스](examples/games/)와 같은 **게임**
- [계산기](examples/calculator/), [CSV 뷰어](examples/csv_viewer/), [온도 변환기](examples/temperature_convertor/), [타이머](examples/timer/)와 같은 **유틸리티**
- [매트릭스](examples/matrix/), [프랙탈](examples/fractals/), [스파이럴](examples/spiral/)과 같은 **애니메이션**
- [버튼](examples/buttons/), [체크박스](examples/checkboxes/), [콤보박스](examples/combobox/), [데이트피커](examples/datepicker/), [리스트뷰](examples/listview/), [트리뷰](examples/treeview/) 등과 같은 **컨트롤**/**위젯**
- [알림](examples/notification_dialogs/) 또는 [입력](examples/input_dialog/)과 같은 **대화상자**

## 🛠️ 좀 더 복잡한 예제

버튼을 눌렀을 때 카운터가 증가하는 창을 생성하는 예제입니다.


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
        // create a text that containe the new counter
        let text = format!("{}",self.counter);
        // aquire a mutable reference to the button using its handle
        if let Some(button) = self.control_mut(handle) {
            // set the caption of the button to th new text
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
    // Run AppCUI framework (this wil start the window loop and messaage passing)
    a.run();
    Ok(())
}
```
## 🛣️ 로드맵

- [x] 기본 위젯 세트 및 Windows, Linux, MacOS 지원
- [x] WebGL 지원
- [ ] OpenGL / SDL / Vulkan 지원
- [ ] 코드 하이라이팅용 TextArea 지원

## 🤝 기여하기

기여, 이슈, 기능 요청을 환영합니다!  
시작하려면 [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md)를 확인하세요.

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions)에서 토론에 참여하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-08

---