<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <p>Terjemahan berikut dihasilkan secara otomatis menggunakan AI. Harap dicatat bahwa terjemahan ini mungkin mengandung ketidakakuratan atau merujuk pada versi lama dari readme ini.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Pratinjau Episode di Pemutar
====================
## 📄 Tentang
Plugin ini menambahkan daftar episode ke pemutar video, sehingga Anda dapat melihat pratinjau setiap episode acara TV tanpa harus keluar dari pemutar.

Modifikasi ini mendukung klien berikut:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Klien Desktop

## ✨ Fitur
* Daftar semua episode dalam satu musim
* Beralih antar musim
* Menampilkan judul episode, deskripsi, gambar mini, dan progres pemutaran
* Menampilkan detail episode seperti peringkat komunitas
* Tandai episode sebagai telah diputar atau favorit
* Mulai episode baru
* Harus bisa digunakan dengan tema kustom

## 📸 Pratinjau
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Tema yang digunakan: (SkinManager) Kaleidochromic
<br>
Pratinjau ini belum menampilkan tombol baru untuk menandai episode sebagai selesai atau favorit.

## 🔧 Instalasi

### Klien Web Jellyfin (Server)

> [!CATATAN]
> Sangat disarankan untuk memasang [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) minimal versi v2.2.1.0. Plugin ini membantu menghindari masalah izin saat memodifikasi index.html pada jenis instalasi apapun!
<details open>
<summary> Lihat instruksi... </summary>

1. Tambahkan manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` sebagai repositori plugin Jellyfin ke server Anda.
2. Instal plugin `InPlayerEpisodePreview` dari repositori tersebut.
3. Restart server Jellyfin.
</details>

### Klien Desktop Jellyfin Media Player (JMP) (Tidak Didukung)
<details>
<summary> Lihat instruksi... </summary>

**Tidak didukung mulai versi JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Karena klien JMP yang baru menggunakan pemutar web dari server secara langsung, tidak perlu lagi melakukan perubahan langsung pada kode klien.

Ini adalah cara yang direkomendasikan untuk memasang skrip pada klien desktop.
Jika Anda tidak merasa nyaman mengedit file nativeshell.js sendiri (langkah 3 hingga 6), Anda dapat mengunduh rilis lengkap sebagai gantinya, yang sudah mencakup script yang ditambahkan ke file nativeshell.js.
Masih belum jelas apakah ada potensi masalah jika mengganti file nativeshell.js dengan yang dari rilis, jadi disarankan untuk mengikuti semua langkah di bawah ini.

1. Unduh rilis terbaru [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) atau [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (sudah termasuk script yang ditambahkan ke file nativeshell.js)
2. Ekstrak file zip ke direktori Jellyfin Anda (misal: C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Di dalam direktori Jellyfin Anda ikuti jalur folder "web-client\extension"
4. Buka file "nativeshell.js" dengan editor teks.
5. Di dalam file temukan bagian `const plugins = [];`. Tambahkan baris baru di awal daftar dan tempelkan `'inPlayerEpisodePreviewPlugin',`. Bagian tersebut sekarang akan terlihat seperti ini:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Simpan file dan restart klien JMP.
</details>

## 💡 Pemecahan Masalah

### 1. Tombol pratinjau tidak terlihat
Ini kemungkinan besar terkait dengan izin yang salah untuk file `index.html`.

<details>
<summary> Lihat daftar kemungkinan solusi... </summary>

#### 1.1 Hindari masalah ini dengan menggunakan plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Ubah Kepemilikan di dalam wadah docker
Jika Anda menjalankan jellyfin di dalam wadah docker, Anda dapat mengubah kepemilikan dengan perintah berikut
(ganti jellyfin dengan nama wadah Anda, user dan group dengan user dan grup dari wadah Anda):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Anda dapat menjalankan ini sebagai cron job saat sistem dinyalakan.
(Terima kasih kepada [muisje](https://github.com/muisje) atas bantuannya dalam [solusi ini](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530))

#### 1.3 Mengubah Kepemilikan yang berjalan di instalasi Windows
1. Arahkan ke: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Klik kanan pada `index.html` → `Properties` → Tab `Security` → Klik pada `Edit`
3. Pilih pengguna Anda dari daftar dan centang kotak izin Tulis `permission`.
4. Restart baik server maupun klien.
   (Terima kasih kepada [xeuc](https://github.com/xeuc) atas [solusi ini](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069))

Jika tidak ada solusi di atas yang berhasil, silakan lihat masalah lama. Contohnya [di sini](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) atau [di sini](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Jika Anda mengalami kesalahan yang tidak dapat Anda selesaikan sendiri, silakan buka issue baru.
<br/>Harap diingat bahwa setiap sistem berbeda yang dapat menyebabkan perilaku tak terduga, jadi tambahkan informasi sebanyak mungkin tentang sistem Anda.
<br/>Log Jellyfin dan log konsol dari browser (berawalan [InPlayerEpisodePreview]) selalu sangat berguna.

## Kredit
Struktur plugin didasarkan dan terinspirasi dari plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) oleh [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---