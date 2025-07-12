# Git Smart Squash

Berhenti membuang waktu untuk mengatur ulang commit secara manual. Biarkan AI yang melakukannya untuk Anda.

## Masalah

Anda pasti pernah mengalaminya: 15 commit untuk satu fitur, setengahnya berisi "fix", "typo", atau "WIP". Sekarang Anda perlu membersihkannya untuk review PR. Melakukan squash dan menulis ulang secara manual itu melelahkan.

## Solusi

Git Smart Squash menganalisis perubahan Anda dan mengaturnya kembali menjadi commit yang logis dengan pesan yang tepat:

```bash
# Sebelum: branch Anda yang berantakan
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Setelah: commit yang bersih dan logis
* feat: implementasi sistem otentikasi JWT
* test: tambah cakupan endpoint auth
```

## Mulai Cepat

### 1. Instalasi

```bash
# Menggunakan pip
pip install git-smart-squash

# Menggunakan pipx (disarankan untuk instalasi terisolasi)
pipx install git-smart-squash

# Menggunakan uv (manajer paket Python yang cepat)
uv tool install git-smart-squash
```
### 2. Siapkan AI

**Opsi A: Lokal (Gratis, Privat)**
```bash
# Instal Ollama dari https://ollama.com
ollama pull devstral  # Model default
```

**Opsi B: Cloud (Hasil lebih baik)**
```bash
export OPENAI_API_KEY="kunci-anda"
export ANTHROPIC_API_KEY="kunci-anda"
export GEMINI_API_KEY="kunci-anda"
```

### 3. Jalankan

```bash
cd repo-anda
git-smart-squash
```
Itu saja. Tinjau rencana dan setujui.

## Parameter Baris Perintah

| Parameter | Deskripsi | Default |
|-----------|-----------|---------|
| `--base` | Cabang dasar untuk dibandingkan | File konfigurasi atau `main` |
| `--ai-provider` | Penyedia AI yang digunakan (openai, anthropic, local, gemini) | Dikomfigurasi di pengaturan |
| `--model` | Model AI spesifik yang digunakan (lihat model yang direkomendasikan di bawah) | Default penyedia |
| `--config` | Path ke file konfigurasi kustom | `.git-smart-squash.yml` atau `~/.git-smart-squash.yml` |
| `--auto-apply` | Terapkan rencana commit tanpa konfirmasi | `false` |
| `--instructions`, `-i` | Instruksi kustom untuk AI (misal, "Kelompokkan berdasarkan area fitur") | Tidak ada |
| `--no-attribution` | Nonaktifkan pesan atribusi pada commit | `false` |
| `--debug` | Aktifkan logging debug untuk informasi detail | `false` |

## Model yang Direkomendasikan

### Model Default
- **OpenAI**: `gpt-4.1` (default)
- **Anthropic**: `claude-sonnet-4-20250514` (default)
- **Gemini**: `gemini-2.5-pro` (default)
- **Local/Ollama**: `devstral` (default)

### Pemilihan Model
```bash
# Tentukan model yang berbeda
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Untuk Ollama lokal
git-smart-squash --ai-provider local --model llama-3.1
```

## Instruksi Kustom

Parameter `--instructions` memungkinkan Anda mengontrol bagaimana commit diatur:

