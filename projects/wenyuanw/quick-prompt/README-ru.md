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
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Логотип Быстрый Prompt" width="128" style="background: transparent;">
</p>

Мощное расширение для браузера, ориентированное на управление подсказками и быстрый ввод. Помогает пользователям создавать, управлять и организовывать библиотеку подсказок, а также быстро вставлять заранее заданный текст Prompt в любое поле ввода на веб-странице для повышения производительности.

> Поскольку расширение браузера может использоваться только на веб-платформе, был открыт исходный код аналогичного [плагина для Raycast](https://github.com/wenyuanw/quick-prompt-raycast), совместимого с форматом данных расширения браузера и поддерживающего бесшовную миграцию с помощью одного и того же JSON.

## ✨ Функциональные особенности

- 📚 **Управление подсказками**: Удобное создание, редактирование и управление вашей библиотекой подсказок
- 🚀 **Быстрый ввод**: В любом поле ввода на веб-странице быстро вызывайте селектор подсказок через `/p`
- ⌨️ Поддержка настройки горячих клавиш для открытия селектора подсказок и сохранения выделенного текста как подсказки
- 📑 Поддержка сохранения выделенного текста как подсказки через контекстное меню
- 🎯 Поддержка пользовательских подсказок, включая категории, заголовки, содержимое, теги и переменные
- 🧑‍💻 **Поддержка переменных**: В подсказках можно использовать переменные в формате `{{имя_переменной}}`, при использовании можно задать конкретное значение
- 💾 **Резервное копирование данных**: Поддержка экспорта и импорта библиотеки подсказок для удобной миграции и резервного копирования между устройствами
- 🔗 **Облачная синхронизация**: Поддержка синхронизации библиотеки подсказок с базой данных Notion или Gitee/GitHub Gist
- 🔍 Поддержка поиска и фильтрации подсказок
- 🌙 Автоматическая адаптация к светлой и тёмной теме системы

## 🚀 Как использовать

1. **Быстрый вызов**: В любом текстовом поле на веб-странице введите `/p` для вызова селектора подсказок
2. **Горячие клавиши для открытия селектора**: Используйте `Ctrl+Shift+P` (Windows/Linux) или `Command+Shift+P` (macOS) для открытия селектора подсказок
3. **Выбор подсказки**: В появившемся селекторе нажмите на нужную подсказку, она автоматически вставится в текущее поле ввода
4. **Быстрое сохранение подсказки**: После выделения любого текста используйте `Ctrl+Shift+S` (Windows/Linux) или `Command+Shift+S` (macOS) для быстрого сохранения в подсказки
5. **Сохранение через контекстное меню**: После выделения любого текста кликните правой кнопкой мыши и выберите "Сохранить как подсказку", чтобы добавить выделенное в подсказки
6. **Экспорт библиотеки подсказок**: На странице управления нажмите кнопку "Экспорт", чтобы сохранить все подсказки в файл JSON на локальный диск
7. **Импорт библиотеки подсказок**: На странице управления нажмите кнопку "Импорт" для загрузки подсказок из локального файла JSON (поддерживается объединение или перезапись текущих подсказок)

## 📸 Обзор интерфейса

Quick Prompt предоставляет интуитивно понятный и удобный интерфейс для управления и использования подсказок.

### Селектор подсказок

![Селектор подсказок](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Селектор подсказок](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Используйте быстрый ввод `/p` или горячие клавиши, чтобы в любом поле ввода быстро открыть селектор подсказок и удобно выбрать и вставить нужную подсказку.

### Страница управления подсказками

![Управление подсказками](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

На странице управления вы можете создавать новые подсказки, редактировать существующие, добавлять теги и управлять категориями. Интерфейс прост и понятен, работа удобна.

### Сохранение через контекстное меню

![Сохранение через контекстное меню](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Достаточно выделить любой текст на веб-странице и кликнуть правой кнопкой мыши, чтобы быстро сохранить его как подсказку и повысить эффективность работы.

### Ввод переменных для подсказки

![Всплывающее окно переменных подсказки](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Подсказки поддерживают настройку переменных, после выбора появляется всплывающее окно для ввода соответствующих значений.

## ⚙️ Настройка

1. Нажмите на иконку расширения, затем кликните на кнопку "Управление подсказками"
2. На странице управления вы можете:
   - Добавлять новые подсказки
   - Редактировать существующие подсказки
   - Удалять ненужные подсказки
   - Добавлять теги к подсказкам для классификации
   - Экспортировать базу подсказок для резервного копирования
   - Импортировать ранее сохранённую базу подсказок

## 📦 Инструкция по установке

### Установка из магазина приложений

Теперь доступно в Chrome Web Store! [Нажмите здесь для загрузки и установки](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Получение с GitHub Releases

1. Перейдите на [страницу GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Скачайте последнюю версию готового пакета расширения
3. Распакуйте загруженный файл
4. Установите собранное расширение, следуя инструкции ниже

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
4. Выберите каталог `.output/chrome-mv3/` вашего проекта

#### Firefox
1. Откройте `about:debugging`
2. Нажмите "Этот Firefox"
3. Нажмите "Временно загрузить дополнение"
4. Выберите файл `manifest.json` в каталоге `.output/firefox-mv2/` вашего проекта

## 📄 Лицензия

MIT

## 🤝 Руководство по вкладу

Мы приветствуем Pull Requests и Issues!

1. Сделайте Fork этого репозитория
2. Создайте свою ветку с функцией (`git checkout -b feature/amazing-feature`)
3. Зафиксируйте свои изменения (`git commit -m 'Add some amazing feature'`)
4. Отправьте ветку (`git push origin feature/amazing-feature`)
5. Откройте Pull Request

## 👏 Список вкладчиков

Благодарим всех разработчиков, внесших вклад в проект!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---