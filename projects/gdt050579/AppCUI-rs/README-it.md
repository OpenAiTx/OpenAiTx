
<div align="right">
  <details>
    <summary>🌐 Lingua</summary>
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

![Stato Build Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Stato Build Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Stato Build macOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Copertura del Codice](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Licenza](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs è una veloce libreria Rust multipiattaforma per creare interfacce utente testuali (TUI) moderne, con widget avanzati, temi e pieno supporto Unicode—un'alternativa a ncurses e ad altri framework UI per terminale.
* [Libro](https://gdt050579.github.io/AppCUI-rs/)
* [Documentazione](https://docs.rs/appcui)
* [Galleria](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Funzionalità
- [x] numerosi controlli pronti all'uso (bottoni, etichette, caselle di testo, checkbox, radio button, list view, tree view, combo box, selettori data/ora, selettori colore, tab, accordion, ecc.). Un elenco completo dei controlli è disponibile [qui](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] potente sistema di layout che consente di posizionare i controlli tramite coordinate assolute, relative, docking, allineamento, ancoraggi o posizionamento pivot (vedi di più [qui](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] menu e barre degli strumenti
- [x] supporto multipiattaforma (Windows tramite API e terminale virtuale, Linux tramite ncurses, macOS tramite termios)
- [x] supporto multithreading per permettere task in background
- [x] timer
- [x] supporto mouse
- [x] supporto clipboard
- [x] temi colore
- [x] supporto caratteri Unicode
- [x] dialoghi predefiniti (message box, input box, selettore colore, finestre di salvataggio/apertura, navigatore cartelle, ecc.)
- [x] supporto true-color (24 bit per pixel) per i terminali che lo supportano.

## 📸 Screenshot 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Dai un'occhiata alla [Galleria](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) per demo complete di tutti i controlli!**

## 🖥️ Backend

AppCUI supporta diversi backend a seconda del sistema operativo:

* **Console di Windows** - basata sull'API low-level Win32, progettata per la console classica di Windows
* **Windows VT** - basata su sequenze ANSI, progettata per i terminali virtuali moderni di Windows
* **NCurses** - basata sull'API NCurses per ambienti Linux
* **Termios** - basata su sequenze ANSI e API low-level per macOS
* **Web Terminale** - progettata per implementazioni web (basata su WebGL)
* **CrossTerm** - basata sul crate `crossterm`, abilitata tramite un feature flag

Maggiori informazioni sui backend supportati sono disponibili [qui](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Avvio rapido

Aggiungi quanto segue al tuo `Cargo.toml`:

```toml
[dependencies]
appcui = "*"
```

Quindi crea un nuovo progetto Rust e aggiungi il seguente codice:

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

Oppure una versione più compatta utilizzando proc-macro:

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

Quindi esegui il progetto con `cargo run`. Dovresti vedere una finestra con il titolo `Test` e il testo `Hello World !` al centro.

## 🧪 Esempi

AppCUI-rs include una serie di esempi per aiutarti a iniziare. Puoi trovarli nella cartella [examples](examples), tra cui:
- **Giochi** come [Tris](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Prato fiorito](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Scacchi](examples/games/), [Forza Quattro](examples/games/), [2048](examples/games/), o [Tetris](examples/games/)
- **Utility** come [Calcolatrice](examples/calculator/), [Visualizzatore CSV](examples/csv_viewer/), [Convertitore di temperatura](examples/temperature_convertor/), o un [Timer](examples/timer/)
- **Animazioni** come [Matrix](examples/matrix/), [Frattali](examples/fractals/), o [Spirale](examples/spiral/)
- **Controlli**/**Widget** come [Bottone](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) e molti altri.
- **Finestre di dialogo** come [Notifica](examples/notification_dialogs/) o [Input](examples/input_dialog/)

## 🛠️ Un esempio più complesso

Un esempio che crea una finestra con un pulsante che, quando premuto, incrementa un contatore.

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

## 🛣️ Tabella di marcia

- [x] Set di widget di base e supporto per Windows, Linux e macOS
- [x] Supporto WebGL
- [ ] Supporto OpenGL / SDL / Vulkan
- [ ] Supporto TextArea per evidenziazione del codice

## 🤝 Contribuire

Contributi, segnalazioni e richieste di funzionalità sono benvenuti!  
Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) per iniziare.

Unisciti alla discussione su [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---