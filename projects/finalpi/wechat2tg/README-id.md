# wechat2tg-mac

Berdasarkan protokol WeChat Mac untuk mengirim dan menerima pesan WeChat di Telegram, layanan wx2tg-server tidak open source demi alasan keamanan.

## Grup TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Fitur Utama

1. Menerima pesan chat pribadi WeChat, pesan grup WeChat, pesan Official Account, serta pesan WeCom (WeChat Enterprise)
2. Mengirim pesan dari Telegram ke pengguna WeChat, grup WeChat, atau Official Account tertentu
3. Memblokir pesan dari grup tertentu

## Jenis Pesan yang Didukung

### Daftar Jenis Pesan WeChat yang Didukung

+ [x] Pesan teks
+ [x] Pesan WeCom (WeChat Enterprise)
+ [x] Stiker WeChat
+ [x] Pesan gambar
+ [x] Pesan video
+ [x] Panggilan suara/video (hanya notifikasi)
+ [x] Pesan file
+ [x] Pesan tautan
+ [x] Pesan grup
+ [x] Pesan grup @ (mention @semua orang dan @anda akan dikonversi ke Telegram @anda)
+ [x] Pesan Official Account
+ [x] Emoji
+ [x] Pesan lokasi
+ [x] Pesan ditarik kembali
+ [x] Pesan suara
+ [ ] Pesan angpao (hanya notifikasi, isi angpao tidak bisa diambil)
+ [ ] Pesan Mini Program

### Daftar Jenis Pesan Telegram yang Didukung

+ [x] Pesan teks
+ [x] Stiker/emoji
+ [x] Pesan gambar
+ [x] Pesan video
+ [x] Pesan file
+ [x] Pesan suara

## Catatan

1. Proyek ini hanya untuk penelitian dan pembelajaran teknis, dilarang digunakan untuk tujuan ilegal.
2. Silakan submit issue untuk masalah apapun.

## Instalasi dan Deploy

Salin file `.env.example` ke `.env`, lalu konfigurasi variabel lingkungan di file `.env`.

Salin `app.conf.example` dari proyek ke file `app.conf` di direktori `conf`, atur alamat Redis ke alamat Redis yang Anda deploy.

### docker-compose

