
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licenza: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Compilatori Supportati](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![Chiedi a DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![Test Unitari](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - La pecora nera per le tue registrazioni di volo.

## Informazioni
Sky Dolly si connette a un'istanza in esecuzione di Flight Simulator 2020 e registra varie variabili di simulazione, per la riproduzione.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

La connessione avviene tramite SimConnect, un'API standard introdotta con Flight Simulator X per connettersi al simulatore di volo.

Consulta anche [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Caratteristiche
- Registra / Pausa / Riproduci
- Volo in formazione (aerei multipli, replay durante la registrazione, "vola con la formazione", offset temporale)
- Frequenza di campionamento registrazione impostabile: fissa o variabile ("auto")
- Velocità di riproduzione regolabile ("slow motion", "timelapse"), riproduzione in loop
- Vengono registrate posizione, velocità e variabili di controllo di volo basilari (aileroni, timone, flap, carrelli, ...)
- Architettura a plugin con vari plugin di importazione/esportazione (CSV, GPX, IGC, KML)
- Modulo delle località con oltre 100 località predefinite e funzionalità di importazione/esportazione
- Persistenza basata su database (SQLite) ("registro di volo")

Guarda il trailer della versione (anteprima) su [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Registratore di volo & Replay per Flight Simulator 2020 (Trailer Cinematico)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Registratore di volo & Replay per Flight Simulator 2020 (Trailer Cinematico)")

Per altri video creati con Sky Dolly consulta anche [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Nuove funzionalità e quelle in arrivo si trovano nel [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Utilizzo Base

- Avvia un volo
- Clicca su "Registra" (tasto R)
- Puoi mettere in pausa la registrazione (tasto P)
- Ferma la registrazione (tasto R) e clicca su "Riproduci" (barra spaziatrice)
- Regola la velocità di riproduzione e cerca la posizione di riproduzione, anche durante la riproduzione
- I voli registrati vengono automaticamente salvati nel "registro di volo"
- Seleziona un volo nel registro di volo e premi "Carica" (o fai doppio clic sulla riga) per caricare il volo salvato

### Registrazione & Replay in Formazione

#### Registrazione

- Passa al modulo "Formazione" (tasto F2)
- Clicca su "Registra" (tasto R)
- Ogni velivolo registrato viene aggiunto al volo corrente
- Mentre i velivoli esistenti vengono riprodotti durante la registrazione con il campionamento "auto", puoi comunque modificare la frequenza di campionamento della registrazione

#### Posizione

- L'ultimo velivolo registrato diventa il "velivolo utente" (seguito dalla telecamera nel simulatore di volo)
- Seleziona una posizione relativa all'attuale "velivolo utente" prima della registrazione

#### Riproduzione

- Basta cliccare su "Play", "Pausa" e cercare nella timeline, proprio come con un volo singolo
- Cambia il "velivolo utente" (anche durante la riproduzione) per "saltare da una cabina all'altra"
- Prendi il controllo del "velivolo utente" selezionando l'opzione "Prendi il controllo" o "Vola con la formazione"

#### Gestione delle Formazioni

- Puoi eliminare singoli velivoli da un volo ("formazione")
- Deve esserci almeno un velivolo per volo, quindi l'ultimo velivolo non può essere eliminato
- Aggiungi un offset temporale al velivolo selezionato ("sincronizzazione volo formazione multiplayer")
- Per iniziare un nuovo volo con un solo velivolo torna al modulo "Logbook" (tasto F1) e clicca su "Registra" (tasto R)

Perché non provi con uno dei ["Tell Tours"](https://github.com/till213/Tell-Tours) guidati? :)

## Download

Vai su [Rilasci](https://github.com/till213/SkyDolly/releases) e scarica l'ultima versione.

Ultima (pre-)release: **Sky Dolly 0.19.2**

Calcola e confronta il tuo checksum con i [checksum SHA-256 pubblicati](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), per verificare l'integrità della copia scaricata.

## Build

Consulta la documentazione [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Progetti correlati

- https://github.com/nguyenquyhy/Flight-Recorder - Un'applicazione .Net per la registrazione e la riproduzione dei voli
- https://github.com/saltysimulations/saltyreplay/ - Registrazione e riproduzione con interfaccia utente web
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Registra il volo e genera "replay" in formato Google Earth (KML)
- https://github.com/Elephant42/FS_Tool - Un semplice strumento che permette di impostare la posizione dell'aereo e il rateo di simulazione
- https://github.com/pyviator/msfs-geoshot - Scatta screenshot e li "geotagga" automaticamente
- https://github.com/ijl20/msfs_logger_replay - Logger e replay IGC (per FSX)
- https://joinfs.net/ - Permette di sincronizzare i voli multiplayer tra diversi simulatori (MSFS, Prepar3D/FSX, XPlane). Include anche un registratore di voli con registrazione di voli in formazione ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote per FlyByWire's A32NX: controlla le funzioni del cockpit dell'FBW A320, tramite FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analizza il logbook di MSFS e consente l'esportazione CSV leggibile da Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave salva automaticamente (o su richiesta) i piani di volo
- https://github.com/mracko/MSFS-Landing-Inspector - Analizza la tua performance di atterraggio
- [Punti di Interesse (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Punti di interesse, aeroporti e città 3D in Microsoft Flight Simulator.

## Altre Risorse Utili

- https://obsproject.com/ - Applicazione per cattura schermo / trasmissione
- https://sqlitebrowser.org/ - Sfoglia i file di database del logbook Sky Dolly (*.sdlog), esegui le tue query SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---