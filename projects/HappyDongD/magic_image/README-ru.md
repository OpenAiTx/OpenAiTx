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

# Магическое AI-рисование

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Приложение для AI-рисования на базе Next.js с основными возможностями:
- 🎨 Поддержка различных AI-моделей (Sora, DALL-E, GPT и др.), а также добавление собственных моделей
- 🖼️ Функции генерации изображений по тексту и обработки изображений, поддержка нескольких референсов и редактирования областей
- 🔐 Все данные и API-ключи хранятся локально, обеспечивая приватность и безопасность
- 💻 Поддержка веб-версии и упаковки в десктопное приложение, кроссплатформенность

## Онлайн-демо

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

- 🎨 Поддержка различных AI-моделей
  - Модель GPT Sora_Image
  - Модель GPT 4o_Image
  - Модель GPT Image 1
  - Модель DALL-E 3
  - 🆕 Пользовательские модели (поддержка приватных моделей)
- ✍️ Генерация изображений по тексту
  - Поддержка пользовательских промптов
  - Выбор пропорций изображения
  - Поддержка различных размеров изображений
- 🖼️ Генерация изображений по картинке
  - Поддержка редактирования изображений
  - Поддержка редактирования области маской
  - Поддержка настройки качества изображения
  - Поддержка нескольких референсов (загрузка нескольких картинок)
- 🔒 Безопасность данных
  - Все созданные изображения и история сохраняются только в локальном браузере
  - Поддержка настройки пользовательского API-прокси
  - Поддержка настройки API-ключа
- 📱 Дизайн интерфейса
  - Современный пользовательский интерфейс
  - Плавный пользовательский опыт
  - Отображение в формате Markdown
  - Поддержка подсветки кода
- 🖥️ Кроссплатформенность
  - Упаковка в десктопное приложение (Windows, macOS, Linux)
  - Поддержка оффлайн-использования (требуется настройка API)

## Стек технологий

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (упаковка для десктопа)

## Локальная разработка

1. Клонировать проект

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
     Внимание: специальные символы в URL должны быть закодированы

2. Выберите режим генерации
   - Текст-в-изображение: создание картинки по текстовому описанию
   - Изображение-в-изображение: загрузка изображения для редактирования

3. Настройка параметров генерации
   - Выбор AI-модели (встроенная или пользовательская)
   - Установка соотношения сторон изображения
   - Настройка качества изображения (для режима "изображение-в-изображение")

4. Управление пользовательскими моделями
   - Нажмите на значок настроек рядом с выбором модели
   - Добавить новую модель: введите имя, значение модели и выберите тип модели
   - Редактировать модель: нажмите кнопку редактирования рядом с моделью
   - Удалить модель: нажмите кнопку удаления рядом с моделью
   - Выбрать модель: нажмите на плюс возле модели для немедленного выбора

5. Описание типов моделей
   - Формат DALL-E: используется интерфейс генерации изображений (/v1/images/generations)
   - Формат OpenAI: используется чат-интерфейс (/v1/chat/completions)

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
- Использование приватного режима или смена устройства приведет к потере данных
- Своевременно скачивайте и делайте резервные копии важных изображений
- Настройки API безопасно сохраняются в вашем браузере и не отправляются на сервер
- При работе с HTTPS-сайтом загрузка HTTP-ресурсов блокируется браузером, приложение автоматически преобразует HTTP-интерфейсы в HTTPS

## Руководство по вкладу

Будем рады вашим Issue и Pull Request для улучшения проекта.

## Лицензия

Данный проект распространяется по лицензии [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

В соответствии с лицензией, вам разрешено:
- ✅ Коммерческое использование: разрешается использовать ПО в коммерческих целях
- ✅ Модификация: разрешается изменять исходный код ПО
- ✅ Распространение: разрешается распространять ПО
- ✅ Личное использование: разрешается использовать ПО в личных целях
- ✅ Патентная лицензия: лицензия также предоставляет патентные права

Но необходимо соблюдать следующие условия:
- 📝 Указание лицензии и авторства: необходимо сохранять оригинальную лицензию и уведомление об авторских правах
- 📝 Указание изменений: необходимо отмечать существенные изменения оригинального кода
- 📝 Использование товарных знаков: нельзя использовать товарные знаки участников проекта

---

## Угостите меня чашкой кофе

Если этот проект был вам полезен, буду рад вашей чашке кофе ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="微信收款码" width="300" />
  <p>Угостите меня чашкой кофе</p>
</div>

## Контакты

Если у вас есть вопросы или предложения, свяжитесь со мной через WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="微信联系方式" width="300" />
  <p>Отсканируйте QR-код, чтобы добавить WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---