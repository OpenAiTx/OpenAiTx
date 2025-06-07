# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer เป็นไลบรารี JavaScript ที่ให้ API ระดับสูงสำหรับควบคุม
> Chrome หรือ Firefox ผ่าน
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) หรือ [WebDriver BiDi](https://pptr.dev/webdriver-bidi)
> โดย Puppeteer จะทำงานในโหมด headless (ไม่มี UI ปรากฏ) ตามค่าเริ่มต้น

## [เริ่มต้นใช้งาน](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [คำถามที่พบบ่อย](https://pptr.dev/faq) | [การมีส่วนร่วม](https://pptr.dev/contributing) | [การแก้ไขปัญหา](https://pptr.dev/troubleshooting)

## การติดตั้ง

```bash npm2yarn
npm i puppeteer # ดาวน์โหลด Chrome ที่เข้ากันได้ระหว่างการติดตั้ง
npm i puppeteer-core # หรือ ติดตั้งเป็นไลบรารีโดยไม่ต้องดาวน์โหลด Chrome
```

## ตัวอย่าง

```ts
import puppeteer from 'puppeteer';
// หรือ import puppeteer from 'puppeteer-core';

// เปิดเบราว์เซอร์และเปิดหน้าเปล่าใหม่
const browser = await puppeteer.launch();
const page = await browser.newPage();

// นำทางไปยัง URL ที่ต้องการ
await page.goto('https://developer.chrome.com/');

// กำหนดขนาดหน้าจอ
await page.setViewport({width: 1080, height: 1024});

// พิมพ์ในกล่องค้นหาโดยใช้ชื่อ input ที่เข้าถึงได้
await page.locator('aria/Search').fill('automate beyond recorder');

// รอและคลิกที่ผลลัพธ์แรก
await page.locator('.devsite-result-item-link').click();

// ค้นหาชื่อเต็มด้วยสตริงที่ไม่ซ้ำกัน
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// แสดงชื่อเต็มของโพสต์บล็อกนี้
console.log('ชื่อของโพสต์บล็อกนี้คือ "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---