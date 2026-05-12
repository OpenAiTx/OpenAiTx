<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# أبستات

> أداة بسيطة وسهلة الاستخدام لمراقبة الحالة مُستضافة ذاتياً


![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 العرض التجريبي المباشر

جربه.

خادم العرض التجريبي (الموقع: سنغافورة): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

اسم المستخدم: `demo`
كلمة المرور: `demodemo`

## ⭐ الميزات

يحتاج إلى المزيد من الميزات ولكن حالياً...

- مراقبة التوفر لخدمات HTTP(s)
- مخطط الحالة والكمون
- إشعارات عبر Discord
- فواصل زمنية كل 60 ثانية
- واجهة مستخدم تفاعلية وسريعة وأنيقة
- صفحات حالة متعددة
- ربط صفحات الحالة بنطاقات محددة
- مخطط القياس (Ping)
- معلومات الشهادة
- تطبيق ويب تقدمي (PWA)
- دعم قاعدة بيانات Sqlite & Postgres

وعشرات الميزات الصغيرة التي ستتم إضافتها.

## 🔧 كيفية التثبيت

### 🐳 Docker

لـ Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
لبوستجريس


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```
أبستات يعمل الآن على http://localhost:3000

> [!هام]
> تأكد من تغيير قيم البيئة قبل النشر.

### 💪🏻 بدون Docker

المتطلبات:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (اختياري)


```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## مجموعة التقنيات

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 المساهمة

أرحب بالمساهمات! المساهمات هي ما يجعل مجتمع المصادر المفتوحة مكانًا رائعًا للتعلم والإلهام والابتكار. أي مساهمة تقوم بها **موضع تقدير كبير**.

إذا كان لديك اقتراح لتحسين هذا المشروع، يرجى عمل fork للمستودع، وإجراء التغييرات وإنشاء طلب سحب. يمكنك أيضًا فتح قضية مع الوسم "تحسين".
لا تنسَ إعطاء المشروع نجمة! شكرًا مرة أخرى!

1. قم بعمل Fork للمشروع
2. أنشئ فرع الميزة الخاص بك (`git checkout -b feature/AmazingFeature`)
3. قم بتثبيت تغييراتك (`git commit -m 'Add some AmazingFeature'`)
4. ادفع إلى الفرع (`git push origin feature/AmazingFeature`)
5. افتح طلب سحب

## المساهمون

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 الرخصة

هذا المشروع مرخص بموجب [رخصة MIT](https://opensource.org/license/mit/).

## 🖼 لقطات شاشة إضافية

إنشاء مراقب

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

صفحة المراقب

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---