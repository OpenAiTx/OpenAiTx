# ZigTUI

Biblioteca TUI multiplataforma para Zig, inspirada en [Ratatui](https://github.com/ratatui/ratatui).

![ZigTUI Dashboard](https://raw.githubusercontent.com/adxdits/zigtui/master/dashboard.gif)

## Características

- **Multiplataforma** — Windows, Linux, macOS
- **Renderizado eficiente** — Diferencias basadas en celdas, solo redibuja lo que cambió
- **Widgets** — Bloque, Párrafo, Lista, Indicador, Tabla
- **15 temas incorporados** — Nord, Dracula, Gruvbox, Catppuccin, Tokyo Night...
- **Protocolo de gráficos Kitty** — Mostrar imágenes (con respaldo Unicode)
- **Sin asignaciones ocultas** — Gestión explícita de memoria

## Requisitos

- Zig 0.15.0+
- Windows 10+ / Linux / macOS

## Instalación

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
<summary>Alternativa: submódulo de Git</summary>

```bash
git submodule add https://github.com/adxdits/zigtui.git libs/zigtui
```

```zig
const zigtui_module = b.addModule("zigtui", .{
    .root_source_file = b.path("libs/zigtui/src/lib.zig"),
});
```
</details>

## Inicio Rápido

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

**Disponibles:** `default`, `nord`, `dracula`, `monokai`, `gruvbox_dark`, `gruvbox_light`, `solarized_dark`, `solarized_light`, `tokyo_night`, `catppuccin_mocha`, `catppuccin_latte`, `one_dark`, `cyberpunk`, `matrix`, `high_contrast`

Ejecute `zig build run-themes` para previsualizar todos los temas.

## Ejemplos

```bash
zig build run-dashboard   # System monitor demo
zig build run-kitty       # Image display demo  
zig build run-themes      # Theme showcase
```

## Gráficos Kitty

Muestra imágenes en terminales que soportan el [Protocolo de Gráficos Kitty](https://sw.kovidgoyal.net/kitty/graphics-protocol/). Vuelve automáticamente a bloques Unicode.

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

**Soportado:** Kitty, WezTerm, foot, Konsole (parcial)  
**Alternativa:** Windows Terminal, iTerm2, Terminal.app

## Soporte de Plataforma

| Plataforma | Terminal | Notas |
|------------|----------|-------|
| Windows 10+ | Windows Terminal, WezTerm | API nativa de consola |
| Linux | Cualquier compatible con ANSI | termios POSIX |
| macOS | Kitty, WezTerm, Terminal.app | termios POSIX |

## Licencia

MIT

## Contribuciones

Se aceptan issues y PRs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---