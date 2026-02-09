
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
![Estado de la compilación en Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Estado de la compilación en Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Estado de la compilación en MacOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Cobertura de código](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Licencia](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galería](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs es una biblioteca rápida y multiplataforma en Rust para construir interfaces de usuario modernas basadas en texto (TUIs) con widgets ricos, temas y soporte completo para Unicode—una alternativa a ncurses y otros frameworks de UI para terminal.
* [Libro](https://gdt050579.github.io/AppCUI-rs/)
* [Documentación](https://docs.rs/appcui)
* [Galería](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Características
- [x] múltiples controles listos para usar (botones, etiquetas, cuadros de texto, casillas de verificación, botones de opción, vistas de lista, vistas de árbol, cuadros combinados, selectores de fecha/hora, selectores de color, pestañas, acordeones, etc.). Una lista completa de controles se puede encontrar [aquí](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] sistema potente de diseño que permite posicionar controles usando coordenadas absolutas, coordenadas relativas, acoplamiento, alineación, anclajes o posicionamiento por pivote (ver más [aquí](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] menús y barras de herramientas
- [x] soporte multiplataforma (Windows vía API y terminal virtual, Linux vía ncurses, MacOS vía termios)
- [x] soporte para multihilo para permitir tareas en segundo plano
- [x] temporizadores
- [x] soporte para ratón
- [x] soporte para portapapeles
- [x] temas de color
- [x] soporte para caracteres Unicode
- [x] diálogos predefinidos (cuadro de mensaje, cuadro de entrada, selector de color, diálogos de guardar y abrir, navegador de carpetas, etc)
- [x] soporte para colores verdaderos (24 bits por píxel) para terminales que lo soportan.

## 📸 Capturas de pantalla

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **¡Consulta la [Galería](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) para demos completas de todos los controles!**

## 🖥️ Backends

AppCUI soporta varios backends según el sistema operativo para el que se esté usando:


* **Consola de Windows** - basada en la API de bajo nivel Win32, diseñada para la consola clásica de Windows
* **Windows VT** - basada en secuencias ANSI, diseñada para terminales virtuales modernas de Windows
* **NCurses** - basada en la API NCurses para entornos Linux
* **Termios** - basada en secuencias ANSI y APIs de bajo nivel para MAC OSX
* **Terminal Web** - diseñada para implementación web (basada en webgl)
* **CrossTerm** - basada en la crate `crossterm`, pero activada mediante una bandera de característica

Más información sobre los backends soportados se puede encontrar [aquí](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Inicio rápido

Agrega lo siguiente a tu `Cargo.toml`:

```toml
[dependencies]
appcui = "*"
```

Luego crea un nuevo proyecto Rust y añade el siguiente código:

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

o una versión más compacta usando proc-macros:

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

Luego ejecuta el proyecto con `cargo run`. Deberías ver una ventana con el título `Test` y el texto `Hello World !` en el centro.

## 🧪 Ejemplos

AppCUI-rs viene con un conjunto de ejemplos para ayudarte a comenzar. Puedes encontrarlos en la carpeta [examples](examples), incluyendo:
- **Juegos** como [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) o [Tetris](examples/games/)
- **Utilidades** como [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/) o un [Timer](examples/timer/)
- **Animaciones** como [Matrix](examples/matrix/), [Fractals](examples/fractals/) o [Spiral](examples/spiral/)
- **Controles**/**Widgets** como [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) y muchos más.
- **Diálogos** como [Notification](examples/notification_dialogs/) o [Input](examples/input_dialog/)

## 🛠️ Un ejemplo más complejo

Un ejemplo que crea una ventana con un botón que al ser presionado aumenta un contador.

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

## 🛣️ Hoja de ruta

- [x] Conjunto básico de widgets y soporte para Windows, Linux y MacOS
- [x] Soporte WebGL
- [ ] Soporte OpenGL / SDL / Vulkan
- [ ] Soporte TextArea para resaltado de código

## 🤝 Contribuciones

¡Se aceptan contribuciones, problemas y solicitudes de funciones!  
Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) para comenzar.

Únete a la discusión en [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---