<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

![Proces pisania AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Pełne wyjaśnienie znajdziesz [tutaj](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Przykładową historię zgłoszoną do konkursu pisarskiego znajdziesz [tutaj](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Nowoczesny, ewolucyjny system pisania, który wykorzystuje modele AI do generowania, oceniania i rozwijania kreatywnych opowiadań lub ogólnych tekstów poprzez iteracyjne konkursy. Zbudowany z użyciem czystej, modułowej architektury Pythona zgodnie z nowoczesnymi zasadami projektowania.




## ✨ Funkcje

- 🧬 **Algorytm ewolucyjny**: Opowiadania ewoluują poprzez turnieje zasilane przez AI
- 🎯 **Dwa tryby pisania**: Kreatywne opowiadania i optymalizacja tekstów ogólnych
- 🏆 **System turniejowy ELO**: Zaawansowane rankingi poprzez porównania parami
- 🌐 **Interfejs webowy**: Narzędzia do walidacji i porównywania opowiadań przez ludzi
- 🔧 **Konfigurowalny**: Szerokie możliwości personalizacji poprzez konfigurację JSON

## 🚀 Szybki start

### Instalacja


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
### Uruchom ewolucję


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
## 🏗️ Architektura

System opiera się na nowoczesnych zasadach projektowania w Pythonie, z wyraźnym podziałem odpowiedzialności:


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
### Kluczowe komponenty

- **`EvolutionPipeline`**: Główny orkiestrator zarządzający całym cyklem ewolucji
- **`InitialStoryGenerator`**: Tworzy pierwszą generację opowiadań na podstawie podpowiedzi
- **`NextBatchGenerator`**: Ewoluuje najlepsze opowiadania w ulepszone warianty
- **`TournamentRunner`**: Zarządza turniejami ELO do rankingu opowiadań
- **`EloRankingSystem`**: Wdraża zaawansowany algorytm rankingowy

## 📖 Jak to działa

System podąża za trzyetapowym cyklem ewolucji:

### 1. **Generowanie początkowej partii**
- Tworzy wiele opowiadań na podstawie Twojej podpowiedzi
- Używa konfigurowalnych modeli AI (GPT, Claude, Llama itp.)
- Przypisuje początkowe oceny ELO

### 2. **Przeprowadź turniej ELO**
- Opowiadania rywalizują w parach
- Sędziowie AI oceniają według Twojej rubryki
- Oceny ELO aktualizowane na podstawie wygranych/przegranych

### 3. **Generowanie kolejnej partii**
- Wybierane są najlepiej ocenione opowiadania
- Generowane są warianty z ulepszeniami
- Proces powtarzany przez wiele generacji

Ten iteracyjny proces z czasem ewoluuje do coraz lepszych tekstów.

## ⚙️ Konfiguracja

### Podstawowa konfiguracja

Edytuj te kluczowe pliki:

- **`prompt.txt`** - Twoja podpowiedź/temat pisarski
- **`rubric.txt`** - Kryteria oceny
- **`config.json`** - Konfiguracja systemu

### Konfiguracja kluczy API

System obsługuje wielu dostawców AI konfigurowanych przez `config.json`. Konfiguracja mapuje modele na dostawców i określa, które zmienne środowiskowe zawierają klucze API:


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
Następnie ustaw swoje klucze API jako zmienne środowiskowe:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Musisz ustawić klucze tylko dla tych dostawców, których planujesz używać. System automatycznie kieruje żądania modelu do odpowiedniego dostawcy na podstawie konfiguracji.

### Opcje konfiguracji

Plik `config.json` kontroluje całe zachowanie systemu:


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
## 🎭 Tryby Pisania

### Tryb Pisania Kreatywnego (Domyślny)
- Skupia się na opowiadaniu historii, rozwoju postaci i technikach narracyjnych
- Wykorzystuje strategie generowania oparte na misjach
- Optymalizuje kreatywność i zaangażowanie

### Tryb Pisania Ogólnego (`--general`)
- Skupia się na pracach naukowych, esejach, raportach i piśmiennictwie zawodowym
- Wykorzystuje analityczne i uporządkowane podejścia
- Optymalizuje jasność i przekonującość

## 🔧 Zaawansowana Konfiguracja

### Dostosowywanie Strategii Generowania

Dla zaawansowanych użytkowników dostępna jest możliwość dostosowania promptów generowania, stylów autorów oraz zestawów misji poprzez edycję plików w katalogu `src/generators/`:

#### Dostosowywanie Pisania Kreatywnego (`src/generators/generate_response.py`)

**Zestawy Misji** - Definiują kreatywne podejścia i cele:

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
**Style autorów** – Naśladuj różne podejścia do pisania:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Ogólna personalizacja pisania (`src/generators/generate_response_general.py`)

**Obszary specjalizacji akademickiej** – Skieruj się na określone dziedziny pisania:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Podejścia do pisania** - Zdefiniuj strategie analityczne:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Dostosowywanie kryteriów oceniania (`src/generators/judge_response.py`)

Możesz zmodyfikować kryteria oceniania oraz polecenia ewaluacyjne, aby skupić się na określonych aspektach jakości pisania:


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
### Wskazówki dotyczące zaawansowanej konfiguracji

1. **Kopia zapasowa oryginalnych plików**: Zawsze zachowuj kopie oryginalnych plików generatora przed wprowadzeniem zmian
2. **Testuj stopniowo**: Wprowadzaj niewielkie zmiany i testuj na kilku iteracjach przed uruchomieniem pełnych cykli ewolucji
3. **Monitoruj wyniki**: Użyj interfejsu webowego, aby sprawdzić, czy Twoje modyfikacje poprawiają jakość opowieści
4. **Łącz i mieszaj**: Kombinuj różne zestawy misji i style autorów, aby uzyskać unikalne strategie generowania
5. **Kontrola wersji**: Śledź swoje modyfikacje za pomocą gita, aby móc je cofnąć w razie potrzeby

To modułowe podejście pozwala precyzyjnie dostosować proces ewolucji do Twoich konkretnych celów pisarskich i dziedzin.

## 🌐 Interfejs webowy

Sprawdź wyniki ewolucji za pomocą wbudowanego interfejsu webowego:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Otwórz http://localhost:5000, aby uzyskać dostęp do:

- **Porównanie opowiadań**: Czytanie obok siebie i wybór preferencji
- **Rankingi ELO**: Przeglądaj aktualne pozycje i statystyki
- **Śledzenie ewolucji**: Sprawdź, czy kolejne generacje się poprawiają
- **Eksport danych**: Pobierz wyniki do analizy


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---