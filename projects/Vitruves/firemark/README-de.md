
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Ein schnelles, einzelnes Binary-Wasserzeichen-Tool für Bilder und PDFs. Entwickelt in Rust.</p>

## Warum sollten Sie Ihre Dokumente mit einem Wasserzeichen versehen?

Jedes Jahr werden Millionen Menschen Opfer von Identitätsbetrug, der mit einem
einfachen Dokumentenaustausch beginnt. Ein häufiges Szenario: Sie suchen eine Wohnung zur Miete.
Der Vermieter — oder jemand, der sich als solcher ausgibt — bittet um eine Kopie Ihres Ausweises, eine Gehaltsabrechnung,
einen Steuerbescheid. Sie senden diese unmarkiert. Der "Vermieter" verschwindet und Ihre
Dokumente werden nun verwendet, um Bankkonten zu eröffnen, Kredite aufzunehmen oder
Identitäten in Ihrem Namen zu fälschen.

Das Wasserzeichen auf jedem Dokument, das Sie versenden, ist die effektivste Verteidigung.
Ein sichtbarer Overlay mit der Aufschrift **"Gesendet an XYZ-Agentur — März 2026 — nur Wohnungsbewerbung"**
macht das Dokument für jeglichen anderen Zweck nutzlos. Sollte es geleakt werden, wissen Sie genau, woher es stammt.

firemark macht dies mühelos: ein Befehl, jedes Bild oder PDF, 17 visuelle
Stile, kryptografische Filigranmuster, die gegen Bearbeitung resistent sind, und Batch-
Verarbeitung für ganze Ordner.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Vor und nach Wasserzeichen" width="800">
  <br>
  <em>Vorher und nachher — ein Befehl, das Dokument ist jetzt nachvollziehbar und manipulationssicher.</em>
</p>

## Installation

Von [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```

Vom Ursprung:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
Erzeugt eine einzelne optimierte Binärdatei (~5 MB).

## Schnellstart


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
Die Ausgabe wird standardmäßig zusammen mit der Eingabe als `{name}-watermarked.{ext}` gespeichert.
Verwenden Sie `-o`, um einen expliziten Ausgabepfad festzulegen, oder `-S` für ein benutzerdefiniertes Suffix.

## Wasserzeichen-Typen

| Flag | Stil | Beschreibung |
|---|---|---|
| `diagonal` | Diagonales Raster | Seitenfüllender, wiederholter diagonaler Text (Standard) |
| `stamp` | Stempel | Großes zentriertes Stempelmotiv mit Doppelrahmen |
| `stencil` | Schablone | Seitenbreite Militär-Schablonenschrift |
| `typewriter` | Schreibmaschine | Monospace-Schreibmaschinentext |
| `handwritten` | Handschrift | Handschriftliche Signatur mit Unterstreichung |
| `redacted` | Schwärzung | Seitenbreite schwarze Schwärzungsbalken |
| `badge` | Abzeichen | Sicherheitsabzeichen-/Wappensymbol |
| `ribbon` | Schleife | Diagonales Eckbanner |
| `seal` | Siegel | Rundes notarielles Siegel |
| `frame` | Rahmen | Seitenfüllender dekorativer Rahmen |
| `tile` | Kachel | Dichtes, einheitliches Textraster |
| `mosaic` | Mosaik | Zufällig verstreuter Text |
| `weave` | Webmuster | Überkreuztes diagonales Webmuster |
| `ghost` | Geisterschrift | Sehr dezenter, geprägter Text |
| `watercolor` | Aquarell | Weiche, verschwommene Farbflächenwirkung |
| `noise` | Rauschen | Abgenutzter Text mit Pixelrauschen |
| `halftone` | Raster | Text als Rasterpunktmuster |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Sicherheitsfiligran

firemark überlagert kryptografische Filigranmuster, die von Sicherheitsmerkmalen von Banknoten inspiriert sind. Diese feinen geometrischen Muster sind mit Bildbearbeitungsprogrammen extrem schwer zu entfernen.

| Stil | Beschreibung |
|---|---|
| `guilloche` | Sinusförmige Wellenbandmuster (Standard) |
| `rosette` | Spirograph + Eck-Rosettenkurven |
| `crosshatch` | Feines diagonales Rautengitter |
| `border` | Verschachtelter, gewellter Sicherheitsrand |
| `lissajous` | Parametrische Lissajous-Figuren |
| `moire` | Interferenz konzentrischer Kreise |
| `spiral` | Archimedischer Spiralwirbel |
| `mesh` | Hexagonales Wabengitter |
| `plume` | Fließende, federartige Kurven über die Oberfläche verteilt |
| `constellation` | Sternknoten, verbunden durch ein feines geometrisches Netz |
| `ripple` | Überlappende elliptische Wellenfronten aus zufälligen Ursprüngen |
| `full` | Alle Muster kombiniert |
| `none` | Filigran deaktivieren |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## KI-Entfernungs-Härtung

Jeder Render ist standardmäßig nicht-deterministisch. Firemark wendet universelle
Post-Render-Störungen an (Alpha-Jitter, Subpixel-Farbrauschen, Kanten-Mikropunkte,
vereinzelte Geisterpixel) sowie Renderer-spezifische Zufallsvariationen, sodass keine zwei Ausgaben
pixelgenau identisch sind — selbst mit den gleichen Einstellungen. Dies macht es für KI-
Visionsmodelle unmöglich, ein vorhersehbares Muster zum Subtrahieren zu lernen.

Zusätzlich werden standardmäßig adversarielle Prompt-Injection-Streifen eingebettet, um
KI-Wasserzeichen-Entfernungswerkzeuge zu verwirren. Mit `--no-anti-ai` deaktivieren, falls Sie
den sichtbaren Prompt-Text nicht wünschen:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Allgemeine Optionen

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

Die vollständige Liste der über 70 Flags finden Sie in [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## PDF-Optionen

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Stapelverarbeitung

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Bereits mit Wasserzeichen versehene Dateien (mit entsprechendem Suffix) werden bei
erneuten Durchläufen automatisch übersprungen.

## Konfigurationsdatei

Speichern Sie Optionen in einer TOML-Datei, um das wiederholte Angeben von Flags zu vermeiden. Siehe
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) für ein vollständiges
Beispiel mit zwei Voreinstellungen: **ultra-secure** (dichtes Kacheln, vollständiges Wasserzeichen, QR-
Rückverfolgbarkeit, Metadaten-Entfernung) und **light** (einfacher diagonaler Text, keine Extras).

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

## Formatunterstützung

| Format | Eingabe | Ausgabe |
|---|---|---|
| PNG | ja | ja |
| JPEG | ja | ja |
| PDF | ja | ja |
| WebP | ja | ja |
| TIFF | ja | ja |

Cross-Format-Konvertierung wird unterstützt (z. B. `firemark photo.webp -o out.pdf`).

## Lizenz

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---