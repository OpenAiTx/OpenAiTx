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

## 🧸 Обзор

BIRD-INTERACT — это интерактивный бенчмарк text-to-SQL, который **переосмысливает оценку Text-to-SQL через призму динамических взаимодействий**.
Среда объединяет иерархическую базу знаний, документацию базы данных и пользовательский симулятор, управляемый функциями, чтобы воссоздать аутентичные корпоративные среды для полного спектра операций **CRUD**.
Бенчмарк предлагает два строгих режима тестирования: (1) пассивный **Conversational Interaction** и (2) активный **Agentic Interaction**, охватывая 600 аннотированных задач, включая бизнес-аналитику (BI), операции CRUD и прочее, каждая из которых сопровождается исполняемыми тест-кейсами.
Типичные оценки инициируют от 1968 до 5496 интеракций между моделью и симулятором пользователя, в то время как современные модели рассуждения решают только **≈24%** и **≈18%** задач, что подчеркивает сложность этого бенчмарка.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Два режима оценки

BIRD-INTERACT поддерживает два режима оценки, как указано выше:

   - **c-Interact**: Conversational Interaction — пассивный режим с фиксированным рабочим процессом. Код и подробная информация находятся в `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction — воплощённый активный режим, где рабочий процесс динамический и управляется моделью. Код и подробная информация находятся в `bird_interact_agent`.


### 🐣 Лёгкая версия

Мы выпускаем лёгкую версию BIRD-INTERACT, `bird-interact-lite-exp`, которая включает 270 высококачественных задач из реального мира, специально для PostgreSQL. Это хорошая отправная точка для быстрых экспериментов.

### 🦜 Полная версия

Полная версия BIRD-INTERACT, `bird-interact-full`, — это комплексный бенчмарк, включающий 600 задач для PostgreSQL. Он охватывает широкий спектр SQL-операций и пользовательских запросов. Полная версия будет доступна скоро.

### Результаты производительности моделей на BIRD-INTERACT Lite

#### 1. **c-Interact** Производительность
| Место | Название модели    | Нормализованная награда | Уровень           |
|:------:|--------------------|:-------:|:-------------------:|
| 1    | o3-mini            | 33.04 | 🏆 Отличный чат      |
| 2    | GPT-4o             | 30.33 | 💎 Хороший чат       |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Хороший чат       |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Стандарт          |
| 5    | DeepSeek-R1        | 21.74 | ✨ Стандарт          |
| 6    | Qwen3              | 20.33 | ⚪ Базовый           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Базовый           |

#### 2. **a-Interact** Производительность
| Место | Название модели    | Бюджетные параметры* | Ср. ходов/задача | Ср. стоимость (USD)/задача | Нормализованная награда | Уровень                  |
|:------:|--------------------|:----------------------:|:-------------------:|:---------------------------:|:-------------------------:|:--------------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Отличное взаимодействие   |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 Хорошее взаимодействие    |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Хорошее взаимодействие    |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Стандарт                  |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Стандарт                  |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Базовый                   |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Базовый                   |

> \* Бюджетные параметры: Стартовый бюджет/Бюджет терпения пользователя, измеряется нашей виртуальной валютой *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Подробнее смотрите в [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Масштабирование по времени взаимодействия (ITS)

Масштабирование по времени взаимодействия (ITS) — это способность модели непрерывно увеличивать итоговую производительность за счёт многократных интеракций. Если эта интерактивная производительность превосходит идеализированную однократную производительность модели на полностью определённой, однозначной задаче, считается, что она удовлетворяет **закону ITS**. По мере роста терпения пользователя и накопления ходов производительность продолжает расти, что демонстрирует способность модели поддерживать эффективное общение в длительном диалоге. В настоящее время только claude-3-7-sonnet соответствует закону ITS.

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
   - `amb_user_query`: Пользовательский запрос с внедрёнными неоднозначностями.
   - `user_query_ambiguity`: Неоднозначности, внедрённые в пользовательский запрос.
   - `non_critical_ambiguity`: Некритичные неоднозначности, такие как порядок, лимит и т.д.
   - `knowledge_ambiguity`: Неоднозначности, созданные маскированными внешними знаниями.
   - `sol_sql`: Эталонное SQL-решение.
   - `preprocess_sql`: SQL-запросы, выполняемые до исполнения решения или предсказания.
   - `clean_up_sql`: SQL-запросы, выполняемые после тестовых случаев для возврата изменений в базе данных.
   - `test_cases`: Набор тестовых случаев для проверки предсказанного исправленного SQL.
   - `follow_up`: Помеченные последующие вопросы.
   - `external_knowledge`: Внешние знания, связанные с конкретной задачей.

- **evaluation:** Код для оценки доступен в каталоге [`./evaluation`](./evaluation).
- **Кураторы:** Команда BIRD и Google Cloud
- **Лицензия:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Карточка датасета HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Использование датасета

Во избежание утечки данных через автосбор, мы не включаем GT SQL-решения и тестовые случаи вместе с данными.
Пожалуйста, отправьте письмо на [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) с тегом `[bird-interact-lite GT&Test Cases]` в заголовке для получения полного набора, который будет отправлен автоматически.


<!-- ### Использование датасета с HuggingFace

Вы можете скачать датасет с HuggingFace с помощью следующей команды:
```bash
from datasets import load_dataset
# Загрузка облегчённой версии датасета
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Загрузка полной версии датасета (скоро будет доступна)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Или вы можете воспользоваться предоставленным скриптом для скачивания полной версии датасета и разделения его на разные диалекты.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Путь к входному JSONL-файлу (может быть пустым, если вы хотите скачать датасет с HuggingFace)
  --output_folder path/to/output_dir # папка для сохранения разделённых файлов
``` -->

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
Подробная информация о запуске **a-interact** находится в `./bird_interact_agent/README.md`; о запуске **c-interact** — в `./bird_interact_conv/README.md`.


## 📋 Списки задач

- [x] Выпустить облегчённую версию, bird-interact-lite (270).
- [x] Выпустить разговорную версию, bird-interact-conv.
- [x] Выпустить агентную версию, bird-interact-agent.
- [ ] Выпустить полную версию bird-interact-full (600).
- [ ] SFT / RL и симулятор пользователя

## Создано:
Команда BIRD и Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---