### Contoh
```bash
# Tambahkan prefiks tiket
git-smart-squash -i "Prefix semua commit dengan [ABC-1234]"

# Pisahkan berdasarkan tipe
git-smart-squash -i "Pisahkan perubahan backend dan frontend dalam commit terpisah"
```
# Batasi jumlah commit
git-smart-squash -i "Buat maksimal 3 commit secara total"
```

### Tips untuk Hasil yang Lebih Baik
- **Jadilah spesifik**: "Kelompokkan migrasi database secara terpisah" lebih baik daripada "atur dengan rapi"
- **Satu instruksi dalam satu waktu**: Instruksi kompleks dengan banyak bagian mungkin hanya sebagian yang diikuti
- **Gunakan model yang lebih baik**: Model yang lebih besar mengikuti instruksi dengan lebih andal dibandingkan model yang lebih kecil

## Kasus Penggunaan Umum

### "Saya perlu merapikan sebelum review PR"
```bash
git-smart-squash              # Menampilkan rencana dan meminta konfirmasi
git-smart-squash --auto-apply # Menerapkan secara otomatis tanpa konfirmasi
```

### "Saya bekerja dengan branch utama yang berbeda"
```bash
git-smart-squash --base develop
```
### "Saya ingin menggunakan penyedia AI tertentu"
```bash
git-smart-squash --ai-provider openai
```

## Keamanan

**Kode Anda aman:**
- Menampilkan rencana sebelum melakukan perubahan
- Membuat cabang cadangan otomatis
- Memerlukan direktori kerja yang bersih
- Tidak pernah melakukan push tanpa perintah Anda

**Jika terjadi kesalahan:**
```bash
# Temukan cadangan
git branch | grep backup

# Pulihkan
git reset --hard your-branch-backup-[timestamp]
```

## Penyedia AI

| Penyedia | Biaya | Privasi |
|----------|-------|---------|
| **Ollama** | Gratis | Lokal |
| **OpenAI** | ~US$0,01 | Cloud |
| **Anthropic** | ~US$0,01 | Cloud |
| **Gemini** | ~US$0,01 | Cloud |

## Konfigurasi Lanjutan (Opsional)

Ingin menyesuaikan? Buat file konfigurasi:

**Khusus Proyek** (`.git-smart-squash.yml` di repo Anda):
```yaml
ai:
  provider: openai  # Gunakan OpenAI untuk proyek ini
base: develop       # Gunakan develop sebagai branch dasar untuk proyek ini
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Selalu gunakan AI lokal secara default
base: main          # Cabang dasar default untuk semua proyek
```

## Pemecahan Masalah

### Error "Invalid JSON"
Ini biasanya berarti model AI tidak dapat memformat respons dengan benar:
- **Dengan Ollama**: Beralih dari `llama2` ke `mistral` atau `mixtral`
- **Solusi**: `ollama pull mistral` lalu coba lagi
- **Alternatif**: Gunakan penyedia cloud dengan `--ai-provider openai`

### Model Tidak Mengikuti Instruksi
Beberapa model kesulitan dengan instruksi yang kompleks:
- **Gunakan model yang lebih baik**: `--model gpt-4-turbo` atau `--model claude-3-opus`
- **Sederhanakan instruksi**: Satu arahan yang jelas lebih baik daripada banyak
- **Bersikap eksplisit**: "Awali dengan [ABC-123]" bukan "tambahkan nomor tiket"
### "Ollama tidak ditemukan" 
```bash
# Instal dari https://ollama.com
ollama serve
ollama pull devstral  # Model default
```

### Pengelompokan Commit Buruk
Jika AI membuat terlalu banyak commit atau tidak mengelompokkan dengan baik:
- **Model tidak memadai**: Gunakan model yang lebih besar
- **Tambahkan instruksi**: `-i "Kelompokkan perubahan terkait, maksimal 3 commit"`
- **Beri Masukan**: Buat issue di GitHub dan beri tahu kami apa yang terjadi

### Masalah Instalasi (Mac)
Jika Anda tidak memiliki pip atau lebih suka instalasi terisolasi:
```bash
# Menggunakan pipx (direkomendasikan)
brew install pipx
pipx install git-smart-squash
```
### "Tidak ada perubahan untuk direorganisasi"
```bash
git log --oneline main..HEAD  # Periksa apakah Anda memiliki commit
git diff main                 # Periksa apakah Anda memiliki perubahan
```

### Diff Besar / Batasan Token
Model lokal memiliki batas ~32k token. Untuk perubahan besar:
- Gunakan `--base` dengan commit yang lebih baru
- Beralih ke cloud: `--ai-provider openai`
- Bagi menjadi PR yang lebih kecil

### Butuh Bantuan Lebih Lanjut?

Lihat [dokumentasi lengkap](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) atau buka issue!

## Lisensi

Lisensi MIT - lihat file [LICENSE](LICENSE) untuk detailnya.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---