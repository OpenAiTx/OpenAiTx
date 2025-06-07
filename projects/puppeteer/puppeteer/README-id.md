# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer adalah pustaka JavaScript yang menyediakan API tingkat tinggi untuk mengendalikan
> Chrome atau Firefox melalui
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) atau [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Secara default, Puppeteer berjalan dalam mode headless (tanpa tampilan antarmuka pengguna)

## [Mulai](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Kontribusi](https://pptr.dev/contributing) | [Pemecahan Masalah](https://pptr.dev/troubleshooting)

## Instalasi

```bash npm2yarn
npm i puppeteer # Mengunduh Chrome yang kompatibel selama instalasi.
npm i puppeteer-core # Atau, instal sebagai pustaka tanpa mengunduh Chrome.
```

## Contoh

```ts
import puppeteer from 'puppeteer';
// Atau import puppeteer dari 'puppeteer-core';

// Luncurkan browser dan buka halaman kosong baru
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Arahkan halaman ke sebuah URL.
await page.goto('https://developer.chrome.com/');

// Atur ukuran layar.
await page.setViewport({width: 1080, height: 1024});

// Ketik di kotak pencarian menggunakan nama input yang dapat diakses.
await page.locator('aria/Search').fill('automate beyond recorder');

// Tunggu dan klik pada hasil pertama.
await page.locator('.devsite-result-item-link').click();

// Temukan judul lengkap dengan string unik.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Cetak judul lengkap.
console.log('Judul dari posting blog ini adalah "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---