# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~後續計畫遷移到 ente-io/ente，因為我需要 s3 來存儲照片~~
> 
> ente 還是功能太少了
> 
> 改成使用 juicedata/juicefs 掛載 s3

## 專案簡介

本專案是 [Immich](https://github.com/immich-app/immich) 相片管理系統的 AI 能力增強解決方案。主要透過以下元件擴展了 Immich 的原生功能：

- **inference-gateway**：以 Go 語言撰寫的閘道服務，負責智慧分流 Immich 的機器學習請求
- **mt-photos-ai**：基於 Python 和 FastAPI 的 AI 服務，整合 RapidOCR 和 cn-clip 模型
- 對 Immich 的功能擴展，包括 OCR 文字識別搜尋和單媒體 AI 資料重新處理，OCR 全文向量與 CLIP 向量評分混合排序
- PostgreSQL 增加 zhparser 中文斷詞

## 主要功能

### 1. OCR 文字識別與搜尋

- 使用 RapidOCR 對圖片中的文字進行識別
- 支援中英文混合文字識別
- 實現基於圖片文字內容的搜尋功能

### 2. CLIP 圖像向量處理

- 基於 cn-clip 模型實現更精確的中文圖像 - 文字配對
- 支援語意化搜尋，提升搜尋精準度

### 3. 單媒體 AI 資料重新處理

- 支援對單張圖片/影片重新產生 OCR 資料
- 支援對單張圖片/影片重新產生 CLIP 向量資料
- 針對識別結果不準確的情況提供手動刷新能力

## 系統架構

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
## 組件詳解

### inference-gateway

以 Go 語言編寫的網關服務，主要職責：
- 接收 Immich 的機器學習請求
- 根據請求類型將 OCR 和 CLIP 請求轉發到 mt-photos-ai 服務
- 將其他機器學習請求（如人臉識別）轉發到 Immich 原生的機器學習服務
- 處理認證和資料格式轉換

### mt-photos-ai

以 Python 和 FastAPI 編寫的 AI 服務，提供：
- OCR 文字識別 API（基於 RapidOCR）
- CLIP 向量處理 API（基於 cn-clip）
- 支援 GPU 加速

## 部署說明

### 環境要求

- Docker 與 Docker Compose
- NVIDIA GPU（可選，但建議用於加速處理）
- 足夠的儲存空間

### 配置說明

1. **inference-gateway 配置**

主要環境變數：

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai 配置**

主要環境變數：

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### 部署步驟

1. 複製倉庫：

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. 啟動服務：

```bash
docker-compose up -d
```
## 使用說明

1. **配置 Immich 使用自訂 ML 服務**

在 Immich 的配置檔案中，將機器學習服務位址指向 inference-gateway：

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR 搜尋使用**

- 在 Immich 搜尋欄中使用 `ocr:` 前綴進行 OCR 搜尋
- 例如：`ocr:發票` 將搜尋圖片中包含「發票」文字的照片

3. **單一媒體 AI 資料重新處理**

- 在照片詳情頁面，點擊選單選項
- 選擇「重新產生 OCR 資料」或「重新產生 CLIP 向量」
- 系統將重新處理該照片的 AI 資料

## 開發指南

### inference-gateway (Go)

編譯運行：

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

開發環境設置：

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## 许可证

本專案基於 MIT 許可證開源。

## 鳴謝

- [Immich](https://github.com/immich-app/immich) - 開源自託管照片和影片備份解決方案
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - 基於 PaddleOCR 的跨平台 OCR 函式庫
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 中文多模態對比學習預訓練模型



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---