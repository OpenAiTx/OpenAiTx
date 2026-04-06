<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">A fast, single-binary watermarking tool for images and PDFs. Built in Rust.</p>

## Why watermark your documents?

Every year, millions of people fall victim to identity fraud that starts with a
simple document exchange. A common scenario: you're looking for a flat to rent.
The landlord — or someone posing as one — asks for a copy of your ID, a pay
stub, a tax notice. You send them unmarked. The "landlord" disappears, and your
documents are now used to open bank accounts, take out loans, or forge
identities in your name.

Watermarking every document you send out is the single most effective defence.
A visible overlay that reads **"Sent to XYZ agency — March 2026 — flat rental
application only"** makes the document useless for any other purpose. If it
leaks, you know exactly where it came from.

firemark makes this effortless: one command, any image or PDF, 17 visual
styles, cryptographic filigrane patterns that resist editing, and batch
processing for entire folders.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Before and after watermarking" width="800">
  <br>
  <em>Before and after — one command, document is now traceable and tamper-evident.</em>
</p>

## Install

From [crates.io](https://crates.io/crates/firemark):

```bash
cargo install firemark
```

From source:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Produces a single optimized binary (~5 MB).

## Quick start

```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
Output is saved alongside the input as `{name}-watermarked.{ext}` by default.  
Use `-o` to set an explicit output path, or `-S` for a custom suffix.  

## Watermark types  

| Flag | Style | Description |  
|---|---|---|  
| `diagonal` | Diagonal grid | Full-page repeating diagonal text (default) |  
| `stamp` | Rubber stamp | Large centred stamp with double border |  
| `stencil` | Stencil | Full-width military stencil lettering |  
| `typewriter` | Typewriter | Monospaced typewriter text |  
| `handwritten` | Signature | Handwritten-style signature with underline |  
| `redacted` | Redaction | Full-width black redaction bars |  
| `badge` | Shield | Security shield/badge emblem |  
| `ribbon` | Ribbon | Diagonal corner ribbon banner |  
| `seal` | Seal | Circular notary-style seal |  
| `frame` | Frame | Full-page decorative border |  
| `tile` | Tile | Dense uniform text grid |  
| `mosaic` | Mosaic | Randomised scattered text |  
| `weave` | Weave | Interlocking diagonal weave |  
| `ghost` | Ghost | Ultra-subtle embossed text |  
| `watercolor` | Watercolour | Soft blurred wash effect |  
| `noise` | Noise | Distressed text with pixel noise |  
| `halftone` | Halftone | Text as halftone dot grid |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Security watermark

firemark overlays cryptographic watermark patterns inspired by banknote
security features. These fine geometric patterns are extremely difficult to
remove with image editors.

| Style | Description |
|---|---|
| `guilloche` | Sinusoidal wave envelope bands (default) |
| `rosette` | Spirograph + corner rose curves |
| `crosshatch` | Fine diagonal diamond lattice |
| `border` | Wavy nested security border |
| `lissajous` | Parametric Lissajous figures |
| `moire` | Concentric circle interference |
| `spiral` | Archimedean spiral vortex |
| `mesh` | Hexagonal honeycomb grid |
| `plume` | Flowing feather-like curves scattered across the surface |
| `constellation` | Star nodes connected by a fine geometric web |
| `ripple` | Overlapping elliptical wave fronts from random origins |
| `full` | All patterns combined |
| `none` | Disable watermark |

```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## AI-removal hardening

Every render is non-deterministic by default. firemark applies universal
post-render perturbation (alpha jitter, sub-pixel color noise, edge micro-dots,
sparse ghost pixels) and per-renderer randomization so that no two outputs are
pixel-identical — even with the same settings. This makes it impossible for AI
vision models to learn a predictable pattern to subtract.

On top of that, adversarial prompt-injection strips are embedded by default to
confuse AI watermark removal tools. Disable with `--no-anti-ai` if you don't
want the visible prompt text:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Common options

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

For the full list of 70+ flags, see [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## PDF options

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Batch processing

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Already-watermarked files (matching the suffix) are automatically skipped on
re-runs.

## Configuration file

Save options in a TOML file to avoid repeating flags. See
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) for a full
example with two presets: **ultra-secure** (dense tiling, full watermark, QR
traceability, metadata stripping) and **light** (simple diagonal text, no extras).

```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## Format support

| Format | Input | Output |
|---|---|---|
| PNG | yes | yes |
| JPEG | yes | yes |
| PDF | yes | yes |
| WebP | yes | yes |
| TIFF | yes | yes |

Cross-format conversion is supported (e.g. `firemark photo.webp -o out.pdf`).

## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---