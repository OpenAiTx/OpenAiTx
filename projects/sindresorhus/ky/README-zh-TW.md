<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky 是一個基於 [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) 的小巧且優雅的 HTTP 用戶端

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky 目標支援[現代瀏覽器](#browser-support)、Node.js、Bun 和 Deno。

它只是一個沒有任何依賴的小型套件。

## 比原生 `fetch` 的優點

- 更簡單的 API
- 方法快捷方式（如 `ky.post()`）
- 將非 2xx 狀態碼視為錯誤（重定向後）
- 失敗請求自動重試
- JSON 選項
- 支援逾時
- URL 前綴選項
- 可自訂預設值的實例
- Hooks
- TypeScript 友善（例如 `.json()` 支援泛型且預設為 `unknown` 而非 `any`）

## 安裝

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## 使用方式

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

若使用原生 `fetch`，則為：

```js
class HTTPError extends Error {}

const response = await fetch('https://example.com', {
	method: 'POST',
	body: JSON.stringify({foo: true}),
	headers: {
		'content-type': 'application/json'
	}
});

if (!response.ok) {
	throw new HTTPError(`Fetch error: ${response.statusText}`);
}

const json = await response.json();

console.log(json);
//=> {data: '🦄'}
```

如果你使用 [Deno](https://github.com/denoland/deno)，請從 URL 匯入 Ky。例如，使用 CDN：

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` 和 `options` 與 [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) 相同，並提供額外的 `options`（見下方）。

回傳一個帶有[ `Body` 方法](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) 的 [`Response` 物件](https://developer.mozilla.org/en-US/docs/Web/API/Response)，方便使用。例如，你可以直接呼叫 `ky.get(input).json()`，無需先等待 `Response`。如此呼叫時，會根據所用的 body 方法自動設置合適的 `Accept` 標頭。與 `window.Fetch` 的 `Body` 方法不同，若回應狀態不在 `200...299` 範圍內，這些方法會拋出 `HTTPError`。此外，`.json()` 若遇到空 body 或回應狀態為 `204` 時，會回傳空字串，而不是因為空 body 拋出解析錯誤。

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript：** 可選用[型別參數](https://www.typescriptlang.org/docs/handbook/2/generics.html)（預設為 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)），並會傳遞至 `.json()` 的回傳型別。

```ts
import ky from 'ky';

// user1 是 unknown
const user1 = await ky('/api/users/1').json();
// user2 是 User
const user2 = await ky<User>('/api/users/2').json();
// user3 是 User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

將 `options.method` 設為方法名稱並發出請求。

⌨️ **TypeScript：** 可選用型別參數，用於 JSON 回應（參見 [`ky()`](#kyinput-options)）。

#### input

型別：`string` | `URL` | `Request`

同 [`fetch` 的 input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input)。

當 `input` 為 [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) 實例時，所有會更改 URL 的選項（例如 `prefixUrl`）將會被忽略。

#### options

型別：`object`

同 [`fetch` 的 options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options)，並額外支援以下選項：

##### method

型別：`string`\
預設值：`'get'`

發送請求所用的 HTTP 方法。

在內部，標準方法（`GET`、`POST`、`PUT`、`PATCH`、`HEAD` 和 `DELETE`）會自動轉為大寫，以避免因大小寫敏感導致的伺服器錯誤。

##### json

型別：`object` 及任何 [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) 可接受的值

用於傳送 JSON 的捷徑。請用這個選項取代 `body`。接受任何純物件或值，並會自動用 `JSON.stringify()` 處理，並附帶正確的標頭。

##### searchParams

型別：`string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
預設值：`''`

要包含在請求 URL 中的查詢參數。設定此選項會覆蓋輸入 URL 中所有現有的查詢參數。

接受任何 [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) 支援的值。

##### prefixUrl

型別：`string | URL`

發送請求時，會將此前綴加在 `input` URL 前。可以是任何有效的 URL，無論是相對還是絕對。結尾的斜線 `/` 可有可無，必要時會自動補上。僅在 `input` 為字串時生效。使用此選項時，`input` 參數不能以斜線 `/` 開頭。

與 [`ky.extend()`](#kyextenddefaultoptions) 搭配使用，可建立針對特定用途的 Ky 實例。

```js
import ky from 'ky';

// 於 https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

注意事項：
 - `prefixUrl` 與 `input` 合併後，結果會根據頁面的[基底 URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI)（若有）來解析。
 - 使用此選項時，`input` 不可有開頭斜線，以強制一致性並避免 `input` URL 處理方式的混淆，因為啟用 `prefixUrl` 後，`input` 不會遵循正常的 URL 解析規則，這會改變開頭斜線的意義。

##### retry

型別：`object | number`\
預設值：
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

一個物件，表示 `limit`、`methods`、`statusCodes`、`afterStatusCodes` 及 `maxRetryAfter` 欄位，用於設定最大重試次數、允許的請求方法、允許的狀態碼、允許使用 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 時間的狀態碼，以及最大 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 時間。

如果 `retry` 為數字，則會被用作 `limit`，其他預設值則會保持不變。

如果回應提供的 HTTP 狀態碼包含在 `afterStatusCodes` 中，Ky 會等待 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 標頭中給定的日期、逾時或時間戳記過後才會重試請求。如果沒有 `Retry-After`，則會以非標準的 [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) 標頭作為備用。如果提供的狀態碼不在清單中，則會忽略 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 標頭。

如果 `maxRetryAfter` 設為 `undefined`，則會使用 `options.timeout`。如果 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 標頭大於 `maxRetryAfter`，則會使用 `maxRetryAfter`。

`backoffLimit` 選項為每次重試延遲的上限（毫秒）。
如要限制延遲，例如設置 `backoffLimit` 為 1000。
預設情況下，延遲計算方式為 `0.3 * (2 ** (attemptCount - 1)) * 1000`。延遲會呈指數增長。

`delay` 選項可用來變更重試間隔延遲的計算方式。該函式接收一個參數，為目前的重試次數（從 1 開始）。

重試不會在 [逾時](#timeout) 後觸發。

```js
import ky from 'ky';

const json = await ky('https://example.com', {
	retry: {
		limit: 10,
		methods: ['get'],
		statusCodes: [413],
		backoffLimit: 3000
	}
}).json();
```

##### timeout

類型：`number | false`\
預設值：`10000`

取得回應的逾時時間（毫秒），包含所有重試。不可超過 2147483647。
若設為 `false`，則不會有逾時限制。

##### hooks

類型：`object<string, Function[]>`\
預設值：`{beforeRequest: [], beforeRetry: [], afterResponse: []}`

hooks 允許在請求生命週期中進行修改。hook 函式可以是 async，且會依序執行。

###### hooks.beforeRequest

類型：`Function[]`\
預設值：`[]`

此 hook 可讓你在請求發送前修改請求。Ky 在此之後不會再對請求做任何更動。hook 函式會接收 `request` 與 `options` 作為參數。你可以在這裡修改 `request.headers`。

hook 可回傳一個 [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) 以取代即將送出的請求，或回傳 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) 以完全避免發送 HTTP 請求。這可以用來模擬請求、檢查內部快取等。**重要提示**：若從此 hook 回傳 request 或 response，剩下的 `beforeRequest` hooks 會被略過，所以你可能只想在最後一個 hook 回傳它們。

```js
import ky from 'ky';

const api = ky.extend({
	hooks: {
		beforeRequest: [
			request => {
				request.headers.set('X-Requested-With', 'ky');
			}
		]
	}
});

const response = await api.get('https://example.com/api/users');
```

###### hooks.beforeRetry

類型：`Function[]`\
預設值：`[]`

此 hook 可讓你在重試前修改請求。Ky 在此之後不會再對請求做任何更動。hook 函式接收一個包含標準化 request 和 options 的物件、一個錯誤實例，以及重試次數。你可以在這裡修改 `request.headers`。

如果請求收到回應，錯誤將是 `HTTPError` 類型，`Response` 物件可從 `error.response` 取得。請注意，某些錯誤如網路錯誤，代表請求沒有收到回應，這時錯誤就不會是 `HTTPError` 實例。

你可以透過丟出錯誤來阻止 Ky 重試請求。Ky 不會再處理該錯誤，錯誤會傳遞給請求發起者。剩下的 `beforeRetry` hooks 也不會被呼叫。或者，你也可以回傳 [`ky.stop`](#kystop) 符號以達到相同效果，但不會拋出錯誤（有些限制，詳見 `ky.stop` 文件）。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		beforeRetry: [
			async ({request, options, error, retryCount}) => {
				const token = await ky('https://example.com/refresh-token');
				request.headers.set('Authorization', `token ${token}`);
			}
		]
	}
});
```

###### hooks.beforeError

類型：`Function[]`\
預設值：`[]`

此 hook 可讓你在拋出 `HTTPError` 前修改錯誤。hook 函式接收一個 `HTTPError` 作為參數，且應回傳一個 `HTTPError` 實例。

```js
import ky from 'ky';

