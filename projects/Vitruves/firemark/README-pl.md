<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

<p align="center">Szybkie, jednoplikowe narzędzie do znakowania wodnego obrazów i plików PDF. Napisane w Rust.</p>


## Dlaczego warto oznaczać dokumenty znakiem wodnym?

Co roku miliony osób padają ofiarą kradzieży tożsamości, która zaczyna się od
zwykłej wymiany dokumentów. Typowy scenariusz: szukasz mieszkania do wynajęcia.
Wynajmujący — lub ktoś, kto się za niego podaje — prosi o kopię Twojego dowodu, pasek
wynagrodzeń, zaświadczenie podatkowe. Wysyłasz je bez znaków wodnych. "Wynajmujący" znika,
a Twoje dokumenty są wykorzystywane do otwierania kont bankowych, zaciągania kredytów lub
fałszowania tożsamości na Twoje nazwisko.

Oznaczanie znakiem wodnym każdego wysyłanego dokumentu to najskuteczniejsza obrona.
Widoczny napis, np. **"Wysłano do agencji XYZ — marzec 2026 — tylko do wniosku o wynajem mieszkania"**
sprawia, że dokument staje się bezużyteczny w innym celu. Jeśli wycieknie, wiesz dokładnie, skąd.

firemark sprawia, że to proste: jedno polecenie, dowolny obraz lub PDF, 17 stylów
wizualnych, kryptograficzne filigranowe wzory odporne na edycję oraz
przetwarzanie wsadowe całych folderów.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Przed i po oznaczeniu znakiem wodnym" width="800">
  <br>
  <em>Przed i po — jedno polecenie, dokument jest teraz identyfikowalny i zabezpieczony przed manipulacją.</em>
</p>

## Instalacja

Z [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```

Ze źródła:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Tworzy pojedynczy zoptymalizowany plik binarny (~5 MB).

## Szybki start

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

Wynik jest domyślnie zapisywany obok pliku wejściowego jako `{name}-watermarked.{ext}`.
Użyj `-o`, aby ustawić konkretną ścieżkę zapisu, lub `-S` dla własnego sufiksu.

## Rodzaje znaków wodnych

| Flaga | Styl | Opis |
|---|---|---|
| `diagonal` | Siatka ukośna | Powtarzający się ukośny tekst na całej stronie (domyślny) |
| `stamp` | Pieczęć | Duża, wyśrodkowana pieczęć z podwójną ramką |
| `stencil` | Szablon | Tekst wojskowy na całą szerokość strony |
| `typewriter` | Maszyna do pisania | Tekst maszynowy o stałej szerokości znaków |
| `handwritten` | Podpis | Stylizowany, odręczny podpis z podkreśleniem |
| `redacted` | Redakcja | Czarny pasek redakcyjny na całą szerokość |
| `badge` | Odznaka | Emblemat tarczy/odznaki bezpieczeństwa |
| `ribbon` | Wstęga | Ukośny baner narożny w formie wstęgi |
| `seal` | Pieczęć okrągła | Okrągła pieczęć notarialna |
| `frame` | Ramka | Dekoracyjna ramka na całą stronę |
| `tile` | Kafelek | Gęsta, jednolita siatka tekstu |
| `mosaic` | Mozaika | Losowo rozrzucony tekst |
| `weave` | Splot | Przeplatający się ukośny splot |
| `ghost` | Duch | Bardzo subtelny, wypukły tekst |
| `watercolor` | Akwarela | Miękki, rozmyty efekt tła |
| `noise` | Szum | Zniekształcony tekst z szumem pikselowym |
| `halftone` | Raster | Tekst jako siatka punktowa rastra |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigran bezpieczeństwa

firemark nakłada kryptograficzne wzory filigranów inspirowane zabezpieczeniami banknotów.
Te drobne geometryczne wzory są niezwykle trudne do usunięcia za pomocą edytorów graficznych.

| Styl | Opis |
|---|---|
| `guilloche` | Pasma sinusoidalnych fal (domyślnie) |
| `rosette` | Krzywe spirografu + rozety w rogach |
| `crosshatch` | Drobna ukośna kratka w romby |
| `border` | Falisty, zagnieżdżony obramowanie zabezpieczające |
| `lissajous` | Parametryczne figury Lissajous |
| `moire` | Koncentryczne interferencje okręgów |
| `spiral` | Wir spiralny Archimedesa |
| `mesh` | Sześciokątna siatka plastra miodu |
| `plume` | Płynące, pierzaste krzywe rozrzucone po powierzchni |
| `constellation` | Gwiaździste węzły połączone drobną siecią geometryczną |
| `ripple` | Nakładające się eliptyczne fronty fal z losowych punktów |
| `full` | Wszystkie wzory połączone |
| `none` | Wyłącz filigran |


```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Utwardzanie przed usuwaniem przez AI

Każde renderowanie jest domyślnie niedeterministyczne. firemark stosuje uniwersalne
zaburzenia po renderowaniu (drgania alfa, szum kolorów podpikselowych, mikro-kropki na krawędziach,
rzadkie piksele-duchy) oraz losowanie specyficzne dla renderera, dzięki czemu żadne dwa wyniki
nie są identyczne pod względem pikseli — nawet przy tych samych ustawieniach. Uniemożliwia to modelom
wizji AI nauczenie się przewidywalnego wzorca do odejmowania.

Dodatkowo, domyślnie osadzane są paski z adwersarialnym wstrzykiwaniem promptów,
by zmylić narzędzia AI do usuwania znaków wodnych. Wyłącz opcją `--no-anti-ai`,
jeśli nie chcesz widocznego tekstu promptu:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Typowe opcje

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

Pełną listę ponad 70 flag znajdziesz w [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Opcje PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Przetwarzanie wsadowe

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Pliki już oznaczone znakami wodnymi (pasujące do sufiksu) są automatycznie pomijane podczas ponownych uruchomień.

## Plik konfiguracyjny

Zapisz opcje w pliku TOML, aby uniknąć powtarzania flag. Zobacz
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) dla pełnego
przykładu z dwoma presetami: **ultra-secure** (gęste kafelkowanie, pełny filigran, śledzenie QR, usuwanie metadanych) oraz **light** (prosty ukośny tekst, bez dodatków).



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

## Obsługa formatów

| Format | Wejście | Wyjście |
|---|---|---|
| PNG | tak | tak |
| JPEG | tak | tak |
| PDF | tak | tak |
| WebP | tak | tak |
| TIFF | tak | tak |

Obsługiwana jest konwersja między formatami (np. `firemark photo.webp -o out.pdf`).

## Licencja

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---