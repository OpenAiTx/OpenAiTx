# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

API fetch ที่ดีกว่า ใช้งานได้กับ node, browser และ workers

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 เริ่มต้นอย่างรวดเร็ว

ติดตั้ง:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

นำเข้า:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ ใช้งานกับ Node.js

เราใช้ [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) เพื่อตรวจจับ Node.js
และใช้งาน [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) โดยอัตโนมัติ หาก `globalThis.fetch` มีอยู่แล้ว จะถูกใช้งานแทน คุณสามารถใช้ native fetch API แบบ experimental ของ Node.js 17.5.0 ได้โดยใช้ [`--experimental-fetch` flag](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch)

## ✔️ การแปลงค่าการตอบกลับ

`ofetch` จะทำการแปลง JSON และ native values อย่างชาญฉลาดโดยใช้ [destr](https://github.com/unjs/destr) และจะ fallback เป็นข้อความหากแปลงไม่สำเร็จ

```js
const { users } = await ofetch("/api/users");
```

สำหรับ binary content types, `ofetch` จะคืนค่าเป็นวัตถุ `Blob`

คุณสามารถกำหนด parser อื่นแทน `destr` ได้ หรือระบุ `blob`, `arrayBuffer` หรือ `text` เพื่อบังคับให้แปลง body ด้วย method ที่เหมาะสมของ `FetchResponse`

```js
// ใช้ JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// คืนค่า text ตามที่เป็น
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// รับค่าตอบกลับแบบ blob
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON Body

หากมีการส่งอ็อบเจกต์หรือคลาสที่มี `.toJSON()` ไปที่ตัวเลือก `body` ของ `ofetch` จะทำการแปลงเป็น string ให้อัตโนมัติ

`ofetch` ใช้ `JSON.stringify()` ในการแปลงอ็อบเจกต์ที่ส่งเข้ามา คลาสที่ไม่มี `.toJSON()` ต้องถูกแปลงเป็น string ก่อนจะถูกส่งไปที่ตัวเลือก `body`

สำหรับ request methods `PUT`, `PATCH` และ `POST` เมื่อมีการตั้งค่า body เป็น string หรือ object, `ofetch` จะเพิ่ม header `content-type: "application/json"` และ `accept: "application/json"` ให้โดยอัตโนมัติ (ซึ่งคุณสามารถ override ได้เสมอ)

นอกจากนี้ `ofetch` ยังรองรับการตอบกลับแบบ binary ด้วย `Buffer`, `ReadableStream`, `Stream` และ [compatible body types](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body) โดยจะตั้งค่า `duplex: "half"` ให้อัตโนมัติสำหรับการสตรีมข้อมูล!

**ตัวอย่าง:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ การจัดการข้อผิดพลาด

`ofetch` จะ throw ข้อผิดพลาดอัตโนมัติเมื่อ `response.ok` เป็น `false` พร้อมข้อความที่อ่านง่ายและ stack ที่ย่อ (ซ่อนรายละเอียดภายใน)

body ที่แปลงแล้วของ error จะอยู่ใน `error.data` คุณยังสามารถใช้ type `FetchError` ได้ด้วย

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

เพื่อจับค่าข้อผิดพลาด:
```markdown
await ofetch("/url").catch((error) => error.data);
```

เพื่อข้ามการจับข้อผิดพลาดของสถานะ คุณสามารถตั้งค่าออปชั่น `ignoreResponseError` ได้ดังนี้:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ การลองซ้ำอัตโนมัติ (Auto Retry)

`ofetch` จะลองส่งคำขอซ้ำโดยอัตโนมัติหากเกิดข้อผิดพลาด และหากรหัสสถานะของการตอบสนองอยู่ในรายการ `retryStatusCodes`:

**รหัสสถานะที่ลองซ้ำ:**

- `408` - Request Timeout
- `409` - Conflict
- `425` - Too Early ([Experimental](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests
- `500` - Internal Server Error
- `502` - Bad Gateway
- `503` - Service Unavailable
- `504` - Gateway Timeout

คุณสามารถกำหนดจำนวนครั้งในการลองซ้ำและระยะเวลาระหว่างแต่ละครั้งได้ด้วยออปชั่น `retry` และ `retryDelay` และยังสามารถกำหนดอาร์เรย์รหัสสถานะเองได้ด้วยออปชั่น `retryStatusCodes`

ค่าเริ่มต้นของ `retry` คือ `1` ครั้ง ยกเว้นสำหรับเมธอด `POST`, `PUT`, `PATCH` และ `DELETE` ที่ `ofetch` จะไม่ลองซ้ำโดยค่าเริ่มต้นเพื่อหลีกเลี่ยงผลข้างเคียง หากคุณตั้งค่า `retry` เอง จะ **ลองซ้ำเสมอ** สำหรับทุกคำขอ

ค่าเริ่มต้นของ `retryDelay` คือ `0` มิลลิวินาที

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // มิลลิวินาที
  retryStatusCodes: [ 404, 500 ], // รหัสสถานะที่จะลองซ้ำ
});
```

## ✔️ การตั้งเวลา Timeout

คุณสามารถกำหนดค่า `timeout` เป็นมิลลิวินาทีเพื่อยกเลิกคำขอโดยอัตโนมัติหลังจากหมดเวลา (ค่าเริ่มต้นคือปิดใช้งาน)

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // หมดเวลาใน 3 วินาที
});
```

## ✔️ รองรับ Type

ผลลัพธ์ที่ตอบกลับสามารถช่วยกำหนดชนิดข้อมูล (type) ได้:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// ทำงาน Auto complete กับ article.id ได้
```

