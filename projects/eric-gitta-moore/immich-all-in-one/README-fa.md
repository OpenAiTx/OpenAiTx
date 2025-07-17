# ایمیچ + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~در آینده برنامه‌ریزی شده بود که به ente-io/ente مهاجرت کنم، چون به s3 برای ذخیره عکس نیاز داشتم~~
> 
> اما ente هنوز امکانات کمی دارد
> 
> به جای آن از juicedata/juicefs برای اتصال به s3 استفاده شد

## معرفی پروژه

این پروژه یک راهکار افزایش قابلیت‌های هوش مصنوعی برای سامانه مدیریت عکس [Immich](https://github.com/immich-app/immich) است. این راهکار با استفاده از اجزای زیر قابلیت‌های Immich را گسترش می‌دهد:

- **inference-gateway**: یک سرویس دروازه نوشته‌شده با زبان Go که وظیفه مسیریابی هوشمند درخواست‌های یادگیری ماشین Immich را دارد
- **mt-photos-ai**: سرویس هوش مصنوعی مبتنی بر Python و FastAPI که RapidOCR و مدل cn-clip را یکپارچه می‌کند
- توسعه قابلیت‌های Immich شامل جستجوی متنی OCR و بازپردازش داده‌های AI برای هر رسانه، رتبه‌بندی ترکیبی بر اساس بردار متنی OCR و بردار CLIP
- افزودن zhparser برای قطعه‌بندی کلمات چینی در PostgreSQL

## قابلیت‌های اصلی

### ۱. شناسایی و جستجوی متن OCR

- استفاده از RapidOCR برای شناسایی متون درون تصاویر
- پشتیبانی از شناسایی متون ترکیبی چینی و انگلیسی
- پیاده‌سازی جستجو بر اساس محتوای متنی تصاویر

### ۲. پردازش بردار تصویر CLIP

- تطبیق دقیق‌تر تصویر-متن چینی با مدل cn-clip
- پشتیبانی از جستجوی معنایی و افزایش دقت جستجو

### ۳. بازپردازش داده‌های AI برای هر رسانه

- پشتیبانی از بازتولید داده‌های OCR برای تک تصویر/ویدیو
- پشتیبانی از بازتولید بردار CLIP برای تک تصویر/ویدیو
- قابلیت بروزرسانی دستی در مواردی که نتایج شناسایی دقیق نیست

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
## توضیحات اجزای سیستم

### inference-gateway

سرویس دروازه‌ای نوشته شده با زبان Go، وظایف اصلی:
- دریافت درخواست‌های یادگیری ماشین Immich
- ارسال درخواست‌های OCR و CLIP به سرویس mt-photos-ai بر اساس نوع درخواست
- ارسال سایر درخواست‌های یادگیری ماشین (مانند شناسایی چهره) به سرویس یادگیری ماشین بومی Immich
- مدیریت احراز هویت و تبدیل فرمت داده‌ها

### mt-photos-ai

سرویس هوش مصنوعی نوشته شده با Python و FastAPI، ارائه‌دهنده:
- API شناسایی متن OCR (مبتنی بر RapidOCR)
- API پردازش بردار CLIP (مبتنی بر cn-clip)
- پشتیبانی از شتاب‌دهی GPU

## راهنمای استقرار

### الزامات محیطی

- Docker و Docker Compose
- کارت گرافیک NVIDIA (اختیاری، اما برای شتاب‌دهی توصیه می‌شود)
- فضای ذخیره‌سازی کافی

### راهنمای پیکربندی

1. **پیکربندی inference-gateway**

متغیرهای محیطی اصلی:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **پیکربندی mt-photos-ai**

متغیرهای محیطی اصلی:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### مراحل استقرار

1. مخزن را کلون کنید:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. راه‌اندازی سرویس:

```bash
docker-compose up -d
```
## راهنمای استفاده

1. **پیکربندی Immich برای استفاده از سرویس ML سفارشی**

در فایل پیکربندی Immich، آدرس سرویس یادگیری ماشین را به سمت inference-gateway تنظیم کنید:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **استفاده از جستجوی OCR**

- در نوار جستجوی Immich از پیشوند `ocr:` برای جستجوی OCR استفاده کنید
- به عنوان مثال: `ocr:فاکتور` عکس‌هایی را که متن "فاکتور" در آن‌ها وجود دارد، جستجو می‌کند

3. **بازپردازش داده‌های AI رسانه تکی**

- در صفحه جزئیات عکس، روی گزینه منو کلیک کنید
- "تولید مجدد داده‌های OCR" یا "تولید مجدد بردارهای CLIP" را انتخاب کنید
- سیستم داده‌های AI آن عکس را مجدداً پردازش خواهد کرد

## راهنمای توسعه

### inference-gateway (Go)

کامپایل و اجرا:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (پایتون)

راه‌اندازی محیط توسعه:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## مجوز

این پروژه بر پایه مجوز MIT به صورت متن‌باز ارائه شده است.

## قدردانی

- [Immich](https://github.com/immich-app/immich) - راهکار پشتیبان‌گیری عکس و ویدیو متن‌باز و خود میزبانی‌شونده
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - کتابخانه OCR چندسکویی مبتنی بر PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - مدل پیش‌آموزش یادگیری مقایسه‌ای چندوجهی برای زبان چینی



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---