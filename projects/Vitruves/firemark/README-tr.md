
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

<p align="center">Görseller ve PDF'ler için hızlı, tek dosyalık filigran ekleme aracı. Rust ile geliştirilmiştir.</p>

## Belgelerinizi neden filigranlamalısınız?

Her yıl milyonlarca insan, basit bir belge paylaşımıyla başlayan kimlik dolandırıcılığının kurbanı oluyor.
Yaygın bir senaryo: Kiralık bir daire arıyorsunuz.
Ev sahibi — veya ev sahibi gibi davranan biri — sizden kimlik fotokopisi, maaş bordrosu, vergi bildirimi istiyor.
Siz de bunları işaretsiz olarak gönderiyorsunuz.
"Ev sahibi" ortadan kayboluyor ve belgeleriniz artık banka hesabı açmak, kredi çekmek veya adınıza kimlik sahtekarlığı yapmak için kullanılıyor.

Gönderdiğiniz her belgeye filigran eklemek, en etkili savunma yöntemidir.
**"XYZ ajansına gönderildi — Mart 2026 — yalnızca daire başvurusu"** yazan görünür bir katman, belgeyi başka amaçlar için işe yaramaz hale getirir.
Eğer belge sızarsa, tam olarak nereden geldiğini bilirsiniz.

firemark bunu zahmetsizce yapar: tek bir komut, herhangi bir resim veya PDF, 17 görsel stil, düzenlemeye karşı dirençli kriptografik filigran desenleri ve tüm klasörler için toplu işlem.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Filigran öncesi ve sonrası" width="800">
  <br>
  <em>Öncesi ve sonrası — tek komutla belge artık izlenebilir ve değişiklik tespit edilebilir.</em>
</p>

## Kurulum

[crates.io](https://crates.io/crates/firemark) adresinden:





```bash
cargo install firemark
```

Kaynak:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Tek bir optimize edilmiş ikili dosya üretir (~5 MB).

## Hızlı başlangıç

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

Çıktı, varsayılan olarak girişin yanında `{name}-watermarked.{ext}` olarak kaydedilir.
Belirli bir çıktı yolu ayarlamak için `-o`, özel bir ek için ise `-S` kullanın.

## Filigran türleri

| Bayrak | Stil | Açıklama |
|---|---|---|
| `diagonal` | Diyagonal ızgara | Tam sayfa tekrarlayan diyagonal metin (varsayılan) |
| `stamp` | Kaşe | Çift kenarlı büyük ortalanmış kaşe damga |
| `stencil` | Şablon | Tam genişlikte askeri şablon harfler |
| `typewriter` | Daktilo | Tek aralıklı daktilo metni |
| `handwritten` | İmzalı | Altı çizili el yazısı imza tarzı |
| `redacted` | Karartma | Tam genişlikte siyah karartma çubukları |
| `badge` | Rozet | Güvenlik kalkanı/rozet amblemi |
| `ribbon` | Şerit | Diyagonal köşe şerit afiş |
| `seal` | Mühür | Dairesel noter tarzı mühür |
| `frame` | Çerçeve | Tam sayfa dekoratif kenarlık |
| `tile` | Doku | Yoğun, düzgün metin ızgarası |
| `mosaic` | Mozaik | Rastgele dağılmış metinler |
| `weave` | Örgü | Birbirine geçen diyagonal örgü |
| `ghost` | Hayalet | Çok ince kabartmalı metin |
| `watercolor` | Sulu boya | Yumuşak, bulanık renk efekti |
| `noise` | Gürültü | Piksel gürültülü bozulmuş metin |
| `halftone` | Yarı ton | Metin, yarı tonlu nokta ızgarası şeklinde |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Güvenlik filigranı

firemark, banknot güvenlik özelliklerinden esinlenen kriptografik filigran desenlerini üst üste bindirir.
Bu ince geometrik desenler, görsel düzenleyicilerle çıkarmak son derece zordur.

| Stil | Açıklama |
|---|---|
| `guilloche` | Sinüzoidal dalga zarf bantları (varsayılan) |
| `rosette` | Spirograf + köşe gül eğrileri |
| `crosshatch` | İnce çapraz elmas örgü |
| `border` | Dalgalı iç içe güvenlik bordürü |
| `lissajous` | Parametrik Lissajous şekilleri |
| `moire` | Eşmerkezli daire girişimi |
| `spiral` | Arşimet spirali girdabı |
| `mesh` | Altıgen bal peteği ızgarası |
| `plume` | Yüzeye dağılmış, akıcı tüy benzeri eğriler |
| `constellation` | İnce geometrik ağ ile bağlanmış yıldız düğümleri |
| `ripple` | Rastgele noktalardan çıkan üst üste eliptik dalga cepheleri |
| `full` | Tüm desenler bir arada |
| `none` | Filigranı devre dışı bırak |


```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## AI-kaldırma güçlendirmesi

Her render varsayılan olarak deterministik değildir. firemark, evrensel
render sonrası bozulma (alfa titremesi, alt-piksel renk gürültüsü, kenar mikro-noktaları,
seyrek hayalet pikseller) ve render başına rastgeleleştirme uygular; böylece aynı ayarlarla
bile hiçbir iki çıktı piksel olarak özdeş olmaz. Bu, AI
görsel modellerinin çıkarılacak öngörülebilir bir deseni öğrenmesini imkansız kılar.

Buna ek olarak, düşmanca prompt-enjeksiyon şeritleri varsayılan olarak gömülüdür;
AI filigran kaldırma araçlarını şaşırtır. Görünür prompt metnini istemiyorsanız
`--no-anti-ai` ile devre dışı bırakabilirsiniz:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Genel seçenekler

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

70'ten fazla bayrağın tam listesi için [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md) dosyasına bakınız.

## PDF seçenekleri

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Toplu işleme

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Zaten filigranlanmış dosyalar (uygun sonek ile eşleşenler) yeniden çalıştırmalarda otomatik olarak atlanır.

## Yapılandırma dosyası

Seçenekleri tekrar tekrar bayrak belirtmekten kaçınmak için bir TOML dosyasında kaydedin. Tam
örnek için [`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) adresine bakın;
iki ön ayar içerir: **ultra-güvenli** (yoğun döşeme, tam filigran, QR
izlenebilirlik, meta veri temizleme) ve **hafif** (basit çapraz metin, ekstra yok).


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

## Format desteği

| Format | Girdi | Çıktı |
|---|---|---|
| PNG | evet | evet |
| JPEG | evet | evet |
| PDF | evet | evet |
| WebP | evet | evet |
| TIFF | evet | evet |

Çapraz format dönüştürme desteklenir (ör. `firemark photo.webp -o out.pdf`).

## Lisans

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---