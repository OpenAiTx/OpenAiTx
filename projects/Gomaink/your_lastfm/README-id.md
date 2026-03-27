
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-aktif-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Lisensi](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Sebuah aplikasi Node.js berbasis kontainer yang menyinkronkan scrobble dari **Last.fm**, menyimpannya di database lokal **SQLite**, dan menyediakan dasbor web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Proyek

**Your LastFM** adalah aplikasi Node.js yang dirancang untuk **menyinkronkan scrobble musik secara otomatis** dari Last.fm. Aplikasi ini menjaga riwayat mendengarkan Anda dalam basis data SQLite lokal dan menyajikan antarmuka web untuk visualisasi data.

Proyek ini sepenuhnya terkontainerisasi dengan **Docker**, menggunakan entrypoint otomatis untuk menangani inisialisasi basis data dan eksekusi berurutan (Sinkronisasi terlebih dahulu, kemudian meluncurkan Web API). Selain itu juga menggunakan **PM2** sebagai manajer proses di dalam kontainer untuk memastikan layanan web tetap aktif dan tahan banting.

## Fitur
### Dasbor Web Interaktif

- Antarmuka web yang bersih dan modern untuk memvisualisasikan aktivitas musik Anda.

### Sinkronisasi Scrobble Last.fm Otomatis

- Secara berkala mengambil dan menyimpan riwayat mendengarkan Anda (scrobble) dari Last.fm.
- Memastikan data Anda selalu terbaru tanpa intervensi manual.

### Basis Data Riwayat Musik Lokal

- Menyimpan semua scrobble dalam basis data SQLite lokal.
- Memungkinkan kueri cepat dan akses offline ke data riwayat mendengarkan.

### Tampilan Scrobble Terbaru

- Menampilkan lagu-lagu terbaru yang Anda dengarkan.
- Logika fallback gambar yang pintar untuk lagu, album, dan artis.

### Perbandingan Teman (Tampilan Kompatibilitas)

- Bandingkan selera musik Anda dengan teman Last.fm Anda.
- Menampilkan tingkat kompatibilitas (Sangat Rendah → Super).
- Menampilkan artis, album, dan lagu teratas yang sama.
- Menghitung dan menormalkan kompatibilitas berdasarkan data mendengarkan nyata.

### Kartu Musik yang Dapat Dibagikan

- Menghasilkan gambar dinamis berdasarkan data mendengarkan Anda.
- Tata letak dioptimalkan untuk posting feed dan cerita instagram (9:16)

- Dibangun menggunakan node-canvas untuk rendering gambar sisi server.

## Prasyarat

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Instalasi

### Buat file `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Buat akun API [di sini](https://www.last.fm/api/account/create) untuk mendapatkan API Key Anda.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

Pada terminal:
`docker compose up -d`

Kemudian akses:
```
http://localhost:1533
```

(atau ganti `localhost` dengan IP server Anda)

## Lisensi

Proyek ini dilisensikan di bawah Lisensi MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---