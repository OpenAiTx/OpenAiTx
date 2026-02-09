
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

![Windows Derleme Durumu](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux Derleme Durumu](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS Derleme Durumu](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Kod Kapsamı](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Lisans](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galeri](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs; zengin araçlar, temalar ve tam Unicode desteği ile modern, metin tabanlı kullanıcı arayüzleri (TUI) oluşturmak için hızlı, çok platformlu bir Rust kütüphanesidir—ncurses ve diğer terminal UI çerçevelerine alternatif olarak kullanılabilir.
* [Kitap](https://gdt050579.github.io/AppCUI-rs/)
* [Dokümantasyon](https://docs.rs/appcui)
* [Galeri](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Özellikler
- [x] kutudan çıktığı gibi çoklu kontrol (butonlar, etiketler, metin kutuları, onay kutuları, radyo butonları, liste görünümleri, ağaç görünümleri, açılır kutular, tarih/saat seçiciler, renk seçiciler, sekmeler, akordeonlar, vb.). Tüm kontrol listesini [buradan](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) bulabilirsiniz
- [x] kontrolleri mutlak koordinatlar, göreli koordinatlar, dock, hizalama, sabitleyiciler veya pivot konumlandırma ile yerleştirmenizi sağlayan güçlü bir yerleşim sistemi (daha fazlası için [buraya bakın](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] menüler ve araç çubukları
- [x] çoklu platform desteği (Windows için API ve sanal terminal, Linux için ncurses, MacOS için termios)
- [x] arka plan görevleri için çoklu iş parçacığı desteği
- [x] zamanlayıcılar
- [x] fare desteği
- [x] panoya kopyalama desteği
- [x] renk temaları
- [x] Unicode karakterler için destek
- [x] önceden tanımlı diyaloglar (mesaj kutusu, giriş kutusu, renk seçici, kaydet & aç diyalogları, klasör gezgini vb.)
- [x] bunu destekleyen terminallerde gerçek renk desteği (piksel başına 24 bit).

## 📸 Ekran Görüntüleri

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Tüm kontrol demoları için [Galeriye](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) göz atın!**

## 🖥️ Arka Uçlar

AppCUI, kullanıldığı işletim sistemine bağlı olarak çeşitli arka uçları destekler:

* **Windows Konsolu** - Win32 düşük seviyeli API'ye dayalı, klasik Windows konsolu için tasarlanmıştır
* **Windows VT** - ANSI dizilerine dayalı, modern Windows sanal terminalleri için tasarlanmıştır
* **NCurses** - Linux ortamları için NCurses API'ye dayalıdır
* **Termios** - MAC OSX için ANSI dizileri ve düşük seviyeli API'lere dayalıdır
* **Web Terminali** - Web uygulamaları için tasarlanmıştır (webgl tabanlı)
* **CrossTerm** - `crossterm` crate'ine dayalıdır, ancak bir özellik bayrağı ile etkinleştirilir

Desteklenen arka uçlar hakkında daha fazla bilgiye [buradan](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html) ulaşabilirsiniz


## 🚀 Hızlı Başlangıç

Aşağıdakini `Cargo.toml` dosyanıza ekleyin:

```toml
[dependencies]
appcui = "*"
```

Daha sonra yeni bir Rust projesi oluşturun ve aşağıdaki kodu ekleyin:

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

veya proc-macros kullanarak daha kompakt bir sürüm:

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

Ardından projeyi `cargo run` komutuyla çalıştırın. Merkezde `Hello World !` yazısı ve başlığı `Test` olan bir pencere görmelisiniz.

## 🧪 Örnekler

AppCUI-rs, başlamanıza yardımcı olacak bir dizi örnekle birlikte gelir. [examples](examples) klasöründe şunları bulabilirsiniz:
- [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) veya [Tetris](examples/games/) gibi **Oyunlar**
- [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/) veya bir [Timer](examples/timer/) gibi **Araçlar**
- [Matrix](examples/matrix/), [Fractals](examples/fractals/) veya [Spiral](examples/spiral/) gibi **Animasyonlar**
- [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) ve çok daha fazlası gibi **Kontroller**/**Bileşenler**
- [Notification](examples/notification_dialogs/) veya [Input](examples/input_dialog/) gibi **Diyaloglar**

## 🛠️ Daha karmaşık bir örnek

Bir butona basıldığında bir sayacı artıran bir pencere oluşturan bir örnek.

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

## 🛣️ Yol Haritası

- [x] Temel widget seti ve Windows, Linux ile MacOS desteği
- [x] WebGL desteği
- [ ] OpenGL / SDL / Vulkan desteği
- [ ] Kod vurgulama için TextArea desteği

## 🤝 Katkı Sağlama

Katkılar, sorunlar ve özellik talepleri memnuniyetle karşılanır!  
Başlamak için [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) dosyasına göz atın.

[GitHub Tartışmaları](https://github.com/gdt050579/AppCUI-rs/discussions) bölümünde tartışmalara katılın.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---