<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

![Processus AlphaEvolve Writing](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Vous pouvez trouver l'explication complète [ici](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Vous pouvez trouver un exemple d'histoire soumise à un concours d'écriture [ici](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Un système moderne et évolutif d’écriture qui utilise des modèles d’IA pour générer, évaluer et faire évoluer des histoires créatives ou des textes généraux à travers des compétitions itératives. Construit avec une architecture Python propre et modulaire suivant les principes de conception modernes.




## ✨ Fonctionnalités

- 🧬 **Algorithme évolutif** : Les histoires évoluent grâce à des tournois propulsés par l’IA
- 🎯 **Deux modes d’écriture** : Rédaction créative et optimisation de texte général
- 🏆 **Système de tournoi ELO** : Classement sophistiqué via des comparaisons par paires
- 🌐 **Interface Web** : Validation humaine et outils de comparaison d’histoires
- 🔧 **Configurable** : Personnalisation étendue via une configuration JSON

## 🚀 Démarrage rapide

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
### Exécuter l'évolution


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
## 🏗️ Architecture

Le système suit les principes de conception modernes de Python avec une séparation claire des responsabilités :


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
### Composants clés

- **`EvolutionPipeline`** : Orchestrateur principal qui gère l'ensemble du cycle d'évolution
- **`InitialStoryGenerator`** : Crée la première génération d'histoires à partir des prompts
- **`NextBatchGenerator`** : Fait évoluer les meilleurs résultats en variantes améliorées
- **`TournamentRunner`** : Gère les tournois ELO pour le classement des histoires
- **`EloRankingSystem`** : Implémente un algorithme de classement sophistiqué

## 📖 Fonctionnement

Le système suit un cycle d'évolution en trois étapes :

### 1. **Générer le lot initial**
- Crée plusieurs histoires à partir de votre prompt
- Utilise des modèles IA configurables (GPT, Claude, Llama, etc.)
- Attribue des notes ELO initiales

### 2. **Lancer le tournoi ELO**
- Les histoires s'affrontent en comparaisons par paires
- Des juges IA évaluent selon votre grille
- Les notes ELO sont mises à jour selon les victoires/défaites

### 3. **Générer le lot suivant**
- Les meilleures histoires sont sélectionnées
- Des variantes sont générées avec des améliorations
- Le processus se répète sur plusieurs générations

Ce processus itératif fait évoluer la qualité d'écriture au fil du temps.

## ⚙️ Configuration

### Configuration de base

Modifiez ces fichiers clés :

- **`prompt.txt`** - Votre prompt ou thème d'écriture
- **`rubric.txt`** - Critères de jugement pour l'évaluation
- **`config.json`** - Configuration du système

### Configuration des clés API

Le système prend en charge plusieurs fournisseurs d'IA configurés via `config.json`. La configuration associe les modèles aux fournisseurs et précise quelles variables d'environnement contiennent les clés API :


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
Ensuite, définissez vos clés API comme variables d'environnement :


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Vous n'avez besoin de définir des clés que pour les fournisseurs que vous prévoyez d'utiliser. Le système oriente automatiquement les requêtes de modèles vers le fournisseur approprié en fonction de la configuration.

### Options de configuration

Le fichier `config.json` contrôle tout le comportement du système :


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
## 🎭 Modes d’écriture

### Mode d’écriture créative (Par défaut)
- Se concentre sur la narration, le développement des personnages et les techniques narratives
- Utilise des stratégies de génération basées sur des missions
- Optimise la créativité et l’engagement

### Mode d’écriture générale (`--general`)
- Se concentre sur les articles académiques, les essais, les rapports et l’écriture professionnelle
- Utilise des approches analytiques et structurées
- Optimise la clarté et la force de persuasion

## 🔧 Configuration avancée

### Personnalisation des stratégies de génération

Pour les utilisateurs avancés, vous pouvez personnaliser les invites de génération, les styles d’auteur et les ensembles de missions en modifiant les fichiers du répertoire `src/generators/` :

#### Personnalisation de l’écriture créative (`src/generators/generate_response.py`)

**Ensembles de missions** - Définir des approches et objectifs créatifs :

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
**Styles d’auteur** - Imitez différentes approches d’écriture :

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Personnalisation générale de l’écriture (`src/generators/generate_response_general.py`)

**Domaines d’accent académique** - Cibler des domaines spécifiques d’écriture :

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Approches d'écriture** - Définir des stratégies d'analyse :

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Personnalisation des critères de jugement (`src/generators/judge_response.py`)

Vous pouvez modifier les critères de jugement et les invites d'évaluation pour vous concentrer sur des aspects spécifiques de la qualité de l'écriture :


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
### Conseils pour une configuration avancée

1. **Sauvegardez les fichiers originaux** : Gardez toujours des copies des fichiers générateurs originaux avant d’apporter des modifications
2. **Testez de manière incrémentale** : Apportez de petits changements et testez-les sur quelques itérations avant de lancer des cycles d’évolution complets
3. **Surveillez les résultats** : Utilisez l’interface web pour valider que vos personnalisations améliorent la qualité des histoires
4. **Mixez et associez** : Combinez différents ensembles de missions et styles d’auteur pour des stratégies de génération uniques
5. **Contrôle de version** : Suivez vos personnalisations avec git afin de pouvoir revenir en arrière si nécessaire

Cette approche modulaire vous permet d’affiner le processus d’évolution pour vos objectifs et domaines d’écriture spécifiques.

## 🌐 Interface web

Validez vos résultats d’évolution avec l’interface web intégrée :


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Ouvrez http://localhost:5000 pour accéder à :

- **Comparaison d'histoires** : Lecture côte à côte et sélection de préférence
- **Classements ELO** : Voir les classements actuels et les statistiques
- **Suivi de l'évolution** : Valider que les générations ultérieures s'améliorent
- **Exportation de données** : Télécharger les résultats pour analyse


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---