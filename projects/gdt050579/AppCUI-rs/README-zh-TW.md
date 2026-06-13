<div align="right">
  <details>
    <summary>🌐 語言</summary>
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

![Windows 構建狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux 構建狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![macOS 構建狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![程式碼覆蓋率](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![授權](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs 是一個快速、跨平台的 Rust 函式庫，用於構建現代文字基礎的使用者介面（TUI），擁有豐富的元件、主題與完整的 Unicode 支援——是 ncurses 及其他終端介面框架的替代方案。
* [書籍](https://gdt050579.github.io/AppCUI-rs/)
* [文件](https://docs.rs/appcui)
* [圖庫](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 功能特色
- [x] 多種即時可用的元件（按鈕、標籤、文字方塊、核取方塊、單選按鈕、清單檢視、樹狀檢視、下拉選單、日期/時間選擇器、顏色選擇器、分頁、手風琴等）。完整元件清單請參見[此處](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] 強大的版面配置系統，可用絕對座標、相對座標、對接、對齊、錨點或樞紐點來配置元件（詳見[此處](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)）
- [x] 選單與工具列
- [x] 跨平台支援（Windows 透過 API 與虛擬終端、Linux 透過 ncurses、macOS 透過 termios）
- [x] 多執行緒支援，可進行背景任務
- [x] 定時器
- [x] 滑鼠支援
- [x] 剪貼簿支援
- [x] 色彩主題
- [x] 支援 Unicode 字元
- [x] 預設對話框（訊息框、輸入框、顏色選擇器、儲存及開啟對話框、資料夾導覽等）
- [x] 真彩支援（24 位元色彩），適用於支援的終端。

## 📸 截圖

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **前往[圖庫](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)查看所有元件的完整展示！**

## 🖥️ 後端支援

AppCUI 依據作業系統支援多種後端：
* **Windows Console** - 基於 Win32 低階 API，設計用於經典的 Windows 主控台
* **Windows VT** - 基於 ANSI 序列，設計用於現代 Windows 虛擬終端
* **NCurses** - 基於 Linux 環境下的 NCurses API
* **Termios** - 基於 ANSI 序列及 macOS 的低階 API
* **Web Terminal** - 為網頁實現所設計（基於 WebGL）
* **CrossTerm** - 基於 `crossterm` crate，透過功能標誌啟用

可在[這裡](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)找到更多支援後端的資訊


## 🚀 快速開始

將以下內容新增至您的 `Cargo.toml`：


```toml
[dependencies]
appcui = "*"
```

然後建立一個新的 Rust 專案並加入以下程式碼：

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

或者使用 proc-macros 的更簡潔版本：

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

然後使用 `cargo run` 執行專案。你應該會看到一個標題為 `Test` 的視窗，中央顯示 `Hello World !` 文字。

## 🧪 範例

AppCUI-rs 提供了一組範例幫助你快速上手。你可以在 [examples](examples) 資料夾中找到這些範例，包括：
- **遊戲**，例如 [井字遊戲](examples/tic-tac-toe/)、[貪食蛇](examples/snake/)、[Flappy Bird](examples/flappy)、[踩地雷](examples/minesweeper/)、[Ram it](examples/ramit/)、[吃豆人](examples/games/)、[西洋棋](examples/games/)、[四連線](examples/games/)、[2048](examples/games/)、或 [俄羅斯方塊](examples/games/)
- **工具**，例如 [計算機](examples/calculator/)、[CSV 檢視器](examples/csv_viewer/)、[溫度轉換器](examples/temperature_convertor/)、或 [計時器](examples/timer/)
- **動畫**，例如 [Matrix](examples/matrix/)、[分形](examples/fractals/)、或 [螺旋](examples/spiral/)
- **控制項**/**元件**，例如 [按鈕](examples/buttons/)、[核取方塊](examples/checkboxes/)、[下拉選單](examples/combobox/)、[日期選擇器](examples/datepicker/)、[清單檢視](examples/listview/)、[樹狀檢視](examples/treeview/) 等等。
- **對話框**，例如 [通知](examples/notification_dialogs/) 或 [輸入](examples/input_dialog/)

## 🛠️ 更複雜的範例

一個建立視窗並包含按鈕的範例，當按鈕被按下時，計數器會增加。

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

## 🛣️ 路線圖

- [x] 基本元件集以及對 Windows、Linux 和 macOS 的支援
- [x] 支援 WebGL
- [ ] 支援 OpenGL / SDL / Vulkan
- [ ] TextArea 支援程式碼高亮顯示

## 🤝 貢獻方式

歡迎貢獻、提出問題與新功能需求！  
請參考 [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) 以開始參與。

加入 [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions) 的討論。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---