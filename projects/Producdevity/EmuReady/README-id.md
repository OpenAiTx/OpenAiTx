# EmuReady

Sebuah platform berbasis komunitas untuk melacak kompatibilitas emulasi di berbagai perangkat dan emulator.

Kunjungi situs web kami: [https://emuready.com](https://emuready.com)

---

**Tangkapan Layar Halaman Utama**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Tangkapan Layar Halaman Daftar Kompatibilitas**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Tangkapan Layar Halaman Game**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Gambaran Umum

EmuReady membantu pengguna berbagi dan menemukan informasi kompatibilitas emulasi di berbagai konfigurasi perangkat keras dan perangkat lunak. Pengguna dapat memberikan laporan kompatibilitas, memberikan suara pada daftar, dan berdiskusi tentang kombinasi game/perangkat/emulator tertentu.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Fitur

- **Basis Data Kompatibilitas Komprehensif**: Lacak bagaimana performa game di berbagai emulator dan perangkat
- **Kontribusi Pengguna**: Laporan berbasis komunitas dan sistem voting
- **Sistem Diskusi**: Thread komentar dengan fungsi upvote/downvote
- **Dasbor Admin**: Kelola pengguna, daftar, dan moderasi konten
- **Desain Responsif**: Berfungsi di perangkat mobile, tablet, dan desktop

## Peningkatan Terbaru

Basis kode telah ditingkatkan secara signifikan dengan peningkatan berikut:

### Komponen UI

- Membuat komponen **ErrorBoundary** untuk penanganan dan pemulihan kesalahan yang lebih baik
- Menambahkan komponen **OptimizedImage** menggunakan komponen Image dari Next.js untuk performa lebih baik
- Meningkatkan **Pagination** dengan fitur aksesibilitas, navigasi keyboard, dan UX yang lebih baik
- Meningkatkan komponen **Badge** dengan lebih banyak varian, ukuran, dan opsi pill
- Menambahkan komponen **ThemeToggle** untuk beralih antara tema terang, gelap, dan sistem
- Mengimplementasikan **SortableHeader** untuk pengurutan tabel dengan indikator visual

### Caching & Performa

- Meningkatkan konfigurasi React Query dengan default yang lebih baik untuk caching, stale time, dan logika retry
- Menambahkan optimasi gambar untuk gambar perangkat
- Mengimplementasikan penanganan kesalahan yang tepat di seluruh aplikasi

### Aksesibilitas

- Meningkatkan navigasi keyboard untuk elemen interaktif
- Menambahkan label dan peran ARIA yang tepat
- Meningkatkan manajemen fokus
- Kontras warna lebih baik pada komponen UI

### Keamanan

- Validasi dan sanitasi data di berbagai level (klien, server, basis data)
- Implementasi Content Security Policy
- Perlindungan terhadap serangan XSS dan CSRF
- Autentikasi aman dengan NextAuth.js
- Validasi upload file dan langkah-langkah keamanan
- Pembatasan panjang input dan sanitasi yang tepat
- Validasi UUID untuk mencegah manipulasi parameter

### Pengalaman Pengembang

- Menambahkan skrip npm tambahan untuk alur kerja pengembangan
- Struktur proyek yang lebih baik dengan ekspor yang konsisten
- Umpan balik kesalahan yang lebih baik dengan ErrorBoundary khusus
- Halaman 404 yang ditingkatkan dengan opsi navigasi yang membantu

### Tema

- Menambahkan deteksi preferensi tema sistem
- Membuat toggle tema dengan beberapa opsi UI
- Peningkatan implementasi mode gelap di seluruh komponen

## Memulai

### Prasyarat

- Node.js 20+
- `npm`
- PostgreSQL (atau SQLite untuk pengembangan)

### Instalasi

1. Klon repositori

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Instal dependensi

```bash
npm install
```

3. Atur variabel lingkungan

```bash
cp .env.example .env
```

Kemudian edit file `.env` dengan kredensial basis data Anda dan konfigurasi lainnya.

4. Siapkan basis data

```bash
npx prisma generate
npx prisma db push
```

5. Jalankan server pengembangan

```bash
npm run dev
```

6. Buka [http://localhost:3000](http://localhost:3000) di browser Anda

## Skrip yang Tersedia

- `npm run dev` - Menjalankan server pengembangan
- `npm run dev:strict` - Menjalankan dengan mode strict React
- `npm run build` - Build untuk produksi
- `npm run start` - Menjalankan server produksi
- `npm run test` - Menjalankan pengujian
- `npm run lint` - Menjalankan ESLint
- `npm run lint:fix` - Memperbaiki masalah linting
- `npm run format` - Memformat kode dengan Prettier
- `npm run typecheck` - Memeriksa tipe TypeScript
- `npm run analyze` - Menganalisis ukuran bundle
- `npm run clean` - Membersihkan cache build
- `npm run prepare-deploy` - Persiapan untuk deployment (lint, typecheck, test, build)

### Perintah Prisma

- `npx prisma db seed` - Seed basis data
- `npx prisma studio` - Buka Prisma Studio
- `npx prisma db pull` - Menarik skema basis data
- `npx prisma db push` - Mendorong skema basis data

Lihat [Referensi Prisma Cli](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) untuk detail lebih lanjut.

## Stack Teknologi

- **Framework**: Next.js 15
- **Database ORM**: Prisma
- **API**: tRPC
- **Autentikasi**: NextAuth.js
- **Styling**: Tailwind CSS
- **Manajemen State**: React Query
- **Pengecekan Tipe**: TypeScript
- **Animasi**: Framer Motion
- **Validasi**: Zod, Content Security Policy, Validasi Input

## Kontribusi

Kami menerima kontribusi! Silakan lihat [Panduan Kontribusi](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) untuk detail lebih lanjut.

## Lisensi

Proyek ini dilisensikan di bawah Lisensi MIT - lihat file [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) untuk detailnya.

## Kode Etik (TODO)

Perhatikan bahwa proyek ini mematuhi [Kode Etik](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Dengan berpartisipasi dalam proyek ini, Anda setuju untuk mematuhi ketentuannya.

## Keamanan (TODO)

Jika Anda menemukan kerentanan keamanan, silakan ikuti [Kebijakan Keamanan](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) kami untuk pelaporan.

## Penghargaan

- Semua [Kontributor](https://github.com/Producdevity/emuready/graphs/contributors) kami
- Komunitas emulasi atas inspirasi dan dukungannya

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---