<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo Basketo Game Engine" width="200"/>
</p>

<h2 align="center">Ciptakan, Mainkan, Menginspirasi. Game yang Menjadi Nyata. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Ganti your_discord_server_id dengan ID server Anda yang sebenarnya -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (sebelumnya Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Selamat datang di Basketo Engine - sebuah proyek penuh gairah di mana kami memberikan usaha terbaik untuk menciptakan engine yang luar biasa dan berkinerja tinggi, dengan rencana menarik untuk menjadikannya engine game AI-Native. Menampilkan antarmuka editor mirip Unity, integrasi Gemini AI, sistem efek suara multi-lanjutan, dan arsitektur ECS yang kuat. Apakah Anda di sini untuk berkontribusi, memberikan ide, atau sekadar menyaksikan perkembangan, Anda adalah bagian dari perjalanan ini! 🚀
</p>
## 🚀 Kondisi Terkini Engine
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Lihat perkembangan dan fitur terbaru yang sedang berjalan!</em> 🎮
</p>

## ✨ Fitur Utama

### 🎮 **Antarmuka Editor Mirip Unity**
- **Pengaturan dua jendela**: Editor scene dan tampilan game berdampingan
- **Pengeditan langsung**: Modifikasi scene saat game berjalan
- **Panel inspector**: Pengeditan komponen secara visual dengan drag-and-drop
- **Tampilan hierarki**: Mengatur dan mengelola entitas
- **Penjelajah aset**: Manajemen tekstur dan audio yang mudah

### 🤖 **Pengembangan Native AI**
- **Integrasi Gemini AI**: Perintah bahasa alami untuk pengembangan game
- **Pembuatan skrip pintar**: Pembuatan skrip Lua bertenaga AI
- **Modifikasi entitas**: Jelaskan perubahan dengan bahasa Inggris biasa
- **Pengaturan API mudah**: Konfigurasi kunci API Gemini bawaan
### 🔊 **Sistem Audio Lanjutan**
- **Efek suara multi**: Beberapa suara yang dinamai per entitas (berjalan, melompat, menyerang, dll.)
- **Audio tradisional**: Musik latar dan suara ambient
- **Integrasi Lua**: Memicu suara dari skrip dengan `PlaySound(entity, "action")`
- **Editor visual**: Kelola efek suara melalui inspector

### 🎯 **Entity-Component-System (ECS)**
- **Performa tinggi**: Dioptimalkan untuk jumlah entitas yang besar
- **Desain modular**: Kombinasikan dan sesuaikan komponen sesuai kebutuhan
- **Integrasi skrip**: Scripting Lua dengan akses penuh ke ECS
- **Pembaruan waktu nyata**: Pengeditan komponen secara langsung

### 🎨 **Grafik & Animasi**
- **Rendering sprite**: Jalur grafis 2D yang efisien
- **Sistem animasi**: Animasi berbasis frame dengan looping
- **Sistem transformasi**: Posisi, rotasi, dan penskalaan
- **Sistem kamera**: Dukungan multi kamera

### ⚡ **Fisika & Tabrakan**
- **Deteksi tabrakan**: Tabrakan AABB dengan optimasi spasial
- **Fisika rigidbody**: Gravitasi, kecepatan, dan gaya
- **Callback tabrakan**: Event tabrakan yang dapat diakses skrip
- **Partisi spasial**: Optimasi quadtree untuk performa
## 🎬 Klik gambar di bawah untuk melihat demonstrasi video:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Demo Basketo Engine" width="500"/>
  </a>
</p>

## 🚀 Panduan Mulai Cepat

### 1. **Dapatkan Kunci API Gemini Anda** (Opsional tapi Disarankan)
- Kunjungi [Google AI Studio](https://aistudio.google.com/app/apikey)
- Masuk dan buat kunci API gratis
- Ini memungkinkan fitur bertenaga AI seperti perintah bahasa alami

### 2. **Bangun dan Jalankan**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Konfigurasikan Fitur AI**
- Di dalam engine, buka panel AI Prompt (bagian bawah)
- Cari "🤖 Gemini AI Configuration"
- Masukkan API key Anda dan klik "Save"

### 4. **Mulai Membuat**
- Coba perintah AI: `"create a player at 100 200"`
- Tambahkan efek suara ke entitas di inspector
- Tulis skrip Lua atau biarkan AI yang membuatnya
- Gunakan editor dua-jendela untuk pengembangan langsung

## �🛠️ Membangun Engine (Linux) 🐧

### Prasyarat
- CMake 3.26.0 atau lebih tinggi diperlukan.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (untuk fitur AI)
- nlohmann/json (sudah termasuk sebagai submodul)
- ImGui (sudah termasuk sebagai submodul)
### Langkah-langkah Build
```bash
# Kloning repositori
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Menjalankan
```bash
./BasketoGameEngine

```
Jika Anda ingin menjalankan tes fisika:
```bash
./PhysicsTest

```

## 🛠️ Membangun Engine (Windows) 💻

### Prasyarat

1. **Visual Studio 2022 (Edisi Komunitas atau lebih tinggi)**  
   Instal dengan beban kerja berikut:
   - Pengembangan desktop dengan C++
   - Alat CMake C++ untuk Windows
   - SDK Windows 10 atau 11

2. **CMake** (termasuk dalam Visual Studio atau unduh dari https://cmake.org/download/)

3. **vcpkg** (digunakan untuk menginstal dependensi)


---
### Install Dependencies

```bash
# Buka Developer Command Prompt untuk VS 2022 atau PowerShell

# Clone vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Instalasi pustaka yang diperlukan
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Build Steps
```bash
# Clone repository Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Konfigurasi dengan CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Ganti "C:/path/to/vcpkg" dengan path lengkap ke direktori vcpkg Anda

# Build engine
cmake --build . --config Release
```

---

### Menjalankan

```bash
# Dari direktori build/Release
```
./BasketoGameEngine.exe

# Untuk menjalankan uji fisika
./PhysicsTest.exe
```

## 📚 Dokumentasi

### Fitur Inti
- **[Sistem Efek Suara](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Panduan lengkap efek suara multi
- **[Pengaturan Gemini API](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Konfigurasi AI langkah demi langkah
- **[Skrip Lua](assets/Scripts/)**: Contoh skrip dan referensi API

### Contoh Penggunaan

#### Pengembangan Berbasis AI
```bash
# Perintah bahasa alami
"buat karakter pemain di posisi 100 200"
"tambahkan perilaku melompat ke pemain"
"buat musuh bergerak lebih cepat"

# Pembuatan Skrip
gemini_script buat controller platformer dengan double jump
```

#### Efek Suara Multi
```lua
-- Dalam skrip Lua Anda
PlaySound(entity, "jump")    -- Mainkan suara lompatan
PlaySound(entity, "walk")    -- Mainkan suara berjalan
PlaySound(entity, "attack")  -- Mainkan suara serangan

-- Cek apakah suara ada
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Sistem Komponen
- **Transform**: Posisi, rotasi, skala
- **Sprite**: Rendering tekstur
- **Animation**: Animasi berbasis frame
- **Script**: Skrip perilaku Lua
- **Collider**: Tabrakan fisika
- **Rigidbody**: Simulasi fisika
- **Audio**: Musik latar belakang
- **SoundEffects**: Beberapa suara dengan nama
- **Camera**: Manajemen tampilan
## 🤝 Ikut Terlibat

Kami sangat menghargai kontribusi dari komunitas kami ❤️. Untuk detail tentang cara berkontribusi atau menjalankan proyek untuk pengembangan, silakan lihat [Panduan Kontribusi](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Asumsi Anda memiliki file ini -->

- 🐛 Menemukan bug? Buka sebuah issue!
- ✨ Punya ide fitur keren? Kami ingin mendengarnya!
- 💻 Ingin berkontribusi? Fork, coding, dan buat pull request!

Mari kita bangun engine ini bersama dan buat pengembangan game menjadi menyenangkan dan mudah untuk semua orang. 🌍

## 👥 Komunitas
Selamat datang dengan pelukan hangat 🤗. Kami sangat antusias menerima kontribusi dari komunitas dalam segala bentuk - baik itu perbaikan kode 📝, pembaruan dokumentasi 📚, pelaporan masalah 🐞, permintaan fitur 💡, maupun diskusi di Discord kami 🗣️.

Bergabunglah dengan komunitas kami di sini:

- 👋 [Bergabung dengan komunitas Discord kami](https://discord.gg/F3DswRMW)
- ⭐ [Beri bintang di GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Dukung kami:
Kami terus melakukan perbaikan, dan fitur serta contoh baru akan segera hadir 🌟. Jika Anda menyukai proyek ini, mohon berikan bintang ⭐ di repo GitHub kami [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) untuk tetap update dan membantu kami berkembang. 🌱

---

Selamat coding dan membuat game! 🎉🎮


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---