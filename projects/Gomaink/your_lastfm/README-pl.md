
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Kontenerowa aplikacja Node.js, która synchronizuje scrobbles z **Last.fm**, zapisuje je w lokalnej bazie danych **SQLite** oraz udostępnia webowy pulpit nawigacyjny.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Projekt

**Your LastFM** to aplikacja Node.js zaprojektowana do **automatycznej synchronizacji scrobblowanych utworów** z Last.fm. Zachowuje historię odsłuchów w lokalnej bazie danych SQLite oraz udostępnia interfejs webowy do wizualizacji danych.

Projekt jest w pełni konteneryzowany za pomocą **Dockera**, wykorzystuje zautomatyzowany entrypoint do inicjalizacji bazy danych oraz sekwencyjnego uruchamiania (najpierw synchronizacja, potem Web API). Wewnątrz kontenera używany jest również **PM2** jako menedżer procesów, aby zapewnić aktywność i odporność usługi webowej.

## Funkcje
### Interaktywny Web Dashboard

- Czysty, nowoczesny interfejs webowy do wizualizacji aktywności muzycznej.

### Automatyczna Synchronizacja Scrobbli z Last.fm

- Okresowo pobiera i zapisuje historię odsłuchów (scrobbli) z Last.fm.
- Zapewnia aktualność danych bez ręcznej ingerencji.

### Lokalna Baza Danych Historii Muzycznej

- Przechowuje wszystkie scrobbla w lokalnej bazie SQLite.
- Umożliwia szybkie zapytania i dostęp offline do danych historycznych.

### Widok Ostatnich Scrobbli

- Wyświetla Twoje najnowsze utwory.
- Inteligentny mechanizm zastępowania obrazów dla utworów, albumów i wykonawców.

### Porównanie z Przyjaciółmi (Widok Zgodności)

- Porównaj swój gust muzyczny z przyjaciółmi z Last.fm.
- Pokazuje poziom zgodności (Bardzo niski → Super).
- Wyświetla wspólnych topowych wykonawców, albumy i utwory.
- Oblicza i normalizuje zgodność na podstawie rzeczywistych danych odsłuchowych.

### Udostępniane Karty Muzyczne

- Generuje dynamiczne obrazy na podstawie Twoich danych odsłuchowych.
- Optymalizowane układy dla postów w feedzie oraz instagram stories (9:16)

- Zbudowany z użyciem node-canvas do renderowania obrazów po stronie serwera.

## Wymagania wstępne

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Instalacja

### Utwórz plik `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Utwórz konto API [tutaj](https://www.last.fm/api/account/create), aby uzyskać swój klucz API.

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

Na terminalu:
`docker compose up -d`

Następnie uzyskaj dostęp:
```
http://localhost:1533
```

(lub zamień `localhost` na adres IP swojego serwera)

## Licencja

Ten projekt jest objęty licencją MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---