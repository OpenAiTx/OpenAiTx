# पपेटियर

[![build](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/puppeteer/puppeteer/actions/workflows/ci.yml)
[![npm puppeteer package](https://img.shields.io/npm/v/puppeteer.svg)](https://npmjs.org/package/puppeteer)

<img src="https://user-images.githubusercontent.com/10379601/29446482-04f7036a-841f-11e7-9872-91d1fc2ea683.png" height="200" align="right"/>

> पपेटियर एक जावास्क्रिप्ट लाइब्रेरी है जो क्रोम या फायरफॉक्स को नियंत्रित करने के लिए उच्च-स्तरीय एपीआई प्रदान करती है
> [DevTools प्रोटोकॉल](https://chromedevtools.github.io/devtools-protocol/) या [WebDriver BiDi](https://pptr.dev/webdriver-bidi) के माध्यम से।
> पपेटियर डिफ़ॉल्ट रूप से हेडलेस (कोई दृश्यमान UI नहीं) मोड में चलता है।

## [शुरू करें](https://pptr.dev/docs) | [एपीआई](https://pptr.dev/api) | [सामान्य प्रश्न](https://pptr.dev/faq) | [योगदान करें](https://pptr.dev/contributing) | [समस्या निवारण](https://pptr.dev/troubleshooting)

## स्थापना

```bash npm2yarn
npm i puppeteer # इंस्टॉलेशन के दौरान उपयुक्त Chrome डाउनलोड करता है।
npm i puppeteer-core # वैकल्पिक रूप से, केवल लाइब्रेरी इंस्टॉल करें, Chrome डाउनलोड किए बिना।
```

## उदाहरण

```ts
import puppeteer from 'puppeteer';
// या import puppeteer from 'puppeteer-core';

// ब्राउज़र लॉन्च करें और एक नया खाली पेज खोलें
const browser = await puppeteer.launch();
const page = await browser.newPage();

// पेज को किसी URL पर नेविगेट करें।
await page.goto('https://developer.chrome.com/');

// स्क्रीन का आकार सेट करें।
await page.setViewport({width: 1080, height: 1024});

// एक्सेसिबल इनपुट नाम का उपयोग करके सर्च बॉक्स में टाइप करें।
await page.locator('aria/Search').fill('automate beyond recorder');

// प्रतीक्षा करें और पहले परिणाम पर क्लिक करें।
await page.locator('.devsite-result-item-link').click();

// एक अद्वितीय स्ट्रिंग के साथ पूर्ण शीर्षक खोजें।
const textSelector = await page
  .locator('text/Customize and automate')
  .waitHandle();
const fullTitle = await textSelector?.evaluate(el => el.textContent);

// पूर्ण शीर्षक प्रिंट करें।
console.log('इस ब्लॉग पोस्ट का शीर्षक है "%s".', fullTitle);

await browser.close();
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---