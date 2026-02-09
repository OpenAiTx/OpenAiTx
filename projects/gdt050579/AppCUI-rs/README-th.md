
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

![Windows Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Code Coverage](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![License](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs เป็นไลบรารี Rust ที่รวดเร็วและรองรับหลายแพลตฟอร์ม สำหรับสร้างส่วนติดต่อผู้ใช้แบบข้อความ (TUI) ที่ทันสมัย พร้อมวิดเจ็ตหลากหลาย ธีม และรองรับ Unicode อย่างเต็มรูปแบบ เป็นทางเลือกแทน ncurses และเฟรมเวิร์ก UI เทอร์มินัลอื่นๆ
* [Book](https://gdt050579.github.io/AppCUI-rs/)
* [Documentation](https://docs.rs/appcui)
* [Gallery](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ ฟีเจอร์
- [x] ควบคุมหลายแบบพร้อมใช้งาน (ปุ่ม, ป้าย, กล่องข้อความ, เช็คบ็อกซ์, เรดิโอบัตตัน, ลิสต์วิว, ทรีวิว, คอมโบบ็อกซ์, ตัวเลือกวันที่/เวลา, ตัวเลือกสี, แท็บ, accordeons ฯลฯ) รายการควบคุมทั้งหมดดูได้ที่ [นี่](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] ระบบจัดวางที่ทรงพลัง ให้คุณจัดตำแหน่งควบคุมด้วยพิกัดแบบสัมบูรณ์, สัมพัทธ์, docking, alignment, anchors หรือ pivot positioning (ดูเพิ่มเติม [ที่นี่](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] เมนูและทูลบาร์
- [x] รองรับหลายแพลตฟอร์ม (Windows ผ่าน API และ virtual terminal, Linux ผ่าน ncurses, MacOS ผ่าน termios)
- [x] รองรับมัลติเธรดสำหรับงานเบื้องหลัง
- [x] ตั้งเวลา
- [x] รองรับเมาส์
- [x] รองรับคลิปบอร์ด
- [x] ธีมสี
- [x] รองรับอักขระ Unicode
- [x] กล่องโต้ตอบที่กำหนดไว้ล่วงหน้า (message box, input box, color picker, save & open dialogs, folder navigator ฯลฯ)
- [x] รองรับ true colors (24 บิตต่อพิกเซล) สำหรับเทอร์มินัลที่รองรับ

## 📸 ภาพหน้าจอ 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **ดู [Gallery](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) เพื่อชมเดโมของทุกควบคุม!**

## 🖥️ แบ็คเอนด์

AppCUI รองรับแบ็คเอนด์หลายแบบตามระบบปฏิบัติการที่ใช้งาน

* **Windows Console** - พื้นฐานบน Win32 low level API ออกแบบสำหรับคอนโซลวินโดว์แบบคลาสสิก
* **Windows VT** - พื้นฐานบน ANSI sequances ออกแบบสำหรับเทอร์มินัลเสมือนวินโดว์ยุคใหม่
* **NCurses** - พื้นฐานบน NCurses API สำหรับสภาพแวดล้อมลินุกซ์
* **Termios** - พื้นฐานบน ANSI sequances และ low level APIs สำหรับ MAC OSX
* **Web Terminal** - ออกแบบสำหรับการใช้งานบนเว็บ (พื้นฐานบน webgl)
* **CrossTerm** - พื้นฐานบน `crossterm` crate แต่เปิดใช้งานผ่าน feature flag

สามารถอ่านข้อมูลเพิ่มเติมเกี่ยวกับ backend ที่รองรับได้ [ที่นี่](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 เริ่มต้นใช้งานอย่างรวดเร็ว

เพิ่มบรรทัดต่อไปนี้ลงในไฟล์ `Cargo.toml` ของคุณ:

```toml
[dependencies]
appcui = "*"
```
จากนั้นสร้างโปรเจกต์ Rust ใหม่และเพิ่มโค้ดต่อไปนี้:


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
หรือเวอร์ชันที่กะทัดรัดกว่าด้วยการใช้ proc-macros:


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
จากนั้นให้รันโปรเจกต์ด้วยคำสั่ง `cargo run` คุณจะเห็นหน้าต่างที่มีชื่อว่า `Test` และข้อความ `Hello World !` อยู่ตรงกลาง

## 🧪 ตัวอย่าง

AppCUI-rs มาพร้อมกับชุดตัวอย่างเพื่อช่วยให้คุณเริ่มต้นใช้งาน คุณสามารถพบตัวอย่างเหล่านี้ได้ในโฟลเดอร์ [examples](examples) ซึ่งรวมถึง:
- **เกม** เช่น [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) หรือ [Tetris](examples/games/)
- **เครื่องมือ** เช่น [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/) หรือ [Timer](examples/timer/)
- **แอนิเมชัน** เช่น [Matrix](examples/matrix/), [Fractals](examples/fractals/) หรือ [Spiral](examples/spiral/)
- **คอนโทรล**/**วิดเจ็ต** เช่น [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) และอื่น ๆ อีกมากมาย
- **ไดอะล็อก** เช่น [Notification](examples/notification_dialogs/) หรือ [Input](examples/input_dialog/)

## 🛠️ ตัวอย่างที่ซับซ้อนมากขึ้น

ตัวอย่างนี้จะสร้างหน้าต่างที่มีปุ่ม ซึ่งเมื่อกดปุ่มแล้วจะเพิ่มตัวนับเลข


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

## 🛣️ แผนงาน

- [x] ชุดวิดเจ็ตพื้นฐานและรองรับ Windows, Linux และ MacOS
- [x] รองรับ WebGL
- [ ] รองรับ OpenGL / SDL / Vulkan
- [ ] รองรับ TextArea สำหรับการเน้นโค้ด

## 🤝 การมีส่วนร่วม

ยินดีต้อนรับการมีส่วนร่วม, รายงานปัญหา และคำขอฟีเจอร์!  
ดูรายละเอียดได้ที่ [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) เพื่อเริ่มต้น

เข้าร่วมพูดคุยใน [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---