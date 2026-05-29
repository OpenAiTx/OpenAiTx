<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## Table of Contents

- [Table of Contents](#table-of-contents)
- [Overview](#overview)
- [Gallery](#gallery)
- [Installation/Usage](#installation/usage)
  - [Nerd Fonts](#nerd-fonts)
  - [Propo](#propo)
  - [Nixpkgs](#nixpkgs)
  - [Nix Flakes](#nix-flakes)
  - [Web](#web)
- [Design Notes](#design-notes)
  - [Flourishes](#flourishes)
  - [Gaps](#gaps)
- [Contributing](#contributing)
- [Credits](#credits)
- [Licensing](#licensing)

## Overview

**kirsch** /ˈkɪərʃ/ _n._

1. _(German)_ cherry.

1. _(Russell A. Kirsch, 1929 - 2020)_ American engineer recognized as the
   developer of the first digital image scanner and the inventor of the pixel.

1. A monospace bitmap font with a 6x16 bounding box (5px avg width, 4px descent,
   12px ascent, 5px x-height, 9px cap height). It draws from a variety of
   letterforms and motifs to create a distinct humanist feel at a compact size.

   Some glyphs come from [Cozette](https://github.com/slavfox/Cozette), often
   with modifications to adhere to kirsch's design.

## Gallery

<details>
<summary><strong>Glyphs</strong></summary>
<div align="center">

![kirsch glyphs](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>Glyphs Map</strong></summary>
<div align="center">

![kirsch glyph map](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>Samples</strong></summary>
<div align="center">

![kirsch sample](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## Installation/Usage

Download from [Releases](https://github.com/molarmanful/kirsch/releases).
Included are bitmap formats - OTB, BDF, PCF, DFONT (for Mac users) - as well as
TTF. 2x versions are available for HiDPI screens. Note that PCF doesn't contain
glyphs past U+FFFF.

For the crispiest viewing experience, try to use the bitmap formats when
possible. If bitmap fonts are not supported on your platform (e.g. Windows,
VSCode), then use the TTF at font sizes that are multiples of 16px.

> [!TIP]
> If you need font size in pt, use the following conversion:
>
> `pt = px * 72 / dpi`
>
> e.g. 16px on a 96dpi screen is `16px * 72 / 96dpi = 12pt`.

### Nerd Fonts

kirsch comes with custom Nerd Fonts glyphs. Support is still WIP. For the sake
of visual clarity, kirsch's Nerd Fonts glyphs tend to bleed heavily beyond their
widths. I've drawn these glyphs with the expectation that they will look best
when padded before and after with a single space.

Patched Nerd Fonts that cover the rest of the Nerd Fonts are available. The
"Mono" variant uses smaller glyphs (single- instead of double-width) and works
for terminals that can't mix widths.

### Propo

For terminals like foot with partial bleed, a Propo variant of kirsch is
available. This variant adjusts the glyphs such that their cells won't be cut
off by the terminal's font renderer.

### Nixpkgs

Thanks to [@ejiektpobehuk](https://github.com/ejiektpobehuk), kirsch is
available on Nixpkgs as `kirsch`.

### Nix Flakes

kirsch releases are also pushed to
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch). `kirsch` (aliased to
`default`) is the base package, while `kirsch-nerd` includes Nerd Fonts patches.

### Web

I would generally discourage usage of kirsch on the web due to lack of bitmap
support. But for the stubborn and the brave, WOFF2 is available. There is also a
[CDN-hosted stylesheet](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)
for convenience.

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```

## Design Notes

Unlike my previous font [eldur](https://github.com/molarmanful/eldur), which had
a mere 4px avg. char width to work with, kirsch has a 5px avg. char width. That
1px of extra width affords a surprising amount of leeway for the design. Far
more glyphs fit comfortably into 5px width - e.g. "m" and "w" - meaning that
those glyphs won't break kerning and intrude on the spaces of neighboring
glyphs. Glyphs that don't fit into 5px width can now work with 7px width, which
maintains balance and legibility without affecting kerning too negatively.

### Flourishes

![rogue fijian xylophone](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

The flourishes - e.g. in "i" or "f" - are a stylistic choice, but they also
serve a functional purpose. Without the flourishes, "i" would take up 1px of
width, leaving 4px of awkward space. 2px flourishes on each side of the "i" give
it a 5px width, thereby addressing the kerning issue in a stylish way.

In "l"'s case, the script-style flourishes further distinguish it from other
vertical characters like `1I|`.

### Gaps

![bad queen peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

One of kirsch's distinctive features is the presence of a gap at the bowls of
the letters. Filling in the gap would make the letters either too square or too
bunched-up, while leaving the gap open declutters the letterforms. The gaps also
evoke script-style stroke endings.

## Contributing

Issues, feature/glyph requests, and pull requests are all welcome! Font files
are edited via [bited](https://github.com/molarmanful/bited).

## Credits

These are projects that have inspired/helped me create kirsch and are 100% worth
checking out.

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Cyreal Font Testing Page](http://www.cyreal.org/Font-Testing-Page/)
- [W3 UTF-8 Demo](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Markus Kuhn UTF-8 Demo](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## Licensing

Made with ♥ by [the kirsch Project Authors](AUTHORS). Released under the OFL-1.1
License.
