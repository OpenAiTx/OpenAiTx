# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteerは、[DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) または [WebDriver BiDi](https://pptr.dev/webdriver-bidi) を介して
> ChromeやFirefoxを制御するための高水準APIを提供するJavaScriptライブラリです。
> Puppeteerはデフォルトでヘッドレス（UIなし）で動作します。

## [はじめに](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [コントリビュート方法](https://pptr.dev/contributing) | [トラブルシューティング](https://pptr.dev/troubleshooting)

## インストール

```bash npm2yarn
npm i puppeteer # インストール時に互換性のあるChromeをダウンロードします。
npm i puppeteer-core # もしくは、Chromeをダウンロードせずライブラリとしてインストールします。
```

## サンプル

```ts
import puppeteer from 'puppeteer';
// または import puppeteer from 'puppeteer-core';

// ブラウザを起動し、新しい空白ページを開く
const browser = await puppeteer.launch();
const page = await browser.newPage();

// ページを指定したURLに遷移
await page.goto('https://developer.chrome.com/');

// 画面サイズを設定
await page.setViewport({width: 1080, height: 1024});

// アクセシブルな入力名を使って検索ボックスに入力
await page.locator('aria/Search').fill('automate beyond recorder');

// 最初の結果が表示されるまで待機し、クリック
await page.locator('.devsite-result-item-link').click();

// 一意な文字列で完全なタイトルを取得
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// 完全なタイトルを出力
console.log('このブログ記事のタイトルは「%s」です。', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---