
<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

![Windows 建置狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux 建置狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS 建置狀態](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![程式碼覆蓋率](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![授權](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs 是一個快速、跨平台的 Rust 函式庫，用於建立現代化的文字用戶介面（TUI），具有豐富的元件、主題及完整的 Unicode 支援，是 ncurses 與其他終端 UI 框架的替代方案。
* [書籍](https://gdt050579.github.io/AppCUI-rs/)
* [文件](https://docs.rs/appcui)
* [畫廊](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 功能特色
- [x] 多種現成控制元件（按鈕、標籤、文字框、勾選框、單選框、清單檢視、樹狀檢視、下拉選單、日期/時間選擇器、色彩選擇器、分頁、手風琴等）。完整控制元件清單請參見[這裡](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] 強大的佈局系統，允許以絕對座標、相對座標、停駐、對齊、錨點或樞軸定位來排列元件（更多內容請見[這裡](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] 選單與工具列
- [x] 多平台支援（Windows 經由 API 與虛擬終端、Linux 經由 ncurses、MacOS 經由 termios）
- [x] 多執行緒支援，允許背景工作
- [x] 計時器
- [x] 滑鼠支援
- [x] 剪貼簿支援
- [x] 色彩主題
- [x] Unicode 字元支援
- [x] 預設對話框（訊息框、輸入框、色彩選擇器、儲存與開啟對話框、資料夾瀏覽器等）
- [x] 真彩支援（每像素 24 位元），適用於支援的終端機。

## 📸 截圖

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **前往 [畫廊](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) 查看所有控制元件的完整示範！**

## 🖥️ 後端支援

AppCUI 根據所使用的作業系統，支援多種後端：

* **Windows Console** - 基於 Win32 低階 API，設計用於傳統 Windows 主控台
* **Windows VT** - 基於 ANSI 序列，設計用於現代 Windows 虛擬終端機
* **NCurses** - 基於 NCurses API，適用於 Linux 環境
* **Termios** - 基於 ANSI 序列及 MAC OSX 低階 API
* **Web Terminal** - 為 Web 實作設計（基於 webgl）
* **CrossTerm** - 基於 `crossterm` crate，但需透過功能標誌啟用

有關支援的後端更多資訊請參考 [這裡](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 快速開始

將下列內容加入你的 `Cargo.toml`：

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
或使用 proc-macros 的更精簡版本：


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
然後使用 `cargo run` 執行專案。你應該會看到一個標題為 `Test` 的視窗，並在中央顯示 `Hello World !` 文字。

## 🧪 範例

AppCUI-rs 提供了一系列範例協助你快速上手。你可以在 [examples](examples) 資料夾中找到，包括：
- **遊戲** 如 [井字遊戲](examples/tic-tac-toe/)、[貪食蛇](examples/snake/)、[Flappy Bird](examples/flappy)、[踩地雷](examples/minesweeper/)、[Ram it](examples/ramit/)、[吃豆人](examples/games/)、[西洋棋](examples/games/)、[四子棋](examples/games/)、[2048](examples/games/) 或 [俄羅斯方塊](examples/games/)
- **工具** 如 [計算機](examples/calculator/)、[CSV 檢視器](examples/csv_viewer/)、[溫度轉換器](examples/temperature_convertor/) 或 [計時器](examples/timer/)
- **動畫** 如 [矩陣](examples/matrix/)、[分形](examples/fractals/) 或 [螺旋](examples/spiral/)
- **控制項**/**小工具** 如 [按鈕](examples/buttons/)、[核取方塊](examples/checkboxes/)、[下拉選單](examples/combobox/)、[日期選擇器](examples/datepicker/)、[清單檢視](examples/listview/)、[樹狀檢視](examples/treeview/) 以及更多。
- **對話框** 如 [通知](examples/notification_dialogs/) 或 [輸入](examples/input_dialog/)

## 🛠️ 更複雜的範例

一個範例會建立一個視窗，包含一個按鈕，按下後會增加計數器。


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

## 🛣️ 路線圖

- [x] 基本元件集及對 Windows、Linux 和 MacOS 的支援
- [x] 支援 WebGL
- [ ] 支援 OpenGL / SDL / Vulkan
- [ ] 支援用於程式碼高亮的 TextArea

## 🤝 貢獻

歡迎貢獻、問題回報與功能請求！  
請參閱 [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) 以開始參與。

歡迎加入 [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions) 討論。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---