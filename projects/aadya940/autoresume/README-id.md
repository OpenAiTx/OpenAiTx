<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Pembangun resume open-source, tempelkan tautan Anda, edit secara manual, dan biarkan AI membantu dalam memperbaiki, memperbarui, dan menyesuaikan resume Anda.</b>
</p>

---

### Bagaimana cara menggunakannya?

[Tautan Blog Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Blog ini sudah tidak sesuai dengan Antarmuka Pengguna dan Template yang digunakan.

## Fitur

- <b>Impor Tautan Mudah:</b> Tempel tautan dari situs web, dan dengan cepat buat resume PDF.
- <b>Editor Manual Tersedia:</b> Sempurnakan atau bangun resume Anda dari awal dengan editor kode tersemat.
- <b>Saran Pintar:</b> Berikan umpan balik atau tautan baru, dan smartedits akan membantu menyempurnakan serta memperbarui resume Anda.
- <b>Disesuaikan untuk Pekerjaan:</b> Tempel deskripsi pekerjaan, dan dapatkan rekomendasi untuk menyesuaikan resume Anda.
- <b>Kualitas LaTeX:</b> Semua resume dihasilkan menggunakan LaTeX untuk tampilan yang bersih dan profesional.
- <b>Prapratin Instan:</b> Lihat resume Anda sebagai PDF secara real time.
- <b>Reset Mudah:</b> Bersihkan dan mulai ulang resume Anda dengan sekali klik.
- <b>Lokal:</b> Berjalan sepenuhnya di mesin Anda menggunakan Docker.

---

## Memulai

### Prasyarat
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Penyiapan

1. Clone repositori:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Bangun dan mulai aplikasi:
   ```bash
   docker compose up --build
   ```
3. Akses aplikasi:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Penggunaan

1. Buka autoResume di browser Anda.
2. Klik ikon :gear:, tempel [GOOGLE API KEY](https://aistudio.google.com/) Anda dan Email Anda.
3. Tempel tautan ke informasi profesional Anda (misalnya, Github, Situs Pribadi, dll.).
4. Opsional, tambahkan umpan balik atau tautan lowongan pekerjaan untuk kustomisasi lebih lanjut.
5. Klik <b>Generate Resume</b> dan biarkan AI melakukan sisanya!

---

## Lisensi

Proyek ini dilisensikan di bawah Lisensi Apache 2.0.

## Panduan Kontribusi

### Frontend
- Implementasikan komponen React di folder `frontend/src/components/`
- Kami menggunakan Chakra UI untuk mengimplementasikan komponen.
- Impor dan gunakan komponen Anda di `frontend/src/App.jsx`

### Backend
- Implementasikan rute API di direktori `backend/src/routes/`
- Tambahkan fungsionalitas AI di direktori `backend/src/ai/`
- Kami menggunakan formatter kode `black` untuk kode Python
- Jaga handler rute tetap bersih dan logika terpisah

### Panduan Umum
- Buat branch baru untuk fitur/perbaikan Anda: `git checkout -b your-branch-name`
- Tulis pesan commit yang jelas
- Uji perubahan Anda sebelum mengirimkan PR

### Mengirimkan Perubahan
1. Buat Pull Request
2. Dalam deskripsi PR Anda, sertakan:
   - Perubahan apa yang Anda buat
   - Alasan Anda membuat perubahan tersebut
   - Screenshot atau hasil pengujian yang relevan
   - Perubahan besar atau langkah migrasi yang dibutuhkan

Kami menghargai kontribusi Anda dan akan meninjau PR Anda secepat mungkin!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---