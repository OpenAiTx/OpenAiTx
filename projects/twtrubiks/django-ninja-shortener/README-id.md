# Django Ninja Shortener - Layanan Short URL Mirip Bitly

Layanan short URL modern yang dibangun dengan Django, Django Ninja, dan Tailwind CSS, terinspirasi dari desain Bitly.

Pengguna dapat mendaftar dan login, lalu memperpendek URL, serta melacak jumlah klik pada setiap short URL.

Proyek ini menggunakan [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) untuk membantu pengembangan, dapat merujuk ke [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Screenshot Tampilan

Halaman short URL (bisa digunakan tanpa registrasi)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Jika mendaftar, dapat melacak klik

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Fitur Unggulan

* **Autentikasi Pengguna**: Mendukung pendaftaran, login, dan logout pengguna.
* **Buat Short URL**: Pengguna yang sudah login dapat menghasilkan short URL unik dari long URL.
* **Redirect Short URL**: Klik pada short URL akan mengarahkan pengguna ke long URL asli.
* **Pelacakan Jumlah Klik**: Sistem secara otomatis menghitung berapa kali setiap short URL diklik.
* **Dashboard Pribadi**: Pengguna dapat melihat semua short URL yang dibuat beserta statistik kliknya.
* **RESTful API**: Menyediakan endpoint API untuk membuat short URL secara terprogram.
* **Dukungan Docker**: Tersedia Dockerfile dan Docker Compose untuk mempermudah pengembangan dan deployment.

## 🛠️ Stack Teknologi

* **Framework Backend**: [Django](https://github.com/twtrubiks/django-tutorial)
* **Framework API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Styling Frontend**: [Tailwind CSS](https://tailwindcss.com/) (terintegrasi dengan `django-tailwind`)
* **Database**:
  * Lingkungan pengembangan: SQLite (default)
  * Lingkungan produksi: Bisa diganti dengan PostgreSQL dengan mudah (sudah disiapkan di `settings.py`)
* **Kode Short URL**: Menggunakan `shortuuid`
* **Testing**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerization**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Quick Start (Menggunakan Docker, Disarankan)

Ini adalah cara paling direkomendasikan untuk memulai, memastikan konsistensi lingkungan pengembangan.

**Langkah Memulai:**

1. **Jalankan layanan:**

    Gunakan Docker Compose untuk menjalankan semua layanan dengan satu perintah.

    ```bash
    docker compose up --build
    ```

    Perintah ini akan membangun image Docker, menginstal dependensi, menjalankan migrasi database, dan memulai development server.

2. **Buat Superuser (opsional):**

    Jika ingin mengakses Django Admin, jalankan di jendela terminal lain:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Akses Aplikasi:**

    * **Homepage**: [http://localhost:8000](http://localhost:8000)

    * **Dokumentasi API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Pengembangan Lokal (Tanpa Docker)

Jika Anda lebih suka menyiapkan lingkungan langsung di lokal.

**Prasyarat:**

* Python 3.12
* Node.js dan npm (untuk Tailwind CSS)

**Langkah-langkah Setup:**

1. **Buat dan aktifkan virtual environment:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Di Windows, gunakan `venv\Scripts\activate`
    ```

2. **Instal dependensi Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Instal dan setup Tailwind CSS:**

    `django-tailwind` akan menangani sebagian besar konfigurasi.

    ```bash
    python manage.py tailwind install
    ```

    Lihat juga [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Jalankan migrasi database:**

    ```bash
    python manage.py migrate
    ```

5. **Buat superuser (opsional):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Jalankan development server:**

    Anda harus menjalankan server Django dan proses kompilasi Tailwind CSS secara bersamaan.

    ```bash
    python manage.py runserver
    ```

    Pada terminal lain:

    ```bash
    python manage.py tailwind start
    ```

7. **Akses Aplikasi:**

    * **Homepage**: [http://localhost:8000](http://localhost:8000)

    * **Dokumentasi API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Menjalankan Testing

Proyek ini menggunakan `pytest` untuk testing dan menghitung coverage.

Rencana pengujian dapat dilihat di [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Menjalankan testing dengan Docker:**

    ```bash
    docker compose --profile test up
    ```

    Laporan hasil testing akan tersedia di `htmlcov/index.html`.

* **Menjalankan testing secara lokal:**

    ```bash
    # Pastikan dependensi development sudah terinstal
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Endpoint API

API menyediakan cara terprogram untuk berinteraksi dengan layanan short URL. Semua endpoint API berada di bawah path `/api/`.

Disarankan untuk langsung ke **Dokumentasi API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Gunakan [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), panggil `/api/token/pair` sesuai username dan password, untuk mendapatkan token Anda

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Kemudian tempel token di kanan atas, lalu Anda bisa memanggil API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Struktur Proyek

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Konfigurasi proyek Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Aplikasi inti short URL
│   ├── models.py         # Model database (Link)
│   ├── api.py            # Endpoint Django Ninja API
│   ├── views.py          # View halaman & logika redirect
│   └── utils.py          # Utility generator short code
└── theme/                # Tema & template Django
    ├── templates/        # Template HTML
    └── static_src/       # Source Tailwind CSS
```

## 💡 Rencana Pengembangan

* **Switch ke PostgreSQL**: Menyediakan database yang lebih kuat untuk produksi. (Selesai)
* **Dashboard Analitik Detail**: Menyediakan lebih banyak data klik, seperti waktu, sumber, lokasi geografis, dll.
* **Kustomisasi URL Pendek**: Mengizinkan pengguna untuk menyesuaikan kode URL pendek.
* **Pembuatan QR Code**: Menghasilkan QR Code yang sesuai untuk setiap URL pendek.
* **Tugas Asinkron**: Menggunakan Celery untuk menangani tugas yang memakan waktu, seperti analisis data.

## Donasi

Semua artikel adalah hasil riset dan karya orisinal saya sendiri. Jika Anda merasa terbantu dan ingin memberikan dukungan, silakan traktir saya secangkir kopi :laughing:

ECPAY (Tidak perlu registrasi)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Pembayaran Donatur](http://bit.ly/2F7Jrha)

O'Pay (Perlu registrasi)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Pembayaran Donatur](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Daftar Donatur

[Daftar Donatur](https://github.com/twtrubiks/Thank-you-for-donate)

## Lisensi

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---