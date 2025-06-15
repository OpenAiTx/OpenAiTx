<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Тема блога Astro</p>
<p>Sora означает «небосвод», символизируя бесконечные возможности и широкое творческое пространство</p>
<p>Если вам нравится эта тема, не забудьте поставить 🌟Star!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# Предварительный просмотр

[Мой блог](https://blog.liks.space)

## Кто использует

Добро пожаловать, откройте [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml), чтобы показать свой сайт.

# Начало работы

1. Установка темы

   - Установите [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Перейдите в каталог проекта и запустите `pnpm dev` для старта проекта

2. Настройка темы

   Измените файл конфигурации `theme.config.ts`, чтобы настроить тему. Подробнее см. [Настройка](#配置).

3. Редактирование статей

   Редактируйте в каталоге `src/content/`, поддерживается формат Markdown.

4. Развертывание сайта

   Выполните `pnpm build` для сборки сайта, результат сборки находится в каталоге `dist/`. Можно выполнить `pnpm preview` для локального просмотра сайта.

   Разверните сайт на своем сервере или следуйте [документации Astro](https://docs.astro.build/en/guides/deploy/) для развертывания на Vercel, Netlify, GitHub Pages и других платформах.

<!-- # Документация -->

# Настройка

Файл конфигурации — `theme.config.ts`.

## Информация о сайте

```typescript
site: {
  // Адрес сайта
  url: "https://blog.liks.space",
  // Заголовок сайта
  title: "Sora",
  // Имя владельца
  author: "Liks",
  // Описание сайта
  description: "A blog theme built with Astro",
  // Иконка сайта
  // Поддерживаются форматы SVG, PNG, ICO
  // Локальный путь к файлу в каталоге public/
  favicon: "/images/favicon.ico",
}
```

## Глобальные настройки

```typescript
global: {
  // Аватар
  // Локальный путь к файлу в каталоге src/images/
  avatar: "avatar.jpg",
  // Включить RSS
  rss: true,
  // Включить поддержку мультиязычности (в разработке)
  i18n: true,
}
```

## Навигационная панель

```typescript
nav: [
  {
    // Название страницы
    name: "Архив",
    // Адрес страницы
    url: "/archives",
  },
  {
    name: "Категории",
    url: "/categories",
  },
  {
    name: "Теги",
    url: "/tags",
  },
  {
    name: "О сайте",
    url: "/about",
  },
  ...
];
```

## Подвал

```typescript
footer: {
  // Авторские права
  copyright: {
    // Время основания сайта
    time: "2024 - 2025",
    // Владелец прав
    owner: "Liks",
  },
  // Регистрация в органах (только для Китая)
  beian: {
    // ICP регистрация
    icp: {
      // Включить
      enabled: false,
      // Номер регистрации
      number: "京 ICP 备 12345678 号",
    },
    // Регистрация в полиции
    police: {
      // Включить
      enabled: false,
      // Номер регистрации
      number: "京公网安备 12345678901234 号",
      // Сайт регистрации
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Главная страница

```typescript
index: {
  // Социальные сети
  social: [
    {
      // Название
      name: "GitHub",
      // Включить
      enabled: true,
      // Ссылка
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Поддерживаются BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Страница статьи

```typescript
post: {
  // Лицензия
  copyright: {
    // Лицензия CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Ссылка на лицензию
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Поддержка

```typescript
sponsor: {
  // Включить
  enabled: true,
  // QR-код Alipay
  alipay: {
    // Включить
    enabled: true,
    // Локальный путь к файлу в каталоге src/images/
    image: "alipay.png",
  },
  // QR-код WeChat
  wechat: {
    enabled: false,
  },
  // Показать список спонсоров
  list: true,
}
```

## Комментарии

```typescript
comment: {
  // Включить
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Адрес сервера backend
    server: "https://artalk.example.com",
    // Имя сайта
    site: "Sora",
  },
}
```

## Инструменты

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Включить
    enabled: false,
    // Адрес сервера
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Лицензия

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Благодарности

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---