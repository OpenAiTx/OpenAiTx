
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Elucidate

- [Deskripsi Proyek](#project-description)
- [Persyaratan Sistem:](#os-requirements)
- [FAQ](#faqs)
- [Peta jalan](#roadmap)
- [Tangkapan Layar](#screenshots)

## Deskripsi Proyek

Elucidate adalah antarmuka GUI Windows untuk aplikasi SnapRAID berbasis command-line.

*Proyek ini melanjutkan penggabungan dari pekerjaan hebat yang dilakukan oleh saya sendiri dan kontributor lainnya.

## Persyaratan Sistem

- Sistem Operasi Windows
- .Net Runtime 4.8.0
- SnapRaid Versi 11.5 atau lebih rendah
- 10MB Ruang Bebas pada drive target

## FAQ

**T**: Apa itu SnapRAID?<br/>
**J**: SnapRAID adalah mesin snapshot-parity berbasis perangkat lunak untuk sistem operasi Windows dan Linux. Secara paling dasar, ia menawarkan perlindungan terhadap isi file-system di bawah pengawasannya dengan menghitung hash dari file komponennya dan menyimpan hasilnya pada file parity. Dalam kasus kegagalan hard drive total, file parity ini dapat digunakan untuk merekonstruksi data yang hilang. Untuk detail lengkap, kunjungi [perbandingan resmi SnapRAID tentang mesin perlindungan file.](http://snapraid.sourceforge.net/compare.html)

**T**: Kenapa harus GUI, Command Line sudah cukup!<br/>
**J**: Tujuan besarnya adalah menciptakan GUI yang lengkap dengan fitur manajemen tambahan yang dirancang untuk membantu pengguna dalam memelihara lingkungan SnapRAID yang berfungsi. Terkadang, ‘klik dan tunjuk’ lebih mudah bagi pemula untuk memulai. Dokumentasi teknis SnapRAID dan konfigurasi mendalamnya dapat membuat adopsinya terasa menakutkan bagi mereka yang ingin mencoba!

**T**: Saya masih ragu, apakah ada lagi?<br/>
**J**: Ya, Silakan lihat [dokumentasi](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) untuk gambar dan lainnya.

**T**: Jadi apa saja "Tujuan Besar"nya?<br/>
**J**: Lihat __Roadmap__ di bawah untuk pemecahan lengkap.

## Roadmap

- [x] Fase I
  - [x] Usaha untuk mengikuti dukungan minimum dari SnapRAID terbaru. - __Sedang berlangsung.__
  - [x] Kemudahan penggunaan
  - [x] SnapRAID memiliki tiga perintah, jadi mari buat agar mudah diakses untuk pemula 
  - [x] Indikator kemajuan 
  - [x] Logging "Interaktif" dan langsung ke log. 
  - [x] Auto start-up saat login pengguna 
  - [x] Tool-tip untuk membimbing •	

- [x] Fase II Permintaan fitur Fase II
  - [x] Pause, Ubah prioritas, Abort.
  - [x] Ekstensi Perintah - "Izinkan parameter tambahan pada nilai default yang digunakan."
  - [x] Penjadwalan
    - Dihapus, gunakan CommandLine
  - [x] Tampilan grafis dari data yang dilindungi.

- [ ] Fase III (Mulai ulang dari 2017-03 dan seterusnya)
  - [x] Kompiler Baru dan .Net 4.7.x
  - [x] Antarmuka Command Line
  - [ ] Tata Letak Baru melalui Krypton Toolkit / Navigator / dll.
    - Sedang Berjalan
  - [ ] Terjemahan
  - [x] Perintah Baru
  - [ ] Pengirim Email dengan laporan status
  - [ ] Dokumen Langkah Pengujian
    - Sedang Berjalan
  - [ ] Tambahkan ke Dokumentasi / Perbarui Gambar
    - Sedang Berjalan
  - [ ] Tambahkan pelaporan _Windows EventLog_ untuk Kesalahan
  - [x] Tambahkan _ExceptionLess_ untuk pelaporan Exception secara daring
  - [x] Tampilkan apa yang dapat dipulihkan.

- [ ] Fase IV (Perintah SnapRAID baru?)
  - [ ] Bantuan Diperluas dengan pemulihan disk - panduan interaktif dll.
  - [ ] Beri tahu pengguna jika versi SnapRAID mereka sudah usang
  - [ ] Interpretasikan log SnapRAID (digunakan oleh perubahan di bawah)
  - [ ] Sediakan status array setelah menjalankan perintah
  - [ ] Modifikasi perintah sync untuk menyertakan diff awal
  - [ ] Modifikasi perintah sync agar memberikan peringatan jika diff melaporkan masalah di atas ambang batas
  - [ ] Tambahkan pengaturan yang dapat dikonfigurasi pengguna untuk kebutuhan ambang batas sinkronisasi


## Tangkapan Layar

![Tampilan Awal](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulir Pengaturan](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Dapatkah Anda Membantu?
- Mencari penguji (Semua platform .Net)
- Dapat membantu menerjemahkan
- Panduan Bantuan / Antarmuka Pengguna
- Ide lainnya :-)
- Pengembang untuk ide-ide tersebut


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---