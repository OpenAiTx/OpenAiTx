
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# OpenSpot Music 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">Gerbang Anda Menuju Musik Tanpa Batas - Streaming Musik Lintas Platform</h3>

<p align="center">
  <strong>Streaming dan unduh musik berkualitas tinggi secara gratis di semua perangkat Anda, tanpa iklan dan tanpa perlu login.</strong>
</p>

<p align="center">
  <a href="https://github.com/BlackHatDevX/openspot-music-app/stargazers">
    <img src="https://img.shields.io/github/stars/BlackHatDevX/openspot-music-app?style=for-the-badge&color=ffd700" alt="Stars">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/network/members">
    <img src="https://img.shields.io/github/forks/BlackHatDevX/openspot-music-app?style=for-the-badge&color=84b4a3" alt="Forks">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/issues">
    <img src="https://img.shields.io/github/issues/BlackHatDevX/openspot-music-app?style=for-the-badge&color=f38ba8" alt="Issues">
  </a>
</p>

---

## 📱📺 Dua Aplikasi Menakjubkan, Satu Repository

Repositori ini berisi **dua aplikasi streaming musik lengkap**:

### 🎵 **OpenSpot Mobile** (React Native + Expo)
- **Platform**: Android, iOS
- **Lokasi**: `openspot-music-mobile/`
- **Fitur**: Pengalaman mobile asli dengan unduhan offline, pemutaran di latar belakang, dan penyimpanan status yang persisten

### 🖥️ **OpenSpot Desktop** (Electron + React)
- **Platform**: macOS, Windows, Linux
- **Lokasi**: `openspot-music-electron/`
- **Fitur**: Antarmuka desktop yang dioptimalkan dengan kontrol audio global, manajemen jendela, dan penyimpanan lokal

---

### 📢 Gabung di Channel Telegram Kami

Dapatkan update tentang **rilis versi** dan **pengumuman penting** di channel Telegram resmi Openspot.

[![Join us on Telegram](https://img.shields.io/badge/Join%20Us%20on-Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/openspot_music)


---


## 📱 Aplikasi Mobile (React Native + Expo)

### Tangkapan Layar

![WhatsApp Image 2025-07-26 at 00 52 14](https://github.com/user-attachments/assets/cc7b262d-ccfe-4899-bd86-56d0e3e90be7)



### Link Unduhan

- **Android APK**: [OpenSpot-2.0.3-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.3/OpenSpot-2.0.3-release.apk)
- **iOS**: Butuh Maintainer

### Pengaturan Pengembangan

```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### Bangun untuk Produksi


```bash
cd openspot-music-app/

# Development Build
eas build --platform android --profile development

# Preview Build (APK)
eas build --platform android --profile preview

# Production Build
eas build --platform android --profile production
```

---

## 🖥️ Aplikasi Desktop (Electron + React)

### Tangkapan Layar

![Aplikasi macOS](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### Tautan Unduhan

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.zip](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64-mac.zip)
- Jalankan ini jika Anda mengalami masalah aplikasi rusak setelah instalasi.
  ```bash
  xattr -rd com.apple.quarantine /Applications/OpenSpot\ Music.app
- **Windows EXE**: Segera Hadir!
- **Linux DEB**: Segera Hadir!

### Pengaturan Pengembangan

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

### Build untuk Produksi

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
---

## ✨ Fitur Utama (Kedua Aplikasi)

- **🎵 Streaming Berkualitas Tinggi**: Dengarkan lagu favorit Anda dengan kualitas terbaik
- **💾 Unduhan Offline**: Simpan musik langsung ke perangkat Anda untuk didengarkan secara offline
- **❤️ Suka & Koleksi**: Bangun koleksi pribadi Anda dengan menyukai lagu-lagu
- **🔄 Pemutaran Latar Belakang**: Tetap mendengarkan sambil menggunakan aplikasi lain
- **🚫 Tidak Perlu Login**: Langsung pakai! Tidak perlu akun atau pendaftaran
- **💾 Status Persisten**: Lagu yang Anda sukai dan yang baru saja diputar akan tersimpan meski aplikasi di-restart
- **🎨 Antarmuka yang Indah**: Tampilan bersih dan modern yang dirancang khusus untuk setiap platform
- **🆓 Sepenuhnya Gratis & Tanpa Iklan**: Nikmati musik tanpa gangguan dan tanpa biaya atau iklan

---

## 💻 Stack Teknologi

### Aplikasi Mobile
- **Framework**: [React Native](https://reactnative.dev/) dengan [Expo](https://expo.dev/)
- **Navigasi**: [Expo Router](https://expo.github.io/router/)
- **Audio**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **Build**: [EAS Build](https://docs.expo.dev/build/introduction/)
- **Pengambilan Lokasi**: [IPinfo API](https://github.com/ipinfo)

### Aplikasi Desktop
- **Framework**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **UI**: [Material-UI](https://mui.com/)
- **State**: React Context + useReducer
- **Penyimpanan**: [electron-store](https://github.com/sindresorhus/electron-store)
- **Build**: [electron-builder](https://www.electron.build/)

### Bersama
- **Bahasa**: [TypeScript](https://www.typescriptlang.org/)
- **Package Manager**: npm/yarn

---

### Konfigurasi Lingkungan

Proyek ini membutuhkan satu variabel lingkungan agar dapat berfungsi dengan benar.

- Template tersedia di file [`.env.template`](https://github.com/BlackHatDevX/openspot-music-app/blob/main/openspot-mobile/.env.template).
- **Nilai** yang diperlukan untuk melengkapi file `.env` Anda dibagikan pada **pesan tersemat** di **saluran Telegram resmi** kami: [@openspot_music](https://t.me/openspot_music).

---

## 🚀 Mulai Cepat

### Untuk Pengembangan Mobile
```bash




git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```

### Untuk Pengembangan Desktop
```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

---

## 🤝 Kontribusi

Kami menyambut kontribusi untuk kedua aplikasi!
## 📞 Komunitas & Dukungan

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **Isu**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 Penulis & Kontak

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **Portofolio**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 Lisensi

Proyek ini bersifat open-source dan dilisensikan di bawah MIT License. Lihat berkas `LICENSE` untuk informasi lebih lanjut.

---

<p align="center">
  <strong>⭐ Jika Anda menyukai proyek ini, silakan beri bintang! ⭐</strong>
  <br />
  <em>Dukungan Anda membantu kami terus mengembangkan aplikasi musik gratis yang luar biasa untuk semua orang.</em>
</p> 
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---