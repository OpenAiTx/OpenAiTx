
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

Zig के लिए क्रॉस-प्लेटफॉर्म TUI लाइब्रेरी, प्रेरित [Ratatui](https://github.com/ratatui/ratatui) से।

![ZigTUI डैशबोर्ड](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## विशेषताएँ

- **क्रॉस-प्लेटफ़ॉर्म** — विंडोज़, लिनक्स, मैकोएस
- **प्रभावी रेंडरिंग** — सेल-आधारित डिफिंग, केवल वही री-ड्रॉ करता है जो बदला है
- **विजेट्स** — ब्लॉक, पैराग्राफ, सूची, गेज, तालिका
- **15 बिल्ट-इन थीम्स** — नॉर्ड, ड्रैकुला, ग्रुवबॉक्स, कैटपुक्किन, टोक्यो नाइट...
- **किटी ग्राफिक्स प्रोटोकॉल** — इमेज प्रदर्शित करें (यूनिकोड फॉलबैक के साथ)
- **कोई छुपी हुई एलोकेशन नहीं** — स्पष्ट मेमोरी प्रबंधन

## आवश्यकताएँ

- Zig 0.15.0+
- विंडोज़ 10+ / लिनक्स / मैकोएस

## इंस्टॉलेशन

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
<summary>विकल्प: Git सबमॉड्यूल</summary>

```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## त्वरित प्रारंभ

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

## विजेट्स

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

**उपलब्ध:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

सभी थीम्स का पूर्वावलोकन देखने के लिए `zig build run-themes` चलाएँ।

## उदाहरण

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## किट्टी ग्राफिक्स

उन टर्मिनलों में चित्र प्रदर्शित करें जो [किट्टी ग्राफिक्स प्रोटोकॉल](https://sw.kovidgoyal.net/kitty/graphics-protocol/) का समर्थन करते हैं। स्वतः ही यूनिकोड ब्लॉक्स पर वापस चला जाता है।

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

**समर्थित:** Kitty, WezTerm, foot, Konsole (आंशिक)  
**फॉलबैक:** Windows Terminal, iTerm2, Terminal.app

## प्लेटफ़ॉर्म समर्थन

| प्लेटफ़ॉर्म | टर्मिनल | नोट्स |
|-------------|----------|-------|
| Windows 10+ | Windows Terminal, WezTerm | नेटिव कंसोल API |
| Linux | कोई भी ANSI-संगत | POSIX termios |
| macOS | Kitty, WezTerm, Terminal.app | POSIX termios |

## लाइसेंस

MIT

## योगदान

इश्यू और PR का स्वागत है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---