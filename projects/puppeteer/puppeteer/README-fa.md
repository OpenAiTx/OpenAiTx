# پوپیتیر

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> پوپیتیر یک کتابخانه جاوااسکریپت است که یک API سطح بالا برای کنترل
> کروم یا فایرفاکس از طریق
> [پروتکل DevTools](https://chromedevtools.github.io/devtools-protocol/) یا [WebDriver BiDi](https://pptr.dev/webdriver-bidi) فراهم می‌کند.
> پوپیتیر به طور پیش‌فرض در حالت headless (بدون رابط کاربری قابل مشاهده) اجرا می‌شود.

## [شروع کنید](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [سوالات متداول](https://pptr.dev/faq) | [مشارکت در توسعه](https://pptr.dev/contributing) | [رفع اشکال](https://pptr.dev/troubleshooting)

## نصب

```bash npm2yarn
npm i puppeteer # دانلود کروم سازگار در هنگام نصب.
npm i puppeteer-core # به صورت کتابخانه‌ای نصب کنید، بدون دانلود کروم.
```

## مثال

```ts
import puppeteer from 'puppeteer';
// یا import puppeteer from 'puppeteer-core';

// مرورگر را اجرا کرده و یک صفحه خالی جدید باز کنید
const browser = await puppeteer.launch();
const page = await browser.newPage();

// صفحه را به یک آدرس URL هدایت کنید.
await page.goto('https://developer.chrome.com/');

// اندازه صفحه نمایش را تنظیم کنید.
await page.setViewport({width: 1080, height: 1024});

// در جعبه جستجو با استفاده از نام ورودی قابل دسترس تایپ کنید.
await page.locator('aria/Search').fill('automate beyond recorder');

// منتظر بمانید و روی اولین نتیجه کلیک کنید.
await page.locator('.devsite-result-item-link').click();

// عنوان کامل را با یک رشته یکتا بیابید.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// عنوان کامل این پست وبلاگ را چاپ کنید.
console.log('عنوان این پست وبلاگ "%s" است.', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---