<translate-content># Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~الخطة المستقبلية كانت نقل المشروع إلى ente-io/ente، لأنني بحاجة إلى s3 لتخزين الصور~~
> 
> لكن ente ما زال يفتقر للميزات الكافية
> 
> تم التغيير لاستخدام juicedata/juicefs لتركيب s3

## مقدمة المشروع

هذا المشروع هو حل لتعزيز قدرات الذكاء الاصطناعي في نظام إدارة الصور [Immich](https://github.com/immich-app/immich). تم توسيع وظائف Immich الأصلية من خلال المكونات التالية:

- **inference-gateway**: خدمة بوابة مكتوبة بلغة Go، مسؤولة عن توجيه ذكي لطلبات تعلم الآلة من Immich
- **mt-photos-ai**: خدمة ذكاء اصطناعي مبنية على Python وFastAPI، تدمج RapidOCR ونموذج cn-clip
- توسيع وظائف Immich، بما يشمل البحث بالتعرف على النصوص (OCR) ومعالجة بيانات الذكاء الاصطناعي لوسائط مفردة، مع دمج ترتيب هجيني للنصوص الكاملة OCR ومتجهات CLIP
- إضافة محلل الكلمات الصينية zhparser إلى PostgreSQL

## الميزات الرئيسية

### 1. التعرف الضوئي على الحروف (OCR) والبحث

- استخدام RapidOCR للتعرف على النصوص داخل الصور
- دعم التعرف على نصوص مختلطة صينية/إنجليزية
- تحقيق وظيفة البحث بناءً على محتوى النصوص داخل الصور

### 2. معالجة متجهات الصور CLIP

- استخدام نموذج cn-clip لتحقيق مطابقة أدق بين الصور والنصوص باللغة الصينية
- دعم البحث الدلالي، مما يزيد من دقة النتائج

### 3. إعادة معالجة بيانات الذكاء الاصطناعي للوسائط الفردية

- دعم إعادة توليد بيانات OCR لصورة/فيديو مفرد
- دعم إعادة توليد متجهات CLIP لصورة/فيديو مفرد
- توفير إمكانية التحديث اليدوي عند النتائج غير الدقيقة

## بنية النظام
</translate-content>
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
## شرح المكونات

### inference-gateway

خدمة بوابة مكتوبة بلغة Go، المسؤوليات الرئيسية:
- استلام طلبات تعلم الآلة من Immich
- إعادة توجيه طلبات OCR و CLIP إلى خدمة mt-photos-ai حسب نوع الطلب
- إعادة توجيه طلبات تعلم الآلة الأخرى (مثل التعرف على الوجوه) إلى خدمة تعلم الآلة الأصلية في Immich
- معالجة المصادقة وتحويل صيغ البيانات

### mt-photos-ai

خدمة ذكاء اصطناعي مكتوبة بلغة Python و FastAPI، تقدم:
- واجهة برمجة تطبيقات للتعرف الضوئي على الحروف (OCR) (تعتمد على RapidOCR)
- واجهة برمجة تطبيقات لمعالجة متجهات CLIP (تعتمد على cn-clip)
- دعم تسريع المعالجة عبر GPU

## تعليمات النشر

### متطلبات البيئة

- Docker و Docker Compose
- وحدة معالجة رسومات NVIDIA (اختياري، لكن يُوصى بها لتسريع المعالجة)
- مساحة تخزين كافية

### تعليمات التكوين

1. **تكوين inference-gateway**

المتغيرات البيئية الرئيسية:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **إعداد mt-photos-ai**

المتغيرات البيئية الرئيسية:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### خطوات النشر

1. استنساخ المستودع:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. بدء الخدمة:

```bash
docker-compose up -d
```
## تعليمات الاستخدام

1. **تهيئة Immich لاستخدام خدمة تعلم آلي مخصصة**

في ملف إعدادات Immich، وجّه عنوان خدمة التعلم الآلي إلى inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **استخدام البحث OCR**

- استخدم البادئة `ocr:` في شريط بحث Immich لإجراء بحث OCR
- على سبيل المثال: `ocr:فاتورة` سيبحث عن الصور التي تحتوي على كلمة "فاتورة" في النص

3. **إعادة معالجة بيانات الذكاء الاصطناعي لوسيط فردي**

- في صفحة تفاصيل الصورة، انقر على خيارات القائمة
- اختر "إعادة إنشاء بيانات OCR" أو "إعادة إنشاء متجهات CLIP"
- سيقوم النظام بإعادة معالجة بيانات الذكاء الاصطناعي لتلك الصورة

## دليل التطوير

### inference-gateway (Go)

الترجمة والتشغيل:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (بايثون)

إعداد بيئة التطوير:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## الترخيص

هذا المشروع مفتوح المصدر بموجب ترخيص MIT.

## الشكر والتقدير

- [Immich](https://github.com/immich-app/immich) - حل نسخ احتياطي للصور والفيديوهات مفتوح المصدر وقابل للاستضافة الذاتية
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - مكتبة OCR عبر الأنظمة مبنية على PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - نموذج تمهيدي للتعلم المقارن متعدد الوسائط باللغة الصينية



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---