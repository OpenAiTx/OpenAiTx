
<div align="right">
  <details>
    <summary>🌐 言語</summary>
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

![Windows ビルドステータス](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Linux ビルドステータス](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![macOS ビルドステータス](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![コードカバレッジ](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![ライセンス](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![ギャラリー](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rsは、高速でクロスプラットフォームなRustライブラリであり、リッチなウィジェット、テーマ、完全なUnicodeサポートを備えたモダンなテキストベースのユーザーインターフェース（TUI）を構築できます。ncursesやその他のターミナルUIフレームワークの代替となります。
* [ブック](https://gdt050579.github.io/AppCUI-rs/)
* [ドキュメント](https://docs.rs/appcui)
* [ギャラリー](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ 特徴
- [x] 複数の標準コントロール（ボタン、ラベル、テキストボックス、チェックボックス、ラジオボタン、リストビュー、ツリービュー、コンボボックス、日付/時刻ピッカー、カラーピッカー、タブ、アコーディオン等）を標準装備。全コントロール一覧は[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] 絶対座標、相対座標、ドッキング、整列、アンカー、ピボット指定などでコントロール配置ができる強力なレイアウトシステム（詳細は[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)） 
- [x] メニューとツールバー
- [x] マルチプラットフォーム対応（WindowsはAPIと仮想ターミナル、Linuxはncurses、macOSはtermios）
- [x] バックグラウンドタスク用のマルチスレッド対応
- [x] タイマー
- [x] マウスサポート
- [x] クリップボードサポート
- [x] カラーテーマ
- [x] Unicode文字対応
- [x] 定義済みダイアログ（メッセージボックス、入力ボックス、カラーピッカー、保存・開くダイアログ、フォルダナビゲータ等）
- [x] 対応端末でのTrueColor（24bit/pixel）サポート

## 📸 スクリーンショット 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **すべてのコントロールの完全なデモは[ギャラリー](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)をチェック！**

## 🖥️ バックエンド

AppCUIは、OSに応じて様々なバックエンドをサポートしています。

* **Windows Console** - Win32の低レベルAPIに基づき、従来のWindowsコンソール向けに設計されています
* **Windows VT** - ANSIシーケンスに基づき、最新のWindows仮想端末向けに設計されています
* **NCurses** - Linux環境向けにNCurses APIに基づいています
* **Termios** - ANSIシーケンスとmacOS用の低レベルAPIに基づいています
* **Web Terminal** - Web実装向けに設計されています（WebGLベース）
* **CrossTerm** - `crossterm`クレートに基づき、フィーチャーフラグで有効化されます

サポートされているバックエンドの詳細は[こちら](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)をご覧ください


## 🚀 クイックスタート

以下を`Cargo.toml`に追加してください:

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

または、proc-macrosを使用したよりコンパクトなバージョン：

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

その後、`cargo run`でプロジェクトを実行してください。タイトルが`Test`のウィンドウと、中央に`Hello World !`というテキストが表示されるはずです。

## 🧪 例

AppCUI-rsには、使い始めるための一連のサンプルが付属しています。[examples](examples)フォルダーで見つけることができます。内容は以下の通りです：
- **ゲーム** 例えば [Tic Tac Toe](examples/tic-tac-toe/)、[Snake](examples/snake/)、[Flappy Bird](examples/flappy)、[Minesweeper](examples/minesweeper/)、[Ram it](examples/ramit/)、[PacMan](examples/games/)、[Chess](examples/games/)、[Connect Four](examples/games/)、[2048](examples/games/)、または [Tetris](examples/games/)
- **ユーティリティ** 例えば [Calculator](examples/calculator/)、[CSV Viewer](examples/csv_viewer/)、[Temperature Converter](examples/temperature_convertor/)、または [Timer](examples/timer/)
- **アニメーション** 例えば [Matrix](examples/matrix/)、[Fractals](examples/fractals/)、または [Spiral](examples/spiral/)
- **コントロール**/**ウィジェット** 例えば [Button](examples/buttons/)、[CheckBox](examples/checkboxes/)、[ComboBox](examples/combobox/)、[DatePicker](examples/datepicker/)、[ListView](examples/listview/)、[TreeView](examples/treeview/)など多数。
- **ダイアログ** 例えば [Notification](examples/notification_dialogs/) や [Input](examples/input_dialog/)

## 🛠️ より複雑な例

ボタン付きのウィンドウを作成し、そのボタンを押すとカウンターが増加する例。

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

## 🛣️ ロードマップ

- [x] 基本的なウィジェットセットとWindows、Linux、macOSのサポート
- [x] WebGLサポート
- [ ] OpenGL / SDL / Vulkanサポート
- [ ] コードハイライト用のTextAreaサポート

## 🤝 コントリビューション

貢献、問題報告、機能要望は大歓迎です！  
始めるには[CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md)をご覧ください。

[GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions)で議論に参加してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---