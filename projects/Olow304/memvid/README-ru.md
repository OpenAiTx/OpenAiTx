# Memvid - Видео-ориентированная AI-память 🧠📹

**Легковесное, революционное решение для масштабируемой AI-памяти**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid революционизирует управление AI-памятью, кодируя текстовые данные в видеофайлы, что позволяет осуществлять **молниеносный семантический поиск** по миллионам текстовых фрагментов с **временем отклика менее секунды**. В отличие от традиционных векторных баз данных, которые требуют огромного объема ОЗУ и хранилища, Memvid сжимает вашу базу знаний в компактные видеофайлы, сохраняя мгновенный доступ к любой информации.

## 🎥 Демонстрация

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Ключевые возможности

- 🎥 **Видео как база данных**: Храните миллионы текстовых фрагментов в одном MP4-файле
- 🔍 **Семантический поиск**: Находите релевантный контент с помощью естественно-языковых запросов
- 💬 **Встроенный чат**: Интерфейс для диалога с учетом контекста
- 📚 **Поддержка PDF**: Прямой импорт и индексация PDF-документов
- 🚀 **Быстрый поиск**: Поиск по огромным массивам данных за доли секунды
- 💾 **Эффективное хранение**: Сжатие в 10 раз по сравнению с традиционными БД
- 🔌 **Плагинные LLM**: Работа с OpenAI, Anthropic или локальными моделями
- 🌐 **Офлайн-режим**: Не требуется интернет после генерации видео
- 🔧 **Простой API**: Для старта нужно всего 3 строки кода

## 🎯 Сценарии использования

- **📖 Цифровые библиотеки**: Индексируйте тысячи книг в одном видеофайле
- **🎓 Образовательные материалы**: Создавайте искомую видео-память курсов
- **📰 Архивы новостей**: Сжимайте многолетние архивы в управляемые видеобазы
- **💼 Корпоративные знания**: Стройте базы знаний по всей компании с возможностью поиска
- **🔬 Научные публикации**: Быстрый семантический поиск по научной литературе
- **📝 Личные заметки**: Преобразуйте свои заметки в AI-ассистента с поиском

## 🚀 Почему Memvid?

### Революционные инновации
- **Видео как база данных**: Храните миллионы текстовых фрагментов в одном MP4-файле
- **Мгновенный доступ**: Семантический поиск по огромным данным менее чем за секунду
- **10-кратная экономия памяти**: Видео-сжатие радикально уменьшает объем хранения
- **Без инфраструктуры**: Нет серверов баз данных — только файлы, которые можно копировать куда угодно
- **Офлайн-режим**: Полностью офлайн после генерации видео

### Легковесная архитектура
- **Минимум зависимостей**: Основной функционал ~1000 строк Python
- **Дружелюбно к CPU**: Эффективная работа без необходимости в GPU
- **Портативность**: Вся база знаний — в одном видеофайле
- **Потоковое воспроизведение**: Видео можно стримить из облака

## 📦 Установка

### Быстрая установка
```bash
pip install memvid
```

### Для поддержки PDF
```bash
pip install memvid PyPDF2
```

### Рекомендуемая настройка (виртуальное окружение)
```bash
# Создать новый проект
mkdir my-memvid-project
cd my-memvid-project

# Создать виртуальное окружение
python -m venv venv

# Активировать окружение
# Для macOS/Linux:
source venv/bin/activate
# Для Windows:
venv\Scripts\activate

# Установить memvid
pip install memvid

# Для поддержки PDF:
pip install PyPDF2
```

## 🎯 Быстрый старт

### Базовое использование
```python
from memvid import MemvidEncoder, MemvidChat

# Создать видео-память из текстовых фрагментов
chunks = ["Важный факт 1", "Важный факт 2", "Детали исторического события"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Чат с вашей памятью
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Что ты знаешь об исторических событиях?")
print(response)
```

### Формирование памяти из документов
```python
from memvid import MemvidEncoder
import os

# Загрузка документов
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Добавить текстовые файлы
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Собрать оптимизированное видео
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Больше FPS = больше фрагментов в секунду
    frame_size=512  # Больше размер кадра = больше данных в кадре
)
```

### Продвинутый поиск и извлечение
```python
from memvid import MemvidRetriever

# Инициализация поисковика
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Семантический поиск
results = retriever.search("алгоритмы машинного обучения", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# Получить окно контекста
context = retriever.get_context("объясни нейронные сети", max_tokens=2000)
print(context)
```

