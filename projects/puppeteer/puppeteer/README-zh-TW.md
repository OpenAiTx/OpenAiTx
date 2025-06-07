# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer 是一個 JavaScript 函式庫，提供高階 API 來控制
> Chrome 或 Firefox，透過
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) 或 [WebDriver BiDi](https://pptr.dev/webdriver-bidi)。
> Puppeteer 預設以無頭模式（無可見 UI）運行

## [快速開始](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [常見問題](https://pptr.dev/faq) | [貢獻指南](https://pptr.dev/contributing) | [疑難排解](https://pptr.dev/troubleshooting)

## 安裝

```bash npm2yarn
npm i puppeteer # 安裝時會下載相容的 Chrome。
npm i puppeteer-core # 或者，作為函式庫安裝，不下載 Chrome。
```

## 範例

```ts
import puppeteer from 'puppeteer';
// 或者 import puppeteer from 'puppeteer-core';

// 啟動瀏覽器並開啟一個新的空白頁面
const browser = await puppeteer.launch();
const page = await browser.newPage();

// 導航到指定網址
await page.goto('https://developer.chrome.com/');

// 設定螢幕尺寸
await page.setViewport({width: 1080, height: 1024});

// 使用可存取的輸入名稱在搜尋框輸入
await page.locator('aria/Search').fill('automate beyond recorder');

// 等待並點擊第一個搜尋結果
await page.locator('.devsite-result-item-link').click();

// 以唯一字串定位完整標題
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// 輸出完整標題
console.log('這篇部落格文章的標題是「%s」。', fullTitle);

await browser.close();
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---