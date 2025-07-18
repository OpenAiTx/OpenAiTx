<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve Writing

![Proses Penulisan AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Penjelasan lengkap dapat ditemukan [di sini](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Contoh cerita yang dikirimkan ke lomba penulisan dapat dilihat [di sini](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Sistem penulisan modern dan evolusioner yang menggunakan model AI untuk menghasilkan, mengevaluasi, dan mengembangkan cerita kreatif atau karya tulis umum melalui kompetisi iteratif. Dibangun dengan arsitektur Python yang bersih dan modular mengikuti prinsip desain modern.




## ✨ Fitur

- 🧬 **Algoritma Evolusioner**: Cerita berkembang melalui turnamen berbasis AI
- 🎯 **Dua Mode Penulisan**: Penceritaan kreatif dan optimasi penulisan umum
- 🏆 **Sistem Turnamen ELO**: Peringkat canggih melalui perbandingan berpasangan
- 🌐 **Antarmuka Web**: Alat validasi manusia dan perbandingan cerita
- 🔧 **Dapat Dikustomisasi**: Kustomisasi luas melalui konfigurasi JSON

## 🚀 Mulai Cepat

### Instalasi


```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### Jalankan Evolusi


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ Arsitektur

Sistem mengikuti prinsip desain Python modern dengan pemisahan tanggung jawab yang jelas:


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### Komponen Utama

- **`EvolutionPipeline`**: Orkestrator utama yang mengelola seluruh siklus evolusi
- **`InitialStoryGenerator`**: Membuat generasi pertama cerita dari prompt
- **`NextBatchGenerator`**: Mengembangkan cerita terbaik menjadi varian yang lebih baik
- **`TournamentRunner`**: Mengelola turnamen ELO untuk pemeringkatan cerita
- **`EloRankingSystem`**: Menerapkan algoritma pemeringkatan canggih

## 📖 Cara Kerjanya

Sistem mengikuti siklus evolusi tiga tahap:

### 1. **Membuat Batch Awal**
- Membuat beberapa cerita dari prompt Anda
- Menggunakan model AI yang dapat dikonfigurasi (GPT, Claude, Llama, dll.)
- Memberikan rating ELO awal

### 2. **Menjalankan Turnamen ELO**
- Cerita bersaing dalam perbandingan berpasangan
- AI menjadi juri berdasarkan rubrik Anda
- Nilai ELO diperbarui berdasarkan menang/kalah

### 3. **Membuat Batch Berikutnya**
- Cerita dengan performa terbaik dipilih
- Varian dibuat dengan perbaikan
- Proses diulang untuk beberapa generasi

Proses iteratif ini mengembangkan tulisan yang semakin baik dari waktu ke waktu.

## ⚙️ Konfigurasi

### Pengaturan Dasar

Edit file-file kunci berikut:

- **`prompt.txt`** - Prompt/tema penulisan Anda
- **`rubric.txt`** - Kriteria penilaian untuk evaluasi
- **`config.json`** - Konfigurasi sistem

### Pengaturan API Keys

Sistem mendukung beberapa penyedia AI yang dikonfigurasi melalui `config.json`. Konfigurasi menghubungkan model ke penyedia dan menentukan variabel lingkungan mana yang berisi API key:


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
Kemudian atur kunci API Anda sebagai variabel lingkungan:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Anda hanya perlu mengatur kunci untuk penyedia yang ingin Anda gunakan. Sistem secara otomatis mengarahkan permintaan model ke penyedia yang benar berdasarkan konfigurasi.

### Opsi Konfigurasi

File `config.json` mengendalikan semua perilaku sistem:


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 Mode Penulisan

### Mode Penulisan Kreatif (Default)
- Berfokus pada penceritaan, pengembangan karakter, dan teknik naratif
- Menggunakan strategi generasi berbasis misi
- Dioptimalkan untuk kreativitas dan keterlibatan

### Mode Penulisan Umum (`--general`)
- Berfokus pada makalah akademik, esai, laporan, dan penulisan profesional
- Menggunakan pendekatan analitis dan terstruktur
- Dioptimalkan untuk kejelasan dan daya persuasif

## 🔧 Konfigurasi Lanjutan

### Kustomisasi Strategi Generasi

Untuk pengguna tingkat lanjut, Anda dapat menyesuaikan prompt generasi, gaya penulis, dan set misi dengan mengedit file di direktori `src/generators/`:

#### Kustomisasi Penulisan Kreatif (`src/generators/generate_response.py`)

**Set Misi** - Mendefinisikan pendekatan dan tujuan kreatif:

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**Gaya Penulis** - Meniru berbagai pendekatan penulisan:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Kustomisasi Penulisan Umum (`src/generators/generate_response_general.py`)

**Fokus Area Akademik** - Menargetkan domain penulisan tertentu:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Pendekatan Penulisan** - Tentukan strategi analitis:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Menyesuaikan Kriteria Penilaian (`src/generators/judge_response.py`)

Anda dapat memodifikasi kriteria penilaian dan prompt evaluasi untuk berfokus pada aspek-aspek tertentu dari kualitas tulisan:


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### Tips untuk Konfigurasi Lanjutan

1. **Cadangkan File Asli**: Selalu simpan salinan file generator asli sebelum melakukan perubahan
2. **Uji Secara Bertahap**: Lakukan perubahan kecil dan uji dengan beberapa iterasi sebelum menjalankan siklus evolusi penuh
3. **Pantau Hasil**: Gunakan antarmuka web untuk memvalidasi bahwa kustomisasi Anda meningkatkan kualitas cerita
4. **Campur dan Padukan**: Gabungkan berbagai set misi dan gaya penulis untuk strategi generasi yang unik
5. **Kontrol Versi**: Lacak kustomisasi Anda dengan git agar dapat dikembalikan jika diperlukan

Pendekatan modular ini memungkinkan Anda menyesuaikan proses evolusi untuk tujuan dan domain penulisan spesifik Anda.

## 🌐 Antarmuka Web

Validasi hasil evolusi Anda dengan antarmuka web bawaan:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Buka http://localhost:5000 untuk mengakses:

- **Perbandingan Cerita**: Membaca berdampingan dan memilih preferensi
- **Peringkat ELO**: Lihat peringkat dan statistik saat ini
- **Pelacakan Evolusi**: Validasi bahwa generasi selanjutnya mengalami peningkatan
- **Ekspor Data**: Unduh hasil untuk analisis


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---