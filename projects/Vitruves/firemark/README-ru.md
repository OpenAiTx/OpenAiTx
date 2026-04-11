<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

<p align="center">Быстрый однобинарный инструмент для нанесения водяных знаков на изображения и PDF. Разработан на Rust.</p>


## Зачем водяные знаки на ваших документах?

Ежегодно миллионы людей становятся жертвами мошенничества с личными данными, которое начинается с простой передачи документов. Обычная ситуация: вы ищете квартиру для аренды. Арендодатель — или тот, кто им представляется — просит копию вашего удостоверения личности, справку о доходах, налоговое уведомление. Вы отправляете их без пометок. "Арендодатель" исчезает, и ваши документы используются для открытия счетов, оформления кредитов или подделки личностей от вашего имени.

Водяной знак на каждом отправляемом документе — самая эффективная защита. Видимая надпись **"Отправлено в агентство XYZ — март 2026 — только для заявки на аренду квартиры"** делает документ бесполезным для других целей. Если он утечет, вы точно знаете источник.

firemark делает это простым: одна команда, любое изображение или PDF, 17 визуальных стилей, криптографические филлигранные узоры, устойчивые к редактированию, и пакетная обработка целых папок.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="До и после нанесения водяного знака" width="800">
  <br>
  <em>До и после — одна команда, документ теперь отслеживаем и защищён от подделки.</em>
</p>

## Установка

С [crates.io](https://crates.io/crates/firemark):











```bash
cargo install firemark
```

Из источника:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Генерирует один оптимизированный бинарный файл (~5 МБ).

## Быстрый старт

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

Вывод по умолчанию сохраняется рядом с входным файлом как `{name}-watermarked.{ext}`.
Используйте `-o` для явного указания пути вывода или `-S` для задания собственного суффикса.

## Типы водяных знаков

| Флаг | Стиль | Описание |
|---|---|---|
| `diagonal` | Диагональная сетка | Повторяющийся по всей странице диагональный текст (по умолчанию) |
| `stamp` | Штамп | Крупный центральный штамп с двойной рамкой |
| `stencil` | Трафарет | Текст по всей ширине страницы в стиле военного трафарета |
| `typewriter` | Печатная машинка | Моноширинный текст в стиле печатной машинки |
| `handwritten` | Подпись | Подпись в рукописном стиле с подчеркиванием |
| `redacted` | Редакция | Черные полосы по всей ширине страницы |
| `badge` | Щит | Эмблема в виде защитного щита/значка |
| `ribbon` | Лента | Диагональная угловая ленточная плашка |
| `seal` | Печать | Круглая печать в стиле нотариуса |
| `frame` | Рамка | Декоративная рамка по всей странице |
| `tile` | Плитка | Плотная равномерная текстовая сетка |
| `mosaic` | Мозаика | Случайно разбросанный текст |
| `weave` | Переплетение | Перекрещивающееся диагональное переплетение |
| `ghost` | Призрак | Очень ненавязчивый тисненый текст |
| `watercolor` | Акварель | Мягкий размытый акварельный эффект |
| `noise` | Шум | Искажённый текст с пиксельным шумом |
| `halftone` | Полутон | Текст в виде сетки из точек полутонов |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Защитная филигрань

firemark накладывает криптографические филигранные узоры, вдохновлённые
защитными элементами банкнот. Эти тонкие геометрические рисунки чрезвычайно сложно
удалить с помощью графических редакторов.

| Стиль | Описание |
|---|---|
| `guilloche` | Синусоидальные волновые полосы (по умолчанию) |
| `rosette` | Спирограф + розовые изгибы по углам |
| `crosshatch` | Мелкая диагональная ромбовидная сетка |
| `border` | Волнистая вложенная защитная рамка |
| `lissajous` | Параметрические фигуры Лиссажу |
| `moire` | Концентрические круговые интерференции |
| `spiral` | Архимедов вихревой спираль |
| `mesh` | Шестиугольная сотовая решетка |
| `plume` | Текучие перообразные кривые, разбросанные по поверхности |
| `constellation` | Звёздные узлы, соединённые тонкой геометрической сетью |
| `ripple` | Перекрывающиеся эллиптические волновые фронты из случайных точек |
| `full` | Все узоры вместе |
| `none` | Отключить филигрань |

```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Укрепление против удаления ИИ

Каждая визуализация по умолчанию является недетерминированной. firemark применяет универсальное
возмущение после рендеринга (джиттер альфа-канала, шум цвета на субпиксельном уровне, микро-точки на краях,
редкие призрачные пиксели) и рандомизацию для каждого рендерера, чтобы ни один из выходных результатов не был
идентичным по пикселям — даже при одинаковых настройках. Это делает невозможным для моделей компьютерного зрения ИИ
выучить предсказуемый шаблон для вычитания.

Кроме того, по умолчанию внедряются полосы с враждебной инъекцией подсказок,
чтобы сбивать с толку инструменты ИИ для удаления водяных знаков. Отключите с помощью `--no-anti-ai`, если вы не хотите
видимого текста подсказки:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Общие параметры

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

Полный список из более чем 70 флагов см. в [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Параметры PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Пакетная обработка

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Уже содержащие водяной знак файлы (с соответствующим суффиксом) автоматически пропускаются при
повторных запусках.

## Файл конфигурации

Сохраните параметры в файле TOML, чтобы не повторять флаги. См.
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) для полного
примера с двумя пресетами: **ultra-secure** (плотная сетка, полный филигрань, QR-
отслеживание, удаление метаданных) и **light** (простой диагональный текст, без дополнительных функций).

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

## Поддержка форматов

| Формат | Вход | Выход |
|---|---|---|
| PNG | да | да |
| JPEG | да | да |
| PDF | да | да |
| WebP | да | да |
| TIFF | да | да |

Поддерживается конвертация между форматами (например, `firemark photo.webp -o out.pdf`).

## Лицензия

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---