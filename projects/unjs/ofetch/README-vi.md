# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Một API fetch tốt hơn. Hoạt động trên node, trình duyệt và workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Bắt Đầu Nhanh

Cài đặt:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Nhập khẩu:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Tương thích với Node.js

Chúng tôi sử dụng [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) để phát hiện Node.js
và tự động sử dụng [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Nếu `globalThis.fetch` khả dụng, nó sẽ được sử dụng thay thế. Để tận dụng API fetch gốc thử nghiệm của Node.js 17.5.0, hãy sử dụng [cờ `--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Phân Tích Phản Hồi

`ofetch` sẽ tự động phân tích JSON và các giá trị gốc sử dụng [destr](https://github.com/unjs/destr), và sẽ trả về văn bản nếu không phân tích được.

```js
const { users } = await ofetch("/api/users");
```

Đối với các loại nội dung nhị phân, `ofetch` sẽ trả về một đối tượng `Blob`.

Bạn cũng có thể cung cấp một parser khác thay vì `destr`, hoặc chỉ định `blob`, `arrayBuffer`, hoặc `text` để ép buộc phân tích nội dung với phương thức tương ứng của `FetchResponse`.

```js
// Sử dụng JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Trả về văn bản như nguyên trạng
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Lấy phiên bản blob của phản hồi
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Thân JSON

Nếu một đối tượng hoặc một lớp có phương thức `.toJSON()` được truyền vào tuỳ chọn `body`, `ofetch` sẽ tự động chuyển nó thành chuỗi.

`ofetch` sử dụng `JSON.stringify()` để chuyển đổi đối tượng được truyền vào. Các lớp không có phương thức `.toJSON()` cần được chuyển thành giá trị chuỗi trước khi truyền vào tuỳ chọn `body`.

Đối với các phương thức yêu cầu `PUT`, `PATCH`, và `POST`, khi một chuỗi hoặc đối tượng được đặt làm thân, `ofetch` sẽ thêm mặc định các header `content-type: "application/json"` và `accept: "application/json"` (bạn luôn có thể ghi đè).

Ngoài ra, `ofetch` hỗ trợ phản hồi nhị phân với `Buffer`, `ReadableStream`, `Stream`, và [các kiểu thân tương thích](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` sẽ tự động đặt tuỳ chọn `duplex: "half"` để hỗ trợ streaming!

**Ví dụ:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Xử Lý Lỗi

`ofetch` tự động ném lỗi khi `response.ok` là `false` với thông báo lỗi thân thiện và stacktrace ngắn gọn (ẩn các phần nội bộ).

Một thân lỗi đã được phân tích sẽ có trong `error.data`. Bạn cũng có thể sử dụng kiểu `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Để bắt lỗi phản hồi:

```ts
await ofetch("/url").catch((error) => error.data);
```

Để bỏ qua việc bắt lỗi trạng thái, bạn có thể đặt tùy chọn `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Tự động thử lại (Auto Retry)

`ofetch` sẽ tự động thử lại yêu cầu nếu xảy ra lỗi và nếu mã trạng thái phản hồi nằm trong danh sách `retryStatusCodes`:

**Mã trạng thái thử lại:**

- `408` - Request Timeout (Hết thời gian yêu cầu)
- `409` - Conflict (Xung đột)
- `425` - Too Early ([Thử nghiệm](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests (Quá nhiều yêu cầu)
- `500` - Internal Server Error (Lỗi máy chủ nội bộ)
- `502` - Bad Gateway (Cổng xấu)
- `503` - Service Unavailable (Dịch vụ không khả dụng)
- `504` - Gateway Timeout (Hết thời gian cổng)

Bạn có thể chỉ định số lần thử lại và khoảng thời gian giữa các lần thử bằng các tùy chọn `retry` và `retryDelay`, đồng thời truyền vào một mảng mã trạng thái tùy chỉnh bằng tùy chọn `retryStatusCodes`.

Mặc định `retry` là `1` lần thử lại, ngoại trừ các phương thức `POST`, `PUT`, `PATCH` và `DELETE` mà `ofetch` sẽ không thử lại để tránh phát sinh tác dụng phụ. Nếu bạn đặt giá trị tùy chỉnh cho `retry` thì nó sẽ **luôn thử lại** cho mọi yêu cầu.

Mặc định `retryDelay` là `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // các mã trạng thái phản hồi sẽ thử lại
});
```

## ✔️ Timeout

Bạn có thể chỉ định `timeout` (thời gian chờ) bằng mili giây để tự động hủy một yêu cầu sau khi hết thời gian chờ (mặc định là tắt).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Hủy sau 3 giây
});
```

## ✔️ Hỗ trợ kiểu dữ liệu (Type Friendly)

Phản hồi có thể được hỗ trợ kiểu dữ liệu:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Tự động hoàn thành khi làm việc với article.id
```

## ✔️ Thêm `baseURL`

Bằng cách sử dụng tùy chọn `baseURL`, `ofetch` sẽ tự động thêm tiền tố cho các dấu gạch chéo đầu/cuối và các tham số truy vấn cho baseURL sử dụng [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Thêm tham số truy vấn (Query Search Params)

Bằng cách sử dụng tùy chọn `query` (hoặc `params` là bí danh), `ofetch` sẽ thêm các tham số truy vấn vào URL đồng thời giữ nguyên truy vấn trong chính request đó bằng [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptors

Có thể cung cấp các interceptor bất đồng bộ để can thiệp vào các sự kiện vòng đời của lệnh gọi `ofetch`.

Bạn nên sử dụng `ofetch.create` để cài đặt các interceptor dùng chung.

### `onRequest({ request, options })`

`onRequest` được gọi ngay khi `ofetch` được gọi, cho phép bạn chỉnh sửa tùy chọn hoặc thực hiện ghi log đơn giản.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Ghi log yêu cầu
    console.log("[fetch request]", request, options);

    // Thêm `?t=1640125211170` vào tham số truy vấn
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` sẽ được gọi khi yêu cầu fetch thất bại.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Ghi log lỗi
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` sẽ được gọi sau khi gọi `fetch` và phân tích body.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Ghi log phản hồi
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` giống như `onResponse` nhưng sẽ được gọi khi fetch xảy ra nhưng `response.ok` không phải là `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Ghi log lỗi
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Truyền mảng các interceptor

Nếu cần thiết, bạn cũng có thể truyền một mảng các hàm sẽ được gọi tuần tự.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Thực hiện gì đó */
    },
    () => {
      /* Thực hiện việc khác */
    },
  ],
});
```

## ✔️ Tạo fetch với tùy chọn mặc định

Tiện ích này hữu ích nếu bạn cần sử dụng các tùy chọn chung cho nhiều lần gọi fetch.

**Lưu ý:** Tùy chọn mặc định sẽ được nhân bản ở một cấp và kế thừa. Hãy cẩn thận với các tùy chọn lồng nhau như `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Tương đương với ofetch('/test', { baseURL: '/api' })
```

## 💡 Thêm headers

Bằng cách sử dụng tùy chọn `headers`, `ofetch` sẽ thêm các header bổ sung ngoài các header mặc định của request:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Truy cập Raw Response

Nếu bạn cần truy cập phản hồi thô (để lấy headers, v.v), bạn có thể sử dụng `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Sử dụng Native Fetch

Để rút ngắn, bạn có thể sử dụng `ofetch.native` để cung cấp API `fetch` gốc

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Thêm HTTP(S) Agent

Trong môi trường Node.js (>= 18), bạn có thể cung cấp một dispatcher tùy chỉnh để chặn các yêu cầu và hỗ trợ các tính năng như Proxy và chứng chỉ tự ký. Tính năng này được kích hoạt bởi [undici](https://undici.nodejs.org/) tích hợp sẵn trong Node.js. [xem thêm](https://undici.nodejs.org/#/docs/api/Dispatcher) về Dispatcher API.

Một số agent có sẵn:

- `ProxyAgent`: Một lớp Proxy Agent triển khai Agent API. Nó cho phép kết nối thông qua proxy một cách đơn giản. ([tài liệu](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Một lớp Agent giả lập triển khai Agent API. Nó cho phép chặn các yêu cầu HTTP thực hiện qua undici và trả về các phản hồi giả lập thay thế. ([tài liệu](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent cho phép gửi các yêu cầu đến nhiều nguồn gốc khác nhau. ([tài liệu](https://undici.nodejs.org/#/docs/api/Agent))

**Ví dụ:** Thiết lập proxy agent cho một yêu cầu:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Ví dụ:** Tạo một instance fetch tùy chỉnh với proxy được bật:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Ví dụ:** Thiết lập proxy agent cho tất cả các yêu cầu:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Ví dụ:** Cho phép sử dụng chứng chỉ tự ký (SỬ DỤNG Ở RỦI RO CỦA BẠN!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Lưu ý: Điều này làm cho fetch không an toàn trước các tấn công MITM. SỬ DỤNG Ở RỦI RO CỦA BẠN!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Trên các phiên bản Node.js cũ hơn (<18), bạn cũng có thể sử dụng `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Hỗ trợ `keepAlive` (chỉ hoạt động với Node < 18)

Bằng cách đặt biến môi trường `FETCH_KEEP_ALIVE` thành `true`, một HTTP/HTTPS agent sẽ được đăng ký để giữ các socket ngay cả khi không còn yêu cầu nào, do đó chúng có thể được sử dụng cho các yêu cầu trong tương lai mà không cần thiết lập lại kết nối TCP.

**Lưu ý:** Tùy chọn này có thể gây ra rò rỉ bộ nhớ. Vui lòng kiểm tra [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Lưu ý cho Bundler

- Tất cả các target đều được xuất ra với định dạng Module và CommonJS và xuất theo dạng named exports
- Không có xuất nào được transpile để giữ cú pháp hiện đại
  - Có thể bạn cần transpile các package `ofetch`, `destr` và `ufo` với Babel để hỗ trợ ES5
- Bạn cần polyfill biến toàn cục `fetch` để hỗ trợ các trình duyệt cũ như sử dụng [unfetch](https://github.com/developit/unfetch)

## ❓ Câu hỏi thường gặp

**Tại sao export lại là `ofetch` thay vì `fetch`?**

Sử dụng cùng tên `fetch` có thể gây nhầm lẫn vì API khác nhau nhưng về bản chất nó vẫn là fetch nên chọn tên thay thế gần nhất có thể. Tuy nhiên, bạn vẫn có thể import `{ fetch }` từ `ofetch` để được tự động polyfill cho Node.js và sử dụng native nếu không phải Node.js.

**Tại sao không có default export?**

Default export luôn có nguy cơ bị trộn lẫn với các export theo kiểu CommonJS.

Điều này cũng đảm bảo rằng chúng tôi có thể thêm nhiều tiện ích khác mà không làm hỏng package và cũng khuyến khích sử dụng tên `ofetch`.

**Tại sao không transpile?**

Việc transpile các thư viện đẩy web quay về phía sau với mã nguồn cũ, điều này là không cần thiết với hầu hết người dùng.

Nếu bạn cần hỗ trợ người dùng cũ, bạn có thể tùy chọn transpile thư viện này trong pipeline build của mình.
```
## Giấy phép

MIT. Được tạo ra với 💖

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