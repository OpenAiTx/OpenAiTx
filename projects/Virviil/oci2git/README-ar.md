
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![التوثيق](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![الرخصة](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![التنزيلات](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (محاكاة لملف test.yaml مستقبلي)
[//]: # ([![حالة الاختبار]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

تطبيق بلغة Rust يقوم بتحويل صور الحاويات (Docker، وغيرها) إلى مستودعات Git. كل طبقة في الحاوية تمثل كتزامن في Git، مع الحفاظ على السجل والبنية للصورة الأصلية.

![عرض توضيحي لتحويل صورة nginx بواسطة OCI2Git](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## الميزات

- تحليل صور Docker واستخراج معلومات الطبقات
- إنشاء مستودع Git حيث تمثل كل طبقة صورة تزامنًا منفصلاً
- دعم الطبقات الفارغة (ENV، WORKDIR، إلخ) كتزامنات فارغة
- استخراج كامل للبيانات الوصفية بتنسيق Markdown
- بنية قابلة للتوسعة لدعم محركات الحاويات المختلفة

## حالات الاستخدام

### مقارنة الطبقات
عند استكشاف مشاكل الحاويات، يمكنك استخدام قدرات Git القوية للمقارنة لمعرفة التغييرات الدقيقة بين أي طبقتين. باستخدام أمر `git diff` بين التزامين، يمكن للمهندسين رؤية الملفات التي تمت إضافتها أو تعديلها أو حذفها بدقة، مما يسهل فهم أثر كل تعليمة Dockerfile وتحديد التغييرات المسببة للمشاكل.
![مثال لمقارنة الطبقات](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### تتبع الأصل
باستخدام `git blame`، يمكن للمطورين بسرعة تحديد الطبقة التي أدخلت ملفًا معينًا أو سطرًا من الشيفرة. هذا مفيد بشكل خاص عند تشخيص مشاكل ملفات الإعداد أو الاعتمادات. بدلاً من تفقد كل طبقة يدويًا، يمكنك تتبع أصل أي ملف مباشرة إلى الطبقة الأصلية وتعليمة Dockerfile المقابلة.

### تتبع دورة حياة الملفات
تتيح لك أداة OCI2Git متابعة مسار أي ملف عبر تاريخ صورة الحاوية. يمكنك معرفة متى تم إنشاء الملف لأول مرة، وكيف تم تعديله عبر الطبقات، وإذا أو متى تم حذفه في النهاية. توفر هذه الرؤية الشاملة فهماً لتطور الملف دون الحاجة لتعقب التغييرات يدويًا عبر العديد من الطبقات.

لتتبع تاريخ ملف في صورة الحاوية — بما في ذلك وقت ظهوره الأول، أو تغييره، أو حذفه — يمكنك استخدام أوامر Git التالية بعد التحويل:

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
يقوم OCI2Git باكتشاف الطبقات المشتركة بين الصور تلقائيًا وينشئ بنية تفريع تعكس القاعدة المشتركة بينها. سيعرض سجل Git ما يلي:
- جذع مشترك يحتوي على جميع الطبقات المشتركة
- فروع منفصلة تتشعب فقط عندما تختلف الصور فعليًا
- تصور واضح لمواضيع اشتراك الصور في السلالة وأين تصبح فريدة
- معالجة ذكية للتكرار: إذا تمت معالجة نفس الصورة بالضبط مرتين، يكتشف الخوارزمية ذلك قبل الالتزام النهائي للبيانات الوصفية ويتجنب إنشاء فرع مكرر

هذه الطريقة ذات قيمة خاصة من أجل:
- **تحليل عائلة الصور**: فهم كيفية ارتباط المتغيرات المختلفة من صورة (إصدارات مختلفة، معماريات، أو إعدادات) ببعضها البعض
- **تأثير الصورة الأساسية**: رؤية كيف تؤثر التغييرات على الصورة الأساسية بالضبط على صور مشتقة متعددة
- **فرص التحسين**: تحديد المكونات المشتركة التي يمكن الاستفادة منها بشكل أفضل عبر متغيرات الصور

![هيكل مستودع صور متعددة يُظهر قاعدة مشتركة وفروع متشعبة](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### حالات استخدام إضافية

- **تدقيق الأمان**: تحديد اللحظة التي أُدخلت فيها الحزم أو الإعدادات الضعيفة وتتبعها إلى أوامر البناء المحددة.
- **تحسين الصور**: تحليل بنية الطبقات لاكتشاف العمليات المتكررة أو الملفات الكبيرة التي يمكن دمجها، مما يساعد في تقليل حجم الصورة.
- **إدارة التبعيات**: مراقبة متى تمت إضافة التبعيات أو ترقيتها أو إزالتها عبر سجل الصورة.
- **تحسين عملية البناء**: فحص تكوين الطبقات لتحسين أوامر Dockerfile من أجل تخزين مؤقت أفضل وحجم صورة أصغر.
- **المقارنة بين الصور**: تحويل صور متعددة ذات صلة إلى مستودعات Git واستخدام أدوات المقارنة الخاصة بـ Git لتحليل اختلافاتها وقواسمها المشتركة.

## التثبيت

### مدراء الحزم

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### ديبيان / أوبونتو

قم بتنزيل وتثبيت حزمة .deb من [الإصدار الأخير](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### آرش لينكس (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### الثنائيات الجاهزة

قم بتنزيل الثنائي المناسب لمنصتك من [الإصدار الأخير](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### من Crates.io

```bash
cargo install oci2git
```

### من المصدر

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
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
- واجهة أوامر Docker (لدعم محرك Docker)
- Git

## الترخيص

MIT

[التوثيق]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---