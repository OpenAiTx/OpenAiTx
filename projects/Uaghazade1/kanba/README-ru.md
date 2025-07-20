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

# Открытое, легковесное решение Trello для мейкеров и инди-хакеров.

Фокус на простоте, скорости и масштабируемости.
Создано на современном стеке: Tailwind CSS, shadcn/ui, Supabase, интеграция Stripe.
Поддержка неограниченного количества проектов, командная работа, светлый/тёмный режим и плавный пользовательский опыт.
Идеально для одиночных разработчиков и небольших команд, желающих полного контроля без лишней сложности.

## 🌟 Если этот проект оказался для вас полезным, поставьте звезду! Это поможет другим тоже его найти.

# Руководство по развертыванию

## Обзор
Приложение теперь использует локальные маршруты API Next.js вместо Supabase Edge Functions для интеграции Stripe. Это упрощает развертывание и позволяет использовать стандартные файлы .env для конфигурации.

## Настройка переменных окружения

### 1. Создайте файл .env.local
Скопируйте `.env.example` в `.env.local` и заполните своими значениями:


```bash
cp .env.example .env.local
```
### 2. Необходимые переменные окружения

#### Конфигурация Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL вашего проекта Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Анонимный ключ вашего Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Ключ сервисной роли Supabase (только для серверной части)

#### Конфигурация Stripe (необязательно)
- `STRIPE_SECRET_KEY` - Ваш секретный ключ Stripe (только для серверной части)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Ваш открытый ключ Stripe
- `STRIPE_WEBHOOK_SECRET` - Ваш секретный ключ Stripe webhook

#### Конфигурация сайта
- `NEXT_PUBLIC_SITE_URL` - URL вашего сайта (для продакшена)
- `NEXTAUTH_URL` - URL вашего сайта (то же, что выше)
- `NEXTAUTH_SECRET` - Случайный секрет для NextAuth

## Локальная разработка

1. Установите зависимости:

```bash
npm install
```
2. Настройте переменные окружения в файле `.env.local`

3. Запустите сервер разработки:

```bash
npm run dev
```
4. Протестируйте Stripe вебхуки локально с помощью Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## Продакшн-развертывание


### Развертывание на Vercel

1. **Развернуть на Vercel:**

```bash
npx vercel
```
2. **Переменные окружения:**
   Добавьте все переменные окружения через панель Vercel или CLI

3. **Настройка Stripe Webhook:**
   - Укажите адрес webhook: `https://your-domain.vercel.app/api/stripe/webhook`

## API Endpoints

Приложение теперь использует следующие локальные API-маршруты:

- `POST /api/stripe/checkout` - Создаёт сессии Stripe checkout
- `POST /api/stripe/webhook` - Обрабатывает события Stripe webhook

## Преимущества локальных API-маршрутов

1. **Проще развертывание** — нет необходимости развертывать отдельные edge-функции
2. **Переменные окружения** — стандартная поддержка .env файлов
3. **Удобная отладка** — проще отлаживать локально
4. **Интеграция с фреймворком** — лучшая интеграция с Next.js
5. **Отсутствие привязки к платформе** — можно развернуть на любой платформе с поддержкой Next.js

## Устранение неполадок

1. **Проблемы с webhook:**
   - Убедитесь, что `STRIPE_WEBHOOK_SECRET` соответствует вашему endpoint Stripe webhook
   - Проверьте логи webhook в панели Stripe
   - Убедитесь, что URL webhook указан верно

2. **Переменные окружения:**
   - Проверьте, что все необходимые переменные заданы
   - Проверьте опечатки в именах переменных
   - Убедитесь, что ключ service role Supabase имеет нужные права

3. **Проблемы с CORS:**
   - API-маршруты содержат корректные CORS-заголовки
   - Убедитесь, что ваш домен включён в белый список при необходимости

## Примечания по безопасности

- Никогда не раскрывайте `STRIPE_SECRET_KEY` или `SUPABASE_SERVICE_ROLE_KEY` на клиенте
- Используйте префикс `NEXT_PUBLIC_` только для переменных на клиенте
- Регулярно меняйте ваши webhook-секреты
- Следите за доставкой webhook в панели Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---