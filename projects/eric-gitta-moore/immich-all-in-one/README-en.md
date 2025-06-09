# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~The plan is to migrate to ente-io/ente in the future, since I need s3 to store photos~~
>
> Ente still lacks features
>
> Changed to use juicedata/juicefs to mount s3

## Project Overview

This project is an AI capability enhancement solution for the [Immich](https://github.com/immich-app/immich) photo management system. It mainly extends Immich's native functions through the following components:

- **inference-gateway**: A gateway service written in Go, responsible for intelligently routing Immich’s machine learning requests
- **mt-photos-ai**: An AI service based on Python and FastAPI, integrating RapidOCR and cn-clip models
- Immich feature extensions, including OCR text recognition search, single media AI data reprocessing, OCR full-text vector and CLIP vector score hybrid ranking
- Add zhparser Chinese word segmentation to PostgreSQL

## Main Features

### 1. OCR Text Recognition and Search

- Uses RapidOCR to recognize text in images
- Supports Chinese-English mixed text recognition
- Implements search functionality based on the text content in images

### 2. CLIP Image Vector Processing

- Implements more accurate Chinese image-to-text matching based on the cn-clip model
- Supports semantic search, improving search accuracy

### 3. Single Media AI Data Reprocessing

- Supports regenerating OCR data for a single image/video
- Supports regenerating CLIP vector data for a single image/video
- Provides manual refresh capability for cases where recognition results are inaccurate

## System Architecture

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go Gateway)  │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP requests
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python Service)│
                     │                  │
                     └──────────────────┘
```

## Component Details

### inference-gateway

A gateway service written in Go, main responsibilities:
- Receives machine learning requests from Immich
- Forwards OCR and CLIP requests to the mt-photos-ai service based on request type
- Forwards other machine learning requests (such as face recognition) to Immich's native ML service
- Handles authentication and data format conversion

### mt-photos-ai

An AI service written in Python and FastAPI, provides:
- OCR text recognition API (based on RapidOCR)
- CLIP vector processing API (based on cn-clip)
- Supports GPU acceleration

## Deployment Instructions

### Environment Requirements

- Docker and Docker Compose
- NVIDIA GPU (optional, but recommended for accelerated processing)
- Sufficient storage space

### Configuration Instructions

1. **inference-gateway Configuration**

Main environment variables:
```
IMMICH_API=http://localhost:3003  # Immich API address
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai service address
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API key
PORT=8080  # Gateway listen port
```

2. **mt-photos-ai Configuration**

Main environment variables:
```
CLIP_MODEL=ViT-B-16  # CLIP model name
CLIP_DOWNLOAD_ROOT=./models/clip  # Model download path
DEVICE=cuda  # Or cpu, inference device
HTTP_PORT=8060  # Service listen port
```

### Deployment Steps

1. Clone the repository:
```bash
git clone https://github.com/your-username/immich-all-in-one.git
cd immich-all-in-one
```

2. Start the services:
```bash
docker-compose up -d
```

## Usage Instructions

1. **Configure Immich to Use Custom ML Service**

In Immich's configuration file, point the ML service address to the inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Using OCR Search**

- In the Immich search bar, use the `ocr:` prefix for OCR search
- For example: `ocr:invoice` will search for photos containing the word "invoice" in the image

3. **Single Media AI Data Reprocessing**

- On the photo details page, click the menu options
- Select "Regenerate OCR Data" or "Regenerate CLIP Vector"
- The system will reprocess the AI data for that photo

## Development Guide

### inference-gateway (Go)

Compile and run:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Set up development environment:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## License

This project is open source under the MIT License.

## Acknowledgements

- [Immich](https://github.com/immich-app/immich) - Open-source self-hosted photo and video backup solution
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Cross-platform OCR library based on PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinese multimodal contrastive learning pre-training model

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---