Buat file `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Setelah mount folder ini, file stiker tidak perlu dikonversi ulang
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Pull image
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Menjalankan

```shell
docker-compose up -d
```

#### Mematikan mode privasi bot

Matikan mode privasi bot. Buka BotFather, ketik `/mybots`, pilih bot Anda. Klik `Bot Settings` - `Group Privacy` - `Turn off`, jika muncul `Privacy mode is disabled for xxx` berarti sudah berhasil dimatikan.

## Petunjuk Penggunaan

### Perintah BOT

- `/login`: Mendapatkan kode QR login; pada saat deploy pertama kali, orang pertama yang mengirim perintah `/login` akan menjadi pemilik `BOT`.
- `/flogin`: Mendapatkan kode QR login untuk File Transfer Assistant, mendukung penerimaan video dan file.
- `/update`: Memperbarui avatar dan informasi nama grup.
- `/message`: Mengaktifkan/menonaktifkan penerimaan pesan grup.
- `/forward`: Mengaktifkan/menonaktifkan penerusan pesan dari anggota lain atau bot di grup.
- `/user`: Mendapatkan daftar pengguna WeChat; klik tombol untuk membuat grup baru atau mengikat pengguna (dapat dicari lewat nama atau remark, contoh: `/user Zhang` untuk mencari pengguna WeChat yang mengandung "Zhang").
- `/room`: Mendapatkan daftar grup WeChat; klik tombol untuk membuat grup baru atau mengikat grup (dapat dicari lewat nama atau remark, contoh: `/room Makanan` untuk mencari grup WeChat yang mengandung "Makanan").
- `/settings`: Pengaturan program.
- `/unbind`: Melepas binding grup atau pengguna WeChat (hanya didukung dalam grup).

### Penjelasan Variabel Lingkungan

|Nama| Wajib | Deskripsi                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Ya    | Token Bot Telegram, buat melalui [BotFather](https://t.me/BotFather) |
|`API_ID`| Ya    | API ID Telegram                                                    |
|`API_HASH`| Ya    | API HASH Telegram                                                |
|`BASE_API`| Ya    | Alamat API wx2tg-server container, harus path lengkap            | |
|`PROXY_PROTOCOL`| Tidak    | Jenis proxy opsional (socks5,http,https)                       |
|`PROXY_HOST`| Tidak    | URL proxy                                                     |
|`PROXY_PORT`| Tidak    | Port proxy                                                    |
|`PROXY_USERNAME`| Tidak    | Username proxy                                             |
|`PROXY_PASSWORD`| Tidak    | Password proxy                                             |
|`ROOM_MESSAGE`| Tidak    | Format tampilan pesan grup WeChat di BOT                    |
|`OFFICIAL_MESSAGE`| Tidak    | Format tampilan pesan Official Account di BOT               |
|`CONTACT_MESSAGE`| Tidak    | Format tampilan pesan pengguna WeChat di BOT               |
|`ROOM_MESSAGE_GROUP`| Tidak    | Format tampilan pesan grup WeChat di grup Telegram          |
|`CONTACT_MESSAGE_GROUP`| Tidak    | Format tampilan pesan pengguna WeChat di grup Telegram       |
|`OFFICIAL_MESSAGE_GROUP`| Tidak    | Format tampilan pesan Official Account di grup Telegram      |
|`CREATE_ROOM_NAME`| Tidak    | Format nama grup ketika otomatis membuat grup WeChat           |
|`CREATE_CONTACT_NAME`| Tidak    | Format nama grup ketika otomatis membuat grup kontak WeChat   |
|`MESSAGE_DISPLAY`| Tidak    | Format tampilan pesan teks                                    |

 ---

### Penjelasan Perintah `/settings`

1. Apakah emoji WeChat ditampilkan sebagai tautan gambar: Jika diaktifkan, emoji kuning kecil dari teman akan tampil sebagai link gambar.
2. Sinkronisasi info grup saat startup: Jika diaktifkan, saat program mulai, info semua orang akan disinkronisasi, avatar dan nama grup akan diperbarui.

---

### Konversi Suara ke Teks

1. Konfigurasikan `TENCENT_SECRET_ID` dan `TENCENT_SECRET_KEY`, dapat didapatkan di [konsol pengenalan suara Tencent](https://console.cloud.tencent.com/asr). Tersedia kuota gratis.
2. Aktifkan fitur otomatis konversi suara ke teks di `/settings`.

---

### Mendapatkan `API_ID` dan `API_HASH`

1. Login ke [akun telegram](https://my.telegram.org/)
2. Klik "API development tools" lalu isi detail aplikasi (hanya judul dan singkatan aplikasi saja)
3. Klik "Create application"

---

### Template Pesan Kustom

Jika ingin mengubah format pengirim pesan, bisa mengubah variabel lingkungan di docker atau file `.env`.

Placeholder template pesan kustom:

`#[alias]`: Remark kontak

`#[name]`: Nama panggilan kontak

`#[topic]`: Nama grup

`#[alias_first]`: Prioritaskan remark, jika tidak ada maka gunakan nama kontak

`#[identity]`: Teks identitas

`#[body]`: Isi pesan

`#[br]`: Baris baru

### Cara @semua orang

Kirim pesan yang diawali `@all` untuk mention semua orang, hanya didukung untuk pesan teks.

---

## FAQ


## Berkontribusi dalam Pengembangan

1. fork proyek, pindah ke branch `wx2tg-mac-dev`, atau buat branch baru. Jangan langsung commit ke branch utama.
2. Ajukan Pull Request ke branch `wx2tg-mac-dev`

## License

[MIT](LICENSE)

## Thanks

Terima kasih kepada Jetbrains atas dukungannya terhadap proyek ini

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---