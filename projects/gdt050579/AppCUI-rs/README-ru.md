
<div align="right">
  <details>
    <summary>🌐 Язык</summary>
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

![Статус сборки Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Статус сборки Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Статус сборки macOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Покрытие кода](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Лицензия](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Галерея](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs — это быстрая кроссплатформенная библиотека Rust для создания современных текстовых пользовательских интерфейсов (TUI) с богатыми виджетами, темами и полной поддержкой Unicode — альтернатива ncurses и другим фреймворкам терминальных интерфейсов.
* [Книга](https://gdt050579.github.io/AppCUI-rs/)
* [Документация](https://docs.rs/appcui)
* [Галерея](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Возможности
- [x] множество готовых контролов (кнопки, метки, текстовые поля, чекбоксы, радиокнопки, списки, деревья, комбобоксы, выбор даты/времени, выбор цвета, вкладки, аккордеоны и т.д.). Полный список контролов доступен [здесь](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] мощная система компоновки, позволяющая размещать элементы с помощью абсолютных координат, относительных координат, докинга, выравнивания, якорей или позиционирования по точке опоры (подробнее [здесь](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] меню и панели инструментов
- [x] поддержка нескольких платформ (Windows через API и виртуальный терминал, Linux через ncurses, macOS через termios)
- [x] поддержка многопоточности для фоновых задач
- [x] таймеры
- [x] поддержка мыши
- [x] поддержка буфера обмена
- [x] цветовые темы
- [x] поддержка символов Unicode
- [x] предопределённые диалоги (сообщение, ввод, выбор цвета, диалоги открытия/сохранения, навигатор папок и др.)
- [x] поддержка true-color (24 бита на пиксель) для терминалов, поддерживающих это.

## 📸 Скриншоты 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Посмотрите [Галерею](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) для полноценных демонстраций всех контролов!**

## 🖥️ Бэкенды

AppCUI поддерживает различные бэкенды в зависимости от операционной системы:

* **Windows Console** - основан на низкоуровневом Win32 API, предназначен для классической консоли Windows
* **Windows VT** - основан на ANSI-последовательностях, предназначен для современных виртуальных терминалов Windows
* **NCurses** - основан на API NCurses для Linux-сред
* **Termios** - основан на ANSI-последовательностях и низкоуровневых API для macOS
* **Web Terminal** - предназначен для веб-реализаций (основан на WebGL)
* **CrossTerm** - основан на библиотеке `crossterm`, активируется через feature-флаг

Подробнее о поддерживаемых бэкендах можно узнать [здесь](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Быстрый старт

Добавьте следующее в ваш `Cargo.toml`:

```toml
[dependencies]
appcui = "*"
```
Затем создайте новый проект Rust и добавьте следующий код:


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

Или более компактная версия с использованием proc-macros:

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

Затем запустите проект с помощью `cargo run`. Вы должны увидеть окно с заголовком `Test` и текстом `Hello World !` в центре.

## 🧪 Примеры

AppCUI-rs поставляется с набором примеров, чтобы помочь вам начать работу. Вы можете найти их в папке [examples](examples), включая:
- **Игры** такие как [Крестики-нолики](examples/tic-tac-toe/), [Змейка](examples/snake/), [Flappy Bird](examples/flappy), [Сапёр](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Шахматы](examples/games/), [Connect Four](examples/games/), [2048](examples/games/), или [Тетрис](examples/games/)
- **Утилиты** такие как [Калькулятор](examples/calculator/), [CSV Просмотрщик](examples/csv_viewer/), [Конвертер температуры](examples/temperature_convertor/), или [Таймер](examples/timer/)
- **Анимации** такие как [Матрица](examples/matrix/), [Фракталы](examples/fractals/), или [Спираль](examples/spiral/)
- **Элементы управления**/**Виджеты** такие как [Кнопка](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) и многое другое.
- **Диалоги** такие как [Уведомление](examples/notification_dialogs/) или [Ввод](examples/input_dialog/)

## 🛠️ Более сложный пример

Пример, который создает окно с кнопкой, при нажатии на которую увеличивается счетчик.

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

## 🛣️ Дорожная карта

- [x] Базовый набор виджетов и поддержка Windows, Linux и macOS
- [x] Поддержка WebGL
- [ ] Поддержка OpenGL / SDL / Vulkan
- [ ] Поддержка TextArea для подсветки кода

## 🤝 Вклад

Вклады, сообщения об ошибках и предложения по функциям приветствуются!  
Ознакомьтесь с [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md), чтобы начать.

Присоединяйтесь к обсуждению в [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---