# ZigTUI

Zig向けのクロスプラットフォームTUIライブラリで、[Ratatui](https://github.com/ratatui/ratatui)に触発されています。

![ZigTUI Dashboard](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## 特徴

- **クロスプラットフォーム** — Windows、Linux、macOS対応
- **効率的なレンダリング** — セルベースの差分描画、変更箇所のみ再描画
- **ウィジェット** — ブロック、パラグラフ、リスト、ゲージ、テーブル
- **15種類の組み込みテーマ** — Nord、Dracula、Gruvbox、Catppuccin、Tokyo Nightなど
- **Kittyグラフィックスプロトコル** — 画像表示（Unicodeフォールバック付き）
- **隠れたメモリアロケーションなし** — 明示的なメモリ管理

## 動作環境

- Zig 0.15.0以上
- Windows 10以上 / Linux / macOS

## インストール

```bash
zig fetch --save git+https://github.com/adxdits/zigtui.git
```

```zig
// build.zig
const zigtui = b.dependency("zigtui", .{ .target = target, .optimize = optimize });

const exe = b.addExecutable(.{
    .name = "myapp",
    .root_module = b.createModule(.{
        .root_source_file = b.path("src/main.zig"),
        .target = target,
        .optimize = optimize,
        .imports = &.{
            .{ .name = "zigtui", .module = zigtui.module("zigtui") },
        },
    }),
});
```
<details>
<summary>代替案: Gitサブモジュール</summary>


```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## クイックスタート

```zig
const std = @import("std");
const tui = @import("zigtui");

pub fn main() !void {
    var gpa = std.heap.GeneralPurposeAllocator(.{}){};
    defer _ = gpa.deinit();
    const allocator = gpa.allocator();

    var backend = try tui.backend.init(allocator);
    defer backend.deinit();

    var terminal = try tui.terminal.Terminal.init(allocator, backend.interface());
    defer terminal.deinit();

    try terminal.hideCursor();
    defer terminal.showCursor() catch {};

    var running = true;
    while (running) {
        const event = try backend.interface().pollEvent(100);
        if (event == .key) {
            if (event.key.code == .esc or (event.key.code == .char and event.key.code.char == 'q'))
                running = false;
        }

        try terminal.draw({}, struct {
            fn render(_: void, buf: *tui.render.Buffer) !void {
                tui.widgets.Block{
                    .title = "Hello ZigTUI — press 'q' to quit",
                    .borders = tui.widgets.Borders.all(),
                    .border_style = .{ .fg = .cyan },
                }.render(buf.getArea(), buf);
            }
        }.render);
    }
}
```

## ウィジェット

```zig
// Block — container with border/title
tui.widgets.Block{ .title = "Panel", .borders = tui.widgets.Borders.all() }

// Paragraph — text display
tui.widgets.Paragraph{ .text = "Hello!", .wrap = true }

// List — scrollable items
tui.widgets.List{ .items = &items, .selected = 0, .highlight_style = .{ .bg = .blue } }

// Gauge — progress bar
tui.widgets.Gauge{ .ratio = 0.75, .label = "75%" }

// Table — tabular data
tui.widgets.Table{ .header = &columns, .rows = &rows }
```

## Themes

![Themes](https://raw.githubusercontent.com/adxdits/zigtui/master/theme.gif)

```zig
const theme = tui.themes.catppuccin_mocha;

tui.widgets.Block{
    .title = "Dashboard",
    .style = theme.baseStyle(),
    .border_style = theme.borderFocusedStyle(),
};
```

**利用可能:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

すべてのテーマをプレビューするには、`zig build run-themes` を実行してください。

## 例

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## Kitty Graphics

[Kitty Graphics Protocol](https://sw.kovidgoyal.net/kitty/graphics-protocol/) をサポートする端末で画像を表示します。自動的にUnicodeブロックにフォールバックします。

```zig
var gfx = tui.Graphics.init(allocator);
defer gfx.deinit();

var bmp = try tui.graphics.bmp.loadFile(allocator, "image.bmp");
const image = tui.Image{ .data = bmp.data, .width = bmp.width, .height = bmp.height, .format = .rgba };

if (gfx.supportsImages()) {
    if (try gfx.drawImage(image, .{ .x = 0, .y = 0 })) |seq| try backend.write(seq);
} else {
    gfx.renderImageToBuffer(image, buffer, area); // Unicode fallback
}
```
**対応済み:** Kitty, WezTerm, foot, Konsole（一部対応）  
**代替:** Windows Terminal, iTerm2, Terminal.app

## プラットフォームサポート

| プラットフォーム | ターミナル | 備考 |
|----------|----------|-------|
| Windows 10以降 | Windows Terminal, WezTerm | ネイティブコンソールAPI |
| Linux | 任意のANSI互換 | POSIX termios |
| macOS | Kitty, WezTerm, Terminal.app | POSIX termios |

## ライセンス

MIT

## コントリビュート

IssueおよびPR歓迎。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---