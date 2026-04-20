<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Alternatif MyFitnessPal yang dihosting sendiri dengan privasi sebagai prioritas utama. Lacak nutrisi, olahraga, metrik tubuh, dan data kesehatan sambil tetap mengendalikan penuh data Anda.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness adalah platform pelacakan kebugaran yang dihosting sendiri, terdiri dari:

- Server backend (API + penyimpanan data)
- Frontend berbasis web
- Aplikasi mobile native untuk iOS dan Android

Menyimpan dan mengelola data kesehatan pada infrastruktur yang Anda kendalikan, tanpa bergantung pada layanan pihak ketiga.

## Fitur Inti

- Pelacakan nutrisi, olahraga, hidrasi, tidur, puasa, suasana hati, dan pengukuran tubuh
- Penetapan tujuan dan pemeriksaan harian
- Grafik interaktif dan laporan jangka panjang
- Profil pengguna ganda dan akses keluarga
- Tema terang dan gelap
- OIDC, TOTP, Passkey, MFA dll.

## Integrasi Kesehatan & Perangkat

SparkyFitness dapat menyinkronkan data dari berbagai platform kesehatan dan kebugaran:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (uji sebagian)
- **Hevy** (belum diuji)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (uji sebagian)

Integrasi secara otomatis menyinkronkan data aktivitas seperti langkah, latihan, dan tidur, bersama dengan metrik kesehatan seperti berat badan dan pengukuran tubuh, ke server SparkyFitness Anda.

## Fitur AI Opsional (Beta)

SparkyAI menyediakan antarmuka percakapan untuk mencatat data dan meninjau kemajuan.

- Catat makanan, olahraga, statistik tubuh, dan langkah melalui chat
- Unggah gambar makanan untuk pencatatan makanan otomatis
- Menyimpan riwayat percakapan untuk tindak lanjut

Catatan: Fitur AI saat ini masih dalam versi beta.

## Mulai Cepat (Server)

Jalankan server SparkyFitness dalam hitungan menit menggunakan Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```
## 🎥 Tutorial Video

[![Tonton videonya](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Tutorial singkat 2 menit yang menunjukkan cara menginstal SparkyFitness (pelacak kebugaran self-hosted).


## Dokumentasi

Untuk panduan instalasi lengkap, opsi konfigurasi, dan dokumentasi pengembangan, silakan kunjungi [Situs Dokumentasi](https://codewithcj.github.io/SparkyFitness/) kami.

### Tautan Cepat

- **[Panduan Instalasi](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Penyebaran dan konfigurasi
- **[Gambaran Fitur](https://codewithcj.github.io/SparkyFitness/features)** - Dokumentasi fitur lengkap
- **[Alur Kerja Pengembangan](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Panduan pengembang dan proses kontribusi
- **[Info Aplikasi iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** dan **[Info Aplikasi Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Butuh Bantuan?

- Posting di isu/diskusi Github.
- Untuk respon lebih cepat dan mendapatkan bantuan dari anggota komunitas lain **[Gabung ke Discord kami](https://discord.gg/vcnMT5cPEA)**

## Riwayat Bintang

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Grafik Riwayat Bintang" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Terjemahan

**[Terjemahan Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">


<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Status Terjemahan" />
</a>

## Aktivitas repositori

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Gambar analitik Repobeats")

## Kontributor

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Masalah Diketahui / Fitur Beta ⚠️

SparkyFitness sedang dalam pengembangan aktif.
Perubahan besar dapat terjadi di antara rilis.

- Kontainer yang memperbarui otomatis tidak disarankan
- Selalu tinjau catatan rilis sebelum melakukan upgrade

Fitur-fitur berikut saat ini dalam versi beta dan mungkin belum diuji secara menyeluruh. Harap waspadai potensi bug atau fungsionalitas yang belum lengkap:

- AI Chatbot
- Akses Keluarga & Teman
- Dokumentasi API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---