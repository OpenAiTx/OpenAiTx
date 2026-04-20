<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Альтернатива MyFitnessPal с приоритетом приватности и возможностью самостоятельного размещения. Отслеживайте питание, тренировки, параметры тела и здоровье, полностью контролируя свои данные.

![Скриншот](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness — это платформа для отслеживания фитнеса с самостоятельным размещением, включающая:

- Серверную часть (API + хранение данных)
- Веб-интерфейс
- Родные мобильные приложения для iOS и Android

Хранит и управляет данными о здоровье на инфраструктуре, которую вы контролируете, без использования сторонних сервисов.

## Основные функции

- Отслеживание питания, упражнений, гидратации, сна, голодания, настроения и параметров тела
- Постановка целей и ежедневные чекины
- Интерактивные графики и долгосрочные отчёты
- Несколько профилей пользователей и семейный доступ
- Светлая и тёмная темы
- OIDC, TOTP, Passkey, MFA и др.

## Интеграции с устройствами и сервисами здоровья

SparkyFitness может синхронизировать данные с несколькими платформами здоровья и фитнеса:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (частично протестировано)
- **Hevy** (не тестировалось)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (частично протестировано)

Интеграции автоматически синхронизируют данные о деятельности, такие как шаги, тренировки и сон, а также параметры здоровья, например вес и измерения тела, на ваш сервер SparkyFitness.

## Дополнительные функции ИИ (Бета)

SparkyAI предоставляет интерфейс для ведения журнала данных и обзора прогресса в виде диалога.

- Ведение журнала питания, упражнений, параметров тела и шагов через чат
- Загрузка фото еды для автоматического ведения журнала приёмов пищи
- Сохраняет историю переписки для последующих обращений

Примечание: функции искусственного интеллекта в настоящее время находятся в бета-версии.

## Быстрый старт (Сервер)

Запустите сервер SparkyFitness за считанные минуты с помощью Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Видеоурок

[![Смотреть видео](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Краткий 2-минутный урок по установке SparkyFitness (фитнес-трекер для самостоятельного размещения).


## Документация

Для полного руководства по установке, вариантам конфигурации и документации по разработке посетите наш [сайт документации](https://codewithcj.github.io/SparkyFitness/).

### Быстрые ссылки

- **[Руководство по установке](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** — Развертывание и настройка
- **[Обзор функций](https://codewithcj.github.io/SparkyFitness/features)** — Полная документация по функциям
- **[Процесс разработки](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** — Руководство для разработчиков и процесс внесения изменений
- **[Информация о приложении для iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** и **[Информация о приложении для Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Нужна помощь?

- Задайте вопрос в Github issues/discussion.
- Для более быстрого ответа и помощи от других участников сообщества **[присоединяйтесь к нашему Discord](https://discord.gg/vcnMT5cPEA)**

## История звёзд

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="График истории звёзд" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Переводы

**[Переводы Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Статус перевода" />
</a>

## Активность репозитория

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Изображение аналитики Repobeats")

## Участники

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Известные проблемы / Бета-функции ⚠️

SparkyFitness находится в активной разработке.
Могут возникать несовместимые изменения между релизами.

- Не рекомендуется автообновление контейнеров
- Всегда изучайте примечания к выпуску перед обновлением

Следующие функции находятся в бета-версии и могут быть недостаточно протестированы. Возможны ошибки или неполная функциональность:

- AI-чат-бот
- Доступ для семьи и друзей
- Документация по API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---