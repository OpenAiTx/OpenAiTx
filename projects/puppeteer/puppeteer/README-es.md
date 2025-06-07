# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer es una biblioteca de JavaScript que proporciona una API de alto nivel para controlar
> Chrome o Firefox a través del
> [Protocolo DevTools](https://chromedevtools.github.io/devtools-protocol/) o [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Puppeteer se ejecuta en modo headless (sin interfaz gráfica visible) por defecto.

## [Comenzar](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [Preguntas Frecuentes](https://pptr.dev/faq) | [Contribuir](https://pptr.dev/contributing) | [Solución de Problemas](https://pptr.dev/troubleshooting)

## Instalación

```bash npm2yarn
npm i puppeteer # Descarga Chrome compatible durante la instalación.
npm i puppeteer-core # Alternativamente, instálalo como biblioteca, sin descargar Chrome.
```

## Ejemplo

```ts
import puppeteer from 'puppeteer';
// O importa puppeteer desde 'puppeteer-core';

// Lanza el navegador y abre una nueva página en blanco
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Navega la página a una URL.
await page.goto('https://developer.chrome.com/');

// Establece el tamaño de la pantalla.
await page.setViewport({width: 1080, height: 1024});

// Escribe en la caja de búsqueda usando el nombre accesible del input.
await page.locator('aria/Search').fill('automate beyond recorder');

// Espera y haz clic en el primer resultado.
await page.locator('.devsite-result-item-link').click();

// Localiza el título completo con una cadena única.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Imprime el título completo.
console.log('El título de esta publicación de blog es "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---