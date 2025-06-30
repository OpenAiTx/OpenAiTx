# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

더 나은 fetch API. Node, 브라우저, 워커에서 동작합니다.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 빠른 시작

설치:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

임포트:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Node.js에서 동작

Node.js를 감지하고 자동으로 [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native)를 사용하기 위해 [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports)를 사용합니다. `globalThis.fetch`가 사용 가능하다면, 그 대신 사용됩니다. Node.js 17.5.0의 실험적 네이티브 fetch API를 활용하려면 [`--experimental-fetch` 플래그](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch)를 사용하세요.

## ✔️ 응답 파싱

`ofetch`는 [destr](https://github.com/unjs/destr)를 사용해 JSON과 네이티브 값을 스마트하게 파싱하며, 파싱에 실패할 경우 텍스트로 대체합니다.

```js
const { users } = await ofetch("/api/users");
```

바이너리 콘텐츠 타입의 경우, `ofetch`는 대신 `Blob` 객체를 반환합니다.

원한다면 `destr` 대신 다른 파서(parser)를 제공할 수 있으며, 또는 `blob`, `arrayBuffer`, `text`를 지정해 해당 `FetchResponse` 메서드로 본문 파싱을 강제할 수 있습니다.

```js
// JSON.parse 사용
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// 텍스트를 그대로 반환
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// 응답의 blob 버전 받기
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON 본문

객체 또는 `.toJSON()` 메서드를 가진 클래스가 `body` 옵션에 전달되면, `ofetch`가 자동으로 문자열로 변환합니다.

`ofetch`는 전달된 객체를 변환하기 위해 `JSON.stringify()`를 사용합니다. `.toJSON()` 메서드가 없는 클래스는 미리 문자열로 변환한 후 `body` 옵션에 전달해야 합니다.

`PUT`, `PATCH`, `POST` 요청 메서드에서 문자열 또는 객체 본문이 설정되면, `ofetch`는 기본적으로 `content-type: "application/json"`과 `accept: "application/json"` 헤더를 추가합니다(언제든지 재정의할 수 있습니다).

또한, `ofetch`는 `Buffer`, `ReadableStream`, `Stream`, [호환되는 body 타입](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body)으로 바이너리 응답을 지원합니다. 스트리밍 지원을 위해 `duplex: "half"` 옵션을 자동으로 설정합니다!

**예시:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ 에러 처리

`ofetch`는 `response.ok`가 `false`일 때 자동으로 에러를 친절한 메시지와 간결한 스택(내부 정보 숨김)과 함께 발생시킵니다.

파싱된 에러 본문은 `error.data`로 제공됩니다. 또한 `FetchError` 타입을 사용할 수 있습니다.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

에러 응답을 잡으려면:

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

상태 오류 처리를 우회하려면 `ignoreResponseError` 옵션을 설정할 수 있습니다:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ 자동 재시도(Auto Retry)

`ofetch`는 오류가 발생하고 응답 상태 코드가 `retryStatusCodes` 목록에 포함되어 있으면 자동으로 요청을 재시도합니다:

**재시도 상태 코드:**

- `408` - 요청 시간 초과(Request Timeout)
- `409` - 충돌(Conflict)
- `425` - 너무 이른 요청(Too Early) ([실험적](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - 요청이 너무 많음(Too Many Requests)
- `500` - 내부 서버 오류(Internal Server Error)
- `502` - 잘못된 게이트웨이(Bad Gateway)
- `503` - 서비스 사용 불가(Service Unavailable)
- `504` - 게이트웨이 시간 초과(Gateway Timeout)

`retry`와 `retryDelay` 옵션을 사용하여 재시도 횟수와 재시도 간 지연 시간을 지정할 수 있으며, `retryStatusCodes` 옵션으로 커스텀 코드 배열을 전달할 수도 있습니다.

`retry`의 기본값은 `1`번 재시도이며, 단 `POST`, `PUT`, `PATCH`, `DELETE` 메서드는 부작용 방지를 위해 기본적으로 재시도하지 않습니다. `retry`에 값을 지정하면 **모든 요청에 대해 항상 재시도**합니다.

`retryDelay`의 기본값은 `0` ms입니다.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // 재시도할 응답 상태 코드
});
```

## ✔️ 타임아웃(Timeout)

밀리초 단위의 `timeout`을 지정하여 타임아웃 후 요청을 자동으로 중단할 수 있습니다(기본값은 비활성화).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3초 후 타임아웃
});
```

## ✔️ 타입 친화적(Type Friendly)

응답에 타입 지원을 받을 수 있습니다:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// article.id 사용 시 자동 완성 지원
```

## ✔️ `baseURL` 추가하기

