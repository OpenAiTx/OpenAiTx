# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~برنامه بعدی انتقال به ente-io/ente است، زیرا من به s3 برای ذخیره عکس‌ها نیاز دارم~~
> 
> امکانات ente هنوز بسیار کم است
> 
> تغییر به استفاده از juicedata/juicefs برای اتصال s3

## معرفی پروژه

این پروژه یک راهکار تقویت قابلیت‌های هوش مصنوعی برای سامانه مدیریت عکس [Immich](https://github.com/immich-app/immich) است. این پروژه از طریق اجزای زیر قابلیت‌های بومی Immich را گسترش می‌دهد:

- **inference-gateway**: یک سرویس دروازه نوشته شده با زبان Go که مسئول توزیع هوشمند درخواست‌های یادگیری ماشین Immich است
- **mt-photos-ai**: سرویس هوش مصنوعی مبتنی بر Python و FastAPI که RapidOCR و مدل cn-clip را ادغام کرده است
- گسترش قابلیت‌های Immich شامل جستجوی OCR و بازپردازش داده‌های AI برای هر رسانه به صورت مجزا، رتبه‌بندی ترکیبی بر اساس بردار کامل متن OCR و بردار CLIP
- افزودن zhparser برای قطعه‌بندی کلمات چینی در PostgreSQL

## قابلیت‌های اصلی

### 1. شناسایی و جستجوی متون تصویری (OCR)

- استفاده از RapidOCR برای شناسایی متون در تصاویر
- پشتیبانی از شناسایی متون ترکیبی چینی و انگلیسی
- پیاده‌سازی قابلیت جستجو بر اساس محتوای متنی تصاویر

### 2. پردازش بردارهای تصویری CLIP

- تطبیق دقیق‌تر تصویر و متن به زبان چینی با مدل cn-clip
- پشتیبانی از جستجوی معنایی برای افزایش دقت نتایج جستجو

### 3. بازپردازش داده AI برای هر رسانه به صورت مجزا

- امکان بازتولید داده OCR برای هر عکس/ویدئو به صورت مجزا
- امکان بازتولید بردار CLIP برای هر عکس/ویدئو به صورت مجزا
- ارائه قابلیت بروزرسانی دستی در صورت عدم دقت نتایج شناسایی

## معماری سیستم

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

## توضیحات اجزا

### inference-gateway

سرویس دروازه نوشته شده با زبان Go با وظایف اصلی زیر:
- دریافت درخواست‌های یادگیری ماشین Immich
- مسیردهی درخواست‌های OCR و CLIP به سرویس mt-photos-ai بر اساس نوع درخواست
- مسیردهی سایر درخواست‌های یادگیری ماشین (مانند شناسایی چهره) به سرویس بومی یادگیری ماشین Immich
- مدیریت احراز هویت و تبدیل فرمت داده‌ها

### mt-photos-ai

سرویس هوش مصنوعی نوشته شده با Python و FastAPI با امکانات زیر:
- API شناسایی متون (OCR) مبتنی بر RapidOCR
- API پردازش بردار CLIP مبتنی بر cn-clip
- پشتیبانی از شتاب‌دهی GPU

## راهنمای استقرار

### پیش‌نیازها

- Docker و Docker Compose
- کارت گرافیک NVIDIA (اختیاری، ولی برای پردازش سریع توصیه می‌شود)
- فضای ذخیره‌سازی کافی

### راهنمای پیکربندی

1. **پیکربندی inference-gateway**

متغیرهای محیطی اصلی:
```
IMMICH_API=http://localhost:3003  # آدرس API سرویس Immich
MT_PHOTOS_API=http://localhost:8060  # آدرس سرویس mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # کلید API
PORT=8080  # پورت گوش دادن دروازه
```

2. **پیکربندی mt-photos-ai**

متغیرهای محیطی اصلی:
```
CLIP_MODEL=ViT-B-16  # نام مدل CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # مسیر دانلود مدل
DEVICE=cuda  # یا cpu، دستگاه پردازش
HTTP_PORT=8060  # پورت گوش دادن سرویس
```

### مراحل استقرار

1. کلون کردن مخزن:
```bash
git clone https://github.com/نام‌کاربری-شما/immich-all-in-one.git
cd immich-all-in-one
```

2. راه‌اندازی سرویس‌ها:
```bash
docker-compose up -d
```

## راهنمای استفاده

1. **پیکربندی Immich برای استفاده از سرویس یادگیری ماشین سفارشی**

در فایل پیکربندی Immich، آدرس سرویس یادگیری ماشین را به inference-gateway تغییر دهید:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **استفاده از جستجوی OCR**

- در نوار جستجوی Immich از پیشوند `ocr:` برای جستجوی OCR استفاده کنید
- برای مثال: `ocr:فاکتور` تصاویری که شامل واژه "فاکتور" هستند را جستجو می‌کند

3. **بازپردازش داده AI برای هر رسانه به صورت مجزا**

- در صفحه جزئیات عکس، روی گزینه منو کلیک کنید
- "بازتولید داده OCR" یا "بازتولید بردار CLIP" را انتخاب کنید
- سیستم داده هوش مصنوعی آن عکس را مجدداً پردازش خواهد کرد

## راهنمای توسعه

### inference-gateway (Go)

کامپایل و اجرا:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

راه‌اندازی محیط توسعه:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## مجوز

این پروژه تحت مجوز MIT متن‌باز است.

## تقدیر و تشکر

- [Immich](https://github.com/immich-app/immich) - راهکار پشتیبان‌گیری عکس و ویدئو متن‌باز و خودمیزبان
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - کتابخانه OCR چندسکویی مبتنی بر PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - مدل پیش‌آموزش یادگیری تطبیقی چندوجهی چینی

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---