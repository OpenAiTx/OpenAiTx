# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

یک API بهتر برای fetch. قابل استفاده در Node، مرورگر و Workerها.

<details>
  <summary>اسپویلر</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 شروع سریع

نصب:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

ایمپورت:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ سازگار با Node.js

ما از [صادرات شرطی](https://nodejs.org/api/packages.html#packages_conditional_exports) برای شناسایی Node.js
و استفاده خودکار از [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) بهره می‌بریم. اگر `globalThis.fetch` در دسترس باشد، استفاده خواهد شد. برای استفاده از API اصلی fetch آزمایشی در Node.js 17.5.0 به بالا از فلگ [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch) استفاده کنید.

## ✔️ تجزیه پاسخ

`ofetch` به صورت هوشمند با استفاده از [destr](https://github.com/unjs/destr) داده‌های JSON و مقادیر بومی را تجزیه می‌کند و در صورت شکست، به متن خام بازمی‌گردد.

```js
const { users } = await ofetch("/api/users");
```

برای انواع محتوای باینری، `ofetch` به جای آن یک شیء `Blob` بازمی‌گرداند.

شما می‌توانید یک parser متفاوت به جز `destr` ارائه دهید، یا با تعیین مقدار `blob`، `arrayBuffer` یا `text`، تجزیه بدنه را با متد مربوط به `FetchResponse` اجبار کنید.

```js
// استفاده از JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// بازگرداندن متن به همان صورت
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// دریافت نسخه blob از پاسخ
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ بدنه JSON

اگر یک شیء یا کلاسی با متد `.toJSON()` به گزینه `body` ارسال شود، `ofetch` به صورت خودکار آن را رشته‌ای می‌کند.

`ofetch` از `JSON.stringify()` برای تبدیل شیء ارسالی استفاده می‌کند. کلاس‌هایی که متد `.toJSON()` ندارند باید قبل از ارسال به گزینه `body` به صورت رشته تبدیل شوند.

برای متدهای `PUT`، `PATCH` و `POST`، زمانی که بدنه‌ای از نوع رشته یا شیء تنظیم شود، `ofetch` به صورت پیش‌فرض headerهای `content-type: "application/json"` و `accept: "application/json"` را اضافه می‌کند (که همیشه می‌توانید آن‌ها را بازنویسی کنید).

علاوه بر این، `ofetch` پاسخ‌های باینری با `Buffer`، `ReadableStream`، `Stream` و [انواع بدنه سازگار](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body) را پشتیبانی می‌کند. `ofetch` به صورت خودکار گزینه `duplex: "half"` را برای پشتیبانی از استریم فعال می‌کند!

**مثال:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ مدیریت خطاها

`ofetch` به صورت خودکار زمانی که مقدار `response.ok` برابر false باشد، خطا را با یک پیام کاربرپسند و stack فشرده (بدون نشان دادن جزئیات داخلی) پرتاب می‌کند.

بدنه خطا به صورت تجزیه‌شده با `error.data` در دسترس است. همچنین می‌توانید از نوع `FetchError` استفاده کنید.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

برای گرفتن پاسخ خطا:

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

برای جلوگیری از گرفتن خطای وضعیت، می‌توانید گزینه `ignoreResponseError` را تنظیم کنید:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ تلاش مجدد خودکار (Auto Retry)

`ofetch` به صورت خودکار اگر خطایی رخ دهد و اگر کد وضعیت پاسخ در لیست `retryStatusCodes` باشد، درخواست را مجدداً تلاش می‌کند:

**کدهای وضعیت تلاش مجدد:**

- `408` - پایان مهلت درخواست (Request Timeout)
- `409` - تداخل (Conflict)
- `425` - خیلی زود (Too Early) ([تجربی](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - درخواست‌های بیش از حد (Too Many Requests)
- `500` - خطای داخلی سرور (Internal Server Error)
- `502` - دروازه بد (Bad Gateway)
- `503` - سرویس در دسترس نیست (Service Unavailable)
- `504` - پایان مهلت دروازه (Gateway Timeout)

شما می‌توانید تعداد تلاش مجدد و تاخیر بین آن‌ها را با استفاده از گزینه‌های `retry` و `retryDelay` مشخص کنید و همچنین یک آرایه سفارشی از کدها را با استفاده از گزینه `retryStatusCodes` ارسال نمایید.

مقدار پیش‌فرض برای `retry`، یک بار تلاش مجدد است، به جز برای متدهای `POST`، `PUT`، `PATCH` و `DELETE` که به صورت پیش‌فرض `ofetch` تلاشی برای جلوگیری از بروز عوارض جانبی انجام نمی‌دهد. اگر مقدار سفارشی برای `retry` تنظیم کنید، **همیشه برای همه درخواست‌ها تلاش مجدد خواهد کرد**.

مقدار پیش‌فرض `retryDelay`، صفر میلی‌ثانیه است.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // میلی‌ثانیه
  retryStatusCodes: [ 404, 500 ], // کدهای وضعیت پاسخ برای تلاش مجدد
});
```

## ✔️ زمان‌سنجی (Timeout)

شما می‌توانید `timeout` را بر حسب میلی‌ثانیه مشخص کنید تا پس از پایان مهلت، درخواست به صورت خودکار لغو شود (به صورت پیش‌فرض غیرفعال است).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // پایان مهلت پس از ۳ ثانیه
});
```

## ✔️ سازگاری با نوع (Type Friendly)

پاسخ می‌تواند از کمک نوعی بهره‌مند شود:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// تکمیل خودکار برای کار با article.id فعال است
```