`baseURL` 옵션을 사용하면, `ofetch`는 [ufo](https://github.com/unjs/ufo)를 활용해 baseURL의 슬래시 및 쿼리 파라미터를 자동으로 붙입니다:

```js
await ofetch("/config", { baseURL });
```

## ✔️ 쿼리 검색 파라미터 추가하기

`query` 옵션(또는 별칭 `params`)을 사용하면, [ufo](https://github.com/unjs/ufo)를 이용해 쿼리 파라미터를 URL에 추가하면서 기존 요청의 쿼리를 보존할 수 있습니다:

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ 인터셉터(Interceptors)

`ofetch` 호출의 라이프사이클 이벤트에 비동기 인터셉터를 제공해 연결할 수 있습니다.

공유 인터셉터를 설정하려면 `ofetch.create`를 사용하는 것이 좋습니다.

### `onRequest({ request, options })`

`onRequest`는 `ofetch`가 호출되자마자 실행되며, 옵션을 수정하거나 간단한 로깅을 할 수 있습니다.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // 요청 로그 출력
    console.log("[fetch request]", request, options);

    // 쿼리 파라미터에 `?t=1640125211170` 추가
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError`는 fetch 요청이 실패했을 때 호출됩니다.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // 오류 로그 기록
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse`는 `fetch` 호출과 본문 파싱 후에 호출됩니다.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // 응답 로그 기록
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError`는 `onResponse`와 동일하지만 fetch가 발생했지만 `response.ok`가 `true`가 아닐 때 호출됩니다.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // 오류 로그 기록
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### 인터셉터 배열 전달

필요한 경우, 순차적으로 호출될 함수 배열을 전달할 수도 있습니다.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* 무언가를 수행 */
    },
    () => {
      /* 다른 무언가를 수행 */
    },
  ],
});
```

## ✔️ 기본 옵션으로 fetch 생성

여러 fetch 호출에서 공통 옵션을 사용해야 할 때 이 유틸리티가 유용합니다.

**참고:** 기본값은 한 단계에서 복제되어 상속됩니다. `headers`와 같은 중첩 옵션에 주의하세요.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // ofetch('/test', { baseURL: '/api' })와 동일
```

## 💡 헤더 추가하기

`headers` 옵션을 사용하면, `ofetch`는 요청 기본 헤더 외에 추가 헤더를 더합니다:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 원시 응답에 접근

원시 응답(헤더 등)에 접근해야 할 경우, `ofetch.raw`를 사용할 수 있습니다:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 네이티브 Fetch 사용하기

단축키로, 네이티브 `fetch` API를 제공하는 `ofetch.native`를 사용할 수 있습니다.

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ HTTP(S) 에이전트 추가하기

Node.js (>= 18) 환경에서는 커스텀 디스패처(dispatcher)를 제공하여 요청을 가로채고 Proxy 및 자체 서명 인증서와 같은 기능을 지원할 수 있습니다. 이 기능은 Node.js에 내장된 [undici](https://undici.nodejs.org/)에 의해 활성화됩니다. Dispatcher API에 대한 자세한 내용은 [여기](https://undici.nodejs.org/#/docs/api/Dispatcher)에서 확인하세요.

사용 가능한 일부 에이전트:

- `ProxyAgent`: Agent API를 구현하는 프록시 에이전트 클래스입니다. 간단하게 프록시를 통해 연결할 수 있도록 해줍니다. ([문서](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Agent API를 구현하는 목(mock) 에이전트 클래스입니다. undici를 통해 이루어지는 HTTP 요청을 가로채고, 대신 목(mock) 응답을 반환할 수 있습니다. ([문서](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: 여러 다른 오리진(origin)에 대해 요청을 디스패치할 수 있는 에이전트입니다. ([문서](https://undici.nodejs.org/#/docs/api/Agent))

**예시:** 한 번의 요청에 프록시 에이전트를 설정하기:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**예시:** 프록시가 활성화된 커스텀 fetch 인스턴스 생성하기:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**예시:** 모든 요청에 프록시 에이전트를 설정하기:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**예시:** 자체 서명 인증서 허용하기 (사용자 책임하에 사용!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// 참고: 이 옵션은 fetch를 MITM 공격에 취약하게 만듭니다. 사용자 책임하에 사용하세요!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

구버전 Node.js (<18)에서는 `agent`를 사용할 수도 있습니다:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` 지원 (Node < 18에서만 동작)

`FETCH_KEEP_ALIVE` 환경 변수를 `true`로 설정하면, 요청이 없을 때도 소켓을 유지하여, 향후 요청 시 TCP 연결을 다시 설정하지 않고 재사용할 수 있는 HTTP/HTTPS 에이전트가 등록됩니다.

**참고:** 이 옵션은 메모리 누수(memory leak)를 유발할 수 있습니다. 자세한 내용은 [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325)를 확인하세요.

## 📦 번들러 참고사항

- 모든 타겟은 Module 및 CommonJS 형식과 named exports로 내보내집니다.
- 최신 문법 유지를 위해 어떠한 내보내기도 트랜스파일되지 않습니다.
  - ES5 지원이 필요하다면 `ofetch`, `destr`, `ufo` 패키지를 Babel로 트랜스파일해야 할 수 있습니다.
- [unfetch](https://github.com/developit/unfetch)와 같이 레거시 브라우저 지원을 위해 `fetch` 글로벌을 폴리필 해야 합니다.

## ❓ FAQ

**왜 export 이름이 `fetch`가 아니라 `ofetch`인가요?**

동일한 이름의 `fetch`를 사용하면 API가 다르기 때문에 혼란스러울 수 있습니다. 하지만 여전히 fetch 기능이므로 가장 비슷한 대체 이름을 사용했습니다. 그러나 `{ fetch }`를 `ofetch`에서 import하면 Node.js에서는 자동 폴리필되고, 그렇지 않으면 네이티브 fetch를 사용합니다.

**왜 default export가 없나요?**

default export는 항상 CommonJS export와 혼합될 위험이 있습니다.

이렇게 하면 더 많은 유틸리티를 패키지를 깨뜨리지 않고 추가할 수 있고, `ofetch` 이름 사용을 장려할 수 있습니다.

**왜 트랜스파일하지 않나요?**

라이브러리를 트랜스파일하면 대부분의 사용자에게 불필요한 레거시 코드를 웹에 추가하게 됩니다.

레거시 사용자를 지원해야 하는 경우, 빌드 파이프라인에서 라이브러리를 선택적으로 트랜스파일하면 됩니다.
```
## 라이선스

MIT. 💖로 만들어졌습니다

<!-- 배지 -->

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