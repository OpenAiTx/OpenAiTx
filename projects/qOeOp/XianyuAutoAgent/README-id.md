<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Sistem Robot Layanan Pelanggan Cerdas untuk Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Solusi AI penjaga otomatis khusus untuk platform Xianyu, memungkinkan penjagaan otomatis 7×24 jam di platform Xianyu, mendukung kolaborasi multi-ahli dalam pengambilan keputusan, negosiasi harga cerdas, dan percakapan kontekstual.

## 🎮 Playground - Uji Coba Cepat (Tanpa Konfigurasi)

Tanpa perlu lingkungan lokal atau mengatur Secrets! **Langsung kirim parameter lewat halaman web GitHub Actions**, mulai robot Xianyu dengan sekali klik.

### Cara Menggunakan
1. **Fork repositori ini** → Klik tombol `Fork` di kanan atas
2. **Jalankan Action**:
   - Masuk ke tab `Actions` di repositorimu
   - Pilih alur kerja **`🚀 Run Service`**
   - Klik tombol **`Run workflow`**, lalu isi parameter:
      - `API Key`: Tempelkan API Key model AI-mu (misal Aliyun DashScope)
      - `Cookies`: Tempelkan string Cookie lengkap dari web Xianyu
3. **Lihat Log Proses**:
   - Setelah robot berjalan, akan otomatis memantau pesan Xianyu
   - Cari `🤖 Reply:` di log Action untuk melihat riwayat percakapan

### Catatan Penting
⚠️ Perhatikan batasan eksekusi sementara:
- Default berjalan **30 menit** (batasan akun gratis GitHub)
- Informasi sensitif (seperti Cookie) **tidak akan disimpan**, hanya berlaku untuk sesi itu saja

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Fitur Utama

### Mesin Percakapan Cerdas
| Modul Fitur    | Implementasi Teknologi      | Fitur Kunci                                               |
| -------------- | -------------------------- | --------------------------------------------------------- |
| Konteks Dialog | Penyimpanan riwayat percakapan | Manajemen memori percakapan ringan, seluruh riwayat dikirim sebagai konteks ke LLM      |
| Routing Ahli   | LLM prompt + aturan routing | Identifikasi intent berbasis prompt → Distribusi dinamis ke Agent Ahli, mendukung skenario negosiasi/harga/layanan pelanggan |

### Matriks Fitur Bisnis
| Modul      | Sudah Tersedia                      | Dalam Rencana                 |
| ---------- | ----------------------------------- | ----------------------------- |
| Mesin Inti | ✅ Balasan otomatis LLM<br>✅ Manajemen konteks | 🔄 Penguatan analisis sentimen     |
| Sistem Nego | ✅ Strategi penurunan harga bertingkat      | 🔄 Fitur pembanding harga pasar    |
| Dukungan Teknis | ✅ Integrasi pencarian online           | 🔄 Penguatan basis pengetahuan RAG |

## 🚴 Mulai Cepat

### Persyaratan Lingkungan
- JDK 21+
- Maven 3.9.10+

### Langkah Instalasi

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Berkontribusi

Silakan ajukan saran melalui Issue atau kontribusi kode melalui PR, harap ikuti [Panduan Kontribusi](https://contributing.md/)



## 🛡 Catatan Penting

⚠️ Perhatian: **Proyek ini hanya untuk pembelajaran dan pertukaran, jika ada pelanggaran hak cipta silakan hubungi penulis untuk dihapus.**

Mengingat kekhususan proyek ini, tim pengembang dapat sewaktu-waktu **menghentikan pembaruan** atau **menghapus proyek**.


## 🧸 Ucapan Terima Kasih Khusus

Proyek ini dibangun ulang berdasarkan proyek open source berikut:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Sistem chatbot layanan pelanggan Xianyu cerdas, dikembangkan oleh [@shaxiu](https://github.com/shaxiu) dan [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---