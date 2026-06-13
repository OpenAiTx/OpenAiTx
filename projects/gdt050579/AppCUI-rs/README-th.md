
<div align="right">
  <details>
    <summary>🌐 ภาษา</summary>
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

![สถานะการ Build บน Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![สถานะการ Build บน Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![สถานะการ Build บน macOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![การครอบคลุมของโค้ด](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![ไลเซนส์](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs คือไลบรารี Rust ที่รวดเร็ว รองรับข้ามแพลตฟอร์ม สำหรับสร้างอินเทอร์เฟซผู้ใช้แบบข้อความ (TUI) สมัยใหม่ที่มีวิดเจ็ต ธีม และรองรับ Unicode อย่างเต็มรูปแบบ—เป็นทางเลือกแทน ncurses และเฟรมเวิร์ก UI บนเทอร์มินัลอื่น ๆ
* [หนังสือ](https://gdt050579.github.io/AppCUI-rs/)
* [เอกสารประกอบ](https://docs.rs/appcui)
* [แกลเลอรี](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ คุณสมบัติ
- [x] คอนโทรลหลากหลายแบบพร้อมใช้งาน (ปุ่ม, ป้ายกำกับ, กล่องข้อความ, กล่องเช็ค, ปุ่มวิทยุ, รายการ, มุมมองต้นไม้, คอมโบ, ตัวเลือกวันที่/เวลา, ตัวเลือกสี, แท็บ, แอคคอร์เดียน ฯลฯ) ดูรายการทั้งหมด [ที่นี่](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] ระบบเลย์เอาต์ที่ทรงพลัง ให้คุณจัดตำแหน่งคอนโทรลด้วยค่าพิกัดแบบสัมบูรณ์ แบบสัมพันธ์ การ dock การจัดแนว anchor หรือ pivot (ดูเพิ่มเติม [ที่นี่](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] เมนูและทูลบาร์
- [x] รองรับหลายแพลตฟอร์ม (Windows ผ่าน API และ virtual terminal, Linux ผ่าน ncurses, macOS ผ่าน termios)
- [x] รองรับมัลติเธรดสำหรับงานพื้นหลัง
- [x] ตัวจับเวลา (timers)
- [x] รองรับเมาส์
- [x] รองรับคลิปบอร์ด
- [x] ธีมสี
- [x] รองรับอักขระ Unicode
- [x] ไดอะล็อกที่กำหนดไว้ล่วงหน้า (กล่องข้อความ, กล่องอินพุต, ตัวเลือกสี, กล่องเซฟ & เปิดไฟล์, ตัวนำทางโฟลเดอร์ ฯลฯ)
- [x] รองรับ True-color (24 บิตต่อพิกเซล) สำหรับเทอร์มินัลที่รองรับ

## 📸 ตัวอย่างภาพหน้าจอ

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **ดู [แกลเลอรี](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) สำหรับตัวอย่างเดโมของคอนโทรลทั้งหมด!**

## 🖥️ แบ็คเอนด์

AppCUI รองรับแบ็คเอนด์ที่หลากหลายขึ้นอยู่กับระบบปฏิบัติการ:

* **Windows Console** - อิงตาม Win32 low-level API ออกแบบมาสำหรับคอนโซล Windows แบบคลาสสิก
* **Windows VT** - อิงตาม ANSI sequences ออกแบบมาสำหรับ virtual terminal สมัยใหม่ของ Windows
* **NCurses** - อิงตาม NCurses API สำหรับสภาพแวดล้อม Linux
* **Termios** - อิงตาม ANSI sequences และ low-level APIs สำหรับ macOS
* **Web Terminal** - ออกแบบมาสำหรับการใช้งานบนเว็บ (อิงตาม WebGL)
* **CrossTerm** - อิงตาม crate `crossterm` เปิดใช้งานผ่าน feature flag

สามารถดูข้อมูลเพิ่มเติมเกี่ยวกับ backend ที่รองรับได้ [ที่นี่](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 เริ่มต้นอย่างรวดเร็ว

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
หรือเวอร์ชันที่กระชับกว่าด้วยการใช้ proc-macros:


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
จากนั้นให้รันโปรเจคด้วย `cargo run` คุณจะเห็นหน้าต่างที่มีชื่อว่า `Test` และข้อความ `Hello World !` อยู่ตรงกลาง

## 🧪 ตัวอย่าง

AppCUI-rs มาพร้อมกับชุดตัวอย่างเพื่อช่วยให้คุณเริ่มต้น คุณสามารถพบตัวอย่างเหล่านี้ได้ในโฟลเดอร์ [examples](examples) รวมถึง:
- **เกม** เช่น [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chess](examples/games/), [Connect Four](examples/games/), [2048](examples/games/), หรือ [Tetris](examples/games/)
- **เครื่องมือ** เช่น [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/), หรือ [Timer](examples/timer/)
- **แอนิเมชัน** เช่น [Matrix](examples/matrix/), [Fractals](examples/fractals/), หรือ [Spiral](examples/spiral/)
- **คอนโทรล**/**วิดเจ็ต** เช่น [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) และอีกมากมาย
- **ไดอะล็อก** เช่น [Notification](examples/notification_dialogs/) หรือ [Input](examples/input_dialog/)

## 🛠️ ตัวอย่างที่ซับซ้อนมากขึ้น

ตัวอย่างที่สร้างหน้าต่างพร้อมปุ่ม ซึ่งเมื่อกดปุ่มจะเพิ่มค่าตัวนับ


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

## 🛣️ แผนงาน

- [x] ชุดวิดเจ็ตพื้นฐานและรองรับ Windows, Linux และ macOS
- [x] รองรับ WebGL
- [ ] รองรับ OpenGL / SDL / Vulkan
- [ ] รองรับ TextArea สำหรับเน้นไวยากรณ์โค้ด

## 🤝 การมีส่วนร่วม

ยินดีต้อนรับการมีส่วนร่วม รายงานปัญหา และขอฟีเจอร์ใหม่!  
ดูรายละเอียดที่ [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) เพื่อเริ่มต้น

เข้าร่วมพูดคุยได้ที่ [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---