# Spesifikasi Universal Tool Calling Protocol (UTCP)

Repositori ini berisi dokumentasi spesifikasi resmi untuk Universal Tool Calling Protocol (UTCP). UTCP adalah standar modern, fleksibel, dan skalabel untuk mendefinisikan dan berinteraksi dengan alat di berbagai protokol komunikasi.

## Apa itu UTCP?

UTCP menyediakan cara yang terstandarisasi bagi sistem AI dan klien lain untuk menemukan dan memanggil alat dari berbagai penyedia, tanpa memandang protokol dasar yang digunakan (HTTP, WebSocket, CLI, dll.). Spesifikasi ini mendefinisikan:

- Mekanisme penemuan alat
- Format pemanggilan alat
- Konfigurasi penyedia
- Metode otentikasi
- Penanganan respons

## Berkontribusi pada Spesifikasi

Kami menyambut kontribusi untuk spesifikasi UTCP! Berikut cara Anda dapat berkontribusi:

1. **Fork repositori**: Buat fork repositori spesifikasi Anda sendiri
2. **Lakukan perubahan**: Perbarui atau tambahkan dokumentasi sesuai kebutuhan
3. **Kirim pull request**: Buka PR dengan perubahan Anda untuk ditinjau
4. **Ikut dalam diskusi**: Bergabunglah dalam percakapan tentang perubahan yang diusulkan

Saat berkontribusi, harap ikuti pedoman berikut:

- Pastikan perubahan Anda selaras dengan visi dan tujuan utama UTCP
- Ikuti struktur dan format dokumentasi yang telah ditetapkan
- Sertakan contoh saat menambahkan fitur atau konsep baru
- Perbarui bagian terkait agar tetap konsisten di seluruh dokumentasi

## Membangun Dokumentasi Secara Lokal

### Prasyarat

Untuk membangun dan meninjau situs dokumentasi secara lokal, Anda akan membutuhkan:

- Ruby versi 2.5.0 atau lebih tinggi
- RubyGems
- Bundler

### Penyiapan

1. Clone repositori:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Instal dependensi:

   ```bash
   bundle install
   ```
### Menjalankan Situs Dokumentasi

Untuk membangun dan menjalankan situs secara lokal:


```bash
bundle exec jekyll serve
```
Ini akan memulai server web lokal di `http://localhost:4000` di mana Anda dapat melihat pratinjau dokumentasi.

## Struktur Dokumentasi

Dokumentasi UTCP diorganisasikan sebagai berikut:

- `index.md`: Beranda dan pengenalan UTCP
- `docs/`
  - `introduction.md`: Pengenalan terperinci dan konsep inti
  - `for-tool-providers.md`: Panduan untuk implementasi penyedia alat
  - `for-tool-callers.md`: Panduan untuk implementasi pemanggil alat
  - `providers/`: Dokumentasi untuk setiap tipe penyedia
    - `http.md`: Penyedia HTTP
    - `websocket.md`: Penyedia WebSocket
    - `cli.md`: Penyedia CLI
    - `sse.md`: Penyedia Server-Sent Events
    - dll.
  - `implementation.md`: Panduan implementasi dan praktik terbaik

## Bekerja dengan Spesifikasi

### Memodifikasi Dokumentasi

Dokumentasi ditulis dalam format Markdown dengan Jekyll front matter. Saat melakukan perubahan:

1. Pastikan Markdown Anda mengikuti gaya yang telah ditetapkan
2. Pratinjau perubahan secara lokal sebelum mengirim PR
3. Pastikan contoh selalu sesuai dengan spesifikasi terbaru
4. Perbarui item navigasi di `_config.yml` jika menambah halaman baru

### Organisasi Berkas

Saat menambah dokumentasi baru:

- Tempatkan dokumentasi spesifik penyedia di `docs/providers/`
- Gunakan front matter yang konsisten dengan urutan navigasi yang sesuai
- Sertakan tag untuk meningkatkan kemampuan pencarian di GitHub Pages

## Kontrol Versi

Spesifikasi UTCP mengikuti semantic versioning:

- Versi mayor (1.0, 2.0): Perubahan besar pada protokol
- Versi minor (1.1, 1.2): Penambahan fitur baru yang tetap kompatibel ke belakang
- Versi patch (1.0.1, 1.0.2): Perbaikan bug dan klarifikasi yang kompatibel ke belakang

## Lisensi

Spesifikasi ini didistribusikan di bawah Mozilla Public License 2.0 (MPL-2.0).

## Sumber Daya Tambahan

- [Organisasi UTCP di GitHub](https://github.com/universal-tool-calling-protocol)
- [Situs Web UTCP](https://utcp.io)
- [Implementasi Referensi](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Diskusi Komunitas](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---