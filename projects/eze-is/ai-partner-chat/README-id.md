
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Sebuah proyek Claude Skills, yang memungkinkan AI menjadi mitra percakapan personal Anda.

## Ringkasan Proyek

AI Partner Chat mengintegrasikan profil pengguna, profil AI, dan catatan pribadi yang telah vektorisasi untuk memberikan pengalaman percakapan yang personal dan kontekstual. Skill ini memungkinkan AI mengingat dan mengutip ide, preferensi, serta basis pengetahuan Anda sebelumnya, menciptakan interaksi yang lebih kohesif dan personal.

## Fitur Inti

### 🎭 Sistem Dua Profil
- **Profil Pengguna**: Mendefinisikan latar belakang, keahlian, minat, dan preferensi komunikasi Anda
- **Profil AI**: Menyesuaikan peran, gaya komunikasi, dan cara interaksi AI

### 📝 Pencarian Catatan Pintar
- Secara otomatis mengindeks catatan Markdown Anda
- Mencari riwayat terkait secara cerdas berdasarkan isi percakapan
- Mengutip ide dan catatan Anda sebelumnya secara alami dalam percakapan

### 💬 Percakapan Personal
- Menghasilkan respons personal berdasarkan profil dan catatan Anda
- Menjaga kesinambungan konteks percakapan
- Mengutip ide Anda secara alami layaknya teman, bukan secara kaku “berdasarkan catatan”

## Skenario Penggunaan

Ketika Anda membutuhkan:
- Komunikasi yang dipersonalisasi, bukan respons generik
- Respons yang sadar konteks, AI dapat mengingat latar belakang Anda
- AI mengingat dan mengutip ide serta catatan Anda sebelumnya
- Pengalaman percakapan berkelanjutan, bukan selalu dimulai dari awal

## Instalasi & Penggunaan

### Instalasi Skill

Salin proyek ini ke folder `.claude/skills/` di direktori kerja Anda:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Menggunakan Keterampilan

Di Claude Code, kirimkan perintah berikut untuk mengaktifkan keterampilan ini:

```
遵循 ai-partner-chat 对话
```

Agen AI akan secara otomatis:
- Membaca konfigurasi dan petunjuk keterampilan
- Membuat struktur direktori yang diperlukan (`notes/`, `config/`, `vector_db/` dan sebagainya)
- Melakukan inisialisasi sesuai kebutuhanmu

### Proses Inisialisasi

#### Cara 1: Biarkan AI membuat dan mengkonfigurasi secara otomatis

Saat pertama kali digunakan, langsung beri tahu AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```
AI agent akan:
1. Menganalisis konten catatan dalam direktori `notes/`
2. Membagi secara cerdas berdasarkan format catatan dan membuat basis data vektor
3. Menyimpulkan latar belakang dan preferensi Anda berdasarkan isi catatan
4. Secara otomatis menghasilkan dan memperbarui `config/user-persona.md`
5. Merekomendasikan dan membuat `config/ai-persona.md` berdasarkan karakteristik Anda

#### Cara Kedua: Konfigurasi Profil Secara Manual

Jika Anda ingin mendefinisikan profil sendiri:
1. AI agent akan secara otomatis membuat file profil dari template ke direktori `config/`
2. Anda dapat mengedit file-file tersebut secara manual untuk menyesuaikan profil
3. Lalu beritahu AI untuk melakukan proses vektorisasi

### Mulai Percakapan

Setelah konfigurasi selesai, setiap kali menggunakan cukup kirimkan:


```
遵循 ai-partner-chat 对话
```
AI akan:
- Membaca profil Anda untuk memahami latar belakang Anda
- Mengambil catatan historis yang relevan
- Menghasilkan respons yang dipersonalisasi dan peka konteks

## Struktur Proyek

### Struktur Paket Keterampilan (berada di `.claude/skills/ai-partner-chat/`)


```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Direktori Data Pengguna (berada di direktori utama proyek)

