# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer는 [DevTools 프로토콜](https://chromedevtools.github.io/devtools-protocol/) 또는 [WebDriver BiDi](https://pptr.dev/webdriver-bidi)를 통해 Chrome 또는 Firefox를 제어할 수 있는
> 고수준 API를 제공하는 JavaScript 라이브러리입니다.
> Puppeteer는 기본적으로 헤드리스(화면 UI 없이)로 실행됩니다.

## [시작하기](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [FAQ](https://pptr.dev/faq) | [기여하기](https://pptr.dev/contributing) | [문제 해결](https://pptr.dev/troubleshooting)

## 설치

```bash npm2yarn
npm i puppeteer # 설치 시 호환되는 Chrome을 다운로드합니다.
npm i puppeteer-core # 또는 라이브러리로만 설치하며, Chrome은 다운로드하지 않습니다.
```

## 예제

```ts
import puppeteer from 'puppeteer';
// 또는 import puppeteer from 'puppeteer-core';

// 브라우저를 실행하고 새 빈 페이지를 엽니다.
const browser = await puppeteer.launch();
const page = await browser.newPage();

// 페이지를 특정 URL로 이동시킵니다.
await page.goto('https://developer.chrome.com/');

// 화면 크기 설정.
await page.setViewport({width: 1080, height: 1024});

// 접근 가능한 입력 이름을 사용하여 검색창에 입력합니다.
await page.locator('aria/Search').fill('automate beyond recorder');

// 잠시 기다렸다가 첫 번째 결과를 클릭합니다.
await page.locator('.devsite-result-item-link').click();

// 고유한 문자열로 전체 제목을 찾습니다.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// 전체 제목을 출력합니다.
console.log('이 블로그 게시물의 제목은 "%s"입니다.', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---