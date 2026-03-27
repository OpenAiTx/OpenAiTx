
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Статус](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Лицензия](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Контейнеризованное Node.js приложение, которое синхронизирует скробблы из **Last.fm**, сохраняет их в локальную базу данных **SQLite** и предоставляет веб-дэшборд.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Проект

**Your LastFM** — это приложение на Node.js, предназначенное для **автоматической синхронизации музыкальных скробблов** с Last.fm. Оно сохраняет вашу историю прослушиваний в локальной базе данных SQLite и предоставляет веб-интерфейс для визуализации данных.

Проект полностью контейнеризирован с помощью **Docker**, использует автоматизированную точку входа для инициализации базы данных и последовательного выполнения (сначала синхронизация, затем запуск Web API). В контейнере также применяется **PM2** как менеджер процессов для обеспечения активности и устойчивости веб-сервиса.

## Возможности
### Интерактивная веб-панель

- Чистый, современный веб-интерфейс для визуализации вашей музыкальной активности.

### Автоматическая синхронизация скробблов Last.fm

- Периодически загружает и сохраняет вашу историю прослушиваний (скробблы) с Last.fm.
- Обеспечивает актуальность данных без ручного вмешательства.

### Локальная база данных истории музыки

- Сохраняет все скробблы в локальной базе данных SQLite.
- Позволяет быстро выполнять запросы и получать доступ к истории офлайн.

### Просмотр последних скробблов

- Отображает ваши самые последние треки.
- Интеллектуальная логика резервных изображений для треков, альбомов и исполнителей.

### Сравнение с друзьями (Вид совместимости)

- Сравнивайте свои музыкальные предпочтения с друзьями Last.fm.
- Показывает уровень совместимости (Очень низкая → Супер).
- Отображает общих топ-исполнителей, альбомы и треки.
- Вычисляет и нормализует совместимость на основе реальных данных прослушиваний.

### Музыкальные карточки для обмена

- Генерирует динамические изображения на основе ваших данных прослушиваний.
- Оптимизированные макеты для публикаций в ленте и историй Instagram (9:16)

- Основано на node-canvas для серверного рендеринга изображений.

## Необходимые компоненты

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Установка

### Создайте файл `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Создайте учетную запись API [здесь](https://www.last.fm/api/account/create), чтобы получить ваш API-ключ.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

В терминале:
`docker compose up -d`

Затем перейдите:
```
http://localhost:1533
```

(или замените `localhost` на IP-адрес вашего сервера)

## Лицензия

Этот проект лицензирован по лицензии MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---