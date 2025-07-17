# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~The plan was to migrate to ente-io/ente, since I need s3 to store photos~~
> 
> But ente still has too few features
> 
> Changed to using juicedata/juicefs to mount s3

## Project Overview

This project is an AI capability enhancement solution for the [Immich](https://github.com/immich-app/immich) photo management system. It mainly extends Immich’s native features with the following components:

- **inference-gateway**: A gateway service written in Go, responsible for intelligently routing Immich's machine learning requests
- **mt-photos-ai**: An AI service based on Python and FastAPI, integrating RapidOCR and the cn-clip model
- Immich functional extensions, including OCR text recognition search and single-media AI data reprocessing, hybrid ranking with OCR full-text vectors and CLIP vector scoring
- Adding zhparser Chinese word segmentation to PostgreSQL

## Main Features

### 1. OCR Text Recognition and Search

- Use RapidOCR to recognize text in images
- Support for mixed Chinese and English text recognition
- Implement search functionality based on image text content

### 2. CLIP Image Vector Processing

- Use the cn-clip model for more accurate Chinese image-text matching
- Support semantic search to improve search accuracy

### 3. Single Media AI Data Reprocessing

- Support regenerating OCR data for a single image/video
- Support regenerating CLIP vector data for a single image/video
- Provide manual refresh capability for inaccurate recognition results

## System Architecture

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
## Component Details

### inference-gateway

A gateway service written in Go, with main responsibilities:
- Receiving machine learning requests from Immich
- Forwarding OCR and CLIP requests to the mt-photos-ai service based on request type
- Forwarding other machine learning requests (such as face recognition) to Immich's native machine learning service
- Handling authentication and data format conversion

### mt-photos-ai

An AI service written in Python and FastAPI, providing:
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
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai Configuration**

Main environment variables:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Deployment Steps

1. Clone the repository:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Start the service:

```bash
docker-compose up -d
```
## Instructions

1. **Configure Immich to Use a Custom ML Service**

In the Immich configuration file, point the machine learning service address to inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR Search Usage**

- Use the `ocr:` prefix in the Immich search bar to perform OCR searches
- For example: `ocr:invoice` will search for photos containing the word "invoice" in the image

3. **Single Media AI Data Reprocessing**

- On the photo details page, click the menu options
- Select "Regenerate OCR Data" or "Regenerate CLIP Vector"
- The system will reprocess the AI data for that photo

## Developer Guide

### inference-gateway (Go)

Compile and run:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Development environment setup:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## License

This project is open-sourced under the MIT License.

## Acknowledgements

- [Immich](https://github.com/immich-app/immich) - Open-source self-hosted photo and video backup solution
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Cross-platform OCR library based on PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chinese multimodal contrastive learning pre-trained model



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---