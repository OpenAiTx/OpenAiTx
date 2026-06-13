
<div align="right">
  <details>
    <summary>🌐 Język</summary>
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

![Status kompilacji Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Status kompilacji Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Status kompilacji macOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Pokrycie kodu](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Licencja](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galeria](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs to szybka, wieloplatformowa biblioteka w języku Rust do budowania nowoczesnych, tekstowych interfejsów użytkownika (TUI) z bogatymi widżetami, motywami oraz pełnym wsparciem Unicode — alternatywa dla ncurses i innych frameworków UI terminala.
* [Książka](https://gdt050579.github.io/AppCUI-rs/)
* [Dokumentacja](https://docs.rs/appcui)
* [Galeria](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Funkcje
- [x] wiele gotowych do użycia kontrolek (przyciski, etykiety, pola tekstowe, pola wyboru, przyciski radiowe, listy, drzewa, listy rozwijane, wybieraki daty/czasu, wybieraki kolorów, zakładki, akordeony itd.). Pełna lista kontrolek znajduje się [tutaj](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] potężny system układu pozwalający pozycjonować kontrolki za pomocą współrzędnych absolutnych, względnych, dokowania, wyrównania, kotwic lub pozycji pivot (więcej [tutaj](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] menu i paski narzędzi
- [x] wsparcie wielu platform (Windows przez API i wirtualny terminal, Linux przez ncurses, macOS przez termios)
- [x] wsparcie wielowątkowości dla zadań w tle
- [x] timery
- [x] obsługa myszy
- [x] obsługa schowka
- [x] motywy kolorystyczne
- [x] obsługa znaków Unicode
- [x] predefiniowane okna dialogowe (okno komunikatu, okno wprowadzania, wybierak kolorów, okna zapisu i otwierania, nawigator folderów itd.)
- [x] wsparcie true-color (24 bity na piksel) dla terminali, które to obsługują.

## 📸 Zrzuty ekranu

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Zobacz [Galerię](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) po pełne dema wszystkich kontrolek!**

## 🖥️ Backend'y

AppCUI obsługuje różne backendy w zależności od systemu operacyjnego:

* **Windows Console** - oparty na niskopoziomowym API Win32, zaprojektowany dla klasycznego konsoli Windows
* **Windows VT** - oparty na sekwencjach ANSI, zaprojektowany dla nowoczesnych wirtualnych terminali Windows
* **NCurses** - oparty na API NCurses dla środowisk Linux
* **Termios** - oparty na sekwencjach ANSI i niskopoziomowych API dla macOS
* **Web Terminal** - zaprojektowany dla implementacji webowych (oparty na WebGL)
* **CrossTerm** - oparty na bibliotece `crossterm`, aktywowany poprzez flagę funkcji

Więcej o obsługiwanych backendach znajdziesz [tutaj](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Szybki start

Dodaj poniższe do swojego pliku `Cargo.toml`:

```toml
[dependencies]
appcui = "*"
```
Następnie utwórz nowy projekt w języku Rust i dodaj poniższy kod:


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

Lub bardziej kompaktowa wersja z użyciem proc-makrosów:

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

Następnie uruchom projekt poleceniem `cargo run`. Powinno pojawić się okno z tytułem `Test` i tekstem `Hello World !` na środku.

## 🧪 Przykłady

AppCUI-rs zawiera zestaw przykładów, które pomogą Ci rozpocząć pracę. Znajdziesz je w folderze [examples](examples), w tym:
- **Gry** takie jak [Kółko-krzyżyk](examples/tic-tac-toe/), [Wąż](examples/snake/), [Flappy Bird](examples/flappy), [Saper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Szachy](examples/games/), [Connect Four](examples/games/), [2048](examples/games/), czy [Tetris](examples/games/)
- **Narzędzia** takie jak [Kalkulator](examples/calculator/), [Przeglądarka CSV](examples/csv_viewer/), [Konwerter temperatury](examples/temperature_convertor/), czy [Stoper](examples/timer/)
- **Animacje** takie jak [Matrix](examples/matrix/), [Fraktale](examples/fractals/), czy [Spirala](examples/spiral/)
- **Kontrolki**/**Widgety** takie jak [Przycisk](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) i wiele innych.
- **Dialogi** takie jak [Powiadomienie](examples/notification_dialogs/) czy [Wejście](examples/input_dialog/)

## 🛠️ Bardziej złożony przykład

Przykład, który tworzy okno z przyciskiem, który po naciśnięciu zwiększa licznik.

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

## 🛣️ Plan działania

- [x] Podstawowy zestaw widgetów oraz wsparcie dla Windows, Linux i macOS
- [x] Wsparcie WebGL
- [ ] Wsparcie OpenGL / SDL / Vulkan
- [ ] Obsługa TextArea z podświetlaniem składni

## 🤝 Współpraca

Wkład, zgłoszenia problemów i propozycje nowych funkcji są mile widziane!  
Zajrzyj do [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md), aby rozpocząć.

Dołącz do dyskusji na [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---