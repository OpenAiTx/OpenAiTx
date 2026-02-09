
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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
![Windows Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![MacOS Build Status](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Code Coverage](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![License](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Gallery](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rsは、高速でクロスプラットフォームなRustライブラリであり、豊富なウィジェット、テーマ、完全なUnicodeサポートを備えたモダンなテキストベースのユーザーインターフェース（TUI）を構築するためのものです。ncursesやその他のターミナルUIフレームワークの代替手段です。
* [ブック](https://gdt050579.github.io/AppCUI-rs/)
* [ドキュメント](https://docs.rs/appcui)
* [ギャラリー](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 特徴
- [x] 多数のすぐに使えるコントロール（ボタン、ラベル、テキストボックス、チェックボックス、ラジオボタン、リストビュー、ツリービュー、コンボボックス、日付/時間ピッカー、カラーピッカー、タブ、アコーディオンなど）。コントロールの完全なリストは[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html)から確認できます 
- [x] 絶対座標、相対座標、ドッキング、配置、アンカー、ピボット位置指定などを使用してコントロールを配置できる強力なレイアウトシステム（詳細は[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)） 
- [x] メニューとツールバー
- [x] マルチプラットフォーム対応（WindowsはAPIと仮想端末、Linuxはncurses、MacOSはtermiosを使用）
- [x] バックグラウンドタスクを可能にするマルチスレッドサポート
- [x] タイマー
- [x] マウスサポート
- [x] クリップボードサポート
- [x] カラーテーマ
- [x] Unicode文字のサポート
- [x] 事前定義されたダイアログ（メッセージボックス、入力ボックス、カラーピッカー、保存＆開くダイアログ、フォルダナビゲーターなど）
- [x] 対応する端末で利用可能な真のカラーサポート（1ピクセルあたり24ビット）

## 📸 スクリーンショット 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **すべてのコントロールの完全なデモについては[ギャラリー](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)をご覧ください！**

## 🖥️ バックエンド

AppCUIは、使用されるオペレーティングシステムに基づいてさまざまなバックエンドをサポートしています：

* **Windows Console** - Win32の低レベルAPIに基づき、従来のWindowsコンソール用に設計  
* **Windows VT** - ANSIシーケンスに基づき、モダンなWindows仮想端末用に設計  
* **NCurses** - Linux環境向けのNCurses APIに基づく  
* **Termios** - ANSIシーケンスおよびMAC OSXの低レベルAPIに基づく  
* **Web Terminal** - Web実装向けに設計（webglベース）  
* **CrossTerm** - `crossterm`クレートに基づくが、機能フラグで有効化  

サポートされているバックエンドの詳細は[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)をご覧ください  


## 🚀 クイックスタート  

以下を `Cargo.toml` に追加してください:


```toml
[dependencies]
appcui = "*"
```

次に、新しいRustプロジェクトを作成し、以下のコードを追加します：

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
よりコンパクトなバージョンはproc-macrosを使用します:


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

次に `cargo run` でプロジェクトを実行します。タイトルが `Test` で、中央に `Hello World !` と表示されたウィンドウが表示されるはずです。

## 🧪 例

AppCUI-rs には入門用の例がいくつか用意されています。[examples](examples) フォルダーで見つけることができ、以下を含みます：
- **ゲーム** 例えば [Tic Tac Toe](examples/tic-tac-toe/)、[Snake](examples/snake/)、[Flappy Bird](examples/flappy)、[Minesweeper](examples/minesweeper/)、[Ram it](examples/ramit/)、[PacMan](examples/games/)、[Chees](examples/games/)、[Connect Four](examples/games/)、[2048](examples/games/) または [Tetris](examples/games/)
- **ユーティリティ** 例えば [Calculator](examples/calculator/)、[CSV Viewer](examples/csv_viewer/)、[Temperature Converter](examples/temperature_convertor/) または [Timer](examples/timer/)
- **アニメーション** 例えば [Matrix](examples/matrix/)、[Fractals](examples/fractals/) または [Spiral](examples/spiral/)
- **コントロール**/**ウィジェット** 例えば [Button](examples/buttons/)、[CheckBox](examples/checkboxes/)、[ComboBox](examples/combobox/)、[DatePicker](examples/datepicker/)、[ListView](examples/listview/)、[TreeView](examples/treeview/) など多数。
- **ダイアログ** 例えば [Notification](examples/notification_dialogs/) または [Input](examples/input_dialog/)

## 🛠️ より複雑な例

ボタンを持つウィンドウを作成し、そのボタンを押すとカウンターが増加する例。

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
## 🛣️ ロードマップ

- [x] 基本的なウィジェットセットとWindows、Linux、MacOSのサポート  
- [x] WebGLサポート  
- [ ] OpenGL / SDL / Vulkanサポート  
- [ ] コードハイライト用のTextAreaサポート  

## 🤝 貢献

貢献、問題報告、機能リクエストを歓迎します！  
始めるには[CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md)を参照してください。

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions)で議論に参加しましょう。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---