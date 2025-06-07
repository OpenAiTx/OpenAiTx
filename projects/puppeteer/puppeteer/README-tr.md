# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer, Chrome veya Firefox'u
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) veya [WebDriver BiDi](https://pptr.dev/webdriver-bidi)
> üzerinden kontrol etmek için yüksek seviyeli bir API sunan bir JavaScript kütüphanesidir.
> Puppeteer varsayılan olarak başsız (görünür bir arayüz olmadan) çalışır.

## [Başlarken](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [SSS](https://pptr.dev/faq) | [Katkıda Bulunma](https://pptr.dev/contributing) | [Sorun Giderme](https://pptr.dev/troubleshooting)

## Kurulum

```bash npm2yarn
npm i puppeteer # Kurulum sırasında uyumlu Chrome'u indirir.
npm i puppeteer-core # Alternatif olarak, sadece kütüphane olarak kurar, Chrome indirmez.
```

## Örnek

```ts
import puppeteer from 'puppeteer';
// Ya da import puppeteer from 'puppeteer-core';

// Tarayıcıyı başlatın ve yeni bir boş sayfa açın
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Sayfayı bir URL'ye yönlendirin.
await page.goto('https://developer.chrome.com/');

// Ekran boyutunu ayarlayın.
await page.setViewport({width: 1080, height: 1024});

// Erişilebilir giriş adı kullanarak arama kutusuna yazı yazın.
await page.locator('aria/Search').fill('otomasyonu kaydedicinin ötesine taşı');

// İlk sonuca bekleyin ve tıklayın.
await page.locator('.devsite-result-item-link').click();

// Eşsiz bir dize ile tam başlığı bulun.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Tam başlığı yazdırın.
console.log('Bu blog yazısının başlığı "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---