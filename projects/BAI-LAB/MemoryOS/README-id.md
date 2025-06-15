# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Jika Anda menyukai proyek kami, silakan beri bintang ⭐ di GitHub untuk pembaruan terbaru.</h5>
**MemoryOS** dirancang untuk menyediakan sistem operasi memori bagi agen AI personal, memungkinkan interaksi yang lebih koheren, personal, dan sadar konteks. Terinspirasi dari prinsip manajemen memori pada sistem operasi, MemoryOS mengadopsi arsitektur penyimpanan hierarkis dengan empat modul inti: Storage, Updating, Retrieval, dan Generation, untuk mencapai manajemen memori yang komprehensif dan efisien. Pada tolok ukur LoCoMo, model ini mencapai rata-rata peningkatan **49.11%** dan **46.18%** pada skor F1 dan BLEU-1.







## 📣 Berita Terbaru
*   *<mark>[baru]</mark>* 🔥  **[2025-06-15]**:🛠️ **MemoryOS-MCP** open source telah dirilis! Kini dapat dikonfigurasi pada klien agen untuk integrasi dan kustomisasi yang mulus. [👉 Lihat](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Versi awal **MemoryOS** diluncurkan! Menyediakan memori persona jangka pendek, menengah, dan panjang dengan pembaruan profil pengguna serta pengetahuan yang otomatis.

## Demo
[![Tonton videonya](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Arsitektur Sistem
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Struktur Proyek

```
memoryos/
├── __init__.py            # Inisialisasi paket MemoryOS
├── __pycache__/           # Direktori cache Python (otomatis dibuat)
├── long_term.py           # Mengelola memori persona jangka panjang (profil pengguna, pengetahuan)
├── memoryos.py            # Kelas utama untuk MemoryOS, mengoordinasikan semua komponen
├── mid_term.py            # Mengelola memori jangka menengah, mengonsolidasikan interaksi jangka pendek
├── prompts.py             # Berisi prompt untuk interaksi LLM (misal, ringkasan, analisis)
├── retriever.py           # Mengambil informasi relevan dari seluruh lapisan memori
├── short_term.py          # Mengelola memori jangka pendek untuk interaksi terbaru
├── updater.py             # Memproses pembaruan memori, termasuk promosi informasi antar lapisan
└── utils.py               # Fungsi utilitas yang digunakan di seluruh pustaka
```

## Cara Kerja

1.  **Inisialisasi:** `Memoryos` diinisialisasi dengan ID pengguna dan asisten, API key, path penyimpanan data, serta berbagai pengaturan kapasitas/ambang batas. Sistem akan menyiapkan penyimpanan khusus untuk setiap pengguna dan asisten.
2.  **Menambah Memori:** Input pengguna dan respons agen ditambahkan sebagai pasangan QA. Awalnya, ini disimpan dalam memori jangka pendek.
3.  **Proses Jangka Pendek ke Jangka Menengah:** Ketika memori jangka pendek penuh, modul `Updater` akan memproses interaksi tersebut, mengonsolidasikannya menjadi segmen bermakna dan menyimpannya dalam memori jangka menengah.
4.  **Analisis Jangka Menengah & Pembaruan LPM:** Segmen memori jangka menengah mengumpulkan "heat" berdasarkan faktor seperti frekuensi kunjungan dan durasi interaksi. Ketika heat segmen melebihi ambang batas, kontennya dianalisis:
    *   Insight profil pengguna diekstrak dan digunakan untuk memperbarui profil pengguna jangka panjang.
    *   Fakta spesifik pengguna ditambahkan ke pengetahuan jangka panjang pengguna.
    *   Informasi relevan untuk asisten ditambahkan ke basis pengetahuan jangka panjang asisten.
5.  **Generasi Respons:** Saat kueri pengguna diterima:
    *   Modul `Retriever` mengambil konteks relevan dari riwayat jangka pendek, segmen memori jangka menengah, profil & pengetahuan pengguna, dan basis pengetahuan asisten.
    *   Konteks komprehensif ini, bersama dengan kueri pengguna, digunakan untuk menghasilkan respons yang koheren dan informatif melalui LLM.

## MemoryOS_PYPI Mulai Cepat

### Prasyarat

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Instalasi

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Penggunaan Dasar

```python

import os
from memoryos import Memoryos

# --- Konfigurasi Dasar ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Ganti dengan API key Anda
BASE_URL = ""  # Opsional: jika menggunakan endpoint OpenAI kustom
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simple Demo")
    
    # 1. Inisialisasi MemoryOS
    print("Menginisialisasi MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS berhasil diinisialisasi!\n")
    except Exception as e:
        print(f"Error: {e}")
        return

    # 2. Tambahkan beberapa memori dasar
    print("Menambahkan beberapa memori...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"User: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Mulai Cepat
### 🔧 Alat Inti

#### 1. `add_memory`
Menyimpan isi percakapan antara pengguna dan asisten AI ke dalam sistem memori, untuk membangun riwayat dialog yang persisten dan catatan konteks.

#### 2. `retrieve_memory`
Mengambil dialog historis terkait, preferensi pengguna, dan informasi pengetahuan dari sistem memori berdasarkan query, membantu asisten AI memahami kebutuhan dan latar belakang pengguna.

#### 3. `get_user_profile`
Mengambil profil pengguna yang dihasilkan dari analisis dialog historis, termasuk sifat kepribadian pengguna, preferensi minat, dan latar belakang pengetahuan yang relevan.


### 1. Instalasi dependensi
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Konfigurasi

Edit `config.json`：
```json
{
  "user_id": "ID Pengguna Anda",
  "openai_api_key": "API Key OpenAI Anda",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Mulai server
```bash
python server_new.py --config config.json
```
### 4. Tes
```bash
python test_comprehensive.py
```
### 5. Konfigurasi di Cline dan klien lainnya
Salin file mcp.json, dan pastikan path file sudah benar.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Ubah ke interpreter Python di virtual environment Anda
```
## Kontribusi

Kontribusi sangat dipersilakan! Silakan ajukan issue atau pull request.

## Sitasi
Jika Anda ingin membaca detail lebih lanjut, silakan klik di sini: [Baca Makalah Lengkap](https://arxiv.org/abs/2506.06326)

Jika proyek ini bermanfaat, mohon sitasi makalah kami:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Hubungi Kami
BAI AI adalah kelompok riset yang dipandu oleh Associate Professor Bai Ting dari Universitas Pos dan Telekomunikasi Beijing, berkomitmen untuk menciptakan otak yang penuh emosi dan memori luar biasa bagi manusia berbasis silikon.<br>
Kerja sama dan saran: baiting@bupt.edu.cn<br>
Silakan ikuti akun resmi BAI Agent di WeChat dan grup WeChat kami untuk berdiskusi bersama!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="Akun Resmi BAI Agent" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="Kode QR Grup WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---