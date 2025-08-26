
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

تطبيق Rust يقوم بتحويل صور الحاويات (Docker وغيرها) إلى مستودعات Git. يتم تمثيل كل طبقة من الحاوية على هيئة عملية Git commit، مع الحفاظ على تاريخ وبنية الصورة الأصلية.

![عرض توضيحي لتحويل صورة nginx باستخدام OCI2Git](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## الميزات

- تحليل صور Docker واستخراج معلومات الطبقات
- إنشاء مستودع Git حيث يتم تمثيل كل طبقة صورة كعملية إيداع (commit)
- دعم الطبقات الفارغة (مثل ENV، WORKDIR، إلخ) كعمليات إيداع فارغة
- استخراج كامل للبيانات التعريفية بصيغة Markdown
- بنية قابلة للتوسعة لدعم محركات الحاويات المختلفة

## حالات الاستخدام

### مقارنة الطبقات (Layer Diffing)
عند استكشاف مشكلات الحاويات، يمكنك استخدام إمكانيات Git القوية للمقارنة لتحديد ما الذي تغير بالضبط بين أي طبقتين. من خلال تشغيل `git diff` بين عمليات الإيداع، يمكن للمهندسين رؤية الملفات التي أضيفت أو عُدلت أو حُذفت بدقة، مما يجعل من السهل فهم تأثير كل تعليمة في Dockerfile وتحديد التغييرات المسببة للمشكلات.
![مثال لمقارنة الطبقات](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### تتبع المصدر (Origin Tracking)
باستخدام `git blame`، يمكن للمطورين تحديد الطبقة التي أدخلت ملفًا أو سطرًا معينًا بسرعة. هذا مفيد بشكل خاص عند تشخيص المشكلات في ملفات التكوين أو التبعيات. بدلاً من فحص كل طبقة يدويًا، يمكنك تتبع مصدر أي ملف مباشرة إلى طبقة المصدر وتعليمة Dockerfile المقابلة.

### تتبع دورة حياة الملف (File Lifecycle Tracking)
تتيح لك OCI2Git متابعة رحلة ملف معين خلال تاريخ صورة الحاوية. يمكنك ملاحظة متى تم إنشاء الملف لأول مرة، وكيف تم تعديله عبر الطبقات، وإذا / ومتى تم حذفه نهائيًا. يوفر هذا العرض الشامل فهمًا لتطور الملف دون الحاجة إلى تتبع التغييرات يدويًا عبر العديد من الطبقات.

لتتبع تاريخ ملف في صورة الحاوية الخاصة بك — بما في ذلك متى ظهر لأول مرة، أو تم تغييره، أو حذفه — يمكنك استخدام أوامر Git التالية بعد التحويل:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
تجعل هذه الأوامر من السهل تتبع التاريخ الكامل لأي ملف عبر طبقات الحاوية دون تعقيد استخراج ومقارنة ملفات tar للطبقات يدويًا.

### التحليل متعدد الطبقات
في بعض الأحيان تأتي المقارنات الأكثر إفادة من فحص التغييرات عبر عدة طبقات غير متتالية. باستخدام OCI2Git، يمكنك الاستفادة من أدوات المقارنة في Git لتحليل كيفية تطور المكونات عبر مراحل بناء متعددة، واكتشاف الأنماط التي قد تكون غير مرئية عند النظر فقط إلى الطبقات المتجاورة.

### استكشاف الطبقات
من خلال استخدام أمر `git checkout` للانتقال إلى أي التزام محدد، يمكنك فحص نظام ملفات الحاوية تمامًا كما كان موجودًا في تلك الطبقة. يتيح ذلك للمطورين استكشاف الحالة الدقيقة للملفات والمجلدات في أي نقطة من عملية إنشاء الصورة، مما يوفر سياقًا لا يقدر بثمن عند تصحيح الأخطاء أو فحص سلوك الحاوية.
![الانتقال إلى التزام سابق](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### التحليل متعدد الصور

عند العمل مع عدة صور حاوية تشترك في أصل مشترك، يقوم OCI2Git بإنشاء الفروع بشكل ذكي فقط عندما تتباعد الصور فعليًا. يتيح لك ذلك تحليل عدة صور ذات صلة في مستودع واحد مع الحفاظ على تاريخها المشترك.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

يقوم OCI2Git بالكشف تلقائيًا عن الطبقات المشتركة بين الصور وينشئ هيكل تفرع يعكس الأساس المشترك بينها. سيُظهر سجل Git ما يلي:
- جذع مشترك يحتوي على جميع الطبقات المشتركة
- فروع منفصلة تتباعد فقط عندما تختلف الصور فعليًا
- تصور واضح لمكان اشتراك الصور في السلف المشترك مقابل مكان تفردها
- معالجة ذكية للتكرار: إذا تم معالجة نفس الصورة تمامًا مرتين، يكتشف الخوارزم ذلك قبل التزام البيانات الوصفية النهائي ويتخطى إنشاء فرع مكرر

هذا النهج ذو قيمة خاصة لـ:
- **تحليل عائلة الصور**: فهم كيفية ارتباط المتغيرات المختلفة لصورة (إصدارات، معماريات، أو إعدادات مختلفة) ببعضها البعض
- **تأثير الصورة الأساسية**: رؤية كيف تؤثر التغييرات على صورة أساسية في صور مشتقة متعددة
- **فرص تحسين**: تحديد المكونات المشتركة التي يمكن الاستفادة منها بشكل أفضل عبر متغيرات الصور

![هيكل مستودع متعدد الصور يُظهر الأساس المشترك والفروع المتباعدة](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### حالات استخدام إضافية

- **تدقيق الأمان**: تحديد بالضبط متى تم إدخال الحزم أو الإعدادات المعرضة للخطر وتتبعها إلى تعليمات البناء المحددة.
- **تحسين الصور**: تحليل هياكل الطبقات للعثور على العمليات أو الملفات الكبيرة المكررة التي يمكن دمجها، مما يساعد في تقليل حجم الصورة.
- **إدارة الاعتماديات**: مراقبة متى تمت إضافة أو ترقية أو إزالة الاعتماديات عبر سجل الصورة.
- **تحسين عملية البناء**: فحص تركيب الطبقات لتحسين تعليمات Dockerfile لتحقيق تخزين مؤقت أفضل وحجم صورة أصغر.
- **مقارنة الصور المتقاطعة**: تحويل عدة صور ذات صلة إلى مستودعات Git واستخدام أدوات المقارنة في Git لتحليل اختلافاتها وقواسمها المشتركة.

## التثبيت

### من المصدر

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### من Crates.io

```bash
cargo install oci2git
```

## الاستخدام

```bash
oci2git [OPTIONS] <IMAGE>
```

المعطيات:
  `<IMAGE>`  اسم الصورة المراد تحويلها (مثال: 'ubuntu:latest') أو مسار ملف tar عند استخدام محرك tar

الخيارات:
  `-o, --output <o>`  دليل الإخراج لمستودع Git [القيمة الافتراضية: ./container_repo]
  `-e, --engine <ENGINE>`  محرك الحاوية المراد استخدامه (docker، nerdctl، tar) [القيمة الافتراضية: docker]
  `-h, --help`            طباعة معلومات المساعدة
  `-V, --version`         طباعة معلومات الإصدار

متغيرات البيئة:
  `TMPDIR`  قم بتعيين هذا المتغير البيئي لتغيير الموقع الافتراضي المستخدم لمعالجة البيانات الوسيطة. هذا يعتمد على نظام التشغيل (مثال: `TMPDIR` على Unix/macOS، أو `TEMP` أو `TMP` على Windows).

## أمثلة

استخدام محرك Docker (افتراضي):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

استخدام أرشيف صورة تم تنزيله مسبقًا:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
يتوقع محرك tar ملف tarball صالح بتنسيق OCI، والذي يتم إنشاؤه عادةً باستخدام الأمر `docker save`:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

سيؤدي هذا إلى إنشاء مستودع Git في `./ubuntu-repo` يحتوي على:
- `Image.md` - بيانات وصفية كاملة عن الصورة بتنسيق Markdown
- `rootfs/` - محتوى نظام الملفات من الحاوية

يعكس سجل Git تاريخ طبقات الحاوية:
- يحتوي الالتزام الأول فقط على ملف `Image.md` مع جميع البيانات الوصفية
- يمثل كل التزام لاحق طبقة من الصورة الأصلية
- تتضمن الالتزامات أمر Dockerfile كرسالة الالتزام

## هيكل المستودع

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## المتطلبات

- إصدار Rust 2021
- واجهة Docker CLI (لدعم محرك Docker)
- Git

## الترخيص

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---