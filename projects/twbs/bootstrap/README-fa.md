<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">بوت‌استرپ</h3>

<p align="center">
  چارچوب فرانت‌اند شیک، شهودی و قدرتمند برای توسعه وب سریع‌تر و آسان‌تر.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>مستندات بوت‌استرپ را مرور کنید »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">گزارش باگ</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">درخواست ویژگی</a>
  ·
  <a href="https://themes.getbootstrap.com/">پوسته‌ها</a>
  ·
  <a href="https://blog.getbootstrap.com/">وبلاگ</a>
</p>


## بوت‌استرپ ۵

شاخه پیش‌فرض ما برای توسعه نسخه بوت‌استرپ ۵ است. برای مشاهده فایل readme، مستندات و کد منبع بوت‌استرپ ۴ به [شاخه `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) مراجعه کنید.


## فهرست مطالب

- [شروع سریع](#quick-start)
- [وضعیت](#status)
- [محتویات شامل شده](#whats-included)
- [باگ‌ها و درخواست ویژگی](#bugs-and-feature-requests)
- [مستندات](#documentation)
- [مشارکت](#contributing)
- [جامعه](#community)
- [نسخه‌بندی](#versioning)
- [سازندگان](#creators)
- [تشکر](#thanks)
- [کپی‌رایت و مجوز](#copyright-and-license)


## شروع سریع

چندین گزینه برای شروع سریع موجود است:

- [آخرین نسخه را دانلود کنید](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- مخزن را کلون کنید: `git clone https://github.com/twbs/bootstrap.git`
- نصب با [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- نصب با [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- نصب با [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- نصب با [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- نصب با [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

برای اطلاعات بیشتر درباره محتویات چارچوب، قالب‌ها، نمونه‌ها و غیره، [صفحه شروع کار](https://getbootstrap.com/docs/5.3/getting-started/introduction/) را بخوانید.


## وضعیت

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## محتویات شامل شده

در فایل دانلود شده، پوشه‌ها و فایل‌های زیر را خواهید یافت که دارایی‌های رایج را گروه‌بندی کرده و نسخه‌های کامپایل و کمینه‌شده را ارائه می‌دهند.

<details>
  <summary>محتویات دانلود</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

ما CSS و JS کامپایل شده (`bootstrap.*`) و همچنین CSS و JS کامپایل و کمینه‌شده (`bootstrap.min.*`) را ارائه می‌دهیم. [سورس‌مپ‌ها](https://web.dev/articles/source-maps) (`bootstrap.*.map`) برای استفاده با ابزار توسعه برخی مرورگرها در دسترس هستند. فایل‌های JS باندل شده (`bootstrap.bundle.js` و نسخه کمینه‌شده‌ی `bootstrap.bundle.min.js`) شامل [Popper](https://popper.js.org/docs/v2/) هستند.


## باگ‌ها و درخواست ویژگی

آیا باگ یا درخواست ویژگی دارید؟ لطفاً ابتدا [راهنمای مسائل](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) را بخوانید و به دنبال مسائل باز و بسته‌شده بگردید. اگر مشکل یا ایده شما هنوز مطرح نشده است، [لطفاً یک مسئله جدید باز کنید](https://github.com/twbs/bootstrap/issues/new/choose).


## مستندات

مستندات بوت‌استرپ، که در ریشه این مخزن قرار دارد، با [Astro](https://astro.build/) ساخته شده و به صورت عمومی در GitHub Pages در <https://getbootstrap.com/> میزبانی می‌شود. مستندات را می‌توانید به صورت محلی نیز اجرا کنید.

جستجوی مستندات توسط [DocSearch الگولیا](https://docsearch.algolia.com/) تامین می‌شود.

### اجرای مستندات به صورت محلی

1. دستور `npm install` را اجرا کنید تا وابستگی‌های Node.js، از جمله Astro (سایت‌ساز)، نصب شوند.
2. دستور `npm run test` (یا اسکریپت npm خاص) را اجرا کنید تا فایل‌های CSS و جاوااسکریپت توزیع شده و همچنین دارایی‌های مستندات ما دوباره ساخته شوند.
3. از دایرکتوری ریشه `/bootstrap`، دستور `npm run docs-serve` را در خط فرمان اجرا کنید.
4. در مرورگر خود آدرس `http://localhost:9001/` را باز کنید.

برای اطلاعات بیشتر درباره استفاده از Astro، [مستندات آن](https://docs.astro.build/en/getting-started/) را بخوانید.

### مستندات نسخه‌های قبلی

تمام مستندات نسخه‌های قبلی را می‌توانید در <https://getbootstrap.com/docs/versions/> بیابید.

[نسخه‌های قبلی](https://github.com/twbs/bootstrap/releases) و مستندات آن‌ها نیز برای دانلود در دسترس هستند.


## مشارکت

لطفاً [راهنمای مشارکت](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) ما را به طور کامل بخوانید. در این راهنما، دستورالعمل‌هایی برای باز کردن مسائل، استانداردهای کدنویسی و نکاتی درباره توسعه آورده شده است.

همچنین، اگر pull request شما شامل تغییرات یا ویژگی‌های JavaScript است، باید [تست‌های واحد مرتبط](https://github.com/twbs/bootstrap/tree/main/js/tests) را نیز اضافه کنید. تمام HTML و CSS باید مطابق [راهنمای کد](https://github.com/mdo/code-guide) که توسط [Mark Otto](https://github.com/mdo) نگهداری می‌شود، باشد.

ترجیحات ویرایشگر در [پیکربندی ویرایشگر](https://github.com/twbs/bootstrap/blob/main/.editorconfig) برای استفاده آسان در ویرایشگرهای متن رایج موجود است. برای اطلاعات بیشتر و دانلود افزونه‌ها به <https://editorconfig.org/> مراجعه کنید.


## جامعه

اخبار توسعه بوت‌استرپ را دریافت کنید و با نگهدارندگان پروژه و اعضای جامعه گفتگو کنید.

- دنبال کنید [@getbootstrap در X](https://x.com/getbootstrap).
- بخوانید و مشترک شوید در [وبلاگ رسمی بوت‌استرپ](https://blog.getbootstrap.com/).
- پرسش بپرسید و [بحث‌های گیت‌هاب ما](https://github.com/twbs/bootstrap/discussions) را مرور کنید.
- بحث کنید، پرسش بپرسید و غیره در [دیسکورد جامعه](https://discord.gg/bZUvakRU3M) یا [ساب‌ردیت بوت‌استرپ](https://www.reddit.com/r/bootstrap/).
- با سایر بوت‌استرپرها در IRC گفتگو کنید. در سرور `irc.libera.chat`، کانال `#bootstrap`.
- کمک در پیاده‌سازی را در Stack Overflow بیابید (برچسب [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- توسعه‌دهندگان باید از کلیدواژه `bootstrap` برای بسته‌هایی که قابلیت‌های بوت‌استرپ را تغییر می‌دهند یا گسترش می‌دهند، هنگام توزیع از طریق [npm](https://www.npmjs.com/browse/keyword/bootstrap) یا مکانیزم‌های مشابه، جهت پیدا شدن بهتر استفاده کنند.


## نسخه‌بندی

برای شفافیت در چرخه انتشار و تلاش برای حفظ سازگاری به عقب، بوت‌استرپ تحت [راهنمای نسخه‌بندی معنایی](https://semver.org/) نگهداری می‌شود. گاهی خطا می‌کنیم، اما تا حد امکان به این قوانین پایبندیم.

برای مشاهده تغییرات هر نسخه بوت‌استرپ به [بخش Releases پروژه در گیت‌هاب](https://github.com/twbs/bootstrap/releases) مراجعه کنید. اطلاعیه‌های انتشار در [وبلاگ رسمی بوت‌استرپ](https://blog.getbootstrap.com/) خلاصه‌ای از مهم‌ترین تغییرات هر نسخه را دارند.


## سازندگان

**مارک اوتو**

- <https://x.com/mdo>
- <https://github.com/mdo>

**جیکوب تورنتون**

- <https://x.com/fat>
- <https://github.com/fat>


## تشکر

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

از [BrowserStack](https://www.browserstack.com/) برای فراهم کردن زیرساختی که امکان تست در مرورگرهای واقعی را به ما می‌دهد تشکر می‌کنیم!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

از [Netlify](https://www.netlify.com/) برای فراهم کردن Deploy Previewها تشکر می‌کنیم!


## اسپانسرها

با اسپانسر شدن از این پروژه حمایت کنید. لوگوی شما اینجا با لینک به وب‌سایتتان نمایش داده می‌شود. [[اسپانسر شوید](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## حامیان

از همه حامیان ما سپاسگزاریم! 🙏 [[حامی شوید](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## کپی‌رایت و مجوز

کد و مستندات متعلق به سال‌های ۲۰۱۱-۲۰۲۵ [نویسندگان بوت‌استرپ](https://github.com/twbs/bootstrap/graphs/contributors) است. کد تحت [مجوز MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE) منتشر شده است. مستندات تحت [Creative Commons](https://creativecommons.org/licenses/by/3.0/) منتشر شده‌اند.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---