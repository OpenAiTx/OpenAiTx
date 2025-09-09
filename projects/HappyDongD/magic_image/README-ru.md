
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Магическая AI-рисовалка

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Приложение для AI-рисования, разработанное на основе Next.js, с основными функциями:
- 🎨 Поддержка различных AI-моделей (Sora, DALL-E, GPT, GEMINI и др.), а также добавление пользовательских моделей
- 🖼️ Предоставляет функции генерации изображений по тексту и по изображению, поддерживает многократные ссылки и редактирование областей
- 🔐 Все данные и API-ключи хранятся локально, обеспечивая безопасность и конфиденциальность
- 💻 Поддержка веб-версии и десктопной упаковки приложения, кроссплатформенность

## Онлайн-демонстрация

Ссылка для доступа: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Скриншоты приложения

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Скриншот приложения 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Скриншот приложения 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Скриншот приложения 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Скриншот приложения 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Скриншот приложения 3" width="800" style="margin-bottom: 20px"/>
</div>

## Особенности

- 🎨 Поддержка множества AI-моделей
  - Модель GPT Sora_Image
  - Модель GPT 4o_Image
  - Модель GPT Image 1
  - Модель DALL-E 3
  - Модель GEMINI
  - 🆕 Пользовательские модели (поддержка добавления приватных моделей)
- 🔄 Переключение между моделями
  - Быстрое переключение между разными моделями
  - Для каждой модели доступны отдельные параметры настройки
- ✍️ Генерация изображений по тексту
  - Поддержка пользовательских подсказок
  - Возможность выбора соотношения сторон изображения
  - Поддержка различных размеров изображений
- 🖼️ Генерация изображений по изображению
  - Поддержка редактирования изображений
  - Поддержка редактирования маски областей
  - Поддержка регулировки качества изображения
  - Поддержка множественных изображений для ссылки (одновременная загрузка нескольких картинок)
- 🔒 Безопасность данных
  - Все сгенерированные изображения и история сохраняются только в локальном браузере
  - Поддержка настройки собственного адреса API-прокси
  - Поддержка конфигурации API-ключа
- 📱 Дизайн интерфейса
  - Современный пользовательский интерфейс
  - Плавный опыт взаимодействия
  - Отображение в формате Markdown
  - Поддержка подсветки кода
- 🖥️ Кроссплатформенная поддержка
  - Возможность сборки в настольное приложение (Windows, macOS, Linux)
  - Поддержка офлайн-использования (требуется настройка API-интерфейса)

## Технологический стек

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (упаковка настольных приложений)

## Локальная разработка

1. Клонируйте проект
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Установка зависимостей

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Запуск сервера разработки

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. 访问 [http://localhost:3000](http://localhost:3000)

## Упаковка настольного приложения

В этом проекте используется Tauri для упаковки настольных приложений, поддерживаются системы Windows, macOS и Linux.

### Подготовка среды

Перед упаковкой настольного приложения необходимо установить следующие зависимости:

1. **Установка Rust**:
   - Перейдите по ссылке [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Следуйте инструкциям для установки Rust и Cargo

2. **Системные зависимости**:
   - **Windows**: Установите [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Установите инструменты командной строки Xcode (`xcode-select --install`)
   - **Linux**: Установите соответствующие зависимости, подробнее см. [документацию Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Режим разработки


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Создание настольного приложения


```bash
# 构建桌面应用安装包
npm run desktop
```
После завершения сборки установочный пакет для соответствующей системы можно найти в каталоге `src-tauri/target/release/bundle`.

## Развертывание на Vercel

1. Форкните этот проект в свой аккаунт GitHub

2. Создайте новый проект на [Vercel](https://vercel.com)

3. Импортируйте свой репозиторий GitHub

4. Нажмите "Deploy" (Развернуть)

## Инструкция по использованию

1. При первом использовании необходимо настроить API-ключ
   - Нажмите в правом верхнем углу "Настройки ключа"
   - Введите API-ключ и базовый адрес
   - Нажмите "Сохранить"
   - Также можно быстро настроить через параметры URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Примечание: специальные символы в URL должны быть закодированы для URL

2. Выбор режима генерации
   - Генерация по тексту: создание изображения по текстовому описанию
   - Генерация по изображению: загрузка изображения для редактирования

3. Настройка параметров генерации
   - Выбор AI-модели (встроенная или пользовательская)
   - Установка пропорций изображения
   - Регулировка качества изображения (режим генерации по изображению)

4. Управление пользовательскими моделями
   - Нажмите на значок настроек рядом с выбором модели
   - Добавить новую модель: введите название модели, значение и выберите тип
   - Редактировать модель: нажмите кнопку редактирования у нужной модели
   - Удалить модель: нажмите кнопку удаления у нужной модели
   - Выбрать модель: нажмите кнопку плюса, чтобы сразу использовать выбранную модель

5. Описание типов моделей
   - Формат DALL-E: используется интерфейс генерации изображений (/v1/images/generations)
   - Формат OpenAI: используется интерфейс чата (/v1/chat/completions)

6. Генерация изображения
   - Введите подсказку
   - Нажмите кнопку "Сгенерировать изображение"
   - Дождитесь завершения генерации

7. Управление изображениями
   - Просмотр истории
   - Загрузка созданных изображений
   - Редактирование существующих изображений

## Важные замечания

- Все созданные изображения и история сохраняются только в локальном браузере
- Использование приватного режима или смена устройства приведёт к потере данных
- Своевременно скачивайте и резервируйте важные изображения
- Настройки API безопасно сохраняются в вашем браузере, не загружаются на сервер
- Браузер блокирует загрузку HTTP-ресурсов на HTTPS-сайтах, приложение автоматически конвертирует HTTP-интерфейсы в HTTPS

## Руководство по внесению вклада

Приветствуются предложения через Issue и Pull Request для улучшения проекта.

## Лицензия

Данный проект распространяется под лицензией [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Согласно лицензии, вы можете:
- ✅ Коммерческое использование: разрешено использовать программное обеспечение в коммерческих целях
- ✅ Модификация: разрешено изменять исходный код программного обеспечения
- ✅ Распространение: разрешено распространять программное обеспечение
- ✅ Личное использование: разрешено использовать программное обеспечение для личных нужд
- ✅ Патентная лицензия: данная лицензия также предоставляет патентные права

Но необходимо соблюдать следующие условия:
- 📝 Лицензионное и авторское уведомление: необходимо включить оригинальную лицензию и уведомление об авторских правах
- 📝 Уведомление об изменениях: необходимо отмечать существенные изменения исходного кода
- 📝 Уведомление о товарных знаках: запрещено использовать товарные знаки авторов

---

## Угостите меня чашкой кофе

Если этот проект оказался для вас полезным, буду рад, если угостите меня чашкой кофе ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="QR-код для оплаты в WeChat" width="300" />
  <p>Угостите меня чашкой кофе</p>
</div>

## Контактная информация

Если у вас есть вопросы или предложения, свяжитесь со мной через WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Контактный QR-код WeChat" width="300" />
  <p>Сканируйте QR-код для добавления в WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---