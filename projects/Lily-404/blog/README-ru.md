
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Блог Джимми

Минималистичная система личного блога, построенная на Next.js 15+, поддерживающая онлайн-создание и статическую публикацию.

## Технологический стек

- **Фреймворк**: Next.js 15+ (App Router)
- **Язык**: TypeScript
- **Стили**: Tailwind CSS
- **Иконки**: Lucide Icons
- **Контент**: Markdown + Gray Matter + Remark
- **Аутентификация**: GitHub OAuth
- **Развертывание**: Vercel

## Особенности

### Сторона читателя

- 📝 Рендеринг статей Markdown + GFM (включая отображение математических формул)
- 🏷️ Фильтрация по тегам, пагинация, архив (по годам/тегам)
- 📚 Навигация по оглавлению (TOC) и копирование блоков кода одним кликом
- 📱 Адаптивная верстка и переключение темного/светлого режима
- 🔥 Всплывающая тепловая карта календаря творчества (статьи + заметки)
- 📡 Вывод RSS подписки (`/rss.xml`)

### Сторона автора (админ-панель)

- 🔐 Вход через GitHub OAuth (проверка прав владельца/соавтора)
- ✍️ Онлайн создание, редактирование и удаление статей/заметок
- 🆔 Пользовательские ID файлов + автоматическое избегание конфликтов
- 👀 Три режима написания: редактирование / предпросмотр / разделённый экран
- 📊 Панель статистики творчества (общий объем, недельная/месячная продуктивность, популярные теги)

### Сторона инженерии

- ⚡ Многостраничный статический вывод (`force-static`) для повышения производительности и стабильности
- 🧭 Встроенные sitemap и robots
- 🧩 Кэширование чтения контента и модульная структура API

## Структура проекта

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Установка и запуск

1. Клонируйте проект

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Установка зависимостей

```bash
npm install
```

3. Запуск сервера разработки

```bash
npm run dev
```

4. Сборка производственной версии

```bash
npm run build
```

## Добавление новой статьи

### Способ 1: Онлайн-панель управления (рекомендуется)

1. Перейдите на страницу `/admin`
2. Войдите через GitHub OAuth
3. Заполните информацию о статье и отправьте
4. Статья будет автоматически создана через GitHub API, Vercel автоматически выполнит повторное развертывание

### Способ 2: Ручное добавление файла

1. Создайте новый Markdown-файл в каталоге `content/posts`
2. Формат имени файла: `xxx.md`
3. Добавьте метаданные в начало файла:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Добавить заметку

1. Создайте новый Markdown-файл в каталоге `content/notes`
2. Формат имени файла: `YYYY-MM-DD-title.md`
3. Добавьте метаданные в начало файла:

```markdown
---
date: YYYY-MM-DD
---
```

## Настройка административной панели

Административная панель использует GitHub OAuth для аутентификации, доступ имеют только владельцы репозитория или сотрудники.

### 1. Создание GitHub OAuth приложения

1. Перейдите на [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Нажмите "New OAuth App"
3. Заполните информацию:
   - **Application name**: `Jimmy Blog Admin` (или любое другое имя)
   - **Homepage URL**: `https://ваш-домен.com` (для продакшена) или `http://localhost:3000` (для локальной разработки)
   - **Authorization callback URL**: 
     - Продакшен: `https://ваш-домен.com/api/auth/github/callback`
     - Локальная разработка: `http://localhost:3000/api/auth/github/callback`
4. Нажмите "Register application"
5. Сохраните **Client ID**
6. Нажмите "Generate a new client secret", сохраните **Client secret**

### 2. Настройка переменных окружения

Добавьте следующие переменные окружения в настройках проекта Vercel:

- `GITHUB_CLIENT_ID`: Client ID вашего GitHub OAuth приложения
- `GITHUB_CLIENT_SECRET`: Client Secret вашего GitHub OAuth приложения
- `GITHUB_OWNER`: Имя пользователя GitHub (по умолчанию: `Lily-404`, для проверки прав доступа)
- `GITHUB_REPO`: Имя репозитория (по умолчанию: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth callback URL (необязательно, по умолчанию генерируется автоматически)
- `NEXT_PUBLIC_BASE_URL`: URL вашего сайта (используется для генерации callback URL, обязательно для продакшена)
  - Продакшен: `https://www.jimmy-blog.top`
  - Локальная разработка: `http://localhost:3000`

### 3. Настройка для локальной разработки

Создайте файл `.env.local` в корневой папке проекта:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Конфигурация производственной среды (Vercel)

В настройках проекта Vercel убедитесь, что установлено:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Внимание**: 
- Файл `.env.local` добавлен в `.gitignore` и не будет добавлен в Git
- При локальной разработке убедитесь, что callback URL OAuth App установлен на `http://localhost:3000/api/auth/github/callback`
- **В продакшене обязательно установите `NEXT_PUBLIC_BASE_URL` в значение `https://www.jimmy-blog.top`**
- Callback URL OAuth App для продакшена должен быть: `https://www.jimmy-blog.top/api/auth/github/callback`

## Деплой

Проект настроен для деплоя на Vercel и поддерживает автоматическое развертывание. Просто отправьте код в репозиторий GitHub, и Vercel автоматически соберёт и развернёт проект.

### Преимущества использования административной панели

- ✅ Не требуется локальная среда разработки
- ✅ Можно добавлять статьи в любое время и из любого места
- ✅ Автоматически инициируется повторный деплой Vercel
- ✅ Полностью бесплатно (GitHub OAuth и Vercel в рамках бесплатного тарифа)
- ✅ Безопасно (аутентификация через GitHub OAuth, доступ только у владельца/сотрудников репозитория)
- ✅ Не нужно управлять паролями, вход через аккаунт GitHub
- ✅ Поддерживается онлайн-редактирование существующего контента (не только создание нового)
- ✅ Автоматическое разрешение конфликтов ID файлов, предотвращение перезаписи и ручного переименования
- ✅ Встроенная статистика по созданию контента для удобства ведения блога

## Анализ проекта и планы на будущее

- Документ анализа проекта: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Документ с планами на будущее: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Вклад

Приветствуются Issue и Pull Request!

## Лицензия

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---