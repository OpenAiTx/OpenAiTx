# جيتليكس

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: ./LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### انضم إلى Discord الخاص بنا! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

جيتليكس هو أداة **لاكتشاف** الأسرار مثل كلمات المرور، ومفاتيح API، والتوكنات في مستودعات جيت، والملفات، وأي شيء آخر ترغب في فحصه عبر `stdin`. إذا أردت معرفة المزيد عن كيفية عمل محرك الاكتشاف، اطلع على هذه التدوينة: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


العنصر المكتشف:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
السر:      cafebabe:deadbeef
معرف القاعدة:      sidekiq-secret
الانتروبي:     2.609850
الملف:        cmd/generate/config/rules/sidekiq.go
السطر:        23
الالتزام:      cd5226711335c68be1e720b318b7bc3135a30eb2
المؤلف:      John
البريد الإلكتروني:       john@users.noreply.github.com
التاريخ:        2022-08-03T12:31:40Z
بصمة الإصبع: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## البدء

يمكن تثبيت جيتليكس باستخدام Homebrew أو Docker أو Go. كما يتوفر جيتليكس أيضًا كملف تنفيذي للعديد من المنصات وأنواع أنظمة التشغيل الشائعة على [صفحة الإصدارات](https://github.com/gitleaks/gitleaks/releases). بالإضافة إلى ذلك، يمكن تنفيذ جيتليكس كخطاف pre-commit مباشرة في مستودعك أو كإجراء على GitHub باستخدام [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### التثبيت

```bash
# ماك أو إس
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# من المصدر (تأكد أن go مثبت)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### إجراء GitHub

اطلع على [إجراء GitHub الرسمي لجيتليكس](https://github.com/gitleaks/gitleaks-action)

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # مطلوب فقط للمؤسسات، وليس للحسابات الشخصية.
```

### Pre-Commit

1. قم بتثبيت pre-commit من https://pre-commit.com/#install
2. أنشئ ملف `.pre-commit-config.yaml` في جذر مستودعك بالمحتوى التالي:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   للتنفيذ [الافتراضي لجيتليكس](https://github.com/gitleaks/gitleaks/releases) أو استخدم [معرّف pre-commit الخاص بـ `gitleaks-docker`](https://github.com/gitleaks/gitleaks/blob/master/.pre-commit-hooks.yaml) لتنفيذ جيتليكس باستخدام [صور Docker الرسمية](#docker)

3. حدّث الإعداد تلقائيًا إلى أحدث إصدارات المستودعات عبر تنفيذ `pre-commit autoupdate`
4. ثبّت عبر `pre-commit install`
5. الآن أنت جاهز!

```
➜ git commit -m "this commit contains a secret"
كشف أسرار مضمّنة في الشيفرة.................................................فشل
```

ملاحظة: لتعطيل خطاف pre-commit الخاص بجيتليكس يمكنك إضافة `SKIP=gitleaks` قبل أمر الالتزام
وسيتم تخطي تشغيل جيتليكس

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
كشف أسرار مضمّنة في الشيفرة................................................تخطي
```

## الاستخدام

```
الاستخدام:
  gitleaks [الأمر]

الأوامر المتاحة:
  dir         فحص الأدلة أو الملفات بحثًا عن الأسرار
  git         فحص مستودعات git بحثًا عن الأسرار
  help        المساعدة حول أي أمر
  stdin       اكتشاف الأسرار من stdin
  version     عرض إصدار جيتليكس

الخيارات:
  -b, --baseline-path string          مسار baseline مع المشاكل التي يمكن تجاهلها
  -c, --config string                 مسار ملف الإعدادات
                                      ترتيب الأولوية:
                                      1. --config/-c
                                      2. متغير البيئة GITLEAKS_CONFIG
                                      3. متغير البيئة GITLEAKS_CONFIG_TOML مع محتوى الملف
                                      4. (المسار المستهدف)/.gitleaks.toml
                                      إذا لم يتم استخدام أي من الخيارات الأربعة، سيستخدم جيتليكس الإعداد الافتراضي
      --diagnostics string            تفعيل التشخيصات (قائمة مفصولة بفواصل: cpu,mem,trace). cpu=تحليل أداء المعالج، mem=تحليل الذاكرة، trace=تتبع التنفيذ
      --diagnostics-dir string        الدليل لحفظ ملفات مخرجات التشخيص (افتراضي الدليل الحالي)
      --enable-rule strings           تفعيل قواعد محددة فقط حسب المعرف
      --exit-code int                 كود الخروج عند وجود تسريبات (الافتراضي 1)
  -i, --gitleaks-ignore-path string   مسار ملف .gitleaksignore أو مجلد يحتوي عليه (افتراضي ".")
  -h, --help                          المساعدة لجيتليكس
      --ignore-gitleaks-allow         تجاهل التعليقات gitleaks:allow
  -l, --log-level string              مستوى السجل (trace, debug, info, warn, error, fatal) (افتراضي "info")
      --max-decode-depth int          السماح بفك التشفير المتكرر حتى هذا العمق (الافتراضي "0"، لا يتم فك التشفير)
      --max-archive-depth int         السماح بالفحص داخل الأرشيفات المتداخلة حتى هذا العمق (الافتراضي "0"، لا يتم استعراض الأرشيفات)
      --max-target-megabytes int      سيتم تخطي الملفات التي تزيد عن هذا الحجم
      --no-banner                     إخفاء الشعار
      --no-color                      تعطيل الألوان في المخرجات التفصيلية
      --redact uint[=100]             إخفاء الأسرار من السجلات وstdout. لإخفاء جزء فقط من السر استخدم نسبة مئوية من 0..100. على سبيل المثال --redact=20 (افتراضي 100%)
  -f, --report-format string          تنسيق الإخراج (json, csv, junit, sarif, template)
  -r, --report-path string            ملف التقرير
      --report-template string        ملف القالب المستخدم لإنشاء التقرير (يفترض --report-format=template)
  -v, --verbose                       عرض مخرجات تفصيلية من الفحص
      --version                       إصدار جيتليكس

استخدم "gitleaks [الأمر] --help" لمزيد من المعلومات حول أي أمر.
```

### الأوامر

⚠️ الإصدار v8.19.0 قدّم تغييرًا أدى إلى إهمال أوامر `detect` و`protect`. هذه الأوامر ما زالت متاحة ولكنها
مخفية من قائمة `--help`. اطلع على هذا [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) لترجمة الأوامر بسهولة.
إذا وجدت أن الإصدار v8.19.0 عطّل أمرًا موجودًا (`detect`/`protect`)، يرجى فتح تذكرة.

هناك ثلاثة أوضاع للفحص: `git`، `dir`، و`stdin`.

#### Git

يتيح لك أمر `git` فحص مستودعات git المحلية. في الخلفية، يستخدم جيتليكس أمر `git log -p` لفحص التصحيحات.
يمكنك ضبط سلوك `git log -p` باستخدام خيار `log-opts`.
على سبيل المثال، إذا أردت تشغيل جيتليكس على نطاق من الالتزامات يمكنك استخدام الأمر التالي:
`gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. راجع [توثيق git log](https://git-scm.com/docs/git-log) لمزيد من المعلومات.
إذا لم يتم تحديد هدف كوسيط موضعي، سيحاول جيتليكس فحص الدليل الحالي كمستودع git.
#### Dir

يتيح لك أمر `dir` (الأسماء المستعارة تشمل `files`, `directory`) فحص الأدلة والملفات. مثال: `gitleaks dir -v path_to_directory_or_file`.
إذا لم يتم تحديد هدف كوسيط موضعي، فسيقوم gitleaks بفحص دليل العمل الحالي.

#### Stdin

يمكنك أيضًا بث البيانات إلى gitleaks باستخدام أمر `stdin`. مثال: `cat some_file | gitleaks -v stdin`

### إنشاء خط أساس

عند فحص مستودعات كبيرة أو مستودعات ذات تاريخ طويل، قد يكون من المناسب استخدام خط أساس. عند استخدام خط الأساس،
سيتجاهل gitleaks أي نتائج قديمة موجودة في خط الأساس. يمكن أن يكون خط الأساس أي تقرير من gitleaks. لإنشاء تقرير gitleaks، قم بتشغيل gitleaks مع معامل `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # سيؤدي هذا إلى حفظ التقرير في ملف يسمى gitleaks-report.json
```

بمجرد إنشاء خط الأساس يمكن تطبيقه عند تشغيل أمر الكشف مرة أخرى:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

بعد تشغيل أمر الكشف مع معامل --baseline-path، سيحتوي إخراج التقرير (findings.json) فقط على المشكلات الجديدة.

## خطاف ما قبل الالتزام (Pre-Commit hook)

يمكنك تشغيل Gitleaks كخطاف ما قبل الالتزام عن طريق نسخ سكريبت `pre-commit.py` المثال إلى
دليل `.git/hooks/` الخاص بك.

## تحميل التكوين

ترتيب الأولوية هو:

1. خيار `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. متغير البيئة `GITLEAKS_CONFIG` مع مسار الملف:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. متغير البيئة `GITLEAKS_CONFIG_TOML` مع محتوى الملف:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. ملف `.gitleaks.toml` ضمن مسار الهدف:
      ```bash
      gitleaks git .
      ```

إذا لم يتم استخدام أي من الخيارات الأربعة، سيستخدم gitleaks التكوين الافتراضي.

## التكوين

يقدم Gitleaks تنسيق تكوين يمكنك اتباعه لكتابة قواعد كشف الأسرار الخاصة بك:

```toml
# عنوان ملف تكوين gitleaks.
title = "تكوين Gitleaks مخصص"

# لديك خياران أساسياً لتكوينك المخصص:
#
# 1. تحديد تكوينك الخاص، لن يتم تطبيق القواعد الافتراضية
#
#    استخدم مثلاً التكوين الافتراضي كنقطة بداية:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. تمديد تكوين، حيث يتم تجاوز أو توسيع القواعد
#
#    عند تمديد التكوين، تكون القواعد الممتدة لها أولوية على القواعد الافتراضية. أي إذا كانت هناك قواعد مكررة في كل من التكوين الممتد
#    والتكوين الافتراضي، سيتم تجاوز القواعد أو سماتها في التكوين الممتد القواعد الافتراضية.
#    أمر آخر يجب معرفته عند تمديد التكوينات هو أنه يمكنك ربط عدة ملفات تكوين معًا حتى عمق 2. يتم إلحاق مصفوفات allowlist ويمكن أن تحتوي على مكررات.

# لا يمكن استخدام useDefault و path في نفس الوقت. اختر واحداً.
[extend]
# useDefault سيقوم بتمديد تكوين gitleaks الافتراضي المدمج في الملف التنفيذي
# أحدث إصدار موجود على:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# أو يمكنك توفير مسار إلى تكوين للتمديد منه.
# المسار نسبي إلى المكان الذي تم فيه استدعاء gitleaks،
# وليس موقع التكوين الأساسي.
# path = "common_config.toml"
# إذا كانت هناك أي قواعد لا ترغب في وراثتها، يمكن تحديدها هنا.
disabledRules = [ "generic-api-key"]

# مصفوفة من الجداول تحتوي على معلومات تحدد التعليمات
# حول كيفية كشف الأسرار
[[rules]]
# معرف فريد لهذه القاعدة
id = "awesome-rule-1"

# وصف قصير قابل للقراءة البشرية للقاعدة.
description = "awesome rule 1"

# تعبير منتظم بلغة Golang يُستخدم لاكتشاف الأسرار. لاحظ أن محرك regex في Golang
# لا يدعم lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# عدد صحيح يُستخدم لاستخلاص السر من نتيجة regex ويُستخدم كمجموعة سيتم التحقق من
# عشوائيتها إذا تم تعيين `entropy`.
secretGroup = 3

# عدد عشري يمثل الحد الأدنى لعشوائية شانون التي يجب أن تمتلكها مجموعة regex ليتم اعتبارها سرًا.
entropy = 3.5

# تعبير منتظم بلغة Golang يُستخدم لمطابقة المسارات. يمكن استخدامه كقاعدة قائمة بذاتها أو يمكن استخدامه
# بالاقتران مع إدخال `regex` صالح.
path = '''a-file-path-regex'''

# تُستخدم الكلمات المفتاحية لتصفية ما قبل التحقق من regex. القواعد التي تحتوي على
# كلمات مفتاحية ستجري تحقق مقارنة سريعة للتأكد من أن
# الكلمة/الكلمات موجودة في المحتوى الذي يتم فحصه. من المثالي أن تكون هذه القيم
# جزءاً من المعرّف أو سلاسل فريدة محددة لـ regex الخاص بالقاعدة
# (تم تقديمها في v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# مصفوفة من السلاسل تُستخدم لأغراض البيانات الوصفية والتقارير.
tags = ["tag","another tag"]

    # ⚠️ في الإصدار v8.21.0 تم استبدال `[rules.allowlist]` بـ `[[rules.allowlists]]`.
    # كان هذا التغيير متوافقاً مع الإصدارات السابقة: لا تزال حالات `[rules.allowlist]` تعمل.
    #
    # يمكنك تعريف عدة قوائم سماح لقاعدة لتقليل الإيجابيات الكاذبة.
    # سيتم تجاهل النتيجة إذا تطابقت _أي_ من `[[rules.allowlists]]`.
    [[rules.allowlists]]
    description = "تجاهل الالتزام A"
    # عند تعريف عدة معايير، يكون الشرط الافتراضي هو "OR".
    # مثلاً، يمكن أن يتطابق هذا مع |commits| أو |paths| أو |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # ملاحظة: stopwords تستهدف السر المستخرج، وليس كامل نتيجة regex
    # كما تفعل 'regexes'. (تم تقديم stopwords في 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # يمكن استخدام شرط "AND" للتأكد من تطابق جميع المعايير.
    # مثلاً، يتطابق هذا إذا تم استيفاء |regexes| و |paths|.
    condition = "AND"
    # ملاحظة: |regexes| افتراضياً يتحقق من _السر_ في النتيجة.
    # القيم المقبولة لـ |regexTarget| هي "secret" (افتراضي)، "match"، و "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# يمكنك تمديد قاعدة معينة من التكوين الافتراضي. مثلاً، gitlab-pat
# إذا قمت بتعريف بادئة رمز مخصصة على مثيل GitLab الخاص بك
[[rules]]
id = "gitlab-pat"
# جميع السمات الأخرى من القاعدة الافتراضية يتم وراثتها

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ في الإصدار v8.25.0 تم استبدال `[allowlist]` بـ `[[allowlists]]`.
#
# قوائم السماح العالمية لها أولوية أعلى من قوائم السماح الخاصة بالقواعد.
# إذا تم العثور على التزام مذكور في الحقل `commits` أدناه فسيتم تخطي ذلك الالتزام ولن
# يتم الكشف عن أي أسرار له. ينطبق نفس المنطق على regexes و paths.
[[allowlists]]
description = "قائمة سماح عالمية"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# ملاحظة: (العالمي) regexTarget افتراضياً يتحقق من _السر_ في النتيجة.
# القيم المقبولة لـ regexTarget هي "match" و "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# ملاحظة: stopwords تستهدف السر المستخرج، وليس كامل نتيجة regex
# كما تفعل 'regexes'. (تم تقديم stopwords في 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ في الإصدار v8.25.0، تمت إضافة حقل جديد باسم |targetRules| في `[[allowlists]]`.
#
# يمكن تعريف قوائم السماح المشتركة مرة واحدة وتعيينها لعدة قواعد باستخدام |targetRules|.
# سيعمل هذا فقط على القواعد المحددة، وليس على مستوى عالمي.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "تتسبب أصول الاختبار لدينا في نتائج إيجابية زائفة في بعض القواعد."
paths = ['''tests/expected/._\.json$''']
```

راجع [إعدادات gitleaks الافتراضية](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) لمزيد من الأمثلة أو اتبع [إرشادات المساهمة](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) إذا كنت ترغب في المساهمة في الإعداد الافتراضي. بالإضافة إلى ذلك، يمكنك الاطلاع على [منشور مدونة gitleaks هذا](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) الذي يغطي إعدادات التكوين المتقدمة.

### إعدادات إضافية

#### gitleaks:allow

إذا كنت تقوم بإضافة سر اختبار معروف أنه سيتم اكتشافه بواسطة gitleaks، يمكنك إضافة تعليق `gitleaks:allow` على السطر ذاته لإخبار gitleaks بتجاهل هذا السر. مثال:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

يمكنك تجاهل نتائج محددة بإنشاء ملف `.gitleaksignore` في جذر المستودع الخاص بك. في الإصدار v8.10.0 أضاف Gitleaks قيمة `Fingerprint` إلى تقرير Gitleaks. كل تسريب أو نتيجة تحتوي على بصمة Fingerprint تميز السر بشكل فريد. أضف هذه البصمة إلى ملف `.gitleaksignore` لتجاهل هذا السر تحديدًا. راجع [ملف .gitleaksignore الخاص بـ Gitleaks](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) كمثال. ملاحظة: هذه الميزة تجريبية وقابلة للتغيير في المستقبل.

#### فك الترميز (Decoding)

أحيانًا يتم ترميز الأسرار بطريقة تجعل اكتشافها باستخدام regex فقط أمرًا صعبًا.
الآن يمكنك إخبار gitleaks باكتشاف وفك ترميز النص المشفر تلقائيًا. يقوم الخيار `--max-decode-depth` بتفعيل هذه الميزة (القيمة الافتراضية "0" تعني أن الميزة معطلة افتراضيًا).

يدعم فك الترميز التكراري لأن النص المفكوك قد يحتوي أيضًا على نص مشفر. يقوم الخيار `--max-decode-depth` بتحديد حد التكرار. تتوقف عملية التكرار عندما لا توجد أجزاء جديدة من النص المشفر ليتم فك ترميزها، لذا تحديد عمق كبير لا يعني بالضرورة عدد تمريرات كبير، بل سيتم فك الترميز بالقدر المطلوب فقط. بشكل عام، يضيف فك الترميز زيادة بسيطة جدًا في وقت الفحص.

تختلف النتائج الخاصة بالنص المشفر عن النتائج العادية من حيث:

- يشير الموقع إلى حدود النص المشفر.
  - إذا تم مطابقة القاعدة خارج النص المشفر، يتم تعديل الحدود لتشمل ذلك أيضًا.
- يحتوي كل من match وsecret على القيمة المفكوكة.
- يتم إضافة وسمين: `decoded:<encoding>` و `decode-depth:<depth>`

أنواع الترميز المدعومة حاليًا:

- **percent** - أي قيم ASCII قابلة للطباعة ومشفرة بنظام النسبة المئوية
- **hex** - أي قيم ASCII قابلة للطباعة ومشفرة بنظام الست عشري طولها 32 حرفًا أو أكثر
- **base64** - أي قيم ASCII قابلة للطباعة ومشفرة بنظام base64 طولها 16 حرفًا أو أكثر

#### فحص الأرشيفات (Archive Scanning)

أحيانًا تكون الأسرار موجودة داخل ملفات أرشيف مثل zip أو tarball، مما يصعب اكتشافها. الآن يمكنك إخبار gitleaks بفك واستخراج وفحص محتويات الأرشيفات تلقائيًا. يقوم الخيار `--max-archive-depth` بتفعيل هذه الميزة لكل من نوعي الفحص `dir` و `git`. القيمة الافتراضية "0" تعني أن الميزة معطلة افتراضيًا.

يدعم الفحص التكراري حيث يمكن أن تحتوي الأرشيفات على أرشيفات أخرى بداخلها. يقوم الخيار `--max-archive-depth` بتحديد حد التكرار. تتوقف العملية عندما لا توجد أرشيفات جديدة ليتم استخراجها، لذا تحديد عمق كبير فقط يحدد الحد الأقصى الممكن للوصول إليه، وسيتم الذهاب فقط بالعمق المطلوب.

ستتضمن النتائج الخاصة بالأسرار الموجودة داخل الأرشيف مسار الملف داخل الأرشيف. يتم الفصل بين المسارات الداخلية باستخدام `!`.

مثال على نتيجة (تم اختصارها):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

هذا يعني أنه تم اكتشاف سر في السطر 4 من `files/.env.prod.` الموجود داخل `archives/files.tar` والذي يوجد داخل `testdata/archives/nested.tar.gz`.

التنسيقات المدعومة حاليًا:

[تنسيقات الضغط](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
و [تنسيقات الأرشيف](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
المدعومة من مكتبة [archives](https://github.com/mholt/archives) الخاصة بـ mholt مدعومة.

#### التقارير (Reporting)

يدعم Gitleaks عدة تنسيقات تقارير مدمجة: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json)، [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1)، [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml)، و [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

إذا لم تكن أي من هذه التنسيقات مناسبة لك، يمكنك إنشاء تنسيق تقرير خاص بك باستخدام [ملف Go `text/template` بامتداد .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) وعلم `--report-template`. يمكن للقالب استخدام [وظائف إضافية من مكتبة القوالب `Masterminds/sprig`](https://masterminds.github.io/sprig/).

على سبيل المثال، القالب التالي يوفر إخراج JSON مخصص:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

الاستخدام:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## الرعايات

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## رموز الخروج (Exit Codes)

يمكنك دائمًا تعيين رمز الخروج عند اكتشاف تسريبات باستخدام الخيار --exit-code. رموز الخروج الافتراضية أدناه:

```
0 - لا توجد تسريبات
1 - تم اكتشاف تسريبات أو خطأ
126 - علم غير معروف
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---