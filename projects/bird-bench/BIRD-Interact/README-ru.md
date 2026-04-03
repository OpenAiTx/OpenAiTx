
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
Пожалуйста, обратите внимание: перед началом процесса оценки при загрузке баз данных Docker могут периодически возникать ошибки из-за несоответствия среды (они не приведут к завершению процесса, но появятся в логах Docker). В результате некоторые базы данных могут не загрузиться корректно, что приведет к пустым базам данных. Это станет причиной аномально низких результатов оценки.  
👉 Поэтому мы настоятельно рекомендуем проверить логи Docker на наличие ошибок **до запуска оценки** и убедиться, что все базы данных были успешно загружены.

👉 Мы обновили **Правила подачи**, теперь поддерживаются пользовательские шаблоны агентов. Ознакомьтесь с подробными правилами подачи [здесь](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Новости

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: Мы выпустили **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)** — реализацию на базе Google ADK с модульной архитектурой из 3 микросервисов (агент, симулятор пользователя и среда DB). Легко заменяйте свой агент, симулятор пользователя или среду DB. Поддерживает параллельное выполнение и любого [LiteLlm-совместимого](https://docs.litellm.ai/docs/providers) LLM-провайдера. Рекомендуем использовать эту реализацию для ваших исследований.

- [2026-02-08] 🔥🔥🔥 Наша **[Bird-Interact статья](https://huggingface.co/papers/2510.05318)** принята на **ICLR 2026 (Oral)**! Увидимся в Рио 🇧🇷!  

- [2025-11-06] 🐛 **Исправление ошибки** & 🐳 **Обновление Docker**: Обновлена версия sqlglot до 26.16.4 для устранения ошибки некорректного парсинга SQL парсером для симулятора пользователя. Исправить это можно переустановкой через `pip install sqlglot==26.16.4` в среде `bird_interact_eval`. Также обновлен образ `bird_interact_eval`, вы можете загрузить его и пересоздать контейнер `bird_interact_eval`.

- [2025-10-21] 🐳 **Обновление Docker**: Мы добавили docker для полной среды DB. И загрузили 3 docker-образа (Base/Full DB Env и среда оценки для `a-Interact` и `c-Interact`) на Docker Hub для облегчения настройки среды. Не нужно скачивать дампы баз данных и собирать образы вручную!

- [2025-10-08] 📝 Наша **[Bird-Interact статья](https://huggingface.co/papers/2510.05318)** теперь доступна публично!  
  В ней представлены все детали, методология и оценка нашего интерактивного теста text-to-SQL.  
  👉 Ознакомьтесь с ней и узнайте больше об идеях [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Мы рады объявить о выпуске набора **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Это сложный набор — лучшие LLM показывают только **16.33%** успешных попыток, всего **10.0%** для частей `c-interact` и `a-interact`.  
👉 Для получения подробной информации, пожалуйста, посетите наш [сайт проекта](https://bird-interact.github.io/).

- [2025-08-26] 📬 На этой неделе мы отправим **Эталонные данные и тестовые кейсы** по нашей рассылке.  
Если вы хотите получить ранний доступ, отправьте письмо согласно инструкции на сайте для **автоматической загрузки**.  

- [2025-08-26] 💾 Кроме того, мы выпустили SQLite-версию **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** для упрощения локальных исследований.  
Полные версии **LiveSQLBench-Base** и **-Large** появятся скоро!

- [2025-08-22] **Исправление ошибки**: В коде Bird-Interact-Agent мы устранили ошибку, из-за которой при оценке phase-2 SQL сохранённый phase-1 SQL не мог быть успешно выполнен, что приводило к снижению успеха на этапе Phase-2. Эта ошибка затрагивала только те задачи, где phase1 sql выполняет операции с БД, например, CREATE table и т.д.

## 🧸 Обзор

BIRD-INTERACT — это интерактивный бенчмарк text-to-SQL, который **переосмысляет оценку Text-to-SQL через призму динамических взаимодействий**.
Среда объединяет иерархическую базу знаний, документацию по базе данных и пользовательский симулятор, управляемый функциями, чтобы воссоздать аутентичные корпоративные сценарии для всех операций **CRUD**.
Предлагается два строгих режима тестирования: (1) пассивное **Разговорное взаимодействие** и (2) активное **Агентное взаимодействие**, охватывающих 600 аннотированных заданий, включая BI, CRUD-операции и т.д., каждое из которых сопровождается исполняемыми тест-кейсами.
Типичная оценка инициирует 1 968–5 496 раундов взаимодействия между моделью и симулятором пользователя, а современные модели рассуждений решают только **≈24%** и **≈18%** задач, что подчеркивает сложность бенчмарка.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Два режима оценки

BIRD-INTERACT поддерживает два режима оценки, описанных выше:

   - **c-Interact**: Разговорное взаимодействие — это пассивный режим с фиксированным сценарием работы. Код и подробная информация находятся в `bird_interact_conv`.
   - **a-Interact**: Агентное взаимодействие — это воплощённый активный режим, где сценарий работы динамичен и определяется моделями. Код и подробная информация находятся в `bird_interact_agent`.


### 🐣 Лёгкая версия

Мы выпускаем облегчённую версию BIRD-INTERACT, `bird-interact-lite-exp`, которая включает 270 высококачественных реальных задач специально для PostgreSQL. Это хорошая отправная точка для быстрых экспериментов.

### 🦜 Полная версия

Полная версия BIRD-INTERACT, `bird-interact-full`, — это комплексный бенчмарк, включающий 600 заданий для PostgreSQL. Она охватывает широкий спектр SQL-операций и пользовательских запросов. Полная версия появится скоро.

### Результаты производительности моделей на BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Производительность
| Место | Название модели      | Нормализованная награда | Средняя стоимость (USD)/Задание | Уровень               |
|:-----:|:--------------------:|:-----------------------:|:-------------------------------:|:---------------------:|
| 1     | Gemini-2.5-Pro       | 20.92                   | $0.04                           | 🏆 Отличный чат       |
| 2     | O3-Mini              | 20.27                   | $0.07                           | 🏆 Отличный чат       |
| 3     | Claude-Sonnet-4      | 18.35                   | $0.29                           | 💎 Хороший чат        |
| 4     | Qwen-3-Coder-480B    | 17.75                   | $0.11                           | 💎 Хороший чат        |
| 5     | Deepseek-Chat-V3.1   | 15.15                   | $0.12                           | ✨ Стандарт           |
| 6     | Claude-Sonnet-3.7    | 13.87                   | $0.29                           | ✨ Стандарт           |
| 7     | GPT-5                | 12.58                   | $0.08                           | ⚪ Базовый            |

#### 2. **a-Interact Text-to-SQL** Производительность
| Место | Название модели      | Нормализованная награда | Средняя стоимость (USD)/Задание | Уровень                   |
|:-----:|:--------------------:|:-----------------------:|:-------------------------------:|:-------------------------:|
| 1     | GPT-5                | 25.52                   | $0.24                           | 🏆 Отличное взаимодействие|
| 2     | Claude-Sonnet-4      | 23.28                   | $0.51                           | 🏆 Отличное взаимодействие|
| 3     | Claude-Sonnet-3.7    | 17.45                   | $0.60                           | 💎 Хорошее взаимодействие |
| 4     | Gemini-2.5-Pro       | 17.33                   | $0.22                           | 💎 Хорошее взаимодействие |
| 5     | O3-Mini              | 16.43                   | $0.06                           | ✨ Стандарт               |
| 6     | Deepseek-Chat-V3.1   | 13.47                   | $0.06                           | ✨ Стандарт               |
| 7     | Qwen-3-Coder-480B    | 10.58                   | $0.07                           | ⚪ Базовый                |

> \* Параметры бюджета: стартовый бюджет/бюджет терпения пользователя, измеряемый нашей виртуальной валютой *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Подробнее см. в [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Масштабирование по времени взаимодействия (ITS)

Масштабирование по времени взаимодействия (ITS) означает способность модели непрерывно повышать итоговую производительность за счет многошагового взаимодействия. Если эта интерактивная производительность превосходит идеализированную однократную производительность модели на полностью определенной, недвусмысленной задаче, считается, что выполнен **закон ITS**. По мере увеличения терпения пользователя и числа шагов диалога, эффективность растет, что демонстрирует способность поддерживать эффективное общение на протяжении длительного диалога. В настоящее время только claude-3-7-sonnet соответствует закону ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Настройка окружения

1. Запустите Docker-контейнеры для базы данных bird-interact-lite, базы данных bird-interact-full и среды оценки:
  
  > Если вы хотите оценивать только на `bird-interact-lite`, можете закомментировать сервис [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) в `docker-compose.yml`, чтобы ускорить настройку окружения.
  
  Запустите окружение с помощью:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Подождите несколько минут для инициализации базы данных.
   
  Вы можете отслеживать прогресс создания с помощью:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Если всё завершено, вы должны увидеть журналы без ошибок, например:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Если вы уже создавали контейнеры ранее и хотите пересоздать их, вы можете выполнить следующую команду:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Это запускает 3 контейнера, используя предсозданные образы из Docker Hub:
   - `bird_interact_postgresql`: база данных PostgreSQL для bird-interact-lite
   - `bird_interact_postgresql_full`: база данных PostgreSQL для bird-interact-full
   - `bird_interact_eval`: среда оценки для `a-Interact` и `c-Interact`.

   Теперь вы можете запустить среду оценки, выполнив следующую команду:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Опционально) Соберите окружение вручную (если хотите создать образы с нуля): 
   - Скачайте дампы базы данных 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Распакуйте и переименуйте в `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Распакуйте и переименуйте в `env/postgre_table_dumps_full`.
   - Соберите окружение вручную, запустив `docker-compose.build.yml`.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Рекомендуется) Проверьте, что контейнеры базы данных собраны и успешно запущены.

-  Выведите журналы сборки контейнеров, чтобы убедиться, что базы данных собраны успешно без ошибок:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Если возникают ошибки, в файлах журнала будет выведено `"Errors occurred during import:"`.


-  Проверьте состояние контейнеров базы данных.
   
   Используйте предоставленный нами скрипт на Python для проверки метаданных базы данных:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Ожидаемые результаты:
   - **bird-interact-lite**: 
     - 📈 Всего баз данных: 18
     - 📋 Всего таблиц: 175
     - 🔢 Всего столбцов: 2286
     - 📈 Среднее количество строк на таблицу: 1,038.48
     - 💾 Общий размер: 207.15 МБ (приблизительно)
   - **bird-interact-full**: 
     - 📈 Всего баз данных: 22
     - 📋 Всего таблиц: 244
     - 🔢 Всего столбцов: 2011
     - 📈 Среднее количество строк на таблицу: 1,121.19
     - 💾 Общий размер: 272.00 МБ (приблизительно)


## 📦 Подробности о наборе данных

### Описание набора данных

- **База данных:** Полную базу данных PostgreSQL можно скачать с [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) и [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Каждый экземпляр данных содержит следующие основные части:
   - `selected_database`: Имя базы данных.  
   - `query`: Однозначный пользовательский запрос.  
   - `amb_user_query`: Запрос пользователя с внедрёнными неоднозначностями.
   - `user_query_ambiguity`: Неоднозначности, внедрённые в пользовательский запрос.
   - `non_critical_ambiguity`: Некритические неоднозначности, такие как порядок, лимит и др.
   - `knowledge_ambiguity`: Неоднозначности, созданные маскировкой внешних знаний. 
   - `sol_sql`: Эталонное SQL-решение.  
   - `preprocess_sql`: SQL-запросы, которые выполняются перед запуском решения или предсказания.  
   - `clean_up_sql`: SQL-запросы, выполняемые после тестовых случаев для отката изменений в базе данных.  
   - `test_cases`: Набор тестовых случаев для проверки предсказанного исправленного SQL.
   - `follow_up`: Пронумерованные уточняющие вопросы.
   - `external_knowledge`: Внешние знания, связанные с конкретной задачей.

- **оценка:** Код для оценки доступен в каталоге [`./evaluation`](./evaluation).
- **Куратор:** Команда BIRD и Google Cloud
- **Лицензия:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Карта набора данных HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  и [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) для PostgreSQL; и [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) для SQLite.
### Использование набора данных

Чтобы избежать утечки данных при автоматическом сканировании, мы не включаем эталонные SQL-решения и тестовые примеры вместе с данными.
Пожалуйста, отправьте письмо на [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) с тегом `[bird-interact-lite GT&Test Cases]` или `[bird-interact-full GT&Test Cases]` в заголовке для получения эталонных ответов и тестовых примеров для наборов данных bird-interact-lite или bird-interact-full, которые будут высланы автоматически.

### Объединение публичных данных с эталонными ответами и тестовыми примерами

Затем используйте следующий скрипт для объединения публичных данных с эталонными ответами и тестовыми примерами:

В качестве примера возьмём полную версию:
(1) Выполните:

```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Это создаст новый файл по адресу `/path/to/bird_interact_data.jsonl` с объединёнными данными.

(2) Затем замените исходные общедоступные данные на объединённые данные:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

То же самое для других версий: bird-interact-lite, мини-версия и т.д. Просто укажите правильные пути к открытым данным, эталонным данным и тестовым случаям, а затем замените открытые данные на объединенные данные.




<!-- ### Использование набора данных с HuggingFace

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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
Подробная информация о запуске **a-interact** находится в `./bird_interact_agent/README.md`; о **c-interact** — в `./bird_interact_conv/README.md`; а **реализация на основе ADK** доступна в `./BIRD-Interact-ADK/README.md`.

## 📋 Списки задач

- [x] Выпустить облегчённую версию, bird-interact-lite (270).
- [x] Выпустить разговорную версию, bird-interact-conv.
- [x] Выпустить версию агента, bird-interact-agent.
- [x] Выпустить полную версию bird-interact-full (600).
- [x] Выпустить реализацию на основе ADK, BIRD-Interact-ADK.
- [ ] SFT / RL пользовательский симулятор

## Благодарности
Мы выражаем искреннюю благодарность **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** и профессору **Shinji Watanabe** за их плодотворные обсуждения и ценные идеи, которые помогли улучшить этот проект.

## Создатели:
Команда BIRD & Google Cloud







## Цитирование

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```
## Журнал изменений

- [2025-11-06] 🐛 **Исправление ошибки** & 🐳 **Обновление Docker**: Обновлена версия sqlglot до 26.16.4 для устранения ошибки, из-за которой SQL-парсер не может корректно разбирать SQL для симулятора пользователя. Вы можете исправить это, переустановив пакет с помощью `pip install sqlglot==26.16.4` в окружении `bird_interact_eval`. Также обновлен образ `bird_interact_eval`, поэтому вы можете просто скачать его и пересоздать контейнер `bird_interact_eval`.
- [2025-10-21] 🐳 **Обновление Docker**: Добавлен docker для полной среды базы данных. Мы загрузили 3 docker-образа (Базовая/Полная среда БД и среда оценки для `a-Interact` и `c-Interact`) на Docker Hub для упрощения настройки среды. Больше не нужно скачивать дампы БД и собирать образы вручную! Просто скачайте последние образы с Docker Hub и пересоздайте контейнеры, например, с помощью `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Исправление ошибки**: Исправлена ошибка, при которой при оценке SQL второго этапа сохранённый SQL первого этапа не может быть успешно выполнен, что приводило к снижению процента успешности второго этапа. Эта ошибка затрагивала только те задания, где SQL первого этапа выполняет операции с базой данных, например, CREATE table и др.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---