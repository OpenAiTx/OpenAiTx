# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~향후 ente-io/ente로 이전할 계획이었으나, 사진 저장을 위해 s3가 필요해서~~
> 
> ente는 여전히 기능이 너무 적다
> 
> juicedata/juicefs를 사용하여 s3를 마운트하는 방식으로 변경

## 프로젝트 소개

본 프로젝트는 [Immich](https://github.com/immich-app/immich) 사진 관리 시스템의 AI 기능 확장 솔루션입니다. 주요 구성요소를 통해 Immich의 기본 기능을 다음과 같이 확장하였습니다:

- **inference-gateway**: Go 언어로 작성된 게이트웨이 서비스로, Immich의 머신러닝 요청을 지능적으로 분기 처리함
- **mt-photos-ai**: Python과 FastAPI 기반의 AI 서비스로, RapidOCR 및 cn-clip 모델을 통합
- Immich 기능 확장: OCR 문자 인식 검색 및 단일 미디어 AI 데이터 재처리, OCR 전체 텍스트 벡터와 CLIP 벡터 점수 혼합 정렬
- PostgreSQL에 zhparser 중국어 형태소 분석기 추가

## 주요 기능

### 1. OCR 문자 인식 및 검색

- RapidOCR을 사용하여 이미지 내 문자를 인식
- 중영문 혼합 텍스트 인식 지원
- 이미지 내 문자 내용을 기반으로 한 검색 기능 제공

### 2. CLIP 이미지 벡터 처리

- cn-clip 모델 기반으로 더 정확한 중국어 이미지-텍스트 매칭 구현
- 의미 기반 검색 지원으로 검색 정확도 향상

### 3. 단일 미디어 AI 데이터 재처리

- 단일 이미지/영상에 대해 OCR 데이터 재생성 지원
- 단일 이미지/영상에 대해 CLIP 벡터 데이터 재생성 지원
- 인식 결과가 부정확할 때 수동 새로고침 기능 제공

## 시스템 아키텍처

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
## 组件详解

### inference-gateway

Go 언어로 작성된 게이트웨이 서비스, 주요 역할:
- Immich의 머신러닝 요청 수신
- 요청 유형에 따라 OCR 및 CLIP 요청을 mt-photos-ai 서비스로 전달
- 기타 머신러닝 요청(예: 얼굴 인식)은 Immich 기본 머신러닝 서비스로 전달
- 인증 및 데이터 형식 변환 처리

### mt-photos-ai

Python과 FastAPI로 작성된 AI 서비스, 제공 기능:
- OCR 문자 인식 API(RapidOCR 기반)
- CLIP 벡터 처리 API(cn-clip 기반)
- GPU 가속 지원

## 배포 설명

### 환경 요구 사항

- Docker 및 Docker Compose
- NVIDIA GPU(선택 사항이나, 가속 처리를 위해 권장)
- 충분한 저장 공간

### 구성 설명

1. **inference-gateway 구성**

주요 환경 변수:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai 구성**

주요 환경 변수:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### 배포 단계

1. 저장소를 클론합니다:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. 서비스 시작:

```bash
docker-compose up -d
```
## 사용 설명

1. **Immich에서 사용자 지정 ML 서비스 구성**

Immich의 구성 파일에서 머신러닝 서비스 주소를 inference-gateway로 지정합니다:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR 검색 사용**

- Immich 검색창에서 `ocr:` 접두사를 사용하여 OCR 검색 수행
- 예시: `ocr:발표`는 사진 속에 "발표"라는 문자가 포함된 이미지를 검색함

3. **단일 미디어 AI 데이터 재처리**

- 사진 상세 페이지에서 메뉴 옵션 클릭
- "OCR 데이터 재생성" 또는 "CLIP 벡터 재생성" 선택
- 시스템이 해당 사진의 AI 데이터를 다시 처리함

## 개발 가이드

### inference-gateway (Go)

컴파일 및 실행:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

개발 환경 설정:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## 라이선스

이 프로젝트는 MIT 라이선스를 기반으로 오픈소스입니다.

## 감사의 말씀

- [Immich](https://github.com/immich-app/immich) - 오픈소스 자체 호스팅 사진 및 비디오 백업 솔루션
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR 기반의 크로스플랫폼 OCR 라이브러리
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 중국어 멀티모달 대조 학습 사전학습 모델



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---