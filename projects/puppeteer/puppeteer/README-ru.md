# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer — это библиотека JavaScript, предоставляющая высокоуровневый API для управления
> Chrome или Firefox через
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) или [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> По умолчанию Puppeteer работает в безголовом режиме (без видимого интерфейса пользователя).

## [Начало работы](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Вклад в проект](https://pptr.dev/contributing) | [Устранение неполадок](https://pptr.dev/troubleshooting)

## Установка

```bash npm2yarn
npm i puppeteer # Загружает совместимый Chrome во время установки.
npm i puppeteer-core # Альтернативно, установка только библиотеки без загрузки Chrome.
```

## Пример

```ts
import puppeteer from 'puppeteer';
// Или import puppeteer from 'puppeteer-core';

// Запустить браузер и открыть новую пустую страницу
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Перейти на страницу по указанному URL.
await page.goto('https://developer.chrome.com/');

// Установить размер экрана.
await page.setViewport({width: 1080, height: 1024});

// Ввести в поисковое поле, используя доступное имя ввода.
await page.locator('aria/Search').fill('automate beyond recorder');

// Подождать и кликнуть по первой найденной ссылке.
await page.locator('.devsite-result-item-link').click();

// Найти полный заголовок с уникальной строкой.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Вывести полный заголовок.
console.log('Заголовок этой записи в блоге: "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---