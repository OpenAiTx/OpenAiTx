
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Высокопроизводительный SQL-движок для запросов к CSV-файлам

 [![Кросс-сборка и тестирование (с помощью zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Легковесный, быстрый процессор SQL-запросов, написанный на C, который позволяет выполнять SQL-запросы непосредственно к CSV-файлам без необходимости в базе данных. Для полной документации смотрите каталог /doc.

 ![cq в работе](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Документация

- Быстрый старт: `doc/GettingStarted.md`
- Установка: `doc/Installation.md`
- Интерфейс командной строки: `doc/CLI.md`
- **TUI (Терминальный пользовательский интерфейс)**: `doc/TUI.md`
- Архитектура: `doc/Architecture.md`
- Тестирование: `doc/Testing.md`
- Дорожная карта: `doc/Roadmap.md`
- Вклад в проект: `doc/Contributing.md`

## Быстрый старт

Сборка: `make`

### Командная строка

Запустите пример запроса:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Терминальный UI

Запустите интерактивный TUI:
`./build/cqtui data/`

Возможности:
- Просмотр и открытие CSV-файлов как таблиц
- Интерактивное выполнение SQL-запросов
- Мультивкладочный интерфейс для нескольких таблиц
- Навигация с помощью клавиатуры
- Без внешних зависимостей

## Примеры SQL файлов

В репозитории есть примеры SQL в каталоге assets/ (example_between.sql, example_aggregation.sql и др.). Подробнее смотрите в assets/.

## Обзор данных и функций

- Смотрите папку /doc для подробных разделов о типах данных, форматах дат, формате CSV и многом другом.

## Лицензия

Лицензия MIT. Подробности см. в файле LICENSE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---