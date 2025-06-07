# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer é uma biblioteca JavaScript que fornece uma API de alto nível para controlar
> o Chrome ou Firefox através do
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) ou [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> O Puppeteer roda em modo headless (sem interface gráfica visível) por padrão.

## [Comece agora](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Contribuindo](https://pptr.dev/contributing) | [Resolução de problemas](https://pptr.dev/troubleshooting)

## Instalação

```bash npm2yarn
npm i puppeteer # Baixa o Chrome compatível durante a instalação.
npm i puppeteer-core # Alternativamente, instale como biblioteca, sem baixar o Chrome.
```

## Exemplo

```ts
import puppeteer from 'puppeteer';
// Ou import puppeteer from 'puppeteer-core';

// Inicie o navegador e abra uma nova página em branco
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Navegue até uma URL.
await page.goto('https://developer.chrome.com/');

// Defina o tamanho da tela.
await page.setViewport({width: 1080, height: 1024});

// Digite na caixa de pesquisa usando o nome acessível do campo.
await page.locator('aria/Search').fill('automate beyond recorder');

// Aguarde e clique no primeiro resultado.
await page.locator('.devsite-result-item-link').click();

// Localize o título completo com uma string única.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Imprima o título completo.
console.log('O título deste post do blog é "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---