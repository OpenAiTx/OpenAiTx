
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

Anda harus memasang [HACS](https://hacs.xyz/). Silakan pasang integrasi **Frontend** berikut:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Diperlukan agar popup berfungsi)
* `layout-card` (Diperlukan untuk tampilan Sections)
* `button-card` (Diperlukan untuk popup penambahan event)

### 2. Backend (Otaknya)

1. Buka file `configuration.yaml` Anda di Home Assistant.
2. Pastikan Anda menambahkan baris ini di bawah `homeassistant:` untuk mengaktifkan paket:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Buat folder bernama `packages` di direktori konfigurasi HA Anda (jika belum ada).
4. Unduh [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) dari repo ini.
5. Tempatkan file tersebut di dalam folder `packages/` Anda.
6. **Restart Home Assistant**.

### 3. Kalender

Anda dapat menggunakan **Google Calendars** atau **Local Calendars**.

#### Opsi A: Kalender Lokal (Paling Mudah)

Catatan: Ini belum diuji karena saya hanya menggunakan Google Calendars

1. Buka **Settings > Devices & Services**.
2. Tambahkan integrasi **Local Calendar**.
3. Buat kalender dengan nama persis: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Jika Anda menggunakan nama-nama ini, kode akan langsung bekerja!*

#### Opsi B: Google Calendar

1. Buka `packages/family_calendar.yaml`.
2. Scroll ke skrip `add_google_calendar_event`.
3. Perbarui `calendar_map` agar menunjuk ke entitas Google Anda yang sebenarnya:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Mengatur Hari Libur

Sejak pembaruan Home Assistant, Hari Libur sekarang ditambahkan melalui UI:

1. Buka **Pengaturan > Perangkat & Layanan > Tambah Integrasi > Holiday**.
2. Pilih negara Anda.
3. Periksa ID entitas (misal, `calendar.holidays`). Jika berbeda dari default, perbarui di YAML dashboard.

### 4. Dashboard (Tampilan)

1. Buat Tampilan Dashboard baru (Setel Jenis Tampilan ke **Sections**).
2. Salin kode dari [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Kustomisasi:**
   * **Cari & Ganti:** Ganti `person.alice` dengan entitas anggota keluarga Anda yang sebenarnya.
   * **Cuaca:** Ganti `weather.home` dengan penyedia cuaca Anda.
   * **Latar Belakang:** Perbarui URL gambar di bagian bawah yaml.

### Langkah 5: Tema (Opsional)

Untuk mendapatkan tampilan font spesifik (Ovo):

1. Pastikan `configuration.yaml` Anda memiliki baris ini di bawah `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Buat folder bernama `themes` di direktori konfigurasi Anda.
3. Unduh [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) dan tempatkan di folder tersebut.
4. Restart Home Assistant.
5. Buka Profil Anda (Ikon Pengguna di kiri bawah) dan ubah **Tema** menjadi `Skylight`.
CATATAN: Tema ini tidak komprehensif, jadi harap diingat

---

## 📐 Cara Kerjanya (Di Balik Layar)

### Logika Filter

`week-planner-card` tidak secara native mendukung penyembunyian kalender tertentu secara langsung. Untuk mengatasinya, saya menggunakan **Input Texts** yang berfungsi sebagai filter Regex.

* Ketika Anda mengklik tombol seseorang, filter mereka akan berganti antara `.*` (Tampilkan semua) dan `^$` (Sembunyikan semua).
* `config-template-card` menyisipkan variabel ini ke dalam kartu kalender secara dinamis.

### Skrip Pembuatan Acara

Popup "Tambah Acara" menggunakan satu skrip yang menangani logika untuk beberapa orang dan jenis acara (Sepanjang Hari vs Waktu Tertentu).


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---