Agen AI akan membuat struktur berikut di direktori utama proyek Anda:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```
**Penting**: Data pengguna dan paket keterampilan dipisahkan, sehingga mudah untuk pencadangan dan migrasi.

## Alur Kerja

1. **Memuat Profil**: Membaca profil pengguna dan AI, memahami latar belakang interaksi
2. **Mengambil Catatan**: Mengambil catatan paling relevan dari basis data vektor sesuai permintaan pengguna
3. **Membangun Konteks**: Mengintegrasikan informasi profil, catatan terkait, dan riwayat percakapan
4. **Menghasilkan Tanggapan**: Menghasilkan tanggapan yang dipersonalisasi dan alami berdasarkan konteks

## Fitur Unggulan

### 🤖 Pembagian Cerdas oleh AI Agent
Sistem menganalisis format nyata setiap catatan, lalu secara dinamis menghasilkan strategi pembagian paling sesuai, bukan memakai template tetap. Artinya, apapun format catatanmu, akan diproses secara optimal.

### 🎯 Referensi Alami
AI akan menyisipkan informasi lampau milikmu secara alami seperti mengingat, tanpa berkata kaku "berdasarkan catatan", namun mengalir dalam percakapan.

### 📦 Data Mandiri
Semua datamu (catatan, profil, basis vektor) disimpan di direktori utama proyek, sehingga mudah dicadangkan, dipindahkan, atau dibagikan antar keterampilan.

## Praktik Terbaik

### Desain Profil
- **Spesifik & Jelas**: Profil yang samar menghasilkan respons generik
- **Sertakan Contoh**: Tunjukkan pola interaksi yang diharapkan di profil AI
- **Perbarui Berkala**: Optimalkan profil sesuai kualitas percakapan

### Manajemen Catatan
- **Format Bebas**: Sistem dapat menyesuaikan dengan struktur catatan apapun
- **Isi Kaya**: Catatan mendalam meningkatkan hasil pencarian
- **Update Tepat Waktu**: Tambahkan catatan baru ke indeks segera

### Pengalaman Percakapan
- **Referensi Alami**: Hanya rujuk catatan jika benar-benar relevan
- **Jaga Kelancaran**: Jangan biarkan referensi mengganggu alur alami percakapan
- **Prioritaskan Kualitas**: Utamakan koneksi bermakna, bukan banyaknya referensi

## Pemeliharaan & Pembaruan


### Menambahkan Catatan Baru
Setelah menempatkan catatan baru ke dalam direktori `notes/`, beri tahu AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

Agen AI akan secara otomatis menganalisis catatan baru dan memperbarui indeks.

### Memperbarui Profil
Kamu dapat langsung mengedit file profil di direktori `config/`, atau memberi tahu AI:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Membangun Ulang Indeks
Ketika struktur catatan berubah secara signifikan, beri tahu AI:

```
请重新初始化向量数据库
```

Agen AI akan menganalisis ulang semua catatan dan membangun ulang indeks.

## Catatan Penting

- **Pertama kali dijalankan**: Agen AI akan otomatis mengunduh model embedding (sekitar 4,3GB) saat pertama kali membuat database vektor, harap bersabar menunggu
- **Lingkungan Python**: Agen AI akan otomatis membuat lingkungan virtual dan menginstal dependensi yang diperlukan
- **Penyimpanan data**: Semua data (catatan, profil, database vektor) disimpan di direktori root proyek, bukan di dalam direktori paket skill
- **Lokasi skill**: Pastikan paket skill berada di direktori `.claude/skills/ai-partner-chat/`

## Informasi Lebih Lanjut

Dokumentasi teknis dan petunjuk penggunaan lebih lengkap dapat dilihat pada file `SKILL.md`.

---

Biarkan AI menjadi mitra percakapan yang benar-benar memahami Anda, bukan sekadar alat.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---