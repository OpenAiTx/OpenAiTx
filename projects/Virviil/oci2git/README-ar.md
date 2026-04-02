
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

[//]: # (محاكاة لاختبار test.yaml مستقبلاً)
[//]: # ([![حالة الاختبار]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

تطبيق بلغة Rust يقوم بتحويل صور الحاويات (Docker، وغيرها) إلى مستودعات Git، وينتج فاتورة مواد نظام الملفات (fsbom) بصيغة YAML. كل طبقة من طبقات الحاوية تمثل كتزامن (commit) في Git، مع الحفاظ على تاريخ وهيكل الصورة الأصلية.

![عرض توضيحي لـ OCI2Git أثناء تحويل صورة nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## الميزات

- تحليل صور Docker واستخراج معلومات الطبقات
- إنشاء مستودع Git بحيث تمثل كل طبقة من الصورة تزامناً منفصلاً
- توليد فاتورة مواد نظام الملفات (fsbom) بصيغة YAML مع قائمة ملفات لكل طبقة
- دعم الطبقات الفارغة (ENV, WORKDIR, وغيرها) كعمليات تزامن فارغة
- استخراج بيانات التعريف بالكامل إلى صيغة Markdown
- بنية قابلة للتوسعة لدعم محركات الحاويات المختلفة

## حالات الاستخدام

### مقارنة الطبقات
عند استكشاف مشكلات الحاويات، يمكنك الاستفادة من قدرات مقارنة Git القوية لتحديد التغييرات بين أي طبقتين. عبر تنفيذ أمر `git diff` بين التزامين، يمكن للمهندسين معرفة الملفات التي تمت إضافتها أو تعديلها أو حذفها بدقة، مما يسهل فهم تأثير كل تعليمة Dockerfile وتحديد التغييرات المسببة للمشاكل.
![مثال لمقارنة الطبقات](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### تتبع الأصل
باستخدام أمر `git blame`، يمكن للمطورين بسرعة معرفة الطبقة التي أدخلت ملفاً أو سطراً معيناً من الشيفرة. هذا مفيد جداً عند تشخيص مشاكل ملفات الإعدادات أو الاعتمادات. بدلاً من فحص كل طبقة يدوياً، يمكنك تتبع أصل أي ملف مباشرةً إلى طبقته الأصلية وتعليمة Dockerfile المقابلة.

### تتبع دورة حياة الملفات
يتيح لك OCI2Git تتبع مسار ملف محدد خلال تاريخ صورة الحاوية. يمكنك ملاحظة متى تم إنشاء الملف لأول مرة، وكيف تم تعديله عبر الطبقات، وإذا/متى تمت إزالته في النهاية. هذه الرؤية الشاملة تساعد على فهم تطور الملف دون الحاجة لتتبع التغييرات يدوياً عبر العديد من الطبقات.

لتتبع تاريخ ملف في صورة الحاوية الخاصة بك — بما في ذلك متى ظهر لأول مرة أو تم تعديله أو حذفه — يمكنك استخدام أوامر Git التالية بعد التحويل:

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

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — صورة OCI → مستودع Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

خيارات:
  `-o, --output <OUTPUT>`  دليل الإخراج لمستودع Git [الافتراضي: ./container_repo]
  `-e, --engine <ENGINE>`  محرك الحاوية المراد استخدامه (docker، nerdctl، tar) [الافتراضي: docker]
  `-v, --verbose`          وضع الإيضاح (-v للمعلومات، -vv للتصحيح، -vvv للتتبع)

### `fsbom` — قائمة المواد لنظام الملفات

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
الخيارات:
  `-o, --output <OUTPUT>`  مسار إخراج ملف BOM بصيغة YAML [القيمة الافتراضية: ./fsbom.yml]
  `-e, --engine <ENGINE>`  محرك الحاويات المستخدم (docker, nerdctl, tar) [القيمة الافتراضية: docker]
  `-v, --verbose`          وضع الإيضاح (-v للمعلومات، -vv للتنقيح، -vvv للتتبع)

متغيرات البيئة:
  `TMPDIR`  ضبط متغير البيئة هذا لتغيير الموقع الافتراضي المستخدم لمعالجة البيانات الوسيطة. هذا يعتمد على النظام الأساسي (مثلاً، `TMPDIR` على Unix/macOS، و`TEMP` أو `TMP` على Windows).

## أمثلة

### التحويل

باستخدام محرك Docker (الافتراضي):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

استخدام أرشيف صورة تم تنزيله مسبقًا:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
يتوقع محرك tar ملف tarball صالح بتنسيق OCI، والذي يتم إنشاؤه عادةً باستخدام الأمر `docker save`:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

سيؤدي ذلك إلى إنشاء مستودع Git في `./ubuntu-repo` يحتوي على:
- `Image.md` - بيانات وصفية كاملة حول الصورة بتنسيق Markdown
- `rootfs/` - محتوى نظام الملفات من الحاوية

يعكس سجل Git تاريخ طبقات الحاوية:
- تحتوي أول عملية إدخال على ملف `Image.md` فقط مع جميع البيانات الوصفية
- تمثل كل عملية إدخال لاحقة طبقة من الصورة الأصلية
- تتضمن عمليات الإدخال أمر Dockerfile كرسالة الإدخال

### قائمة مكونات نظام الملفات (fsbom)

توليد ملف YAML يسرد كل ملف تم إدخاله أو تعديله في كل طبقة:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

استخدام ملف tarball:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

يُدرج ملف YAML الناتج كل طبقة مع إدخالاتها المميزة حسب النوع (`file`، `hardlink`، `symlink`، `directory`) والحالة (`n:uid:gid` للجديدة، `m:uid:gid` للمعدلة). الملفات المحذوفة (OCI whiteouts) مستثناة.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---