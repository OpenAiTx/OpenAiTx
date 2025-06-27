# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Repositori ini berisi Gemini CLI, sebuah alat alur kerja AI berbasis command-line yang terhubung ke
alat Anda, memahami kode Anda, dan mempercepat alur kerja Anda.

Dengan Gemini CLI, Anda dapat:

- Menelusuri dan mengedit basis kode besar di dalam dan di luar jendela konteks 1M token Gemini.
- Menghasilkan aplikasi baru dari PDF atau sketsa, menggunakan kemampuan multimodal Gemini.
- Mengotomatisasi tugas operasional, seperti menelusuri pull request atau menangani rebase yang kompleks.
- Menggunakan alat dan server MCP untuk menghubungkan kemampuan baru, termasuk [generasi media dengan Imagen,
  Veo atau Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Menguatkan kueri Anda dengan alat [Google Search](https://ai.google.dev/gemini-api/docs/grounding),
  yang sudah terintegrasi dalam Gemini.

## Quickstart

1. **Prasyarat:** Pastikan Anda telah memasang [Node.js versi 18](https://nodejs.org/en/download) atau lebih tinggi.
2. **Jalankan CLI:** Eksekusi perintah berikut di terminal Anda:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Atau instal dengan:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Pilih tema warna**
4. **Autentikasi:** Saat diminta, masuklah dengan akun Google pribadi Anda. Ini akan memberikan Anda hingga 60 permintaan model per menit dan 1.000 permintaan model per hari menggunakan Gemini.

Sekarang Anda siap menggunakan Gemini CLI!

### Untuk penggunaan lanjutan atau peningkatan batas:

Jika Anda perlu menggunakan model tertentu atau membutuhkan kapasitas permintaan yang lebih tinggi, Anda dapat menggunakan API key:

1. Hasilkan kunci dari [Google AI Studio](https://aistudio.google.com/apikey).
2. Atur sebagai variabel lingkungan di terminal Anda. Ganti `YOUR_API_KEY` dengan kunci yang sudah Anda buat.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Untuk metode autentikasi lainnya, termasuk akun Google Workspace, lihat panduan [autentikasi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Contoh

Setelah CLI berjalan, Anda dapat mulai berinteraksi dengan Gemini dari shell Anda.

Anda dapat memulai proyek dari direktori baru:

```sh
cd new-project/
gemini
> Buatkan saya bot Discord Gemini yang menjawab pertanyaan menggunakan file FAQ.md yang akan saya sediakan
```

Atau bekerja dengan proyek yang sudah ada:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Berikan saya ringkasan semua perubahan yang terjadi kemarin
```

### Langkah selanjutnya

- Pelajari cara [berkontribusi atau membangun dari sumber](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Jelajahi **[Perintah CLI yang tersedia](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Jika Anda menemui masalah, tinjau **[panduan pemecahan masalah](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Untuk dokumentasi lebih lengkap, lihat [dokumentasi lengkap](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Lihat beberapa [tugas populer](#popular-tasks) untuk inspirasi lebih lanjut.

### Pemecahan Masalah

Kunjungi panduan [pemecahan masalah](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) jika Anda mengalami kendala.

## Tugas Populer

### Jelajahi basis kode baru

Mulai dengan melakukan `cd` ke dalam repositori yang sudah ada atau yang baru di-clone dan jalankan `gemini`.

```text
> Jelaskan bagian utama dari arsitektur sistem ini.
```

```text
> Mekanisme keamanan apa saja yang diterapkan?
```

### Bekerja dengan kode yang sudah ada

```text
> Implementasikan draft pertama untuk GitHub issue #123.
```

```text
> Bantu saya migrasi basis kode ini ke versi Java terbaru. Mulai dengan rencana.
```

### Otomatiskan alur kerja Anda

Gunakan server MCP untuk mengintegrasikan alat sistem lokal Anda dengan suite kolaborasi perusahaan Anda.

```text
> Buatkan saya presentasi slide yang menunjukkan riwayat git selama 7 hari terakhir, dikelompokkan berdasarkan fitur dan anggota tim.
```

```text
> Buat aplikasi web layar penuh untuk tampilan dinding yang menampilkan isu GitHub kami yang paling sering diinteraksi.
```

### Berinteraksi dengan sistem Anda

```text
> Konversi semua gambar di direktori ini ke png, dan ubah nama file menggunakan tanggal dari data exif.
```

```text
> Organisir faktur PDF saya berdasarkan bulan pengeluaran.
```

## Ketentuan Layanan dan Pemberitahuan Privasi

Untuk detail mengenai ketentuan layanan dan pemberitahuan privasi yang berlaku untuk penggunaan Gemini CLI Anda, lihat [Ketentuan Layanan dan Pemberitahuan Privasi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---