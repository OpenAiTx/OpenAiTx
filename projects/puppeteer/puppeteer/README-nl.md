# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer is een JavaScript-bibliotheek die een high-level API biedt om
> Chrome of Firefox aan te sturen via het
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) of [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Puppeteer draait standaard in headless-modus (geen zichtbare UI).

## [Aan de slag](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Bijdragen](https://pptr.dev/contributing) | [Probleemoplossing](https://pptr.dev/troubleshooting)

## Installatie

```bash npm2yarn
npm i puppeteer # Downloadt compatibele Chrome tijdens installatie.
npm i puppeteer-core # Installeer eventueel als een bibliotheek, zonder Chrome te downloaden.
```

## Voorbeeld

```ts
import puppeteer from 'puppeteer';
// Of importeer puppeteer van 'puppeteer-core';

// Start de browser en open een nieuwe lege pagina
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Navigeer de pagina naar een URL.
await page.goto('https://developer.chrome.com/');

// Stel schermgrootte in.
await page.setViewport({width: 1080, height: 1024});

// Typ in het zoekvak met behulp van toegankelijke invoernaam.
await page.locator('aria/Search').fill('automate beyond recorder');

// Wacht en klik op het eerste resultaat.
await page.locator('.devsite-result-item-link').click();

// Zoek de volledige titel met een unieke string.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Print de volledige titel.
console.log('De titel van deze blogpost is "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---