# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Geplant ist die Migration zu ente-io/ente, da ich S3 für die Speicherung von Fotos benötige~~
> 
> ente bietet immer noch zu wenige Funktionen
> 
> Umstellung auf juicedata/juicefs zur Einbindung von S3

## Projektübersicht

Dieses Projekt ist eine KI-Fähigkeitserweiterung für das [Immich](https://github.com/immich-app/immich) Fotoverwaltungssystem. Die nativen Funktionen von Immich werden hauptsächlich durch folgende Komponenten erweitert:

- **inference-gateway**: In Go geschriebener Gateway-Service, der das intelligente Routing von Machine-Learning-Anfragen von Immich übernimmt
- **mt-photos-ai**: KI-Service auf Basis von Python und FastAPI, integriert RapidOCR und das cn-clip Modell
- Erweiterung der Immich-Funktionalität, einschließlich OCR-Text-Erkennungssuche und erneuter Verarbeitung von KI-Daten einzelner Medien, hybride Sortierung mit OCR-Vektor und CLIP-Vektorscore
- Hinzufügen von zhparser für chinesische Segmentierung in PostgreSQL

## Hauptfunktionen

### 1. OCR Texterkennung und Suche

- Nutzung von RapidOCR zur Erkennung von Text in Bildern
- Unterstützung von gemischtem chinesisch-englischem Text
- Implementierung einer Suchfunktion basierend auf dem Textinhalt von Bildern

### 2. CLIP Bildvektorverarbeitung

- Genauere chinesische Bild-Text-Zuordnung basierend auf dem cn-clip Modell
- Unterstützung semantischer Suche zur Verbesserung der Suchgenauigkeit

### 3. Erneute Verarbeitung von KI-Daten einzelner Medien

- Unterstützung der erneuten Generierung von OCR-Daten für einzelne Bilder/Videos
- Unterstützung der erneuten Generierung von CLIP-Vektordaten für einzelne Bilder/Videos
- Manuelle Aktualisierungsmöglichkeit bei ungenauen Erkennungsergebnissen

## Systemarchitektur

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

## Komponentenbeschreibung

### inference-gateway

In Go geschriebener Gateway-Service, Hauptaufgaben:
- Empfängt Machine-Learning-Anfragen von Immich
- Leitet OCR- und CLIP-Anfragen je nach Typ an den mt-photos-ai-Service weiter
- Leitet andere Machine-Learning-Anfragen (wie Gesichtserkennung) an den nativen ML-Service von Immich weiter
- Übernimmt Authentifizierung und Datenformatumwandlung

### mt-photos-ai

In Python und FastAPI geschriebener KI-Service, bietet:
- OCR Texterkennungs-API (basiert auf RapidOCR)
- CLIP-Vektorverarbeitungs-API (basiert auf cn-clip)
- Unterstützung von GPU-Beschleunigung

## Deployment-Anleitung

### Systemanforderungen

- Docker und Docker Compose
- NVIDIA GPU (optional, aber empfohlen zur Beschleunigung)
- Ausreichend Speicherplatz

### Konfigurationshinweise

1. **Konfiguration von inference-gateway**

Wichtige Umgebungsvariablen:
```
IMMICH_API=http://localhost:3003  # Immich API-Adresse
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai-Service-Adresse
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API-Schlüssel
PORT=8080  # Gateway-Port
```

2. **Konfiguration von mt-photos-ai**

Wichtige Umgebungsvariablen:
```
CLIP_MODEL=ViT-B-16  # Name des CLIP-Modells
CLIP_DOWNLOAD_ROOT=./models/clip  # Download-Pfad für das Modell
DEVICE=cuda  # oder cpu, Ausführungsgerät
HTTP_PORT=8060  # Service-Port
```

### Deploymentschritte

1. Repository klonen:
```bash
git clone https://github.com/DEIN-BENUTZERNAME/immich-all-in-one.git
cd immich-all-in-one
```

2. Dienste starten:
```bash
docker-compose up -d
```

## Anwendungshinweise

1. **Immich für den Einsatz des benutzerdefinierten ML-Services konfigurieren**

In der Immich-Konfigurationsdatei die Machine-Learning-Service-Adresse auf inference-gateway setzen:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR-Suche verwenden**

- Im Immich-Suchfeld das Präfix `ocr:` für die OCR-Suche verwenden
- Beispiel: `ocr:Rechnung` sucht nach Fotos, die den Text "Rechnung" im Bild enthalten

3. **Erneute Verarbeitung von KI-Daten einzelner Medien**

- Im Fotodetail-Menü die entsprechenden Optionen auswählen
- "OCR-Daten neu generieren" oder "CLIP-Vektor neu generieren" wählen
- Das System verarbeitet die KI-Daten für dieses Foto neu

## Entwicklerhandbuch

### inference-gateway (Go)

Kompilieren und ausführen:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Entwicklungsumgebung einrichten:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Lizenz

Dieses Projekt ist unter der MIT-Lizenz als Open Source verfügbar.

## Danksagung

- [Immich](https://github.com/immich-app/immich) - Open-Source Self-Hosting-Lösung für Foto- und Video-Backups
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Cross-Platform OCR-Bibliothek basierend auf PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinesisches multimodales kontrastives Pretraining-Modell

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---