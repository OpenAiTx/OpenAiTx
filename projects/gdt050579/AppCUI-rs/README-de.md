
<div align="right">
  <details>
    <summary>🌐 Sprache</summary>
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

![Windows Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![macOS Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Code Coverage](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![License](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs ist eine schnelle, plattformübergreifende Rust-Bibliothek zum Erstellen moderner, textbasierter Benutzeroberflächen (TUIs) mit umfangreichen Widgets, Themes und vollständiger Unicode-Unterstützung—eine Alternative zu ncurses und anderen Terminal-UI-Frameworks.
* [Buch](https://gdt050579.github.io/AppCUI-rs/)
* [Dokumentation](https://docs.rs/appcui)
* [Galerie](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Funktionen
- [x] zahlreiche sofort einsatzbereite Steuerelemente (Buttons, Labels, Textfelder, Kontrollkästchen, Optionsfelder, Listenansichten, Baumansichten, Kombinationsfelder, Datum-/Zeitwähler, Farbwähler, Registerkarten, Akkordeons usw.). Eine vollständige Liste der Steuerelemente finden Sie [hier](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] leistungsfähiges Layout-System, das die Platzierung von Steuerelementen mittels absoluter Koordinaten, relativer Koordinaten, Docking, Ausrichtung, Anker oder Pivot-Positionierung ermöglicht (siehe mehr [hier](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] Menüs und Werkzeugleisten
- [x] Multi-Plattform-Unterstützung (Windows via API und virtuellem Terminal, Linux via ncurses, macOS via termios)
- [x] Multi-Threading-Unterstützung für Hintergrundaufgaben
- [x] Timer
- [x] Mausunterstützung
- [x] Zwischenablage-Unterstützung
- [x] Farbthemen
- [x] Unterstützung für Unicode-Zeichen
- [x] vordefinierte Dialoge (Meldungsbox, Eingabebox, Farbwähler, Speichern & Öffnen Dialoge, Ordnernavigator usw.)
- [x] True-Color-Unterstützung (24 Bit pro Pixel) für Terminals, die dies unterstützen.

## 📸 Screenshots 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Schauen Sie sich die [Galerie](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) für vollständige Demos aller Steuerelemente an!**

## 🖥️ Backends

AppCUI unterstützt verschiedene Backends je nach Betriebssystem:

* **Windows-Konsole** – basierend auf der Win32 Low-Level-API, entwickelt für die klassische Windows-Konsole
* **Windows VT** – basierend auf ANSI-Sequenzen, entwickelt für moderne Windows-Virtual-Terminals
* **NCurses** – basierend auf der NCurses-API für Linux-Umgebungen
* **Termios** – basierend auf ANSI-Sequenzen und Low-Level-APIs für macOS
* **Web-Terminal** – entwickelt für Web-Implementierungen (basiert auf WebGL)
* **CrossTerm** – basiert auf dem `crossterm`-Crate, aktiviert über ein Feature-Flag

Weitere Informationen zu den unterstützten Backends finden Sie [hier](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Schnellstart

Fügen Sie Folgendes zu Ihrer `Cargo.toml` hinzu:

```toml
[dependencies]
appcui = "*"
```
Erstellen Sie dann ein neues Rust-Projekt und fügen Sie den folgenden Code hinzu:


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
Oder eine kompaktere Version unter Verwendung von Proc-Makros:


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

Führen Sie dann das Projekt mit `cargo run` aus. Sie sollten ein Fenster mit dem Titel `Test` und dem Text `Hello World !` in der Mitte sehen.

## 🧪 Beispiele

AppCUI-rs enthält eine Reihe von Beispielen, die Ihnen den Einstieg erleichtern. Sie finden sie im Ordner [examples](examples), darunter:
- **Spiele** wie [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Schach](examples/games/), [Vier Gewinnt](examples/games/), [2048](examples/games/) oder [Tetris](examples/games/)
- **Werkzeuge** wie [Rechner](examples/calculator/), [CSV-Viewer](examples/csv_viewer/), [Temperaturumwandler](examples/temperature_convertor/) oder ein [Timer](examples/timer/)
- **Animationen** wie [Matrix](examples/matrix/), [Fraktale](examples/fractals/) oder [Spirale](examples/spiral/)
- **Steuerelemente**/**Widgets** wie [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) und viele mehr.
- **Dialoge** wie [Benachrichtigung](examples/notification_dialogs/) oder [Eingabe](examples/input_dialog/)

## 🛠️ Ein komplexeres Beispiel

Ein Beispiel, das ein Fenster mit einem Button erstellt, der beim Drücken einen Zähler erhöht.

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

## 🛣️ Roadmap

- [x] Grundlegende Widgets und Unterstützung für Windows, Linux und macOS
- [x] WebGL-Unterstützung
- [ ] OpenGL- / SDL- / Vulkan-Unterstützung
- [ ] TextArea-Unterstützung für Code-Hervorhebung

## 🤝 Beitrag leisten

Beiträge, Probleme und Feature-Anfragen sind willkommen!  
Schau dir [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) an, um loszulegen.

Nimm an der Diskussion in [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions) teil.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---