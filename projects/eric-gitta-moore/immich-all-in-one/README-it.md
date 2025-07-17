# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~In futuro prevedo di migrare a ente-io/ente, poiché ho bisogno di s3 per archiviare le foto~~
> 
> ente ha ancora troppe poche funzionalità
> 
> Cambiato in utilizzo di juicedata/juicefs per montare s3

## Introduzione al progetto

Questo progetto è una soluzione di potenziamento AI per il sistema di gestione foto [Immich](https://github.com/immich-app/immich). Estende principalmente le funzionalità native di Immich tramite i seguenti componenti:

- **inference-gateway**: servizio gateway scritto in Go, responsabile dell'instradamento intelligente delle richieste di machine learning di Immich
- **mt-photos-ai**: servizio AI basato su Python e FastAPI, integra i modelli RapidOCR e cn-clip
- Estensione delle funzionalità Immich, inclusa la ricerca testo OCR e la rielaborazione dei dati AI su singoli media, ranking misto di vettori testo OCR e vettori CLIP
- Aggiunta di zhparser per la segmentazione cinese su PostgreSQL

## Funzionalità principali

### 1. Riconoscimento e ricerca testo OCR

- Utilizza RapidOCR per il riconoscimento del testo nelle immagini
- Supporta il riconoscimento di testo misto cinese e inglese
- Implementa la ricerca basata sul contenuto testuale delle immagini

### 2. Elaborazione vettori immagine CLIP

- Implementa un matching immagine-testo più accurato in cinese tramite il modello cn-clip
- Supporta ricerca semantica, migliorando la precisione dei risultati

### 3. Rielaborazione dati AI su singolo media

- Supporta la rigenerazione dei dati OCR per singole immagini/video
- Supporta la rigenerazione dei vettori CLIP per singole immagini/video
- Fornisce la possibilità di aggiornamento manuale in caso di riconoscimento non accurato

## Architettura di sistema

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Dettagli dei componenti

### inference-gateway

Servizio gateway scritto in Go, responsabilità principali:
- Riceve le richieste di machine learning da Immich
- In base al tipo di richiesta, inoltra le richieste OCR e CLIP al servizio mt-photos-ai
- Inoltra altre richieste di machine learning (come il riconoscimento facciale) al servizio di machine learning nativo di Immich
- Gestisce autenticazione e conversione dei formati dati

### mt-photos-ai

Servizio AI scritto in Python e FastAPI, offre:
- API di riconoscimento testo OCR (basata su RapidOCR)
- API di elaborazione vettoriale CLIP (basata su cn-clip)
- Supporto per accelerazione GPU

## Istruzioni di deploy

### Requisiti ambientali

- Docker e Docker Compose
- GPU NVIDIA (opzionale, ma consigliata per accelerare l'elaborazione)
- Spazio di archiviazione sufficiente

### Istruzioni di configurazione

1. **Configurazione di inference-gateway**

Principali variabili di ambiente:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Configurazione di mt-photos-ai**

Principali variabili d'ambiente:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Passaggi di distribuzione

1. Clona il repository:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Avviare il servizio:

```bash
docker-compose up -d
```
## Istruzioni per l'uso

1. **Configurare Immich per utilizzare un servizio ML personalizzato**

Nel file di configurazione di Immich, indirizza l'indirizzo del servizio di machine learning verso inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Utilizzo della ricerca OCR**

- Utilizzare il prefisso `ocr:` nella barra di ricerca di Immich per effettuare una ricerca OCR
- Ad esempio: `ocr:fattura` cercherà le foto che contengono la parola "fattura" nell'immagine

3. **Rielaborazione dei dati AI di un singolo media**

- Nella pagina dei dettagli della foto, cliccare sulle opzioni del menu
- Selezionare "Rigenera dati OCR" o "Rigenera vettori CLIP"
- Il sistema rielaborerà i dati AI di quella foto

## Guida allo sviluppo

### inference-gateway (Go)

Compilazione ed esecuzione:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Impostazione dell'ambiente di sviluppo:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Licenza

Questo progetto è open source sotto licenza MIT.

## Ringraziamenti

- [Immich](https://github.com/immich-app/immich) - Soluzione open source per il backup self-hosted di foto e video
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Libreria OCR cross-platform basata su PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modello pre-addestrato di apprendimento contrastivo multimodale in cinese



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---