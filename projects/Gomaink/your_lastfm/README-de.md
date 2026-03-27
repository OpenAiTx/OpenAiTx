
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Eine containerisierte Node.js-Anwendung, die Scrobbles von **Last.fm** synchronisiert, sie in einer lokalen **SQLite**-Datenbank speichert und ein Web-Dashboard bereitstellt.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Projekt

**Your LastFM** ist eine Node.js-Anwendung, die dazu dient, **Musik-Scrobbles automatisch mit Last.fm zu synchronisieren**. Sie speichert deinen Hörverlauf in einer lokalen SQLite-Datenbank und bietet eine Web-Oberfläche zur Datenvisualisierung.

Das Projekt ist vollständig mit **Docker** containerisiert und verwendet einen automatisierten Entry-Point, um die Initialisierung der Datenbank und die sequentielle Ausführung zu steuern (zuerst Synchronisierung, dann Start der Web-API). Außerdem wird **PM2** als Prozessmanager im Container eingesetzt, um den Webdienst aktiv und stabil zu halten.

## Funktionen
### Interaktives Web-Dashboard

- Saubere, moderne Web-Oberfläche zur Visualisierung deiner Musikaktivität.

### Automatische Last.fm-Scrobble-Synchronisation

- Ruft regelmäßig deinen Hörverlauf (Scrobbles) von Last.fm ab und speichert ihn.
- Stellt sicher, dass deine Daten immer aktuell sind, ohne manuelles Eingreifen.

### Lokale Musikverlaufsdatenbank

- Speichert alle Scrobbles in einer lokalen SQLite-Datenbank.
- Ermöglicht schnelle Abfragen und Offline-Zugriff auf den historischen Hörverlauf.

### Ansicht der letzten Scrobbles

- Zeigt deine zuletzt gehörten Titel an.
- Intelligente Bild-Fallback-Logik für Titel, Alben und Künstler.

### Freunde-Vergleich (Kompatibilitätsansicht)

- Vergleiche deinen Musikgeschmack mit Last.fm-Freunden.
- Zeigt Kompatibilitätslevel (Sehr Niedrig → Super).
- Zeigt gemeinsame Top-Künstler, Alben und Titel.
- Berechnet und normalisiert die Kompatibilität basierend auf echten Hördaten.

### Teilbare Musikkarten

- Erzeugt dynamische Bilder basierend auf deinen Hördaten.
- Optimierte Layouts für Feed-Posts und Instagram-Stories (9:16)

- Erstellt mit node-canvas für serverseitiges Bild-Rendering.

## Voraussetzungen

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installation

### Erstellen Sie eine `.env`-Datei

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Erstellen Sie ein API-Konto [hier](https://www.last.fm/api/account/create), um Ihren API-Schlüssel zu erhalten.

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

Im Terminal:
`docker compose up -d`

Dann zugreifen:
```
http://localhost:1533
```

(oder ersetzen Sie `localhost` durch Ihre Server-IP)

## Lizenz

Dieses Projekt ist unter der MIT-Lizenz lizenziert.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---