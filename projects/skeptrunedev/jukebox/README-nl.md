<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

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
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Volg op X (Twitter)" />
  </a>
</p>

---
# Maak van elk apparaat een collaboratieve jukebox

**Jukebox** laat je direct een gedeelde afspeellijst met vrienden maken—geen app, geen login, geen advertenties. Maak gewoon een box aan, deel een link en begin samen liedjes toe te voegen. Perfect voor feestjes, roadtrips of elke groepsbijeenkomst!

- 🌐 **Open source alternatief voor Spotify Collaborative Playlists**
- 🕵️ **Geen account nodig**: Gebruik anoniem—geen registratie of e-mail vereist
- ✨ **Deel een link, voeg samen liedjes toe**: Iedereen kan in realtime bijdragen
- 🚀 **Geen app-download vereist**: Werkt op elk apparaat, direct in je browser
- 🎵 **YouTube-integratie**: Zoek en speel bijna elk nummer direct af
- 📱 **Mobielvriendelijk**: Ontworpen voor telefoons, tablets en desktops
- ⚖️ **Eerlijke wachtrij**: Liedjes worden automatisch gesorteerd zodat iedereen aan de beurt komt
- 🆓 **100% gratis, geen advertenties**

---

## Probeer het nu

1. **Maak een Jukebox aan**: Bezoek de homepage en maak een nieuwe box aan
2. **Deel de link**: Stuur de uitnodigingslink naar je vrienden
3. **Voeg liedjes toe**: Zoek op YouTube of voeg handmatig nummers toe
4. **Speel muziek af**: Gebruik de ingebouwde speler om samen te streamen

---
## Functies

- Collaboratieve afspeellijsten: Voeg samen nummers toe, zet ze in de wachtrij en speel ze af
- Anoniem gebruik: Geen login of account vereist
- YouTube-zoekfunctie & -afspelen: Toegang tot een enorme muziekbibliotheek
- Mobile-first, responsieve UI
- Open source (MIT-licentie)
- Eenvoudige implementatie met Docker

### Docker Compose-implementaties

Start alle services op:

```bash
docker-compose up -d
```

Herdeploy services zonder downtime na het bijwerken van images:

```bash
bash ./redeploy.sh
```
---

## Aan de slag

### Vereisten

- Node.js 16+
- npm of yarn
- YouTube Data API v3 sleutel (gratis van Google)

### YouTube API Instellen

1. Ga naar de [Google Cloud Console](https://console.cloud.google.com/)
2. Maak een nieuw project aan of selecteer een bestaand project
3. Schakel de **YouTube Data API v3** in
4. Maak referenties aan (API Sleutel)
5. Kopieer je API sleutel

### Installatie
```bash
# Clone de repository
git clone <your-repo-url>
cd jukebox

# Installeer serverafhankelijkheden
cd server
yarn install

# Installeer frontendafhankelijkheden
cd ../frontend
yarn install

# Configureer omgevingsvariabelen
cd ../server
cp .env.example .env
# Bewerk .env en voeg je YouTube API-sleutel toe

# Voer databasemigraties uit
```
yarn migrate

# Start de ontwikkelservers
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (in een nieuw terminalvenster):
cd frontend
yarn dev
```

---

## Licentie

MIT

---

## Bijdragen & Feedback

- Open een issue of pull request op [GitHub](https://github.com/skeptrunedev/jukebox)
- Functieaanvragen? Stuur een DM naar [@skeptrune op X (Twitter)](https://twitter.com/skeptrune)

---

## Wijzigingslog

Bekijk het [Wijzigingslog](https://jukebox.skeptrune.com#changelog) voor de laatste updates en functies.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---