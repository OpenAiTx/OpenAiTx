<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Italiano</a>
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

![AlphaEvolve Writing Process](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Puoi trovare la spiegazione completa [qui](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Puoi trovare un esempio di racconto inviato a un concorso di scrittura [qui](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Un sistema moderno ed evolutivo di scrittura che utilizza modelli AI per generare, valutare ed evolvere storie creative o testi generali attraverso competizioni iterative. Costruito con un'architettura Python modulare e pulita seguendo i principi di design moderni.




## ✨ Caratteristiche

- 🧬 **Algoritmo Evolutivo**: Le storie evolvono tramite tornei alimentati dall'IA
- 🎯 **Doppia Modalità di Scrittura**: Narrazione creativa e ottimizzazione della scrittura generale
- 🏆 **Sistema di Torneo ELO**: Classificazione sofisticata tramite confronti a coppie
- 🌐 **Interfaccia Web**: Strumenti per la validazione umana e il confronto delle storie
- 🔧 **Configurabile**: Ampia personalizzazione tramite configurazione JSON

## 🚀 Guida Rapida

### Installazione


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
### Esegui Evoluzione


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
## 🏗️ Architettura

Il sistema segue i principi di progettazione moderni di Python con una chiara separazione delle responsabilità:


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
### Componenti Chiave

- **`EvolutionPipeline`**: Orchestratore principale che gestisce l'intero ciclo evolutivo
- **`InitialStoryGenerator`**: Crea la prima generazione di storie a partire dai prompt
- **`NextBatchGenerator`**: Evolve i migliori performer in varianti migliorate
- **`TournamentRunner`**: Gestisce i tornei ELO per la classifica delle storie
- **`EloRankingSystem`**: Implementa un sofisticato algoritmo di classificazione

## 📖 Come Funziona

Il sistema segue un ciclo evolutivo in tre fasi:

### 1. **Genera Batch Iniziale**
- Crea più storie dal tuo prompt
- Usa modelli AI configurabili (GPT, Claude, Llama, ecc.)
- Assegna valutazioni ELO iniziali

### 2. **Esegui Torneo ELO**
- Le storie competono in confronti a coppie
- Giudici AI valutano secondo la tua rubrica
- Le valutazioni ELO vengono aggiornate in base a vittorie/sconfitte

### 3. **Genera Batch Successivo**
- Seleziona le storie con le migliori prestazioni
- Vengono generate varianti con miglioramenti
- Il processo si ripete per più generazioni

Questo processo iterativo porta nel tempo a scritture sempre migliori.

## ⚙️ Configurazione

### Configurazione Base

Modifica questi file chiave:

- **`prompt.txt`** - Il tuo prompt/tema di scrittura
- **`rubric.txt`** - Criteri di valutazione per il giudizio
- **`config.json`** - Configurazione del sistema

### Configurazione delle Chiavi API

Il sistema supporta diversi provider AI configurabili tramite `config.json`. La configurazione associa i modelli ai provider e specifica quali variabili d'ambiente contengono le chiavi API:


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
Quindi imposta le tue chiavi API come variabili d'ambiente:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Devi impostare le chiavi solo per i provider che prevedi di utilizzare. Il sistema indirizza automaticamente le richieste dei modelli al provider corretto in base alla configurazione.

### Opzioni di configurazione

Il file `config.json` controlla tutto il comportamento del sistema:


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
## 🎭 Modalità di Scrittura

### Modalità Scrittura Creativa (Predefinita)
- Si concentra su narrazione, sviluppo dei personaggi e tecniche narrative
- Utilizza strategie di generazione basate su missioni
- Ottimizza per creatività e coinvolgimento

### Modalità Scrittura Generale (`--general`)
- Si concentra su articoli accademici, saggi, relazioni e scrittura professionale
- Utilizza approcci analitici e strutturati
- Ottimizza per chiarezza e capacità persuasiva

## 🔧 Configurazione Avanzata

### Personalizzazione delle Strategie di Generazione

Per utenti avanzati, è possibile personalizzare i prompt di generazione, gli stili degli autori e i set di missioni modificando i file nella directory `src/generators/`:

#### Personalizzazione Scrittura Creativa (`src/generators/generate_response.py`)

**Set di Missioni** - Definisci approcci e obiettivi creativi:

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
**Stili dell'autore** - Emula diversi approcci di scrittura:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Personalizzazione della Scrittura Generale (`src/generators/generate_response_general.py`)

**Aree di Interesse Accademico** - Prendi di mira domini di scrittura specifici:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Approcci di Scrittura** - Definisci le strategie analitiche:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Personalizzazione dei criteri di valutazione (`src/generators/judge_response.py`)

Puoi modificare i criteri di valutazione e i prompt di valutazione per concentrarti su specifici aspetti della qualità della scrittura:


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
### Suggerimenti per la Configurazione Avanzata

1. **Backup dei File Originali**: Conserva sempre copie dei file originali del generatore prima di apportare modifiche
2. **Test Incrementali**: Apporta piccole modifiche e testa con alcune iterazioni prima di eseguire cicli di evoluzione completi
3. **Monitora i Risultati**: Usa l'interfaccia web per verificare che le tue personalizzazioni migliorino la qualità delle storie
4. **Combina e Abbina**: Unisci diversi set di missioni e stili di autori per strategie di generazione uniche
5. **Controllo delle Versioni**: Tieni traccia delle tue personalizzazioni con git per poter tornare indietro se necessario

Questo approccio modulare ti consente di perfezionare il processo di evoluzione per i tuoi specifici obiettivi e ambiti di scrittura.

## 🌐 Interfaccia Web

Valida i risultati dell'evoluzione con l'interfaccia web integrata:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Apri http://localhost:5000 per accedere a:

- **Confronto Storie**: Lettura affiancata e selezione delle preferenze
- **Classifiche ELO**: Visualizza le posizioni attuali e le statistiche
- **Tracciamento Evoluzione**: Verifica che le generazioni successive migliorino
- **Esportazione Dati**: Scarica i risultati per l'analisi


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---