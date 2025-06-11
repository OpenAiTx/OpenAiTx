# RSS-Master

Untuk kustomisasi penyaringan dan filtrasi sumber RSS, menggunakan AI untuk merangkum, menyimpulkan, memberi skor, dll. Versi dengan optimasi performa, mendukung pemrosesan asinkron dan ringkasan AI paralel.

### Pendahuluan

Awal September, saya mulai menggunakan Inoreader + RSSHub untuk menggabungkan dan berlangganan RSS yang saya minati, dipadukan dengan Reeder untuk membaca, mencoba mengendalikan sepenuhnya sumber informasi harian. Setelah satu bulan, jumlah sumber RSS yang bertambah dan informasi belum dibaca yang terus meningkat menambah kecemasan saya dalam membaca, sehingga saya bertanya-tanya apakah ada cara untuk membuat aturan filtrasi khusus, idealnya dengan bantuan AI untuk mengurangi beban membaca saya.

Inoreader menyediakan filter bawaan, tapi hanya untuk fitur ini rasanya kurang sepadan; NewsBlur memiliki "Intelligence Trainer" untuk klasifikasi cerdas, tapi saya coba sederhana dan merasa feedback-nya tidak signifikan, tidak menunjukkan kecerdasan dalam waktu singkat; Feedly memiliki filter dan fitur AI, terdengar cocok dengan kebutuhan saya, saat saya ragu untuk pindah dari Inoreader ke pengguna berbayar Feedly, saya menemukan dua proyek ini

- [Biarkan ChatGPT membantu kita merangkum Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Panduan penggunaan RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

Kedua proyek ini pada dasarnya menjalankan skrip melalui GitAction, mengambil informasi lalu menggunakan API Open AI untuk terjemahan, ringkasan, dan kemudian merender ke template, diterbitkan ke GitHub Page. Metode dalam RSS-GPT lebih memenuhi kebutuhan saya, dengan menjalankan skrip terjadwal untuk langsung mendapatkan file xml RSS, memprosesnya lalu menerbitkan xml ke GitHub Page sehingga dapat diperoleh link akses file xml tersebut, dan akhirnya pembaca cukup berlangganan ke link ini.

Saya memiliki kebutuhan kuat untuk sinkronisasi multi-perangkat Inoreader, untuk sumber RSS baru yang ditambahkan di file konfigurasi, perlu segera memberi tahu Inoreader agar sinkron. Maka saya mengembangkan dari ide [RSS-GPT](https://github.com/yinan-c/) menjadi RSS-Master.

### Fitur Unggulan

- **Mendukung pemrosesan paralel**: Menggunakan asinkron dan thread pool untuk pemrosesan paralel sumber RSS dan ringkasan AI, mempercepat proses secara signifikan
- **Mekanisme cache yang ditingkatkan**: Sistem cache lebih stabil, mencegah kehilangan data dan meningkatkan performa akses ulang
- **Penanganan error lebih baik**: Semua operasi lengkap dengan penanganan error dan pencatatan log, meningkatkan stabilitas
- **Optimasi ekstraksi konten HTML**: Ekstraksi konten artikel secara cerdas, mengabaikan informasi tidak relevan, meningkatkan kualitas ringkasan AI
- **Dukungan API OpenAI terbaru**: Kompatibel penuh dengan versi terbaru API OpenAI
- **Statistik detail**: Menyediakan waktu eksekusi, tingkat keberhasilan, dan statistik biaya setelah pemrosesan selesai
- **Mendukung pembuatan file opml**: Serta konversi timbal balik dengan config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Dukungan aturan filter kustom**: Mendukung tipe include dan exclude, dengan cakupan pada title dan artikel
- **Model AI yang dapat dikustomisasi**: Konfigurasi model OpenAI berbeda melalui variabel lingkungan
- **URL dasar yang dapat dikustomisasi**: Pengaturan URL dasar file RSS agar mudah diterapkan di berbagai lingkungan
- **Notebook interaktif untuk pengujian**: Disediakan Jupyter notebook untuk pengujian berbagai fitur

### Konfigurasi Variabel Lingkungan

Proyek mendukung pengaturan parameter berikut melalui file `.env`:

```
# Parameter wajib
OPENAI_API_KEY=your_openai_api_key_here

# Parameter opsional
RSS_BASE_URL=https://example.com/rss-feeds/  # URL dasar RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Model OpenAI
LOG_LEVEL=INFO                               # Level log
PARALLEL_WORKERS=5                           # Jumlah proses paralel
```

Anda bisa menyalin file `.env.example` dan mengubah namanya menjadi `.env`, lalu sesuaikan nilai parameter sesuai kebutuhan.

### Perbaikan Performa

Versi ini memiliki perbaikan performa dibanding versi asli:

1. **Pemrosesan sumber RSS paralel**: Menggunakan `asyncio` untuk menangani banyak sumber RSS sekaligus
2. **Ringkasan AI paralel**: Menggunakan thread pool untuk memproses ringkasan AI banyak artikel secara bersamaan
3. **Optimasi pemrosesan teks**: Algoritma ekstraksi konten HTML yang lebih cerdas untuk mengambil inti artikel
4. **Penanganan file yang aman**: Mekanisme penulisan file yang aman untuk mencegah kehilangan data akibat crash
5. **Optimasi penggunaan memori**: Struktur data dan proses yang lebih efisien mengurangi penggunaan memori

### Cara Penggunaan

1. Kloning proyek ke lokal
2. Instal dependensi: `pip install -r requirements.txt`
3. Buat file `.env` dan setel kunci API OpenAI: `OPENAI_API_KEY=kunci_anda`
4. Edit `resource/config.yml` untuk mengatur sumber RSS Anda
5. Jalankan `python main.py` untuk memulai pemrosesan

### Pengujian dan Debugging

Proyek menyediakan notebook interaktif `test.ipynb` untuk menguji berbagai fitur:

1. Pengambilan dan parsing sumber RSS
2. Fungsi filter
3. Fungsi ringkasan AI
4. Mekanisme cache
5. Kustomisasi URL dasar
6. Pengujian performa

Cara penggunaan:

```bash
# Install Jupyter
pip install jupyter

# Jalankan notebook
jupyter notebook test.ipynb
```

### Contoh Aturan Filter Kustom

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: Apa yang layak dibeli | Pilihan diskon
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          'Coca-Cola',
          'Sprite',
          'Fanta',
          'Lemon',
          'Teh',
          'Tisu',
          'Alkohol',
          'Tisu basah',
          'Serbet',
        ]
```

### Screenshot Penggunaan

- Fungsi ringkasan dan abstraksi AI

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Filter kustom: menyaring channel diskon "Apa yang layak dibeli", hanya merekomendasikan barang yang ingin saya stok akhir-akhir ini, seperti minuman bersoda

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---