
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=gdt050579&project=AppCUI-rs&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AppCUI-rs

<img src="https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/docs/chapter-1/img/logo.png" align="center" />

```                                                              
⯈ 𝗔𝗽𝗽𝗖𝗨𝗜-𝗿𝘀 🖳
```

![Trạng thái Build Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Trạng thái Build Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Trạng thái Build MacOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Mức độ bao phủ mã nguồn](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Giấy phép](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Thư viện ảnh](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs là một thư viện Rust nhanh, đa nền tảng để xây dựng giao diện người dùng dạng văn bản hiện đại (TUI) với các widget phong phú, chủ đề và hỗ trợ Unicode đầy đủ—là một lựa chọn thay thế cho ncurses và các framework giao diện terminal khác.
* [Sách](https://gdt050579.github.io/AppCUI-rs/)
* [Tài liệu](https://docs.rs/appcui)
* [Thư viện ảnh](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Tính năng
- [x] nhiều điều khiển có sẵn (nút bấm, nhãn, hộp văn bản, hộp kiểm, nút radio, danh sách, cây thư mục, hộp chọn, chọn ngày/giờ, chọn màu, tab, accordion, v.v.). Danh sách đầy đủ các điều khiển có thể xem [tại đây](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] hệ thống bố cục mạnh mẽ cho phép bạn định vị điều khiển bằng tọa độ tuyệt đối, tương đối, docking, căn chỉnh, neo hoặc định vị theo pivot (xem thêm [tại đây](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] menu và thanh công cụ
- [x] hỗ trợ đa nền tảng (Windows qua API và virtual terminal, Linux qua ncurses, MacOS qua termios)
- [x] hỗ trợ đa luồng để thực hiện các tác vụ nền
- [x] bộ đếm thời gian
- [x] hỗ trợ chuột
- [x] hỗ trợ clipboard
- [x] chủ đề màu sắc
- [x] hỗ trợ ký tự Unicode
- [x] hộp thoại định nghĩa sẵn (hộp thông báo, hộp nhập liệu, chọn màu, hộp thoại lưu & mở, trình điều hướng thư mục, v.v)
- [x] hỗ trợ màu thực (24 bit/pixel) cho các terminal hỗ trợ.

## 📸 Ảnh chụp màn hình 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Xem [Thư viện ảnh](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) để xem demo đầy đủ của tất cả điều khiển!**

## 🖥️ Backend

AppCUI hỗ trợ nhiều backend khác nhau tùy theo hệ điều hành mà bạn sử dụng:

* **Windows Console** - dựa trên API Win32 cấp thấp, thiết kế cho console cổ điển của Windows
* **Windows VT** - dựa trên chuỗi ANSI, thiết kế cho các terminal ảo hiện đại của Windows
* **NCurses** - dựa trên API NCurses cho môi trường Linux
* **Termios** - dựa trên chuỗi ANSI và API cấp thấp cho MAC OSX
* **Web Terminal** - thiết kế cho triển khai trên Web (dựa trên webgl)
* **CrossTerm** - dựa trên crate `crossterm`, nhưng được kích hoạt thông qua một cờ tính năng

Thông tin thêm về các backend được hỗ trợ có thể xem [tại đây](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Khởi động nhanh

Thêm các dòng sau vào `Cargo.toml` của bạn:

```toml
[dependencies]
appcui = "*"
```
Sau đó tạo một dự án Rust mới và thêm đoạn mã sau:


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
hoặc một phiên bản gọn hơn sử dụng proc-macros:


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
Sau đó chạy dự án với `cargo run`. Bạn sẽ thấy một cửa sổ với tiêu đề `Test` và dòng chữ `Hello World !` ở giữa màn hình.

## 🧪 Các ví dụ

AppCUI-rs đi kèm với một bộ ví dụ để giúp bạn bắt đầu. Bạn có thể tìm thấy chúng trong thư mục [examples](examples), bao gồm:
- **Trò chơi** như [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) hoặc [Tetris](examples/games/)
- **Tiện ích** như [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/) hoặc [Timer](examples/timer/)
- **Hoạt họa** như [Matrix](examples/matrix/), [Fractals](examples/fractals/) hoặc [Spiral](examples/spiral/)
- **Điều khiển**/**Widget** như [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) và nhiều hơn nữa.
- **Hộp thoại** như [Notification](examples/notification_dialogs/) hoặc [Input](examples/input_dialog/)

## 🛠️ Một ví dụ phức tạp hơn

Một ví dụ tạo ra một cửa sổ với một nút bấm, khi nhấn sẽ tăng bộ đếm.


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

## 🛣️ Lộ trình

- [x] Bộ widget cơ bản và hỗ trợ cho Windows, Linux và MacOS
- [x] Hỗ trợ WebGL
- [ ] Hỗ trợ OpenGL / SDL / Vulkan
- [ ] Hỗ trợ TextArea cho tô sáng mã nguồn

## 🤝 Đóng góp

Đóng góp, báo lỗi và yêu cầu tính năng luôn được hoan nghênh!  
Hãy xem [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) để bắt đầu.

Tham gia thảo luận tại [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---