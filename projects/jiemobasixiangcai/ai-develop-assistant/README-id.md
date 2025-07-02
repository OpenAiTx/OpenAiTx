# 🚀 MCP AI Pengembang Asisten

> Alat MCP untuk membantu pengembang AI dalam analisis kebutuhan cerdas dan desain arsitektur

## ✨ Fitur Utama

- **Klarifikasi Kebutuhan Cerdas**: Mengidentifikasi jenis proyek secara otomatis, menghasilkan pertanyaan yang relevan
- **Manajemen Cabang yang Sadar**: Melacak tujuan proyek, desain fungsi, preferensi teknologi, desain UI, dan dimensi lainnya
- **Generasi Arsitektur Otomatis**: Menghasilkan solusi arsitektur teknis berdasarkan kebutuhan yang lengkap
- **Penyimpanan Persisten**: Secara otomatis menyimpan hasil analisis, mendukung ekspor dokumen

## 📁 Konfigurasi Cepat

### Konfigurasi Versi Lama
1. **Kloning kode**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Rekomendasi lingkungan virtual**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Instal dependensi**
   ```bash
   pip install -r requirements.txt
   ```

4. **Lokasi file konfigurasi**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Tambahkan konfigurasi**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Restart Claude Desktop**

### Konfigurasi Versi Baru
#### 🔧 Alat Inti
1. **start_new_project** - Mulai proyek baru
2. **create_requirement_blueprint** - Buat blueprint kebutuhan
3. **requirement_clarifier** - Dapatkan prompt klarifikasi kebutuhan
4. **save_clarification_tasks** - Simpan tugas klarifikasi
5. **update_branch_status** - Perbarui status cabang
6. **requirement_manager** - Pengelola dokumen kebutuhan
7. **check_architecture_prerequisites** - Periksa prasyarat arsitektur
8. **get_architecture_design_prompt** - Dapatkan prompt desain arsitektur
9. **save_generated_architecture** - Simpan desain arsitektur yang dihasilkan
10. **export_final_document** - Ekspor dokumen lengkap
11. **view_requirements_status** - Lihat status kebutuhan

#### Konfigurasi (salin koneksi langsung jarak jauh ke alat Anda, ganti MCP_STORAGE_DIR dengan direktori lokal Anda)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Alur Penggunaan

### Langkah Dasar

1. **Klarifikasi Kebutuhan**
   ```
   requirement_clarifier("Saya ingin membuat sebuah platform pendidikan online")
   ```

2. **Manajemen Kebutuhan**
   ```
   requirement_manager("Pengguna target: siswa dan guru", "Ringkasan proyek")
   ```

3. **Lihat Status**
   ```
   view_requirements_status()
   ```

4. **Desain Arsitektur**
   ```
   architecture_designer("Arsitektur Platform Pendidikan Online")
   ```

5. **Ekspor Dokumen**
   ```
   export_final_document()
   ```

## 🚀 Mulai Menggunakan

### Cepat Mulai
1. **Konfigurasi Claude Desktop** (lihat metode konfigurasi di atas)
2. **Restart Claude Desktop**
3. **Mulai Analisis Kebutuhan Cerdas**:
   ```
   requirement_clarifier("Deskripsikan ide proyek Anda")
   ```
4. **Ikuti Panduan Cerdas AI** untuk menyempurnakan setiap cabang kebutuhan secara bertahap
5. **Ekspor Dokumen Lengkap**:
   ```
   export_final_document()
   ```

### Praktik Terbaik
- 💬 **Percayakan Manajemen Cabang pada AI**: Biarkan AI membimbing Anda menyelesaikan semua cabang kebutuhan
- 🎯 **Ekspresikan Preferensi secara Jelas**: Ungkapkan preferensi Anda secara jelas untuk pemilihan teknologi, gaya UI, dll.
- 📊 **Pantau Status Secara Berkala**: Gunakan `view_requirements_status` untuk memantau progres
- 🤖 **Berikan Wewenang pada AI Secara Tepat**: Untuk bagian yang tidak pasti, Anda bisa mengatakan "gunakan solusi konvensional"

---

**🎯 Sekarang Anda memiliki asisten pengembangan AI yang benar-benar cerdas, yang akan mengingat setiap detail dan membimbing Anda menyelesaikan analisis kebutuhan secara lengkap!**

## 💬 Grup Diskusi

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Grup Diskusi">
<br>
Grup Diskusi
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---