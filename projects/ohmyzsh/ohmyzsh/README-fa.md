<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh یک چارچوب متن‌باز و مبتنی بر جامعه برای مدیریت پیکربندی [zsh](https://www.zsh.org/) شماست.

خیلی خشک به نظر می‌رسد. بیایید دوباره امتحان کنیم.

**Oh My Zsh شما را تبدیل به یک توسعه‌دهنده ۱۰ برابری نمی‌کند... اما ممکن است این احساس را داشته باشید.**

پس از نصب، پوسته ترمینال شما نقل محافل خواهد شد _یا پولتان را پس می‌گیرید!_ با هر ضربه کلید در خط فرمان خود، از صدها افزونه قدرتمند و قالب‌های زیبای آن بهره‌مند خواهید شد.
افراد غریبه در کافی‌شاپ‌ها نزد شما آمده و خواهند پرسید، _"این فوق‌العاده است! آیا شما نابغه هستید؟"_

در نهایت، شروع به جلب توجهی خواهید کرد که همیشه فکر می‌کردید شایسته آن هستید. ...یا شاید وقت ذخیره‌شده را صرف نخ دندان کشیدن بیشتر کنید. 😬

برای اطلاعات بیشتر به [ohmyz.sh](https://ohmyz.sh) مراجعه کنید، [@ohmyzsh](https://x.com/ohmyzsh) را در X (توییتر سابق) دنبال کنید، و به ما در [Discord](https://discord.gg/ohmyzsh) بپیوندید.

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>فهرست مطالب</summary>

- [شروع به کار](#getting-started)
  - [سازگاری با سیستم‌عامل](#operating-system-compatibility)
  - [پیش‌نیازها](#prerequisites)
  - [نصب پایه](#basic-installation)
    - [بازبینی دستی](#manual-inspection)
- [استفاده از Oh My Zsh](#using-oh-my-zsh)
  - [افزونه‌ها](#plugins)
    - [فعال‌سازی افزونه‌ها](#enabling-plugins)
    - [استفاده از افزونه‌ها](#using-plugins)
  - [قالب‌ها](#themes)
    - [انتخاب یک قالب](#selecting-a-theme)
  - [پرسش‌های متداول](#faq)
- [موضوعات پیشرفته](#advanced-topics)
  - [نصب پیشرفته](#advanced-installation)
    - [دایرکتوری سفارشی](#custom-directory)
    - [نصب بدون نظارت](#unattended-install)
    - [نصب از مخزن فورک شده](#installing-from-a-forked-repository)
    - [نصب دستی](#manual-installation)
  - [مشکلات نصب](#installation-problems)
  - [افزونه‌ها و قالب‌های سفارشی](#custom-plugins-and-themes)
  - [فعال‌سازی GNU ls در macOS و freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [رد کردن میانبرها](#skip-aliases)
  - [پرومت git غیرهمزمان](#async-git-prompt)
- [دریافت به‌روزرسانی‌ها](#getting-updates)
  - [سطح جزئیات به‌روزرسانی](#updates-verbosity)
  - [به‌روزرسانی دستی](#manual-updates)
- [حذف نصب Oh My Zsh](#uninstalling-oh-my-zsh)
- [چگونه در توسعه Oh My Zsh مشارکت کنم؟](#how-do-i-contribute-to-oh-my-zsh)
  - [برای ما قالب نفرستید](#do-not-send-us-themes)
- [مشارکت‌کنندگان](#contributors)
- [ما را دنبال کنید](#follow-us)
- [محصولات](#merchandise)
- [مجوز](#license)
- [درباره Planet Argon](#about-planet-argon)

</details>

## شروع به کار

### سازگاری با سیستم‌عامل

| سیستم‌عامل      | وضعیت |
| :------------- | :----: |
| اندروید         |   ✅   |
| freeBSD         |   ✅   |
| LCARS           |   🛸   |
| لینوکس          |   ✅   |
| macOS           |   ✅   |
| OS/2 Warp       |   ❌   |
| ویندوز (WSL2)   |   ✅   |

### پیش‌نیازها

- [Zsh](https://www.zsh.org) باید نصب باشد (نسخه ۴.۳.۹ یا جدیدتر کافی است اما ترجیحاً ۵.۰.۸ به بالا). اگر به‌صورت پیش‌فرض نصب نیست (با اجرای `zsh --version` بررسی کنید)، دستورالعمل‌ها را در اینجا ببینید: [نصب ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` یا `wget` باید نصب باشند
- `git` باید نصب باشد (نسخه پیشنهادی ۲.۴.۱۱ یا بالاتر)

### نصب پایه

Oh My Zsh با اجرای یکی از دستورات زیر در ترمینال شما نصب می‌شود. می‌توانید آن را با خط فرمان و با استفاده از `curl`، `wget` یا ابزار مشابه نصب کنید.

| روش     | دستور                                                                                           |
| :------ | :---------------------------------------------------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

همچنین نصب‌کننده خارج از GitHub نیز آینه شده است. در صورتی که در کشوری مانند چین یا هند هستید (برخی ISPها)، که `raw.githubusercontent.com` را مسدود می‌کنند، ممکن است نیاز باشد از این URL استفاده کنید:

| روش     | دستور                                           |
| :------ | :---------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_توجه داشته باشید که هر `.zshrc` قبلی به `.zshrc.pre-oh-my-zsh` تغییر نام می‌دهد. پس از نصب، می‌توانید تنظیماتی که می‌خواهید حفظ کنید را به `.zshrc` جدید منتقل کنید._

#### بازبینی دستی

خوب است که اسکریپت نصب پروژه‌هایی که هنوز نمی‌شناسید را بازبینی کنید. می‌توانید ابتدا اسکریپت نصب را دانلود کرده، بررسی کنید تا همه چیز عادی باشد، سپس آن را اجرا کنید:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

اگر URL بالا تایم‌اوت شد یا به هر دلیلی کار نکرد، می‌توانید URL را با `https://install.ohmyz.sh` جایگزین کنید تا اسکریپت را دریافت کنید.

## استفاده از Oh My Zsh

### افزونه‌ها

Oh My Zsh با حجم زیادی از افزونه‌ها عرضه می‌شود که می‌توانید از آن‌ها بهره ببرید. می‌توانید پوشه [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) و/یا [ویکی](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) را بررسی کنید تا ببینید چه افزونه‌هایی در دسترس است.

#### فعال‌سازی افزونه‌ها

پس از انتخاب افزونه (یا چند افزونه) مورد نظر خود برای استفاده با Oh My Zsh، باید آن‌ها را در فایل `.zshrc` فعال کنید. فایل zshrc را در مسیر `$HOME` خود پیدا خواهید کرد. با ویرایشگر متنی دلخواه آن را باز کنید و بخشی را برای لیست افزونه‌هایی که می‌خواهید بارگذاری شوند خواهید یافت.

```sh
vi ~/.zshrc
```

به‌عنوان مثال، ممکن است به شکل زیر باشد:

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

_توجه داشته باشید که افزونه‌ها با فاصله (space، tab، خط جدید و غیره) از هم جدا شده‌اند. **از کاما بین آن‌ها استفاده نکنید** زیرا باعث اختلال می‌شود._

#### استفاده از افزونه‌ها

هر افزونه داخلی دارای یک **README** است که مستندسازی شده است. این README باید میانبرها (در صورت افزودن) و امکانات اضافی هر افزونه را نمایش دهد.

### قالب‌ها

ما اعتراف می‌کنیم. اوایل دنیای Oh My Zsh کمی درگیر قالب‌ها شدیم. اکنون بیش از ۱۵۰ قالب همراه داریم. بیشتر آن‌ها دارای [تصاویر](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) در ویکی هستند (در حال به‌روزرسانی آن هستیم!). آن‌ها را بررسی کنید!

#### انتخاب یک قالب

_قالب Robby به‌صورت پیش‌فرض است. نه فانتزی‌ترین، نه ساده‌ترین؛ فقط مناسب اوست._

وقتی قالبی را یافتید که می‌خواهید استفاده کنید، باید فایل `~/.zshrc` را ویرایش کنید. یک متغیر محیطی (با حروف بزرگ) در آن خواهید دید که به شکل زیر است:

```sh
ZSH_THEME="robbyrussell"
```

برای استفاده از قالب دیگر، کافیست مقدار آن را به نام قالب موردنظر خود تغییر دهید. مثلاً:

```sh
ZSH_THEME="agnoster" # (این یکی از قالب‌های فانتزی است)
# ببینید https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> اغلب ممکن است اسکرین‌شاتی از یک قالب zsh ببینید، آن را امتحان کنید و متوجه شوید که برای شما شبیه همان نیست.
>
> دلیلش این است که بسیاری از قالب‌ها نیاز به نصب [Powerline Font](https://github.com/powerline/fonts) یا
> [Nerd Font](https://github.com/ryanoasis/nerd-fonts) دارند تا به‌درستی نمایش داده شوند. بدون آن‌ها، این قالب‌ها نمادهای عجیبی نمایش می‌دهند. برای اطلاعات بیشتر به
> [سوالات متداول](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) مراجعه کنید.
>
> همچنین توجه داشته باشید قالب‌ها فقط ظاهر خط فرمان شما را تغییر می‌دهند؛ یعنی متنی که قبل یا بعد از مکان‌نمای شما دیده می‌شود، جایی که دستورات خود را تایپ می‌کنید. قالب‌ها رنگ‌های پنجره ترمینال (موسوم به _طرح رنگ_) یا فونت ترمینال را کنترل نمی‌کنند. این تنظیمات را باید در شبیه‌ساز ترمینال خود تغییر دهید. برای اطلاعات بیشتر ببینید
> [یک قالب zsh چیست](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

یک پنجره ترمینال جدید باز کنید و باید خط فرمان شما شبیه چیزی مانند این شود:

![قالب Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

اگر قالب مناسبی برای نیاز خود پیدا نکردید، لطفاً ویکی را برای [موارد بیشتر](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) بررسی کنید.

اگر اهل هیجان هستید، می‌توانید اجازه دهید کامپیوتر هر بار به‌صورت تصادفی یک قالب برای شما انتخاب کند:

```sh
ZSH_THEME="random" # (...لطفاً پای باشد... لطفاً یکی پای باشد..)
```

و اگر می‌خواهید قالب تصادفی را از بین لیستی از قالب‌های محبوب خود انتخاب کنید:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

اگر فقط می‌دانید کدام قالب‌ها را دوست ندارید، می‌توانید آن‌ها را به لیست نادیده‌گرفته‌ها اضافه کنید:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### پرسش‌های متداول

اگر سؤالات یا مشکلات بیشتری دارید، ممکن است راه‌حل را در [پرسش‌های متداول](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ) پیدا کنید.

## موضوعات پیشرفته

اگر اهل کارهای پیشرفته هستید، این بخش‌ها مناسب شماست.

### نصب پیشرفته

برخی کاربران ممکن است بخواهند Oh My Zsh را به‌صورت دستی نصب کنند یا مسیر پیش‌فرض یا سایر تنظیمات قابل قبول نصب‌کننده را تغییر دهند (این تنظیمات در ابتدای اسکریپت نصب نیز مستند شده‌اند).

#### دایرکتوری سفارشی

محل پیش‌فرض `~/.oh-my-zsh` است (در پوشه خانه شما، با `cd ~/.oh-my-zsh` قابل دسترسی است)

اگر می‌خواهید مسیر نصب را با متغیر محیطی `ZSH` تغییر دهید، یا با اجرای
`export ZSH=/your/path` قبل از نصب، یا با تنظیم آن قبل از پایان خط نصب به‌صورت زیر:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### نصب بدون نظارت

اگر اسکریپت نصب Oh My Zsh را به‌عنوان بخشی از نصب خودکار اجرا می‌کنید، می‌توانید پارامتر
`--unattended` را به اسکریپت `install.sh` بدهید. این باعث می‌شود پوسته پیش‌فرض تغییر نکند و پس از پایان نصب نیز `zsh` اجرا نشود.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

اگر در چین، هند یا کشوری هستید که `raw.githubusercontent.com` را مسدود کرده، ممکن است لازم باشد URL را با `https://install.ohmyz.sh` جایگزین کنید.

#### نصب از مخزن فورک شده

اسکریپت نصب این متغیرها را می‌پذیرد تا نصب از مخزن دیگری را ممکن سازد:

- `REPO` (پیش‌فرض: `ohmyzsh/ohmyzsh`): به صورت `owner/repository`. اگر این متغیر را تنظیم کنید، نصب‌کننده مخزن را در `https://github.com/{owner}/{repository}` جستجو می‌کند.

- `REMOTE` (پیش‌فرض: `https://github.com/${REPO}.git`): آدرس کامل کلون مخزن git. اگر می‌خواهید از فورکی خارج از گیت‌هاب (مثلاً GitLab, Bitbucket) یا با SSH کلون کنید (`git@github.com:user/project.git`) از این تنظیم استفاده کنید.

  _توجه: این گزینه با تنظیم متغیر `REPO` ناسازگار است و اولویت دارد._

- `BRANCH` (پیش‌فرض: `master`): اگر می‌خواهید شاخه پیش‌فرض را هنگام کلون تغییر دهید (مثلاً برای تست pull request یا استفاده از شاخه‌ای غیر از master).

مثلاً:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### نصب دستی

##### ۱. کلون کردن مخزن <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### ۲. _در صورت تمایل_، پشتیبان‌گیری از فایل `~/.zshrc` موجود <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### ۳. ساخت فایل پیکربندی جدید Zsh <!-- omit in toc -->

می‌توانید با کپی کردن الگوی موجود، فایل پیکربندی جدید بسازید.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### ۴. تغییر پوسته پیش‌فرض <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

باید از نشست کاربری خود خارج و دوباره وارد شوید تا این تغییر اعمال شود.

##### ۵. راه‌اندازی پیکربندی جدید Zsh <!-- omit in toc -->

پس از باز کردن یک پنجره ترمینال جدید، باید zsh با پیکربندی Oh My Zsh بارگذاری شود.

### مشکلات نصب

اگر هنگام نصب مشکل داشتید، چند راه‌حل رایج:

- شاید لازم باشد متغیر `PATH` را در `~/.zshrc` تغییر دهید اگر برخی دستورات را پس از تغییر به oh-my-zsh پیدا نمی‌کنید.
- اگر به‌صورت دستی نصب کردید یا محل نصب را تغییر دادید، متغیر محیطی `ZSH` را در `~/.zshrc` بررسی کنید.

### افزونه‌ها و قالب‌های سفارشی

اگر می‌خواهید هر یک از رفتارهای پیش‌فرض را بازنویسی کنید، کافیست یک فایل جدید (با پسوند `.zsh`) در پوشه `custom/` اضافه کنید.

اگر چند تابع مرتبط دارید، می‌توانید آن‌ها را به‌صورت فایل `XYZ.plugin.zsh` در پوشه `custom/plugins/` قرار داده و سپس این افزونه را فعال کنید.

اگر می‌خواهید عملکرد افزونه‌ای که با Oh My Zsh توزیع شده را بازنویسی کنید، یک افزونه با همان نام در پوشه `custom/plugins/` بسازید تا بجای افزونه موجود بارگذاری شود.

### فعال‌سازی GNU ls در macOS و freeBSD

<a name="enable-gnu-ls"></a>

رفتار پیش‌فرض در Oh My Zsh استفاده از BSD `ls` در macOS و FreeBSD است. اگر GNU `ls` (به‌صورت دستور `gls`) نصب شده باشد، می‌توانید آن را انتخاب کنید. برای این کار، تنظیمات مبتنی بر zstyle را قبل از بارگذاری `oh-my-zsh.sh` اضافه کنید:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_توجه: این گزینه با `DISABLE_LS_COLORS=true` ناسازگار است_

### رد کردن میانبرها

<a name="remove-directories-aliases"></a>

اگر می‌خواهید میانبرهای پیش‌فرض Oh My Zsh (تعریف شده در فایل‌های `lib/*`) یا افزونه‌ها را رد کنید، می‌توانید تنظیمات زیر را در فایل `~/.zshrc`، **قبل از بارگذاری Oh My Zsh** اضافه کنید. راه‌های مختلفی برای رد کردن میانبرها وجود دارد که بستگی به نیاز شما دارد.

```sh
# رد همه میانبرها، هم در فایل‌های lib و هم افزونه‌های فعال
zstyle ':omz:*' aliases no

# رد همه میانبرها در فایل‌های lib
zstyle ':omz:lib:*' aliases no
# فقط رد میانبرهای تعریف‌شده در فایل lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# رد همه میانبرهای افزونه‌ها
zstyle ':omz:plugins:*' aliases no
# فقط رد میانبرهای افزونه git
zstyle ':omz:plugins:git' aliases no
```

می‌توانید این تنظیمات را به صورت ترکیبی و با اولویت دامنه خاص‌تر استفاده کنید:

```sh
# رد همه میانبرهای افزونه‌ها به جز git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

نسخه قبلی این ویژگی از تنظیم زیر استفاده می‌کرد که اکنون حذف شده است:

```sh
zstyle ':omz:directories' aliases no
```

اکنون می‌توانید از تنظیم زیر استفاده کنید:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### اطلاعیه <!-- omit in toc -->

> این ویژگی فعلاً در مرحله آزمایش است و ممکن است در آینده تغییر کند. همچنین فعلاً با مدیریت‌کننده‌های افزونه مانند zpm یا zinit که اسکریپت init (`oh-my-zsh.sh`) را بارگذاری نمی‌کنند، ناسازگار است.

> همچنین فعلاً نسبت به "میانبرهایی" که به‌صورت تابع تعریف شده‌اند آگاه نیست. مثال‌هایی مانند توابع `gccd`، `ggf` یا `ggl` در افزونه git.

### پرومت git غیرهمزمان

توابع پرومت غیرهمزمان یک ویژگی آزمایشی (از ۳ آوریل ۲۰۲۴) است که به Oh My Zsh اجازه می‌دهد اطلاعات پرومت را به‌صورت غیرهمزمان نمایش دهد. این ویژگی می‌تواند عملکرد نمایش پرومت را بهبود دهد، اما ممکن است با برخی تنظیمات ناسازگار باشد. امیدواریم مشکلی ایجاد نکند، اما اگر مشکلی مشاهده کردید، می‌توانید با افزودن تنظیم زیر در فایل .zshrc خود و قبل از بارگذاری Oh My Zsh آن را غیرفعال کنید:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

اگر مشکل شما این است که پرومت git دیگر نمایش داده نمی‌شود، می‌توانید با تنظیم زیر قبل از بارگذاری `oh-my-zsh.sh` آن را مجبور به نمایش کنید. اگر باز هم کار نکرد، لطفاً یک issue با توضیح مشکل خود باز کنید.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## دریافت به‌روزرسانی‌ها

به‌صورت پیش‌فرض، هر دو هفته یک‌بار برای بررسی به‌روزرسانی‌ها از شما سؤال می‌شود. می‌توانید حالت‌های دیگر را با افزودن یک خط به فایل `~/.zshrc` خود، **قبل از بارگذاری Oh My Zsh** انتخاب کنید:

1. به‌روزرسانی خودکار بدون درخواست تأیید:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. فقط یادآوری هر چند روز یک‌بار، در صورت وجود به‌روزرسانی:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. غیرفعال‌سازی کامل به‌روزرسانی خودکار:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

توجه: می‌توانید فاصله زمانی بررسی به‌روزرسانی را با تنظیم زیر کنترل کنید:

```sh
# این تنظیم هر ۷ روز به‌روزرسانی را بررسی می‌کند
zstyle ':omz:update' frequency 7
# این تنظیم هر بار باز شدن ترمینال (توصیه نمی‌شود) بررسی می‌کند
zstyle ':omz:update' frequency 0
```

### سطح جزئیات به‌روزرسانی

همچنین می‌توانید سطح جزئیات به‌روزرسانی را با تنظیمات زیر محدود کنید:

```sh
zstyle ':omz:update' verbose default # حالت پیش‌فرض

zstyle ':omz:update' verbose minimal # فقط چند خط

zstyle ':omz:update' verbose silent # فقط خطاها
```

### به‌روزرسانی دستی

اگر می‌خواهید در هر زمانی (مثلاً یک افزونه جدید منتشر شده و نمی‌خواهید یک هفته صبر کنید) به‌روزرسانی کنید، کافیست اجرا کنید:

```sh
omz update
```

> [!NOTE]
> اگر می‌خواهید این فرایند را در اسکریپت خودکار کنید، باید مستقیماً اسکریپت `upgrade` را اجرا کنید، مثلاً:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> گزینه‌های بیشتر را در [FAQ: چگونه Oh My Zsh را به‌روزرسانی کنم؟](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh) ببینید.
>
> **استفاده از `omz update --unattended` حذف شده است، زیرا عوارض جانبی دارد**.

جادو! 🎉

## حذف نصب Oh My Zsh

Oh My Zsh برای همه مناسب نیست. دلتنگ شما خواهیم شد، اما می‌خواهیم این جدایی آسان باشد.

اگر می‌خواهید `oh-my-zsh` را حذف کنید، کافیست از خط فرمان دستور `uninstall_oh_my_zsh` را اجرا کنید. این دستور خود را حذف و پیکربندی قبلی `bash` یا `zsh` شما را بازمی‌گرداند.

## چگونه در توسعه Oh My Zsh مشارکت کنم؟

قبل از مشارکت در این جامعه دوست‌داشتنی، لطفاً [قوانین رفتار](CODE_OF_CONDUCT.md) را بخوانید.

من هنوز متخصص [Zsh](https://www.zsh.org/) نیستم و مطمئنم راه‌های زیادی برای بهبود وجود دارد – اگر ایده‌ای برای آسان‌تر کردن نگهداری (و سریع‌تر شدن) پیکربندی دارید، تردید نکنید و فورک کنید و pull request بفرستید!

همچنین به افرادی نیاز داریم که pull requestها را تست کنند. پس [ایرادهای باز](https://github.com/ohmyzsh/ohmyzsh/issues) را ببینید و هر جا می‌توانید کمک کنید.

برای جزئیات بیشتر به [راهنمای مشارکت](CONTRIBUTING.md) مراجعه کنید.

### برای ما قالب نفرستید

فعلاً (بیش از) تعداد کافی قالب داریم. لطفاً قالب خود را به صفحه [قالب‌های خارجی](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) در ویکی اضافه کنید.

## مشارکت‌کنندگان

Oh My Zsh جامعه‌ای پرجنب‌وجوش از کاربران خوشحال و مشارکت‌کنندگان دوست‌داشتنی دارد. بدون تمام وقت و کمک مشارکت‌کنندگان، این پروژه چنین عالی نمی‌شد.

خیلی ممنونیم!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## ما را دنبال کنید

ما در شبکه‌های اجتماعی هستیم:

- [@ohmyzsh](https://x.com/ohmyzsh) در X (توییتر سابق). ما را دنبال کنید.
- [فیسبوک](https://www.facebook.com/Oh-My-Zsh-296616263819290/) ما را پیدا کنید.
- [اینستاگرام](https://www.instagram.com/_ohmyzsh/) ما را در پست‌های خود با Oh My Zsh تگ کنید!
- [Discord](https://discord.gg/ohmyzsh) برای گفتگو با ما!

## محصولات

ما [استیکر، تی‌شرت و ماگ قهوه](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) داریم تا علاقه خود به Oh My Zsh را نشان دهید. باز هم، نقل محافل خواهید شد!

## مجوز

Oh My Zsh تحت [مجوز MIT](LICENSE.txt) منتشر شده است.

## درباره Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh توسط تیم [Planet Argon](https://www.planetargon.com/?utm_source=github)، یک [آژانس توسعه Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github) آغاز شد.
سایر [پروژه‌های متن‌باز ما](https://www.planetargon.com/open-source?utm_source=github) را نیز ببینید.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---