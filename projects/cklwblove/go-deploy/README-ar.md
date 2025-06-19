# أداة النشر Go-Deploy

أداة نشر آلي مبنية بلغة Go، تدعم رفع نواتج البناء المحلية إلى الخادم البعيد عبر بروتوكول SFTP.

## الميزات الوظيفية

- ✅ **نقل آمن**: استخدام بروتوكول SFTP، يعتمد على تشفير SSH
- ✅ **مزامنة الدلائل**: رفع هيكلية الدليل بالكامل بشكل متكرر مع الحفاظ على بنية الملفات
- ✅ **إنشاء ذكي**: إنشاء هيكلية الدليل البعيد تلقائيًا
- ✅ **تكيّف المسارات**: حساب المسار المحلي تلقائيًا بناءً على موقع الملف التنفيذي، دون الحاجة لمعرفة دليل التنفيذ
- ✅ **دعم ملفات الإعداد**: يدعم ملفات إعداد بصيغة JSON، لتسهيل إدارة إعدادات البيئات المختلفة
- ✅ **استثناء الملفات**: يدعم أنماط البدل لاستثناء الملفات غير المراد رفعها
- ✅ **نسخ احتياطي تلقائي**: إمكانية عمل نسخة احتياطية للملفات البعيدة قبل الرفع تلقائيًا
- ✅ **آلية إعادة المحاولة**: إعادة المحاولة تلقائيًا عند فشل الرفع، لزيادة نسبة النجاح
- ✅ **إحصائيات مفصلة**: عرض عدد الملفات المرفوعة، حجم النقل، الوقت المستغرق والسرعة
- ✅ **عرض التقدم**: عرض تقدم الرفع ومعلومات الملفات بشكل لحظي
- ✅ **معالجة الأخطاء**: معالجة شاملة للأخطاء وإخراج السجلات

## متطلبات النظام

- Go 1.18 أو إصدار أعلى
- يجب أن يدعم الخادم الهدف بروتوكول SSH/SFTP

## تعليمات التثبيت

### 1. استنساخ المشروع

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. تهيئة وحدة Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. تثبيت الاعتمادات

سيقوم البرنامج تلقائيًا بتحميل الاعتمادات التالية:

- `github.com/pkg/sftp` - عميل SFTP
- `golang.org/x/crypto/ssh` - عميل SSH

## شرح الإعدادات

يدعم البرنامج طريقتين للإعداد:

### 1. استخدام ملف إعداد (موصى به)

قم بنسخ `config.example.json` إلى `config.json` وعدّل الإعدادات:

```bash
cp config.example.json config.json
```

ثم حرر ملف `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### شرح عناصر الإعداد

**إعدادات server**:

- `host`: عنوان خادم SSH
- `port`: منفذ SSH، عادة 22
- `username`: اسم مستخدم SSH
- `password`: كلمة مرور SSH (يوصى باستخدام التوثيق بالمفتاح في بيئة الإنتاج)
- `timeout`: مهلة الاتصال (بالثواني)

**إعدادات paths**:

- `local`: مسار الدليل المحلي، يدعم المسارات النسبية والمطلقة
- `remote`: مسار الدليل البعيد، يجب أن يكون مسارًا مطلقًا

**إعدادات options**:

- `backup`: هل يتم إنشاء نسخة احتياطية للملفات البعيدة الموجودة قبل الرفع
- `backup_suffix`: لاحقة ملفات النسخ الاحتياطي، يمكن تخصيصها، وإذا لم توجد ملفات للنسخ الاحتياطي يتم تخطي النسخ
- `exclude_patterns`: أنماط استثناء الملفات، يدعم البدل
- `max_retries`: أقصى عدد لمحاولات إعادة الرفع عند الفشل
- `chunk_size`: حجم كتلة نقل الملفات (بايت، لم يتم تفعيلها بعد)

### 2. الإعداد الافتراضي (وضع التوافق)

إذا لم يوجد ملف `config.json` سيستخدم البرنامج الإعدادات الافتراضية المدمجة، للحفاظ على التوافق مع الإصدارات السابقة.

#### أولوية ملفات الإعداد

1. **ملف الإعداد المحدد بسطر الأوامر**: الملف المحدد عبر معامل `--config`
2. **ملف الإعداد الافتراضي**: `config.json` في الدليل الحالي
3. **الإعداد الافتراضي المدمج**: إذا لم يوجد أي مما سبق، يستخدم البرنامج الإعدادات المدمجة

#### قواعد معالجة المسارات

- **مسار ملف الإعداد**:

  - المسار النسبي: يعتمد على دليل الملف التنفيذي
  - المسار المطلق: يستخدم كما هو

- **مسار الدليل المحلي**:

  - المسار النسبي: يعتمد على دليل الملف التنفيذي
  - المسار المطلق: يستخدم كما هو

## شرح التشغيل

### معلمات سطر الأوامر

يدعم البرنامج معلمات سطر الأوامر التالية:

```bash
# عرض معلومات المساعدة
./deploy --help

