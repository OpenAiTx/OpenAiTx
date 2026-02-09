<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

![Windows बिल्ड स्टेटस](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux बिल्ड स्टेटस](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS बिल्ड स्टेटस](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![कोड कवरेज](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![लाइसेंस](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![गैलरी](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs एक तेज़, क्रॉस-प्लेटफ़ॉर्म Rust लाइब्रेरी है, जो आधुनिक, टेक्स्ट-आधारित यूजर इंटरफेस (TUI) बनाने के लिए समृद्ध विजेट्स, थीम्स और पूर्ण यूनिकोड समर्थन प्रदान करती है—यह ncurses और अन्य टर्मिनल UI फ्रेमवर्क का एक विकल्प है।
* [पुस्तक](https://gdt050579.github.io/AppCUI-rs/)
* [प्रलेखन](https://docs.rs/appcui)
* [गैलरी](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ विशेषताएं
- [x] कई इनबिल्ट कंट्रोल्स (बटन, लेबल, टेक्स्ट बॉक्स, चेक बॉक्स, रेडियो बटन, लिस्ट व्यू, ट्री व्यू, कॉम्बो बॉक्स, डेट/टाइम पिकर, कलर पिकर, टैब्स, एकॉर्डियन्स, आदि)। सभी कंट्रोल्स की पूरी सूची [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) देख सकते हैं
- [x] शक्तिशाली लेआउट सिस्टम जो आपको कंट्रोल्स को absolute coordinates, relative coordinates, docking, alignment, anchors या pivot positioning द्वारा स्थान देने की अनुमति देता है (अधिक जानकारी [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html))
- [x] मेनू और टूलबार
- [x] मल्टी-प्लेटफ़ॉर्म सपोर्ट (Windows API और वर्चुअल टर्मिनल, Linux ncurses के माध्यम से, MacOS termios के माध्यम से)
- [x] मल्टी-थ्रेडिंग सपोर्ट ताकि बैकग्राउंड टास्क संभव हो
- [x] टाइमर
- [x] माउस सपोर्ट
- [x] क्लिपबोर्ड सपोर्ट
- [x] कलर थीम्स
- [x] यूनिकोड कैरेक्टर्स का समर्थन
- [x] पूर्वनिर्धारित डायलॉग्स (मैसेज बॉक्स, इनपुट बॉक्स, कलर पिकर, सेव एवं ओपन डायलॉग्स, फोल्डर नेविगेटर, आदि)
- [x] टर्मिनल में True Colors सपोर्ट (24 बिट्स प्रति पिक्सल), जहाँ उपलब्ध हो।

## 📸 स्क्रीनशॉट्स 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **[गैलरी](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) में सभी कंट्रोल्स के पूर्ण डेमो देखें!**

## 🖥️ बैकएंड्स

AppCUI विभिन्न ऑपरेटिंग सिस्टम के अनुसार विभिन्न बैकएंड्स का समर्थन करता है:

* **Windows Console** - Win32 लो-लेवल API पर आधारित, क्लासिकल विंडोज़ कंसोल के लिए डिज़ाइन किया गया
* **Windows VT** - ANSI अनुक्रमों पर आधारित, आधुनिक विंडोज़ वर्चुअल टर्मिनल्स के लिए डिज़ाइन किया गया
* **NCurses** - लिनक्स वातावरण के लिए NCurses API पर आधारित
* **Termios** - ANSI अनुक्रमों और MAC OSX के लिए लो-लेवल APIs पर आधारित
* **Web Terminal** - वेब इम्प्लीमेंटेशन के लिए डिज़ाइन किया गया (webgl पर आधारित)
* **CrossTerm** - `crossterm` क्रेट पर आधारित, लेकिन फीचर फ्लैग के माध्यम से सक्षम किया गया

समर्थित बैकएंड्स के बारे में अधिक जानकारी [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html) पाई जा सकती है


## 🚀 त्वरित शुरुआत

अपने `Cargo.toml` में निम्नलिखित जोड़ें:

```toml
[dependencies]
appcui = "*"
```
फिर एक नया Rust प्रोजेक्ट बनाएं और निम्नलिखित कोड जोड़ें:


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
या प्रोसीजरल मैक्रो का उपयोग करते हुए एक और संक्षिप्त संस्करण:


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
फिर प्रोजेक्ट को `cargo run` के साथ चलाएँ। आपको एक विंडो दिखाई देगी जिसका शीर्षक `Test` होगा और केंद्र में `Hello World !` लिखा होगा।

## 🧪 उदाहरण

AppCUI-rs के साथ शुरुआत करने में मदद के लिए एक उदाहरणों का सेट आता है। आप इन्हें [examples](examples) फ़ोल्डर में पा सकते हैं, जिनमें शामिल हैं:
- **गेम्स** जैसे [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Minesweeper](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Connect Four](examples/games/), [2048](examples/games/) या [Tetris](examples/games/)
- **उपयोगिताएँ** जैसे [Calculator](examples/calculator/), [CSV Viewer](examples/csv_viewer/), [Temperature Converter](examples/temperature_convertor/) या [Timer](examples/timer/)
- **एनिमेशन** जैसे [Matrix](examples/matrix/), [Fractals](examples/fractals/) या [Spiral](examples/spiral/)
- **नियंत्रण**/**विजेट्स** जैसे [Button](examples/buttons/), [CheckBox](examples/checkboxes/), [ComboBox](examples/combobox/), [DatePicker](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) और भी बहुत कुछ।
- **डायालॉग्स** जैसे [Notification](examples/notification_dialogs/) या [Input](examples/input_dialog/)

## 🛠️ एक अधिक जटिल उदाहरण

एक उदाहरण जो एक विंडो बनाता है जिसमें एक बटन होता है, जिसे दबाने पर काउंटर बढ़ता है।


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

## 🛣️ रोडमैप

- [x] बेसिक विजेट सेट और विंडोज़, लिनक्स और मैकोएस के लिए सपोर्ट
- [x] वेबजीएल सपोर्ट
- [ ] ओपनजीएल / एसडीएल / वल्कन सपोर्ट
- [ ] कोड हाइलाइटिंग के लिए टेक्स्टएरिया सपोर्ट

## 🤝 योगदान

योगदान, समस्याएं, और फीचर अनुरोध स्वागत योग्य हैं!  
शुरू करने के लिए [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) देखें।

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions) में चर्चा में शामिल हों।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---