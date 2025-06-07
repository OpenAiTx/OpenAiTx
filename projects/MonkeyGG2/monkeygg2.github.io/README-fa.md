<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">سایت بازی دوستانه محله شما.</p>
<br>

به MonkeyGG2 خوش آمدید، یک سایت بازی با امکانات فراوان که برای شما ساخته شده است! با بیش از ۱۵۰ بازی برای انتخاب، MonkeyGG2 تجربه‌ای منحصربه‌فرد و قابل شخصی‌سازی ارائه می‌دهد. چه یک گیمر باشید، چه توسعه‌دهنده یا کاربر عادی، MonkeyGG2 محیطی بدون نقص و لذت‌بخش برای بازی فراهم می‌کند.

> لطفاً به ما یک ستاره بدهید! مخصوصاً اگر این مخزن را fork کرده‌اید یا استفاده دیگری از آن برده‌اید.

## ویژگی‌ها

-   بیش از ۱۵۰ بازی
-   استفاده آسان
-   استقرار آسان
-   قابل شخصی‌سازی
-   پراکسی
-   و موارد بیشتر...

## شخصی‌سازی

### تنظیمات

#### Cloaking (پنهان‌سازی)

پنهان‌سازی به باز کردن صفحه در یک تب `about:blank` اشاره دارد. این رفتار به طور پیش‌فرض فعال است، هرچند می‌توانید آن را غیرفعال کنید. پیش‌تنظیم‌هایی برای لینک ریدایرکت وجود دارد اما می‌توانید آن را به صورت دستی نیز تنظیم کنید.

#### Masking (ماسک‌گذاری)

ماسک‌گذاری به تغییر آیکون و عنوان تب about:blank اشاره دارد. پیش‌تنظیم‌هایی برای آیکون و عنوان تب وجود دارد اما می‌توانید آن‌ها را به صورت دستی نیز تنظیم کنید.

#### کلیدهای میانبر

می‌توانید کلیدهای میانبر سفارشی برای انجام وظایف مختلف بسازید. برای مثال، خروج از بازی، ماسک‌گذاری تب و اجرای جاوااسکریپت سفارشی همگی پشتیبانی می‌شوند.
> توجه: اگر می‌خواهید جاوااسکریپت سفارشی اجرا کنید، مطمئن شوید که می‌دانید چه می‌کنید. اگر چیزی خراب شد، بارگذاری مجدد صفحه همیشه راه‌حل است.

#### تم

سفارشی‌سازی‌های تم فعلاً شامل موارد زیر است:
- فعال/غیرفعال کردن انیمیشن پس‌زمینه (اگر نگران عملکرد وسط بازی هستید، نگران نباشید به طور خودکار هنگام بازی غیرفعال می‌شود)
- رنگ پس‌زمینه
- رنگ بلوک
- رنگ دکمه
- رنگ بازی‌ها
- رنگ هاور
- رنگ اسکرول‌بار
- رنگ ترک اسکرول
- رنگ فونت

> توجه: اگر به طور تصادفی رنگ‌ها را طوری تغییر دهید که سایت غیرقابل استفاده شود، باید کوکی‌ها و حافظه محلی خود را پاک کنید.

### شخصی‌سازی پیشرفته

> سلب مسئولیت: شخصی‌سازی‌های زیر تنها برای مالکان مخزن یا هر fork از این مخزن در دسترس است.

فایل `config.jsonc` برای پیکربندی کل سایت قالب‌بندی شده است. در حال حاضر موارد زیر پشتیبانی می‌شوند:
- بازی‌ها
- تم‌ها (به‌زودی)
- پیکربندی پراکسی

#### بازی‌ها

هر ورودی بازی یک کلید به عنوان نام نمایشی بازی دارد و مقدار آن باید یک شی با سه جفت کلید-مقدار باشد:
- `"path"`: مسیر بازی از دایرکتوری `./games`
- `"aliases"`: لیست نام‌های جایگزین بازی برای بهبود جستجو
- `"categories"`: لیست دسته‌هایی که بازی در آن قرار می‌گیرد (پشتیبانی از افزودن آیکون به‌زودی)

افزودن ورودی به صورت دستی ممکن است اما به‌ویژه اگر بخواهید لیست را به صورت الفبایی مرتب کنید، خسته‌کننده است (برای عملکرد پیکربندی الزامی نیست!)
به همین دلیل اسکریپت `add-game-entry.js` ساخته شده است تا افزودن بازی جدید به پیکربندی را بدون ویرایش دستی فایل آسان کند.

```bash
# می‌توانید از هر محیط اجرایی جاوااسکریپت مثل node.js, bun یا deno استفاده کنید
# برای این نمایش از bun استفاده می‌شود چون وابستگی‌ها را به طور خودکار نصب می‌کند
bun add-game-script.js
# به پرسش‌های نمایش‌داده‌شده پاسخ دهید و پیکربندی به‌روزرسانی می‌شود
```

#### تم‌ها

استاندارد تم هنوز پیاده‌سازی نشده است (در دست انجام)

#### پراکسی

گزینه‌های پیکربندی پراکسی تحت کلید **"config"** قرار دارند. 
مقدار کلید `"proxy"` یک مقدار بولی است که فعال یا غیرفعال بودن عملکرد پراکسی را تعیین می‌کند. اگر `"proxy"` روی false باشد، هنگام تلاش برای دسترسی به پراکسی، کاربر با یک پنجره خطا مواجه می‌شود.
مقدار کلید `"proxyPath"` مسیر پراکسی است. این مسیر می‌تواند مطلق یا نسبی باشد اما پراکسی باید از **CORS** پشتیبانی کند زیرا صفحه پراکسی به صورت iframe در سایت نمایش داده می‌شود.

## استقرار

### بدون پراکسی

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

همچنین می‌توانید این مخزن را در [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) یا [Codeberg](https://codeberg.org/MonkeyGG2/pages) fork کرده و به ترتیب در GitHub Pages یا Codeberg Pages مستقر کنید.

### با پراکسی

برای اطلاعات بیشتر درباره میزبانی MonkeyGG2 با پراکسی، به صفحه [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) مراجعه کنید.

### اجرای محلی

```bash
# هشدار: اگر پوشه‌ای به نام "monkeygg2" دارید، این فرمان همه فایل‌های داخل آن پوشه را حذف خواهد کرد
# لطفاً نام دایرکتوری را در دو فرمان زیر تغییر دهید
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# از اینجا می‌توانید از هر ابزاری برای اجرای سرور استاتیک استفاده کنید، در اینجا "live-server" از npm استفاده می‌شود
npm install -g live-server # فقط اگر قبلاً نصب نکرده‌اید
npx live-server
```

## مجوز

براساس مجوز WTFPL توزیع شده است. برای جزئیات بیشتر [اینجا](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) را ببینید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---