# عرض معلومات الإصدار  
./deploy --version

# استخدام ملف الإعداد الافتراضي config.json
./deploy

# استخدام ملف إعداد محدد
./deploy --config prod.json

# استخدام ملف إعداد بمسار مطلق
./deploy --config /path/to/config.json
```

### التشغيل في بيئة التطوير

```bash
# استخدام الإعداد الافتراضي
go run main.go

# استخدام ملف إعداد محدد
go run main.go --config test.json

# عرض المساعدة
go run main.go --help
```

### التشغيل بعد الترجمة

```bash
# الترجمة
go build -o deploy main.go

# التشغيل باستخدام الإعداد الافتراضي
./deploy

# التشغيل باستخدام ملف إعداد محدد
./deploy --config prod.json
```

## شرح التغليف

### 1. تغليف لمنصة محلية

```bash
# ترجمة ملف تنفيذي لمنصة التشغيل الحالية
go build -o deploy main.go
```

### 2. تغليف عبر الأنظمة

#### Linux 64-بت

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-بت
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64 بت

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. تحسين الحزمة (تقليل حجم الملف)

```bash
# إزالة معلومات التصحيح وجداول الرموز
go build -ldflags="-s -w" -o deploy main.go

# ضغط باستخدام UPX (يجب تثبيت UPX أولاً)
upx --best deploy
```

### 4. سكريبت تجميع متعدد الدُفعات

أنشئ سكريبت `build.sh`:

```bash
#!/bin/bash

# إنشاء مجلد البناء
mkdir -p builds

# بناء نسخ المنصات المختلفة
echo "بناء نسخة Linux 64 بت..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "بناء نسخة Windows 64 بت..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "بناء نسخة macOS 64 بت..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "بناء نسخة macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "اكتمل البناء!"
ls -la builds/
```

تشغيل السكريبت:

```bash
chmod +x build.sh
./build.sh
```

## أمثلة الاستخدام

### عرض معلومات المساعدة

```bash
$ ./deploy --help
أداة النشر Go-Deploy

الاستخدام: ./deploy [خيارات]

الخيارات:
  -config string
        مسار ملف الإعدادات (default "config.json")
  -help
        عرض معلومات المساعدة
  -version
        عرض معلومات الإصدار

أمثلة:
  ./deploy                           # استخدام ملف الإعدادات الافتراضي config.json
  ./deploy --config prod.json        # استخدام ملف إعدادات محدد
  ./deploy --config /path/to/config.json  # استخدام ملف إعدادات بمسار مطلق
