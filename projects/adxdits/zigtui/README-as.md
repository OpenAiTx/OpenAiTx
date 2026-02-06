
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ZigTUI

Zig ৰ বাবে ক্রছ-প্লেটফৰ্ম TUI লাইব্ৰেৰী, [Ratatui](https://github.com/ratatui/ratatui) ৰ পৰা অনুপ্ৰাণিত।

![ZigTUI ডেশব’ৰ্ড](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## বৈশিষ্ট্যসমূহ

- **ক্ৰছ-প্লেটফৰ্ম** — উইণ্ড'জ, লিনাক্স, মেক'অএস
- **দক্ষ ৰেণ্ডাৰিং** — চেল-ভিত্তিক ডিফিং, কেৱল পৰিৱর্তিত অংশসমূহ পুনৰ আঁকিছে
- **উইজেটসমূহ** — ব্লক, অনুচ্ছেদ, তালিকা, গেজ, টেবুল
- **১৫টা নিৰ্মিত থীম** — নৰ্ড, ড্ৰাকুলা, গ্ৰুভবক্স, কেটপুচিন, টকিঅ' নাইট...
- **কিটি গ্ৰাফিক্স প্ৰ'ট'কল** — চিত্ৰ প্ৰদৰ্শন (ইউনিক'ড বিকল্পসহ)
- **গোপন এল'কেশ্যন নাই** — স্পষ্ট স্মৃতি ব্যৱস্থাপনা

## requirements

- Zig 0.15.0+
- উইণ্ড'জ ১০+ / লিনাক্স / মেক'অএস

## Installation

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
<summary>বিকল্প: Git সাবমডিউল</summary>

```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## দ্ৰুত আৰম্ভণি

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

## উইজেটসমূহ

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

**উপলব্ধ:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

সকলো থীম পূৰ্বদৰ্শন কৰিবলৈ `zig build run-themes` চলাওক।

## উদাহৰণসমূহ

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## কিটি গ্ৰাফিক্স

[কিটি গ্ৰাফিক্স প্ৰ'ট'কল](https://sw.kovidgoyal.net/kitty/graphics-protocol/) সমৰ্থন কৰা টাৰ্মিনেলসমূহত চিত্ৰ প্ৰদৰ্শন কৰক। স্বয়ংক্ৰিয়ভাৱে ইউনিক'ড ব্লকত পিছলৈ যায়।

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

**সমৰ্থিত:** Kitty, WezTerm, foot, Konsole (আংশিক)  
**বিকল্প:** Windows Terminal, iTerm2, Terminal.app

## প্লেটফৰ্ম সমৰ্থন

| প্লেটফৰ্ম | টার্মিনেল | মন্তব্য |
|-----------|-----------|---------|
| Windows 10+ | Windows Terminal, WezTerm | দেশীয় কনচোল API |
| Linux | যিকোনো ANSI-সমৰ্থিত | POSIX termios |
| macOS | Kitty, WezTerm, Terminal.app | POSIX termios |

## অনুজ্ঞাপত্ৰ

MIT

## অৱদান

সমস্যা আৰু PR আদৰণি।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---