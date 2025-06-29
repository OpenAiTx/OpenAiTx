![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Ubah repositori GitHub apa pun menjadi Docker container siap produksi dengan pembuatan Dockerfile bertenaga AI.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer adalah aplikasi web bertenaga AI yang secara otomatis menghasilkan Dockerfile siap produksi dengan menganalisis repositori GitHub. Cukup tempel URL GitHub dan dapatkan Dockerfile yang disesuaikan dengan pemilihan base image yang cerdas, manajemen dependensi, dan praktik terbaik Docker.

## 🌟 Akses Cepat

Cukup ganti `github.com` dengan `gitcontainer.com` pada URL repositori GitHub apa pun untuk langsung mengakses halaman pembuatan Dockerfile untuk repositori tersebut.

Contoh:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Fitur

- **🔄 Akses URL Instan**: Cukup ganti 'github.com' dengan 'gitcontainer.com' di URL GitHub apa pun
- **🤖 Analisis Berbasis AI**: Menggunakan OpenAI GPT-4 untuk menganalisis struktur repositori dan membuat Dockerfile cerdas
- **⚡ Streaming Real-time**: Saksikan AI membuat Dockerfile Anda secara real-time dengan streaming WebSocket
- **🎯 Deteksi Cerdas**: Secara otomatis mendeteksi stack teknologi (Python, Node.js, Java, Go, dll.)
- **🔧 Siap Produksi**: Menghasilkan Dockerfile mengikuti praktik terbaik dengan keamanan, multi-stage build, dan optimasi yang tepat
- **📋 Instruksi Tambahan**: Tambahkan kebutuhan khusus untuk lingkungan yang spesifik
- **📄 Docker Compose**: Secara otomatis menyarankan docker-compose.yml untuk aplikasi kompleks
- **🎨 UI Modern**: Antarmuka bersih dan responsif dengan editor Monaco untuk penyorotan sintaks
- **📱 Ramah Mobile**: Bekerja mulus di perangkat desktop dan seluler

## 🚀 Mulai Cepat

### Prasyarat

- Python 3.9 atau lebih tinggi
- Git
- Kunci API OpenAI

### Instalasi

1. **Clone repositori:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Instal dependensi:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Siapkan variabel lingkungan:**
   ```bash
   # Buat file .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Jalankan aplikasi:**
   ```bash
   python app.py
   ```

5. **Buka browser Anda:**
   Akses `http://localhost:8000`

## 🛠️ Cara Kerja

1. **Pemrosesan URL**: Akses repositori apa pun dengan mengganti 'github.com' dengan 'gitcontainer.com' di URL
2. **Kloning Repositori**: Gitcontainer mengkloning repositori GitHub secara lokal menggunakan Git
3. **Analisis Kode**: Menggunakan [gitingest](https://github.com/cyclotruc/gitingest) untuk menganalisis struktur repositori dan mengekstrak informasi relevan
4. **Pembuatan AI**: Mengirimkan hasil analisis ke OpenAI GPT-4 dengan prompt khusus untuk pembuatan Dockerfile
5. **Optimasi Cerdas**: AI mempertimbangkan:
   - Deteksi stack teknologi
   - Manajemen dependensi
   - Praktik terbaik keamanan
   - Multi-stage build jika menguntungkan
   - Konfigurasi port
   - Variabel lingkungan
   - Health check

## 📁 Struktur Proyek

```
cyclotruc-gitcontainer/
├── app.py                 # Aplikasi utama FastAPI
├── requirements.txt       # Dependensi Python
├── .env                  # Variabel lingkungan (buat file ini)
├── static/               # Aset statis (ikon, CSS)
├── templates/
│   └── index.jinja       # Template HTML utama
└── tools/                # Modul fungsi inti
    ├── __init__.py
    ├── create_container.py  # Pembuatan Dockerfile berbasis AI
    ├── git_operations.py    # Kloning repositori GitHub
    └── gitingest.py        # Analisis repositori
```
## 🔧 Konfigurasi

### Variabel Lingkungan

| Variabel | Deskripsi | Wajib |
|----------|-----------|-------|
| `OPENAI_API_KEY` | Kunci API OpenAI Anda | Ya |
| `PORT` | Port server (default: 8000) | Tidak |
| `HOST` | Host server (default: 0.0.0.0) | Tidak |

### Penggunaan Lanjutan

Anda dapat menggunakan tools ini secara terprogram:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Clone repository
    clone_result = await clone_repo_tool(github_url)
    
    # Analisis dengan gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Generate Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Penggunaan
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Kustomisasi

### Menambahkan Instruksi Kustom

Gunakan fitur "Instruksi tambahan" untuk menyesuaikan proses generasi:

- `"Gunakan Alpine Linux untuk ukuran image yang lebih kecil"`
- `"Sertakan Redis dan PostgreSQL"`
- `"Optimalkan untuk deployment produksi"`
- `"Tambahkan alat pengembangan untuk debugging"`

## 📝 Lisensi

Proyek ini dilisensikan di bawah MIT License - lihat file [LICENSE](LICENSE) untuk detailnya.

## 🙏 Ucapan Terima Kasih

- **[OpenAI](https://openai.com/)** atas penyediaan GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** atas kemampuan analisis repositori
- **[FastAPI](https://fastapi.tiangolo.com/)** atas framework web yang luar biasa
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** untuk penyorotan sintaks kode

## 🔗 Tautan

- **Repositori GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Coba langsung dengan repositori contoh
- **Isu**: [Laporkan bug atau minta fitur](https://github.com/cyclotruc/gitcontainer/issues)

---

**Dibuat dengan ❤️ oleh [Romain Courtois](https://github.com/cyclotruc)**

*Ubah repositori apa pun menjadi container dalam hitungan detik!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---