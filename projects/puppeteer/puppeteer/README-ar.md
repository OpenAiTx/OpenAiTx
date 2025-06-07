# بابيتير

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> بابيتير عبارة عن مكتبة جافاسكريبت توفر واجهة برمجة تطبيقات عالية المستوى للتحكم في
> كروم أو فايرفوكس عبر
> [بروتوكول أدوات المطورين](https://chromedevtools.github.io/devtools-protocol/) أو [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> يعمل بابيتير بشكل افتراضي بوضع الرأسية (بدون واجهة مرئية)

## [ابدأ](https://pptr.dev/docs) | [واجهة البرمجة](https://pptr.dev/api) | [الأسئلة الشائعة](https://pptr.dev/faq) | [المساهمة](https://pptr.dev/contributing) | [استكشاف الأخطاء وإصلاحها](https://pptr.dev/troubleshooting)

## التثبيت

```bash npm2yarn
npm i puppeteer # يقوم بتنزيل إصدار كروم متوافق أثناء التثبيت.
npm i puppeteer-core # أو بدلاً من ذلك، تثبيته كمكتبة فقط دون تنزيل كروم.
```

## مثال

```ts
import puppeteer from 'puppeteer';
// أو import puppeteer from 'puppeteer-core';

// تشغيل المتصفح وفتح صفحة جديدة فارغة
const browser = await puppeteer.launch();
const page = await browser.newPage();

// الانتقال إلى عنوان URL.
await page.goto('https://developer.chrome.com/');

// ضبط حجم الشاشة.
await page.setViewport({width: 1080, height: 1024});

// الكتابة في مربع البحث باستخدام اسم الإدخال القابل للوصول.
await page.locator('aria/Search').fill('automate beyond recorder');

// الانتظار والنقر على أول نتيجة.
await page.locator('.devsite-result-item-link').click();

// تحديد العنوان الكامل باستخدام نص فريد.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// طباعة العنوان الكامل.
console.log('عنوان منشور المدونة هذا هو "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---