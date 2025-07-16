# Быстрый Prompt

<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Мощное расширение для браузера, предназначенное для управления подсказками и быстрого ввода. Помогает пользователям создавать, управлять и организовывать библиотеку подсказок, а также быстро вставлять предустановленные Prompt в любые поля ввода на веб-страницах, повышая эффективность работы.

> Поскольку расширение браузера работает только на веб-страницах, был открыт исходный код [плагина Raycast](https://github.com/wenyuanw/quick-prompt-raycast) с аналогичной функциональностью, совместимого с форматом данных браузерного расширения, с поддержкой бесшовной миграции по одному и тому же JSON.

## ✨ Основные функции

- 📚 **Управление подсказками**: удобно создавать, редактировать и управлять своей библиотекой подсказок
- 🚀 **Быстрый ввод**: быстро вызывать селектор подсказок в любом поле ввода с помощью `/p`
- ⌨️ Поддержка настройки горячих клавиш для открытия селектора подсказок и сохранения выделенного текста в виде подсказки
- 📑 Поддержка сохранения выделенного текста как подсказки через контекстное меню (ПКМ)
- 🎯 Поддержка пользовательских подсказок: категории, заголовки, содержимое, теги и переменные
- 🧑‍💻 **Поддержка переменных**: в подсказках можно использовать переменные в формате `{{имя_переменной}}`, при использовании вводится конкретное значение
- 💾 **Резервное копирование данных**: поддержка экспорта и импорта библиотеки подсказок для удобства миграции и резервного копирования между устройствами
- 🔗 **Синхронизация с Notion**: поддержка синхронизации библиотеки подсказок с базой данных Notion
- 🔍 Поддержка поиска и фильтрации подсказок
- 🌙 Автоматическое определение светлой/тёмной темы системы

## ⚠️ Известные проблемы

- На сайте doubao.com при использовании `/p` для вызова селектора подсказок в некоторых полях ввода может не очищаться `/p`. Не волнуйтесь, я и мой старый напарник Cursor работаем денно и нощно над решением этой проблемы и постараемся исправить её как можно скорее!

## 🚀 Как пользоваться

1. **Быстрый вызов**: в любом текстовом поле веб-страницы введите `/p` для вызова селектора подсказок
2. **Открытие селектора по горячим клавишам**: используйте `Ctrl+Shift+P` (Windows/Linux) или `Command+Shift+P` (macOS) для открытия селектора подсказок
3. **Выбор подсказки**: выберите нужную подсказку из появившегося селектора, и она автоматически вставится в текущее поле ввода
4. **Быстрое сохранение подсказки**: выделите любой текст и используйте `Ctrl+Shift+S` (Windows/Linux) или `Command+Shift+S` (macOS) для быстрого сохранения как подсказки
5. **Сохранение через ПКМ**: выделите любой текст, кликните правой кнопкой мыши и выберите "Сохранить подсказку", чтобы сохранить выделенное как подсказку
6. **Экспорт библиотеки подсказок**: на странице управления нажмите кнопку "Экспорт", чтобы сохранить все подсказки в файл JSON на устройство
7. **Импорт библиотеки подсказок**: на странице управления нажмите "Импорт" и загрузите подсказки из локального файла JSON (поддерживается объединение или замена существующих подсказок)

## 📸 Интерфейс

Quick Prompt предлагает интуитивно понятный и удобный пользовательский интерфейс для легкого управления и использования подсказок.

### Селектор подсказок

![Селектор подсказок](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Селектор подсказок](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Используйте быстрый ввод `/p` или горячие клавиши для быстрого вызова селектора подсказок в любом поле ввода, чтобы легко выбрать и вставить нужную подсказку.

### Страница управления подсказками

![Управление подсказками](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

На странице управления можно создавать новые подсказки, редактировать существующие, добавлять теги и управлять категориями. Интерфейс лаконичен и удобен.

### Сохранение через ПКМ

![Сохранение через ПКМ](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Достаточно выделить любой текст на веб-странице, затем кликнуть правой кнопкой мыши — и быстро сохранить его как подсказку, повышая эффективность работы.

### Ввод переменных подсказки

![Окно переменных подсказки](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Подсказки поддерживают переменные: после выбора откроется окно для ввода значений переменных.

## ⚙️ Индивидуальные настройки

1. Нажмите на иконку расширения, затем кнопку "Управление подсказками"
2. На странице управления вы можете:
   - Добавлять новые подсказки
   - Редактировать существующие подсказки
   - Удалять ненужные подсказки
   - Добавлять теги к подсказкам для их классификации
   - Экспортировать библиотеку подсказок для резервного копирования
   - Импортировать ранее сохранённую библиотеку подсказок

## 📦 Инструкция по установке

### Установка из магазина приложений

Теперь доступно в магазине Chrome! [Нажмите здесь для скачивания и установки](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Получение с GitHub Releases

1. Перейдите на [страницу GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Скачайте последнюю версию готового плагина
3. Распакуйте скачанный файл
4. Установите собранное расширение согласно инструкциям ниже

### Сборка из исходного кода

1. Клонируйте репозиторий
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Установка зависимостей
   ```bash
   pnpm install
   ```
3. Разработка и сборка

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Установка собранного расширения

#### Chrome / Edge
1. Откройте страницу управления расширениями (`chrome://extensions` или `edge://extensions`)
2. Включите "Режим разработчика"
3. Нажмите "Загрузить распакованное расширение"
4. Выберите каталог `.output/chrome-mv3/` проекта

#### Firefox
1. Откройте `about:debugging`
2. Нажмите "Этот Firefox"
3. Нажмите "Временная загрузка дополнения"
4. Выберите файл `manifest.json` в каталоге `.output/firefox-mv2/` проекта

## 📄 Лицензия

MIT

## 🤝 Руководство по вкладу

Pull Requests и Issues приветствуются!

1. Сделайте Fork этого репозитория
2. Создайте свою ветку с функцией (`git checkout -b feature/amazing-feature`)
3. Зафиксируйте изменения (`git commit -m 'Add some amazing feature'`)
4. Запушьте ветку (`git push origin feature/amazing-feature`)
5. Откройте Pull Request

## 👏 Список участников

Благодарим всех разработчиков, внесших вклад в проект!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## История звезд

[![График истории звезд](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---