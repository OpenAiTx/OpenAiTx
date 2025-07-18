<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Примеры изображений

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Обязательно скачайте Последний Стабильный Релиз (LSR), а не последний/LFR! Текущий LSR: 2.4.9

`pip install winup==2.4.9`

**Крайне питоничный и мощный фреймворк для создания красивых десктопных приложений.**

WinUp — это современный UI-фреймворк для Python, который оборачивает возможности PySide6 (Qt) в простой, декларативный и дружелюбный к разработчику API. Он создан для того, чтобы ускорить создание приложений, сделать код чище и приносить удовольствие от разработки.

### ✨ Теперь с поддержкой Web!
WinUp теперь также поддерживает создание полностью интерактивных, управляемых состоянием веб-приложений с тем же подходом, ориентированным на Python и компоненты. Модуль web использует FastAPI и WebSockets для переноса простоты WinUp в браузер.

[Документация по Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Отказ от ответственности:** Веб-поддержка — опциональная функция. Чтобы её использовать, установите web-зависимости:
> ```bash
> pip install "winup[web]"
> ```

[Вклад в проект](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[История изменений](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Лицензия](LICENSE)

---

## Почему WinUp? (Вместо обычного PySide6 или Tkinter)

Разработка десктопных приложений на Python может быть неуклюжей. WinUp создан, чтобы это исправить.

| Функция                | WinUp Way ✨                                                                   | Обычный PySide6 / Tkinter 😟                                                         |
| ---------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| **Макеты**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`           |
| **Стилизация**         | `props={"background-color": "blue", "font-size": "16px"}`                      | Ручные QSS-строки, `widget.setStyleSheet(...)`, сложные объекты стилей.              |
| **Управление состоянием** | `state.bind(widget, "prop", "key")`                                         | Ручные функции обратного вызова, геттеры/сеттеры, `StringVar()`, шаблоны повсюду.    |
| **Двунаправленный биндинг** | `state.bind_two_way(input_widget, "key")`                                 | Не реализовано. Требуется ручная обработка `on_change` для обновления состояния и UI. |
| **Инструменты разработчика** | **Встроенный Hot Reloading**, профайлер кода и инструменты окна из коробки. | Не реализовано. Перезапуск приложения для каждой мелкой смены UI.                    |
| **Структура кода**     | Переиспользуемые, самостоятельные компоненты с `@component`.                   | Обычно приводит к большим, монолитным классам или процедурным скриптам.              |

**Проще говоря, WinUp приносит "убойные фичи" современных веб-фреймворков (как React или Vue) на десктоп, экономя ваше время и позволяя сосредоточиться на главном — логике приложения.**

# 🧊 WinUp vs 🧱 PyEdifice (По запросу пользователя Reddit)

| Функция                        | WinUp      | PyEdifice                        |
|--------------------------------|--------------------------------------|----------------------------------|
| 🧱 Архитектура                 | React-стиль + состояние              | React-стиль + состояние          |
| 🌐 Встроенный роутинг          | ✅ Да (`Router(routes={...})`)        | ❌ Нет встроенного роутинга       |
| ♻️ Хуки жизненного цикла       | ✅ `on_mount`, `on_unmount` и др.     | ⚠️ Ограничено (`did_mount` и др.)|
| 🎨 Темизация / система стилей   | ✅ Глобальные и локальные темы        | ❌ Ручное внедрение CSS           |
| 🔲 Варианты макетов            | ✅ Row, Column, Grid, Stack, Flexbox  | ⚠️ В основном Box и HBox/VBox     |
| 🎞️ Анимации                   | ✅ Встроенные (fade, scale и др.)     | ❌ Нет встроенных                 |
| 🔁 Горячая перезагрузка (LHR)  | ✅ Стабильная + быстрая (`loadup dev`)| ⚠️ Экспериментальная, ограниченно |
| 📦 Пакетирование               | ✅ Через LoadUp (на основе PyInstaller)| ❌ PyInstaller интегрируется вручную |
| 🧩 Переиспользование компонентов | ✅ Высокое, декларативное            | ✅ Высокое                        |

| 🛠 Инструменты для разработчиков      | ✅ DevTools в планах, Inspector скоро | ❌ Пока нет                         |
| 📱 Поддержка мобильных устройств      | ❌ Пока нет                           | ❌ Не поддерживается                |
| 🧠 Кривая обучения                    | ✅ Легко для пользователей Python+React | ✅ Легко, но меньше инструментов   |

> ✅ = Встроено или реализовано на высоком уровне  
> ⚠️ = Частично или ограничено  
> ❌ = Полностью отсутствует
---

## Основные возможности

*   **Декларативный и питонический UI:** Создавайте сложные интерфейсы с помощью простых объектов `Row` и `Column` вместо громоздких box-лейаутов.
*   **Архитектура на компонентах:** Используйте декоратор `@component` для создания модульных и переиспользуемых UI-виджетов из простых функций.
*   **Мощная система стилей:** Оформляйте виджеты с помощью простых Python-словарей через `props`. Создавайте глобальные "CSS-подобные" классы с помощью `style.add_style_dict`.
*   **Полноценная оболочка приложения:** Разрабатывайте профессиональные приложения с декларативным API для `MenuBar`, `ToolBar`, `StatusBar` и `SystemTrayIcon`.
*   **Асинхронный запуск задач:** Запускайте долгие операции в фоновом режиме без зависания UI с помощью простого декоратора `@tasks.run`.
*   **Производительность по умолчанию:** Включает опциональный декоратор `@memo` для кеширования рендеров компонентов и предотвращения лишних вычислений.
*   **Продвинутая расширяемость:**
    *   **Фабрика виджетов:** Заменяйте любой стандартный виджет своей собственной реализацией (например, на C++) с помощью `ui.register_widget()`.
    *   **Множественные окна:** Создавайте и управляйте несколькими независимыми окнами для сложных приложений, таких как палитры инструментов или музыкальные плееры.
*   **Реактивное управление состоянием:**
    *   **Одностороннее связывание:** Автоматически обновляйте UI при изменении данных через `state.bind()`.
    *   **Двустороннее связывание:** Легко синхронизируйте виджеты ввода с состоянием через `state.bind_two_way()`.
    *   **Подписки:** Запускайте любые функции в ответ на изменения состояния через `state.subscribe()`.
*   **Инструменты для разработчиков:**
    *   **Горячая перезагрузка:** Видите изменения в UI мгновенно без перезапуска приложения.
    *   **Профилировщик:** Легко измеряйте производительность любой функции с помощью декоратора `@profiler.measure()`.
    *   **Инструменты окна:** Центрируйте, мигаете или управляйте окном приложения с легкостью.
*   **Встроенный роутинг:** Легко создавайте многостраничные приложения с интуитивным роутером, управляемым состоянием.
*   **Гибкий слой данных:** Включает простые и единообразные коннекторы для SQLite, PostgreSQL, MySQL, MongoDB и Firebase.

---

# Документация

Узнайте больше о возможностях WinUp:

## Основные концепции
- [**Модель компонентов и стилизация**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Управление состоянием**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Жизненный цикл компонента**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Роутинг**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Абсолютное позиционирование (Advanced)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Инструменты разработчика
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Профилировщик производительности**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Мемоизация**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Асинхронный запуск задач**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI-компоненты
- [**Полная библиотека компонентов**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Вклад в проект

WinUp — это проект с открытым исходным кодом. Приветствуются любые вклады!

## Лицензия

Этот проект распространяется под лицензией MIT. Подробнее см. в файле **LICENSE**.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---