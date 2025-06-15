# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Если вам нравится наш проект, пожалуйста, поставьте нам звезду ⭐ на GitHub, чтобы получать последние обновления.</h5>
**MemoryOS** разработан для предоставления операционной системы памяти для персонализированных AI-агентов, обеспечивая более последовательные, персонализированные и контекстно-осознанные взаимодействия. Вдохновленный принципами управления памятью в операционных системах, он использует иерархическую архитектуру хранения с четырьмя основными модулями: Хранение, Обновление, Извлечение и Генерация, для достижения комплексного и эффективного управления памятью. На бенчмарке LoCoMo модель достигла средних улучшений **49.11%** и **46.18%** по метрикам F1 и BLEU-1 соответственно.







## 📣 Последние новости
*   *<mark>[new]</mark>* 🔥  **[2025-06-15]**:🛠️ Выпущен открытый исходный код **MemoryOS-MCP**! Теперь доступна настройка на клиентских агентах для бесшовной интеграции и кастомизации. [👉 Подробнее](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Выпущена начальная версия **MemoryOS**! Включает краткосрочную, среднесрочную и долгосрочную память персонажа с автоматическим обновлением профиля пользователя и знаний.

## Демонстрация
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Архитектура системы
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Структура проекта

```
memoryos/
├── __init__.py            # Инициализация пакета MemoryOS
├── __pycache__/           # Каталог кэша Python (создается автоматически)
├── long_term.py           # Управление долгосрочной памятью персонажа (профиль пользователя, знания)
├── memoryos.py            # Главный класс MemoryOS, координирует все компоненты
├── mid_term.py            # Управление среднесрочной памятью, консолидация краткосрочных взаимодействий
├── prompts.py             # Содержит подсказки для взаимодействия с LLM (например, суммаризация, анализ)
├── retriever.py           # Извлекает релевантную информацию из всех слоев памяти
├── short_term.py          # Управление краткосрочной памятью для недавних взаимодействий
├── updater.py             # Обрабатывает обновления памяти, включая продвижение информации между слоями
└── utils.py               # Вспомогательные функции, используемые в библиотеке
```

## Как это работает

1.  **Инициализация:** `Memoryos` инициализируется с идентификаторами пользователя и ассистента, API-ключами, путями к хранилищу данных и различными параметрами емкости/порогов. Для каждого пользователя и ассистента создается отдельное хранилище.
2.  **Добавление воспоминаний:** Вводы пользователя и ответы агента добавляются как пары вопрос-ответ. Изначально они сохраняются в краткосрочной памяти.
3.  **Обработка от краткосрочной к среднесрочной памяти:** Когда краткосрочная память заполняется, модуль `Updater` обрабатывает эти взаимодействия, объединяя их в значимые сегменты и сохраняя в среднесрочной памяти.
4.  **Анализ среднесрочной памяти и обновление LPM:** Сегменты среднесрочной памяти накапливают "накал" (heat) на основе частоты обращений и длительности взаимодействий. Когда накал сегмента превышает порог, его содержимое анализируется:
    *   Инсайты профиля пользователя извлекаются и используются для обновления долгосрочного профиля пользователя.
    *   Конкретные факты о пользователе добавляются в долгосрочные знания пользователя.
    *   Релевантная информация для ассистента добавляется в долгосрочную базу знаний ассистента.
5.  **Генерация ответа:** При поступлении запроса пользователя:
    *   Модуль `Retriever` извлекает релевантный контекст из краткосрочной истории, сегментов среднесрочной памяти, профиля и знаний пользователя, а также базы знаний ассистента.
    *   Этот комплексный контекст, вместе с запросом пользователя, используется для генерации связного и информативного ответа с помощью LLM.

## Быстрый старт MemoryOS_PYPI

### Необходимые условия

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Установка

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Базовое использование

```python

import os
from memoryos import Memoryos

# --- Базовая конфигурация ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Замените на ваш ключ
BASE_URL = ""  # Необязательно: если используется кастомный OpenAI endpoint
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Простая Демонстрация")
    
    # 1. Инициализация MemoryOS
    print("Инициализация MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS успешно инициализирован!\n")
    except Exception as e:
        print(f"Ошибка: {e}")
        return

    # 2. Добавление базовых воспоминаний
    print("Добавление воспоминаний...")
    
    memo.add_memory(
        user_input="Привет! Я Том, работаю дата-сайентистом в Сан-Франциско.",
        agent_response="Привет, Том! Приятно познакомиться. Data Science — очень захватывающая область. С какими данными ты работаешь?"
    )
     
    test_query = "Что ты помнишь о моей работе?"
    print(f"Пользователь: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Ассистент: {response}")

if __name__ == "__main__":
    simple_demo()
```
## Быстрый старт MemoryOS-MCP
### 🔧 Основные инструменты

#### 1. `add_memory`
Сохраняет содержимое диалога между пользователем и AI-ассистентом в системе памяти для построения постоянной истории диалогов и контекстной записи.

#### 2. `retrieve_memory`
Извлекает связанные исторические диалоги, пользовательские предпочтения и знания из системы памяти на основе запроса, помогая AI-ассистенту понять потребности и бэкграунд пользователя.

#### 3. `get_user_profile`
Получает профиль пользователя, сформированный на основе анализа истории диалогов, включая черты личности, интересы и релевантные знания.


### 1. Установите зависимости
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Конфигурация

Редактируйте файл `config.json`：
```json
{
  "user_id": "ваш_пользовательский_ID",
  "openai_api_key": "ваш_OpenAI_API_ключ",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Запуск сервера
```bash
python server_new.py --config config.json
```
### 4. Тестирование
```bash
python test_comprehensive.py
```
### 5. Настройка на Cline и других клиентах
Скопируйте файл mcp.json и убедитесь, что путь к файлу указан верно.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Замените на интерпретатор Python вашей виртуальной среды
```
## Вклад в проект

Вклады приветствуются! Не стесняйтесь отправлять issues или pull requests.

## Цитирование
Если вы хотите узнать больше подробностей, пожалуйста, перейдите по ссылке: [Читать полную статью](https://arxiv.org/abs/2506.06326)

Если этот проект оказался для вас полезным, пожалуйста, процитируйте нашу статью:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Связаться с нами
百家AI — это исследовательская группа под руководством доцента Бай Тин из Пекинского университета почтовой и телекоммуникационной связи, посвящённая созданию для кремниевых людей мозга, наполненного эмоциями и обладающего выдающейся памятью.<br>
Сотрудничество и предложения: baiting@bupt.edu.cn<br>
Добро пожаловать в официальный аккаунт 百家Agent в WeChat и нашу группу в WeChat для совместного общения!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="Официальный аккаунт 百家Agent в WeChat" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="QR-код группы WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---