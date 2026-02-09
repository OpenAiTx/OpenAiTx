
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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
![Windows 构建状态](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux 构建状态](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS 构建状态](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![代码覆盖率](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![许可证](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![图库](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs 是一个快速的跨平台 Rust 库，用于构建现代的基于文本的用户界面（TUI），拥有丰富的控件、主题和完整的 Unicode 支持——是 ncurses 和其他终端 UI 框架的替代方案。
* [书籍](https://gdt050579.github.io/AppCUI-rs/)
* [文档](https://docs.rs/appcui)
* [图库](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 特性
- [x] 多种开箱即用的控件（按钮、标签、文本框、复选框、单选按钮、列表视图、树视图、组合框、日期/时间选择器、颜色选择器、标签页、手风琴等）。完整控件列表见[这里](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] 强大的布局系统，允许使用绝对坐标、相对坐标、停靠、对齐、锚点或枢轴定位来定位控件（详情见[这里](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)）
- [x] 菜单和工具栏
- [x] 多平台支持（Windows 通过 API 和虚拟终端，Linux 通过 ncurses，MacOS 通过 termios）
- [x] 多线程支持，允许后台任务
- [x] 计时器
- [x] 鼠标支持
- [x] 剪贴板支持
- [x] 颜色主题
- [x] 支持 Unicode 字符
- [x] 预定义对话框（消息框、输入框、颜色选择器、保存和打开对话框、文件夹导航等）
- [x] 真彩色支持（每像素 24 位）针对支持的终端。


## 📸 截图

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **查看[图库](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)以获取所有控件的完整演示！**

## 🖥️ 后端

AppCUI 根据使用的操作系统支持多种后端：

* **Windows 控制台** - 基于 Win32 低级 API，设计用于经典 Windows 控制台
* **Windows VT** - 基于 ANSI 序列，设计用于现代 Windows 虚拟终端
* **NCurses** - 基于 Linux 环境下的 NCurses API
* **Termios** - 基于 ANSI 序列和 MAC OSX 低级 API
* **Web 终端** - 设计用于 Web 实现（基于 webgl）
* **CrossTerm** - 基于 `crossterm` crate，但通过功能标志启用

更多支持的后端信息请见 [这里](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 快速开始

将以下内容添加到您的 `Cargo.toml`：

```toml
[dependencies]
appcui = "*"
```

然后创建一个新的 Rust 项目并添加以下代码：

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
或者使用过程宏的更简洁版本：


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
然后运行项目，使用 `cargo run`。你应该会看到一个标题为 `Test` 的窗口，中央显示文本 `Hello World !`。

## 🧪 示例

AppCUI-rs 附带了一组示例，帮助你快速入门。你可以在 [examples](examples) 文件夹中找到它们，包括：
- **游戏**，如 [井字棋](examples/tic-tac-toe/)、[贪吃蛇](examples/snake/)、[飞翔的小鸟](examples/flappy)、[扫雷](examples/minesweeper/)、[猛撞](examples/ramit/)、[吃豆人](examples/games/)、[奶酪](examples/games/)、[四子棋](examples/games/)、[2048](examples/games/) 或 [俄罗斯方块](examples/games/)
- **工具**，如 [计算器](examples/calculator/)、[CSV 查看器](examples/csv_viewer/)、[温度转换器](examples/temperature_convertor/) 或 [计时器](examples/timer/)
- **动画**，如 [矩阵](examples/matrix/)、[分形](examples/fractals/) 或 [螺旋](examples/spiral/)
- **控件**/**部件**，如 [按钮](examples/buttons/)、[复选框](examples/checkboxes/)、[下拉框](examples/combobox/)、[日期选择器](examples/datepicker/)、[列表视图](examples/listview/)、[树视图](examples/treeview/) 等等。
- **对话框**，如 [通知](examples/notification_dialogs/) 或 [输入](examples/input_dialog/)

## 🛠️ 一个更复杂的示例

一个创建带按钮的窗口的示例，按下按钮时计数器会增加。


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
## 🛣️ 路线图

- [x] 基础控件集及对 Windows、Linux 和 MacOS 的支持
- [x] WebGL 支持
- [ ] OpenGL / SDL / Vulkan 支持
- [ ] 支持用于代码高亮的文本区域

## 🤝 贡献

欢迎贡献代码、提交问题和功能请求！  
查看 [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) 以开始。

加入 [GitHub 讨论](https://github.com/gdt050579/AppCUI-rs/discussions) 一起交流。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---