# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Toekomstige plannen om te migreren naar ente-io/ente, omdat ik s3 nodig heb voor het opslaan van foto's~~
> 
> ente heeft toch te weinig functionaliteit
> 
> Omschakelen naar het gebruik van juicedata/juicefs om s3 te mounten

## Projectoverzicht

Dit project is een AI-capaciteiten uitbreidingsoplossing voor het [Immich](https://github.com/immich-app/immich) foto managementsysteem. De native functionaliteiten van Immich zijn uitgebreid met de volgende componenten:

- **inference-gateway**: Een gatewayservice geschreven in Go, verantwoordelijk voor het intelligent routeren van de machine learning verzoeken van Immich
- **mt-photos-ai**: Een AI-service gebaseerd op Python en FastAPI, integreert RapidOCR en het cn-clip model
- Functionaliteitsuitbreiding voor Immich, waaronder OCR tekstherkenning en zoeken, AI-herverwerking van enkele media, volledige OCR-tekst en CLIP-vector scoring en gemengde ranking
- Toevoeging van zhparser Chinese segmentatie aan PostgreSQL

## Belangrijkste functionaliteiten

### 1. OCR Tekstherkenning en Zoeken

- Herken tekst in afbeeldingen met RapidOCR
- Ondersteunt gemengde Chinees-Engelse tekstdetectie
- Implementeert zoeken op basis van tekstinhoud in afbeeldingen

### 2. CLIP Afbeeldingsvectorverwerking

- Nauwkeurigere Chinese afbeelding-tekst matching op basis van het cn-clip model
- Ondersteunt semantisch zoeken voor een hogere zoeknauwkeurigheid

### 3. AI-herverwerking van enkele media

- Ondersteunt het opnieuw genereren van OCR-gegevens voor een enkele afbeelding/video
- Ondersteunt het opnieuw genereren van CLIP-vectorgegevens voor een enkele afbeelding/video
- Biedt handmatige verversingsmogelijkheid wanneer herkenningsresultaten onnauwkeurig zijn

## Systeemarchitectuur

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
## Componenten Gedetailleerd Uitgelegd

### inference-gateway

Gateway-service geschreven in Go, met de volgende hoofdtaken:
- Ontvangen van machine learning-verzoeken van Immich
- Doorsturen van OCR- en CLIP-verzoeken naar de mt-photos-ai-service op basis van het type verzoek
- Doorsturen van andere machine learning-verzoeken (zoals gezichtsherkenning) naar de native machine learning-service van Immich
- Afhandelen van authenticatie en gegevensformaatconversie

### mt-photos-ai

AI-service geschreven in Python en FastAPI, biedt:
- OCR-tekstherkennings-API (gebaseerd op RapidOCR)
- CLIP-vectorverwerkings-API (gebaseerd op cn-clip)
- Ondersteuning voor GPU-versnelling

## Deploy-instructies

### Vereisten voor de omgeving

- Docker en Docker Compose
- NVIDIA GPU (optioneel, maar aanbevolen voor snellere verwerking)
- Voldoende opslagruimte

### Configuratie-instructies

1. **inference-gateway configuratie**

Belangrijkste omgevingsvariabelen:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai configuratie**

Belangrijkste omgevingsvariabelen:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Implementatiestappen

1. Repository klonen:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Start de service:

```bash
docker-compose up -d
```
## Gebruiksaanwijzing

1. **Stel Immich in om een aangepaste ML-service te gebruiken**

Wijs in het configuratiebestand van Immich het adres van de machine learning-service naar de inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR-zoekfunctie gebruiken**

- Gebruik de prefix `ocr:` in de zoekbalk van Immich om op OCR te zoeken
- Bijvoorbeeld: `ocr:factuur` zoekt naar foto's met het woord "factuur" in de afbeelding

3. **AI-gegevens van één media-item opnieuw verwerken**

- Ga naar de detailpagina van de foto en klik op het menu
- Kies "OCR-gegevens opnieuw genereren" of "CLIP-vector opnieuw genereren"
- Het systeem zal de AI-gegevens van deze foto opnieuw verwerken

## Ontwikkelaarsgids

### inference-gateway (Go)

Compileren en uitvoeren:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Instellen van de ontwikkelomgeving:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Licentie

Dit project is open source onder de MIT-licentie.

## Dankbetuigingen

- [Immich](https://github.com/immich-app/immich) - Open source, zelfgehoste foto- en videoback-upoplossing
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Cross-platform OCR-bibliotheek gebaseerd op PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinees multimodaal contrastief leren pre-trainingsmodel



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---