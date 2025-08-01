<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Открытая, легковесная альтернатива Trello, созданная для создателей и инди-хакеров.

Сфокусирована на простоте, скорости и масштабируемости.
Построена на современном стеке: Tailwind CSS, shadcn/ui, Supabase, интеграция Stripe.
Поддерживает неограниченное количество проектов, командную работу, темный/светлый режим и плавный пользовательский опыт.
Идеально подходит для соло-разработчиков и небольших команд, которым нужен полный контроль без лишней сложности.

## 🌟 Если этот проект оказался полезен, поставьте ему звезду! Это поможет другим его найти.

# Руководство по развертыванию

## Обзор
Теперь это приложение использует локальные API-маршруты Next.js вместо Supabase Edge Functions для интеграции Stripe. Это упрощает развертывание и позволяет использовать стандартные .env-файлы для конфигурации.

## Настройка переменных среды

### 1. Создайте файл .env.local
Скопируйте `.env.example` в `.env.local` и заполните своими актуальными значениями:


```bash
cp .env.example .env.local
```

### 2. Необходимые переменные окружения

#### Конфигурация Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL вашего проекта Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Анонимный ключ вашего Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Ключ роли сервиса Supabase (только на сервере)

#### Конфигурация Stripe (необязательно)
- `STRIPE_SECRET_KEY` - Ваш секретный ключ Stripe (только на сервере)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Ваш публичный ключ Stripe
- `STRIPE_WEBHOOK_SECRET` - Ваш секрет для Stripe webhook

#### Конфигурация сайта
- `NEXT_PUBLIC_SITE_URL` - URL вашего сайта (для продакшена)
- `NEXTAUTH_URL` - URL вашего сайта (такой же, как выше)
- `NEXTAUTH_SECRET` - Случайный секрет для NextAuth

## Локальная разработка

1. Установите зависимости:
```bash
npm install
```

2. Установите переменные среды в файле `.env.local`

3. Запустите сервер разработки:
```bash
npm run dev
```

4. Протестируйте вебхуки Stripe локально с помощью Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Продуктивное Развертывание


### Развертывание на Vercel

1. **Разверните на Vercel:**
```bash
npx vercel
```
2. **Переменные окружения:**
   Добавьте все переменные окружения через панель управления Vercel или CLI

3. **Настройка Stripe Webhook:**
   - Укажите webhook на: `https://your-domain.vercel.app/api/stripe/webhook`

## API Эндпоинты

Приложение теперь использует следующие локальные маршруты API:

- `POST /api/stripe/checkout` - Создаёт сессии оплаты Stripe
- `POST /api/stripe/webhook` - Обрабатывает события Stripe webhook

## Преимущества локальных маршрутов API

1. **Проще деплой** - Не требуется развертывать отдельные edge-функции
2. **Переменные окружения** - Поддержка стандартного файла .env
3. **Удобная отладка** - Проще отлаживать локально
4. **Интеграция с фреймворком** - Лучшая интеграция с Next.js
5. **Нет привязки к поставщику** - Можно развернуть на любой платформе, поддерживающей Next.js

## Устранение неполадок

1. **Проблемы с Webhook:**
   - Убедитесь, что `STRIPE_WEBHOOK_SECRET` соответствует вашему endpoint'у Stripe webhook
   - Проверьте логи webhook в панели Stripe
   - Убедитесь, что URL webhook указан верно

2. **Переменные окружения:**
   - Убедитесь, что все необходимые переменные установлены
   - Проверьте опечатки в названиях переменных
   - Убедитесь, что ключ роли службы Supabase имеет соответствующие разрешения

3. **Проблемы с CORS:**
   - Маршруты API включают необходимые заголовки CORS
   - При необходимости убедитесь, что ваш домен находится в белом списке

## Примечания по безопасности

- Никогда не передавайте `STRIPE_SECRET_KEY` или `SUPABASE_SERVICE_ROLE_KEY` на клиент
- Используйте префикс `NEXT_PUBLIC_` только для переменных на стороне клиента
- Регулярно меняйте ваши webhook-секреты
- Контролируйте доставку webhook в панели Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---