```

### استخدام ملف إعدادات محدد

```bash
$ ./deploy --config prod.json
بدء تنفيذ برنامج النشر...
محاولة قراءة ملف الإعدادات: /path/to/go-deploy/prod.json
يتم استخدام ملف الإعدادات...
المجلد المحلي /path/to/project/dist موجود
يتم الاتصال بخادم SSH...
تم الاتصال بخادم SSH بنجاح
...
```

### استخدام ملف الإعدادات

```bash
$ ./deploy
بدء تنفيذ برنامج النشر...
محاولة قراءة ملف الإعدادات: /path/to/go-deploy/config.json
يتم استخدام ملف الإعدادات...
المجلد المحلي /path/to/project/unpackage/dist/build/web موجود
يتم الاتصال بخادم SSH...
تم الاتصال بخادم SSH بنجاح
يتم إنشاء عميل SFTP...
تم إنشاء عميل SFTP بنجاح
الاستعداد للرفع إلى المجلد البعيد: /opt/xsoft/nginx/html/app/dist
بدء رفع المجلد...
بدء استعراض المجلد المحلي: /path/to/project/unpackage/dist/build/web
إنشاء مجلد: /opt/xsoft/nginx/html/app/dist
تم استبعاد الملف static/js/app.js.map، تم تخطي الرفع
إنشاء نسخة احتياطية: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
رفع الملف: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
تم استبعاد الملف .DS_Store، تم تخطي الرفع
رفع الملف: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
فشل الرفع (محاولة 1/3): خطأ في الشبكة
إعادة محاولة رفع الملف (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
رفع الملف: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
تم رفع المجلد بنجاح!
الإحصاءات:
  - عدد الملفات المرفوعة: 485
  - عدد المجلدات المنشأة: 18
  - حجم النقل: 25.8 MB
  - زمن الرفع: 38.5s
  - الزمن الكلي: 39.2s
  - سرعة النقل: 0.67 MB/s
```

## ملاحظات هامة

1. **الأمان**:

   - يوصى باستخدام المصادقة بمفتاح SSH في بيئة الإنتاج بدلاً من المصادقة بكلمة المرور
   - حالياً يستخدم `ssh.InsecureIgnoreHostKey()`، يجب في بيئة الإنتاج التحقق من مفتاح المضيف
2. **الشبكة**:

   - تأكد من أن الجهاز المحلي يمكنه الوصول إلى المنفذ 22 في الخادم الهدف
   - سرعة النقل تعتمد على عرض النطاق الترددي للشبكة وأداء الخادم
3. **الصلاحيات**:

   - تأكد أن مستخدم SSH لديه صلاحية الكتابة على المجلد الهدف
   - إذا لزم الأمر، قد تحتاج لاستخدام صلاحيات sudo
4. **المسارات**:

   - يتم حساب المسار المحلي تلقائياً بناءً على مكان الملف التنفيذي، لا داعي للقلق بشأن مجلد التنفيذ
   - المسار البعيد يجب أن يكون مطلقاً

## استكشاف الأخطاء وإصلاحها

### المشاكل الشائعة

1. **انتهاء مهلة الاتصال**

   ```
   فشل الاتصال بخادم SSH: dial tcp: i/o timeout
   ```

   - تحقق من عنوان الخادم والمنفذ
   - تأكد من اتصال الشبكة
   - تحقق من إعدادات الجدار الناري
2. **فشل المصادقة**

   ```
   فشل تسجيل الدخول: ssh: handshake failed
   ```

   - تحقق من اسم المستخدم وكلمة المرور
   - تأكد أن خدمة SSH تعمل
   - تحقق من إعدادات SSH
3. **خطأ في الصلاحيات**

   ```
   فشل إنشاء المجلد: permission denied
   ```

   - تحقق من صلاحية المستخدم على المجلد الهدف
   - قد تحتاج لاستخدام sudo أو تغيير مالك المجلد
4. **المجلد المحلي غير موجود**

   ```
   خطأ: المجلد المحلي /path/to/unpackage/dist/build/web غير موجود
   ```

   - تأكد من إتمام البناء المحلي
   - تحقق من هيكلية مجلد المشروع
   - البرنامج سيحسب المسار تلقائياً، لا داعي لتعديل مجلد العمل يدوياً

## تعليمات التطوير

### هيكلية المشروع

```
go-deploy/
├── main.go                 # ملف البرنامج الرئيسي
├── go.mod                  # ملف وحدة Go  
├── go.sum                  # ملف التحقق من الاعتمادات
```
├── README.md               # وثيقة الشرح التفصيلية  
├── Makefile                # أداة البناء  
├── build.sh                # سكريبت التجميع الدفعي  
├── install.sh              # سكريبت التثبيت بنقرة واحدة  
└── config.example.json     # نموذج ملف التكوين  
```

### الدوال الرئيسية

- `main()` - الدالة الرئيسية، تعالج الاتصال واستدعاء الرفع  
- `uploadDirectory()` - رفع المجلد بشكل متكرر  
- `uploadFile()` - رفع ملف واحد  
- `mkdirAll()` - إنشاء دليل بعيد بشكل متكرر  

## الرخصة

رخصة MIT

## المساهمة

نرحب بإرسال القضايا وطلبات السحب (Pull Request)!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---