## ✔️ افزودن `baseURL`

با استفاده از گزینه `baseURL`، `ofetch` آن را برای اسلش‌های پایانی/ابتدایی و پارامترهای جستجوی کوئری برای baseURL با استفاده از [ufo](https://github.com/unjs/ufo) اضافه می‌کند:

```js
await ofetch("/config", { baseURL });
```

## ✔️ افزودن پارامترهای جستجوی کوئری

با استفاده از گزینه `query` (یا `params` به عنوان نام مستعار)، `ofetch` پارامترهای جستجوی کوئری را به URL اضافه می‌کند و کوئری موجود در خود درخواست را با استفاده از [ufo](https://github.com/unjs/ufo) حفظ می‌کند:

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ اینترسپتور‌ها (Interceptors)

ارائه اینترسپتورهای ناهمگام برای اتصال به رویدادهای چرخه عمر فراخوانی `ofetch` ممکن است.

شاید بخواهید از `ofetch.create` برای تنظیم اینترسپتورهای مشترک استفاده کنید.

### `onRequest({ request, options })`

`onRequest` بلافاصله پس از فراخوانی `ofetch` اجرا می‌شود و به شما اجازه می‌دهد گزینه‌ها را تغییر دهید یا لاگ‌برداری ساده انجام دهید.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // لاگ‌برداری درخواست
    console.log("[fetch request]", request, options);

    // افزودن `?t=1640125211170` به پارامترهای جستجوی کوئری
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` زمانی فراخوانی می‌شود که درخواست fetch شکست بخورد.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // ثبت خطا
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` پس از فراخوانی `fetch` و تجزیه بدنه فراخوانی می‌شود.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // ثبت پاسخ
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` مشابه `onResponse` است اما زمانی فراخوانی می‌شود که درخواست fetch انجام شده اما `response.ok` برابر با `true` نباشد.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // ثبت خطا
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### ارسال آرایه‌ای از اینترسپتور‌ها

در صورت نیاز، امکان ارسال آرایه‌ای از توابع که به صورت ترتیبی فراخوانی می‌شوند نیز وجود دارد.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* انجام کاری */
    },
    () => {
      /* انجام کار دیگر */
    },
  ],
});
```

## ✔️ ایجاد fetch با گزینه‌های پیش‌فرض

این ابزار زمانی مفید است که نیاز به استفاده از گزینه‌های مشترک در چندین فراخوانی fetch داشته باشید.

**توجه:** مقادیر پیش‌فرض در یک سطح کپی و به ارث برده می‌شوند. مراقب گزینه‌های تو در تو مانند `headers` باشید.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // معادل ofetch('/test', { baseURL: '/api' })
```

## 💡 افزودن هدرها

با استفاده از گزینه‌ی `headers`، `ofetch` هدرهای اضافی را علاوه بر هدرهای پیش‌فرض درخواست اضافه می‌کند:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 دسترسی به پاسخ خام

در صورتی که نیاز به دسترسی به پاسخ خام (برای هدرها و غیره) دارید، می‌توانید از `ofetch.raw` استفاده کنید:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 استفاده از Fetch بومی

به عنوان یک میانبر، می‌توانید از `ofetch.native` استفاده کنید که API بومی `fetch` را فراهم می‌کند.

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ افزودن HTTP(S) Agent

در محیط‌های Node.js (نسخه ۱۸ به بالا)، می‌توانید یک دیسپچر سفارشی برای رهگیری درخواست‌ها و پشتیبانی از ویژگی‌هایی مانند پروکسی و گواهی‌های خودامضا شده فراهم کنید. این قابلیت توسط [undici](https://undici.nodejs.org/) به صورت داخلی در Node.js فعال است. [بیشتر بخوانید](https://undici.nodejs.org/#/docs/api/Dispatcher) درباره API دیسپچر.

برخی agentهای موجود:

- `ProxyAgent`: یک کلاس Proxy Agent که API مربوط به Agent را پیاده‌سازی می‌کند. این امکان را می‌دهد تا ارتباط به‌سادگی از طریق پروکسی انجام شود. ([مستندات](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: یک کلاس Agent شبیه‌سازی‌شده که API مربوط به Agent را پیاده‌سازی می‌کند. این امکان را فراهم می‌کند تا درخواست‌های HTTP انجام شده از طریق undici را رهگیری کرده و پاسخ‌های شبیه‌سازی‌شده بازگردانید. ([مستندات](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent اجازه ارسال درخواست به چندین origin مختلف را می‌دهد. ([مستندات](https://undici.nodejs.org/#/docs/api/Agent))

**مثال:** تنظیم یک پروکسی agent برای یک درخواست:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**مثال:** ساخت یک instance سفارشی fetch با پروکسی فعال:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**مثال:** تنظیم پروکسی agent برای همه درخواست‌ها:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**مثال:** اجازه دادن به گواهی خودامضا شده (با مسئولیت خودتان استفاده کنید!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// توجه: این کار fetch را در برابر حملات MITM ناامن می‌کند. با مسئولیت خودتان استفاده کنید!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

در نسخه‌های قدیمی‌تر Node.js (<18)، همچنین می‌توانید از `agent` استفاده کنید:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### پشتیبانی از `keepAlive` (فقط برای Node زیر ۱۸)

با تنظیم متغیر محیطی `FETCH_KEEP_ALIVE` روی مقدار `true`، یک HTTP/HTTPS agent ثبت می‌شود که سوکت‌ها را حتی زمانی که درخواست فعالی وجود ندارد، نگه می‌دارد تا برای درخواست‌های آینده بدون نیاز به برقراری مجدد اتصال TCP مورد استفاده قرار گیرند.

**توجه:** این گزینه ممکن است باعث نشت حافظه شود. لطفاً [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325) را بررسی کنید.

## 📦 نکات مربوط به Bundler

- همه تارگت‌ها با فرمت Module و CommonJS و با named export صادر می‌شوند
- هیچ خروجی برای حفظ سینتکس مدرن transpil نمی‌شود
  - احتمالاً لازم است پکیج‌های `ofetch`، `destr` و `ufo` را برای پشتیبانی ES5 با Babel ترنسپایل کنید
- برای پشتیبانی مرورگرهای قدیمی باید global مربوط به `fetch` را به صورت polyfill اضافه کنید، مثل استفاده از [unfetch](https://github.com/developit/unfetch)

## ❓ سوالات متداول

**چرا export با نام `ofetch` است نه `fetch`؟**

استفاده از نام `fetch` می‌تواند گیج‌کننده باشد چون API متفاوت است ولی همچنان یک fetch محسوب می‌شود، پس نزدیک‌ترین نام ممکن انتخاب شده است. البته می‌توانید `{ fetch }` را از `ofetch` ایمپورت کنید که برای Node.js به صورت خودکار polyfill و در سایر موارد از نسخه بومی استفاده می‌کند.

**چرا export پیش‌فرض وجود ندارد؟**

خروجی پیش‌فرض همواره ریسک ترکیب شدن با خروجی‌های CommonJS را دارد.

این کار همچنین تضمین می‌کند که بتوانیم ابزارهای بیشتری بدون شکستن پکیج معرفی کنیم و نیز استفاده از نام `ofetch` را تشویق می‌کند.

**چرا ترنسپایل نشده است؟**

ترنسپایل کردن کتابخانه‌ها باعث عقب‌گرد وب با کدهای قدیمی می‌شود که برای بیشتر کاربران غیرضروری است.

اگر لازم است از کاربران قدیمی پشتیبانی کنید، می‌توانید کتابخانه را به صورت اختیاری در زنجیره build خود ترنسپایل کنید.
```
## مجوز

MIT. ساخته شده با 💖

<!-- نشان‌ها -->

[npm-version-src]: https://img.shields.io/npm/v/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[npm-version-href]: https://npmjs.com/package/ofetch
[npm-downloads-src]: https://img.shields.io/npm/dm/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[npm-downloads-href]: https://npmjs.com/package/ofetch
[codecov-src]: https://img.shields.io/codecov/c/gh/unjs/ofetch/main?style=flat&colorA=18181B&colorB=F0DB4F
[codecov-href]: https://codecov.io/gh/unjs/ofetch
[bundle-src]: https://img.shields.io/bundlephobia/minzip/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[bundle-href]: https://bundlephobia.com/result?p=ofetch
[license-src]: https://img.shields.io/github/license/unjs/ofetch.svg?style=flat&colorA=18181B&colorB=F0DB4F
[license-href]: https://github.com/unjs/ofetch/blob/main/LICENSE
[jsdocs-src]: https://img.shields.io/badge/jsDocs.io-reference-18181B?style=flat&colorA=18181B&colorB=F0DB4F
[jsdocs-href]: https://www.jsdocs.io/package/ofetch

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-30

---