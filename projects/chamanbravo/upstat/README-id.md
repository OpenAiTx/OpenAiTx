
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> alat pemantauan status mandiri yang sederhana dan mudah digunakan

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Demo Langsung

Coba sekarang.

Server Demo (Lokasi: Singapura): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Nama Pengguna: `demo`
Kata Sandi: `demodemo`

## ⭐ Fitur

Masih butuh lebih banyak fitur, tapi untuk saat ini...

- Memantau uptime untuk HTTP(s)
- Grafik Status dan Latensi
- Notifikasi via Discord
- Interval 60 detik
- UI/UX Mewah, Reaktif, dan Cepat
- Banyak halaman status
- Pemetaan halaman status ke domain tertentu
- Grafik ping
- Info sertifikat
- PWA
- Dukungan database Sqlite & Postgres

Dan puluhan fitur kecil lain yang akan ditambahkan.

## 🔧 Cara Instalasi

### 🐳 Docker

Untuk Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Untuk Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat sekarang berjalan di http://localhost:3000

> [!PENTING]
> Pastikan untuk mengubah nilai lingkungan sebelum melakukan deployment.

### 💪🏻 Non-Docker

Persyaratan:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Opsional)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Teknologi yang Digunakan

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Kontribusi

Saya sangat menyambut kontribusi! Kontribusi adalah apa yang membuat komunitas open source menjadi tempat yang luar biasa untuk belajar, menginspirasi, dan menciptakan. Setiap kontribusi yang Anda berikan sangat **dihargai**.

Jika Anda memiliki saran yang dapat membuat ini menjadi lebih baik, silakan fork repo ini, lakukan perubahan dan buat pull request. Anda juga bisa langsung membuka issue dengan tag "enhancement".
Jangan lupa untuk memberi bintang pada proyek ini! Terima kasih sekali lagi!

1. Fork Proyek Ini
2. Buat Branch Fitur Anda (`git checkout -b feature/AmazingFeature`)
3. Commit Perubahan Anda (`git commit -m 'Add some AmazingFeature'`)
4. Push ke Branch (`git push origin feature/AmazingFeature`)
5. Buka Pull Request

## Kontributor

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Lisensi

Proyek ini dilisensikan di bawah [MIT License](https://opensource.org/license/mit/).

## 🖼 Lebih Banyak Screenshot

Buat Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Halaman Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---