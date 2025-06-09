# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~후속 계획은 ente-io/ente로 마이그레이션 예정이었으나 사진 저장에 s3가 필요해서~~
> 
> ente는 아직 기능이 너무 부족함
> 
> juicedata/juicefs를 사용하여 s3 마운트 방식으로 변경

## 프로젝트 소개

본 프로젝트는 [Immich](https://github.com/immich-app/immich) 사진 관리 시스템의 AI 기능 확장 솔루션입니다. 주요 구성 요소를 통해 Immich의 기본 기능을 다음과 같이 확장하였습니다:

- **inference-gateway**: Go 언어로 작성된 게이트웨이 서비스로, Immich의 머신러닝 요청을 스마트하게 분기 처리함
- **mt-photos-ai**: Python과 FastAPI 기반의 AI 서비스로, RapidOCR와 cn-clip 모델 통합
- Immich의 기능 확장, OCR 텍스트 인식 검색 및 단일 미디어 AI 데이터 재처리, OCR 전체문서 벡터 및 CLIP 벡터 스코어 혼합 정렬
- PostgreSQL에 zhparser 중국어 형태소 분석기 추가

## 주요 기능

### 1. OCR 문자 인식 및 검색

- RapidOCR을 사용하여 이미지 내의 문자를 인식
- 중영문 혼합 텍스트 인식 지원
- 이미지 내 문자 기반 검색 기능 구현

### 2. CLIP 이미지 벡터 처리

- cn-clip 모델 기반으로 더 정확한 중국어 이미지-텍스트 매칭
- 의미론적 검색 지원, 검색 정확도 향상

### 3. 단일 미디어 AI 데이터 재처리

- 단일 사진/영상의 OCR 데이터 재생성 지원
- 단일 사진/영상의 CLIP 벡터 데이터 재생성 지원
- 인식 결과가 부정확할 경우 수동 새로고침 기능 제공

## 시스템 아키텍처

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP요청
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python서비스)  │
                     │                  │
                     └──────────────────┘
```

## 구성 요소 상세

### inference-gateway

Go 언어로 작성된 게이트웨이 서비스, 주요 역할:
- Immich의 머신러닝 요청 수신
- 요청 유형에 따라 OCR 및 CLIP 요청을 mt-photos-ai 서비스로 분기
- 기타 머신러닝 요청(예: 얼굴 인식)은 Immich 기본 머신러닝 서비스로 전달
- 인증 및 데이터 포맷 변환 처리

### mt-photos-ai

Python과 FastAPI로 작성된 AI 서비스, 제공 기능:
- OCR 문자 인식 API(RapidOCR 기반)
- CLIP 벡터 처리 API(cn-clip 기반)
- GPU 가속 지원

## 배포 안내

### 환경 요구사항

- Docker 및 Docker Compose
- NVIDIA GPU (선택 사항이나 가속처리에 권장)
- 충분한 저장공간

### 설정 안내

1. **inference-gateway 설정**

주요 환경 변수:
```
IMMICH_API=http://localhost:3003  # Immich API 주소
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai 서비스 주소
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API 키
PORT=8080  # 게이트웨이 리스닝 포트
```

2. **mt-photos-ai 설정**

주요 환경 변수:
```
CLIP_MODEL=ViT-B-16  # CLIP 모델명
CLIP_DOWNLOAD_ROOT=./models/clip  # 모델 다운로드 경로
DEVICE=cuda  # 또는 cpu, 추론 장치
HTTP_PORT=8060  # 서비스 리스닝 포트
```

### 배포 절차

1. 저장소 클론:
```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```

2. 서비스 시작:
```bash
docker-compose up -d
```

## 사용법 안내

1. **Immich에 커스텀 ML 서비스 설정**

Immich의 설정 파일에서 머신러닝 서비스 주소를 inference-gateway로 지정:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR 검색 사용**

- Immich 검색창에 `ocr:` 접두사를 사용하여 OCR 검색
- 예: `ocr:발표` 입력 시 이미지 내에 "발표" 문자가 포함된 사진 검색

3. **단일 미디어 AI 데이터 재처리**

- 사진 상세 페이지에서 메뉴 옵션 클릭
- "OCR 데이터 재생성" 또는 "CLIP 벡터 재생성" 선택
- 시스템이 해당 사진의 AI 데이터를 재처리함

## 개발 안내

### inference-gateway (Go)

빌드 및 실행:
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

본 프로젝트는 MIT 라이선스로 오픈소스 공개됩니다.

## 감사의 말씀

- [Immich](https://github.com/immich-app/immich) - 오픈소스 자가호스팅 사진 및 영상 백업 솔루션
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR 기반 크로스플랫폼 OCR 라이브러리
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 중국어 멀티모달 대조 학습 사전학습 모델

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---