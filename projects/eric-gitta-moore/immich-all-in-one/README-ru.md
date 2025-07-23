
# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~В дальнейшем планируется миграция на ente-io/ente, потому что мне нужен s3 для хранения фотографий~~
> 
> Но в ente всё ещё слишком мало функций
> 
> Перешёл на использование juicedata/juicefs для монтирования s3

## Описание проекта

Данный проект представляет собой решение по расширению AI-возможностей системы управления фотографиями [Immich](https://github.com/immich-app/immich). Основные расширения реализованы с помощью следующих компонентов:

- **inference-gateway**: шлюзовый сервис на Go, отвечает за интеллектуальную маршрутизацию ML-запросов Immich
- **mt-photos-ai**: AI-сервис на базе Python и FastAPI, интегрирует RapidOCR и cn-clip модели
- Расширение функций Immich, включая поиск по OCR и повторную обработку AI-данных для одного медиафайла, смешанная сортировка по OCR-вектору全文 и CLIP-вектору
- В PostgreSQL добавлен zhparser для китайской сегментации текста

## Основные функции

### 1. Распознавание и поиск текста (OCR)

- Использование RapidOCR для распознавания текста на изображениях
- Поддержка смешанного распознавания китайского и английского текста
- Реализация поиска по содержимому текста на изображениях

### 2. Обработка векторов изображений CLIP

- Более точное сопоставление изображение–текст на основе модели cn-clip
- Поддержка семантического поиска для повышения точности

### 3. Повторная обработка AI-данных для одного медиа

- Поддержка повторной генерации OCR-данных для отдельного фото/видео
- Поддержка повторной генерации CLIP-векторов для отдельного фото/видео
- Возможность ручного обновления при неточных результатах распознавания

## Архитектура системы


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
## Компоненты: подробное описание

### inference-gateway

Сервис-шлюз, написанный на Go, основные задачи:
- Прием запросов машинного обучения от Immich
- Перенаправление запросов OCR и CLIP в сервис mt-photos-ai в зависимости от типа запроса
- Перенаправление других запросов машинного обучения (например, распознавание лиц) в собственный сервис машинного обучения Immich
- Обработка аутентификации и преобразование форматов данных

### mt-photos-ai

AI-сервис на Python и FastAPI, предоставляет:
- API для распознавания текста (OCR) (на базе RapidOCR)
- API для обработки векторов CLIP (на базе cn-clip)
- Поддержка ускорения на GPU

## Инструкция по развертыванию

### Системные требования

- Docker и Docker Compose
- NVIDIA GPU (необязательно, но рекомендуется для ускорения обработки)
- Достаточно места на диске

### Описание конфигурации

1. **Конфигурация inference-gateway**

Основные переменные окружения:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai конфигурация**

Основные переменные среды:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Шаги развертывания

1. Клонируйте репозиторий:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Запуск службы:

```bash
docker-compose up -d
```
## Инструкция по применению

1. **Настройка использования Immich с пользовательским ML-сервисом**

В конфигурационном файле Immich укажите адрес сервиса машинного обучения на inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Использование OCR-поиска**

- В строке поиска Immich используйте префикс `ocr:` для поиска по OCR
- Например: `ocr:发票` выполнит поиск фотографий, на которых есть текст "发票"

3. **Повторная обработка AI-данных для отдельного медиафайла**

- На странице сведений о фото нажмите на меню
- Выберите "Перегенерировать данные OCR" или "Перегенерировать CLIP-вектор"
- Система повторно обработает AI-данные для этого фото

## Руководство по разработке

### inference-gateway (Go)

Сборка и запуск:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Настройка среды разработки:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Лицензия

Этот проект с открытым исходным кодом на основе лицензии MIT.

## Благодарности

- [Immich](https://github.com/immich-app/immich) — открытое автономное решение для резервного копирования фото и видео
- [RapidOCR](https://github.com/RapidAI/RapidOCR) — кроссплатформенная OCR-библиотека на основе PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) — предварительно обученная модель мультимодального контрастивного обучения для китайского языка



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---