
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Een snelle, enkelvoudige binaire watermerkhulpmiddel voor afbeeldingen en PDF's. Gebouwd in Rust.</p>

## Waarom uw documenten watermerken?

Elk jaar worden miljoenen mensen slachtoffer van identiteitsfraude die begint met een
eenvoudige documentuitwisseling. Een veelvoorkomend scenario: u bent op zoek naar een flat om te huren.
De verhuurder — of iemand die zich als zodanig voordoet — vraagt om een kopie van uw identiteitsbewijs, een loonstrook,
een belastingaangifte. U stuurt ze ongemarkeerd op. De "verhuurder" verdwijnt, en uw
documenten worden nu gebruikt om bankrekeningen te openen, leningen af te sluiten, of
identiteiten in uw naam te vervalsen.

Het watermerken van elk document dat u verstuurt is de meest effectieve verdediging.
Een zichtbare overlay met de tekst **"Verzonden naar XYZ agentschap — maart 2026 — alleen voor huur aanvraag flat"**
maakt het document onbruikbaar voor elk ander doel. Als het uitlekt, weet u precies waar het vandaan komt.

firemark maakt dit moeiteloos: één commando, elk beeld of PDF, 17 visuele
stijlen, cryptografische filigrane patronen die bestand zijn tegen bewerking, en batchverwerking
voor hele mappen.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Voor en na watermerken" width="800">
  <br>
  <em>Voor en na — één commando, document is nu traceerbaar en bewerking zichtbaar.</em>
</p>

## Installeren

Van [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```

Van bron:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Produceert één enkele geoptimaliseerde binaire file (~5 MB).

## Snelstart

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
Uitvoer wordt standaard opgeslagen naast de invoer als `{name}-watermarked.{ext}`.
Gebruik `-o` om een expliciet uitvoerpad in te stellen, of `-S` voor een aangepast achtervoegsel.

## Watermerktypen

| Vlag | Stijl | Beschrijving |
|---|---|---|
| `diagonal` | Diagonaal raster | Volledige pagina met herhalende diagonale tekst (standaard) |
| `stamp` | Stempel | Grote gecentreerde stempel met dubbele rand |
| `stencil` | Sjabloon | Volledige breedte militaire sjabloonletters |
| `typewriter` | Typemachine | Monogespatieerde typemachinetekst |
| `handwritten` | Handtekening | Handschriftstijl handtekening met onderstreping |
| `redacted` | Geredigeerd | Zwarte redactiebalken over de volledige breedte |
| `badge` | Schild | Beveiligingsschild/-embleem |
| `ribbon` | Lint | Diagonale hoeklintbanner |
| `seal` | Zegel | Circulair notarisstijl zegel |
| `frame` | Kader | Volledige pagina decoratieve rand |
| `tile` | Tegel | Dicht uniform tekstrooster |
| `mosaic` | Mozaïek | Willekeurig verspreide tekst |
| `weave` | Weefsel | In elkaar grijpende diagonale weving |
| `ghost` | Spook | Ultra subtiele reliëftekst |
| `watercolor` | Aquarel | Zachte vervaagde was-effecten |
| `noise` | Ruis | Versleten tekst met pixelruis |
| `halftone` | Raster | Tekst als raster van halve toonpunten |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Beveiligingsfiligrain

firemark legt cryptografische filigrainpatronen over die geïnspireerd zijn op beveiligingskenmerken van bankbiljetten. Deze fijne geometrische patronen zijn uiterst moeilijk te verwijderen met afbeeldingsbewerkingsprogramma’s.

| Stijl | Beschrijving |
|---|---|
| `guilloche` | Sinusvormige golvende banden (standaard) |
| `rosette` | Spirograaf + roosvormige hoekkrommen |
| `crosshatch` | Fijne diagonale diamantstructuur |
| `border` | Golvende geneste beveiligingsrand |
| `lissajous` | Parametrische Lissajous-figuren |
| `moire` | Concentreerde cirkelinterferentie |
| `spiral` | Archimedische spiraalwerveling |
| `mesh` | Hexagonaal honingraatgrid |
| `plume` | Stromende, veerachtige krommen verspreid over het oppervlak |
| `constellation` | Sterpunten verbonden door een fijn geometrisch web |
| `ripple` | Overlappende elliptische golfpatronen vanuit willekeurige oorsprong |
| `full` | Alle patronen gecombineerd |
| `none` | Filigrain uitschakelen |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## AI-verwijdering hardening

Elke render is standaard niet-deterministisch. firemark past universele
post-render verstoring toe (alpha jitter, sub-pixel kleurruis, edge micro-dots,
spaarzame spookpixels) en per-renderer randomisatie zodat geen twee outputs
pixel-identiek zijn — zelfs met dezelfde instellingen. Dit maakt het onmogelijk voor AI
vision modellen om een voorspelbaar patroon te leren om af te trekken.

Daarbovenop worden adversarial prompt-injectie strips standaard ingebed om
AI-watermerkverwijderingshulpmiddelen te verwarren. Uitschakelen met `--no-anti-ai` als je de zichtbare prompttekst niet wilt:


```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Algemene opties

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

Voor de volledige lijst van meer dan 70 vlaggen, zie [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## PDF-opties

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Batchverwerking

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Bestanden die al voorzien zijn van een watermerk (met overeenkomend achtervoegsel) worden automatisch overgeslagen bij
herhaalde uitvoeringen.

## Configuratiebestand

Sla opties op in een TOML-bestand om het herhalen van vlaggen te vermijden. Zie
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) voor een volledig
voorbeeld met twee presets: **ultra-secure** (dichte betegeling, volledig filigrain, QR
traceerbaarheid, metadata verwijdering) en **light** (eenvoudige diagonale tekst, geen extra’s).

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

## Ondersteunde formaten

| Formaat | Invoer | Uitvoer |
|---|---|---|
| PNG | ja | ja |
| JPEG | ja | ja |
| PDF | ja | ja |
| WebP | ja | ja |
| TIFF | ja | ja |

Cross-formaat conversie wordt ondersteund (bijv. `firemark photo.webp -o out.pdf`).

## Licentie

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---