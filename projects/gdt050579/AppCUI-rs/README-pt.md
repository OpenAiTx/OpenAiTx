
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

![Status de Build do Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Status de Build do Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Status de Build do MacOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Cobertura de Código](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Licença](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galeria](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs é uma biblioteca Rust rápida e multiplataforma para construir interfaces de usuário modernas baseadas em texto (TUIs) com widgets ricos, temas e suporte total a Unicode—uma alternativa ao ncurses e outros frameworks de UI para terminal.
* [Livro](https://gdt050579.github.io/AppCUI-rs/)
* [Documentação](https://docs.rs/appcui)
* [Galeria](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Funcionalidades
- [x] múltiplos controles prontos para uso (botões, rótulos, caixas de texto, caixas de seleção, botões de rádio, listas, árvores, combos, seletores de data/hora, seletores de cor, abas, acordeões, etc.). Uma lista completa de controles pode ser encontrada [aqui](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)
- [x] sistema de layout poderoso que permite posicionar controles usando coordenadas absolutas, relativas, dock, alinhamento, âncoras ou posicionamento por pivô (veja mais [aqui](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] menus e barras de ferramentas
- [x] suporte multiplataforma (Windows via API e terminal virtual, Linux via ncurses, MacOS via termios)
- [x] suporte a multi-threading para tarefas em segundo plano
- [x] timers
- [x] suporte a mouse
- [x] suporte a área de transferência
- [x] temas de cores
- [x] suporte a caracteres Unicode
- [x] diálogos predefinidos (caixa de mensagem, caixa de entrada, seletor de cor, diálogos de salvar & abrir, navegador de pastas, etc)
- [x] suporte a cores reais (24 bits por pixel) para terminais compatíveis.

## 📸 Capturas de Tela 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Confira a [Galeria](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) para demonstrações completas de todos os controles!**

## 🖥️ Backends

AppCUI suporta vários backends baseados no sistema operacional em que está sendo utilizado:

* **Console do Windows** - baseado na API de baixo nível Win32, projetado para o console clássico do Windows
* **Windows VT** - baseado em sequências ANSI, projetado para terminais virtuais modernos do Windows
* **NCurses** - baseado na API NCurses para ambientes Linux
* **Termios** - baseado em sequências ANSI e APIs de baixo nível para MAC OSX
* **Terminal Web** - projetado para implementação na Web (baseado em webgl)
* **CrossTerm** - baseado no crate `crossterm`, mas habilitado via uma flag de recurso

Mais informações sobre os backends suportados podem ser encontradas [aqui](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Início Rápido

Adicione o seguinte ao seu `Cargo.toml`:

```toml
[dependencies]
appcui = "*"
```
Em seguida, crie um novo projeto Rust e adicione o seguinte código:


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
ou uma versão mais compacta usando proc-macros:


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

Em seguida, execute o projeto com `cargo run`. Você deverá ver uma janela com o título `Test` e o texto `Hello World !` no centro.

## 🧪 Exemplos

O AppCUI-rs vem com um conjunto de exemplos para ajudá-lo a começar. Você pode encontrá-los na pasta [examples](examples), incluindo:
- **Jogos** como [Jogo da Velha](examples/tic-tac-toe/), [Cobra](examples/snake/), [Flappy Bird](examples/flappy), [Campo Minado](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) ou [Tetris](examples/games/)
- **Utilitários** como [Calculadora](examples/calculator/), [Visualizador de CSV](examples/csv_viewer/), [Conversor de Temperatura](examples/temperature_convertor/) ou um [Timer](examples/timer/)
- **Animações** como [Matrix](examples/matrix/), [Fractais](examples/fractals/) ou [Espiral](examples/spiral/)
- **Controles**/**Widgets** como [Botão](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) e muitos outros.
- **Diálogos** como [Notificação](examples/notification_dialogs/) ou [Entrada](examples/input_dialog/)

## 🛠️ Um exemplo mais complexo

Um exemplo que cria uma janela com um botão que, quando pressionado, aumenta um contador.

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

## 🛣️ Roteiro

- [x] Conjunto básico de widgets e suporte para Windows, Linux e MacOS
- [x] Suporte a WebGL
- [ ] Suporte a OpenGL / SDL / Vulkan
- [ ] Suporte a TextArea para destaque de código

## 🤝 Contribuindo

Contribuições, problemas e solicitações de recursos são bem-vindos!  
Confira [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) para começar.

Participe da discussão em [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---