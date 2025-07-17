# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Geplant ist die Migration zu ente-io/ente, da ich S3 zur Speicherung der Fotos benötige~~
> 
> ente bietet immer noch zu wenige Funktionen
> 
> Umstellung auf juicedata/juicefs zur Einbindung von S3

## Projektübersicht

Dieses Projekt ist eine KI-Erweiterungslösung für das [Immich](https://github.com/immich-app/immich) Fotoverwaltungssystem. Die nativen Funktionen von Immich werden dabei hauptsächlich durch folgende Komponenten erweitert:

- **inference-gateway**: Ein in Go geschriebenes Gateway-Service, das für die intelligente Verteilung von Machine-Learning-Anfragen von Immich verantwortlich ist
- **mt-photos-ai**: Ein KI-Service auf Basis von Python und FastAPI, der RapidOCR und cn-clip Modelle integriert
- Erweiterung der Immich-Funktionalität, einschließlich OCR-Textsuche und erneute Verarbeitung von KI-Daten einzelner Medien, kombinierte Sortierung von OCR-Volltext-Vektoren und CLIP-Vektoren
- Hinzufügen des zhparser für chinesische Worttrennung in PostgreSQL

## Hauptfunktionen

### 1. OCR Texterkennung und -suche

- Verwendung von RapidOCR zur Texterkennung in Bildern
- Unterstützung für gemischte chinesisch-englische Texterkennung
- Implementierung einer Suchfunktion basierend auf dem Textinhalt von Bildern

### 2. CLIP Bildvektor-Verarbeitung

- Genauere chinesische Bild-Text-Zuordnung basierend auf dem cn-clip Modell
- Unterstützung für semantische Suche, um die Suchgenauigkeit zu erhöhen

### 3. Einzelmedien-KI-Daten erneute Verarbeitung

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
## Komponenten-Details

### inference-gateway

Gateway-Service, geschrieben in Go, Hauptaufgaben:
- Entgegennahme von Machine-Learning-Anfragen von Immich
- Weiterleitung von OCR- und CLIP-Anfragen je nach Typ an den mt-photos-ai-Service
- Weiterleitung anderer Machine-Learning-Anfragen (z. B. Gesichtserkennung) an den nativen Machine-Learning-Service von Immich
- Verarbeitung von Authentifizierung und Datenformat-Konvertierung

### mt-photos-ai

AI-Service, geschrieben in Python und FastAPI, bietet:
- OCR Texterkennungs-API (basiert auf RapidOCR)
- CLIP Vektorverarbeitungs-API (basiert auf cn-clip)
- Unterstützt GPU-Beschleunigung

## Bereitstellungshinweise

### Systemvoraussetzungen

- Docker und Docker Compose
- NVIDIA GPU (optional, aber empfohlen zur Beschleunigung)
- Ausreichend Speicherplatz

### Konfigurationshinweise

1. **inference-gateway Konfiguration**

Wichtige Umgebungsvariablen:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai Konfiguration**

Wichtige Umgebungsvariablen:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Bereitstellungsschritte

1. Repository klonen:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Dienst starten:

```bash
docker-compose up -d
```
## Gebrauchsanweisung

1. **Immich für die Verwendung eines benutzerdefinierten ML-Dienstes konfigurieren**

Im Konfigurationsfile von Immich die Adresse des Machine-Learning-Dienstes auf inference-gateway setzen:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Verwendung der OCR-Suche**

- Verwenden Sie im Immich-Suchfeld das Präfix `ocr:` für die OCR-Suche
- Beispiel: `ocr:Rechnung` sucht nach Fotos, die den Text "Rechnung" im Bild enthalten

3. **AI-Daten für einzelne Medien neu verarbeiten**

- Klicken Sie auf der Fotodetailseite auf die Menüoptionen
- Wählen Sie "OCR-Daten neu generieren" oder "CLIP-Vektor neu generieren"
- Das System wird die AI-Daten dieses Fotos neu verarbeiten

## Entwicklerhandbuch

### inference-gateway (Go)

Kompilieren und ausführen:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Entwicklungsumgebungseinrichtung:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Lizenz

Dieses Projekt ist unter der MIT-Lizenz als Open Source verfügbar.

## Danksagung

- [Immich](https://github.com/immich-app/immich) - Open-Source Self-Hosting-Lösung für Foto- und Video-Backups
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Plattformübergreifende OCR-Bibliothek basierend auf PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinesisches Multimodales Kontrastives Lern-Vortrainingsmodell



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---