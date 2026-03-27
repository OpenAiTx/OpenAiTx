<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![الحالة](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![الترخيص](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# يور لاست إف إم

تطبيق Node.js يعمل في حاوية (container) يقوم بمزامنة الاستماعات من **Last.fm**، ويخزنها في قاعدة بيانات **SQLite** محلية، ويوفر لوحة تحكم ويب.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## المشروع

**Your LastFM** هو تطبيق Node.js مصمم لـ **مزامنة سجلات الاستماع الموسيقي تلقائيًا** من Last.fm. يحفظ سجل الاستماع الخاص بك في قاعدة بيانات SQLite محلية ويقدم واجهة ويب لعرض البيانات بصريًا.

المشروع محاط بالكامل بحاويات باستخدام **Docker**، مع نقطة دخول تلقائية للتعامل مع تهيئة قاعدة البيانات والتنفيذ المتسلسل (المزامنة أولاً ثم إطلاق واجهة برمجة تطبيقات الويب). كما يستخدم **PM2** كمدير عمليات داخل الحاوية لضمان بقاء خدمة الويب نشطة ومرنة.

## الميزات
### لوحة تحكم ويب تفاعلية

- واجهة ويب نظيفة وحديثة لعرض نشاطك الموسيقي.

### مزامنة تلقائية لسجلات Last.fm

- يسترجع ويخزن سجل الاستماع الخاص بك (scrobbles) من Last.fm بشكل دوري.
- يضمن أن بياناتك محدثة دائمًا دون تدخل يدوي.

### قاعدة بيانات محلية لسجل الموسيقى

- يحفظ جميع سجلات الاستماع في قاعدة بيانات SQLite محلية.
- يسمح باستعلامات سريعة والوصول دون اتصال إلى بيانات الاستماع التاريخية.

### عرض سجلات الاستماع الأخيرة

- يعرض أحدث المقاطع الموسيقية التي استمعت إليها.
- منطق ذكي لاستبدال الصور للمقاطع والألبومات والفنانين.

### مقارنة الأصدقاء (عرض التوافق)

- قارن ذوقك الموسيقي مع أصدقاء Last.fm.
- يعرض مستوى التوافق (من منخفض جدًا → فائق).
- يعرض الفنانين والألبومات والمقاطع المشتركة في القمة.
- يحسب ويطبع مستوى التوافق بناءً على بيانات الاستماع الفعلية.

### بطاقات موسيقية قابلة للمشاركة

- يولد صور ديناميكية بناءً على بيانات الاستماع الخاصة بك.
- تصاميم محسنة لنشر التغذية وقصص انستغرام (9:16)

- تم البناء باستخدام node-canvas لتصيير الصور على جانب الخادم.

## المتطلبات الأساسية

* [دوكر](https://docs.docker.com/get-docker/)
* [دوكر كومبوز](https://docs.docker.com/compose/install/)

## التثبيت

### إنشاء ملف `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: أنشئ حساب API [هنا](https://www.last.fm/api/account/create) للحصول على مفتاح API الخاص بك.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

على الطرفية:
`docker compose up -d`

ثم قم بالوصول إلى:
```
http://localhost:1533
```

(أو استبدل `localhost` بعنوان IP الخاص بخادمك)

## الترخيص

هذا المشروع مرخص بموجب رخصة MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---