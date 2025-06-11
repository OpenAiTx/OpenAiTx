# Django Ninja Shortener - Сервис коротких ссылок, похожий на Bitly

Современный сервис коротких ссылок, созданный с помощью Django, Django Ninja и Tailwind CSS, вдохновлённый Bitly.

Пользователь может зарегистрироваться и войти в систему, чтобы сокращать ссылки и отслеживать количество переходов по каждой короткой ссылке.

В этом проекте используется [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) для автоматизации, см. [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Скриншоты интерфейса

Страница коротких ссылок (можно использовать без регистрации)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Если зарегистрироваться — можно отслеживать переходы

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Основные возможности

* **Аутентификация пользователей**: поддержка регистрации, входа и выхода.
* **Создание коротких ссылок**: авторизованный пользователь может создавать уникальные короткие ссылки для длинных URL.
* **Редирект коротких ссылок**: при переходе по короткой ссылке происходит перенаправление на исходный длинный URL.
* **Отслеживание переходов**: система автоматически считает количество переходов по каждой короткой ссылке.
* **Персональная панель**: пользователь может просматривать все свои короткие ссылки и статистику переходов.
* **RESTful API**: предоставляет API-эндпоинты для программного создания коротких ссылок.
* **Поддержка Docker**: имеются Dockerfile и настройки Docker Compose для упрощения разработки и развёртывания.

## 🛠️ Технологический стек

* **Бэкенд-фреймворк**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API-фреймворк**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend-стили**: [Tailwind CSS](https://tailwindcss.com/) (интеграция через `django-tailwind`)
* **База данных**:
  * Для разработки: SQLite (по умолчанию)
  * Для продакшена: легко заменить на PostgreSQL (настройки уже предусмотрены в `settings.py`)
* **Генерация коротких кодов**: используется `shortuuid`
* **Тестирование**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Контейнеризация**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Быстрый старт (с использованием Docker, рекомендовано)

Это наиболее рекомендуемый способ запуска, обеспечивающий одинаковую среду разработки.

**Шаги запуска:**

1. **Запуск сервисов:**

    Используйте Docker Compose для одновременного запуска всех сервисов.

    ```bash
    docker compose up --build
    ```

    Эта команда создаст Docker-образы, установит зависимости, выполнит миграции базы данных и запустит dev-сервер.

2. **Создание суперпользователя (опционально):**

    Для доступа к Django Admin выполните в отдельном терминале:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Доступ к приложению:**

    * **Главная страница сайта**: [http://localhost:8000](http://localhost:8000)

    * **Документация API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Локальная разработка (без Docker)

Если вы предпочитаете ручную настройку окружения.

**Требования:**

* Python 3.12
* Node.js и npm (для Tailwind CSS)

**Шаги настройки:**

1. **Создайте и активируйте виртуальное окружение:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # В Windows используйте `venv\Scripts\activate`
    ```

2. **Установите зависимости Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Установите и настройте Tailwind CSS:**

    `django-tailwind` выполнит основную часть настроек.

    ```bash
    python manage.py tailwind install
    ```

    Подробнее: [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Выполните миграции базы данных:**

    ```bash
    python manage.py migrate
    ```

5. **Создайте суперпользователя (опционально):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Запустите dev-сервер:**

    Необходимо одновременно запускать сервер Django и процесс компиляции Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    В другом терминале:

    ```bash
    python manage.py tailwind start
    ```

7. **Доступ к приложению:**

    * **Главная страница сайта**: [http://localhost:8000](http://localhost:8000)

    * **Документация API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Запуск тестов

В проекте используется `pytest` для тестирования и подсчёта покрытия.

План тестирования см. [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Запуск тестов в Docker:**

    ```bash
    docker compose --profile test up
    ```

    Отчёт о тестировании будет доступен в `htmlcov/index.html`.

* **Запуск тестов локально:**

    ```bash
    # Убедитесь, что установлены dev-зависимости
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API-эндпоинты

API предоставляет программный способ работы с сервисом коротких ссылок. Все API-эндпоинты находятся по адресу `/api/`.

Рекомендуется пользоваться **документацией API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Используйте [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), сначала вызовите `/api/token/pair` с вашим логином и паролем, чтобы получить token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Затем вставьте token в правый верхний угол — теперь можно вызывать API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Структура проекта

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Настройки Django-проекта
│   ├── settings.py
│   └── urls.py
├── shortener/            # Основное приложение коротких ссылок
│   ├── models.py         # Модели БД (Link)
│   ├── api.py            # Эндпоинты Django Ninja API
│   ├── views.py          # Представления и логика редиректа
│   └── utils.py          # Утилиты для генерации коротких кодов
└── theme/                # Django-тема и шаблоны
    ├── templates/        # HTML-шаблоны
    └── static_src/       # Исходники Tailwind CSS
```

## 💡 Планы на будущее

* **Переход на PostgreSQL**: для более надёжной БД в продакшене (уже реализовано)
* **Более подробная аналитика**: дополнительные данные по переходам — время, источник, геолокация и др.
* **Пользовательские короткие URL**: позволяет пользователям настраивать код короткого URL.
* **Генерация QR-кода**: для каждого короткого URL создаётся соответствующий QR-код.
* **Асинхронные задачи**: использование Celery для обработки ресурсоёмких задач, таких как анализ данных.

## Donation

Все статьи являются результатом моего собственного изучения и оригинальными, если они были вам полезны и вы хотите меня поддержать, буду рад, если угостите меня чашкой кофе :laughing:

ECPAY (не требуется регистрация)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Оплатить пожертвование](http://bit.ly/2F7Jrha)

O'Pay (требуется регистрация)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Оплатить пожертвование](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Список спонсоров

[Список спонсоров](https://github.com/twtrubiks/Thank-you-for-donate)

## Лицензия

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---