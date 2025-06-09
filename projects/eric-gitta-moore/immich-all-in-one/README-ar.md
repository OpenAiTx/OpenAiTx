# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~الخطة المستقبلية هي الانتقال إلى ente-io/ente لأنني أحتاج إلى s3 لتخزين الصور~~
> 
> ente لا تزال تفتقر للكثير من الوظائف
> 
> تم التغيير لاستخدام juicedata/juicefs لتركيب s3

## مقدمة المشروع

هذا المشروع هو حل لتعزيز قدرات الذكاء الاصطناعي لنظام إدارة الصور [Immich](https://github.com/immich-app/immich). تم توسيع الوظائف الأصلية لـ Immich بشكل أساسي من خلال المكونات التالية:

- **inference-gateway**: خدمة بوابة مكتوبة بلغة Go، مسؤولة عن التوزيع الذكي لطلبات التعلم الآلي من Immich
- **mt-photos-ai**: خدمة ذكاء اصطناعي مبنية على Python وFastAPI، تدمج RapidOCR ونموذج cn-clip
- توسيع وظائف Immich، بما في ذلك البحث والتعرف على النصوص OCR وإعادة معالجة بيانات الذكاء الاصطناعي للوسائط المفردة، وترتيب مختلط بناءً على متجهات النص الكامل OCR ومتجهات CLIP
- إضافة zhparser لتجزئة الكلمات الصينية في PostgreSQL

## الميزات الرئيسية

### 1. التعرف على النصوص (OCR) والبحث

- استخدام RapidOCR للتعرف على النصوص داخل الصور
- دعم التعرف على النصوص المختلطة بين الصينية والإنجليزية
- تنفيذ وظيفة البحث بناءً على محتوى النص الموجود في الصور

### 2. معالجة متجهات الصور باستخدام CLIP

- تحقيق مطابقة أكثر دقة بين الصور والنصوص الصينية بناءً على نموذج cn-clip
- دعم البحث الدلالي لتحسين دقة البحث

### 3. إعادة معالجة بيانات الذكاء الاصطناعي للوسائط المفردة

- دعم إعادة توليد بيانات OCR لصورة/فيديو مفرد
- دعم إعادة توليد بيانات متجهات CLIP لصورة/فيديو مفرد
- توفير إمكانية التحديث اليدوي في حال كانت نتائج التعرف غير دقيقة

## بنية النظام

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Goبوابة)     │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ طلبات OCR/CLIP
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (خدمة Python)   │
                     │                  │
                     └──────────────────┘
```

## شرح المكونات

### inference-gateway

خدمة بوابة مكتوبة بلغة Go، المسؤوليات الرئيسية:
- استقبال طلبات التعلم الآلي من Immich
- إعادة توجيه طلبات OCR وCLIP إلى خدمة mt-photos-ai بناءً على نوع الطلب
- إعادة توجيه طلبات التعلم الآلي الأخرى (مثل التعرف على الوجوه) إلى خدمة التعلم الآلي الأصلية لـ Immich
- معالجة المصادقة وتحويل تنسيق البيانات

### mt-photos-ai

خدمة ذكاء اصطناعي مكتوبة بلغة Python وFastAPI، تقدم:
- واجهة برمجة تطبيقات (API) للتعرف على النصوص (OCR) (مبنية على RapidOCR)
- واجهة برمجة تطبيقات لمعالجة متجهات CLIP (مبنية على cn-clip)
- دعم تسريع المعالجة باستخدام وحدة معالجة الرسومات (GPU)

## تعليمات النشر

### المتطلبات البيئية

- Docker وDocker Compose
- بطاقة رسومية NVIDIA (اختياري، لكن يوصى بها لتسريع المعالجة)
- مساحة تخزين كافية

### تعليمات التهيئة

1. **تهيئة inference-gateway**

المتغيرات البيئية الرئيسية:
```
IMMICH_API=http://localhost:3003  # عنوان Immich API
MT_PHOTOS_API=http://localhost:8060  # عنوان خدمة mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # مفتاح API
PORT=8080  # منفذ استماع البوابة
```

2. **تهيئة mt-photos-ai**

المتغيرات البيئية الرئيسية:
```
CLIP_MODEL=ViT-B-16  # اسم نموذج CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # مسار تحميل النموذج
DEVICE=cuda  # أو cpu، جهاز الاستدلال
HTTP_PORT=8060  # منفذ استماع الخدمة
```

### خطوات النشر

1. استنساخ المستودع:
```bash
git clone https://github.com/اسم_المستخدم/immich-all-in-one.git
cd immich-all-in-one
```

2. بدء الخدمة:
```bash
docker-compose up -d
```

## تعليمات الاستخدام

1. **تهيئة Immich لاستخدام خدمة ML مخصصة**

في ملف إعدادات Immich، قم بتوجيه عنوان خدمة التعلم الآلي إلى inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **استخدام البحث OCR**

- استخدم البادئة `ocr:` في شريط البحث في Immich للبحث باستخدام OCR
- مثال: `ocr:فاتورة` سيبحث عن الصور التي تحتوي على كلمة "فاتورة" في النص الموجود داخل الصورة

3. **إعادة معالجة بيانات الذكاء الاصطناعي للوسائط المفردة**

- في صفحة تفاصيل الصورة، انقر على خيارات القائمة
- اختر "إعادة توليد بيانات OCR" أو "إعادة توليد متجهات CLIP"
- سيقوم النظام بإعادة معالجة بيانات الذكاء الاصطناعي للصورة المحددة

## دليل التطوير

### inference-gateway (Go)

التجميع والتشغيل:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

إعداد بيئة التطوير:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## الرخصة

هذا المشروع مفتوح المصدر بموجب رخصة MIT.

## الشكر والتقدير

- [Immich](https://github.com/immich-app/immich) - حل النسخ الاحتياطي للصور والفيديوهات مفتوح المصدر والمستضاف ذاتياً
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - مكتبة OCR متعددة المنصات مبنية على PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - نموذج تعلم تمهيدي متعدد الوسائط للغة الصينية

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---