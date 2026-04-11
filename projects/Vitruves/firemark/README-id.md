<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

<p align="center">Alat watermarking cepat dan single-binary untuk gambar dan PDF. Dibangun dengan Rust.</p>


## Mengapa memberi watermark pada dokumen Anda?

Setiap tahun, jutaan orang menjadi korban penipuan identitas yang dimulai dari
pertukaran dokumen yang sederhana. Skenario yang umum: Anda mencari apartemen untuk disewa.
Pemilik — atau seseorang yang berpura-pura sebagai pemilik — meminta salinan KTP Anda, slip gaji,
atau surat pemberitahuan pajak. Anda mengirimkannya tanpa tanda. "Pemilik" tersebut menghilang, dan
dokumen Anda kini digunakan untuk membuka rekening bank, mengambil pinjaman, atau memalsukan
identitas atas nama Anda.

Memberi watermark pada setiap dokumen yang Anda kirim adalah pertahanan paling efektif.
Tampilan overlay yang terlihat bertuliskan **"Dikirim ke agensi XYZ — Maret 2026 — hanya untuk aplikasi sewa apartemen"** membuat dokumen tersebut tidak berguna untuk tujuan lain. Jika
dokumen bocor, Anda tahu persis dari mana asalnya.

firemark membuat ini sangat mudah: satu perintah, gambar atau PDF apa saja, 17 gaya
visual, pola filigran kriptografis yang tahan terhadap pengeditan, dan pemrosesan batch
untuk seluruh folder.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Sebelum dan sesudah watermarking" width="800">
  <br>
  <em>Sebelum dan sesudah — satu perintah, dokumen kini dapat dilacak dan terbukti jika dirusak.</em>
</p>

## Instalasi

Dari [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```
Dari sumber:


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
Menghasilkan satu berkas biner yang dioptimalkan (~5 MB).

## Mulai cepat


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

Output disimpan berdampingan dengan input sebagai `{name}-watermarked.{ext}` secara default.
Gunakan `-o` untuk menentukan jalur output secara eksplisit, atau `-S` untuk suffix khusus.

## Jenis Watermark

| Flag | Gaya | Deskripsi |
|---|---|---|
| `diagonal` | Grid diagonal | Teks diagonal berulang di seluruh halaman (default) |
| `stamp` | Cap karet | Cap besar di tengah dengan dua garis tepi |
| `stencil` | Stensil | Huruf stensil militer sepanjang halaman |
| `typewriter` | Mesin ketik | Teks monospace gaya mesin ketik |
| `handwritten` | Tanda tangan | Tanda tangan gaya tulisan tangan dengan garis bawah |
| `redacted` | Redaksi | Bar redaksi hitam sepanjang halaman |
| `badge` | Perisai | Emblem perisai/medali keamanan |
| `ribbon` | Pita | Banner pita diagonal di sudut |
| `seal` | Segel | Segel notaris gaya lingkaran |
| `frame` | Bingkai | Bingkai dekoratif di seluruh halaman |
| `tile` | Ubin | Grid teks seragam yang rapat |
| `mosaic` | Mosaik | Teks acak yang tersebar |
| `weave` | Anyaman | Anyaman diagonal yang saling terkait |
| `ghost` | Hantu | Teks emboss ultra-halus |
| `watercolor` | Cat air | Efek sapuan kabur lembut |
| `noise` | Noise | Teks rusak dengan noise piksel |
| `halftone` | Halftone | Teks sebagai grid titik halftone |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigrane Keamanan

firemark menampilkan pola filigrane kriptografi yang terinspirasi dari fitur keamanan uang kertas. Pola geometris halus ini sangat sulit dihapus dengan editor gambar.

| Gaya | Deskripsi |
|---|---|
| `guilloche` | Pita amplop gelombang sinusoidal (default) |
| `rosette` | Spirograf + kurva mawar di sudut |
| `crosshatch` | Kisi berlian diagonal halus |
| `border` | Garis tepi keamanan berlapis bergelombang |
| `lissajous` | Figur parametrik Lissajous |
| `moire` | Interferensi lingkaran konsentris |
| `spiral` | Pusaran spiral Archimedean |
| `mesh` | Kisi sarang lebah heksagonal |
| `plume` | Kurva seperti bulu yang mengalir tersebar di permukaan |
| `constellation` | Titik bintang dihubungkan oleh jaring geometris halus |
| `ripple` | Gelombang elips bertumpuk dari asal acak |
| `full` | Semua pola digabungkan |
| `none` | Menonaktifkan filigrane |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Penguatan Penghapusan AI

Setiap render bersifat non-deterministik secara default. firemark menerapkan
gangguan pasca-render universal (jitter alpha, noise warna sub-piksel, mikro-titik tepi,
piksel hantu jarang) dan pengacakan per-renderer sehingga tidak ada dua output yang
identik secara piksel — bahkan dengan pengaturan yang sama. Ini membuat model visi AI
tidak mungkin mempelajari pola yang dapat diprediksi untuk dikurangi.

Selain itu, strip injeksi prompt adversarial disematkan secara default untuk
membingungkan alat penghapus watermark AI. Nonaktifkan dengan `--no-anti-ai` jika Anda tidak
menginginkan teks prompt yang terlihat:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Opsi umum

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

Untuk daftar lengkap lebih dari 70 flag, lihat [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Opsi PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Pemrosesan batch

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
File yang sudah diberi watermark (yang cocok dengan akhiran) akan otomatis dilewati pada
pengulangan proses.

## Berkas Konfigurasi

Simpan opsi di dalam berkas TOML untuk menghindari pengulangan flag. Lihat
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) untuk contoh lengkap
dengan dua preset: **ultra-secure** (penyusunan padat, filigrane penuh, pelacakan QR,
penghapusan metadata) dan **light** (teks diagonal sederhana, tanpa tambahan).


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

## Dukungan format

| Format | Input | Output |
|---|---|---|
| PNG | ya | ya |
| JPEG | ya | ya |
| PDF | ya | ya |
| WebP | ya | ya |
| TIFF | ya | ya |

Konversi lintas format didukung (misalnya `firemark photo.webp -o out.pdf`).

## Lisensi

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---