await ky('https://example.com', {
	hooks: {
		beforeError: [
			error => {
				const {response} = error;
				if (response && response.body) {
					error.name = 'GitHubError';
					error.message = `${response.body.message} (${response.status})`;
				}

				return error;
			}
		]
	}
});
```

###### hooks.afterResponse

類型：`Function[]`\
預設值：`[]`

此 hook 可讓你讀取並選擇性地修改回應。hook 函式會接收標準化的 request、options，以及回應的 clone 作為參數。如果回傳值為 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) 實例，Ky 會將其作為回應物件使用。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// 你可以在這裡對 response 做一些操作，例如記錄。
				log(response);

				// 或回傳一個 `Response` 實例以覆蓋回應內容。
				return new Response('A different response', {status: 200});
			},

			// 或者在 403 錯誤時用新 token 重試
			async (request, options, response) => {
				if (response.status === 403) {
					// 取得新 token
					const token = await ky('https://example.com/token').text();

					// 攜帶 token 重試
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

類型：`boolean`\
預設值：`true`

當回應最終（經過重導之後）狀態碼不是 2xx 時，拋出 `HTTPError`。若你想對重導也拋錯而不是跟隨重導，請將 [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) 選項設為 `'manual'`。

將此設為 `false` 在你需檢查資源可用性、預期會有錯誤回應時很有用。

注意：若為 `false`，錯誤回應會被當作成功，且請求將不會被重試。

##### onDownloadProgress

類型：`Function`

下載進度事件處理器。

該函式會收到以下參數：
- `progress` 是一個包含下列屬性的物件：
- - `percent`：0 到 1 之間的數字，表示進度百分比。
- - `transferredBytes`：目前已傳輸的位元組數。
- - `totalBytes`：預計要傳輸的總位元組數。如果無法確定總大小則為 0。
- `chunk`：一個包含已傳輸資料的 `Uint8Array` 實例。注意：第一次呼叫時為空。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// 範例輸出：
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

類型：`Function`
上傳進度事件處理器。

該函數接收以下參數：
- `progress` 是一個物件，具有以下屬性：
- - `percent` 是一個介於 0 和 1 之間的數字，表示進度百分比。
- - `transferredBytes` 是目前已傳輸的位元組數。
- - `totalBytes` 是要傳輸的總位元組數。這是個估計值，若無法確定總大小則可能為 0。
- `chunk` 是一個包含已傳送資料的 `Uint8Array` 實例。注意：最後一次呼叫時為空。

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// 範例輸出：
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

型別：`Function`\
預設值：`JSON.parse()`

自訂的 JSON 解析函數。

使用情境：
1. 透過 [`bourne` 套件](https://github.com/hapijs/bourne) 解析 JSON，以防止原型污染。
2. 使用 [`JSON.parse()` 的 `reviver` 選項](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) 解析 JSON。

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

型別：`Function`\
預設值：`JSON.stringify()`

自訂的 JSON 字串化函數。

使用情境：
1. 使用自訂的 `replacer` 函數將 JSON 字串化。

```js
import ky from 'ky';
import {DateTime} from 'luxon';