## ✔️ การเพิ่ม `baseURL`

โดยการใช้ออปชั่น `baseURL` `ofetch` จะเพิ่มค่า baseURL ให้อัตโนมัติทั้งในส่วนที่มีหรือไม่มีเครื่องหมาย / และ query search params สำหรับ baseURL โดยใช้ [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ การเพิ่ม Query Search Params

โดยการใช้ออปชั่น `query` (หรือ `params` เป็นชื่อเล่น) `ofetch` จะเพิ่ม query search params ลงใน URL โดยคงค่า query ในคำขอเองโดยใช้ [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ ตัวดักจับ (Interceptors)

สามารถเพิ่ม async interceptors เพื่อเชื่อมต่อกับเหตุการณ์ต่าง ๆ ในวงจรชีวิตของการเรียก `ofetch` ได้

คุณอาจต้องการใช้ `ofetch.create` เพื่อกำหนด interceptors ที่ใช้ร่วมกัน

### `onRequest({ request, options })`

`onRequest` จะถูกเรียกทันทีที่มีการเรียก `ofetch` ทำให้คุณสามารถปรับเปลี่ยน options หรือทำการ log อย่างง่าย ๆ ได้

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Log request
    console.log("[fetch request]", request, options);

    // เพิ่ม `?t=1640125211170` ลงใน query search params
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` จะถูกเรียกเมื่อคำขอ fetch ล้มเหลว
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // บันทึกข้อผิดพลาด
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` จะถูกเรียกหลังจาก `fetch` และทำการแปลง body

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // บันทึกการตอบกลับ
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` เหมือนกับ `onResponse` แต่จะถูกเรียกเมื่อเกิด fetch แล้วแต่ `response.ok` ไม่เป็น `true`

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // บันทึกข้อผิดพลาด
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### การส่งอาร์เรย์ของ interceptor

หากจำเป็น คุณสามารถส่งอาร์เรย์ของฟังก์ชันที่จะถูกเรียกตามลำดับได้เช่นกัน

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* ทำบางอย่าง */
    },
    () => {
      /* ทำอย่างอื่น */
    },
  ],
});
```

## ✔️ สร้าง fetch พร้อม options เริ่มต้น

ยูทิลิตี้นี้มีประโยชน์หากคุณต้องการใช้งาน options เดียวกันกับหลาย ๆ fetch calls

**หมายเหตุ:** ค่าตั้งต้นจะถูกโคลนในระดับเดียวและสืบทอดต่อกัน โปรดระวัง options ซ้อนเช่น `headers`

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // เหมือนกับ ofetch('/test', { baseURL: '/api' })
```

## 💡 การเพิ่ม headers

โดยการใช้ options `headers` `ofetch` จะเพิ่ม header เพิ่มเติมนอกเหนือจาก header เริ่มต้นของ request:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 การเข้าถึง Raw Response

หากคุณต้องการเข้าถึง response ดิบ (สำหรับ headers ฯลฯ) คุณสามารถใช้ `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 การใช้ Native Fetch

เพื่อความสะดวก คุณสามารถใช้ `ofetch.native` ที่ให้ API `fetch` แบบ native

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ การเพิ่ม HTTP(S) Agent

ในสภาพแวดล้อม Node.js (>= 18) คุณสามารถกำหนด dispatcher แบบกำหนดเองเพื่อดักจับคำขอและรองรับฟีเจอร์ต่างๆ เช่น Proxy และใบรับรองที่ลงนามด้วยตนเอง ฟีเจอร์นี้เปิดใช้งานโดย [undici](https://undici.nodejs.org/) ที่มาพร้อมกับ Node.js [อ่านเพิ่มเติม](https://undici.nodejs.org/#/docs/api/Dispatcher) เกี่ยวกับ Dispatcher API

Agent ที่ใช้งานได้บางตัว:

- `ProxyAgent`: คลาส Proxy Agent ที่ใช้งาน Agent API อนุญาตให้เชื่อมต่อผ่าน proxy ได้อย่างง่ายดาย ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: คลาส Mocked Agent ที่ใช้งาน Agent API อนุญาตให้ดักจับ HTTP requests ที่เกิดผ่าน undici และส่งกลับ mocked responses แทน ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent อนุญาตให้ส่งคำขอไปยังหลาย origins ที่แตกต่างกัน ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**ตัวอย่าง:** กำหนด proxy agent สำหรับคำขอเดียว:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**ตัวอย่าง:** สร้าง fetch instance แบบกำหนดเองที่เปิดใช้งาน proxy:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**ตัวอย่าง:** กำหนด proxy agent สำหรับทุกคำขอ:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**ตัวอย่าง:** อนุญาตให้ใช้ใบรับรองที่ลงนามเอง (ใช้ด้วยความเสี่ยงของคุณเอง!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// หมายเหตุ: นี่จะทำให้ fetch ไม่ปลอดภัยต่อการโจมตีแบบ MITM ใช้ด้วยความเสี่ยงของคุณเอง!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

บน Node.js เวอร์ชันเก่า (<18) คุณอาจใช้ `agent` ได้เช่นกัน:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### รองรับ `keepAlive` (ใช้ได้เฉพาะกับ Node < 18)

โดยการตั้งค่าตัวแปรสภาพแวดล้อม `FETCH_KEEP_ALIVE` ให้เป็น `true` จะมีการลงทะเบียน HTTP/HTTPS agent ที่คง socket เอาไว้แม้จะไม่มีคำขอค้างอยู่ เพื่อให้สามารถนำมาใช้กับคำขอในอนาคตโดยไม่ต้องสร้างการเชื่อมต่อ TCP ใหม่

**หมายเหตุ:** ตัวเลือกนี้อาจก่อให้เกิด memory leak ได้ โปรดตรวจสอบ [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325)

## 📦 หมายเหตุเกี่ยวกับ Bundler

- ทุก target จะถูก export ทั้งแบบ Module และ CommonJS format และใช้ named exports
- ไม่มีการ transpile export ใดๆ เพื่อรักษา syntax ที่ทันสมัย
  - คุณอาจจำเป็นต้อง transpile แพ็กเกจ `ofetch`, `destr` และ `ufo` ด้วย Babel เพื่อรองรับ ES5
- คุณจำเป็นต้อง polyfill ตัวแปร global `fetch` เพื่อรองรับเบราว์เซอร์รุ่นเก่า เช่น โดยใช้ [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**ทำไม export ถึงชื่อ `ofetch` แทนที่จะเป็น `fetch`?**

การใช้ชื่อเดียวกับ `fetch` อาจทำให้สับสน เนื่องจาก API แตกต่างกันแต่ยังคงเป็น fetch ดังนั้นจึงเลือกชื่อที่ใกล้เคียงที่สุด อย่างไรก็ตาม คุณสามารถ import `{ fetch }` จาก `ofetch` ซึ่งจะเป็น auto-polyfill สำหรับ Node.js และใช้ native ในกรณีอื่น

**ทำไมไม่มี default export?**

Default exports มักมีความเสี่ยงที่จะถูกรวมกับ CommonJS exports

สิ่งนี้ยังรับประกันว่าเราสามารถเพิ่ม utils อื่นๆ ได้โดยไม่กระทบกับแพ็กเกจ และส่งเสริมให้ใช้ชื่อ `ofetch`

**ทำไมไม่ transpile?**

การ transpile ไลบรารีจะย้อนให้เว็บกลับไปใช้โค้ดรุ่นเก่าซึ่งไม่จำเป็นสำหรับผู้ใช้ส่วนใหญ่

หากคุณต้องการรองรับผู้ใช้รุ่นเก่า คุณสามารถเลือก transpile ไลบรารีนี้ใน build pipeline ของคุณได้
```
## ใบอนุญาต

MIT. สร้างด้วย 💖

<!-- Badges -->

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