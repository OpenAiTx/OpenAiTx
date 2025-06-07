# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer to biblioteka JavaScript, która udostępnia wysokopoziomowe API do sterowania
> Chrome lub Firefox za pomocą
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) lub [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Domyślnie Puppeteer działa w trybie bezgłowym (bez widocznego interfejsu użytkownika)

## [Rozpocznij](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [Współtworzenie](https://pptr.dev/contributing) | [Rozwiązywanie problemów](https://pptr.dev/troubleshooting)

## Instalacja

```bash npm2yarn
npm i puppeteer # Podczas instalacji pobierana jest kompatybilna wersja Chrome.
npm i puppeteer-core # Alternatywnie, zainstaluj jako bibliotekę, bez pobierania Chrome.
```

## Przykład

```ts
import puppeteer from 'puppeteer';
// Lub import puppeteer from 'puppeteer-core';

// Uruchom przeglądarkę i otwórz nową, pustą stronę
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Przejdź na wskazany adres URL.
await page.goto('https://developer.chrome.com/');

// Ustaw rozmiar ekranu.
await page.setViewport({width: 1080, height: 1024});

// Wpisz w polu wyszukiwania, korzystając z dostępnej nazwy input.
await page.locator('aria/Search').fill('automate beyond recorder');

// Zaczekaj i kliknij pierwszy wynik.
await page.locator('.devsite-result-item-link').click();

// Zlokalizuj pełny tytuł przy użyciu unikalnego ciągu znaków.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// Wyświetl pełny tytuł.
console.log('Tytuł tego wpisu na blogu to "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---