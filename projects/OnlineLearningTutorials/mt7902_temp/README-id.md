
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 Driver sebagai Sub-Bagian dari Driver MT7921 (✅ Berfungsi)
Chip wifi 6E Mediatek mt7902 mendukung Bluetooth dan WiFi

> [!PENTING]
> Kernel Linux 7.1 Secara Resmi Mendukung chip WIFI 6E MT7902


## 📁 Mengkloning repository
Klon repositori ke PC lokal Anda
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Jika Anda tidak ingin mengkloning riwayat sebelumnya maka
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Instalasi


### 🚀 Panduan Instalasi Script (Direkomendasikan untuk Sistem Berbasis Ubuntu)
Buat script dapat dieksekusi jika belum
```
chmod +x ./install_guide.sh
```
Sekarang jalankan skrip ini
```
./install_guide.sh
```
Ini akan secara otomatis meminta password jika diperlukan
* Skrip ini akan meminta Anda untuk menginstal firmware, driver bluetooth dan wifi satu per satu
* Telah diuji di Ubuntu dengan kernel linux 7.0

### 🚀 Perbaikan Otomatis Mudah (Direkomendasikan untuk Sistem Berbasis Arch)
Jika Anda ingin memperbaiki WiFi dan Bluetooth dengan cepat pada kernel modern mana pun, ikuti langkah-langkah berikut:

Jadikan skrip dapat dieksekusi jika belum
```
chmod +x ./fix_my_wifi.sh
```

**Jalankan skrip perbaikan otomatis** dengan sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Apa yang dilakukan skrip ini:
* **Memeriksa dependensi:** Memastikan Anda memiliki `gcc`/`clang`, `make`, `bc`, dan `kernel-headers` saat ini terpasang. Jika belum - akan memasang dengan manajer paket pilihan Anda
* **Menyusun Driver:** Secara otomatis membangun driver WiFi dan Bluetooth untuk versi kernel Anda yang tepat.
* **Perbaikan Persisten:** Memasang layanan sistem yang memastikan WiFi Anda tetap aktif bahkan setelah Anda restart komputer.
* **Keamanan:** Memasang modul ke direktori khusus (`/lib/modules/mt7902_custom`) untuk menghindari perubahan pada file sistem default Anda.

> [!NOTE]
> Anda membutuhkan koneksi internet (melalui Ethernet atau tethering USB dari ponsel Anda) saat pertama kali menjalankan ini untuk mengunduh alat build yang diperlukan. (Seperti compiler, linux-headers, dll)


## ✅ Diuji Pada (Terbukti Berfungsi)
Perbaikan ini telah diverifikasi dan dikonfirmasi berfungsi pada:

* **Merek:** ASUS
* **Model:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Versi Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **OS:** Arch, Ubuntu
* **Manajer Paket:** pacman, apt

## Tersedia untuk:
* **OS**: OS apapun yang mendukung salah satu PM
* **Manajer paket pilihan**: apt, pacman, dnf, zypper, nix-shell
* **Versi kernel**: 6.14-7.0.7


## 🔧 Firmware yang digunakan
Firmware disimpan di folder `firmware`.


## 📱 Bluetooth ✅ (Berfungsi)
> [!WARNING]
> Jika driver bluetooth konflik dengan `gen4-mt7902` maka silakan hapus firmware bluetooth agar tidak mengganggu driver ini
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Proyek ini menggunakan firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Untuk mengaktifkan bluetooth, buka direktori versi kernel Anda saat ini. ``
Misalnya jika Anda memiliki kernel linux-6.16 maka buka direktori `./linux-6.16/drivers/bluetooth` .
Buka terminal di direktori ini dan kompilasi dengan perintah `make`.
Dua modul kernel akan dikompilasi `btusb.ko` dan `btmtk.ko`.
Untuk mengaktifkan bluetooth di perangkat Anda, hapus btusb dan btmtk di sistem Anda dan instal kedua file ini, gunakan perintah
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Sekarang periksa apakah bluetooth Anda sudah berfungsi sekarang.

## 💻 WiFi ✅ (Berfungsi)
> [!PENTING]
> Repo yang berfungsi dengan beberapa keterbatasan ada [di sini](https://github.com/hmtheboy154/gen4-mt7902)

Driver WiFi untuk mt7902, yang baru saja dirilis oleh mediatek, ada di dalam folder `latest`.

Jika Anda menggunakan Ubuntu, cukup masuk ke folder `latest` dan jalankan perintah berikut di terminal.
```
make
```

Ini akan mengompilasi semua modul, mengompresnya, dan menginstalnya (mengganti modul kernel asli dengan modul yang telah dimodifikasi). Jika Anda menggunakan distro lain atau tidak ingin semua langkah dan hanya ingin mengompilasi kode, maka jalankan di terminal
```
make module_compile
```
Untuk mengompresi modul yang telah Anda kompilasi, lalu jalankan di terminal
```
make module_compress
```
Untuk menginstal modul terkompresi ke modul kernel sistem, jalankan di terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---