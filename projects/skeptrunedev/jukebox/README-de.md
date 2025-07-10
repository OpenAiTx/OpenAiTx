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
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Folgen Sie auf X (Twitter)" />
  </a>
</p>

---
# Verwandle jedes Gerät in eine kollaborative Jukebox

**Jukebox** ermöglicht es dir, sofort eine gemeinsame Musik-Playlist mit Freunden zu erstellen – keine App, kein Login, keine Werbung. Einfach eine Box erstellen, Link teilen und gemeinsam Songs hinzufügen. Perfekt für Partys, Roadtrips oder jedes Gruppentreffen!

- 🌐 **Open-Source-Alternative zu Spotify-Kollaborativen Playlists**
- 🕵️ **Kein Account nötig**: Anonyme Nutzung – keine Anmeldung oder E-Mail erforderlich
- ✨ **Link teilen, gemeinsam Songs hinzufügen**: Jeder kann in Echtzeit beitragen
- 🚀 **Kein App-Download nötig**: Funktioniert auf jedem Gerät direkt im Browser
- 🎵 **YouTube-Integration**: Suche und spiele fast jeden Song sofort ab
- 📱 **Mobilfreundlich**: Für Smartphones, Tablets und Desktops optimiert
- ⚖️ **Faires Warteschlangensystem**: Songs werden automatisch sortiert, damit jeder dran kommt
- 🆓 **100% kostenlos, keine Werbung**

---

## Jetzt ausprobieren

1. **Jukebox erstellen**: Besuche die Startseite und erstelle eine neue Box
2. **Link teilen**: Sende den Einladungslink an deine Freunde
3. **Songs hinzufügen**: Suche auf YouTube oder füge Songs manuell hinzu
4. **Musik abspielen**: Nutze den integrierten Player, um gemeinsam zu streamen

---
## Funktionen

- Kollaborative Playlists: Gemeinsam Songs hinzufügen, in die Warteschlange stellen und abspielen
- Anonyme Nutzung: Kein Login oder Konto erforderlich
- YouTube-Suche & Wiedergabe: Zugriff auf eine riesige Musikbibliothek
- Mobile-First, responsives UI
- Open Source (MIT-Lizenz)
- Einfache Bereitstellung mit Docker

### Docker-Compose-Bereitstellungen

Alle Dienste starten:

```bash
docker-compose up -d
```

Dienste mit null Ausfallzeit nach dem Aktualisieren der Images neu bereitstellen:

```bash
bash ./redeploy.sh
```
---

## Erste Schritte

### Voraussetzungen

- Node.js 16+
- npm oder yarn
- YouTube Data API v3 Schlüssel (kostenlos von Google)

### YouTube API Einrichtung

1. Gehe zur [Google Cloud Console](https://console.cloud.google.com/)
2. Erstelle ein neues Projekt oder wähle ein bestehendes aus
3. Aktiviere die **YouTube Data API v3**
4. Erstelle Zugangsdaten (API-Schlüssel)
5. Kopiere deinen API-Schlüssel

### Installation
```bash
# Repository klonen
git clone <dein-repo-url>
cd jukebox

# Server-Abhängigkeiten installieren
cd server
yarn install

# Frontend-Abhängigkeiten installieren
cd ../frontend
yarn install

# Umgebungsvariablen konfigurieren
cd ../server
cp .env.example .env
# Bearbeite .env und füge deinen YouTube API-Schlüssel hinzu

# Datenbankmigrationen ausführen
```
yarn migrate

# Starte die Entwicklungsserver
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (in einem neuen Terminal):
cd frontend
yarn dev
```

---

## Lizenz

MIT

---
## Beitrag & Feedback

- Eröffne ein Issue oder einen Pull Request auf [GitHub](https://github.com/skeptrunedev/jukebox)
- Feature-Wünsche? Schreibe eine DM an [@skeptrune auf X (Twitter)](https://twitter.com/skeptrune)

---

## Changelog

Siehe das [Changelog](https://jukebox.skeptrune.com#changelog) für die neuesten Updates und Funktionen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---