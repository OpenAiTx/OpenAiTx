<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# AlphaEvolve Yazım

![AlphaEvolve Yazma Süreci](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Tam açıklamayı [burada](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html) bulabilirsiniz

Bir yazma yarışmasına gönderilen örnek hikayeyi [burada](https://blog.reedsy.com/short-story/wo9iuy/#comments) bulabilirsiniz

Yapay zeka modellerinin yaratıcı hikayeler veya genel yazı parçalarını yinelemeli yarışmalar yoluyla üretip, değerlendirip geliştirdiği modern, evrimsel bir yazım sistemi. Temiz ve modüler Python mimarisiyle, modern tasarım ilkelerine uygun şekilde geliştirilmiştir.




## ✨ Özellikler

- 🧬 **Evrimsel Algoritma**: Hikayeler, yapay zeka destekli turnuvalarla evrimleşir
- 🎯 **Çift Yazım Modu**: Yaratıcı hikaye anlatımı ve genel yazı optimizasyonu
- 🏆 **ELO Turnuva Sistemi**: Eşli karşılaştırmalarla gelişmiş sıralama
- 🌐 **Web Arayüzü**: İnsan doğrulaması ve hikaye karşılaştırma araçları
- 🔧 **Yapılandırılabilir**: JSON yapılandırmasıyla kapsamlı özelleştirme

## 🚀 Hızlı Başlangıç

### Kurulum


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
### Evrimi Çalıştır


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
## 🏗️ Mimari

Sistem, sorumlulukların temiz bir şekilde ayrıldığı modern Python tasarım prensiplerini takip eder:


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
### Ana Bileşenler

- **`EvolutionPipeline`**: Tüm evrim döngüsünü yöneten ana düzenleyici
- **`InitialStoryGenerator`**: İstemlerden ilk hikaye neslini oluşturur
- **`NextBatchGenerator`**: En iyi performans gösterenleri geliştirilmiş varyantlara evrimleştirir
- **`TournamentRunner`**: Hikaye sıralaması için ELO turnuvalarını yönetir
- **`EloRankingSystem`**: Gelişmiş sıralama algoritmasını uygular

## 📖 Nasıl Çalışır

Sistem üç aşamalı bir evrim döngüsünü takip eder:

### 1. **İlk Parti Oluşturma**
- İsteminizden birden fazla hikaye oluşturur
- Yapılandırılabilir yapay zeka modelleri kullanır (GPT, Claude, Llama, vb.)
- Başlangıç ELO puanları atar

### 2. **ELO Turnuvası Çalıştırma**
- Hikayeler ikili karşılaştırmalarda yarışır
- Yapay zeka jüri üyeleri, değerlendirme kriterlerinize göre puanlar
- ELO puanları kazanma/kaybetmelere göre güncellenir

### 3. **Sonraki Parti Oluşturma**
- En iyi performans gösteren hikayeler seçilir
- Geliştirilmiş varyantlar oluşturulur
- İşlem birden çok nesil boyunca tekrar eder

Bu yinelemeli süreç, zamanla giderek daha iyi yazılar ortaya çıkarır.

## ⚙️ Yapılandırma

### Temel Kurulum

Şu önemli dosyaları düzenleyin:

- **`prompt.txt`** - Yazma isteminiz/temanız
- **`rubric.txt`** - Değerlendirme için hakem kriterleri
- **`config.json`** - Sistem yapılandırması

### API Anahtarları Kurulumu

Sistem, `config.json` üzerinden yapılandırılan birden fazla yapay zeka sağlayıcısını destekler. Yapılandırma, modelleri sağlayıcılara eşler ve API anahtarlarını içeren ortam değişkenlerini belirtir:


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
Ardından API anahtarlarınızı ortam değişkenleri olarak ayarlayın:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Yalnızca kullanmayı planladığınız sağlayıcılar için anahtarlar ayarlamanız gerekir. Sistem, yapılandırmaya göre model isteklerini otomatik olarak doğru sağlayıcıya yönlendirir.

### Yapılandırma Seçenekleri

`config.json` dosyası tüm sistem davranışını kontrol eder:


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
## 🎭 Yazım Modları

### Yaratıcı Yazım Modu (Varsayılan)
- Hikaye anlatımı, karakter geliştirme ve anlatı tekniklerine odaklanır
- Göreve dayalı üretim stratejileri kullanır
- Yaratıcılık ve ilgi çekicilik için optimize edilmiştir

### Genel Yazım Modu (`--general`)
- Akademik makaleler, denemeler, raporlar ve profesyonel yazılar üzerine odaklanır
- Analitik ve yapılandırılmış yaklaşımlar kullanır
- Açıklık ve ikna edicilik için optimize edilmiştir

## 🔧 Gelişmiş Yapılandırma

### Üretim Stratejilerini Özelleştirme

İleri düzey kullanıcılar, `src/generators/` dizinindeki dosyaları düzenleyerek üretim istemlerini, yazar stillerini ve görev setlerini özelleştirebilirler:

#### Yaratıcı Yazım Özelleştirme (`src/generators/generate_response.py`)

**Görev Setleri** - Yaratıcı yaklaşımlar ve hedefler tanımlayın:

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
**Yazar Tarzları** - Farklı yazı yaklaşımlarını taklit edin:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Genel Yazma Özelleştirmesi (`src/generators/generate_response_general.py`)

**Akademik Odak Alanları** - Belirli yazı alanlarını hedefleyin:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Yazım Yaklaşımları** - Analitik stratejileri tanımlayın:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Hakem Kriterlerini Özelleştirme (`src/generators/judge_response.py`)

Değerlendirme kriterlerini ve değerlendirme istemlerini, yazı kalitesinin belirli yönlerine odaklanacak şekilde değiştirebilirsiniz:


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
### Gelişmiş Yapılandırma için İpuçları

1. **Orijinal Dosyaların Yedeğini Alın**: Değişiklik yapmadan önce her zaman jeneratör dosyalarının bir kopyasını saklayın
2. **Artımlı Test Edin**: Tam evrim döngülerini çalıştırmadan önce küçük değişiklikler yapın ve birkaç yineleme ile test edin
3. **Sonuçları İzleyin**: Özelleştirmelerinizin hikaye kalitesini artırıp artırmadığını doğrulamak için web arayüzünü kullanın
4. **Karıştır ve Eşleştir**: Farklı görev setleri ve yazar stillerini benzersiz üretim stratejileri için birleştirin
5. **Sürüm Kontrolü**: Gerekirse geri almak için özelleştirmelerinizi git ile takip edin

Bu modüler yaklaşım, evrim sürecini belirli yazma hedefleriniz ve alanlarınız için hassas şekilde ayarlamanıza olanak tanır.

## 🌐 Web Arayüzü

Evrim sonuçlarınızı yerleşik web arayüzüyle doğrulayın:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
http://localhost:5000 adresini açarak erişebilirsiniz:

- **Hikaye Karşılaştırma**: Yan yana okuma ve tercih seçimi
- **ELO Sıralamaları**: Mevcut sıralamaları ve istatistikleri görüntüle
- **Evrim Takibi**: Sonraki nesillerin gelişip gelişmediğini doğrula
- **Veri Dışa Aktarma**: Analiz için sonuçları indir


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---