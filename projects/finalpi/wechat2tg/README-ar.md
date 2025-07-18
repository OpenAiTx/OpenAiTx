# wechat2tg-mac

استنادًا إلى بروتوكول WeChat لنظام Mac لإرسال واستقبال رسائل WeChat على Telegram، خدمة wx2tg-server ليست مفتوحة المصدر لأسباب أمنية

## مجموعة TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## الوظائف الرئيسية

1. استقبال رسائل الدردشة الفردية في WeChat، رسائل مجموعات WeChat، رسائل الحسابات الرسمية، رسائل WeChat Work (الشركات)
2. إرسال رسائل من Telegram إلى مستخدمي WeChat أو مجموعات WeChat أو الحسابات الرسمية المحددة
3. حجب رسائل المجموعات المحددة

## أنواع الرسائل المدعومة

### قائمة أنواع رسائل WeChat المدعومة

+ [x] رسائل نصية
+ [x] رسائل WeChat Work (الشركات)
+ [x] ملصقات WeChat
+ [x] رسائل الصور
+ [x] رسائل الفيديو
+ [x] مكالمات صوتية/فيديو (إشعار فقط)
+ [x] رسائل الملفات
+ [x] رسائل الروابط
+ [x] رسائل مجموعات الدردشة
+ [x] رسائل الإشارة في المجموعات (@الجميع و@أنت سيتم تحويلها إلى @أنت في Telegram)
+ [x] رسائل الحسابات الرسمية
+ [x] emoji
+ [x] رسائل الموقع الجغرافي
+ [x] رسائل السحب (التراجع)
+ [x] رسائل الصوت
+ [ ] رسائل الهدايا (تنبيه فقط، لا يمكن الحصول على محتوى الهدية)
+ [ ] رسائل التطبيقات المصغرة

### قائمة أنواع رسائل Telegram المدعومة

+ [x] رسائل نصية
+ [x] ملصقات ووجوه تعبيرية
+ [x] رسائل الصور
+ [x] رسائل الفيديو
+ [x] رسائل الملفات
+ [x] رسائل الصوت

## ملاحظات

1. هذا المشروع مخصص فقط للبحث التقني والتعليم، ولا يجوز استخدامه لأغراض غير قانونية
2. يُرحب بتقديم issues في حال مواجهة أي مشكلة

## التثبيت والنشر

انسخ أولاً ملف `.env.example` إلى `.env`، ثم قم بضبط متغيرات البيئة في ملف `.env`

انسخ ملف `app.conf.example` من المشروع إلى ملف `app.conf` وضعه في مجلد `conf`، ثم قم بضبط عنوان Redis إلى عنوان Redis الذي قمت بنشره

### docker-compose

