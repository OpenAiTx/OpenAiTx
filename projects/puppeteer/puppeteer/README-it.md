# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer è una libreria JavaScript che fornisce un'API di alto livello per controllare
> Chrome o Firefox tramite il
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) o [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Per impostazione predefinita, Puppeteer viene eseguito in modalità headless (senza interfaccia utente visibile)

## [Inizia](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Contribuire](https://pptr.dev/contributing) | [Risoluzione dei problemi](https://pptr.dev/troubleshooting)

## Installazione

```bash npm2yarn
npm i puppeteer # Scarica Chrome compatibile durante l'installazione.
npm i puppeteer-core # In alternativa, installa come libreria senza scaricare Chrome.
```

## Esempio

```ts
import puppeteer from 'puppeteer';
// Oppure import puppeteer from 'puppeteer-core';

// Avvia il browser e apri una nuova pagina vuota
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Naviga la pagina verso un URL.
await page.goto('https://developer.chrome.com/');

// Imposta la dimensione dello schermo.
await page.setViewport({width: 1080, height: 1024});

// Digita nella casella di ricerca usando il nome accessibile dell'input.
await page.locator('aria/Search').fill('automate beyond recorder');

// Attendi e clicca sul primo risultato.
await page.locator('.devsite-result-item-link').click();

// Trova il titolo completo con una stringa unica.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Stampa il titolo completo.
console.log('Il titolo di questo post del blog è "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---