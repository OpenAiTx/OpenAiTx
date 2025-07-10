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
# Trasforma Qualsiasi Dispositivo in un Jukebox Collaborativo

**Jukebox** ti permette di creare istantaneamente una playlist musicale condivisa con gli amici—senza app, senza login, senza pubblicità. Basta creare una box, condividere un link e iniziare ad aggiungere canzoni insieme. Perfetto per feste, viaggi in auto o qualsiasi ritrovo di gruppo!

- 🌐 **Alternativa Open Source alle Playlist Collaborative di Spotify**
- 🕵️ **Nessun Account Necessario**: Usalo in modo anonimo—senza registrazione né email richiesta
- ✨ **Condividi un Link, Aggiungi Canzoni Insieme**: Tutti possono contribuire in tempo reale
- 🚀 **Nessun Download di App Richiesto**: Funziona su qualsiasi dispositivo, direttamente nel browser
- 🎵 **Integrazione con YouTube**: Cerca e riproduci quasi qualsiasi canzone all’istante
- 📱 **Ottimizzato per Mobile**: Progettato per telefoni, tablet e desktop
- ⚖️ **Coda Equa**: Le canzoni vengono ordinate automaticamente così tutti hanno il proprio turno
- 🆓 **100% Gratuito, Senza Pubblicità**

---

## Provalo Subito

1. **Crea un Jukebox**: Visita la homepage e crea una nuova box
2. **Condividi il Link**: Invia il link di invito ai tuoi amici
3. **Aggiungi Canzoni**: Cerca su YouTube o aggiungi manualmente le canzoni
4. **Riproduci Musica**: Usa il player integrato per ascoltare insieme

---
## Funzionalità

- Playlist collaborative: aggiungi, metti in coda e riproduci brani insieme
- Utilizzo anonimo: nessun login o account richiesto
- Ricerca e riproduzione da YouTube: accesso a un'enorme libreria musicale
- Interfaccia utente mobile-first e reattiva
- Open source (Licenza MIT)
- Distribuzione semplice con Docker

### Deployment con Docker Compose

Avvia tutti i servizi:

```bash
docker-compose up -d
```

Ridistribuisci i servizi senza tempi di inattività dopo aver aggiornato le immagini:

```bash
bash ./redeploy.sh
```
---

## Guida introduttiva

### Prerequisiti

- Node.js 16+
- npm o yarn
- Chiave API YouTube Data v3 (gratuita da Google)

### Configurazione API di YouTube

1. Vai alla [Google Cloud Console](https://console.cloud.google.com/)
2. Crea un nuovo progetto o selezionane uno esistente
3. Abilita **YouTube Data API v3**
4. Crea le credenziali (Chiave API)
5. Copia la tua chiave API

### Installazione
```bash
# Clona il repository
git clone <your-repo-url>
cd jukebox

# Installa le dipendenze del server
cd server
yarn install

# Installa le dipendenze del frontend
cd ../frontend
yarn install

# Configura le variabili d'ambiente
cd ../server
cp .env.example .env
# Modifica .env e aggiungi la tua chiave API di YouTube

# Esegui le migrazioni del database
```
yarn migrate

# Avvia i server di sviluppo
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (in un nuovo terminale):
cd frontend
yarn dev
```

---

## Licenza

MIT

---
## Contributi & Feedback

- Apri una issue o una pull request su [GitHub](https://github.com/skeptrunedev/jukebox)
- Richieste di funzionalità? Scrivi un DM a [@skeptrune su X (Twitter)](https://twitter.com/skeptrune)

---

## Changelog

Consulta il [Changelog](https://jukebox.skeptrune.com#changelog) per gli ultimi aggiornamenti e funzionalità.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---