# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Toekomstig plan is om te migreren naar ente-io/ente, omdat ik s3 nodig heb om foto's op te slaan~~
> 
> ente heeft toch te weinig functionaliteit
> 
> Overgestapt op gebruik van juicedata/juicefs voor het koppelen van s3

## Projectoverzicht

Dit project is een AI-mogelijkheden-uitbreidingsoplossing voor het [Immich](https://github.com/immich-app/immich) fotobeheersysteem. De native functies van Immich zijn vooral uitgebreid via de volgende componenten:

- **inference-gateway**: Gatewayservice geschreven in Go, verantwoordelijk voor het intelligent routeren van machine learning-verzoeken van Immich
- **mt-photos-ai**: AI-service gebaseerd op Python en FastAPI, geïntegreerd met RapidOCR en cn-clip-modellen
- Functie-uitbreiding voor Immich, waaronder OCR-tekstherkenning en -zoekfunctie, individuele media AI-data herverwerking, hybride sortering op basis van OCR-volledige tekstvectoren en CLIP-vectoren
- Toevoeging van zhparser Chinese woordsegmentatie aan PostgreSQL

## Belangrijkste functies

### 1. OCR Tekstherkenning en Zoeken

- Herkent tekst in afbeeldingen met RapidOCR
- Ondersteunt Chinees-Engelse gemengde tekstherkenning
- Implementeert zoekfunctionaliteit op basis van tekstinhoud in afbeeldingen

### 2. CLIP Afbeeldingsvectorverwerking

- Nauwkeurige Chinese beeld-tekst matching op basis van cn-clip-model
- Ondersteunt semantisch zoeken, verbetert zoeknauwkeurigheid

### 3. Individuele Media AI-data Herverwerking

- Ondersteunt het opnieuw genereren van OCR-data voor een enkele foto/video
- Ondersteunt het opnieuw genereren van CLIP-vectorgegevens voor een enkele foto/video
- Biedt handmatige vernieuwingsmogelijkheid bij onnauwkeurige herkenningsresultaten

## Systeemarchitectuur

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP-verzoeken
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python-service)│
                     │                  │
                     └──────────────────┘
```

## Componenten in detail

### inference-gateway

Gatewayservice geschreven in Go, belangrijkste verantwoordelijkheden:
- Ontvangen van machine learning-verzoeken van Immich
- Doorsturen van OCR- en CLIP-verzoeken naar de mt-photos-ai-service op basis van het type verzoek
- Andere machine learning-verzoeken (zoals gezichtsherkenning) doorsturen naar de native machine learning-service van Immich
- Afhandelen van authenticatie en gegevensformaatconversie

### mt-photos-ai

AI-service geschreven in Python en FastAPI, biedt:
- OCR-tekstherkennings-API (gebaseerd op RapidOCR)
- CLIP-vectorverwerkings-API (gebaseerd op cn-clip)
- Ondersteunt GPU-versnelling

## Deploy-instructies

### Vereisten

- Docker en Docker Compose
- NVIDIA GPU (optioneel, maar aanbevolen voor snellere verwerking)
- Voldoende opslagruimte

### Configuratie-instructies

1. **inference-gateway configuratie**

Belangrijkste omgevingsvariabelen:
```
IMMICH_API=http://localhost:3003  # Immich API-adres
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai serviceadres
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API-sleutel
PORT=8080  # Gateway luisterpoort
```

2. **mt-photos-ai configuratie**

Belangrijkste omgevingsvariabelen:
```
CLIP_MODEL=ViT-B-16  # CLIP-modelnaam
CLIP_DOWNLOAD_ROOT=./models/clip  # Model downloadpad
DEVICE=cuda  # Of cpu, inferentie-apparaat
HTTP_PORT=8060  # Service luisterpoort
```

### Deploy-stappen

1. Clone de repository:
```bash
git clone https://github.com/jouwgebruikersnaam/immich-all-in-one.git
cd immich-all-in-one
```

2. Start de services:
```bash
docker-compose up -d
```

## Gebruiksaanwijzing

1. **Configureer Immich om aangepaste ML-service te gebruiken**

Stel in het configuratiebestand van Immich het adres van de machine learning-service in op inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Gebruik van OCR-zoekfunctie**

- Gebruik het voorvoegsel `ocr:` in de zoekbalk van Immich voor OCR-zoekopdrachten
- Bijvoorbeeld: `ocr:factuur` zoekt naar foto's met het woord "factuur" in de afbeelding

3. **Individuele media AI-data herverwerking**

- Klik op de menukeuze op de detailpagina van een foto
- Kies "Genereer OCR-data opnieuw" of "Genereer CLIP-vector opnieuw"
- Het systeem verwerkt de AI-data van deze foto opnieuw

## Ontwikkelgids

### inference-gateway (Go)

Compileer en start:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Instellen ontwikkelomgeving:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licentie

Dit project is open source onder de MIT-licentie.

## Dankwoord

- [Immich](https://github.com/immich-app/immich) - Open source self-hosted foto- en videoback-upoplossing
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Cross-platform OCR-bibliotheek gebaseerd op PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinese multi-modale contrastief pre-train model

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---