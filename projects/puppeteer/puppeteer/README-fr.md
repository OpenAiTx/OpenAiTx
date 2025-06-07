# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer est une bibliothèque JavaScript qui fournit une API de haut niveau pour contrôler
> Chrome ou Firefox via le
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) ou [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Par défaut, Puppeteer s'exécute en mode headless (sans interface utilisateur visible).

## [Commencer](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Contribuer](https://pptr.dev/contributing) | [Dépannage](https://pptr.dev/troubleshooting)

## Installation

```bash npm2yarn
npm i puppeteer # Télécharge Chrome compatible lors de l'installation.
npm i puppeteer-core # Ou bien, installer comme une bibliothèque sans télécharger Chrome.
```

## Exemple

```ts
import puppeteer from 'puppeteer';
// Ou import puppeteer from 'puppeteer-core';

// Lance le navigateur et ouvre une nouvelle page vierge
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Navigue vers une URL.
await page.goto('https://developer.chrome.com/');

// Définit la taille de l'écran.
await page.setViewport({width: 1080, height: 1024});

// Tape dans la barre de recherche en utilisant le nom accessible de l'entrée.
await page.locator('aria/Search').fill('automate beyond recorder');

// Attend et clique sur le premier résultat.
await page.locator('.devsite-result-item-link').click();

// Localise le titre complet avec une chaîne unique.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Affiche le titre complet.
console.log('Le titre de cet article de blog est "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---