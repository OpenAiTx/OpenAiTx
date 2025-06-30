# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

一個更優秀的 fetch API。可在 Node、瀏覽器與 workers 環境運行。

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 快速開始

安裝：

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

匯入：

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ 支援 Node.js

我們使用[條件匯出（conditional exports）](https://nodejs.org/api/packages.html#packages_conditional_exports)來偵測 Node.js
並自動使用 [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native)。如果 `globalThis.fetch` 可用，則會優先使用。如需利用 Node.js 17.5.0 實驗性的原生 fetch API，請使用 [`--experimental-fetch` 旗標](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch)。

## ✔️ 解析回應

`ofetch` 會智能地使用 [destr](https://github.com/unjs/destr) 解析 JSON 與原生值，若解析失敗則回傳純文字。

```js
const { users } = await ofetch("/api/users");
```

針對二進位內容類型，`ofetch` 會回傳一個 `Blob` 物件。

你也可以選擇提供不同於 `destr` 的解析器，或指定 `blob`、`arrayBuffer`、或 `text`，強制以對應的 `FetchResponse` 方法解析回應主體。

```js
// 使用 JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// 直接回傳文字內容
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// 取得回應的 blob 版本
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON 主體

若在 `body` 選項中傳入物件或帶有 `.toJSON()` 方法的類別，`ofetch` 會自動將其字串化。

`ofetch` 會使用 `JSON.stringify()` 來轉換所傳入的物件。沒有 `.toJSON()` 方法的類別需在傳入 `body` 前先轉為字串。

對於 `PUT`、`PATCH` 與 `POST` 請求方法，當設定字串或物件主體時，`ofetch` 會自動添加預設的 `content-type: "application/json"` 和 `accept: "application/json"` 標頭（你也可以自行覆蓋）。

此外，`ofetch` 支援以 `Buffer`、`ReadableStream`、`Stream` 及[相容主體類型](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body)進行二進位回應。`ofetch` 會自動設定 `duplex: "half"` 選項以支援串流！

**範例：**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ 錯誤處理

當 `response.ok` 為 `false` 時，`ofetch` 會自動拋出錯誤，並帶有友善的錯誤訊息與精簡堆疊（隱藏內部細節）。

已解析的錯誤主體可由 `error.data` 取得。你也可以使用 `FetchError` 類型。

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

捕捉錯誤回應請參考：
await ofetch("/url").catch((error) => error.data);
```

要繞過狀態錯誤的捕獲，可以設置 `ignoreResponseError` 選項：

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ 自動重試

`ofetch` 會在發生錯誤並且響應狀態碼包含於 `retryStatusCodes` 列表時自動重試請求：

**重試狀態碼：**

- `408` - 請求逾時
- `409` - 衝突
- `425` - 太早 ([實驗性](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - 請求過多
- `500` - 內部伺服器錯誤
- `502` - 錯誤閘道
- `503` - 服務不可用
- `504` - 閘道逾時

你可以使用 `retry` 和 `retryDelay` 選項來指定重試次數及延遲時間，也可以透過 `retryStatusCodes` 選項傳入自訂的狀態碼陣列。

`retry` 預設為重試 `1` 次，除了 `POST`、`PUT`、`PATCH` 和 `DELETE` 方法，`ofetch` 預設不會重試，以避免產生副作用。如果你為 `retry` 設定了自訂值，則**所有請求都會執行重試**。

`retryDelay` 預設為 `0` 毫秒。

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // 毫秒
  retryStatusCodes: [ 404, 500 ], // 需重試的響應狀態碼
});
```

## ✔️ 逾時設定

你可以指定 `timeout`（毫秒）來在逾時後自動終止請求（預設為停用）。

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3 秒後逾時
});
```

## ✔️ 類型友好

響應結果可以支援型別提示：

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// 可自動完成並使用 article.id
```

## ✔️ 新增 `baseURL`

透過設定 `baseURL` 選項，`ofetch` 會利用 [ufo](https://github.com/unjs/ufo) 處理斜線與查詢參數，將其加在請求前面：

```js
await ofetch("/config", { baseURL });
```

## ✔️ 新增查詢參數

透過 `query` 選項（或別名 `params`），`ofetch` 會使用 [ufo](https://github.com/unjs/ufo) 保留請求本身的查詢並添加查詢參數至 URL：

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ 攔截器

可以提供非同步攔截器來鉤入 `ofetch` 調用的生命週期事件。

你可以使用 `ofetch.create` 來設置共用攔截器。

### `onRequest({ request, options })`

`onRequest` 會在呼叫 `ofetch` 時立即執行，可用於修改選項或簡單紀錄日誌。

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // 輸出請求日誌
    console.log("[fetch request]", request, options);

    // 在查詢參數中加入 `?t=1640125211170`
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

當 fetch 請求失敗時，會呼叫 `onRequestError`。
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // 記錄錯誤
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` 會在 `fetch` 呼叫並解析 body 之後被呼叫。

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // 記錄回應
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` 與 `onResponse` 相同，但僅在 fetch 發生但 `response.ok` 不是 `true` 時被呼叫。

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // 記錄錯誤
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### 傳遞攔截器陣列

如果有需要，也可以傳遞一個函式陣列，這些函式會被依序呼叫。

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* 執行某些操作 */
    },
    () => {
      /* 執行其他操作 */
    },
  ],
});
```

## ✔️ 使用預設選項建立 fetch

如果你需要在多個 fetch 呼叫中使用共用選項，這個工具會很有用。

**注意：** 預設值只會被複製一層並繼承。請小心像 `headers` 這樣的巢狀選項。

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // 等同於 ofetch('/test', { baseURL: '/api' })
```

## 💡 新增 headers

透過使用 `headers` 選項，`ofetch` 會在預設請求標頭之外新增額外的標頭：

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 存取原始回應

如果你需要存取原始回應（例如標頭等），可以使用 `ofetch.raw`：

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 使用原生 Fetch

作為捷徑，你可以使用提供原生 `fetch` API 的 `ofetch.native`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ 新增 HTTP(S) Agent

在 Node.js (>= 18) 環境中，你可以提供自訂的 dispatcher 來攔截請求並支援像是 Proxy 和自簽憑證等功能。這個功能由 [undici](https://undici.nodejs.org/) 內建於 Node.js。關於 Dispatcher API 的更多資訊請參閱 [read more](https://undici.nodejs.org/#/docs/api/Dispatcher)。

可用的 agent 有：

- `ProxyAgent`：一個實作 Agent API 的 Proxy Agent 類別。它允許以簡單的方式透過代理連線。([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`：一個實作 Agent API 的模擬 Agent 類別。它允許攔截經由 undici 發出的 HTTP 請求並返回模擬回應。([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`：Agent 允許向多個不同的來源派送請求。([docs](https://undici.nodejs.org/#/docs/api/Agent))

**範例：** 為單一請求設定 proxy agent：

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**範例：** 建立啟用代理的自訂 fetch 實例：

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**範例：** 為所有請求設定 proxy agent：

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**範例：** 允許自簽憑證（風險自負！）

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// 注意：這會讓 fetch 對 MITM 攻擊變得不安全。請自行承擔風險！
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

在較舊版本的 Node.js（<18）中，你也可以使用 `agent`：

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` 支援（僅適用於 Node < 18）

透過將 `FETCH_KEEP_ALIVE` 環境變數設為 `true`，會註冊一個 HTTP/HTTPS agent，即使沒有任何未完成的請求，也會保留 socket，使其可供未來請求重複使用，而無需重新建立 TCP 連線。

**注意：** 此選項可能會導致記憶體洩漏。請參閱 [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325)。

## 📦 Bundler 備註

- 所有目標皆以 Module 及 CommonJS 格式與具名匯出進行導出
- 為了現代語法，並未進行轉譯
  - 若需支援 ES5，建議你使用 Babel 轉譯 `ofetch`、`destr` 及 `ufo` 套件
- 若要支援舊版瀏覽器，需要為 `fetch` 全域進行 polyfill，可使用 [unfetch](https://github.com/developit/unfetch)

## ❓ 常見問答

**為什麼匯出名稱是 `ofetch` 而不是 `fetch`？**

使用 `fetch` 這個相同名稱可能會造成混淆，因為 API 不完全相同，但它仍然是 fetch，因此採用最接近的替代名稱。不過，你仍然可以從 `ofetch` 匯入 `{ fetch }`，這會自動為 Node.js polyfill，否則則使用原生。

**為什麼沒有預設匯出？**

預設匯出與 CommonJS 匯出混用總是有風險。

這也保證我們可以在不破壞套件的情況下加入更多工具，並鼓勵使用 `ofetch` 這個名稱。

**為什麼不進行轉譯？**

轉譯函式庫會讓網頁倒退回使用不必要的舊有程式碼，對大多數使用者來說並不需要。

如果你需要支援舊版用戶，可選擇在你的建置流程中轉譯此函式庫。
```
## 授權條款

MIT。以 💖 製作

<!-- 徽章 -->

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