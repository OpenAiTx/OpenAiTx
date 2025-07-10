<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# Превратите любое устройство в совместный музыкальный проигрыватель

**Jukebox** позволяет мгновенно создавать общие музыкальные плейлисты с друзьями — без приложения, без регистрации, без рекламы. Просто создайте бокс, поделитесь ссылкой и начинайте добавлять песни вместе. Идеально для вечеринок, поездок или любых встреч с друзьями!

- 🌐 **Открытая альтернатива совместным плейлистам Spotify**
- 🕵️ **Без аккаунта**: Используйте анонимно — не требуется регистрация или email
- ✨ **Делитесь ссылкой, добавляйте песни вместе**: Каждый может вносить свой вклад в реальном времени
- 🚀 **Не требует установки приложения**: Работает на любом устройстве прямо в браузере
- 🎵 **Интеграция с YouTube**: Мгновенный поиск и воспроизведение почти любой песни
- 📱 **Удобно для мобильных устройств**: Подходит для телефонов, планшетов и компьютеров
- ⚖️ **Справедливая очередь**: Песни автоматически сортируются, чтобы каждый получил свой ход
- 🆓 **Абсолютно бесплатно, без рекламы**

---

## Попробуйте прямо сейчас

1. **Создайте Jukebox**: Перейдите на главную страницу и создайте новый бокс
2. **Поделитесь ссылкой**: Отправьте приглашение своим друзьям
3. **Добавляйте песни**: Ищите в YouTube или добавляйте песни вручную
4. **Воспроизводите музыку**: Используйте встроенный плеер для совместного прослушивания

---
## Возможности

- Совместные плейлисты: добавляйте, ставьте в очередь и воспроизводите песни вместе
- Анонимное использование: не требуется вход или учетная запись
- Поиск и воспроизведение с YouTube: доступ к огромной музыкальной библиотеке
- Мобильный, адаптивный интерфейс
- Открытый исходный код (лицензия MIT)
- Простое развертывание с помощью Docker

### Развертывание с Docker Compose

Запустите все сервисы:

```bash
docker-compose up -d
```

Переразвертывание сервисов без простоя после обновления образов:

```bash
bash ./redeploy.sh
```
---

## Начало работы

### Необходимые требования

- Node.js 16+
- npm или yarn
- Ключ YouTube Data API v3 (бесплатно от Google)

### Настройка YouTube API

1. Перейдите в [Google Cloud Console](https://console.cloud.google.com/)
2. Создайте новый проект или выберите существующий
3. Включите **YouTube Data API v3**
4. Создайте учетные данные (API-ключ)
5. Скопируйте ваш API-ключ

### Установка
```bash
# Клонируйте репозиторий
git clone <your-repo-url>
cd jukebox

# Установите зависимости сервера
cd server
yarn install

# Установите зависимости фронтенда
cd ../frontend
yarn install

# Настройте переменные окружения
cd ../server
cp .env.example .env
# Отредактируйте .env и добавьте ваш ключ YouTube API

# Запустите миграции базы данных
```
yarn migrate

# Запустите серверы разработки
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (в новом терминале):
cd frontend
yarn dev
```

---

## Лицензия

MIT

---
## Внесение вклада и обратная связь

- Откройте issue или pull request на [GitHub](https://github.com/skeptrunedev/jukebox)
- Есть предложения по функциям? Напишите в личные сообщения [@skeptrune на X (Twitter)](https://twitter.com/skeptrune)

---

## Журнал изменений

Смотрите [Журнал изменений](https://jukebox.skeptrune.com#changelog) для получения последних обновлений и новых функций.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---