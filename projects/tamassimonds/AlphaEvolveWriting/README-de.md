<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">Englisch</a>
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

# AlphaEvolve Schreiben

![AlphaEvolve Schreibprozess](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Die vollständige Erklärung finden Sie [hier](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Ein Beispiel für eine bei einem Schreibwettbewerb eingereichte Geschichte finden Sie [hier](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Ein modernes, evolutionäres Schreibsystem, das KI-Modelle verwendet, um kreative Geschichten oder allgemeine Texte durch iterative Wettbewerbe zu generieren, zu bewerten und weiterzuentwickeln. Entwickelt mit sauberer, modularer Python-Architektur nach modernen Designprinzipien.




## ✨ Funktionen

- 🧬 **Evolutionärer Algorithmus**: Geschichten entwickeln sich durch KI-gesteuerte Turniere
- 🎯 **Duale Schreibmodi**: Kreatives Geschichtenerzählen und Optimierung allgemeiner Texte
- 🏆 **ELO-Turniersystem**: Anspruchsvolle Bewertung durch paarweise Vergleiche
- 🌐 **Web-Oberfläche**: Menschliche Validierung und Vergleich von Geschichten
- 🔧 **Konfigurierbar**: Umfangreiche Anpassungsmöglichkeiten per JSON-Konfiguration

## 🚀 Schnellstart

### Installation


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
### Evolution ausführen


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
## 🏗️ Architektur

Das System folgt modernen Python-Designprinzipien mit einer klaren Trennung der Verantwortlichkeiten:


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
### Schlüsselkomponenten

- **`EvolutionPipeline`**: Haupt-Orchestrator, der den vollständigen Evolutionszyklus verwaltet
- **`InitialStoryGenerator`**: Erstellt die erste Generation von Geschichten aus Vorgaben
- **`NextBatchGenerator`**: Entwickelt die besten Geschichten zu verbesserten Varianten weiter
- **`TournamentRunner`**: Verwaltet ELO-Turniere zur Geschichtsbewertung
- **`EloRankingSystem`**: Implementiert einen ausgefeilten Bewertungsalgorithmus

## 📖 Funktionsweise

Das System folgt einem dreistufigen Evolutionszyklus:

### 1. **Erste Charge generieren**
- Erstellt mehrere Geschichten aus Ihrem Prompt
- Verwendet konfigurierbare KI-Modelle (GPT, Claude, Llama, etc.)
- Vergibt anfängliche ELO-Bewertungen

### 2. **ELO-Turnier durchführen**
- Geschichten treten in Paarvergleichen gegeneinander an
- KI-Richter bewerten nach Ihrem Bewertungsraster
- ELO-Bewertungen werden basierend auf Siegen/Niederlagen aktualisiert

### 3. **Nächste Charge generieren**
- Bestbewertete Geschichten werden ausgewählt
- Varianten werden mit Verbesserungen generiert
- Prozess wiederholt sich über mehrere Generationen

Dieser iterative Prozess führt im Laufe der Zeit zu immer besseren Texten.

## ⚙️ Konfiguration

### Grundlegende Einrichtung

Bearbeiten Sie diese wichtigen Dateien:

- **`prompt.txt`** – Ihr Schreibprompt/Thema
- **`rubric.txt`** – Bewertungskriterien für die Beurteilung
- **`config.json`** – Systemkonfiguration

### API-Schlüssel einrichten

Das System unterstützt mehrere KI-Anbieter, die über `config.json` konfiguriert werden. Die Konfiguration ordnet Modelle Anbietern zu und legt fest, welche Umgebungsvariablen die API-Schlüssel enthalten:


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
Legen Sie dann Ihre API-Schlüssel als Umgebungsvariablen fest:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Sie müssen nur Schlüssel für die Anbieter festlegen, die Sie verwenden möchten. Das System leitet Modellanfragen automatisch basierend auf der Konfiguration an den richtigen Anbieter weiter.

### Konfigurationsoptionen

Die Datei `config.json` steuert das gesamte Systemverhalten:


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
## 🎭 Schreibmodi

### Kreativer Schreibmodus (Standard)
- Konzentriert sich auf Storytelling, Charakterentwicklung und Erzähltechniken
- Verwendet missionsbasierte Generierungsstrategien
- Optimiert für Kreativität und Engagement

### Allgemeiner Schreibmodus (`--general`)
- Konzentriert sich auf akademische Arbeiten, Essays, Berichte und professionelles Schreiben
- Verwendet analytische und strukturierte Ansätze
- Optimiert für Klarheit und Überzeugungskraft

## 🔧 Erweiterte Konfiguration

### Anpassung von Generierungsstrategien

Für fortgeschrittene Nutzer können Sie die Generierungsaufforderungen, Autorenstile und Missionssets anpassen, indem Sie die Dateien im Verzeichnis `src/generators/` bearbeiten:

#### Kreative Schreibanpassung (`src/generators/generate_response.py`)

**Missionssets** - Definieren kreative Ansätze und Ziele:

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
**Autorenstile** – Verschiedene Schreibansätze nachahmen:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Allgemeine Schreibanpassung (`src/generators/generate_response_general.py`)

**Akademische Schwerpunktbereiche** – Bestimmte Schreibdomänen anvisieren:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Schreibansätze** – Analytische Strategien definieren:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Anpassen der Bewertungskriterien (`src/generators/judge_response.py`)

Sie können die Bewertungskriterien und Evaluierungsaufforderungen anpassen, um sich auf bestimmte Aspekte der Schreibqualität zu konzentrieren:


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
### Tipps für die erweiterte Konfiguration

1. **Originaldateien sichern**: Bewahren Sie immer Kopien der Original-Generator-Dateien auf, bevor Sie Änderungen vornehmen
2. **Schrittweise testen**: Nehmen Sie kleine Änderungen vor und testen Sie mit einigen Durchläufen, bevor Sie vollständige Evolutionszyklen starten
3. **Ergebnisse überwachen**: Verwenden Sie die Weboberfläche, um zu überprüfen, ob Ihre Anpassungen die Qualität der Geschichten verbessern
4. **Kombinieren und variieren**: Kombinieren Sie verschiedene Missionssets und Autorenstile für einzigartige Generierungsstrategien
5. **Versionskontrolle**: Verfolgen Sie Ihre Anpassungen mit git, um bei Bedarf Änderungen rückgängig zu machen

Dieser modulare Ansatz ermöglicht es Ihnen, den Evolutionsprozess für Ihre spezifischen Schreibziele und -bereiche fein abzustimmen.

## 🌐 Web-Oberfläche

Validieren Sie Ihre Evolutionsergebnisse mit der integrierten Weboberfläche:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Öffnen Sie http://localhost:5000, um zuzugreifen auf:

- **Story-Vergleich**: Nebeneinander lesen und Präferenz auswählen
- **ELO-Ranglisten**: Aktuelle Platzierungen und Statistiken anzeigen
- **Evolutionsverfolgung**: Überprüfen, dass spätere Generationen sich verbessern
- **Datenexport**: Ergebnisse für die Analyse herunterladen


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---