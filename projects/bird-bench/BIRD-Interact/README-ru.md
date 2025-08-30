
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Лицензия">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Таблица лидеров">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 📰 Новости

- [2025-08-26] 🚀 Мы рады объявить о выпуске набора **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Это сложный набор — лучшие LLM достигают лишь **16,33%** успешности, а на частях `c-interact` и `a-interact` всего **10,0%**.  
👉 Подробнее смотрите на нашем [сайте проекта](https://bird-interact.github.io/).

- [2025-08-26] 📬 На этой неделе мы отправим **Ground Truth и тестовые кейсы** в наш список рассылки.  
Если вы хотите получить ранний доступ, отправьте письмо согласно инструкции на сайте для **автоматической загрузки**.  

- [2025-08-26] 💾 Также мы выпустили SQLite-версию **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** для упрощения локальных исследований.  
Полные версии **LiveSQLBench-Base** и **-Large** появятся скоро!

- [2025-08-22] **Исправление ошибки**: В коде Bird-Interact-Agent мы исправили баг, из-за которого при оценке phase-2 SQL сохранённый phase-1 SQL не мог быть успешно выполнен, что приводило к снижению успешности Phase-2. Ошибка затрагивает только те задачи, где phase1 sql выполняет операции с базой, например CREATE table и т.д.

## 🧸 Обзор

BIRD-INTERACT — интерактивный бенчмарк text-to-SQL, **переосмысливающий оценку Text-to-SQL через призму динамических взаимодействий**.
Среда сочетает иерархическую базу знаний, документацию по базе данных и симулятор пользователя на основе функций, чтобы воссоздать аутентичные корпоративные условия для всех операций **CRUD**.
Бенчмарк предлагает два строгих режима тестирования: (1) пассивное **разговорное взаимодействие** и (2) активное **агентное взаимодействие**, охватывая 600 аннотированных заданий, включая BI, CRUD-операции и др., каждое сопровождается исполняемыми тест-кейсами.
Типичные оценки запускают от 1 968 до 5 496 раундов взаимодействия между моделью и симулятором пользователя, а современные reasoning-модели решают только **≈24%** и **≈18%** заданий, что подчёркивает сложность бенчмарка.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Два режима оценки

BIRD-INTERACT поддерживает два режима оценки, как указано выше:

   - **c-Interact**: Диалоговое взаимодействие, пассивный режим с фиксированным рабочим процессом. Код и подробная информация доступны в `bird_interact_conv`.
   - **a-Interact**: Агентное взаимодействие, активный режим с динамическим процессом, управляемым моделями. Код и подробная информация доступны в `bird_interact_agent`.


### 🐣 Облегчённая версия

Мы выпускаем облегчённую версию BIRD-INTERACT, `bird-interact-lite-exp`, которая включает 270 высококачественных реальных задач специально для PostgreSQL. Это хороший старт для быстрого эксперимента.

### 🦜 Полная версия

Полная версия BIRD-INTERACT, `bird-interact-full`, — это комплексный бенчмарк, включающий 600 задач для PostgreSQL. Она охватывает широкий спектр операций SQL и пользовательских запросов. Полная версия появится в ближайшее время.

### Результаты производительности моделей на BIRD-INTERACT Lite

#### 1. **c-Interact** Производительность
| Ранг | Название модели     | Нормализованная награда | Уровень        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Отличный чат |
| 2    | GPT-4o             | 30.33 | 💎 Хороший чат  |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Хороший чат  |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Стандарт      |
| 5    | DeepSeek-R1        | 21.74 | ✨ Стандарт      |
| 6    | Qwen3              | 20.33 | ⚪ Базовый       |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Базовый       |

#### 2. **a-Interact** Производительность
| Ранг | Название модели     | Параметры бюджета* | Среднее шагов/задачу | Средняя стоимость (USD)/задачу | Нормализованная награда | Уровень                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Отличное взаимодействие |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Хорошее взаимодействие  |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Хорошее взаимодействие  |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Стандарт                |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Стандарт              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Базовый               |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Базовый               |

> \* Параметры бюджета: Стартовый бюджет/Бюджет терпения пользователя, измеряется нашей виртуальной валютой *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Подробнее см. в [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Масштабирование времени взаимодействия (ITS)

Масштабирование времени взаимодействия (ITS) относится к способности модели непрерывно улучшать итоговую производительность через многотуровые взаимодействия. Когда эта интерактивная производительность превосходит идеализированную однобитовую производительность модели на полностью определённой, однозначной задаче, считается, что она удовлетворяет **закону ITS**. По мере роста терпения пользователя и накопления числа взаимодействий, производительность продолжает улучшаться, демонстрируя, что модель способна поддерживать эффективную коммуникацию в длительном диалоге. В настоящее время только claude-3-7-sonnet удовлетворяет закону ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Подробности о датасете

### Описание датасета

- **База данных:** Полную базу данных PostgreSQL можно скачать с [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Подробнее см. раздел [Quick Eval](#quick-eval).
- **data:** Каждый экземпляр данных содержит следующие основные части:
   - `selected_database`: Имя базы данных.  
   - `query`: Однозначный пользовательский запрос.  
   - `amb_user_query`: Запрос пользователя с внесёнными неоднозначностями.
   - `user_query_ambiguity`: Неоднозначности, внесённые в пользовательский запрос.
   - `non_critical_ambiguity`: Некритичные неоднозначности, такие как порядок, лимит и др.
   - `knowledge_ambiguity`: Неоднозначности, созданные маскированными внешними знаниями. 
   - `sol_sql`: Эталонное SQL-решение.  
   - `preprocess_sql`: SQL-запросы, выполняемые перед решением или предсказанием.  
   - `clean_up_sql`: SQL-запросы для отката изменений в базе после тестирования.  
   - `test_cases`: Набор тестовых кейсов для проверки предсказанного исправленного SQL.
   - `follow_up`: Помеченные уточняющие вопросы.
   - `external_knowledge`: Внешние знания, относящиеся к конкретной задаче.

- **evaluation:** Код для оценки доступен в директории [`./evaluation`](./evaluation).
- **Кураторы:** BIRD Team & Google Cloud
- **Лицензия:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Карточка датасета на HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Использование датасета

Чтобы избежать утечки данных из-за автоматического сканирования, мы не включаем SQL-решения GT и тестовые примеры вместе с данными.
пожалуйста, отправьте письмо на [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) с тегом `[bird-interact-lite GT&Test Cases]` в заголовке для получения полного набора, который будет отправлен автоматически.


<!-- ### Используйте датасет из HuggingFace

Вы можете скачать датасет из HuggingFace с помощью следующей команды:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Или вы можете использовать предоставленный скрипт для загрузки полной версии набора данных и разделения его на разные диалекты.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Путь к входному JSONL-файлу (может быть пустым, если вы хотите скачать датасет с HuggingFace)
  --output_folder path/to/output_dir # выходная папка для файлов разбиения
```

## Структура папок
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
Подробности о запуске **a-interact** можно найти в `./bird_interact_agent/README.md`; а о **c-interact** — в `./bird_interact_conv/README.md`.

## 📋 Списки задач

- [x] Выпущена облегчённая версия, bird-interact-lite (270).
- [x] Выпущена разговорная версия, bird-interact-conv.
- [x] Выпущена агентная версия, bird-interact-agent.
- [x] Выпущена полная версия bird-interact-full (600).
- [ ] SFT / RL симулятор пользователя

## Создано:
Команда BIRD и Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---