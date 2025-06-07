<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

أوه ماي زدش (Oh My Zsh) هو إطار عمل مفتوح المصدر تقوده المجتمع لإدارة إعدادات [zsh](https://www.zsh.org/).

يبدو مملاً. دعنا نجرب مرة أخرى.

**أوه ماي زدش لن يجعلك مطورًا أسرع بعشرة أضعاف... لكنك قد تشعر بذلك.**

بمجرد تثبيته، سيصبح موجه الأوامر لديك حديث الجميع _أو استرجع أموالك!_ مع كل نقرة مفتاح في موجه الأوامر، ستستفيد من مئات الإضافات القوية والسمات الجميلة. سيقترب منك الغرباء في المقاهي ويسألونك، _"هذا مذهل! هل أنت عبقري من نوع ما؟"_

أخيرًا، ستبدأ في الحصول على الاهتمام الذي شعرت دومًا أنك تستحقه. ...أو ربما ستستخدم الوقت الذي توفره لتبدأ في تنظيف أسنانك بالخيط أكثر 😬

للتعرف أكثر، زر [ohmyz.sh](https://ohmyz.sh)، وتابع [@ohmyzsh](https://x.com/ohmyzsh) على X (تويتر سابقًا)، وانضم إلينا على [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>جدول المحتويات</summary>

- [البدء](#getting-started)
  - [توافق أنظمة التشغيل](#operating-system-compatibility)
  - [المتطلبات المسبقة](#prerequisites)
  - [التثبيت الأساسي](#basic-installation)
    - [الفحص اليدوي](#manual-inspection)
- [استخدام أوه ماي زدش](#using-oh-my-zsh)
  - [الإضافات](#plugins)
    - [تفعيل الإضافات](#enabling-plugins)
    - [استخدام الإضافات](#using-plugins)
  - [السمات](#themes)
    - [اختيار سمة](#selecting-a-theme)
  - [الأسئلة الشائعة](#faq)
- [مواضيع متقدمة](#advanced-topics)
  - [التثبيت المتقدم](#advanced-installation)
    - [دليل مخصص](#custom-directory)
    - [تثبيت غير مراقب](#unattended-install)
    - [التثبيت من مستودع متشعب](#installing-from-a-forked-repository)
    - [التثبيت اليدوي](#manual-installation)
  - [مشاكل التثبيت](#installation-problems)
  - [إضافات وسمات مخصصة](#custom-plugins-and-themes)
  - [تفعيل GNU ls في أنظمة macOS و freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [تخطي الاختصارات](#skip-aliases)
  - [موجه git غير متزامن](#async-git-prompt)
- [الحصول على التحديثات](#getting-updates)
  - [تفصيل التحديثات](#updates-verbosity)
  - [التحديث اليدوي](#manual-updates)
- [إلغاء تثبيت أوه ماي زدش](#uninstalling-oh-my-zsh)
- [كيف أساهم في أوه ماي زدش؟](#how-do-i-contribute-to-oh-my-zsh)
  - [لا ترسل لنا سمات](#do-not-send-us-themes)
- [المساهمون](#contributors)
- [تابعنا](#follow-us)
- [البضائع](#merchandise)
- [الترخيص](#license)
- [حول Planet Argon](#about-planet-argon)

</details>

## البدء

### توافق أنظمة التشغيل

| نظام التشغيل  | الحالة |
| :------------- | :----: |
| أندرويد        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| لينكس          |   ✅   |
| ماك أو إس      |   ✅   |
| OS/2 Warp      |   ❌   |
| ويندوز (WSL2)  |   ✅   |

### المتطلبات المسبقة

- يجب تثبيت [Zsh](https://www.zsh.org) (الإصدار 4.3.9 أو أحدث جيد، لكن نُفضّل 5.0.8 أو أحدث). إذا لم يكن مثبتًا مسبقًا (نفذ `zsh --version` للتأكد)، راجع تعليمات الويكي هنا: [تثبيت ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- يجب تثبيت `curl` أو `wget`
- يجب تثبيت `git` (ننصح بالإصدار 2.4.11 أو أعلى)

### التثبيت الأساسي

يتم تثبيت أوه ماي زدش بتشغيل أحد الأوامر التالية في الطرفية. يمكنك تثبيته عبر سطر الأوامر باستخدام `curl` أو `wget` أو أداة مشابهة.

| الطريقة   | الأمر                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

بديلًا عن ذلك، يتوفر المثبت أيضًا خارج GitHub. قد تحتاج لاستخدام هذا الرابط إذا كنت في بلد مثل الصين أو الهند (لبعض مزودي الخدمة) الذين يحجبون `raw.githubusercontent.com`:

| الطريقة   | الأمر                                               |
| :-------- | :-------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"`   |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`     |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"`   |

_لاحظ أن أي ملف `.zshrc` سابق سيتم إعادة تسميته إلى `.zshrc.pre-oh-my-zsh`. بعد التثبيت، يمكنك نقل الإعدادات التي ترغب في الحفاظ عليها إلى الملف الجديد `.zshrc`._

#### الفحص اليدوي

من الجيد فحص سكربت التثبيت للمشاريع التي لا تعرفها بعد. يمكنك فعل ذلك بتحميل سكربت التثبيت أولاً، ثم استعراضه والتأكد من أنه طبيعي، ثم تشغيله:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

إذا انتهت صلاحية الرابط أعلاه أو فشل، قد تحتاج إلى استبداله بـ
`https://install.ohmyz.sh` للحصول على السكربت.

## استخدام أوه ماي زدش

### الإضافات

يأتي أوه ماي زدش مع عدد هائل من الإضافات يمكنك الاستفادة منها. يمكنك إلقاء نظرة على مجلد [الإضافات](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) و/أو [الويكي](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) لرؤية ما هو متوفر حاليًا.

#### تفعيل الإضافات

بمجرد تحديد إضافة (أو عدة) ترغب باستخدامها مع أوه ماي زدش، ستحتاج لتفعيلها في ملف `.zshrc`. ستجد هذا الملف في مجلد `$HOME`. افتحه بمحررك المفضل وستجد مكانًا لإدراج جميع الإضافات التي ترغب في تحميلها.

```sh
vi ~/.zshrc
```

على سبيل المثال، قد يبدو الأمر هكذا:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_لاحظ أن الإضافات مفصولة بمسافات (مسافات، تبويبات، أسطر جديدة...). **لا تستخدم الفواصل** بينها وإلا سيتسبب ذلك في خلل._

#### استخدام الإضافات

كل إضافة مدمجة تحتوي على **README** يشرحها. يجب أن يوضح هذا الملف الاختصارات (إن وجدت) والمزايا الإضافية المدمجة في تلك الإضافة.

### السمات

نعترف بذلك، في بداية عالم أوه ماي زدش، ربما بالغنا في حماسنا للسمات. لدينا الآن أكثر من 150 سمة مضمنة. معظمها لديها [لقطات شاشة](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) في الويكي (نعمل على تحديث ذلك!). اطلع عليها!

#### اختيار سمة

_سمة "روبي" هي الافتراضية. ليست الأجمل. ليست الأبسط. إنها فقط الأنسب (له)._

عندما تجد سمة ترغب في استخدامها، ستحتاج لتحرير ملف `~/.zshrc`. ستجد متغير بيئة (أحرف كبيرة) يبدو هكذا:

```sh
ZSH_THEME="robbyrussell"
```

لاستخدام سمة مختلفة، غيّر القيمة لتطابق اسم السمة التي ترغب بها. على سبيل المثال:

```sh
ZSH_THEME="agnoster" # (واحدة من السمات المتقدمة)
# راجع https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!ملاحظة]
> كثيرًا ما سترى لقطات شاشة لسمة zsh وتجربها، وتجد أنها لا تبدو كما رأيتها.
>
> ذلك لأن العديد من السمات تتطلب تثبيت [خط Powerline](https://github.com/powerline/fonts) أو [خط Nerd](https://github.com/ryanoasis/nerd-fonts) لتظهر بشكل صحيح. بدونها، ستظهر رموز غريبة في الموجه. راجع [الأسئلة الشائعة](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) للمزيد.
>
> أيضًا، انتبه أن السمات تتحكم فقط في شكل موجه الأوامر. أي النص الذي تراه قبل أو بعد المؤشر، حيث تكتب أوامرك. السمات لا تتحكم في ألوان نافذة الطرفية (المعروفة بـ _نظام الألوان_) أو خط الطرفية. يمكنك تغيير هذه الإعدادات من برنامج الطرفية لديك. للمزيد، راجع [ما هي سمة zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

افتح نافذة طرفية جديدة ويجب أن يبدو الموجه لديك هكذا:

![سمة Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

إذا لم تجد سمة مناسبة لاحتياجاتك، يرجى مراجعة الويكي للمزيد من [السمات](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

إذا أردت، يمكنك جعل الحاسوب يختار سمة عشوائيًا لك في كل مرة تفتح فيها نافذة طرفية جديدة:

```sh
ZSH_THEME="random" # (...رجاءً فلتكن فطيرة... رجاءً فلتكن فطيرة..)
```

وإذا أردت اختيار سمة عشوائية من قائمة سماتك المفضلة:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

إذا كنت تعرف فقط السمات التي لا ترغب بها، يمكنك إضافتها إلى قائمة التجاهل:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### الأسئلة الشائعة

إذا كان لديك المزيد من الأسئلة أو المشاكل، قد تجد الحل في [الأسئلة الشائعة](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## مواضيع متقدمة

إذا كنت من النوع الذي يحب العمل بيديه، قد تهمك هذه الأقسام.

### التثبيت المتقدم

بعض المستخدمين قد يرغبون في تثبيت أوه ماي زدش يدويًا، أو تغيير المسار الافتراضي أو إعدادات أخرى يقبلها المثبت (هذه الإعدادات موضحة أيضًا في أعلى سكربت التثبيت).

#### دليل مخصص

الموقع الافتراضي هو `~/.oh-my-zsh` (مخفي في مجلد المنزل لديك، يمكنك الوصول إليه عبر `cd ~/.oh-my-zsh`)

إذا رغبت في تغيير دليل التثبيت باستخدام متغير البيئة `ZSH`، إما بتشغيل
`export ZSH=/your/path` قبل التثبيت، أو بتحديده قبل نهاية خط التثبيت هكذا:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### تثبيت غير مراقب

إذا كنت تقوم بتشغيل سكربت تثبيت أوه ماي زدش كجزء من تثبيت آلي، يمكنك تمرير الخيار `--unattended` إلى السكربت `install.sh`. هذا سيمنع محاولة تغيير الصدفة الافتراضية، ولن يشغل `zsh` عند الانتهاء.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

إذا كنت في الصين أو الهند أو دولة أخرى تحجب `raw.githubusercontent.com`، قد تحتاج لاستبدال الرابط بـ `https://install.ohmyz.sh`.

#### التثبيت من مستودع متشعب

يقبل سكربت التثبيت أيضًا هذه المتغيرات لتثبيت مستودع مختلف:

- `REPO` (الافتراضي: `ohmyzsh/ohmyzsh`): يأخذ الشكل `owner/repository`. إذا قمت بتعيينه، سيبحث المثبت عن المستودع على `https://github.com/{owner}/{repository}`.

- `REMOTE` (الافتراضي: `https://github.com/${REPO}.git`): هذا هو عنوان المستودع الكامل. استخدمه إذا أردت التثبيت من تشعيب ليس على GitHub (مثل GitLab أو Bitbucket...) أو إذا أردت الاستنساخ عبر SSH بدلًا من HTTPS (`git@github.com:user/project.git`).

  _ملاحظة: هذا غير متوافق مع تعيين متغير `REPO`. هذا الإعداد له أولوية._

- `BRANCH` (الافتراضي: `master`): يمكنك استخدامه لتغيير الفرع الافتراضي الذي سيتم استنساخه. هذا مفيد لاختبار طلبات السحب، أو إذا أردت فرعًا غير `master`.

مثال:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### التثبيت اليدوي

##### 1. استنساخ المستودع <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _اختياريًا_، نسخ احتياطي لملف `~/.zshrc` الحالي <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. إنشاء ملف إعدادات zsh جديد <!-- omit in toc -->

يمكنك إنشاء ملف إعدادات جديد بنسخ القالب المرفق.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. تغيير الصدفة الافتراضية <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

يجب عليك تسجيل الخروج من الجلسة ثم تسجيل الدخول مجددًا لرؤية التغيير.

##### 5. تهيئة إعدادات zsh الجديدة <!-- omit in toc -->

عند فتح نافذة طرفية جديدة، يجب أن يقوم بتحميل zsh مع إعدادات أوه ماي زدش.

### مشاكل التثبيت

إذا واجهت مشاكل أثناء التثبيت، إليك بعض الحلول الشائعة:

- قد تحتاج لتعديل متغير `PATH` في `~/.zshrc` إذا لم تتمكن من العثور على بعض الأوامر بعد التحويل إلى أوه ماي زدش.
- إذا قمت بالتثبيت يدويًا أو غيرت موقع التثبيت، تحقق من متغير البيئة `ZSH` في `~/.zshrc`.

### إضافات وسمات مخصصة

إذا أردت تجاوز أي من السلوكيات الافتراضية، فقط أضف ملفًا جديدًا (ينتهي بـ .zsh) في مجلد `custom/`.

إذا كان لديك عدة دوال تعمل معًا، يمكنك وضعها كملف `XYZ.plugin.zsh` في مجلد `custom/plugins/` ثم تفعيل هذه الإضافة.

إذا رغبت في تجاوز وظيفة إضافة مدمجة مع أوه ماي زدش، أنشئ إضافة بنفس الاسم في مجلد `custom/plugins/` وسيتم تحميلها بدلًا من الموجودة في `plugins/`.

### تفعيل GNU ls في أنظمة macOS و freeBSD

<a name="enable-gnu-ls"></a>

السلوك الافتراضي في أوه ماي زدش هو استخدام BSD `ls` في أنظمة macOS وFreeBSD. إذا كان GNU `ls` مثبتًا (كأمر `gls`)، يمكنك اختياره بدلًا منه. للقيام بذلك، يمكنك استخدام إعداد zstyle قبل استيراد `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_ملاحظة: هذا غير متوافق مع `DISABLE_LS_COLORS=true`_

### تخطي الاختصارات

<a name="remove-directories-aliases"></a>

إذا كنت تريد تخطي اختصارات أوه ماي زدش الافتراضية (المحددة في ملفات `lib/*`) أو اختصارات الإضافات، يمكنك استخدام الإعدادات أدناه في ملف `~/.zshrc`، **قبل تحميل أوه ماي زدش**. لاحظ أن هناك طرقًا مختلفة لتخطي الاختصارات حسب الحاجة.

```sh
# تخطي جميع الاختصارات، في ملفات lib والإضافات المفعلة
zstyle ':omz:*' aliases no

# تخطي جميع الاختصارات في ملفات lib
zstyle ':omz:lib:*' aliases no
# تخطي اختصارات ملف directories.zsh فقط
zstyle ':omz:lib:directories' aliases no

# تخطي جميع اختصارات الإضافات
zstyle ':omz:plugins:*' aliases no
# تخطي اختصارات إضافة git فقط
zstyle ':omz:plugins:git' aliases no
```

يمكنك الجمع بينها مع مراعاة أن النطاقات الأكثر تحديدًا لها أولوية:

```sh
# تخطي جميع اختصارات الإضافات، باستثناء إضافة git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

كان إصدار سابق من هذه الميزة يستخدم الإعداد أدناه، الذي تم حذفه:

```sh
zstyle ':omz:directories' aliases no
```

بدلًا من ذلك، يمكنك الآن استخدام التالي:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### ملاحظة <!-- omit in toc -->

> هذه الميزة حاليًا في مرحلة اختبار وقد تتغير في المستقبل. كما أنها غير متوافقة حاليًا مع مديري الإضافات مثل zpm أو zinit، الذين لا يقومون باستيراد السكربت التمهيدي (`oh-my-zsh.sh`) حيث تم تنفيذ هذه الميزة.

> كما أنها غير قادرة حاليًا على التعرف على "الاختصارات" المعرفة كدوال. مثل دوال `gccd`، `ggf`، أو `ggl` في إضافة git.

### موجه git غير متزامن

دوال الموجه غير المتزامنة هي ميزة تجريبية (أضيفت في 3 أبريل 2024) تسمح لأوه ماي زدش بعرض معلومات الموجه بشكل غير متزامن. هذا يمكن أن يحسن أداء عرض الموجه، لكنه قد لا يعمل جيدًا مع بعض الإعدادات. إذا ظهرت لديك مشاكل مع هذه الميزة الجديدة، يمكنك إيقافها بوضع السطر التالي في ملف .zshrc قبل تحميل أوه ماي زدش:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

إذا كانت مشكلتك أن موجه git توقف عن الظهور، يمكنك محاولة إجباره بإعداد التالي قبل استيراد `oh-my-zsh.sh`. إذا لم يعمل، يرجى فتح تذكرة بالمشكلة.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## الحصول على التحديثات

بشكل افتراضي، سيتم سؤالك عن وجود تحديثات كل أسبوعين. يمكنك اختيار وضع تحديث آخر بوضع سطر في ملف `~/.zshrc`، **قبل تحميل أوه ماي زدش**:

1. تحديث تلقائي بدون طلب تأكيد:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. فقط تذكير كل بضعة أيام إذا توفرت تحديثات:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. لتعطيل التحديثات التلقائية تمامًا:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

ملاحظة: يمكنك التحكم في تكرار فحص التحديثات عبر الإعداد التالي:

```sh
# هذا سيفحص التحديثات كل 7 أيام
zstyle ':omz:update' frequency 7
# هذا سيفحص التحديثات في كل مرة تفتح فيها الطرفية (غير مستحسن)
zstyle ':omz:update' frequency 0
```

### تفصيل التحديثات

يمكنك أيضًا تحديد مستوى تفاصيل التحديث عبر الإعدادات التالية:

```sh
zstyle ':omz:update' verbose default # موجه التحديث الافتراضي

zstyle ':omz:update' verbose minimal # فقط بعض الأسطر

zstyle ':omz:update' verbose silent # فقط الأخطاء
```

### التحديث اليدوي

إذا أردت التحديث في أي وقت (ربما تم إصدار إضافة جديدة ولا ترغب في الانتظار؟) فقط نفذ:

```sh
omz update
```

> [!ملاحظة]
> إذا أردت أتمتة هذه العملية في سكربت، يجب عليك استدعاء سكربت `upgrade` مباشرة، هكذا:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> راجع المزيد من الخيارات في [الأسئلة الشائعة: كيف أقوم بتحديث أوه ماي زدش؟](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **تمت إزالة استخدام `omz update --unattended` نظرًا لآثاره الجانبية**.

سحر! 🎉

## إلغاء تثبيت أوه ماي زدش

أوه ماي زدش ليس للجميع. سنفتقدك، لكننا نريد أن نجعل هذا الانفصال سهلًا.

إذا أردت إزالة تثبيت `oh-my-zsh`، فقط نفذ الأمر `uninstall_oh_my_zsh` من سطر الأوامر. سيزيل نفسه ويعيد إعدادات `bash` أو `zsh` السابقة.

## كيف أساهم في أوه ماي زدش؟

قبل أن تشارك في مجتمعنا الرائع، يرجى قراءة [مدونة قواعد السلوك](CODE_OF_CONDUCT.md).

أنا لست خبيرًا في [Zsh](https://www.zsh.org/) وأعتقد أن هناك الكثير من الطرق للتحسين – إذا كانت لديك أفكار لجعل الإعدادات أسهل في الصيانة (وأسرع)، لا تتردد في عمل fork وإرسال pull request!

نحتاج أيضًا لأشخاص لتجربة طلبات السحب. ألق نظرة على [المشاكل المفتوحة](https://github.com/ohmyzsh/ohmyzsh/issues) وساعد حيثما تستطيع.

راجع [المساهمة](CONTRIBUTING.md) للمزيد من التفاصيل.

### لا ترسل لنا سمات

لدينا (أكثر من) ما يكفي من السمات في الوقت الحالي. يرجى إضافة سمتك إلى صفحة [السمات الخارجية](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) في الويكي.

## المساهمون

أوه ماي زدش لديه مجتمع نشط من المستخدمين السعداء والمساهمين الرائعين. بدون وقت وجهود المساهمين، لما كان بهذا الروعة.

شكرًا جزيلًا لكم!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## تابعنا

نحن على وسائل التواصل الاجتماعي:

- [@ohmyzsh](https://x.com/ohmyzsh) على X (تويتر سابقًا). يجب أن تتابعنا.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) تواصل معنا.
- [Instagram](https://www.instagram.com/_ohmyzsh/) ضع وسم لنا في منشوراتك التي تظهر فيها أوه ماي زدش!
- [Discord](https://discord.gg/ohmyzsh) للدردشة معنا!

## البضائع

لدينا [ملصقات، قمصان، وأكواب قهوة متوفرة](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) لتظهر مدى حبك لأوه ماي زدش. مرة أخرى، ستصبح حديث الجميع!

## الترخيص

أوه ماي زدش متوفر بموجب [رخصة MIT](LICENSE.txt).

## حول Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

بدأ أوه ماي زدش بواسطة فريق [Planet Argon](https://www.planetargon.com/?utm_source=github)، [وكالة تطوير Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). اطلع على [مشاريعنا مفتوحة المصدر الأخرى](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---