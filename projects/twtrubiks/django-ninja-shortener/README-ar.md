# Django Ninja Shortener - خدمة تقصير الروابط مثل Bitly

خدمة تقصير روابط حديثة مبنية باستخدام Django، Django Ninja و Tailwind CSS، مستوحاة من تصميم Bitly.

يمكن للمستخدمين التسجيل وتسجيل الدخول لتقصير الروابط وتتبع عدد النقرات لكل رابط مختصر.

يستخدم هذا المشروع [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) للمساعدة في الإنجاز، يمكن الرجوع إلى [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## لقطات الشاشة

صفحة الروابط المختصرة (يمكن استخدامها بدون تسجيل)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

إذا قمت بالتسجيل يمكنك تتبع النقرات

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ أبرز الميزات

* **توثيق المستخدم**: دعم التسجيل، تسجيل الدخول، وتسجيل الخروج.
* **إنشاء روابط مختصرة**: يمكن للمستخدمين المسجلين إنشاء رابط مختصر فريد لأي رابط طويل.
* **إعادة توجيه الرابط المختصر**: عند النقر على الرابط المختصر، يتم إعادة توجيه المستخدم للرابط الأصلي الطويل.
* **تتبع عدد النقرات**: النظام يحسب تلقائياً عدد مرات النقر لكل رابط مختصر.
* **لوحة تحكم شخصية**: يمكن للمستخدمين عرض جميع روابطهم المختصرة وإحصائيات النقرات الخاصة بها.
* **RESTful API**: توفير نقاط نهاية API لإنشاء الروابط المختصرة برمجياً.
* **دعم Docker**: توفير ملف Dockerfile و Docker Compose لتسهيل التطوير والنشر.

## 🛠️ التقنيات المستخدمة

* **إطار العمل الخلفي**: [Django](https://github.com/twtrubiks/django-tutorial)
* **إطار عمل API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **تصميم الواجهة الأمامية**: [Tailwind CSS](https://tailwindcss.com/) (متكامل عبر `django-tailwind`)
* **قاعدة البيانات**:
  * بيئة التطوير: SQLite (افتراضي)
  * بيئة الإنتاج: يمكن التبديل بسهولة إلى PostgreSQL (الإعدادات موجودة مسبقاً في `settings.py`)
* **كود الرابط المختصر**: يتم التوليد باستخدام `shortuuid`
* **الاختبار**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **حاويات**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 بدء سريع (باستخدام Docker، يُنصح به)

هذه هي الطريقة الموصى بها للتشغيل، حيث تضمن لك بيئة تطوير متسقة.

**خطوات التشغيل:**

1. **تشغيل الخدمة:**

    استخدم Docker Compose لتشغيل جميع الخدمات بضغطة واحدة.

    ```bash
    docker compose up --build
    ```

    هذا الأمر سيبني صورة Docker، يثبت التبعيات، ينفذ ترحيل قاعدة البيانات، ويشغل خادم التطوير.

2. **إنشاء مستخدم فائق الصلاحية (اختياري):**

    إذا رغبت بالدخول إلى لوحة إدارة Django، نفذ في نافذة طرفية أخرى:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **الوصول إلى التطبيق:**

    * **الصفحة الرئيسية للموقع**: [http://localhost:8000](http://localhost:8000)

    * **توثيق API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 التطوير المحلي (بدون Docker)

إذا كنت تفضل إعداد البيئة محلياً مباشرةً.

**المتطلبات الأساسية:**

* Python 3.12
* Node.js و npm (لاستخدام Tailwind CSS)

**خطوات الإعداد:**

1. **إنشاء وتفعيل البيئة الافتراضية:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # على Windows استخدم `venv\Scripts\activate`
    ```

2. **تثبيت تبعيات Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **تثبيت وإعداد Tailwind CSS:**

    يقوم `django-tailwind` بمعظم الإعدادات.

    ```bash
    python manage.py tailwind install
    ```

    يمكن الرجوع إلى [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **تنفيذ ترحيل قاعدة البيانات:**

    ```bash
    python manage.py migrate
    ```

5. **إنشاء مستخدم فائق الصلاحية (اختياري):**

    ```bash
    python manage.py createsuperuser
    ```

6. **تشغيل خادم التطوير:**

    تحتاج لتشغيل خادم Django وبرنامج ترجمة Tailwind CSS في نفس الوقت.

    ```bash
    python manage.py runserver
    ```

    وفي نافذة طرفية أخرى:

    ```bash
    python manage.py tailwind start
    ```

7. **الوصول إلى التطبيق:**

    * **الصفحة الرئيسية للموقع**: [http://localhost:8000](http://localhost:8000)

    * **توثيق API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 تشغيل الاختبارات

يستخدم هذا المشروع `pytest` للاختبار وحساب نسبة التغطية بالاختبارات.

خطة الاختبار يمكن مراجعتها في [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **تشغيل الاختبارات عبر Docker:**

    ```bash
    docker compose --profile test up
    ```

    سيتم إنشاء تقرير الاختبار في `htmlcov/index.html`.

* **تشغيل الاختبارات محلياً:**

    ```bash
    # تأكد من تثبيت تبعيات التطوير
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 نقاط نهاية API

يوفر الـ API طريقة برمجية للتفاعل مع خدمة تقصير الروابط. جميع نقاط النهاية تحت مسار `/api/`.

ينصح بالدخول مباشرة إلى **توثيق API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

باستخدام [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt)، استدعي `/api/token/pair` باستخدام اسم المستخدم وكلمة المرور للحصول على رمز الدخول (token) الخاص بك

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

ثم الصق رمز الدخول في أعلى اليمين، ويمكنك استدعاء الـ API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 هيكلية المشروع

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # إعدادات مشروع Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # تطبيق تقصير الروابط الأساسي
│   ├── models.py         # نماذج قاعدة البيانات (Link)
│   ├── api.py            # نقاط نهاية Django Ninja API
│   ├── views.py          # منطق الصفحات وإعادة التوجيه
│   └── utils.py          # أدوات توليد الكود المختصر
└── theme/                # القوالب والسمات في Django
    ├── templates/        # قوالب HTML
    └── static_src/       # ملفات Tailwind CSS الأصلية
```

## 💡 آفاق مستقبلية

* **الانتقال إلى PostgreSQL**: قاعدة بيانات أكثر استقراراً للإنتاج. (تم التنفيذ)
* **لوحة تحكم تحليلية مفصلة**: تقديم بيانات أكثر عن النقرات مثل الوقت، المصدر، والموقع الجغرافي.
* **تخصيص الروابط المختصرة**: يسمح للمستخدمين بتخصيص رمز الرابط المختصر.
* **توليد رمز QR**: توليد رمز QR لكل رابط مختصر.
* **المهام غير المتزامنة**: استخدام Celery لمعالجة المهام التي تستهلك وقتًا، مثل تحليل البيانات.

## التبرع

جميع المقالات هي من بحثي الخاص وإنتاجي الأصلي، إذا أفادتك وأردت تشجيعي، يسعدني أن تدعوني لفنجان قهوة :laughing:

ECPAY من Green World (لا حاجة لتسجيل عضوية)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[دفع المتبرع](http://bit.ly/2F7Jrha)

O'Pay (يتطلب تسجيل عضوية)

![alt tag](https://i.imgur.com/LRct9xa.png)

[دفع المتبرع](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## قائمة الداعمين

[قائمة الداعمين](https://github.com/twtrubiks/Thank-you-for-donate)

## الرخصة

رخصة MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---