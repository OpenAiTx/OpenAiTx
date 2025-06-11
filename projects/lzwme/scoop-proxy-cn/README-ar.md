# 🍡 scoop-proxy-cn

مخزن مرآة وكيل [Scoop](https://scoop.sh) مناسب لمستخدمي الصين القارية. يتم تحديثه ومزامنته من عدة مستودعات `bucket` مفتوحة المصدر. من بينها:

- فرع `sync` (الافتراضي): مزامنة تطبيقات من عدة مستودعات، ولكن بدون تعديل وكيل ghproxy. **مناسب للاستخدام مع نسخة scoop المعدلة محليًا على gitee في الصين**
- فرع `main`: يقوم بتعديل عناوين تنزيل التطبيقات من `github release` إلى عناوين تنزيل عبر وكيل مبني على `https://ghfast.top`. **نظرًا لأن عناوين الوكيل غالبًا ما تتغير بسبب التعطل، فهي غير مستقرة**

## الاستخدام

أضف مستودع تطبيقات `spc`. يُستخدم مع [مكتبة تحسين المرآة Scoop المحلية](https://gitee.com/scoop-installer/scoop):

```bash
# إضافة bucket، يسحب فرع sync افتراضيًا
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# تثبيت التطبيقات
scoop install spc/<app_name>
```

إذا كنت ترغب باستخدام نسخة Scoop الرسمية فقط، يمكنك تعديل فرع الاشتراك إلى فرع `main` كما يلي:

```bash
# انتقل إلى مجلد spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# إذا تم تعيين متغير البيئة SCOOP، فعليك تنفيذ الأمر التالي
cd "$env:SCOOP\buckets\spc"

# التبديل إلى فرع main
git fetch --all
git checkout -b main origin/main
```

## مرجع تثبيت وتكوين Scoop

### الطريقة الأولى: التثبيت باستخدام مرآة مخصصة محلية (موصى به)

نظرًا لأن شفرة المصدر و buckets الخاصة بـ scoop تتم إدارتها بشكل أساسي عبر git في github، فإن صعوبة الوصول إلى github يجعل التثبيت، التحديث، وتنزيل التطبيقات تجربة سيئة جدًا.

فيما يلي طريقة تثبيت [مكتبة تحسين المرآة Scoop المحلية](https://gitee.com/scoop-installer/scoop):

```bash
# تغيير سياسة تنفيذ السكريبتات، الموافقة تلقائيًا افتراضيًا
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# الطريقة الأولى: تنفيذ أمر التثبيت (يتم التثبيت افتراضيًا في مجلد المستخدم، لتغيير الموقع نفذ الأمر "تخصيص مجلد التثبيت" أدناه)
iwr -useb scoop.201704.xyz | iex


## الطريقة الثانية: تخصيص مجلد التثبيت (تأكد من تعديل المسار إلى موقع مناسب)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# إذا كنت قد ثبت المصدر الرسمي من قبل، يمكنك التبديل بالأمر التالي
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# إضافة مستودع spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# تحديث المكتبة الجديدة
scoop update
```

تم تعديل نسخة scoop المثبتة بهذه الطريقة لتدعم تعيين وكيل تنزيل مخصص، وتستخدم افتراضيًا وكيل التنزيل `scoop.201704.xyz`.

```bash
# تعيين الوكيل
scoop config URL_PROXY "https://scoop.201704.xyz"

# إزالة الوكيل
scoop config rm URL_PROXY
```

### الطريقة الثانية: التثبيت من المستودع الرسمي باستخدام وكيل

افتح `PowerShell` ونفذ الأوامر التالية للتثبيت:

```bash
# التثبيت
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# التكوين
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# إضافة مستودع spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# انتقل إلى مجلد spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# التبديل إلى فرع main
git fetch --all && git checkout -b main origin/main

# عرض المساعدة
scoop help

# تثبيت 7zip، aria2، scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### حول `scoop-search`

نظرًا لأن مستودع `scoop-proxy-cn` مزامَن مع أكثر من `1.4w+` تطبيق، فإن أمر `scoop search` الرسمي المبني على `PowerShell` يكون بطيئًا جدًا وغير عملي، لذا يُنصح بتثبيت واستخدام أداة `scoop-search` المطورة بلغة `go` كبديل. مثال:

```bash
scoop install scoop-search
# استخدام scoop-search
scoop-search act
```

## المشكلات الشائعة

### مشكلة فشل التنزيل بسبب `aria2`

عند تثبيت `aria2`، يستخدم scoop `aria2` لتنزيل الأجزاء لتسريع التنزيل. لكن بعض عناوين الوكيل لا تدعم أو تحجب طلبات التنزيل المجزأ من `aria2`. في هذه الحالة يمكن تعطيل `aria2` بالأمر التالي:

```bash
scoop config aria2-enabled false
```

### مشكلة `Hash Check Failed`

بعض التطبيقات مكونة لتنزيل أحدث إصدار مع وجود قيمة hash ثابتة. عند وجود إصدار جديد، يحدث خطأ `Hash Check Failed`. يمكن تخطي هذا الخطأ باستخدام المعامل `-s`. مثال:

```bash
scoop install scoop-search -s
```

### كيفية التعامل مع تعطل الوكيل وحاجة التحديث

عند استخدام نسخة Scoop الرسمية والاشتراك بفرع `main`، يتم استخدام وكيل لتسريع تنزيل مستودعات git والتطبيقات. إذا تعطل الوكيل، فلن يتم تحديث المستودعات. يرجى تنفيذ الأوامر التالية لإعادة الإضافة:

```bash
# تحديث scoop repo أولًا
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# الطريقة الأولى: تحديث مستودع spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# إذا غيرت موقع buckets الافتراضي، استخدم الأمر التالي
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# الطريقة الثانية: إزالة وإعادة إضافة مستودع spc bucket
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## المزامنة من مستودعات

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## التصريح

> [!WARNING]
> يحتوي هذا المستودع على معلومات التطبيقات التي تم مزامنتها فقط من مستودعات الطرف الثالث، ولم يتم التحقق من صلاحية أو أمان كل تطبيق على حدة، يرجى التحقق والتعرف بنفسك عند اختيار التثبيت. إذا كان هناك أي انتهاك، يرجى رفع issues لمعالجته.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---