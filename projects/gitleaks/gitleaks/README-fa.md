# گیت‌لیکس (Gitleaks)

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


### به دیسکورد ما بپیوندید! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

گیت‌لیکس ابزاری برای **شناسایی** اسرار مانند پسوردها، کلیدهای API و توکن‌ها در مخازن گیت، فایل‌ها و هر چیز دیگری است که شما می‌خواهید از طریق `stdin` به آن بدهید. اگر می‌خواهید بیشتر با نحوه کار موتور شناسایی آشنا شوید، به این وبلاگ مراجعه کنید: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


یافت شده:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
اسرار:        cafebabe:deadbeef
شناسه قانون:  sidekiq-secret
آنتروپی:      2.609850
فایل:         cmd/generate/config/rules/sidekiq.go
خط:           23
کامیت:        cd5226711335c68be1e720b318b7bc3135a30eb2
نویسنده:      John
ایمیل:        john@users.noreply.github.com
تاریخ:        2022-08-03T12:31:40Z
اثر انگشت:     cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## شروع به کار

گیت‌لیکس را می‌توانید با استفاده از Homebrew، Docker یا Go نصب کنید. همچنین گیت‌لیکس به صورت باینری برای بسیاری از پلتفرم‌ها و سیستم‌عامل‌های محبوب در [صفحه نسخه‌ها](https://github.com/gitleaks/gitleaks/releases) موجود است. علاوه بر این، گیت‌لیکس را می‌توان به عنوان یک pre-commit hook مستقیماً در مخزن خود یا به صورت GitHub Action با استفاده از [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action) اجرا کرد.

### نصب

```bash
# مک‌اواس
brew install gitleaks

# داکر (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# داکر (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# از سورس (اطمینان حاصل کنید که `go` نصب است)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### اکشن گیت‌هاب

اکشن رسمی [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action) را بررسی کنید

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
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # فقط برای سازمان‌ها لازم است، نه حساب‌های شخصی.
```

### Pre-Commit

1. pre-commit را از https://pre-commit.com/#install نصب کنید
2. یک فایل `.pre-commit-config.yaml` در ریشه مخزن خود با محتوای زیر ایجاد کنید:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   برای [اجرای بومی گیت‌لیکس](https://github.com/gitleaks/gitleaks/releases) یا استفاده از [شناسه pre-commit `gitleaks-docker`](https://github.com/gitleaks/gitleaks/blob/master/.pre-commit-hooks.yaml) برای اجرای گیت‌لیکس با استفاده از [تصاویر رسمی داکر](#docker)

3. پیکربندی را با اجرای `pre-commit autoupdate` به آخرین نسخه‌های مخازن به‌روزرسانی خودکار کنید
4. با دستور `pre-commit install` نصب را انجام دهید
5. اکنون همه چیز آماده است!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

توجه: برای غیرفعال کردن hook پیش‌تعهدی گیت‌لیکس می‌توانید `SKIP=gitleaks` را به ابتدای دستور commit اضافه کنید و اجرای گیت‌لیکس را رد کنید

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## نحوه استفاده

```
Usage:
  gitleaks [command]

Available Commands:
  dir         اسکن دایرکتوری‌ها یا فایل‌ها برای یافتن اسرار
  git         اسکن مخازن گیت برای یافتن اسرار
  help        راهنما درباره هر فرمان
  stdin       شناسایی اسرار از طریق ورودی استاندارد
  version     نمایش نسخه گیت‌لیکس

Flags:
  -b, --baseline-path string          مسیر baseline با مشکلاتی که می‌توان نادیده گرفت
  -c, --config string                 مسیر فایل پیکربندی
                                      ترتیب اولویت:
                                      1. --config/-c
                                      2. متغیر محیطی GITLEAKS_CONFIG
                                      3. متغیر محیطی GITLEAKS_CONFIG_TOML با محتوای فایل
                                      4. (مسیر هدف)/.gitleaks.toml
                                      اگر هیچ‌یک از این چهار گزینه استفاده نشود، گیت‌لیکس پیکربندی پیش‌فرض را استفاده می‌کند
      --diagnostics string            فعال‌سازی تشخیص‌ها (لیست جدا شده با کاما: cpu,mem,trace). cpu=پروفایل‌گیری CPU، mem=پروفایل‌گیری حافظه، trace=رهگیری اجرا
      --diagnostics-dir string        دایرکتوری برای ذخیره فایل‌های خروجی تشخیص (پیش‌فرض دایرکتوری فعلی)
      --enable-rule strings           فقط فعال‌سازی قوانین خاص با شناسه
      --exit-code int                 کد خروج در صورت یافتن نشت (پیش‌فرض 1)
  -i, --gitleaks-ignore-path string   مسیر فایل .gitleaksignore یا پوشه‌ای که شامل آن است (پیش‌فرض ".")
  -h, --help                          راهنما برای گیت‌لیکس
      --ignore-gitleaks-allow         نادیده گرفتن کامنت‌های gitleaks:allow
  -l, --log-level string              سطح لاگ (trace, debug, info, warn, error, fatal) (پیش‌فرض "info")
      --max-decode-depth int          اجازه رمزگشایی بازگشتی تا این عمق (پیش‌فرض "0"، رمزگشایی انجام نمی‌شود)
      --max-archive-depth int         اجازه اسکن آرشیوهای تو در تو تا این عمق (پیش‌فرض "0"، پیمایش آرشیو انجام نمی‌شود)
      --max-target-megabytes int      فایل‌های بزرگ‌تر از این مقدار رد می‌شوند
      --no-banner                     عدم نمایش بنر
      --no-color                      خاموش کردن رنگ برای خروجی verbose
      --redact uint[=100]             پنهان‌سازی اسرار در لاگ‌ها و خروجی استاندارد. برای پنهان‌سازی بخشی از اسرار درصدی از 0 تا 100 را اعمال کنید. مثلاً --redact=20 (پیش‌فرض 100٪)
  -f, --report-format string          فرمت خروجی (json, csv, junit, sarif, template)
  -r, --report-path string            مسیر فایل گزارش
      --report-template string        فایل قالب برای تولید گزارش (به معنای --report-format=template)
  -v, --verbose                       نمایش خروجی مفصل از اسکن
      --version                       نسخه گیت‌لیکس

برای اطلاعات بیشتر درباره هر فرمان از "gitleaks [command] --help" استفاده کنید.
```

### دستورات

⚠️ نسخه v8.19.0 تغییری اعمال کرد که دستورات `detect` و `protect` را کنار گذاشت. این دستورات همچنان در دسترس هستند اما در منوی `--help` پنهان شده‌اند. برای ترجمه آسان دستورات به این [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) مراجعه کنید.
اگر نسخه v8.19.0 باعث شکست یک فرمان موجود (`detect`/`protect`) شد، لطفاً یک issue باز کنید.

سه حالت اسکن وجود دارد: `git`، `dir` و `stdin`.

#### Git

فرمان `git` به شما امکان می‌دهد مخازن گیت محلی را اسکن کنید. در پس‌زمینه، گیت‌لیکس از دستور `git log -p` برای اسکن patchها استفاده می‌کند.
می‌توانید رفتار `git log -p` را با گزینه `log-opts` پیکربندی کنید.
مثلاً اگر بخواهید گیت‌لیکس را روی بازه‌ای از کامیت‌ها اجرا کنید می‌توانید از فرمان زیر استفاده کنید: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. برای اطلاعات بیشتر به مستندات [git log](https://git-scm.com/docs/git-log) مراجعه کنید.
اگر هدفی به عنوان آرگومان موقعیتی مشخص نشود، گیت‌لیکس تلاش می‌کند پوشه کاری فعلی را به عنوان یک مخزن گیت اسکن کند.
#### Dir

دستور `dir` (نام‌های مستعار شامل `files`، `directory`) به شما اجازه می‌دهد دایرکتوری‌ها و فایل‌ها را اسکن کنید. مثال: `gitleaks dir -v path_to_directory_or_file`.
اگر هیچ هدفی به عنوان آرگومان موقعیتی مشخص نشود، gitleaks دایرکتوری کاری جاری را اسکن خواهد کرد.

#### Stdin

شما همچنین می‌توانید داده‌ها را با دستور `stdin` به gitleaks ارسال کنید. مثال: `cat some_file | gitleaks -v stdin`

### ایجاد یک خط پایه

هنگام اسکن مخازن بزرگ یا مخازنی با تاریخچه طولانی، استفاده از یک خط پایه می‌تواند راحت باشد. با استفاده از خط پایه،
gitleaks هر یافته قدیمی که در خط پایه موجود باشد را نادیده می‌گیرد. یک خط پایه می‌تواند هر گزارشی از gitleaks باشد. برای ایجاد یک گزارش gitleaks، gitleaks را با پارامتر `--report-path` اجرا کنید.

```
gitleaks git --report-path gitleaks-report.json # این گزارش را در فایلی به نام gitleaks-report.json ذخیره می‌کند
```

وقتی که یک خط پایه ایجاد شد، می‌توان آن را هنگام اجرای مجدد دستور detect اعمال کرد:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

پس از اجرای دستور detect با پارامتر --baseline-path، خروجی گزارش (findings.json) فقط شامل مشکلات جدید خواهد بود.

## قلاب Pre-Commit

شما می‌توانید Gitleaks را به عنوان یک قلاب pre-commit با کپی کردن اسکریپت نمونه `pre-commit.py` در
دایرکتوری `.git/hooks/` خود اجرا کنید.

## بارگذاری پیکربندی

ترتیب اولویت به شرح زیر است:

1. گزینه `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. متغیر محیطی `GITLEAKS_CONFIG` با مسیر فایل:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. متغیر محیطی `GITLEAKS_CONFIG_TOML` با محتوای فایل:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. یک فایل `.gitleaks.toml` در مسیر هدف:
      ```bash
      gitleaks git .
      ```

اگر هیچ‌یک از چهار گزینه استفاده نشود، gitleaks از پیکربندی پیش‌فرض استفاده خواهد کرد.

## پیکربندی

Gitleaks یک فرمت پیکربندی ارائه می‌دهد که می‌توانید طبق آن قوانین شناسایی رمز خود را بنویسید:

```toml
# عنوان برای فایل پیکربندی gitleaks.
title = "پیکربندی سفارشی Gitleaks"

# شما اساساً دو گزینه برای پیکربندی سفارشی خود دارید:
#
# 1. تعریف پیکربندی خودتان، قوانین پیش‌فرض اعمال نمی‌شوند
#
#    برای شروع می‌توانید مثلاً از پیکربندی پیش‌فرض استفاده کنید:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. گسترش یک پیکربندی، قوانین بازنویسی یا گسترش می‌یابند
#
#    هنگامی که یک پیکربندی را گسترش می‌دهید، قوانین گسترش‌یافته نسبت به
#    قوانین پیش‌فرض ارجحیت دارند. یعنی اگر قوانین تکراری در هر دو پیکربندی
#    گسترش‌یافته و پیش‌فرض وجود داشته باشد، قوانین یا ویژگی‌های گسترش‌یافته
#    جایگزین قوانین پیش‌فرض خواهند شد.
#    نکته دیگری که در مورد گسترش پیکربندی‌ها باید بدانید این است که می‌توانید
#    چندین فایل پیکربندی را تا عمق ۲ به هم زنجیر کنید. آرایه‌های Allowlist
#    اضافه می‌شوند و می‌توانند شامل تکراری باشند.

# useDefault و path نمی‌توانند به طور همزمان استفاده شوند. یکی را انتخاب کنید.
[extend]
# useDefault پیکربندی پیش‌فرض gitleaks را که در باینری تعبیه شده گسترش می‌دهد
# آخرین نسخه در آدرس زیر قرار دارد:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# یا می‌توانید مسیری برای گسترش از یک پیکربندی ارائه دهید.
# مسیر نسبت به جایی است که gitleaks اجرا شده،
# نه محل پیکربندی پایه.
# path = "common_config.toml"
# اگر قوانینی وجود دارد که نمی‌خواهید به ارث ببرید، می‌توانید آن‌ها را اینجا مشخص کنید.
disabledRules = [ "generic-api-key"]

# آرایه‌ای از جدول‌ها که شامل اطلاعاتی برای تعریف دستورالعمل‌ها
# جهت شناسایی رمزها است
[[rules]]
# شناسه یکتا برای این قانون
id = "awesome-rule-1"

# توضیح کوتاه و قابل فهم برای قانون.
description = "قانون عالی ۱"

# عبارت باقاعده Golang برای شناسایی رمزها. توجه داشته باشید که موتور regex Golang
# از lookahead پشتیبانی نمی‌کند.
regex = '''one-go-style-regex-for-this-rule'''

# عدد صحیح برای استخراج رمز از تطابق regex و به عنوان گروهی که
# اگر `entropy` تنظیم شده باشد، آنتروپی آن بررسی می‌شود.
secretGroup = 3

# عدد اعشاری که حداقل آنتروپی شانون گروه regex را برای شناسایی به عنوان رمز تعیین می‌کند.
entropy = 3.5

# عبارت باقاعده Golang برای تطبیق مسیرها. می‌تواند به عنوان یک قانون مستقل یا به همراه
# یک ورودی معتبر `regex` استفاده شود.
path = '''a-file-path-regex'''

# کلیدواژه‌ها برای فیلتر اولیه قبل از چک regex استفاده می‌شوند. قوانینی که شامل
# کلیدواژه هستند یک بررسی سریع مقایسه رشته‌ای انجام می‌دهند تا مطمئن شوند
# کلیدواژه(ها) در محتوای اسکن شده موجود است. ایده‌آل است که این مقادیر
# بخشی از شناسه یا رشته‌های منحصربه‌فرد مرتبط با regex قانون باشند
# (معرفی شده در v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# آرایه‌ای از رشته‌ها برای متادیتا و اهداف گزارش‌دهی.
tags = ["tag","another tag"]

    # ⚠️ در نسخه v8.21.0 `[rules.allowlist]` جایگزین `[[rules.allowlists]]` شد.
    # این تغییر با نسخه‌های قبلی سازگار است: نمونه‌های `[rules.allowlist]` همچنان کار می‌کنند.
    #
    # شما می‌توانید چندین allowlist برای یک قانون تعریف کنید تا مثبت‌های کاذب را کاهش دهید.
    # اگر _هر_ کدام از `[[rules.allowlists]]` تطبیق داشته باشد، یک یافته نادیده گرفته می‌شود.
    [[rules.allowlists]]
    description = "نادیده گرفتن commit A"
    # وقتی چندین معیار تعریف شده باشد، شرط پیش‌فرض "OR" است.
    # مثال: این می‌تواند روی |commits| یا |paths| یا |stopwords| تطبیق داشته باشد.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # توجه: stopwords روی رمز استخراج شده هدف قرار می‌گیرد، نه کل تطبیق regex
    # مانند 'regexes'. (stopwords از نسخه 8.8.0 معرفی شد)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # شرط "AND" می‌تواند استفاده شود تا مطمئن شوید همه معیارها تطبیق دارند.
    # مثال: این زمانی تطبیق دارد که |regexes| و |paths| هر دو برقرار باشند.
    condition = "AND"
    # توجه: |regexes| به طور پیش‌فرض رمز استخراج شده در یافته را بررسی می‌کند.
    # مقادیر قابل قبول برای |regexTarget| عبارتند از "secret" (پیش‌فرض)، "match" و "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# می‌توانید یک قانون خاص را از پیکربندی پیش‌فرض گسترش دهید. مثال: gitlab-pat
# اگر یک پیشوند رمز سفارشی روی نمونه GitLab خود تعریف کرده‌اید
[[rules]]
id = "gitlab-pat"
# همه ویژگی‌های دیگر از قانون پیش‌فرض به ارث می‌رسند

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ در نسخه v8.25.0 `[allowlist]` جایگزین `[[allowlists]]` شد.
#
# allowlistهای کلی ترتیب اولویت بالاتری نسبت به allowlistهای مخصوص قانون دارند.
# اگر یک commit که در فیلد `commits` زیر آمده مشاهده شود، آن commit رد می‌شود و هیچ
# رمزی برای آن commit شناسایی نخواهد شد. همین منطق برای regexها و مسیرها نیز صدق می‌کند.
[[allowlists]]
description = "لیست مجاز سراسری"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# توجه: (سراسری) regexTarget به طور پیش‌فرض رمز استخراج شده در یافته را بررسی می‌کند.
# مقادیر قابل قبول برای regexTarget عبارتند از "match" و "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# توجه: stopwords روی رمز استخراج شده هدف قرار می‌گیرد، نه کل تطبیق regex
# مانند 'regexes'. (stopwords از نسخه 8.8.0 معرفی شد)
stopwords = [
  '''client''',
```endpoint''',
]

# ⚠️ در نسخه v8.25.0، بخش `[[allowlists]]` دارای فیلد جدیدی به نام |targetRules| است.
#
# لیست‌های مجاز مشترک را می‌توان یک‌بار تعریف کرد و به چندین قانون با استفاده از |targetRules| اختصاص داد.
# این فقط روی قوانین مشخص شده اجرا می‌شود، نه به صورت سراسری.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "دارایی‌های تست ما موجب مثبت کاذب در چند قانون می‌شوند."
paths = ['''tests/expected/._\.json$''']
```

برای مثال‌ها به [پیکربندی پیش‌فرض گیت‌لیکس](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) مراجعه کنید یا در صورت تمایل به همکاری در پیکربندی پیش‌فرض، [راهنمای همکاری](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) را دنبال نمایید. همچنین می‌توانید [این پست وبلاگ گیت‌لیکس](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) را که تنظیمات پیشرفته پیکربندی را پوشش می‌دهد، بررسی کنید.

### پیکربندی‌های اضافی

#### gitleaks:allow

اگر آگاهانه یک راز آزمایشی را که گیت‌لیکس آن را شناسایی می‌کند کامیت می‌کنید، می‌توانید یک کامنت `gitleaks:allow` به آن خط اضافه کنید تا گیت‌لیکس آن راز را نادیده بگیرد. مثال:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

می‌توانید یافته‌های خاص را با ایجاد یک فایل `.gitleaksignore` در ریشه مخزن خود نادیده بگیرید. در نسخه v8.10.0 گیت‌لیکس یک مقدار `Fingerprint` به گزارش خود افزود. هر نشت یا یافته دارای یک Fingerprint است که راز را به طور منحصر به فرد شناسایی می‌کند. این اثر انگشت را به فایل `.gitleaksignore` اضافه کنید تا آن راز خاص نادیده گرفته شود. برای مثال، [.gitleaksignore گیت‌لیکس](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) را ببینید. توجه: این ویژگی آزمایشی است و ممکن است در آینده تغییر کند.

#### رمزگشایی (Decoding)

گاهی اوقات رازها به گونه‌ای رمزگذاری می‌شوند که یافتن آن‌ها فقط با regex دشوار است.
اکنون می‌توانید به گیت‌لیکس بگویید تا به طور خودکار متن رمزگذاری‌شده را بیابد و رمزگشایی کند.
فلگ `--max-decode-depth` این ویژگی را فعال می‌کند (مقدار پیش‌فرض "0" به معنای غیرفعال بودن پیش‌فرض ویژگی است).

رمزگشایی بازگشتی پشتیبانی می‌شود زیرا متن رمزگشایی‌شده می‌تواند حاوی متن رمزگذاری‌شده بیشتری باشد. فلگ `--max-decode-depth` حد بازگشت را تعیین می‌کند. بازگشت زمانی متوقف می‌شود که بخش جدیدی برای رمزگشایی وجود نداشته باشد، بنابراین تعیین عمق زیاد به این معنا نیست که آن تعداد بار اجرا می‌شود، فقط به اندازه نیاز رمزگشایی انجام می‌شود. به طور کلی، رمزگشایی فقط زمان اسکن را به میزان اندکی افزایش می‌دهد.

یافته‌های متن رمزگذاری‌شده به روش‌های زیر با یافته‌های عادی متفاوت است:

- موقعیت مکانی مرزهای متن رمزگذاری‌شده را نشان می‌دهد
  - اگر قانون خارج از متن رمزگذاری‌شده مطابقت پیدا کند، مرزها برای پوشش آن نیز تنظیم می‌شوند
- مقدار match و secret حاوی مقدار رمزگشایی‌شده هستند
- دو تگ به یافته‌ها افزوده می‌شود: `decoded:<encoding>` و `decode-depth:<depth>`

رمزگذاری‌های پشتیبانی‌شده فعلی:

- **percent** - هر مقدار رمزگذاری‌شده با درصد از کاراکترهای ASCII قابل چاپ
- **hex** - هر مقدار رمزگذاری‌شده هگزادسیمال از کاراکترهای ASCII قابل چاپ با طول حداقل ۳۲ کاراکتر
- **base64** - هر مقدار رمزگذاری‌شده base64 از کاراکترهای ASCII قابل چاپ با طول حداقل ۱۶ کاراکتر

#### اسکن آرشیو

گاهی اوقات رازها در فایل‌های آرشیو مانند فایل‌های zip یا tarball قرار می‌گیرند و کشف آن‌ها دشوار است. اکنون می‌توانید به گیت‌لیکس بگویید تا به طور خودکار محتوای آرشیوها را استخراج و اسکن کند. فلگ `--max-archive-depth` این ویژگی را برای هر دو نوع اسکن `dir` و `git` فعال می‌کند. مقدار پیش‌فرض "0" به معنای غیرفعال بودن این ویژگی است.

اسکن بازگشتی پشتیبانی می‌شود زیرا آرشیوها می‌توانند حاوی آرشیوهای دیگری باشند. فلگ `--max-archive-depth` حد بازگشت را تعیین می‌کند. بازگشت زمانی متوقف می‌شود که آرشیو جدیدی برای استخراج وجود نداشته باشد، بنابراین تعیین عمق زیاد فقط امکان رفتن به آن عمق را فراهم می‌کند، و فقط به اندازه نیاز پیش می‌رود.

یافته‌های رازهای داخل یک آرشیو شامل مسیر فایل درون آرشیو نیز خواهد بود. مسیرهای داخلی با `!` جدا می‌شوند.

نمونه یافته (برای اختصار کوتاه شده):

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

این بدان معناست که رازی در خط ۴ فایل `files/.env.prod.` که در
`archives/files.tar` است و آن نیز در `testdata/archives/nested.tar.gz` قرار دارد شناسایی شده است.

فرمت‌های پشتیبانی‌شده فعلی:

فرمت‌های [فشرده‌سازی](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
و [آرشیو](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
که توسط بسته [archives](https://github.com/mholt/archives) متعلق به mholt پشتیبانی می‌شوند، پشتیبانی می‌شوند.

#### گزارش‌دهی (Reporting)

گیت‌لیکس به طور داخلی از چندین فرمت گزارش پشتیبانی می‌کند: [`json`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/json_simple.json)، [`csv`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/csv_simple.csv?plain=1)، [`junit`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/junit_simple.xml)، و [`sarif`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/sarif_simple.sarif).

اگر هیچ‌یک از این فرمت‌ها نیاز شما را برآورده نمی‌کند، می‌توانید قالب گزارش دلخواه خود را با استفاده از یک [فایل .tmpl قالب Go `text/template`](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) و فلگ `--report-template` ایجاد کنید. قالب می‌تواند از [قابلیت‌های افزوده‌شده از کتابخانه قالب `Masterminds/sprig`](https://masterminds.github.io/sprig/) استفاده کند.

به عنوان مثال، قالب زیر یک خروجی JSON سفارشی ارائه می‌دهد:
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

نحوه استفاده:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## اسپانسرشیپ‌ها

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## کدهای خروجی (Exit Codes)

شما همیشه می‌توانید با استفاده از فلگ --exit-code کد خروجی را هنگام مواجهه با نشت‌ها تنظیم کنید. کدهای خروجی پیش‌فرض به شرح زیر است:

```
0 - هیچ نشتی وجود ندارد
1 - نشتی یا خطا رخ داده است
126 - فلگ ناشناخته
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---