
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

![Proceso de Escritura AlphaEvolve](https://raw.githubusercontent.com/tobysimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Puedes encontrar la explicación completa [aquí](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Puedes encontrar un ejemplo de historia presentada a un concurso de escritura [aquí](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Un sistema moderno de escritura evolutiva que usa modelos de IA para generar, evaluar y evolucionar historias creativas o piezas de escritura general mediante competiciones iterativas. Construido con una arquitectura Python limpia y modular siguiendo principios modernos de diseño.
## ✨ Características

- 🧬 **Algoritmo Evolutivo**: Las historias evolucionan mediante torneos impulsados por IA  
- 🎯 **Modos de Escritura Duales**: Narración creativa y optimización general de escritura  
- 🏆 **Sistema de Torneos ELO**: Clasificación sofisticada mediante comparaciones por pares  
- 🌐 **Interfaz Web**: Validación humana y herramientas para comparar historias  
- 🔧 **Configuración Personalizable**: Amplia personalización mediante configuración JSON  

## 🚀 Inicio Rápido

### Instalación





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

### Ejecutar Evolución

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

## 🏗️ Arquitectura

El sistema sigue principios modernos de diseño en Python con una clara separación de responsabilidades:

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

### Componentes Clave

- **`EvolutionPipeline`**: Orquestador principal que gestiona el ciclo completo de evolución
- **`InitialStoryGenerator`**: Crea la primera generación de historias a partir de indicaciones
- **`NextBatchGenerator`**: Evoluciona los mejores ejemplos en variantes mejoradas
- **`TournamentRunner`**: Gestiona torneos ELO para el ranking de historias
- **`EloRankingSystem`**: Implementa un algoritmo sofisticado de clasificación

## 📖 Cómo Funciona

El sistema sigue un ciclo de evolución de tres etapas:

### 1. **Generar Lote Inicial**
- Crea múltiples historias a partir de tu indicación
- Usa modelos de IA configurables (GPT, Claude, Llama, etc.)
- Asigna calificaciones ELO iniciales

### 2. **Ejecutar Torneo ELO**
- Las historias compiten en comparaciones por pares
- Jueces IA evalúan según tu rúbrica
- Las calificaciones ELO se actualizan según victorias/derrotas

### 3. **Generar Próximo Lote**
- Se seleccionan las historias con mejor desempeño
- Se generan variantes con mejoras
- El proceso se repite por múltiples generaciones

Este proceso iterativo evoluciona una escritura cada vez mejor con el tiempo.

## ⚙️ Configuración

### Configuración Básica

Edita estos archivos clave:

- **`prompt.txt`** - Tu indicación/tema de escritura
- **`rubric.txt`** - Criterios de evaluación para juzgar
- **`config.json`** - Configuración del sistema

### Configuración de Claves API

El sistema soporta múltiples proveedores de IA configurados a través de `config.json`. La configuración asigna modelos a proveedores y especifica qué variables de entorno contienen las claves API:

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

Luego establezca sus claves API como variables de entorno:

```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```

Solo necesitas configurar las claves para los proveedores que planeas usar. El sistema enruta automáticamente las solicitudes del modelo al proveedor correcto según la configuración.

### Opciones de Configuración

El archivo `config.json` controla todo el comportamiento del sistema:

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
## 🎭 Modos de Escritura

### Modo de Escritura Creativa (Predeterminado)
- Se enfoca en la narración, desarrollo de personajes y técnicas narrativas
- Utiliza estrategias de generación basadas en misiones
- Optimiza para creatividad y engagement

### Modo de Escritura General (`--general`)
- Se enfoca en artículos académicos, ensayos, reportes y escritura profesional
- Utiliza enfoques analíticos y estructurados
- Optimiza para claridad y persuasión

## 🔧 Configuración Avanzada

### Personalización de Estrategias de Generación

Para usuarios avanzados, puede personalizar los mensajes de generación, estilos de autor y conjuntos de misiones editando los archivos en el directorio `src/generators/`:

#### Personalización de Escritura Creativa (`src/generators/generate_response.py`)

**Conjuntos de Misiones** - Definen enfoques creativos y objetivos:

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

**Estilos de Autor** - Emular diferentes enfoques de escritura:
```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```

#### Personalización General de Escritura (`src/generators/generate_response_general.py`)

**Áreas de Enfoque Académico** - Dirigido a dominios específicos de escritura:
```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```

**Enfoques de Escritura** - Definir estrategias analíticas:
```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```

### Personalización de los Criterios del Juez (`src/generators/judge_response.py`)

Puedes modificar los criterios de evaluación y los indicativos de evaluación para centrarte en aspectos específicos de la calidad de la escritura:

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

### Consejos para Configuración Avanzada

1. **Haz Copias de Seguridad de los Archivos Originales**: Siempre guarda copias de los archivos originales del generador antes de hacer cambios
2. **Prueba Incrementalmente**: Realiza pequeños cambios y prueba con algunas iteraciones antes de ejecutar ciclos completos de evolución
3. **Monitorea los Resultados**: Usa la interfaz web para validar que tus personalizaciones mejoren la calidad de la historia
4. **Combina y Mezcla**: Combina diferentes conjuntos de misiones y estilos de autor para estrategias de generación únicas
5. **Control de Versiones**: Rastrea tus personalizaciones con git para revertir si es necesario

Este enfoque modular te permite ajustar el proceso de evolución para tus objetivos y dominios específicos de escritura.

## 🌐 Interfaz Web

Valida los resultados de tu evolución con la interfaz web incorporada:

```bash
cd web_interface
pip install -r requirements.txt
python app.py
```

Abra http://localhost:5000 para acceder:

- **Comparación de Historias**: Lectura lado a lado y selección de preferencia
- **Clasificaciones ELO**: Ver posiciones y estadísticas actuales
- **Seguimiento de la Evolución**: Validar que las generaciones posteriores mejoren
- **Exportación de Datos**: Descargar resultados para análisis

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---