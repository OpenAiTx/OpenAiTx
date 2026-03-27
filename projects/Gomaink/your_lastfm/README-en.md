
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

A containerized Node.js application that synchronizes scrobbles from **Last.fm**, stores them in a local **SQLite** database, and serves a web dashboard.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## Project

**Your LastFM** is a Node.js application designed to **automatically synchronize music scrobbles** from Last.fm. It preserves your listening history in a local SQLite database and serves a web interface for data visualization.

The project is fully containerized with **Docker**, using an automated entrypoint to handle database initialization and sequential execution (Syncing first, then launching the Web API). It also utilizes **PM2** as a process manager inside the container to ensure the web service remains active and resilient.

## Features
### Interactive Web Dashboard

- Clean, modern web interface to visualize your music activity.

### Automatic Last.fm Scrobble Synchronization

- Periodically fetches and stores your listening history (scrobbles) from Last.fm.
- Ensures your data is always up to date without manual intervention.

### Local Music History Database

- Persists all scrobbles in a local SQLite database.
- Allows fast queries and offline access to historical listening data.

### Recent Scrobbles View

- Displays your most recent tracks.
- Smart image fallback logic for tracks, albums, and artists.

### Friends Comparison (Compatibility View)

- Compare your music taste with Last.fm friends.
- Shows compatibility level (Very Low → Super).
- Displays common top artists, albums, and tracks.
- Calculates and normalizes compatibility based on real listening data.

### Shareable Music Cards

- Generate dynamic images based on your listening data.
- Optimized layouts for feed posts and instagram stories (9:16)
- Built using node-canvas for server-side image rendering.

## Prerequisites

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installation

### Create a `.env` file

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Create an API account [here](https://www.last.fm/api/account/create) to get your API Key.

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

On terminal:
`docker compose up -d`

Then access:
```
http://localhost:1533
```

(or replace `localhost` with your server IP)

## License

This project is licensed under the MIT License.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---