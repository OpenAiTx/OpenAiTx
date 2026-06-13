<div align="right">
  <details>
    <summary>🌐 भाषा</summary>
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

![Windows बिल्ड स्थिति](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux बिल्ड स्थिति](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![macOS बिल्ड स्थिति](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![कोड कवरेज](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![लाइसेंस](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs एक तेज, क्रॉस-प्लेटफॉर्म Rust लाइब्रेरी है जो आधुनिक, टेक्स्ट-आधारित यूजर इंटरफेस (TUI) बनाने के लिए है, जिसमें समृद्ध विजेट, थीम, और पूर्ण यूनिकोड सपोर्ट है—यह ncurses और अन्य टर्मिनल UI फ्रेमवर्क का विकल्प है।
* [बुक](https://gdt050579.github.io/AppCUI-rs/)
* [दस्तावेज़](https://docs.rs/appcui)
* [गैलरी](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ विशेषताएँ
- [x] कई आउट-ऑफ-द-बॉक्स कंट्रोल्स (बटन, लेबल, टेक्स्ट बॉक्स, चेक बॉक्स, रेडियो बटन, लिस्ट व्यू, ट्री व्यू, कॉम्बो बॉक्स, दिनांक/समय पिकर, रंग पिकर, टैब्स, एकॉर्डियन्स आदि)। सभी कंट्रोल्स की पूरी सूची [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) देखी जा सकती है 
- [x] शक्तिशाली लेआउट सिस्टम जो आपको कंट्रोल्स को पूर्ण निर्देशांक, सापेक्ष निर्देशांक, डॉकिंग, अलाइनमेंट, एंकर, या पिवट पोजिशनिंग द्वारा स्थित करने देता है (और देखें [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] मेन्यू और टूलबार
- [x] मल्टी-प्लेटफॉर्म सपोर्ट (Windows API और वर्चुअल टर्मिनल के जरिए, Linux में ncurses के जरिए, macOS में termios के जरिए)
- [x] बैकग्राउंड टास्क के लिए मल्टी-थ्रेडिंग सपोर्ट
- [x] टाइमर
- [x] माउस सपोर्ट
- [x] क्लिपबोर्ड सपोर्ट
- [x] रंग थीम्स
- [x] यूनिकोड कैरेक्टर का समर्थन
- [x] पूर्व-निर्धारित डायलॉग (संदेश बॉक्स, इनपुट बॉक्स, रंग पिकर, सेव व ओपन डायलॉग, फोल्डर नेविगेटर आदि)
- [x] टर्मिनल के लिए ट्रू-कलर सपोर्ट (24 बिट प्रति पिक्सेल) जो इसे सपोर्ट करते हैं।

## 📸 स्क्रीनशॉट्स 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **[गैलरी](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) देखें, सभी कंट्रोल्स के पूर्ण डेमो के लिए!**

## 🖥️ बैकएंड्स

AppCUI विभिन्न ऑपरेटिंग सिस्टम के अनुसार कई बैकएंड्स को सपोर्ट करता है:

* **विंडोज़ कंसोल** - Win32 लो-लेवल API पर आधारित, पारंपरिक विंडोज़ कंसोल के लिए डिज़ाइन किया गया
* **विंडोज़ VT** - ANSI सीक्वेंस पर आधारित, आधुनिक विंडोज़ वर्चुअल टर्मिनलों के लिए डिज़ाइन किया गया
* **एनकर्सेस** - लिनक्स परिवेशों के लिए NCurses API पर आधारित
* **टर्मियोस** - macOS के लिए ANSI सीक्वेंस और लो-लेवल API पर आधारित
* **वेब टर्मिनल** - वेब कार्यान्वयन के लिए डिज़ाइन किया गया (WebGL पर आधारित)
* **क्रॉसटर्म** - `crossterm` क्रेट पर आधारित, फीचर फ्लैग के माध्यम से सक्षम

समर्थित बैकएंड्स के बारे में अधिक जानकारी [यहाँ](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html) पाई जा सकती है


## 🚀 त्वरित प्रारंभ

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
या proc-macros का उपयोग करके एक अधिक संक्षिप्त संस्करण:


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
फिर प्रोजेक्ट को `cargo run` के साथ चलाएँ। आपको एक विंडो दिखाई देगी जिसका शीर्षक `Test` है और केंद्र में `Hello World !` लिखा होगा।

## 🧪 उदाहरण

AppCUI-rs कुछ उदाहरणों के सेट के साथ आता है, जो आपको शुरुआत करने में मदद करते हैं। आप इन्हें [examples](examples) फ़ोल्डर में पा सकते हैं, जिनमें शामिल हैं:
- **गेम्स** जैसे [टिक टैक टो](examples/tic-tac-toe/), [स्नेक](examples/snake/), [फ्लैपी बर्ड](examples/flappy), [माइनस्वीपर](examples/minesweeper/), [राम इट](examples/ramit/), [पैकमैन](examples/games/), [चेस](examples/games/), [कनेक्ट फोर](examples/games/), [2048](examples/games/) या [टेट्रिस](examples/games/)
- **यूटिलिटीज** जैसे [कैलकुलेटर](examples/calculator/), [CSV व्यूअर](examples/csv_viewer/), [तापमान कन्वर्टर](examples/temperature_convertor/), या [टाइमर](examples/timer/)
- **एनिमेशन** जैसे [मैट्रिक्स](examples/matrix/), [फ्रैक्टल्स](examples/fractals/), या [स्पाइरल](examples/spiral/)
- **कंट्रोल्स**/**विजेट्स** जैसे [बटन](examples/buttons/), [चेकबॉक्स](examples/checkboxes/), [कॉम्बोबॉक्स](examples/combobox/), [डेटपिकर](examples/datepicker/), [लिस्टव्यू](examples/listview/), [ट्रीव्यू](examples/treeview/) और बहुत कुछ।
- **डायलॉग्स** जैसे [नोटिफिकेशन](examples/notification_dialogs/) या [इनपुट](examples/input_dialog/)

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

## 🛣️ रोडमैप

- [x] विंडोज, लिनक्स, और मैकओएस के लिए बेसिक विजेट्स और समर्थन
- [x] WebGL समर्थन
- [ ] OpenGL / SDL / Vulkan समर्थन
- [ ] कोड हाइलाइटिंग के लिए TextArea समर्थन

## 🤝 योगदान

योगदान, समस्याएँ, और फीचर अनुरोध स्वागत योग्य हैं!  
शुरुआत करने के लिए [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) देखें।

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions) में चर्चा में शामिल हों।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---