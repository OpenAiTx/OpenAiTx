# SparkyFitness - Alternatif Selfhosted untuk MyFitnessPal

SparkyFitness adalah aplikasi pelacakan dan manajemen kebugaran yang komprehensif, dirancang untuk membantu pengguna memantau nutrisi, olahraga, dan pengukuran tubuh mereka. Aplikasi ini menyediakan alat untuk pelacakan kemajuan harian, penetapan tujuan, dan laporan yang informatif untuk mendukung gaya hidup sehat.


## ✨ Fitur

### 🍎 Pelacakan Nutrisi

* **Catat makanan harian Anda**
* **Buat dan kelola makanan serta kategori khusus**
* **Lihat ringkasan dan analisis tren dengan grafik interaktif**

### 💪 Pencatatan Latihan

* **Catat latihan Anda**
* **Telusuri dan cari basis data latihan yang komprehensif**
* **Lacak kemajuan kebugaran seiring waktu**

### 💧 Pemantauan Asupan Air

* **Lacak target hidrasi harian**
* **Pencatatan air yang cepat dan sederhana**

### 📏 Pengukuran Tubuh

* **Catat metrik tubuh** (misal: berat badan, pinggang, lengan)
* **Tambahkan jenis pengukuran khusus**
* **Visualisasikan kemajuan melalui grafik**

### 🎯 Penetapan Tujuan

* **Tetapkan dan kelola tujuan kebugaran dan nutrisi**
* **Lacak kemajuan dari waktu ke waktu**

### 🗓️ Check-In Harian

* **Pantau aktivitas harian**
* **Tetap konsisten dengan pelacakan kebiasaan**

### 🤖 AI Nutrition Coach (SparkyAI)

* **Catat makanan, latihan, statistik tubuh, dan langkah melalui chat**
* **Unggah gambar makanan untuk pencatatan otomatis**
* **Termasuk riwayat chat dan panduan yang dipersonalisasi**

### 🔒 Autentikasi Pengguna & Profil

* **Sistem login yang aman**
* **Beralih antar profil pengguna**
* **Dukungan untuk akses dan manajemen keluarga**

### 📊 Laporan Komprehensif

* **Buat ringkasan nutrisi dan metrik tubuh**
* **Lacak tren jangka panjang selama minggu atau bulan**

### 🎨 Tema yang Dapat Dikustomisasi

* **Beralih antara mode terang dan gelap**
* **Dirancang dengan antarmuka minimalis dan bebas gangguan**

### Butuh Bantuan?
* **Gabung Discord**
  https://discord.gg/vcnMT5cPEA
* **Posting di diskusi**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Memulai

Untuk menjalankan aplikasi SparkyFitness di mesin lokal Anda, ikuti langkah-langkah berikut:

### Prasyarat

*   **Proyek Supabase**: Anda memerlukan proyek Supabase yang sudah disiapkan.
    *   **Buat proyek baru di Supabase**: Kunjungi [Supabase](https://app.supabase.com/) dan buat proyek baru. (Anda juga dapat mencoba menyiapkan proyek Supabase secara lokal jika diinginkan.)
    *   Dapatkan URL Proyek Supabase dan Anon Key Anda dari pengaturan proyek (bagian API).
    *   **Catatan Penting tentang Autentikasi Supabase:** Perbarui Konfigurasi URL Anda di pengaturan Autentikasi Supabase agar sesuai dengan domain Anda. Ini penting agar domain Anda dapat berfungsi dan untuk menerima undangan email saat pendaftaran. Supabase menawarkan fitur keamanan yang luas dan opsi SSO pihak ketiga; konfigurasikan sesuai kebutuhan proyek Anda.
    *   Deployment DB otomatis ke Supabase tidak berfungsi dengan IPV4 jika Anda menggunakan versi gratis Supabase. Jadi, Anda perlu mengonfigurasi Jaringan Anda untuk menggunakan koneksi IPV6. Jika tidak, migrasi DB akan gagal dan Anda harus melakukan deployment manual.       


    

### Instalasi

1.  **Konfigurasikan Variabel Lingkungan:**
    Buat file `.env` di dalam folder private. Jika Anda menggunakan Portainer, buat langsung di sana.
    Tambahkan kredensial Supabase Anda:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Jalankan dengan Docker Compose:**
    Tarik image Docker dan mulai layanan:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **Akses Aplikasi:**
    Setelah semua layanan berjalan, akses SparkyFitness di browser web Anda pada:
    ```
    http://localhost:3000
    ```

4.  **Chatbot AI - Konfigurasi Opsional:**
    Untuk mengaktifkan seluruh fungsionalitas Chatbot AI, termasuk penyimpanan kunci API yang aman dan akses database, ikuti langkah-langkah berikut:

    *   **Konfigurasi `AI_API_ENCRYPTION_KEY`:** Buat secret di "Supabase -> Edge Functions" -> "Environment Variables". Kunci ini digunakan untuk mengenkripsi kunci AI Anda saat disimpan di dalam Supabase.

    *   **Generate `SUPABASE_ACCESS_TOKEN`:**
        1.  Akses konsol Docker Anda.
        2.  Jalankan `supabase login` dan lakukan autentikasi menggunakan URL yang disediakan.
        3.  Ambil access token dengan menjalankan `cat ~/.supabase/access-token`.
        4.  Perbarui `docker-compose.yml` atau konfigurasi Portainer Anda dengan token ini untuk melakukan redeploy.
        5.  Setelah redeploy, login ke SparkyFitness dan konfigurasikan layanan AI dengan provider pilihan Anda.
     

### Deployment Manual DB & Fungsi ke Supabase
**Metode 1:  
**Jika Anda tidak memiliki koneksi jaringan IPV6 yang diaktifkan, migrasi DB akan gagal karena versi gratis Supabase tidak mendukung koneksi langsung IPV4.

   1. Unduh rilis terbaru dan ekstrak ke PC Anda.
   2. Masuk ke folder proyek. Docker harus sudah berjalan.
   3. Jalankan perintah di bawah ini. (deploy functions hanya diperlukan untuk konfigurasi AI. Jika Anda tidak membutuhkan ChatBOT, Anda dapat melewatinya)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Jalankan kembali Docker compose. Aplikasi Front end akan mulai berjalan.

**Metode 2:  
   1. Unduh rilis terbaru dan ekstrak ke PC Anda.  
   2. Masuk ke folder proyek.  
   3. Masuk ke supabase/migrations. Salin pernyataan SQL dan jalankan satu per satu di Supabase-->Project-->SQL Editor secara berurutan ASC.  
   4. [Opsional] Lakukan hal yang sama untuk supabase/functions/chat jika Anda membutuhkan AI ChatBOT. Salin index.js dan jalankan di Supabase-->Project-->Edge Function-->Deploy new function.  

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---