
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

![حالة البناء على ويندوز](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![حالة البناء على لينكس](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![حالة البناء على ماك أو إس](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![تغطية الشيفرة](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![الرخصة](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![المعرض](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs هي مكتبة Rust سريعة ومتعددة المنصات لبناء واجهات مستخدم حديثة قائمة على النصوص (TUIs) مع عناصر واجهة غنية ومواضيع ودعم كامل لـ Unicode—بديل لـ ncurses وأطر واجهات الطرفية الأخرى.
* [الكتاب](https://gdt050579.github.io/AppCUI-rs/)
* [التوثيق](https://docs.rs/appcui)
* [المعرض](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ الميزات
- [x] عناصر تحكم جاهزة متعددة (أزرار، تسميات، صناديق نصية، صناديق اختيار، أزرار اختيار، قوائم، شجرات، قوائم منسدلة، منتقيات تاريخ/وقت، منتقيات ألوان، تبويبات، أكورديونات، إلخ). القائمة الكاملة لعناصر التحكم يمكن العثور عليها [هنا](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] نظام تخطيط قوي يسمح لك بترتيب العناصر باستخدام إحداثيات مطلقة، نسبية، إرساء، محاذاة، نقاط ارتكاز أو تموضع محوري (اطلع على المزيد [هنا](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] قوائم وأشرطة أدوات
- [x] دعم متعدد المنصات (ويندوز عبر API والطرفية الافتراضية، لينكس عبر ncurses، ماك أو إس عبر termios)
- [x] دعم للتعددية في المعالجة للسماح بالمهام الخلفية
- [x] مؤقتات
- [x] دعم للفأرة
- [x] دعم للحافظة
- [x] مواضيع ألوان
- [x] دعم لحروف الـ Unicode
- [x] حوارات معرفة مسبقًا (صندوق رسائل، صندوق إدخال، منتقي ألوان، حوارات حفظ وفتح، مستعرض مجلدات، إلخ)
- [x] دعم الألوان الحقيقية (24 بت لكل بكسل) للطرفيات التي تدعمها.

## 📸 لقطات شاشة 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **اطلع على [المعرض](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) لمشاهدة عروض كاملة لجميع العناصر!**

## 🖥️ الأنظمة الخلفية

يدعم AppCUI العديد من الأنظمة الخلفية حسب نظام التشغيل المستخدم:

* **كونسول ويندوز** - يعتمد على واجهة برمجة التطبيقات Win32 منخفضة المستوى، مصمم للكونسول الكلاسيكي في ويندوز
* **ويندوز VT** - يعتمد على تسلسل ANSI، مصمم للمحطات الافتراضية الحديثة في ويندوز
* **NCurses** - يعتمد على واجهة برمجة تطبيقات NCurses لبيئات لينكس
* **Termios** - يعتمد على تسلسلات ANSI وواجهات برمجة التطبيقات منخفضة المستوى لنظام MAC OSX
* **ويب تيرمينال** - مصمم للتنفيذ على الويب (معتمد على webgl)
* **CrossTerm** - يعتمد على مكتبة `crossterm`، ويتم تفعيله عبر علم خاص بالميزات

يمكنك معرفة المزيد حول الأنظمة الخلفية المدعومة من خلال [هذا الرابط](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 البداية السريعة

أضف ما يلي إلى ملف `Cargo.toml` الخاص بك:

```toml
[dependencies]
appcui = "*"
```

ثم أنشئ مشروع Rust جديد وأضف الكود التالي:

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
أو نسخة أكثر إحكامًا باستخدام وحدات الماكرو الإجرائية:


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

ثم قم بتشغيل المشروع باستخدام الأمر `cargo run`. يجب أن تظهر نافذة بعنوان `Test` ونص `Hello World !` في الوسط.

## 🧪 أمثلة

يأتي AppCUI-rs مع مجموعة من الأمثلة لمساعدتك على البدء. يمكنك العثور عليها في مجلد [examples](examples)، بما في ذلك:
- **الألعاب** مثل [Tic Tac Toe](examples/tic-tac-toe/)، [Snake](examples/snake/)، [Flappy Bird](examples/flappy)، [Minesweeper](examples/minesweeper/)، [Ram it](examples/ramit/)، [PacMan](examples/games/)، [Chees](examples/games/)، [Connect Four](examples/games/)، [2048](examples/games/) أو [Tetris](examples/games/)
- **الأدوات** مثل [Calculator](examples/calculator/)، [CSV Viewer](examples/csv_viewer/)، [Temperature Converter](examples/temperature_convertor/) أو [Timer](examples/timer/)
- **الرسوم المتحركة** مثل [Matrix](examples/matrix/)، [Fractals](examples/fractals/) أو [Spiral](examples/spiral/)
- **عناصر التحكم**/**الحاجيات** مثل [Button](examples/buttons/)، [CheckBox](examples/checkboxes/)، [ComboBox](examples/combobox/)، [DatePicker](examples/datepicker/)، [ListView](examples/listview/)، [TreeView](examples/treeview/) والمزيد.
- **الحوارات** مثل [Notification](examples/notification_dialogs/) أو [Input](examples/input_dialog/)

## 🛠️ مثال أكثر تعقيداً

مثال ينشئ نافذة تحتوي على زر، وعند الضغط عليه يزيد عداداً.

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

## 🛣️ خارطة الطريق

- [x] مجموعة أساسية من العناصر ودعم لأنظمة ويندوز، لينكس وماك أو إس
- [x] دعم WebGL
- [ ] دعم OpenGL / SDL / Vulkan
- [ ] دعم TextArea لإبراز الشيفرة

## 🤝 المساهمة

المساهمات، والمشكلات، وطلبات الميزات مرحب بها!  
اطلع على [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) للبدء.

انضم للنقاش في [مناقشات GitHub](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---