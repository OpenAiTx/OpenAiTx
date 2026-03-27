
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

[![Stato](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licenza](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Un'applicazione Node.js containerizzata che sincronizza gli scrobble da **Last.fm**, li memorizza in un database locale **SQLite** e offre una dashboard web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Progetto

**Your LastFM** è un'applicazione Node.js progettata per **sincronizzare automaticamente gli scrobble musicali** da Last.fm. Conserva la cronologia di ascolto in un database locale SQLite e offre un'interfaccia web per la visualizzazione dei dati.

Il progetto è completamente containerizzato con **Docker**, utilizzando un entrypoint automatizzato per gestire l'inizializzazione del database e l'esecuzione sequenziale (prima la sincronizzazione, poi il lancio della Web API). Utilizza inoltre **PM2** come process manager all'interno del container per garantire che il servizio web rimanga attivo e resiliente.

## Caratteristiche
### Dashboard Web Interattiva

- Interfaccia web pulita e moderna per visualizzare la tua attività musicale.

### Sincronizzazione Automatica degli Scrobble Last.fm

- Recupera e memorizza periodicamente la tua cronologia di ascolto (scrobble) da Last.fm.
- Garantisce che i tuoi dati siano sempre aggiornati senza intervento manuale.

### Database Locale della Cronologia Musicale

- Conserva tutti gli scrobble in un database locale SQLite.
- Permette interrogazioni rapide e accesso offline ai dati storici di ascolto.

### Vista Scrobble Recenti

- Mostra i tuoi brani più recenti.
- Logica intelligente di fallback immagini per brani, album e artisti.

### Confronto con Amici (Vista Compatibilità)

- Confronta i tuoi gusti musicali con gli amici di Last.fm.
- Mostra il livello di compatibilità (Molto Bassa → Super).
- Visualizza artisti, album e brani top in comune.
- Calcola e normalizza la compatibilità in base ai dati di ascolto reali.

### Schede Musicali Condivisibili

- Genera immagini dinamiche basate sui tuoi dati di ascolto.
- Layout ottimizzati per post nei feed e storie Instagram (9:16)

- Realizzato utilizzando node-canvas per il rendering delle immagini lato server.

## Prerequisiti

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installazione

### Crea un file `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Crea un account API [qui](https://www.last.fm/api/account/create) per ottenere la tua chiave API.

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

Sul terminale:
`docker compose up -d`

Quindi accedi:
```
http://localhost:1533
```

(o sostituisci `localhost` con l'indirizzo IP del tuo server)

## Licenza

Questo progetto è concesso in licenza secondo la Licenza MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---