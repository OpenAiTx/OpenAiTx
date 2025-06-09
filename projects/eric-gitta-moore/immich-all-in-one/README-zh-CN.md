# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~后续计划迁移到 ente-io/ente，因为我需要 s3 来存储照片~~
> 
> ente 还是功能太少了
> 
> 改成使用 juicedata/juicefs 挂载 s3

## 项目简介

本项目是 [Immich](https://github.com/immich-app/immich) 照片管理系统的 AI 能力增强解决方案。主要通过以下组件扩展了 Immich 的原生功能：

- **inference-gateway**：Go 语言编写的网关服务，负责智能分流 Immich 的机器学习请求
- **mt-photos-ai**：基于 Python 和 FastAPI 的 AI 服务，集成了 RapidOCR 和 cn-clip 模型
- 对 Immich 的功能扩展，包括 OCR 文本识别搜索和单媒体 AI 数据重新处理，OCR 全文向量和 CLIP 向量打分混合排序
- PostgreSQL 添加 zhparser 中文分词

## 主要功能

### 1. OCR 文字识别与搜索

- 使用 RapidOCR 对图片中的文字进行识别
- 支持中英文混合文本识别
- 实现基于图片文字内容的搜索功能

### 2. CLIP 图像向量处理

- 基于 cn-clip 模型实现更准确的中文图像 - 文本匹配
- 支持语义化搜索，提高搜索准确度

### 3. 单媒体 AI 数据重新处理

- 支持对单张图片/视频重新生成 OCR 数据
- 支持对单张图片/视频重新生成 CLIP 向量数据
- 针对识别结果不准确的情况提供手动刷新能力

## 系统架构

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

Go 语言编写的网关服务，主要职责：
- 接收 Immich 的机器学习请求
- 根据请求类型将 OCR 和 CLIP 请求转发到 mt-photos-ai 服务
- 将其他机器学习请求（如人脸识别）转发到 Immich 原生的机器学习服务
- 处理认证和数据格式转换

### mt-photos-ai

Python 和 FastAPI 编写的 AI 服务，提供：
- OCR 文字识别 API（基于 RapidOCR）
- CLIP 向量处理 API（基于 cn-clip）
- 支持 GPU 加速

## 部署说明

### 环境要求

- Docker 和 Docker Compose
- NVIDIA GPU (可选，但推荐用于加速处理)
- 足够的存储空间

### 配置说明

1. **inference-gateway 配置**

主要环境变量：
```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```

2. **mt-photos-ai 配置**

主要环境变量：
```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```

### 部署步骤

1. 克隆仓库：
```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```

2. 启动服务：
```bash
docker-compose up -d
```

## 使用说明

1. **配置 Immich 使用自定义 ML 服务**

在 Immich 的配置文件中，将机器学习服务地址指向 inference-gateway：
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR 搜索使用**

- 在 Immich 搜索栏中使用`ocr:`前缀进行 OCR 搜索
- 例如：`ocr:发票` 将搜索图片中包含"发票"文字的照片

3. **单媒体 AI 数据重新处理**

- 在照片详情页面，点击菜单选项
- 选择"重新生成 OCR 数据"或"重新生成 CLIP 向量"
- 系统将重新处理该照片的 AI 数据

## 开发指南

### inference-gateway (Go)

编译运行：
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

开发环境设置：
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## 许可证

本项目基于 MIT 许可证开源。

## 鸣谢

- [Immich](https://github.com/immich-app/immich) - 开源自托管照片和视频备份解决方案
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - 基于 PaddleOCR 的跨平台 OCR 库
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 中文多模态对比学习预训练模型

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---