const json = await ky('https://example.com', {
	stringifyJson: data => JSON.stringify(data, (key, value) => {
		if (key.endsWith('_at')) {
			return DateTime.fromISO(value).toSeconds();
		}

		return value;
	})
}).json();
```

##### fetch

型別：`Function`\
預設值：`fetch`

自訂的 `fetch` 函數。
必須完全相容於 [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) 標準。

使用情境：
1. 使用自訂的 `fetch` 實作，例如 [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch)。
2. 使用某些使用伺服器端渲染 (SSR) 框架提供的 `fetch` 包裝函數。

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

建立一個新的 `ky` 實例，並用你自己的預設值覆蓋部分設定。

與 `ky.create()` 不同，`ky.extend()` 會從其父級繼承預設值。

你可以將 headers 以 `Headers` 實例或純物件的形式傳遞。

你可以透過傳遞 `undefined` 值來使用 `.extend()` 移除標頭。
若以字串型態傳遞 `undefined`，僅會從 `Headers` 實例來源移除該標頭。

同樣地，你也可以通過將 hook 明確設為 `undefined` 來移除現有的 `hooks` 項目。

```js
import ky from 'ky';

const url = 'https://sindresorhus.com';

const original = ky.create({
	headers: {
		rainbow: 'rainbow',
		unicorn: 'unicorn'
	},
	hooks: {
		beforeRequest: [ () => console.log('before 1') ],
		afterResponse: [ () => console.log('after 1') ],
	},
});

