<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve Schrijven

![AlphaEvolve Schrijfproces](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

De volledige uitleg kun je [hier](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html) vinden

Een voorbeeldverhaal dat is ingezonden voor een schrijfwedstrijd vind je [hier](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Een modern, evolutionair schrijfsysteem dat AI-modellen gebruikt om creatieve verhalen of algemene teksten te genereren, evalueren en te laten evolueren via iteratieve competities. Gebouwd met een schone, modulaire Python-architectuur volgens moderne ontwerpprincipes.




## ✨ Functies

- 🧬 **Evolutionair Algoritme**: Verhalen evolueren via door AI aangedreven toernooien
- 🎯 **Dubbele Schrijfmodi**: Creatief verhalen vertellen en optimalisatie van algemene teksten
- 🏆 **ELO-toernooisysteem**: Geavanceerde rangschikking via pairwise vergelijkingen
- 🌐 **Webinterface**: Hulpmiddelen voor menselijke validatie en verhaalvergelijking
- 🔧 **Configureerbaar**: Uitgebreide aanpassingsmogelijkheden via JSON-configuratie

## 🚀 Snel Starten

### Installatie


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
### Voer Evolutie Uit


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
## 🏗️ Architectuur

Het systeem volgt moderne Python-ontwerpprincipes met een duidelijke scheiding van verantwoordelijkheden:


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
### Belangrijke Componenten

- **`EvolutionPipeline`**: Hoofdorkestrator die de volledige evolutiecyclus beheert
- **`InitialStoryGenerator`**: Maakt de eerste generatie verhalen op basis van prompts
- **`NextBatchGenerator`**: Evolueert toppresteerders naar verbeterde varianten
- **`TournamentRunner`**: Beheert ELO-toernooien voor het rangschikken van verhalen
- **`EloRankingSystem`**: Implementeert geavanceerd rangschikkingsalgoritme

## 📖 Hoe Werkt Het

Het systeem volgt een evolutiecyclus in drie fasen:

### 1. **Genereer Initiële Batch**
- Maakt meerdere verhalen op basis van jouw prompt
- Gebruikt configureerbare AI-modellen (GPT, Claude, Llama, etc.)
- Wijst initiële ELO-scores toe

### 2. **Voer ELO Toernooi Uit**
- Verhalen concurreren in paarvergelijkingen
- AI-juryleden beoordelen volgens jouw rubric
- ELO-scores worden bijgewerkt op basis van winst/verlies

### 3. **Genereer Volgende Batch**
- Best presterende verhalen worden geselecteerd
- Varianten worden gegenereerd met verbeteringen
- Proces wordt herhaald voor meerdere generaties

Dit iteratieve proces zorgt ervoor dat het schrijven in de loop van de tijd steeds beter wordt.

## ⚙️ Configuratie

### Basisinstellingen

Bewerk deze belangrijke bestanden:

- **`prompt.txt`** - Jouw schrijfprompt/thema
- **`rubric.txt`** - Beoordelingscriteria voor evaluatie
- **`config.json`** - Systeemconfiguratie

### API-sleutels Instellen

Het systeem ondersteunt meerdere AI-aanbieders die worden geconfigureerd via `config.json`. De configuratie koppelt modellen aan aanbieders en specificeert welke omgevingsvariabelen de API-sleutels bevatten:


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
Stel vervolgens uw API-sleutels in als omgevingsvariabelen:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
U hoeft alleen sleutels in te stellen voor de providers die u van plan bent te gebruiken. Het systeem stuurt modelverzoeken automatisch naar de juiste provider op basis van de configuratie.

### Configuratie-opties

Het bestand `config.json` bepaalt al het systeemgedrag:


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
## 🎭 Schrijfmodi

### Creatieve Schrijfmodus (Standaard)
- Richt zich op storytelling, karakterontwikkeling en narratieve technieken
- Gebruikt missie-gebaseerde generatiestrategieën
- Optimaliseert voor creativiteit en betrokkenheid

### Algemene Schrijfmodus (`--general`)
- Richt zich op academische artikelen, essays, rapporten en professioneel schrijven
- Gebruikt analytische en gestructureerde benaderingen
- Optimaliseert voor duidelijkheid en overtuigingskracht

## 🔧 Geavanceerde Configuratie

### Generatiestrategieën Aanpassen

Voor gevorderde gebruikers kun je de generatie-prompts, auteursstijlen en missiesets aanpassen door de bestanden in de map `src/generators/` te bewerken:

#### Creatieve Schrijfaanpassing (`src/generators/generate_response.py`)

**Missiesets** - Definieer creatieve benaderingen en doelen:

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
**Auteursstijlen** - Imiteer verschillende schrijfbenaderingen:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Algemene Schrijftoepassing Aanpassingen (`src/generators/generate_response_general.py`)

**Academische Focusgebieden** - Richt je op specifieke schrijfgebieden:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Schrijfbenaderingen** - Definieer analytische strategieën:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Aangepaste beoordelingscriteria (`src/generators/judge_response.py`)

Je kunt de beoordelingscriteria en evaluatieprompts aanpassen om je te richten op specifieke aspecten van schrijfkwaliteit:


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
### Tips voor Geavanceerde Configuratie

1. **Maak Back-ups van Originele Bestanden**: Bewaar altijd kopieën van de originele generatorbestanden voordat je wijzigingen aanbrengt
2. **Test Geleidelijk**: Breng kleine wijzigingen aan en test met een paar iteraties voordat je volledige evolutiecycli uitvoert
3. **Monitor Resultaten**: Gebruik de webinterface om te controleren of je aanpassingen de kwaliteit van het verhaal verbeteren
4. **Combineer en Varieer**: Combineer verschillende missiesets en schrijfstijlen voor unieke generatiestrategieën
5. **Versiebeheer**: Houd je aanpassingen bij met git zodat je indien nodig kunt terugdraaien

Deze modulaire aanpak stelt je in staat het evolutieproces fijn af te stemmen op jouw specifieke schrijfdoelen en domeinen.

## 🌐 Webinterface

Valideer je evolutieresultaten met de ingebouwde webinterface:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Open http://localhost:5000 om toegang te krijgen tot:

- **Verhaalvergelijking**: Naast elkaar lezen en voorkeur selecteren
- **ELO-ranglijsten**: Bekijk huidige standen en statistieken
- **Evolutietracking**: Valideer dat latere generaties verbeteren
- **Gegevens exporteren**: Download resultaten voor analyse


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---