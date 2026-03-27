
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-actief-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licentie](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Een gecontaineriseerde Node.js-applicatie die scrobbles synchroniseert van **Last.fm**, deze opslaat in een lokale **SQLite** database en een webdashboard aanbiedt.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Project

**Your LastFM** is een Node.js-applicatie die is ontworpen om **automatisch muziek-scrobbles te synchroniseren** van Last.fm. Het bewaart je luistergeschiedenis in een lokale SQLite-database en biedt een webinterface voor datavisualisatie.

Het project is volledig gecontaineriseerd met **Docker**, waarbij een geautomatiseerd entrypoint wordt gebruikt voor database-initialisatie en sequentiële uitvoering (eerst synchroniseren, daarna de Web API starten). Ook wordt **PM2** als procesmanager binnen de container gebruikt om te garanderen dat de webservice actief en veerkrachtig blijft.

## Functionaliteiten
### Interactief Web Dashboard

- Schone, moderne webinterface om je muziekactiviteit te visualiseren.

### Automatische Last.fm Scrobble-synchronisatie

- Haalt periodiek je luistergeschiedenis (scrobbles) op en slaat deze op vanaf Last.fm.
- Zorgt dat je gegevens altijd up-to-date zijn zonder handmatige tussenkomst.

### Lokale Muziekgeschiedenis-database

- Slaat alle scrobbles op in een lokale SQLite-database.
- Maakt snelle zoekopdrachten en offline toegang tot historische luistergegevens mogelijk.

### Weergave van Recente Scrobbles

- Toont je meest recente nummers.
- Slimme fallback-logica voor afbeeldingen van nummers, albums en artiesten.

### Vriendenvergelijking (Compatibiliteitsweergave)

- Vergelijk je muzieksmaak met Last.fm-vrienden.
- Toont compatibiliteitsniveau (Zeer Laag → Super).
- Geeft gemeenschappelijke topartiesten, albums en nummers weer.
- Berekent en normaliseert compatibiliteit op basis van echte luistergegevens.

### Deelbare Muziekkaarten

- Genereer dynamische afbeeldingen op basis van je luistergegevens.
- Geoptimaliseerde lay-outs voor feedposts en Instagram-verhalen (9:16)

- Gebouwd met node-canvas voor server-side afbeeldingsrendering.

## Vereisten

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installatie

### Maak een `.env` bestand aan

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Maak een API-account aan [hier](https://www.last.fm/api/account/create) om je API-sleutel te verkrijgen.

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

In terminal:
`docker compose up -d`

Vervolgens toegang:
```
http://localhost:1533
```
(of vervang `localhost` door het IP-adres van uw server)

## Licentie

Dit project is gelicentieerd onder de MIT-licentie.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---