const extended = original.extend({
	headers: {
		rainbow: undefined
	},
	hooks: {
		beforeRequest: undefined,
		afterResponse: [ () => console.log('after 2') ],
	}
});

const response = await extended(url).json();
//=> after 1
//=> after 2

console.log('rainbow' in response);
//=> false

console.log('unicorn' in response);
//=> true
```

你也可以通過傳遞函數給 `.extend()` 來參考父級的預設值。

```js
import ky from 'ky';

const api = ky.create({prefixUrl: 'https://example.com/api'});

const usersApi = api.extend((options) => ({prefixUrl: `${options.prefixUrl}/users`}));

const response = await usersApi.get('123');
//=> 'https://example.com/api/users/123'

const response = await api.get('version');
//=> 'https://example.com/api/version'
```

### ky.create(defaultOptions)

建立一個具有全新預設值的 Ky 實例。

```js
import ky from 'ky';

// 在 https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

型別：`object`

### ky.stop

一個可以由 `beforeRetry` hook 回傳以停止重試的 `Symbol`。這也會中斷剩餘的 `beforeRetry` hooks。

注意：回傳此 symbol 會讓 Ky 中止並回傳 `undefined` 作為回應。在存取回應任何屬性之前請務必先檢查是否有回應，或使用 [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining)。此外，它與如 `.json()` 或 `.text()` 等 body 方法不相容，因為沒有回應可供解析。通常，我們建議改為拋出錯誤，這樣會讓 Ky 中止並拋出異常，從而避免這些限制。

`ky.stop` 的一個合理用途是在進行具有副作用的請求時防止重試，例如將用戶端活動記錄到伺服器，這時回傳的資料並不重要。

```js
import ky from 'ky';

const options = {
	hooks: {
		beforeRetry: [
			async ({request, options, error, retryCount}) => {
				const shouldStopRetry = await ky('https://example.com/api');
				if (shouldStopRetry) {
					return ky.stop;
				}
			}
		]
	}
};
```
// 請注意，如果回傳 `ky.stop`，則 response 會是 `undefined`。
const response = await ky.post('https://example.com', options);

