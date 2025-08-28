
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

## Новости
- [2025-08-22] **Исправление ошибки**: В коде Bird-Interact-Agent мы исправили ошибку, при которой при оценке SQL на этапе 2 сохранённый SQL с этапа 1 не мог быть успешно выполнен, что приводило к снижению процента успешных фаз 2. Эта ошибка влияет только на те задачи, где на этапе 1 SQL выполняет операции с базой данных, например CREATE table и др.

## 🧸 Обзор

BIRD-INTERACT — интерактивный бенчмарк text-to-SQL, **переосмысляющий оценку Text-to-SQL через призму динамических взаимодействий**.
Среда сочетает иерархическую базу знаний, документацию по базе данных и симулятор пользователя, управляемый функциями, чтобы воссоздать аутентичные корпоративные условия для всех операций **CRUD**.
Он предлагает два строгих режима тестирования: (1) пассивное **Conversational Interaction** и (2) активное **Agentic Interaction**, охватывая 600 аннотированных задач по бизнес-аналитике (BI), операциям CRUD и др., каждая из которых сопровождается исполняемыми тест-кейсами.
Типичные оценки вызывают от 1 968 до 5 496 интерактивных этапов между моделью и симулятором пользователя, при этом современные модели рассуждения решают лишь **≈24%** и **≈18%** задач, что подчёркивает сложность бенчмарка.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Два режима оценки

BIRD-INTERACT поддерживает два режима оценки, описанные выше:

   - **c-Interact**: Conversational Interaction — пассивный режим с фиксированным рабочим процессом. Код и подробную информацию можно найти в `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction — активный режим с динамическим процессом, управляемым моделями. Код и подробную информацию можно найти в `bird_interact_agent`.


### 🐣 Легкая версия

Мы выпускаем легкую версию BIRD-INTERACT, `bird-interact-lite-exp`, которая включает 270 высококачественных реальных задач специально для PostgreSQL. Это хороший старт для быстрых экспериментов.

### 🦜 Полная версия

Полная версия BIRD-INTERACT, `bird-interact-full`, — это комплексный эталон, включающий 600 задач для PostgreSQL. Она охватывает широкий спектр операций SQL и пользовательских запросов. Полная версия появится скоро.

### Результаты производительности моделей на BIRD-INTERACT Lite

#### 1. **c-Interact** Результаты
| Ранг | Название модели     | Нормализованная награда | Уровень        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Отличный чат |
| 2    | GPT-4o             | 30.33 | 💎 Хороший чат   |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Хороший чат   |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Стандарт      |
| 5    | DeepSeek-R1        | 21.74 | ✨ Стандарт      |
| 6    | Qwen3              | 20.33 | ⚪ Базовый       |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Базовый       |

#### 2. **a-Interact** Результаты
| Ранг | Название модели     | Параметры бюджета* | Средн. шагов/задача | Средн. стоимость (USD)/задача | Нормализованная награда | Уровень            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Отличное взаимодействие |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Хорошее взаимодействие  |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Хорошее взаимодействие  |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Стандарт               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Стандарт               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Базовый                |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Базовый                |

> \* Параметры бюджета: Стартовый бюджет/Бюджет терпения пользователя, измеряются нашей виртуальной валютой *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Подробнее см. [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Масштабирование по времени взаимодействия (ITS)

Масштабирование по времени взаимодействия (ITS) описывает способность модели непрерывно повышать итоговую производительность благодаря многократным интеракциям. Когда эта интерактивная производительность превосходит идеализированную однократную производительность модели на полностью определенной, недвусмысленной задаче, мы говорим, что модель удовлетворяет **закону ITS**. По мере роста терпения пользователя и накопления интеракций производительность продолжает увеличиваться, демонстрируя, что модель способна поддерживать эффективное общение в продолжительном диалоге. На данный момент только claude-3-7-sonnet удовлетворяет закону ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Детали набора данных

### Описание набора данных

- **База данных:** Полную базу данных PostgreSQL можно скачать с [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Подробнее см. в разделе [Quick Eval](#quick-eval).
- **data:** Каждый экземпляр данных содержит следующие основные части:
   - `selected_database`: Название базы данных.  
   - `query`: Недвусмысленный пользовательский запрос.  
   - `amb_user_query`: Пользовательский запрос с внесёнными неоднозначностями.
   - `user_query_ambiguity`: Неоднозначности, внесённые в пользовательский запрос.
   - `non_critical_ambiguity`: Некритические неоднозначности, такие как порядок, лимит и др.
   - `knowledge_ambiguity`: Неоднозначности, созданные маскировкой внешних знаний.
   - `sol_sql`: Эталонное SQL-решение.  
   - `preprocess_sql`: SQL-запросы, которые нужно выполнить до запуска решения или предсказания.  
   - `clean_up_sql`: SQL-запросы, которые нужно выполнить после тестовых случаев для отката изменений в базе данных.  
   - `test_cases`: Набор тестовых случаев для проверки предсказанного SQL.
   - `follow_up`: Маркированные дополнительные вопросы.
   - `external_knowledge`: Внешние знания, относящиеся к конкретной задаче.

- **evaluation:** Код для оценки доступен в каталоге [`./evaluation`](./evaluation).
- **Кураторы:** Команда BIRD и Google Cloud
- **Лицензия:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Карта набора данных HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Использование набора данных

Чтобы избежать утечки данных при автоматическом сборе, мы не включаем эталонные SQL-решения и тестовые случаи вместе с данными.
Пожалуйста, отправьте письмо на [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) с тегом `[bird-interact-lite GT&Test Cases]` в заголовке для получения полного набора, который будет отправлен автоматически.


<!-- ### Использование набора данных из HuggingFace

Вы можете скачать набор данных из HuggingFace с помощью следующей команды:
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

## 📰 Новости

🚀 Мы рады объявить о выпуске набора **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Это сложный набор — лучшие LLM достигают лишь **16,33%** успешных попыток, а по разделам `c-interact` и `a-interact` всего **10,0%**.  
👉 Для получения подробностей посетите наш [сайт проекта](https://bird-interact.github.io/).

📬 На этой неделе мы отправим **Эталонные ответы и тестовые кейсы** по нашей рассылке.  
Если хотите получить ранний доступ, отправьте письмо согласно инструкции на сайте для **автоматической загрузки**.  

💾 К тому же, мы выпустили SQLite-версию **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** для удобных локальных исследований.  
Полные версии **LiveSQLBench-Base** и **-Large** появятся совсем скоро!

## 📋 Список задач

- [x] Выпустить lite-версию, bird-interact-lite (270).
- [x] Выпустить разговорную версию, bird-interact-conv.
- [x] Выпустить агентную версию, bird-interact-agent.
- [x] Выпустить полную версию bird-interact-full (600).
- [ ] SFT / RL пользовательского симулятора

## Создано:
Команда BIRD и Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---