<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="شعار Trieve">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="عدد مرات سحب Docker" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="نجوم GitHub" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="تابعنا على X (تويتر)" />
  </a>
</p>

---
# حوّل أي جهاز إلى صندوق موسيقي جماعي

**Jukebox** يتيح لك إنشاء قائمة تشغيل موسيقية مشتركة مع الأصدقاء فوراً—بدون تطبيق، بدون تسجيل دخول، بدون إعلانات. فقط أنشئ صندوقاً، شارك الرابط، وابدأوا في إضافة الأغاني معاً. مثالي للحفلات، الرحلات البرية، أو أي تجمع جماعي!

- 🌐 **بديل مفتوح المصدر لقوائم تشغيل سبوتيفاي التعاونية**
- 🕵️ **لا حاجة لحساب**: استخدمه بشكل مجهول—لا حاجة للتسجيل أو البريد الإلكتروني
- ✨ **شارك رابط، أضف الأغاني معاً**: يمكن للجميع الإضافة في الوقت الفعلي
- 🚀 **لا حاجة لتحميل تطبيق**: يعمل على أي جهاز، مباشرة من المتصفح
- 🎵 **تكامل مع يوتيوب**: ابحث وشغّل تقريباً أي أغنية فوراً
- 📱 **متوافق مع الجوال**: مصمم للهواتف، الأجهزة اللوحية، وأجهزة الكمبيوتر المكتبية
- ⚖️ **ترتيب عادل بالدور**: يتم ترتيب الأغاني تلقائياً ليحصل الجميع على دورهم
- 🆓 **مجاني 100%، بدون إعلانات**

---

## جربه الآن

1. **أنشئ صندوق موسيقى**: زر الصفحة الرئيسية وأنشئ صندوقاً جديداً
2. **شارك الرابط**: أرسل رابط الدعوة إلى أصدقائك
3. **أضف الأغاني**: ابحث في يوتيوب أو أضف الأغاني يدوياً
4. **شغّل الموسيقى**: استخدم المشغل المدمج للاستماع معاً

---
## الميزات

- قوائم تشغيل تعاونية: إضافة، ترتيب، وتشغيل الأغاني معًا
- استخدام مجهول: لا حاجة لتسجيل الدخول أو إنشاء حساب
- البحث والتشغيل من يوتيوب: الوصول إلى مكتبة موسيقية ضخمة
- واجهة مستخدم متجاوبة تركز على الأجهزة المحمولة
- مفتوح المصدر (رخصة MIT)
- نشر سهل باستخدام Docker

### عمليات النشر باستخدام Docker Compose

تشغيل جميع الخدمات:

```bash
docker-compose up -d
```

إعادة نشر الخدمات بدون توقف بعد تحديث الصور:

```bash
bash ./redeploy.sh
```
---

## البدء

### المتطلبات الأساسية

- Node.js 16 أو أحدث
- npm أو yarn
- مفتاح YouTube Data API v3 (مجاني من Google)

### إعداد YouTube API

1. انتقل إلى [وحدة تحكم Google Cloud](https://console.cloud.google.com/)
2. أنشئ مشروعًا جديدًا أو اختر مشروعًا موجودًا
3. فعّل **YouTube Data API v3**
4. أنشئ بيانات الاعتماد (مفتاح API)
5. انسخ مفتاح API الخاص بك

### التثبيت
```bash
# استنساخ المستودع
git clone <your-repo-url>
cd jukebox

# تثبيت تبعيات الخادم
cd server
yarn install

# تثبيت تبعيات الواجهة الأمامية
cd ../frontend
yarn install

# إعداد متغيرات البيئة
cd ../server
cp .env.example .env
# قم بتحرير ملف .env وأضف مفتاح YouTube API الخاص بك

# تشغيل ترحيلات قاعدة البيانات
```
yarn migrate

# بدء خوادم التطوير
# الخلفية:
cd server
yarn dev
# العامل:
cd server
yarn dev:worker
# الواجهة الأمامية (في نافذة طرفية جديدة):
cd frontend
yarn dev
```

---

## الرخصة

MIT

---

## المساهمة والتعليقات

- افتح قضية أو طلب دمج على [GitHub](https://github.com/skeptrunedev/jukebox)
- لديك طلبات ميزات؟ أرسل رسالة مباشرة إلى [@skeptrune على X (تويتر)](https://twitter.com/skeptrune)

---

## سجل التغييرات

راجع [سجل التغييرات](https://jukebox.skeptrune.com#changelog) لمعرفة آخر التحديثات والميزات.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---