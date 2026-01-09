
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Kumpulan modifikasi, peningkatan, dan sumber daya rekayasa balik untuk Creation Kit oleh Bethesda.
</p>

# Deskripsi
**CKPE** adalah platform sumber bersama yang kuat yang membuat banyak perbaikan dan peningkatan pada editor Creation Kit dari **Bethesda**, termasuk dukungan editor untuk game seperti **Skyrim Special Edition**, **Fallout 4**, **Starfield**, merupakan penerus dari proyek [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), juga [Unicode patch untuk SSE CK 1.5.73](https://github.com/Perchik71/usse_test) yang menjadi awal mula untuk penulis **perchik71**.  

Halaman [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dependensi
[toml11](https://github.com/ToruNiina/toml11) oleh `ToruNiina` dan lainnya  
[Zydis](https://github.com/zyantific/zydis.git) oleh `zyantifi` dan lainnya  
[zipper](https://github.com/kuba--/zip.git) oleh `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) oleh `ebiggers` dan lainnya  
[xbyak](https://github.com/herumi/xbyak.git) oleh `herumi` dan lainnya  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) oleh `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) oleh `perchik71` *(rekursif)*

# Instalasi
### Instalasi Baru
Unduh [game yang didukung](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) dan instal Creation Kit.  
Unduh [rilis terbaru](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** untuk game Anda.  
Ekstrak semua konten ke direktori game, sehingga **ckpe_loader.exe** berada di folder yang sama dengan **CreationKit.exe**.
### Pembaruan
Unduh [rilis terbaru](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** untuk game Anda.  
Ekstrak semua konten ke direktori game, sehingga **ckpe_loader.exe** berada di folder yang sama dengan **CreationKit.exe**.  
Setujui untuk mengganti semua file.
### Kompilasi
Pengguna biasa hanya memerlukan metode ini untuk mengakses fitur terbaru yang belum dirilis.  
Buka proyek di **`Visual Studio 2022`** atau lebih baru. Build proyek dalam mode **`Release`** atau **`Release-NoAVX2`**.  
Kemudian pindahkan output build Anda ke direktori game, sehingga **ckpe_loader.exe** berada di folder yang sama dengan **CreationKit.exe**.  
Jika Anda diminta untuk mengganti file lama, setujui untuk menggantinya semua.
### Otomatisasi Build (Beta)
Unduh [build commit terbaru](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) **CKPE** untuk game Anda.  
Ekstrak semua konten ke direktori game, sehingga **ckpe_loader.exe** berada di folder yang sama dengan **CreationKit.exe**.  
Kemungkinan error.

# Kredit
[Nukem9](https://github.com/Nukem9) (untuk fungsi eksperimental, hash dan lain-lain, sangat berguna)  
[adzm](https://github.com/adzm) (Saya sangat menghargai karya Anda, Anda telah [melakukan](https://github.com/adzm/win32-custom-menubar-aero-theme) apa yang sudah lama ingin saya lakukan sendiri)  
[yak3d](https://github.com/yak3d) (Atas kontribusi dan pengembangan workflow serta dukungan Starfield terbaru)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (Untuk desain readme)  

# Lisensi
Mulai dari v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) proyek ini dilisensikan dengan [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Versi awal dilisensikan oleh [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Hak Cipta © 2023-2025 aka perchik71. Semua hak dilindungi. <br />
File `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` berisi file berpemilik dan tidak berlisensi; hal yang sama berlaku untuk file di `d3dcompiler\*.*`. <br />
Dependensi berada di bawah lisensi masing-masing. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---