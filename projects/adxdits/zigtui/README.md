# ZigTUI

Cross-platform TUI library for Zig, inspired by [Ratatui](https://github.com/ratatui/ratatui).

![ZigTUI Dashboard](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## Features

- **Cross-platform** — Windows, Linux, macOS
- **Efficient rendering** — Cell-based diffing, only redraws what changed
- **Widgets** — Block, Paragraph, List, Gauge, Table
- **15 built-in themes** — Nord, Dracula, Gruvbox, Catppuccin, Tokyo Night...
- **Kitty Graphics Protocol** — Display images (with Unicode fallback)
- **No hidden allocations** — Explicit memory management

## Requirements

- Zig 0.15.0+
- Windows 10+ / Linux / macOS

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
<summary>Alternative: Git submodule</summary>

```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## Quick Start

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

## Widgets

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

**Available:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

Run `zig build run-themes` to preview all themes.

## Examples

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## Kitty Graphics

Display images in terminals that support the [Kitty Graphics Protocol](https://sw.kovidgoyal.net/kitty/graphics-protocol/). Falls back to Unicode blocks automatically.

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

**Supported:** Kitty, WezTerm, foot, Konsole (partial)  
**Fallback:** Windows Terminal, iTerm2, Terminal.app

## Platform Support

| Platform | Terminal | Notes |
|----------|----------|-------|
| Windows 10+ | Windows Terminal, WezTerm | Native Console API |
| Linux | Any ANSI-compatible | POSIX termios |
| macOS | Kitty, WezTerm, Terminal.app | POSIX termios |

## License

MIT

## Contributing

Issues and PRs welcome.
