<a href="https://excalidraw.com/" target="_blank" rel="noopener">
  <picture>
    <source media="(prefers-color-scheme: dark)" alt="Excalidraw" srcset="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2_dark.png" />
    <img alt="Excalidraw" src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2.png" />
  </picture>
</a>

<h4 align="center">
  <a href="https://excalidraw.com">ویرایشگر Excalidraw</a> |
  <a href="https://plus.excalidraw.com/blog">وبلاگ</a> |
  <a href="https://docs.excalidraw.com">مستندات</a> |
  <a href="https://plus.excalidraw.com">Excalidraw+</a>
</h4>

<div align="center">
  <h2>
    وایت‌برد مجازی متن‌باز با سبک دست‌نویس. </br>
    مشارکتی و رمزگذاری‌شده سرتاسری. </br>
  <br />
  </h2>
</div>

<br />
<p align="center">
  <a href="https://github.com/excalidraw/excalidraw/blob/master/LICENSE">
    <img alt="Excalidraw تحت مجوز MIT منتشر شده است." src="https://img.shields.io/badge/license-MIT-blue.svg"  />
  </a>
  <a href="https://www.npmjs.com/package/@excalidraw/excalidraw">
    <img alt="دانلود npm در ماه" src="https://img.shields.io/npm/dm/@excalidraw/excalidraw"  />
  </a>
  <a href="https://docs.excalidraw.com/docs/introduction/contributing">
    <img alt="درخواست‌های Pull پذیرفته می‌شود!" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"  />
  </a>
  <a href="https://discord.gg/UexuTaE">
    <img alt="گفتگو در Discord" src="https://img.shields.io/discord/723672430744174682?color=738ad6&label=Chat%20on%20Discord&logo=discord&logoColor=ffffff&widge=false"/>
  </a>
  <a href="https://deepwiki.com/excalidraw/excalidraw">
    <img alt="پرسش از DeepWiki" src="https://deepwiki.com/badge.svg" />
  </a>
  <a href="https://twitter.com/excalidraw">
    <img alt="دنبال کردن Excalidraw در توییتر" src="https://img.shields.io/twitter/follow/excalidraw.svg?label=follow+@excalidraw&style=social&logo=twitter"/>
  </a>
</p>

<div align="center">
  <figure>
    <a href="https://excalidraw.com" target="_blank" rel="noopener">
      <img src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github%2Fproduct_showcase.png" alt="نمایش محصول" />
    </a>
    <figcaption>
      <p align="center">
        نمودارها، وایرفریم‌ها یا هر چیزی که دوست دارید را با ظاهری دست‌نویس و زیبا رسم کنید.
      </p>
    </figcaption>
  </figure>
</div>

## ویژگی‌ها

ویرایشگر Excalidraw (پکیج npm) از امکانات زیر پشتیبانی می‌کند:

- 💯&nbsp;رایگان و متن‌باز.
- 🎨&nbsp;وایت‌برد بی‌نهایت مبتنی بر بوم (canvas).
- ✍️&nbsp;سبک شبیه دست‌نویس.
- 🌓&nbsp;حالت تیره.
- 🏗️&nbsp;قابل سفارشی‌سازی.
- 📷&nbsp;پشتیبانی از تصویر.
- 😀&nbsp;پشتیبانی از کتابخانه‌های اشکال.
- 🌐&nbsp;پشتیبانی از بومی‌سازی (i18n).
- 🖼️&nbsp;خروجی به PNG، SVG و کلیپ‌بورد.
- 💾&nbsp;فرمت باز - خروجی نقاشی به صورت فایل json با پسوند `.excalidraw`.
- ⚒️&nbsp;ابزارهای متنوع - مستطیل، دایره، لوزی، پیکان، خط، رسم آزاد، پاک‌کن و...
- ➡️&nbsp;اتصال پیکان‌ها و پیکان‌های دارای برچسب.
- 🔙&nbsp;واگرد (undo) / تکرار (redo).
- 🔍&nbsp;پشتیبانی از بزرگ‌نمایی و جابه‌جایی (pan).

## Excalidraw.com

