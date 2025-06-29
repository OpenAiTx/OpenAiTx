![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Преобразуйте любой репозиторий GitHub в готовый к производству Docker-контейнер с помощью генерации Dockerfile на базе искусственного интеллекта.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer — это веб-приложение на базе искусственного интеллекта, которое автоматически генерирует готовые к продакшну Dockerfile, анализируя репозитории GitHub. Просто вставьте ссылку на репозиторий GitHub и получите индивидуальный Dockerfile с интеллектуальным выбором базового образа, управлением зависимостями и соблюдением лучших практик Docker.

## 🌟 Быстрый доступ

Просто замените `github.com` на `gitcontainer.com` в любой ссылке на репозиторий GitHub, чтобы мгновенно перейти на страницу генерации Dockerfile для этого репозитория.

Например:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Возможности

- **🔄 Мгновенный доступ по URL**: Просто замените 'github.com' на 'gitcontainer.com' в любом URL GitHub
- **🤖 Анализ на базе ИИ**: Использует OpenAI GPT-4 для анализа структуры репозитория и генерации интеллектуальных Dockerfile
- **⚡ Потоковая генерация в реальном времени**: Наблюдайте за процессом генерации Dockerfile в реальном времени через WebSocket
- **🎯 Умное определение стека**: Автоматически определяет технологический стек (Python, Node.js, Java, Go и др.)
- **🔧 Готов к продакшну**: Генерирует Dockerfile с соблюдением лучших практик — безопасность, multi-stage сборки и оптимизация
- **📋 Дополнительные инструкции**: Возможность добавления пользовательских требований для специализированных окружений
- **📄 Docker Compose**: Автоматически предлагает docker-compose.yml для сложных приложений
- **🎨 Современный UI**: Чистый, отзывчивый интерфейс с редактором Monaco и подсветкой синтаксиса
- **📱 Поддержка мобильных устройств**: Корректная работа на десктопах и мобильных устройствах

## 🚀 Быстрый старт

### Предварительные требования

- Python 3.9 или выше
- Git
- Ключ OpenAI API

### Установка

1. **Клонируйте репозиторий:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Установите зависимости:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Настройте переменные окружения:**
   ```bash
   # Создайте файл .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Запустите приложение:**
   ```bash
   python app.py
   ```

5. **Откройте браузер:**
   Перейдите по адресу `http://localhost:8000`

## 🛠️ Как это работает

1. **Обработка URL**: Откройте любой репозиторий, заменив 'github.com' на 'gitcontainer.com' в ссылке
2. **Клонирование репозитория**: Gitcontainer клонирует репозиторий GitHub локально с помощью Git
3. **Анализ кода**: Использует [gitingest](https://github.com/cyclotruc/gitingest) для анализа структуры репозитория и извлечения информации
4. **Генерация на базе ИИ**: Отправляет анализ в OpenAI GPT-4 со специальными запросами для генерации Dockerfile
5. **Умная оптимизация**: ИИ учитывает:
   - Определение технологического стека
   - Управление зависимостями
   - Лучшие практики безопасности
   - Многоэтапные сборки (multi-stage), если это выгодно
   - Настройку портов
   - Переменные окружения
   - Health-check команды

## 📁 Структура проекта

```
cyclotruc-gitcontainer/
├── app.py                 # Основное приложение FastAPI
├── requirements.txt       # Python-зависимости
├── .env                  # Переменные окружения (создайте этот файл)
├── static/               # Статические ресурсы (иконки, CSS)
├── templates/
│   └── index.jinja       # Основной HTML-шаблон
└── tools/                # Модули основной функциональности
    ├── __init__.py
    ├── create_container.py  # Генерация Dockerfile на базе ИИ
    ├── git_operations.py    # Клонирование репозиториев GitHub
    └── gitingest.py        # Анализ репозитория
```
## 🔧 Конфигурация

### Переменные окружения

| Переменная | Описание | Обязательно |
|------------|----------|-------------|
| `OPENAI_API_KEY` | Ваш API-ключ OpenAI | Да |
| `PORT` | Порт сервера (по умолчанию: 8000) | Нет |
| `HOST` | Хост сервера (по умолчанию: 0.0.0.0) | Нет |

### Расширенное использование

Вы можете использовать инструменты программно:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Клонировать репозиторий
    clone_result = await clone_repo_tool(github_url)
    
    # Анализировать с помощью gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Сгенерировать Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Использование
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Кастомизация

### Добавление пользовательских инструкций

Используйте функцию «Дополнительные инструкции» для настройки генерации:

- `"Использовать Alpine Linux для уменьшения размера образа"`
- `"Включить Redis и PostgreSQL"`
- `"Оптимизировать для продакшн-развертывания"`
- `"Добавить инструменты разработки для отладки"`

## 📝 Лицензия

Этот проект распространяется под лицензией MIT — см. файл [LICENSE](LICENSE) для подробностей.

## 🙏 Благодарности

- **[OpenAI](https://openai.com/)** за предоставление GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** за возможности анализа репозиториев
- **[FastAPI](https://fastapi.tiangolo.com/)** за отличный веб-фреймворк
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** за подсветку синтаксиса кода

## 🔗 Ссылки

- **Репозиторий на GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Демо**: Попробуйте вживую с примерными репозиториями
- **Issues**: [Сообщить об ошибках или предложить функции](https://github.com/cyclotruc/gitcontainer/issues)

---

**Сделано с любовью ❤️ [Romain Courtois](https://github.com/cyclotruc)**

*Преобразуйте любой репозиторий в контейнер за считанные секунды!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---