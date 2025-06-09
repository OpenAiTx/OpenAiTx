# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~In futuro pianifico di migrare a ente-io/ente, perché ho bisogno di s3 per archiviare le foto~~
> 
> Ente ha ancora troppe poche funzionalità
> 
> Modificato per usare juicedata/juicefs per montare s3

## Introduzione al progetto

Questo progetto è una soluzione di potenziamento AI per il sistema di gestione foto [Immich](https://github.com/immich-app/immich). Principalmente estende le funzionalità native di Immich tramite i seguenti componenti:

- **inference-gateway**: servizio gateway scritto in Go, responsabile dell’instradamento intelligente delle richieste di machine learning di Immich
- **mt-photos-ai**: servizio AI basato su Python e FastAPI, integra i modelli RapidOCR e cn-clip
- Estensione delle funzionalità di Immich, tra cui ricerca e riconoscimento testo OCR e rielaborazione dei dati AI per singolo media, ordinamento ibrido tra vettori OCR completi e vettori CLIP
- Aggiunta di zhparser per la segmentazione delle parole cinesi in PostgreSQL

## Funzionalità principali

### 1. Riconoscimento e ricerca del testo tramite OCR

- Utilizza RapidOCR per riconoscere il testo nelle immagini
- Supporto per il riconoscimento di testo misto cinese e inglese
- Implementa la ricerca basata sul contenuto testuale delle immagini

### 2. Elaborazione dei vettori di immagini CLIP

- Basato sul modello cn-clip per un matching immagine-testo in cinese più accurato
- Supporta la ricerca semantica, migliorando la precisione delle ricerche

### 3. Rielaborazione dei dati AI per singolo media

- Supporta la rigenerazione dei dati OCR per singole immagini/video
- Supporta la rigenerazione dei vettori CLIP per singole immagini/video
- Offre la possibilità di aggiornamento manuale in caso di risultati di riconoscimento non accurati

## Architettura del sistema

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ Richieste OCR/CLIP
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Servizio Python)│
                     │                  │
                     └──────────────────┘
```

## Dettagli dei componenti

### inference-gateway

Servizio gateway scritto in Go, principali responsabilità:
- Riceve le richieste di machine learning da Immich
- Inoltra le richieste OCR e CLIP al servizio mt-photos-ai in base al tipo di richiesta
- Inoltra le altre richieste di machine learning (come riconoscimento facciale) al servizio ML nativo di Immich
- Gestisce autenticazione e conversione del formato dati

### mt-photos-ai

Servizio AI scritto in Python e FastAPI, offre:
- API di riconoscimento testo OCR (basata su RapidOCR)
- API di elaborazione vettori CLIP (basata su cn-clip)
- Supporta l’accelerazione GPU

## Istruzioni di deploy

### Requisiti ambientali

- Docker e Docker Compose
- NVIDIA GPU (opzionale, ma consigliata per un’elaborazione più veloce)
- Spazio di archiviazione sufficiente

### Istruzioni di configurazione

1. **Configurazione di inference-gateway**

Principali variabili d’ambiente:
```
IMMICH_API=http://localhost:3003  # Indirizzo API di Immich
MT_PHOTOS_API=http://localhost:8060  # Indirizzo del servizio mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # Chiave API
PORT=8080  # Porta di ascolto del gateway
```

2. **Configurazione di mt-photos-ai**

Principali variabili d’ambiente:
```
CLIP_MODEL=ViT-B-16  # Nome del modello CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Percorso di download del modello
DEVICE=cuda  # oppure cpu, dispositivo di inferenza
HTTP_PORT=8060  # Porta di ascolto del servizio
```

### Passaggi per il deploy

1. Clona il repository:
```bash
git clone https://github.com/tuo-username/immich-all-in-one.git
cd immich-all-in-one
```

2. Avvia i servizi:
```bash
docker-compose up -d
```

## Istruzioni d’uso

1. **Configura Immich per usare il servizio ML personalizzato**

Nel file di configurazione di Immich, imposta l’indirizzo del servizio di machine learning su inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Uso della ricerca OCR**

- Nella barra di ricerca di Immich, usa il prefisso `ocr:` per effettuare una ricerca OCR
- Ad esempio: `ocr:fattura` cercherà le foto che contengono il testo "fattura" nelle immagini

3. **Rielaborazione dei dati AI per singolo media**

- Nella pagina dei dettagli della foto, clicca sulle opzioni del menu
- Seleziona "Rigenera dati OCR" oppure "Rigenera vettore CLIP"
- Il sistema rielaborerà i dati AI per quella foto

## Guida allo sviluppo

### inference-gateway (Go)

Compilazione ed esecuzione:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Configurazione dell’ambiente di sviluppo:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licenza

Questo progetto è open source sotto licenza MIT.

## Ringraziamenti

- [Immich](https://github.com/immich-app/immich) - Soluzione open source self-hosted per backup di foto e video
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Libreria OCR multipiattaforma basata su PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modello di pre-addestramento per apprendimento contrastivo multimodale in cinese

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---