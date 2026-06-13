
<div align="right">
  <details>
    <summary>🌐 Bahasa</summary>
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

![Status Build Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Status Build Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Status Build macOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Cakupan Kode](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Lisensi](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galeri](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs adalah pustaka Rust yang cepat dan lintas platform untuk membangun antarmuka pengguna berbasis teks modern (TUI) dengan widget kaya, tema, dan dukungan Unicode penuh—sebuah alternatif untuk ncurses dan framework UI terminal lainnya.
* [Buku](https://gdt050579.github.io/AppCUI-rs/)
* [Dokumentasi](https://docs.rs/appcui)
* [Galeri](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Fitur
- [x] banyak kontrol siap pakai (tombol, label, kotak teks, check box, radio button, list view, tree view, combo box, pemilih tanggal/waktu, pemilih warna, tab, accordion, dll.). Daftar lengkap kontrol dapat ditemukan [di sini](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] sistem tata letak yang kuat yang memungkinkan Anda memposisikan kontrol menggunakan koordinat absolut, koordinat relatif, docking, alignment, anchor, atau pivot positioning (lihat lebih lanjut [di sini](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] menu dan toolbar
- [x] dukungan multi-platform (Windows via API dan virtual terminal, Linux via ncurses, macOS via termios)
- [x] dukungan multi-threading untuk menjalankan tugas di latar belakang
- [x] timer
- [x] dukungan mouse
- [x] dukungan clipboard
- [x] tema warna
- [x] dukungan karakter Unicode
- [x] dialog yang sudah tersedia (message box, input box, color picker, save & open dialog, folder navigator, dll.)
- [x] dukungan true-color (24 bit per piksel) untuk terminal yang mendukungnya.

## 📸 Tangkapan Layar

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Lihat [Galeri](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) untuk demo penuh dari semua kontrol!**

## 🖥️ Backend

AppCUI mendukung berbagai backend tergantung pada sistem operasi:

* **Windows Console** - berdasarkan Win32 low-level API, dirancang untuk konsol Windows klasik
* **Windows VT** - berdasarkan ANSI sequences, dirancang untuk virtual terminal Windows modern
* **NCurses** - berdasarkan NCurses API untuk lingkungan Linux
* **Termios** - berdasarkan ANSI sequences dan low-level API untuk macOS
* **Web Terminal** - dirancang untuk implementasi web (berbasis WebGL)
* **CrossTerm** - berdasarkan crate `crossterm`, diaktifkan melalui feature flag

Informasi lebih lanjut tentang backend yang didukung dapat ditemukan [di sini](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Mulai Cepat

Tambahkan berikut ini ke `Cargo.toml` Anda:

```toml
[dependencies]
appcui = "*"
```

Kemudian buat proyek Rust baru dan tambahkan kode berikut:

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

Atau versi yang lebih ringkas menggunakan proc-macros:

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

Kemudian jalankan proyek dengan `cargo run`. Anda akan melihat sebuah jendela dengan judul `Test` dan teks `Hello World !` di tengah.

## 🧪 Contoh

AppCUI-rs dilengkapi dengan beberapa contoh untuk membantu Anda memulai. Anda dapat menemukannya di folder [examples](examples), termasuk:
- **Permainan** seperti [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chess](examples/games/), [Connect Four](examples/games/), [2048](examples/games/), atau [Tetris](examples/games/)
- **Utilitas** seperti [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/), atau [Timer](examples/timer/)
- **Animasi** seperti [Matrix](examples/matrix/), [Fractals](examples/fractals/), atau [Spiral](examples/spiral/)
- **Kontrol**/**Widget** seperti [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) dan masih banyak lagi.
- **Dialog** seperti [Notification](examples/notification_dialogs/) atau [Input](examples/input_dialog/)

## 🛠️ Contoh yang lebih kompleks

Sebuah contoh yang membuat sebuah jendela dengan tombol yang, ketika ditekan, akan meningkatkan penghitung.

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

## 🛣️ Peta Jalan

- [x] Set widget dasar dan dukungan untuk Windows, Linux, dan macOS
- [x] Dukungan WebGL
- [ ] Dukungan OpenGL / SDL / Vulkan
- [ ] Dukungan TextArea untuk penyorotan kode

## 🤝 Kontribusi

Kontribusi, isu, dan permintaan fitur sangat diterima!  
Lihat [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) untuk memulai.

Bergabunglah dalam diskusi di [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---