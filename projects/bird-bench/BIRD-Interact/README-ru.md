
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
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
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

## ⚠️ Объявление  
Обратите внимание, что до начала процесса оценки при загрузке баз данных в Docker могут периодически возникать ошибки из-за несоответствия среды (они не приведут к завершению процесса, но появятся в логах Docker). В результате некоторые базы данных могут загрузиться некорректно, что приведет к пустым базам данных. Это вызовет аномально низкие результаты оценки.  
👉 Поэтому настоятельно рекомендуем проверить логи Docker на наличие ошибок **до запуска оценки** и убедиться, что все базы данных успешно загружены.

## 📰 Новости

- [2025-08-26] 🚀 Мы рады объявить о выходе набора **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Это сложный набор — лучшие LLM достигают всего **16.33%** успешных решений, а на частях `c-interact` и `a-interact` — лишь **10.0%**.  
👉 Подробнее смотрите на нашем [сайте проекта](https://bird-interact.github.io/).

- [2025-08-26] 📬 На этой неделе мы разошлем **Ground Truth & Test cases** по нашей рассылке.  
Если хотите получить доступ раньше, отправьте письмо согласно инструкции на сайте для **автоматической загрузки**.  

- [2025-08-26] 💾 Кроме того, мы выпустили SQLite-версию **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** для локальных исследований.  
Полные версии **LiveSQLBench-Base** и **-Large** скоро будут доступны!

- [2025-08-22] **Исправление ошибки**: В коде Bird-Interact-Agent мы устранили ошибку, из-за которой при оценке phase-2 SQL сохраненный phase-1 SQL не мог быть успешно выполнен, что приводило к снижению успешности Phase-2. Эта ошибка затрагивала только те задачи, где phase1 sql выполняет операции с базой данных, например CREATE table и др.

## 🧸 Обзор

BIRD-INTERACT — это интерактивный бенчмарк text-to-SQL, который **переосмысливает оценку Text-to-SQL через призму динамических взаимодействий**.
Среда сочетает иерархическую базу знаний, документацию базы данных и симулятор пользователя на основе функций для воссоздания реальных корпоративных условий по всем операциям **CRUD**.
Он предлагает два строгих режима тестирования: (1) пассивное **Диалоговое взаимодействие** и (2) активное **Агентное взаимодействие**, охватывающих 600 аннотированных задач, включая бизнес-аналитику (BI), операции CRUD и др., каждая из которых защищена исполняемыми тест-кейсами.
Типичные оценки инициируют от 1 968 до 5 496 интерактивных шагов между моделью и симулятором пользователя, тогда как современные модели рассуждений на сегодняшний день решают лишь **≈24%** и **≈18%** задач, что подчеркивает сложность данного бенчмарка.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Два режима оценки

BIRD-INTERACT поддерживает два режима оценки, как указано выше:

   - **c-Interact**: Диалоговое взаимодействие, являющееся пассивным режимом с фиксированным workflow. Код и подробная информация доступны в `bird_interact_conv`.
   - **a-Interact**: Агентное взаимодействие, являющееся воплощенным активным режимом, где workflow динамичен и формируется моделями. Код и подробная информация доступны в `bird_interact_agent`.


### 🐣 Легкая версия

Мы выпускаем легкую версию BIRD-INTERACT, `bird-interact-lite-exp`, включающую 270 высококачественных реальных задач специально для PostgreSQL. Это хорошая отправная точка для быстрых экспериментов.

### 🦜 Полная версия

Полная версия BIRD-INTERACT, `bird-interact-full`, — это комплексный бенчмарк, включающий 600 задач для PostgreSQL. Он охватывает широкий спектр SQL-операций и пользовательских запросов. Полная версия выйдет в ближайшее время.

### Результаты производительности моделей на BIRD-INTERACT Lite

#### 1. Производительность **c-Interact**
| Место | Название модели    | Нормализованная награда | Уровень        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Отличный чат |
| 2    | GPT-4o             | 30.33 | 💎 Хороший чат   |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Хороший чат   |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Стандарт      |
| 5    | DeepSeek-R1        | 21.74 | ✨ Стандарт      |
| 6    | Qwen3              | 20.33 | ⚪ Базовый       |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Базовый       |

#### 2. Производительность **a-Interact**
| Место | Название модели    | Ограничение бюджета* | Среднее кол-во шагов/задача | Средняя стоимость (USD)/задача | Нормализованная награда | Уровень            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Отличное взаимодействие |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Хорошее взаимодействие   |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Хорошее взаимодействие   |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Стандарт                |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Стандарт                |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Базовый                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Базовый                 |

> \* Параметры бюджета: Начальный бюджет/Бюджет терпения пользователя, измеряется нашей виртуальной валютой *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Подробнее смотрите в [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Масштабирование времени взаимодействия (ITS)

Масштабирование времени взаимодействия (ITS) — это способность модели непрерывно улучшать итоговую производительность за счет многоходового взаимодействия. Когда эта интерактивная производительность превосходит идеализированную одновременную производительность модели на полностью определенной, однозначной задаче, мы говорим, что она удовлетворяет **закону ITS**. По мере роста терпения пользователя и накопления ходов взаимодействия производительность продолжает расти, демонстрируя, что модель способна поддерживать эффективную коммуникацию в ходе длительного диалога. В настоящее время только claude-3-7-sonnet соответствует закону ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Детали датасета

### Описание датасета

- **База данных:** Полная база данных PostgreSQL доступна для скачивания на [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Подробнее смотрите в разделе [Quick Eval](#quick-eval).
- **data:** Каждый экземпляр данных содержит следующие основные части:
   - `selected_database`: Имя базы данных.  
   - `query`: Однозначный пользовательский запрос.  
   - `amb_user_query`: Пользовательский запрос с внедренными неоднозначностями.
   - `user_query_ambiguity`: Неоднозначности, внедренные в пользовательский запрос.
   - `non_critical_ambiguity`: Некритические неоднозначности, такие как порядок, лимит и др.
   - `knowledge_ambiguity`: Неоднозначности, созданные маскировкой внешних знаний. 
   - `sol_sql`: Эталонное решение SQL.  
   - `preprocess_sql`: SQL-запросы, выполняемые перед запуском решения или предсказания.  
   - `clean_up_sql`: SQL-запросы для отката изменений после выполнения тестовых случаев.  
   - `test_cases`: Набор тестовых случаев для проверки предсказанного исправленного SQL.
   - `follow_up`: Помеченные последующие вопросы.
   - `external_knowledge`: Внешние знания, относящиеся к конкретной задаче.

- **evaluation:** Код для оценки доступен в директории [`./evaluation`](./evaluation).
- **Кураторы:** Команда BIRD и Google Cloud
- **Лицензия:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Карточка набора данных на HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Использование набора данных

Во избежание утечки данных при автоматическом сканировании мы не включаем эталонные SQL-решения и тестовые случаи вместе с данными.
пожалуйста, напишите на [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) с тегом `[bird-interact-lite GT&Test Cases]` в теме письма для получения полного набора, который будет отправлен автоматически.


<!-- ### Используйте набор данных с HuggingFace

Вы можете скачать набор данных с HuggingFace, используя следующую команду:
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
Подробная информация о запуске **a-interact** доступна в `./bird_interact_agent/README.md`; а о **c-interact** — в `./bird_interact_conv/README.md`.

## 📋 Списки задач

- [x] Выпустить облегчённую версию, bird-interact-lite (270).
- [x] Выпустить разговорную версию, bird-interact-conv.
- [x] Выпустить версию агента, bird-interact-agent.
- [x] Выпустить полную версию, bird-interact-full (600).
- [ ] SFT / RL симулятор пользователя

## Создано:
Команда BIRD и Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---