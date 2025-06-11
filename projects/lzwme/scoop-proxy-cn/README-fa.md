# 🍡 scoop-proxy-cn

مخزن آیینه‌ای پراکسی مناسب برای کاربران سرزمین اصلی چین برای [Scoop](https://scoop.sh) buckets. همگام‌سازی و به‌روزرسانی از چندین مخزن متن باز `bucket`. در میان آنها:

- شاخه `sync` (پیش‌فرض): همگام‌سازی برنامه‌ها از چند مخزن، اما بدون اصلاح آدرس‌های پراکسی ghproxy. **مناسب برای استفاده در سناریوهای نسخه اصلاح شده داخلی scoop در گیت‌ای (gitee)**
- شاخه `main`: آدرس دانلود برنامه‌های `github release` را به آدرس دانلود پراکسی مبتنی بر `https://ghfast.top` تغییر می‌دهد. **به دلیل تغییرات مکرر و عدم پایداری آدرس پراکسی، ناپایدار است**

## استفاده

افزودن مخزن برنامه `spc`. مناسب برای استفاده همراه با [مخزن بهینه‌سازی آینه‌ای داخلی scoop](https://gitee.com/scoop-installer/scoop):

```bash
# افزودن bucket، به طور پیش‌فرض شاخه sync را می‌کشد
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# نصب برنامه‌ها
scoop install spc/<app_name>
```

اگر فقط می‌خواهید نسخه رسمی Scoop را استفاده کنید، می‌توانید به صورت زیر شاخه اشتراک را به شاخه `main` تغییر دهید:

```bash
# وارد شاخه spc شوید
cd "$env:USERPROFILE\scoop\buckets\spc"
# اگر متغیر محیطی SCOOP تنظیم شده است، باید دستور زیر را اجرا کنید
cd "$env:SCOOP\buckets\spc"

# تغییر به شاخه main
git fetch --all
git checkout -b main origin/main
```

## مرجع نصب و تنظیم Scoop

### روش اول: نصب بر اساس آینه داخلی سفارشی (توصیه شده)

از آنجا که سورس کد و برنامه‌های buckets scoop معمولاً به صورت git در github نگهداری می‌شوند و دسترسی به github دشوار است، نصب، به‌روزرسانی و دانلود برنامه‌ها به شدت تحت تأثیر قرار می‌گیرد.

در ادامه روش نصب برای [مخزن بهینه‌سازی آینه‌ای داخلی scoop](https://gitee.com/scoop-installer/scoop) شرح داده شده است.

```bash
# تغییر سیاست اجرای اسکریپت، به طور پیش‌فرض موافقت خودکار
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# روش اول: اجرای دستور نصب (به طور پیش‌فرض در دایرکتوری کاربر نصب می‌شود، برای تغییر مسیر به دستور "نصب سفارشی" زیر مراجعه کنید)
iwr -useb scoop.201704.xyz | iex


## روش دوم: نصب در دایرکتوری سفارشی (توجه داشته باشید مسیر را به مکان مناسب تغییر دهید)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# اگر قبلاً مخزن رسمی نصب شده است، می‌توانید به مخزن زیر سوئیچ کنید
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# افزودن bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# بروزرسانی آدرس مخزن جدید
scoop update
```

نسخه scoop نصب شده با این روش سفارشی شده است، از سایت‌های پراکسی سفارشی پشتیبانی می‌کند و به طور پیش‌فرض از پراکسی `scoop.201704.xyz` برای دانلود برنامه‌ها استفاده می‌کند.

```bash
# افزودن پراکسی
scoop config URL_PROXY "https://scoop.201704.xyz"

# حذف پراکسی
scoop config rm URL_PROXY
```

### روش دوم: نصب بر اساس مخزن رسمی با استفاده از پراکسی

PowerShell را باز کرده و دستورات زیر را برای نصب اجرا کنید:

```bash
# نصب
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# پیکربندی
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# افزودن bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# وارد شاخه spc شوید
cd "$env:USERPROFILE\scoop\buckets\spc"
# تغییر به شاخه main
git fetch --all && git checkout -b main origin/main

# نمایش راهنما
scoop help

# نصب 7zip، aria2، scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### درباره `scoop-search`

از آنجا که مخزن `scoop-proxy-cn` بیش از ۱۴۰۰۰ برنامه را همگام‌سازی کرده است، دستور رسمی `scoop search` که بر اساس PowerShell نوشته شده است، به شدت کند و غیرقابل استفاده است، توصیه می‌شود ابزار `scoop-search` که به زبان Go توسعه یافته است را جایگزین کنید. نمونه:

```bash
scoop install scoop-search
# استفاده از scoop-search
scoop-search act
```

## سوالات متداول

### درباره مشکل عدم موفقیت دانلود به دلیل `aria2`

وقتی `aria2` نصب شود، scoop از `aria2` برای دانلود تکه‌ای و تسریع استفاده می‌کند. اما بعضی آدرس‌های پراکسی از دانلود تکه‌ای توسط `aria2` پشتیبانی نمی‌کنند یا آن را مسدود می‌کنند، در این صورت می‌توانید با دستور زیر `aria2` را غیرفعال کنید:

```bash
scoop config aria2-enabled false
```

### درباره مشکل `Hash Check Failed`

برخی برنامه‌ها آدرس دانلود به روزترین نسخه را دارند ولی مقدار hash هم تنظیم شده است. وقتی نسخه جدیدی منتشر شود، خطای `Hash Check Failed` رخ می‌دهد. در این حالت می‌توانید پارامتر `-s` را اضافه کنید تا این خطا نادیده گرفته شود. نمونه:

```bash
scoop install scoop-search -s
```

### درباره روش به‌روزرسانی در صورت از کار افتادن سایت پراکسی

اگر از نسخه رسمی Scoop استفاده می‌کنید و شاخه اشتراک `main` است، از سایت پراکسی برای تسریع دانلود مخازن git و برنامه‌ها استفاده می‌شود. اما اگر این سایت‌های پراکسی قدیمی از کار بیفتند، بروزرسانی متوقف می‌شود. برای رفع مشکل، دستورات زیر را اجرا کنید:

```bash
# ابتدا مخزن scoop را بروزرسانی کنید
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# روش اول: بروزرسانی آدرس مخزن spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# اگر محل پیش‌فرض buckets تغییر کرده است، دستور زیر را اجرا کنید
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# روش دوم: حذف و افزودن مجدد spc bucket
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## همگام‌سازی از مخازن

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

## اعلامیه

> [!WARNING]
> این مخزن شامل اطلاعات برنامه‌ها است که تنها از مخازن شخص ثالث همگام‌سازی شده‌اند و به طور جداگانه برای قابلیت استفاده و امنیت بررسی نشده‌اند، لطفاً هنگام نصب و انتخاب، خودتان آن‌ها را تأیید و شناسایی کنید. در صورت وجود نقض حقوق، لطفاً issues ارسال کنید تا رسیدگی شود.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---