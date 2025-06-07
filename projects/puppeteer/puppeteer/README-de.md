# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer ist eine JavaScript-Bibliothek, die eine High-Level-API zur Steuerung von
> Chrome oder Firefox über das
> [DevTools-Protokoll](https://chromedevtools.github.io/devtools-protocol/) oder [WebDriver BiDi](https://pptr.dev/webdriver-bidi) bereitstellt.
> Standardmäßig läuft Puppeteer im Headless-Modus (ohne sichtbare Benutzeroberfläche).

## [Erste Schritte](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Mitwirken](https://pptr.dev/contributing) | [Fehlerbehebung](https://pptr.dev/troubleshooting)

## Installation

```bash npm2yarn
npm i puppeteer # Lädt kompatiblen Chrome während der Installation herunter.
npm i puppeteer-core # Alternativ als Bibliothek installieren, ohne Chrome herunterzuladen.
```

## Beispiel

```ts
import puppeteer from 'puppeteer';
// Oder import puppeteer from 'puppeteer-core';

// Startet den Browser und öffnet eine neue leere Seite
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Navigiert die Seite zu einer URL.
await page.goto('https://developer.chrome.com/');

// Setzt die Bildschirmgröße.
await page.setViewport({width: 1080, height: 1024});

// Tippt in das Suchfeld unter Verwendung des barrierefreien Eingabenamens.
await page.locator('aria/Search').fill('automate beyond recorder');

// Warten und auf das erste Ergebnis klicken.
await page.locator('.devsite-result-item-link').click();

// Findet den vollständigen Titel mit einer eindeutigen Zeichenkette.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Gibt den vollständigen Titel aus.
console.log('Der Titel dieses Blogbeitrags ist "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---