// 不支援使用 `.text()` 或其他 body 方法。
const text = await ky('https://example.com', options).text();
```

### HTTPError

暴露給 `instanceof` 檢查。該錯誤具有一個 `response` 屬性，包含 [`Response` 物件](https://developer.mozilla.org/en-US/docs/Web/API/Response)，`request` 屬性包含 [`Request` 物件](https://developer.mozilla.org/en-US/docs/Web/API/Request)，以及 `options` 屬性，為標準化後的選項（可以是在使用 `ky.create()` 建立實例時傳入 `ky` 的選項，也可以是在執行請求時直接傳入的）。

請注意，某些型別的錯誤，例如網路錯誤，本質上表示未收到回應。在這種情況下，該錯誤不會是 HTTPError 的實例，且不會包含 `response` 屬性。

如果你需要在發生 `HTTPError` 時讀取實際回應，可以在回應物件上呼叫對應的解析器方法。例如：

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript：** 接受一個可選的 [型別參數](https://www.typescriptlang.org/docs/handbook/2/generics.html)，預設為 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)，並會傳遞到 `error.response.json()` 的回傳型別中。

### TimeoutError

當請求逾時時所拋出的錯誤。它有一個 `request` 屬性，包含 [`Request` 物件](https://developer.mozilla.org/en-US/docs/Web/API/Request)。

## 小技巧

### 傳送表單資料

在 Ky 中傳送表單資料與 `fetch` 完全相同。只要將 [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) 實例傳給 `body` 選項即可。`Content-Type` 標頭會自動設為 `multipart/form-data`。

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

如果你想以 `application/x-www-form-urlencoded` 格式傳送資料，你需要使用 [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) 來編碼資料。

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### 設定自訂 `Content-Type`

Ky 會根據請求主體中的資料，自動為每個請求設置合適的 [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) 標頭。不過，有些 API 需要自訂的、非標準的內容型別，例如 `application/x-amz-json-1.1`。你可以使用 `headers` 選項手動覆蓋內容型別。

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {
	headers: {
		'content-type': 'application/json'
	},
	json: {
		foo: true
	},
}).json();

console.log(json);
//=> {data: '🦄'}
```

### 取消請求

Fetch（Ky 也是如此）內建通過 [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) 支援請求取消。[進一步閱讀。](https://developers.google.com/web/updates/2017/09/abortable-fetch)

範例：

```js
import ky from 'ky';

const controller = new AbortController();
const {signal} = controller;

setTimeout(() => {
	controller.abort();
}, 5000);

try {
	console.log(await ky(url, {signal}).text());
} catch (error) {
	if (error.name === 'AbortError') {
		console.log('Fetch aborted');
	} else {
		console.error('Fetch error:', error);
	}
}
```

## 常見問題

#### 如何在 Node.js 中使用這個套件？

Node.js 18 及以上版本原生支援 `fetch`，所以可以直接使用這個套件。

#### 如何在使用伺服器端渲染（SSR）的 Web 應用（React、Vue.js 等）中使用？

同上。

#### 如何測試使用這個套件的瀏覽器函式庫？

可以使用能在瀏覽器中運行的測試執行器，例如 Mocha，或使用 [AVA](https://avajs.dev) 搭配 `ky-universal`。[進一步閱讀。](https://github.com/sindresorhus/ky-universal#faq)

#### 如何在不使用 Webpack 等打包工具的情況下使用這個套件？

請確保你的程式碼以 JavaScript 模組（ESM）形式運行，例如在 HTML 文件中使用 `<script type="module">` 標籤。這樣 Ky 就可以直接被該模組引用，而無需打包工具或其他工具。

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### 它與 [`got`](https://github.com/sindresorhus/got) 有什麼不同？

請參考我在 [這裡](https://twitter.com/sindresorhus/status/1037406558945042432) 的回答。Got 由與 Ky 相同的人維護。

#### 它與 [`axios`](https://github.com/axios/axios) 有什麼不同？

請參考我在 [這裡](https://twitter.com/sindresorhus/status/1037763588826398720) 的回答。

#### 它與 [`r2`](https://github.com/mikeal/r2) 有什麼不同？

請參考我在 [#10](https://github.com/sindresorhus/ky/issues/10) 的回答。

#### `ky` 是什麼意思？

這只是我能搶到的一個隨機 npm 套件短名稱。不過，在日語中它確實有一個意思：

> 一種可用於簡訊的俚語，KY 是「空気読めない」(kuuki yomenai) 的縮寫，意思是「不會讀空氣」。這個詞用來形容那些察覺不到言外之意的人。

## 瀏覽器支援

最新版本的 Chrome、Firefox 和 Safari。

## Node.js 支援

Node.js 18 及以上版本。

## 相關資源

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - 用於 Fetch 的實用工具
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - 用於修改物件請求和回應大小寫的 Ky hooks

## 維護者

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---