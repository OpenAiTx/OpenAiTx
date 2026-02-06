
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=adxdits&project=zigtui&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

# ZigTUI

Cross-platform TUI-bibliotheek voor Zig, geïnspireerd door [Ratatui](https://github.com/ratatui/ratatui).

![ZigTUI Dashboard](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## Functies

- **Cross-platform** — Windows, Linux, macOS
- **Efficiënte weergave** — Celgebaseerde diffing, tekent alleen wat gewijzigd is
- **Widgets** — Blok, Paragraaf, Lijst, Meter, Tabel
- **15 ingebouwde thema's** — Nord, Dracula, Gruvbox, Catppuccin, Tokyo Night...
- **Kitty Graphics Protocol** — Afbeeldingen tonen (met Unicode-terugval)
- **Geen verborgen allocaties** — Expliciet geheugenbeheer

## Vereisten

- Zig 0.15.0+
- Windows 10+ / Linux / macOS

## Installatie

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
<summary>Alternatief: Git-submodule</summary>


```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## Snelle start

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

**Beschikbaar:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

Voer `zig build run-themes` uit om alle thema's te bekijken.

## Voorbeelden

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## Kitty Graphics

Toon afbeeldingen in terminals die het [Kitty Graphics Protocol](https://sw.kovidgoyal.net/kitty/graphics-protocol/) ondersteunen. Valt automatisch terug op Unicode-blokken.

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

**Ondersteund:** Kitty, WezTerm, foot, Konsole (gedeeltelijk)  
**Terugvalopties:** Windows Terminal, iTerm2, Terminal.app

## Platformondersteuning

| Platform | Terminal | Opmerkingen |
|----------|----------|-------------|
| Windows 10+ | Windows Terminal, WezTerm | Native Console API |
| Linux | Elke ANSI-compatibele | POSIX termios |
| macOS | Kitty, WezTerm, Terminal.app | POSIX termios |

## Licentie

MIT

## Bijdragen

Issues en PR's welkom.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---