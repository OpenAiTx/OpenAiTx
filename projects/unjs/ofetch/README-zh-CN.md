# ofetch

[![npm 版本][npm-version-src]][npm-version-href]
[![npm 下载量][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![许可证][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

一个更好的 fetch API。支持 Node、浏览器和 worker 环境。

<details>
  <summary>剧透</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 快速开始

安装：

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

导入：

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ 支持 Node.js

我们使用[条件导出](https://nodejs.org/api/packages.html#packages_conditional_exports)来检测 Node.js，
并自动使用 [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native)。如果 `globalThis.fetch` 可用，则优先使用。如需使用 Node.js 17.5.0 的实验性原生 fetch API，请使用 [`--experimental-fetch` 参数](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch)。

## ✔️ 响应解析

`ofetch` 会智能地使用 [destr](https://github.com/unjs/destr) 解析 JSON 及原生值，如果解析失败则回退为文本。

```js
const { users } = await ofetch("/api/users");
```

对于二进制内容类型，`ofetch` 会返回一个 `Blob` 对象。

你可以选择提供不同于 `destr` 的解析器，或通过指定 `blob`、`arrayBuffer` 或 `text`，强制使用相应的 `FetchResponse` 方法解析响应体。

```js
// 使用 JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// 原样返回文本
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// 获取响应的 blob 版本
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON 请求体

如果在 `body` 选项中传入对象或带有 `.toJSON()` 方法的类，`ofetch` 会自动将其字符串化。

`ofetch` 利用 `JSON.stringify()` 将传入的对象转换为字符串。没有 `.toJSON()` 方法的类需在传递给 `body` 选项前提前转换为字符串。

对于 `PUT`、`PATCH` 和 `POST` 请求方法，在设置字符串或对象类型的请求体时，`ofetch` 会自动添加默认的 `content-type: "application/json"` 和 `accept: "application/json"` 头（你也可以自定义覆盖）。

此外，`ofetch` 支持 `Buffer`、`ReadableStream`、`Stream` 及[兼容的请求体类型](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body)的二进制响应。对于流式支持，`ofetch` 会自动设置 `duplex: "half"` 选项！

**示例：**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ 错误处理

当 `response.ok` 为 `false` 时，`ofetch` 会自动抛出错误，并带有友好的错误信息和简洁的堆栈（隐藏内部细节）。

已解析的错误体可通过 `error.data` 获取。你也可以使用 `FetchError` 类型。

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

捕获错误响应：

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

要绕过状态错误捕获，可以设置 `ignoreResponseError` 选项：

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ 自动重试

`ofetch` 会在发生错误时自动重试请求，并且如果响应状态码包含在 `retryStatusCodes` 列表中：

**重试状态码：**

- `408` - 请求超时
- `409` - 冲突
- `425` - 过早 ([实验性](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - 请求过多
- `500` - 服务器内部错误
- `502` - 错误网关
- `503` - 服务不可用
- `504` - 网关超时

你可以通过 `retry` 和 `retryDelay` 选项来指定重试次数和间隔，也可以通过 `retryStatusCodes` 选项传递自定义状态码数组。

`retry` 的默认值为重试 `1` 次，除了 `POST`、`PUT`、`PATCH` 和 `DELETE` 方法，`ofetch` 默认不会重试这些方法以避免产生副作用。如果你为 `retry` 设置了自定义值，则**所有请求都会重试**。

`retryDelay` 的默认值为 `0` 毫秒。

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // 毫秒
  retryStatusCodes: [ 404, 500 ], // 需要重试的响应状态码
});
```

## ✔️ 超时

你可以指定以毫秒为单位的 `timeout`，在超时后自动中止请求（默认禁用）。

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3秒后超时
});
```

## ✔️ 类型友好

响应结果可以支持类型推断：

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// 在 article.id 上有自动补全
```

## ✔️ 添加 `baseURL`

通过使用 `baseURL` 选项，`ofetch` 会在基础 URL 上自动拼接斜杠和查询参数，处理方式使用 [ufo](https://github.com/unjs/ufo)：

```js
await ofetch("/config", { baseURL });
```

## ✔️ 添加查询参数

通过使用 `query` 选项（或其别名 `params`），`ofetch` 会在请求地址中保留原有查询参数并添加新的查询参数，底层使用 [ufo](https://github.com/unjs/ufo)：

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ 拦截器

可以提供异步拦截器来钩入 `ofetch` 调用的生命周期事件。

你可能希望使用 `ofetch.create` 来设置共享拦截器。

### `onRequest({ request, options })`

当 `ofetch` 被调用时，`onRequest` 会立即被调用，允许你修改选项或进行简单日志记录。

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // 日志请求
    console.log("[fetch request]", request, options);

    // 向查询参数中添加 `?t=1640125211170`
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

当 fetch 请求失败时，会调用 `onRequestError`。
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // 记录错误
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` 会在 `fetch` 调用并解析响应体后被调用。

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // 记录响应
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` 与 `onResponse` 类似，但会在 fetch 请求发生且 `response.ok` 不为 `true` 时被调用。

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // 记录错误
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### 传递拦截器数组

如有需要，也可以传递一个函数数组，这些函数会被依次调用。

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* 做一些事情 */
    },
    () => {
      /* 做其他事情 */
    },
  ],
});
```

## ✔️ 创建带默认选项的 fetch

如果你需要在多个 fetch 调用中使用通用选项，此工具非常有用。

**注意：** 默认值会被浅层克隆并继承。请注意像 `headers` 这样的嵌套选项。

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // 等同于 ofetch('/test', { baseURL: '/api' })
```

## 💡 添加请求头

通过使用 `headers` 选项，`ofetch` 会在默认请求头的基础上添加额外的请求头：

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 获取原始响应

如果你需要访问原始响应（例如获取响应头等），可以使用 `ofetch.raw`：

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 使用原生 Fetch

作为快捷方式，你可以使用提供原生 `fetch` API 的 `ofetch.native`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ 添加 HTTP(S) 代理

在 Node.js（>= 18）环境中，你可以提供自定义调度器来拦截请求，并支持如代理和自签名证书等功能。该特性由 Node.js 内置的 [undici](https://undici.nodejs.org/) 实现。[阅读更多](https://undici.nodejs.org/#/docs/api/Dispatcher) 了解 Dispatcher API。

可用的代理有：

- `ProxyAgent`：实现了 Agent API 的代理类。它允许通过代理以简单的方式建立连接。（[文档](https://undici.nodejs.org/#/docs/api/ProxyAgent)）
- `MockAgent`：实现了 Agent API 的模拟代理类。它允许拦截通过 undici 发起的 HTTP 请求并返回模拟响应。（[文档](https://undici.nodejs.org/#/docs/api/MockAgent)）
- `Agent`：Agent 允许向多个不同的源分发请求。（[文档](https://undici.nodejs.org/#/docs/api/Agent)）

**示例：** 为单个请求设置代理代理：

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**示例：** 创建一个启用代理的自定义 fetch 实例：

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**示例：** 为所有请求设置代理代理：

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**示例：** 允许自签名证书（使用此功能需自担风险！）

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// 注意：这会导致 fetch 在遭受 MITM 攻击时变得不安全。请自行承担风险使用！
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

在较旧的 Node.js 版本（<18）中，你也可以使用 `agent`：

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` 支持（仅适用于 Node < 18）

通过将环境变量 `FETCH_KEEP_ALIVE` 设置为 `true`，将注册一个 HTTP/HTTPS 代理，即使没有未完成的请求，也会保持 socket 连接，以便后续请求可以复用连接而无需重新建立 TCP 连接。

**注意：** 此选项有可能引入内存泄漏。请参考 [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325)。

## 📦 打包器说明

- 所有目标均以 Module 和 CommonJS 格式以及具名导出方式导出
- 为保持现代语法，不进行任何导出转译
  - 你可能需要用 Babel 转译 `ofetch`、`destr` 和 `ufo` 包以支持 ES5
- 如需支持旧版浏览器，你需要对 `fetch` 全局对象进行 polyfill，比如使用 [unfetch](https://github.com/developit/unfetch)

## ❓ 常见问题解答

**为什么导出叫 `ofetch` 而不是 `fetch`？**

使用 `fetch` 这个名称可能会让人困惑，因为 API 不完全相同，但它本质上还是 fetch，因此采用了最接近的替代名称。不过，你可以从 `ofetch` 导入 `{ fetch }`，这会自动为 Node.js polyfill，并在其他环境下使用原生 fetch。

**为什么没有默认导出？**

默认导出容易和 CommonJS 导出混淆。

这样也能保证我们可以引入更多工具而不破坏包的兼容性，同时也鼓励大家使用 `ofetch` 这个名字。

**为什么不转译？**

对库进行转译，会使 Web 倒退到旧时代代码，对大多数用户来说没有必要。

如果你需要支持旧版用户，可以选择在你的构建流程中对该库进行转译。
```
## 许可证

MIT。由 💖 创作

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