برنامه‌ی میزبانی‌شده در [excalidraw.com](https://excalidraw.com) نمونه‌ای ساده از آنچه با Excalidraw می‌توانید بسازید است. [کد منبع](https://github.com/excalidraw/excalidraw/tree/master/excalidraw-app) این برنامه نیز بخشی از این مخزن است و این ویژگی‌ها را دارد:

- 📡&nbsp;پشتیبانی از PWA (قابل استفاده آفلاین).
- 🤼&nbsp;همکاری همزمان (Real-time).
- 🔒&nbsp;رمزگذاری سرتاسری.
- 💾&nbsp;ذخیره‌سازی محلی (به طور خودکار در مرورگر ذخیره می‌شود).
- 🔗&nbsp;پیوندهای قابل اشتراک‌گذاری (خروجی به پیوند فقط خواندنی برای به اشتراک‌گذاری با دیگران).

در آینده این ویژگی‌ها را به صورت افزونه‌های قابل نصب برای پکیج npm ارائه خواهیم داد.

## شروع سریع

**نکته:** دستورالعمل‌های زیر برای نصب [پکیج npm](https://www.npmjs.com/package/@excalidraw/excalidraw) Excalidraw هنگام یکپارچه‌سازی با برنامه‌ی شما است. برای اجرای مخزن به صورت محلی جهت توسعه، لطفاً به [راهنمای توسعه](https://docs.excalidraw.com/docs/introduction/development) مراجعه کنید.

برای نصب پکیج از `npm` یا `yarn` استفاده کنید.

```bash
npm install react react-dom @excalidraw/excalidraw
# یا
yarn add react react-dom @excalidraw/excalidraw
```

برای اطلاعات بیشتر به [مستندات](https://docs.excalidraw.com/docs/@excalidraw/excalidraw/installation) ما مراجعه کنید!

## مشارکت

- چیزی کم است یا باگ پیدا کردید؟ [اینجا گزارش دهید](https://github.com/excalidraw/excalidraw/issues).
- مایل به مشارکت هستید؟ [راهنمای مشارکت](https://docs.excalidraw.com/docs/introduction/contributing) ما را ببینید یا در [Discord](https://discord.gg/UexuTaE) به ما اطلاع دهید.
- می‌خواهید در ترجمه‌ها کمک کنید؟ [راهنمای ترجمه](https://docs.excalidraw.com/docs/introduction/contributing#translating) را ببینید.

## یکپارچه‌سازی‌ها

- [افزونه VScode](https://marketplace.visualstudio.com/items?itemName=pomdtr.excalidraw-editor)
- [پکیج npm](https://www.npmjs.com/package/@excalidraw/excalidraw)

## چه کسانی Excalidraw را یکپارچه کرده‌اند

[Google Cloud](https://googlecloudcheatsheet.withgoogle.com/architecture) • [Meta](https://meta.com/) • [CodeSandbox](https://codesandbox.io/) • [Obsidian Excalidraw](https://github.com/zsviczian/obsidian-excalidraw-plugin) • [Replit](https://replit.com/) • [Slite](https://slite.com/) • [Notion](https://notion.so/) • [HackerRank](https://www.hackerrank.com/) • و بسیاری دیگر

## حامیان و پشتیبانی

اگر پروژه را دوست دارید، می‌توانید در [Open Collective](https://opencollective.com/excalidraw) حامی شوید یا از [Excalidraw+](https://plus.excalidraw.com/) استفاده کنید.

## سپاس از حمایت شما از Excalidraw

[<img src="https://opencollective.com/excalidraw/tiers/sponsors/0/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/0/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/1/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/1/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/2/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/2/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/3/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/3/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/4/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/4/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/5/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/5/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/6/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/6/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/7/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/7/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/8/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/8/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/9/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/9/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/10/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/10/website)

<a href="https://opencollective.com/excalidraw#category-CONTRIBUTE" target="_blank"><img src="https://opencollective.com/excalidraw/tiers/backers.svg?avatarHeight=32"/></a>

در آخر، ما از این شرکت‌ها که خدمات خود را به صورت رایگان ارائه می‌دهند سپاسگزاریم:

[![Vercel](./.github/assets/vercel.svg)](https://vercel.com) [![Sentry](./.github/assets/sentry.svg)](https://sentry.io) [![Crowdin](./.github/assets/crowdin.svg)](https://crowdin.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---