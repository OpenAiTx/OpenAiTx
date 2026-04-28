
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Mesin Query SQL Berkinerja Tinggi untuk File CSV

 [![Cross-Build and Test (dengan sistem build zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Sebuah pemroses query SQL ringan dan cepat yang ditulis dalam bahasa C, memungkinkan eksekusi query SQL langsung pada file CSV tanpa memerlukan basis data. Untuk dokumentasi lengkap, lihat direktori /doc.

 ![cq dalam aksi](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Dokumentasi

- Memulai: `doc/GettingStarted.md`
- Instalasi: `doc/Installation.md`
- Antarmuka Baris Perintah: `doc/CLI.md`
- **TUI (Antarmuka Pengguna Terminal)**: `doc/TUI.md`
- Arsitektur: `doc/Architecture.md`
- Pengujian: `doc/Testing.md`
- Peta Jalan: `doc/Roadmap.md`
- Kontribusi: `doc/Contributing.md`

## Mulai Cepat

Build: `make`

### Baris Perintah

Jalankan contoh kueri:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal UI

Luncurkan TUI interaktif:
`./build/cqtui data/`

Fitur:
- Menjelajah dan membuka file CSV sebagai tabel
- Menjalankan kueri SQL secara interaktif
- Antarmuka multi-tab untuk banyak tabel
- Navigasi menggunakan keyboard
- Tanpa dependensi eksternal

## Contoh File SQL

Repositori ini menyertakan contoh SQL di bawah assets/ (example_between.sql, example_aggregation.sql, dll.). Lihat assets/ untuk detailnya.

## Ikhtisar Data & Fitur

- Lihat folder /doc untuk bagian terperinci tentang tipe data, format tanggal, format CSV, dan lainnya.

## Lisensi

Lisensi MIT. Lihat berkas LICENSE untuk detailnya.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---