
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

تقدم شركة Tencent EdgeOne دعم تسريع CDN وحماية الأمان لهذا المشروع.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

مؤلف هذا المشروع هو colin1114.

# 🚀 محول اشتراكات Clash

أداة إلكترونية جميلة وقوية لتحويل روابط اشتراكات البروكسي المختلفة إلى تنسيق إعدادات Clash. يدعم النشر التلقائي عبر Cloudflare Workers & Pages، ويوفر خدمة تحويل اشتراكات سريعة وموثوقة.

## ✨ الميزات الوظيفية

- 🎨 **واجهة حديثة وجذابة** - تصميم بخلفية متدرجة وبطاقات
- 🔄 **دعم بروتوكولات متعددة** - يدعم V2Ray وVLESS وShadowsocks وTrojan وغيرها من البروتوكولات الشائعة
- ☁️ **النشر السحابي** - تسريع CDN عالمي عبر Cloudflare Workers
- 📱 **تصميم متجاوب** - متوافق تمامًا مع أجهزة الكمبيوتر والموبايل
- ⚡ **تحويل سريع** - تحويل فوري لرابط الاشتراك إلى إعدادات Clash
- 📋 **نسخ ذكي** - يدعم نسخ إعدادات YAML بنقرة واحدة، متوافق مع جميع المتصفحات
- 📡 **إنشاء روابط اشتراك** - إنشاء تلقائي لروابط اشتراك قابلة للاستيراد مباشرة في Clash
- 🌐 **الوصول إلى YAML عبر الإنترنت** - يوفر طرقًا متعددة للوصول إلى ملفات YAML:
  - 📡 رابط الاشتراك: يدعم التحديث التلقائي لعميل Clash
  - 🔗 العرض عبر الإنترنت: عرض الإعدادات مباشرة في المتصفح
  - 💾 تحميل الملف: تنزيل ملف .yaml إلى الجهاز المحلي
  - ⚡ وصول سريع: رابط تنزيل مبسط
- 🔧 **دعم UTF-8** - دعم كامل لأسماء العقد الصينية والإعدادات
- 🆓 **مجاني بالكامل** - يعتمد على خدمات Cloudflare المجانية بدون قيود استخدام

## 📁 هيكل المشروع

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 البدء السريع

### الطريقة الأولى: التشغيل المحلي

1. **استنساخ المشروع**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **تشغيل الخادم المحلي**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **زيارة التطبيق**
   - افتح المتصفح وادخل إلى `http://localhost:8000`
   - سيتم عرض إعدادات المثال في بيئة العمل المحلية

### الطريقة الثانية: النشر عبر Cloudflare Workers

#### الخطوة 1: إنشاء Worker

