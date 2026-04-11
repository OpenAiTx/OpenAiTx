
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

<p align="center">Uno strumento veloce, a binario singolo, per filigranare immagini e PDF. Sviluppato in Rust.</p>

## Perché filigranare i tuoi documenti?

Ogni anno, milioni di persone sono vittime di frodi d'identità che iniziano con un
semplice scambio di documenti. Uno scenario comune: stai cercando un appartamento in affitto.
Il proprietario — o qualcuno che si spaccia per tale — chiede una copia del tuo documento, una busta paga,
una dichiarazione dei redditi. Glieli mandi senza alcun segno distintivo. Il "proprietario" scompare, e i tuoi
documenti vengono ora utilizzati per aprire conti bancari, richiedere prestiti o falsificare
identità a tuo nome.

Applicare una filigrana a ogni documento che invii è la difesa più efficace in assoluto.
Una sovrapposizione visibile con la dicitura **"Inviato all'agenzia XYZ — Marzo 2026 — solo per domanda di affitto"**
rende il documento inutile per qualsiasi altro scopo. Se viene divulgato, sai esattamente da dove proviene.

firemark rende tutto questo senza sforzo: un solo comando, qualsiasi immagine o PDF, 17 stili
visivi, motivi filigranati crittografici che resistono alla modifica e
elaborazione in batch per intere cartelle.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Prima e dopo la filigranatura" width="800">
  <br>
  <em>Prima e dopo — un comando, il documento ora è tracciabile e manomissione evidente.</em>
</p>

## Installazione

Da [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```

Dalla fonte:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Produce un singolo binario ottimizzato (~5 MB).

## Avvio rapido

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

L'output viene salvato insieme all'input come `{name}-watermarked.{ext}` per impostazione predefinita.
Usa `-o` per impostare un percorso di output esplicito, oppure `-S` per un suffisso personalizzato.

## Tipi di filigrana

| Flag | Stile | Descrizione |
|---|---|---|
| `diagonal` | Griglia diagonale | Testo diagonale ripetuto su tutta la pagina (predefinito) |
| `stamp` | Timbro | Grande timbro centrale con doppio bordo |
| `stencil` | Stencil | Lettere stencil militari a tutta larghezza |
| `typewriter` | Macchina da scrivere | Testo monospaziato stile macchina da scrivere |
| `handwritten` | Firma | Firma in stile manoscritto con sottolineatura |
| `redacted` | Redazione | Barre nere di redazione a tutta larghezza |
| `badge` | Scudo | Emblema di scudo/distintivo di sicurezza |
| `ribbon` | Nastro | Banner diagonale a nastro sull’angolo |
| `seal` | Sigillo | Sigillo notarile circolare |
| `frame` | Cornice | Bordo decorativo su tutta la pagina |
| `tile` | Piastrella | Griglia di testo uniforme e densa |
| `mosaic` | Mosaico | Testo sparso casualmente |
| `weave` | Intreccio | Intreccio diagonale interconnesso |
| `ghost` | Fantasma | Testo ultra-sottile in rilievo |
| `watercolor` | Acquerello | Effetto lavaggio sfumato e morbido |
| `noise` | Rumore | Testo rovinato con rumore di pixel |
| `halftone` | Mezzetinte | Testo come griglia di punti mezzetinte |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigrane di sicurezza

firemark sovrappone motivi crittografici di filigrana ispirati alle
caratteristiche di sicurezza delle banconote. Questi fini motivi geometrici sono estremamente difficili da
rimuovere con editor di immagini.

| Stile | Descrizione |
|---|---|
| `guilloche` | Bande sinusoidali ondulate (predefinito) |
| `rosette` | Spirografo + curve a rosa agli angoli |
| `crosshatch` | Griglia a losanghe diagonali sottili |
| `border` | Bordo di sicurezza ondulato annidato |
| `lissajous` | Figure parametriche di Lissajous |
| `moire` | Interferenza di cerchi concentrici |
| `spiral` | Vortice a spirale di Archimede |
| `mesh` | Griglia a nido d’ape esagonale |
| `plume` | Curve fluenti simili a piume sparse sulla superficie |
| `constellation` | Nodi stellari collegati da una fine rete geometrica |
| `ripple` | Fronti d’onda ellittici sovrapposti da origini casuali |
| `full` | Tutti i motivi combinati |
| `none` | Disabilita filigrana |

```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Durezza contro la rimozione da parte dell'IA

Ogni rendering è non deterministico per impostazione predefinita. firemark applica una
perturbazione universale post-render (jitter dell'alpha, rumore cromatico sub-pixel, micro-punti sui bordi,
pixel fantasma sparsi) e una randomizzazione per ogni renderer, così che nessun output sia
pixel-identico — anche con le stesse impostazioni. Questo rende impossibile per i modelli di visione IA
apprendere un pattern prevedibile da sottrarre.

Inoltre, per impostazione predefinita vengono incorporate strisce di injection avversaria del prompt
per confondere gli strumenti di rimozione del watermark da parte dell'IA. Disattiva con `--no-anti-ai` se non
vuoi il testo visibile del prompt:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Opzioni comuni

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

Per l'elenco completo di oltre 70 flag, consulta [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Opzioni PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Elaborazione batch

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
I file già filigranati (che corrispondono al suffisso) vengono automaticamente saltati nei
riavvii.

## File di configurazione

Salva le opzioni in un file TOML per evitare di ripetere i flag. Vedi
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) per un
esempio completo con due preset: **ultra-sicuro** (tassellatura fitta, filigrana completa, tracciabilità QR,
rimozione dei metadati) e **leggero** (semplice testo diagonale, senza extra).


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

## Supporto formati

| Formato | Input | Output |
|---|---|---|
| PNG | sì | sì |
| JPEG | sì | sì |
| PDF | sì | sì |
| WebP | sì | sì |
| TIFF | sì | sì |

La conversione tra formati diversi è supportata (es. `firemark photo.webp -o out.pdf`).

## Licenza

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---