أنشئ ملف `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # بعد ربط مجلد حفظ الملفات، لن تحتاج لتحويل ملفات الملصقات مرة أخرى
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # اسحب الصورة
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### التشغيل

```shell
docker-compose up -d
```

#### إيقاف وضع خصوصية البوت

قم بإيقاف وضع خصوصية الروبوت. افتح BotFather، واكتب `/mybots`، واختر البوت الخاص بك. اضغط على `Bot Settings` - `Group Privacy` - `Turn off`
، إذا ظهرت رسالة `Privacy mode is disabled for xxx` فهذا يعني أنه تم إيقاف الخصوصية بنجاح

## دليل الاستخدام

### أوامر البوت

- `/login`: الحصول على رمز الاستجابة السريعة لتسجيل الدخول؛ أول شخص يرسل أمر `/login` بعد تثبيت البوت سيصبح مالك البوت

- `/flogin`: الحصول على رمز الاستجابة السريعة لتسجيل الدخول كمساعد لنقل الملفات، يدعم استقبال الفيديو والملفات

- `/update`: تحديث صورة المجموعة ومعلومات الأسماء المستعارة

- `/message`: تشغيل/إيقاف استقبال رسائل المجموعات

- `/forward`: تشغيل/إيقاف إعادة توجيه رسائل أعضاء المجموعة الآخرين أو البوت

- `/user`: الحصول على قائمة مستخدمي WeChat؛ بعد الضغط على الزر يمكنك إنشاء مجموعة جديدة أو ربط المستخدم (يمكن البحث بالاسم أو الملاحظة، مثال: `/user 张` للبحث عن مستخدمي WeChat الذين يتضمن اسمهم "张")

- `/room`: الحصول على قائمة مجموعات WeChat؛ بعد الضغط على الزر يمكنك إنشاء مجموعة جديدة أو ربط مجموعة WeChat (يمكن البحث بالاسم أو الملاحظة، مثال: `/room 外卖` للبحث عن مجموعات WeChat التي تحتوي على "外卖")

- `/settings`: إعدادات البرنامج

- `/unbind`: إلغاء ربط مجموعة WeChat أو مستخدم WeChat (فقط للاستخدام في المجموعات)

### شرح متغيرات البيئة

|الاسم| إجباري | الوصف                                                        |
|--|------|------------------------------------------------------------|
|`BOT_TOKEN`| نعم  | رمز بوت Telegram، يتم إنشاؤه عبر [BotFather](https://t.me/BotFather)          |
|`API_ID`| نعم  | معرف API الخاص بـ Telegram API                                   |
|`API_HASH`| نعم  | قيمة API HASH الخاصة بـ Telegram API                            |
|`BASE_API`| نعم  | عنوان طلب API الخاص بحاوية wx2tg-server، يجب إدخال المسار الكامل               | |
|`PROXY_PROTOCOL`| لا   | نوع البروكسي، القيم الممكنة (socks5,http,https)                            |
|`PROXY_HOST`| لا   | عنوان URL الخاص بالبروكسي                                         |
|`PROXY_PORT`| لا   | رقم منفذ البروكسي                                                |
|`PROXY_USERNAME`| لا   | اسم مستخدم البروكسي                                              |
|`PROXY_PASSWORD`| لا   | كلمة مرور البروكسي                                               |
|`ROOM_MESSAGE`| لا   | تنسيق عرض رسائل مجموعات WeChat في البوت                              |
|`OFFICIAL_MESSAGE`| لا   | تنسيق عرض رسائل الحسابات الرسمية في البوت                            |
|`CONTACT_MESSAGE`| لا   | تنسيق عرض رسائل مستخدمي WeChat في البوت                              |
|`ROOM_MESSAGE_GROUP`| لا   | تنسيق عرض رسائل مجموعات WeChat في المجموعات                           |
|`CONTACT_MESSAGE_GROUP`| لا   | تنسيق عرض رسائل مستخدمي WeChat في المجموعات                           |
|`OFFICIAL_MESSAGE_GROUP`| لا   | تنسيق عرض رسائل الحسابات الرسمية في المجموعات                          |
|`CREATE_ROOM_NAME`| لا   | تنسيق اسم المجموعة عند إنشاء مجموعة WeChat تلقائيًا                       |
|`CREATE_CONTACT_NAME`| لا   | تنسيق اسم المجموعة عند إنشاء مجموعة لجهة اتصال WeChat تلقائيًا             |
|`MESSAGE_DISPLAY`| لا   | تنسيق عرض الرسائل النصية                                         |

 ---

### شرح إعدادات أمر `/settings`

1. هل يتم عرض emoji في WeChat كرابط صورة: عند التفعيل سيتم تحويل الرموز التعبيرية الصغيرة المستلمة من الأصدقاء إلى روابط صور

2. مزامنة معلومات المجموعات عند بدء التشغيل: عند التفعيل سيتم مزامنة معلومات الجميع عند بدء البرنامج، وسيتم تحديث صورة المجموعة واسمها

---

### تحويل الصوت إلى نص

1. قم بضبط `TENCENT_SECRET_ID` و `TENCENT_SECRET_KEY`، يمكن الحصول عليهما من [لوحة تحكم التعرف على الصوت من Tencent](https://console.cloud.tencent.com/asr)
   . يوجد حصة مجانية للاستخدام
2. قم بتفعيل ميزة التحويل التلقائي من صوت إلى نص في إعدادات `/settings`

---

### كيفية الحصول على `API_ID` و `API_HASH`

1. سجل الدخول إلى [telegram account](https://my.telegram.org/)

2. ثم اضغط على "API development tools" واملأ تفاصيل التطبيق (يكفي إدخال اسم التطبيق المختصر والعنوان)

3. أخيرًا اضغط "Create application"

---

### تخصيص قوالب الرسائل

إذا كنت ترغب في تعديل تنسيق مرسل الرسالة، يمكنك تعديل متغيرات البيئة في docker أو ملف `.env`

الرموز المتغيرة المتاحة في قوالب الرسائل:

`#[alias]`: الملاحظة (الاسم المستعار) لجهة الاتصال

`#[name]`: اسم جهة الاتصال

`#[topic]`: اسم مجموعة الدردشة

`#[alias_first]`: الأولوية للملاحظة، إذا لم توجد فسيظهر اسم جهة الاتصال

`#[identity]`: نص معلومات الهوية

`#[body]`: نص الرسالة

`#[br]`: سطر جديد

### كيف @الجميع

إرسال رسالة تبدأ بـ `@all` سيقوم بعمل إشارة لجميع الأعضاء، فقط الرسائل النصية تدعم @الجميع

---

## الأسئلة الشائعة


## المساهمة في التطوير

1. قم بعمل fork للمشروع، وانتقل إلى فرع `wx2tg-mac-dev` أو أنشئ فرعًا جديدًا. الرجاء عدم إرسال الأكواد مباشرة إلى الفرع الرئيسي
2. أرسل Pull Request إلى فرع `wx2tg-mac-dev`


## الرخصة

[MIT](LICENSE)


## الشكر

شكرًا لـ Jetbrains على دعمهم لهذا المشروع

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---