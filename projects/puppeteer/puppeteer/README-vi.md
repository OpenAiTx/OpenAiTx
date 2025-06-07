# Puppeteer

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> Puppeteer là một thư viện JavaScript cung cấp API cấp cao để điều khiển
> Chrome hoặc Firefox thông qua
> [DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) hoặc [WebDriver BiDi](https://pptr.dev/webdriver-bidi).
> Puppeteer mặc định chạy ở chế độ headless (không có giao diện người dùng hiển thị)

## [Bắt đầu](https://pptr.dev/docs) | [API](https://pptr.dev/api) | [Câu hỏi thường gặp](https://pptr.dev/faq) | [Đóng góp](https://pptr.dev/contributing) | [Khắc phục sự cố](https://pptr.dev/troubleshooting)

## Cài đặt

```bash npm2yarn
npm i puppeteer # Tải về Chrome tương thích trong quá trình cài đặt.
npm i puppeteer-core # Hoặc, cài đặt như một thư viện mà không tải về Chrome.
```

## Ví dụ

```ts
import puppeteer from 'puppeteer';
// Hoặc import puppeteer from 'puppeteer-core';

// Khởi động trình duyệt và mở một trang trắng mới
const browser = await puppeteer.launch();
const page = await browser.newPage();

// Điều hướng trang đến một URL.
await page.goto('https://developer.chrome.com/');

// Đặt kích thước màn hình.
await page.setViewport({width: 1080, height: 1024});

// Gõ vào ô tìm kiếm bằng tên input truy cập được.
await page.locator('aria/Search').fill('automate beyond recorder');

// Chờ và nhấp vào kết quả đầu tiên.
await page.locator('.devsite-result-item-link').click();

// Xác định tiêu đề đầy đủ bằng chuỗi duy nhất.
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// In ra tiêu đề đầy đủ.
console.log('Tiêu đề của bài viết blog này là "%s".', fullTitle);

await browser.close();
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---