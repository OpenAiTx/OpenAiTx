# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~В дальнейшем планируется перейти на ente-io/ente, так как мне нужен s3 для хранения фотографий~~
> 
> Однако у ente все еще слишком мало функций
> 
> Изменено на использование juicedata/juicefs для монтирования s3

## Описание проекта

Данный проект представляет собой решение по расширению AI-возможностей [Immich](https://github.com/immich-app/immich) — системы управления фотографиями. Основные улучшения Immich реализованы с помощью следующих компонентов:

- **inference-gateway**: шлюзовый сервис на Go, отвечающий за интеллектуальную маршрутизацию запросов машинного обучения Immich
- **mt-photos-ai**: AI-сервис на Python и FastAPI, интегрирующий RapidOCR и cn-clip модели
- Расширение функциональности Immich, включая поиск по OCR-распознаванию текста и повторную обработку AI-данных для отдельных медиа, смешанная сортировка по вектору OCR и CLIP
- Добавлен zhparser для китайской сегментации слов в PostgreSQL

## Основные функции

### 1. Распознавание и поиск текста (OCR)

- Использование RapidOCR для распознавания текста на изображениях
- Поддержка распознавания смешанного китайско-английского текста
- Реализация поиска по содержимому текста на изображениях

### 2. Обработка векторов изображений CLIP

- Более точное сопоставление изображение–текст на основе модели cn-clip (китайский CLIP)
- Поддержка семантического поиска, повышение точности поиска

### 3. Повторная обработка AI-данных отдельного медиа

- Повторное создание OCR-данных для отдельного изображения/видео
- Повторное создание CLIP-векторов для отдельного изображения/видео
- Возможность вручную обновить результаты, если они некорректны

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

## Подробное описание компонентов

### inference-gateway

Шлюзовый сервис, написанный на Go, основные задачи:
- Принимать запросы машинного обучения от Immich
- Перенаправлять запросы OCR и CLIP к сервису mt-photos-ai в зависимости от типа запроса
- Перенаправлять другие запросы машинного обучения (например, распознавание лиц) в родной ML-сервис Immich
- Обрабатывать аутентификацию и преобразование данных

### mt-photos-ai

AI-сервис на Python и FastAPI, предоставляющий:
- API для распознавания текста (OCR) (на базе RapidOCR)
- API для обработки CLIP-векторов (на базе cn-clip)
- Поддержка ускорения на GPU

## Инструкция по развертыванию

### Требования к среде

- Docker и Docker Compose
- NVIDIA GPU (опционально, но рекомендуется для ускорения обработки)
- Достаточно места для хранения

### Описание конфигурации

1. **Конфигурация inference-gateway**

Основные переменные окружения:
```
IMMICH_API=http://localhost:3003  # адрес API Immich
MT_PHOTOS_API=http://localhost:8060  # адрес сервиса mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API-ключ
PORT=8080  # порт для прослушивания шлюза
```

2. **Конфигурация mt-photos-ai**

Основные переменные окружения:
```
CLIP_MODEL=ViT-B-16  # название модели CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # путь для загрузки модели
DEVICE=cuda  # или cpu, устройство для инференса
HTTP_PORT=8060  # порт для прослушивания сервиса
```

### Шаги развертывания

1. Клонируйте репозиторий:
```bash
git clone https://github.com/ваш_пользователь/immich-all-in-one.git
cd immich-all-in-one
```

2. Запустите сервисы:
```bash
docker-compose up -d
```

## Инструкция по использованию

1. **Настройте Immich для использования пользовательского ML-сервиса**

В конфигурационном файле Immich укажите адрес ML-сервиса на inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Использование поиска по OCR**

- В строке поиска Immich используйте префикс `ocr:` для поиска по OCR
- Например: `ocr:счет` найдет фотографии с текстом "счет" на изображении

3. **Повторная обработка AI-данных для отдельного медиа**

- На странице с деталями фото откройте меню
- Выберите "Повторно сгенерировать OCR-данные" или "Повторно сгенерировать CLIP-векторы"
- Система повторно обработает AI-данные для выбранного фото

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

Проект распространяется под лицензией MIT.

## Благодарности

- [Immich](https://github.com/immich-app/immich) — open source решение для резервного копирования фотографий и видео
- [RapidOCR](https://github.com/RapidAI/RapidOCR) — кроссплатформенная OCR-библиотека на базе PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) — мультимодальная модель предварительного обучения для китайского языка

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---