### Интерактивный чат-интерфейс
```python
from memvid import MemvidInteractive

# Запустить интерактивный чат UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Откроет веб-интерфейс на http://localhost:7860
```

### Тестирование с file_chat.py
Скрипт `examples/file_chat.py` предоставляет комплексный способ тестирования Memvid с вашими документами:

```bash
# Обработка директории документов
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Обработка конкретных файлов
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Использование H.265-сжатия (требуется Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Индивидуальный разбиение для крупных документов
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Загрузка существующей памяти
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Полный пример: Чат с PDF-книгой
```bash
# 1. Создать новую директорию и настроить окружение
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Для Windows: venv\Scripts\activate

# 2. Установить зависимости
pip install memvid PyPDF2

# 3. Создать book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Ваш PDF-файл
book_pdf = "book.pdf"  # Замените на путь к вашему PDF

# Создать видео-память
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Чат с книгой
api_key = os.getenv("OPENAI_API_KEY")  # Необязательно: для AI-ответов
```python
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Запустите
export OPENAI_API_KEY="your-api-key"  # Необязательно
python book_chat.py
```

## 🛠️ Продвинутая настройка

### Пользовательские эмбеддинги
```python
from sentence_transformers import SentenceTransformer

# Используйте собственную модель эмбеддинга
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Оптимизация видео
```python
# Для максимального сжатия
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Больше кадров в секунду
    frame_size=256,  # Меньше размер кадров
    video_codec='h265',  # Лучшее сжатие
    crf=28  # Качество сжатия (меньше = лучше качество)
)
```

### Распределённая обработка
```python
# Обработка больших наборов данных параллельно
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Поиск и устранение неисправностей

### Частые проблемы

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Убедитесь, что используете правильный Python
which python  # Должен показывать путь к вашему виртуальному окружению
# Если нет, активируйте виртуальное окружение:
source venv/bin/activate  # На Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**Проблемы с ключом LLM API**
```bash
# Установите ваш API-ключ (получить можно на https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Или на Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Обработка больших PDF**
```python
# Для очень больших PDF используйте меньший размер чанков
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Вклад

Мы приветствуем вклад! См. [Руководство по вкладу](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) для подробностей.

```bash
# Запуск тестов
pytest tests/

# Запуск с покрытием
pytest --cov=memvid tests/

# Форматирование кода
black memvid/
```

## 🆚 Сравнение с традиционными решениями

| Функция            | Memvid   | Векторные БД | Традиционные БД |
|--------------------|----------|--------------|-----------------|
| Эффективность хранения | ⭐⭐⭐⭐⭐   | ⭐⭐           | ⭐⭐⭐            |
| Сложность настройки   | Простая  | Сложная      | Сложная         |
| Семантический поиск   | ✅        | ✅            | ❌              |
| Оффлайн-использование | ✅        | ❌            | ✅              |
| Портативность         | Файловая | Серверная    | Серверная       |
| Масштабируемость      | Миллионы | Миллионы     | Миллиарды       |
| Стоимость            | Бесплатно | $$$$         | $$$             |


## 📚 Примеры

Посмотрите каталог [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) для:
- Построения памяти из дампов Википедии
- Создания персональной базы знаний
- Многоязычной поддержки
- Обновления памяти в реальном времени
- Интеграции с популярными LLM

## 🆘 Получить помощь

- 📖 [Документация](https://github.com/olow304/memvid/wiki) — Полные руководства
- 💬 [Обсуждения](https://github.com/olow304/memvid/discussions) — Задавайте вопросы
- 🐛 [Трекер проблем](https://github.com/olow304/memvid/issues) — Сообщайте об ошибках
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) — Делитесь своими проектами

## 🔗 Ссылки

- [Репозиторий GitHub](https://github.com/olow304/memvid)
- [Пакет PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Лицензия

MIT License — см. файл [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) для подробностей.

## 🙏 Благодарности

Создано [Olow304](https://github.com/olow304) и сообществом Memvid.

Создано с любовью с использованием:
- [sentence-transformers](https://www.sbert.net/) — передовые эмбеддинги для семантического поиска
- [OpenCV](https://opencv.org/) — компьютерное зрение и обработка видео
- [qrcode](https://github.com/lincolnloop/python-qrcode) — генерация QR-кодов
- [FAISS](https://github.com/facebookresearch/faiss) — эффективный поиск по сходству
- [PyPDF2](https://github.com/py-pdf/pypdf) — извлечение текста из PDF

Особая благодарность всем участникам, которые помогают делать Memvid лучше!

---

**Готовы изменить управление памятью ИИ? Установите Memvid и начните строить!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---