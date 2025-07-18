<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

![AlphaEvolve Writing Process](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Полное объяснение вы можете найти [здесь](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Пример истории, отправленной на конкурс, можно найти [здесь](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Современная эволюционная система письма, использующая ИИ-модели для генерации, оценки и развития креативных историй или текстов общего назначения с помощью итерационных конкурсов. Создана на основе чистой, модульной архитектуры Python с использованием современных принципов проектирования.




## ✨ Особенности

- 🧬 **Эволюционный алгоритм**: Истории развиваются через турниры на базе ИИ
- 🎯 **Два режима письма**: Креативное повествование и оптимизация общего текста
- 🏆 **Турнирная система ELO**: Сложная система ранжирования через парные сравнения
- 🌐 **Веб-интерфейс**: Инструменты для валидации человеком и сравнения историй
- 🔧 **Настраиваемость**: Широкие возможности настройки через JSON-конфигурирование

## 🚀 Быстрый старт

### Установка


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
### Запуск эволюции


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
## 🏗️ Архитектура

Система следует современным принципам проектирования на Python с четким разделением ответственностей:


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
### Ключевые компоненты

- **`EvolutionPipeline`**: Главный оркестратор, управляющий полным циклом эволюции
- **`InitialStoryGenerator`**: Создает первое поколение историй по заданным промптам
- **`NextBatchGenerator`**: Эволюционирует лучших исполнителей в улучшенные варианты
- **`TournamentRunner`**: Управляет турнирами ELO для ранжирования историй
- **`EloRankingSystem`**: Реализует сложный алгоритм ранжирования

## 📖 Как это работает

Система использует трехступенчатый эволюционный цикл:

### 1. **Генерация начального набора**
- Создает несколько историй по вашему промпту
- Использует настраиваемые AI-модели (GPT, Claude, Llama и др.)
- Присваивает начальные рейтинги ELO

### 2. **Проведение ELO-турнира**
- Истории соревнуются в попарных сравнениях
- AI-судьи оценивают по вашему рубрикатору
- Рейтинги ELO обновляются в зависимости от побед/поражений

### 3. **Генерация следующего набора**
- Отбираются лучшие истории
- Генерируются улучшенные варианты
- Процесс повторяется для нескольких поколений

Этот итеративный процесс со временем улучшает качество текста.

## ⚙️ Конфигурация

### Базовая настройка

Отредактируйте эти ключевые файлы:

- **`prompt.txt`** - Ваш промпт/тема для написания
- **`rubric.txt`** - Критерии оценки для судейства
- **`config.json`** - Конфигурация системы

### Настройка API-ключей

Система поддерживает нескольких AI-провайдеров, настраиваемых через `config.json`. Конфигурация связывает модели с провайдерами и указывает, в каких переменных окружения содержатся API-ключи:


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
Затем установите свои ключи API в качестве переменных окружения:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Вам нужно указывать ключи только для тех провайдеров, которыми вы планируете пользоваться. Система автоматически направляет запросы к моделям нужному провайдеру в соответствии с конфигурацией.

### Параметры конфигурации

Файл `config.json` управляет всеми аспектами работы системы:


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
## 🎭 Режимы написания

### Режим креативного письма (по умолчанию)
- Сфокусирован на повествовании, проработке персонажей и нарративных техниках
- Использует генерацию на основе миссий
- Оптимизирован для креативности и вовлечённости

### Общий режим письма (`--general`)
- Сфокусирован на академических статьях, эссе, отчётах и профессиональном письме
- Использует аналитические и структурированные подходы
- Оптимизирован для ясности и убедительности

## 🔧 Расширенная настройка

### Настройка стратегий генерации

Для опытных пользователей доступна возможность настроить подсказки генерации, стили авторов и наборы миссий путём редактирования файлов в каталоге `src/generators/`:

#### Кастомизация креативного письма (`src/generators/generate_response.py`)

**Наборы миссий** — Определяют креативные подходы и цели:

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
**Стили авторов** — Имитация различных подходов к написанию:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Общая настройка написания (`src/generators/generate_response_general.py`)

**Академические области** - Ориентация на определённые направления письма:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Подходы к написанию** - Определите аналитические стратегии:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Настройка критериев оценки (`src/generators/judge_response.py`)

Вы можете изменить критерии оценки и подсказки для оценки, чтобы сосредоточиться на конкретных аспектах качества письма:


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
### Советы по расширенной настройке

1. **Создайте резервные копии оригинальных файлов**: Всегда сохраняйте копии исходных файлов генератора перед внесением изменений
2. **Тестируйте поэтапно**: Вносите небольшие изменения и тестируйте их на нескольких итерациях перед запуском полного цикла эволюции
3. **Отслеживайте результаты**: Используйте веб-интерфейс для проверки того, что ваши настройки улучшают качество историй
4. **Смешивайте и сочетайте**: Комбинируйте различные наборы миссий и стили авторов для создания уникальных стратегий генерации
5. **Контроль версий**: Отслеживайте свои изменения с помощью git, чтобы при необходимости можно было откатить их

Такой модульный подход позволяет точно настраивать процесс эволюции под ваши конкретные задачи и области письма.

## 🌐 Веб-интерфейс

Проверьте результаты эволюции с помощью встроенного веб-интерфейса:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Откройте http://localhost:5000 для доступа:

- **Сравнение историй**: Чтение бок о бок и выбор предпочтений
- **Рейтинги ELO**: Просмотр текущих позиций и статистики
- **Отслеживание эволюции**: Проверка улучшения последующих поколений
- **Экспорт данных**: Скачивание результатов для анализа


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---