
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Kalender Keluarga Smart Home DIY (Klon Skylight)

![Kalender Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Pendahuluan

Istri saya baru-baru ini dibanjiri iklan kalender smart home (Skylight, Cozyla, Hearth) di media sosial dan hampir membeli satu dengan harga lebih dari $300. Sebelum memberikan izin, saya meminta kesempatan untuk meneliti produk-produk tersebut.
Saya menyadari sebagian besar menawarkan fungsionalitas serupa namun berbeda signifikan dalam harga. Yang paling penting, saya tidak melihat fitur luar biasa yang tidak dapat saya implementasikan di **Home Assistant**.

**Tujuan:** Kalender layar sentuh yang ramah meja dapur dan disetujui WAF (Wife Acceptance Factor), yang terintegrasi mendalam ke smart home kami tanpa biaya bulanan.

## 💡 Mengapa DIY?

Memilih jalur DIY dengan Home Assistant memberikan beberapa keuntungan dibandingkan membeli display Skylight/Hearth:

* **Tanpa Biaya Bulanan:** Menghindari langganan untuk fitur "premium".
* **Integrasi Mulus:** Terhubung dengan lampu, tugas (Grocy), dan sensor kehadiran kami.
* **Perangkat Lama:** Memanfaatkan ulang Mini PC dan monitor standar.
* **Privasi:** Tidak terikat vendor atau risiko perusahaan tutup.

## 🛠 Pilihan Perangkat Keras

Saat ini dibuat untuk menampilkan dashboard di layar HD (1920x1080) apa pun.

Dalam kasus saya, kebutuhannya adalah agar perangkat tersebut "terlihat seperti" skylight, layar sentuh, ramah meja dapur, dan bisa dipindahkan ke lokasi berbeda. Maka saya memilih perangkat keras seperti di bawah ini.
Namun, kasus Anda mungkin berbeda dan perlu disesuaikan sesuai kebutuhan, misalnya jika ingin menampilkan di tablet atau perangkat lain.

Perangkat keras yang awalnya saya gunakan dipilih berdasarkan pertimbangan di atas plus harapan bisa menambah fungsionalitas menggunakan webcam, speaker, dan mikrofon. Saat ini, mungkin saya akan membangunnya secara berbeda jika melihat ke belakang, karena saya belum sempat mengembangkan ide perangkat keras tambahan tersebut.

* **Monitor:** [HP Engage 15-inch Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Saya memilih ini dibanding monitor portable generic karena sudah terdapat **Speaker, Webcam, dan Mikrofon** bawaan, memungkinkan kontrol suara atau panggilan video di masa depan.
* **Komputer:** Mini PC lama (NUC/Tiny PC) menjalankan Windows/Linux dalam mode Kios, atau Raspberry Pi 4.~~

## ✨ Fitur

* **Tampilan Keluarga & Individu:** Mengaktifkan/nonaktifkan kalender anggota keluarga tertentu.
* **Sinkronisasi Dua Arah:** Edit acara di layar atau di ponsel kami (Google Calendar).
* **Popup "Tambah Acara":** UI khusus untuk menambah acara ke kalender tertentu langsung dari layar.
* **Cuaca & Tanggal:** Header yang cantik dan mudah dilihat sekilas.
* **Responsif:** Secara otomatis menyesuaikan jumlah hari berdasarkan lebar layar (Mobile vs Desktop).

---

## ⚙️ Panduan Instalasi

*Catatan: Setup ini menggunakan **YAML Package** untuk secara otomatis membuat semua helper, skrip, dan variabel yang diperlukan untuk Anda. Anda tidak perlu membuatnya secara manual.*



### 1. Prasyarat (HACS)

Anda harus sudah menginstal [HACS](https://hacs.xyz/). Silakan instal integrasi **Frontend** berikut:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Diperlukan agar popup berfungsi)
* `layout-card` (Diperlukan untuk tampilan Sections)
* `button-card` (Diperlukan untuk popup menambah event)

*Catatan: Pada Pengaturan → Perangkat & Layanan, pastikan Browser Mod muncul sebagai Integrasi (ubin) dan bukan hanya di bawah HACS. 
Jika belum ada, klik Tambah Integrasi → Browser Mod dan selesaikan prosesnya, lalu restart HA.
Menginstal melalui HACS hanya mengunduh file; Anda harus menambahkan integrasi agar HA mendaftarkan tindakan/entitasnya.

### 2. Backend (Otak Sistem)

1. Buka file `configuration.yaml` Anda di Home Assistant.
2. Pastikan Anda menambahkan baris ini di bawah `homeassistant:` untuk mengaktifkan paket:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Buat folder bernama `packages` di direktori konfigurasi HA Anda (jika belum ada).
4. Unduh [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) dari repo ini.
5. Cari string [ #<--- UPDATE THIS ENTITY] dan perbarui ID entitas kalender agar sesuai dengan lingkungan Anda. Lihat bagian 3 untuk detail lebih lanjut.
6. Tempatkan file tersebut di dalam folder `packages/` Anda.
7. **Restart Home Assistant**.

### 3. Kalender

Anda dapat menggunakan **Google Kalender** atau **Kalender Lokal**.

#### Opsi A: Gunakan Nama Kalender yang Sama (Paling Mudah)


1. Masuk ke **Settings > Devices & Services**.
2. Tambahkan integrasi **Local Calendar**.
3. Buat kalender dengan nama persis: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Jika Anda menggunakan nama-nama ini, kode akan langsung bekerja!*

#### Opsi B: Kalender Kustom

1. Masuk ke **Settings > Devices & Services**.
2. Tambahkan integrasi **Local Calendar** atau **Google Calendar**.
3. Buka **Configuration > Integrations > Local Calendar** atau **Google Calendar** dan pilih "Add Entry"
4. Untuk setiap entri yang dibuat, dapatkan ID entitas untuk memperbarui file dashboard.yaml.
5. Buka `dashboard.yaml`.
6. Cari `# <--- UPDATE THIS ENTITY`.
7. Perbarui ID entitas sesuai dengan lingkungan Anda


#### Mengatur Hari Libur

Sejak pembaruan Home Assistant, Hari Libur sekarang ditambahkan melalui UI:

1. Masuk ke **Settings > Devices & Services > Add Integration > Holiday**.
2. Pilih negara Anda.
3. Periksa ID entitas (misalnya, `calendar.holidays`). Jika berbeda dari default, perbarui di YAML dashboard.

### 4. Dashboard (Tampilan)


1. Pergi ke **Pengaturan > Dasbor**
2. Klik **Tambah Dasbor** (Pilih opsi "Dasbor Baru dari Awal" pastikan untuk memilih "Tambahkan ke sidebar").
3. Pada menu sebelah kiri, pilih dasbor yang baru dibuat dan klik ikon pensil untuk mengeditnya.
5. Pilih ikon 3 titik dan pilih "Editor konfigurator mentah".
6. Salin dan tempel kode dari [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### Langkah 5: Tema (Opsional)

Untuk mendapatkan tampilan font spesifik (Ovo):

1. Pastikan `configuration.yaml` Anda memiliki baris ini di bawah `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Buat folder bernama `themes` di direktori konfigurasi Anda.
3. Unduh [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) dan tempatkan di folder tersebut.
4. Gunakan File Editor dan unggah calbackgrd.png ke folder /www/, yang secara internal diterjemahkan menjadi /local di dashboard.
5. Restart Home Assistant.
6. Buka Profil Anda (Ikon Pengguna di kiri bawah) dan ubah **Theme** menjadi `Skylight`.
CATATAN: Tema ini tidak komprehensif, jadi harap diingat

---

## 📐 Cara Kerja (Di Balik Layar)

### Logika Filter

`week-planner-card` tidak secara native mendukung penyembunyian kalender tertentu secara langsung. Untuk mengatasinya, saya menggunakan **Input Texts** yang bertindak sebagai filter Regex.

* Saat Anda mengklik tombol seseorang, itu akan mengubah filter mereka antara `.*` (Tampilkan semua) dan `^$` (Sembunyikan semua).
* `config-template-card` secara dinamis menyuntikkan variabel ini ke kartu kalender.

### Skrip Pembuatan Event

Popup "Add Event" menggunakan satu skrip yang menangani logika untuk banyak orang dan tipe acara (Sepanjang Hari vs Bertime).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## CATATAN

Postingan asli saya hanya untuk memberikan gambaran tingkat tinggi tentang cara melakukannya dan memungkinkan orang menyesuaikan kode agar berfungsi dalam skenario spesifik mereka.

Secara khusus saya melakukan ini karena setiap tampilan dan kebutuhan berbeda. Saya tidak bisa mengembangkan untuk semua ukuran tampilan, dasbor, dll yang mungkin. Jadi, kode ini dibuat untuk bekerja pada tampilan yang saya sebutkan atau lainnya (1920x1080) namun seharusnya dapat diedit untuk yang lain.

Berbicara tentang tampilan, saya awalnya menyarankan yang itu karena sedang diskon di Woot dan merupakan cara yang sangat ekonomis untuk mendapatkan layar sentuh pada saat itu. Mungkin sekarang tidak lagi, jadi gunakan tampilan apa pun yang cocok untuk Anda. Tablet, layar sentuh, ponsel, apa saja. Hal utama yang perlu Anda edit adalah dasbornya.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---