1. زر [Cloudflare Workers](https://workers.cloudflare.com/)
2. قم بالتسجيل/تسجيل الدخول إلى حساب Cloudflare الخاص بك
3. اضغط على "Create a Worker"
4. انسخ الكود بالكامل من `worker.js` إلى المحرر
5. اضغط على "Save and Deploy"

#### الخطوة 2: النشر باستخدام Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### الخطوة 3: إعداد اسم النطاق (اختياري)

1. إضافة اسم نطاق مخصص في إعدادات Worker
2. أو استخدام اسم النطاق الافتراضي الذي توفره Cloudflare

### الطريقة الثالثة: النشر عبر Cloudflare Pages

#### الخيار A: التكامل مع GitHub (موصى به)

1. **تحضير المستودع**
   - ادفع الشيفرة إلى مستودع GitHub
   - تأكد من تضمين جميع الملفات الضرورية

2. **إنشاء مشروع Pages**
   - انتقل إلى [Cloudflare Pages](https://pages.cloudflare.com/)
   - اربط مستودع GitHub الخاص بك
   - اختر مستودع المشروع

3. **إعدادات البناء**
   - أمر البناء: اتركه فارغًا أو `echo "No build required"`
   - دليل إخراج البناء: `/` (الدليل الجذري)
   - متغيرات البيئة: لا حاجة للإعداد

#### الخيار B: التحميل المباشر

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ الهيكلية التقنية

### حزمة التقنيات للواجهة الأمامية
- **HTML5** - لغة الترميز الحديثة
- **CSS3** - التصميم المتجاوب وتأثيرات الحركة
- **Vanilla JavaScript** - تفاعلات الواجهة الأمامية الخفيفة

### حزمة التقنيات للواجهة الخلفية
- **Cloudflare Workers** - منصة الحوسبة الطرفية
- **Web APIs** - واجهات Fetch القياسية ومعالجة الاستجابة

### صيغ البروتوكولات المدعومة
- **VMess** - بروتوكول V2Ray القياسي
- **VLESS** - بروتوكول V2Ray الخفيف (يدعم Reality)
- **Shadowsocks** - بروتوكول الوكيل الكلاسيكي
- **Trojan** - بروتوكول وكيل ناشئ

### نقاط نهاية API
- `GET /` - الصفحة الرئيسية
- `POST /convert` - واجهة تحويل الاشتراك
- `GET /clash/{config-id}` - الحصول على ملف إعدادات YAML (رابط الاشتراك)
- `GET /yaml/{config-id}` - تنزيل ملف إعدادات YAML
- `OPTIONS /*` - طلب التحقق المسبق لـ CORS

## 📖 دليل الاستخدام

### الاستخدام الأساسي

1. **إدخال رابط الاشتراك**
   - الصق رابط الاشتراك الخاص بوكيلك في مربع الإدخال
   - يدعم روابط الاشتراك المشفرة بـ Base64

2. **تعيين اسم الإعدادات**
   - يمكنك اختيارياً تعيين اسم مخصص لملف الإعدادات
   - الاسم الافتراضي هو "My Clash Config"

3. **تحويل الإعدادات**
   - اضغط على زر "تحويل الاشتراك"
   - انتظر حتى يكتمل التحويل
4. **استخدام التكوين**
   - انسخ ملف YAML الذي تم إنشاؤه
   - استورد الملف في عميل Clash لاستخدامه

5. **استخدام رابط الاشتراك (موصى به)**
   - انسخ رابط الاشتراك الذي تم إنشاؤه
   - أضفه في عميل Clash ضمن الاشتراكات
   - سيتم مزامنة التكوين تلقائيًا، لا حاجة للتحديث اليدوي

### التكوينات المتقدمة

ملف تكوين Clash المولد يتضمن الميزات التالية:

- **سياسة مجموعات الوكيل**
  - 🚀 اختيار العقدة - اختيار يدوي للوكيل
  - ♻️ اختيار تلقائي - اختبار تلقائي بناءً على التأخير
  - 🎯 اتصال عالمي مباشر - اتصال مباشر

- **تكوين DNS**
  - تفعيل تحليل DNS
  - دعم وضع fake-ip
  - تقسيم DNS بين المحلي والدولي

- **قواعد التوجيه**
  - اتصال مباشر للعناوين المحلية
  - اتصال مباشر لعناوين IP المحلية
  - تمرير باقي الحركة عبر الوكيل

## 🔧 استكشاف أخطاء النشر وإصلاحها

### المشاكل الشائعة

#### 1. لا يمكن لـ Wrangler العثور على نقطة الدخول
**رسالة الخطأ**: `Missing entry-point to Worker script`

**الحل**: 
- تأكد من وجود ملف `wrangler.jsonc` في المجلد الرئيسي للمشروع
- تحقق من أن حقل `main` في `wrangler.jsonc` يشير إلى `worker.js`


#### 2. فشل النشر باستخدام GitHub Actions
**الحل**:
- أضف الأسرار التالية في إعدادات مستودع GitHub:
  - `CLOUDFLARE_API_TOKEN`: رمز API الخاص بـ Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: معرف حساب Cloudflare

#### 3. فشل بناء Pages
**الحل**:
- اجعل أمر البناء فارغًا أو استخدم `echo "No build required"`
- تأكد من تعيين دليل إخراج البناء إلى `/`

### شرح ملفات إعدادات النشر

- **`wrangler.jsonc`**: إعدادات واجهة الأوامر Wrangler، تُستخدم لنشر Worker
- **`_headers`**: إعداد رؤوس HTTP لـ Cloudflare Pages
- **`.github/workflows/deploy.yml`**: إعدادات النشر التلقائي باستخدام GitHub Actions

## 🔧 إعدادات مخصصة

### تعديل مجموعات الوكيل

يمكنك تعديل دالة `convertToClash` في ملف `worker.js` لتخصيص مجموعات الوكيل:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### قواعد التوجيه المخصصة

قم بتعديل مصفوفة `rules` لإضافة قواعد توجيه مخصصة:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 ميزات الأداء

- **CDN عالمي** - تغطية Cloudflare لعقد الحافة حول العالم
- **استجابة سريعة** - متوسط زمن الاستجابة < 100 مللي ثانية
- **توفر عالي** - توفر الخدمة بنسبة 99.9%
- **حصة مجانية** - 100,000 طلب يوميًا مجانًا

## 🔒 تعليمات الأمان

- **خصوصية البيانات** - بيانات الاشتراك تُستخدم فقط أثناء التحويل ولا يتم تخزينها
- **تشفير HTTPS** - جميع الاتصالات مشفرة عبر HTTPS
- **شفافية المصدر المفتوح** - الشيفرة الكاملة متاحة ويمكن مراجعتها ذاتيًا

## 🤝 دليل المساهمة

نرحب بتقديم القضايا وطلبات السحب!

1. قم بعمل Fork لهذا المستودع
2. أنشئ فرع ميزة (`git checkout -b feature/AmazingFeature`)
3. قدم التغييرات (`git commit -m 'Add some AmazingFeature'`)
4. ادفع التغييرات للفرع (`git push origin feature/AmazingFeature`)
5. افتح طلب سحب

## 📝 سجل التحديثات

### v1.1.0
- ✅ دعم بروتوكول VLESS الجديد (بما في ذلك نقل Reality الآمن)
- ✅ تحسين توافق البروتوكولات

### v1.0.0
- ✅ وظيفة تحويل الاشتراكات الأساسية
- ✅ واجهة مستخدم جذابة
- ✅ دعم Cloudflare Workers
- ✅ دعم بروتوكولات متعددة (VMess، Shadowsocks، Trojan)
- ✅ تصميم متجاوب
- ✅ وظيفة النسخ بنقرة واحدة

## 📞 الدعم والملاحظات

إذا واجهت أي مشكلة أو كان لديك اقتراح أثناء الاستخدام، يرجى:

1. مراجعة وثيقة README هذه
2. تقديم [Issue](../../issues)
3. بدء [Discussion](../../discussions)

## 📄 الترخيص

يعتمد هذا المشروع ترخيص MIT - راجع ملف [LICENSE](LICENSE)

## 🙏 الشكر والتقدير

- [Cloudflare Workers](https://workers.cloudflare.com/) - توفير منصة الحوسبة الطرفية
- [Clash](https://github.com/Dreamacro/clash) - عميل وكيل ممتاز
- دعم جميع المساهمين والمستخدمين

---

⭐ إذا كان هذا المشروع مفيداً لك، يرجى منحه نجمة! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---