[![لوگوی Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![وضعیت ساخت GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![دعوت به دیسکورد Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: ترجمه‌های موجود: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
برای مشاهده این مستندات به زبان‌های دیگر به پروژه [Crowdin](https://crowdin.com/project/electron) ما مراجعه کنید.

فریم‌ورک Electron به شما اجازه می‌دهد برنامه‌های دسکتاپ چندسکویی را با استفاده از JavaScript، HTML و CSS بنویسید. این فریم‌ورک بر پایه [Node.js](https://nodejs.org/) و [Chromium](https://www.chromium.org) ساخته شده و توسط [Visual Studio Code](https://github.com/Microsoft/vscode/) و بسیاری از [برنامه‌های دیگر](https://electronjs.org/apps) استفاده می‌شود.

برای اطلاعیه‌های مهم، [@electronjs](https://twitter.com/electronjs) را در توییتر دنبال کنید.

این پروژه از میثاق مشارکت‌کنندگان [code of conduct](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) پیروی می‌کند. با مشارکت در این پروژه، انتظار می‌رود که این کد را رعایت کنید. لطفاً رفتارهای غیرقابل قبول را به [coc@electronjs.org](mailto:coc@electronjs.org) گزارش دهید.

## نصب

برای نصب باینری‌های از پیش ساخته شده Electron، از [`npm`](https://docs.npmjs.com/) استفاده کنید.
روش پیشنهادی نصب Electron به عنوان یک وابستگی توسعه‌ای در برنامه شماست:

```sh
npm install electron --save-dev
```

برای گزینه‌های بیشتر نصب و نکات رفع اشکال، به [نصب](docs/tutorial/installation.md) مراجعه کنید. برای اطلاعات درباره مدیریت نسخه‌های Electron در برنامه‌های خود، به [نسخه‌بندی Electron](docs/tutorial/electron-versioning.md) مراجعه کنید.

## پشتیبانی از سکوها

هر نسخه Electron باینری‌هایی برای macOS، ویندوز و لینوکس ارائه می‌دهد.

* macOS (Big Sur و بالاتر): Electron باینری‌های ۶۴ بیتی برای Intel و Apple Silicon / ARM برای macOS ارائه می‌کند.
* ویندوز (ویندوز 10 و بالاتر): Electron باینری‌های `ia32` (`x86`)، `x64` (`amd64`) و `arm64` را برای ویندوز ارائه می‌دهد. پشتیبانی از Windows on ARM در Electron 5.0.8 اضافه شد. پشتیبانی از ویندوز ۷، ۸ و ۸.۱ [در Electron 23 حذف شد، مطابق با سیاست حذف پشتیبانی ویندوز در Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* لینوکس: باینری‌های از پیش ساخته شده Electron بر روی Ubuntu 20.04 ساخته می‌شوند. همچنین تأیید شده که روی موارد زیر کار می‌کنند:
  * Ubuntu 18.04 و بالاتر
  * Fedora 32 و بالاتر
  * Debian 10 و بالاتر

## Electron Fiddle

از [`Electron Fiddle`](https://github.com/electron/fiddle) برای ساخت، اجرا و بسته‌بندی آزمایش‌های کوچک Electron، مشاهده نمونه کد برای تمام APIهای Electron و امتحان نسخه‌های مختلف Electron استفاده کنید. این ابزار برای ساده‌تر کردن شروع کار با Electron طراحی شده است.

## منابع آموزش Electron

* [electronjs.org/docs](https://electronjs.org/docs) - تمام مستندات Electron
* [electron/fiddle](https://github.com/electron/fiddle) - ابزاری برای ساخت، اجرا و بسته‌بندی آزمایش‌های کوچک Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - برنامه‌های نمونه شروع که توسط جامعه ساخته شده‌اند

## استفاده برنامه‌نویسی

اکثر افراد Electron را از طریق خط فرمان استفاده می‌کنند، اما اگر به `electron` در **برنامه Node** خود (نه برنامه Electron) نیاز داشته باشید، مسیر فایل باینری را بازمی‌گرداند. از این قابلیت برای اجرای Electron از اسکریپت‌های Node استفاده کنید:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// چیزی مشابه /Users/maf/.../Electron چاپ می‌کند
console.log(electron)

// اجرای Electron
const child = proc.spawn(electron)
```

### آینه‌ها

* [چین](https://npmmirror.com/mirrors/electron/)

برای یادگیری نحوه استفاده از آینه سفارشی، به [دستورالعمل‌های پیشرفته نصب](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) مراجعه کنید.

## ترجمه مستندات

ما ترجمه‌های مستندات خود را از طریق [Crowdin](https://crowdin.com/project/electron) به صورت جمع‌سپاری انجام می‌دهیم.
در حال حاضر ترجمه‌های چینی (ساده‌شده)، فرانسوی، آلمانی، ژاپنی، پرتغالی، روسی و اسپانیایی پذیرفته می‌شود.

## مشارکت

اگر علاقمند به گزارش/رفع اشکال‌ها و مشارکت مستقیم در کد هستید، لطفاً برای اطلاعات بیشتر درباره آنچه به دنبال آن هستیم و نحوه شروع، [CONTRIBUTING.md](CONTRIBUTING.md) را مشاهده کنید.

## جامعه

اطلاعات مربوط به گزارش باگ، دریافت کمک، یافتن ابزارهای شخص ثالث و برنامه‌های نمونه و موارد بیشتر را می‌توانید در [صفحه جامعه](https://www.electronjs.org/community) پیدا کنید.

## مجوز

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

هنگام استفاده از لوگوهای Electron، مطمئن شوید که [سیاست علائم تجاری OpenJS Foundation](https://trademark-policy.openjsf.org/) را رعایت می‌کنید.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---