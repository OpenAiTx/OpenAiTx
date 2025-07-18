<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>Инженер-программист</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Last Commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Issues">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requests">
  </p>
</div>

Отобранная, высококачественная коллекция учебных материалов, ориентированных на **Python** и в будущем **C/C++**, предназначенная для формирования прочной базы в программной инженерии и понимания системного уровня.

## Структура репозитория

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## Как использовать

Каждая пронумерованная папка содержит файл `README.md`, объясняющий концепции, а также исполняемые файлы `.py`. Например:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
Некоторые скрипты требуют сторонних библиотек (например, `numpy`, `scipy`, `torch`).

Весь код совместим с **Python 3.7+** и написан так, чтобы быть **минималистичным, сфокусированным и тестируемым**.

## Основные особенности

### Python

- **Мастерство ООП**: Классы, наследование, метаклассы, дескрипторы (`python-OOP/`)
- **Продвинутые темы**: Декораторы, менеджеры контекста, кэширование функций, параллелизм
- **Структуры данных**: Списки, кортежи, словари, множества с практическим использованием

### C++

- **Основы C++**: Синтаксис, функции, указатели, структуры, области видимости, перечисления (`cpp-basic/`)
- **Современный C++**: RAII, умные указатели, семантика перемещения, выравнивание, RVO (`cpp-advanced/`)
- **ООП в C++**: Классы, спецификаторы доступа, наследование, полиморфизм, шаблоны

### Системы и производительность

- **Программирование CUDA**: Модель host/device, запуск ядер, управление памятью (`CUDA/`)
- **Программирование MPI**: Практические распределённые программы, операции с матрицами, проверки (`MPI/`)
- **Документация**: Интерфейс Python-C++, работа с GIL, тюнинг CUDA, обучение в смешанной точности (`docs/`)

## Философия обучения

- Маленькие, модульные примеры — никаких перегруженных ноутбуков
- Чёткое разделение концепции, кода и комментариев
- Акцент на дизайн, производительность и поддерживаемость
- Знания накапливаются поэтапно — идеально для серьёзных учащихся и профессионалов

## История звёзд

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 Вклад

Нашли ошибку, опечатку или хотите что-то расширить? Откройте PR — приветствуются любые вклады.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 Лицензия

Лицензия MIT — свободно используйте, адаптируйте и распространяйте для обучения и преподавания.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---