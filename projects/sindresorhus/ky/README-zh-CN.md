<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky 是一个基于 [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) 的小巧优雅的 HTTP 客户端

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky 适用于[现代浏览器](#browser-support)、Node.js、Bun 和 Deno。

它只是一个无依赖的小型包。

## 相较于原生 `fetch` 的优势

- 更简单的 API
- 方法快捷方式（如 `ky.post()`）
- 将非 2xx 状态码视为错误（重定向后）
- 自动重试失败的请求
- JSON 选项
- 支持超时
- URL 前缀选项
- 带有自定义默认值的实例
- 钩子（Hooks）
- TypeScript 优化（如 `.json()` 支持泛型并默认为 `unknown`，而不是 `any`）

## 安装

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## 用法

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

如果使用原生 `fetch`，则为：

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

如果你在使用 [Deno](https://github.com/denoland/deno)，请从 URL 导入 Ky。例如，使用 CDN：

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` 和 `options` 与 [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) 相同，同时还提供了额外的 `options`（见下文）。

返回一个带有便捷 [`Body` 方法](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) 的 [`Response` 对象](https://developer.mozilla.org/en-US/docs/Web/API/Response)。因此，你可以直接调用 `ky.get(input).json()`，而无需先等待 `Response`。以这种方式调用时，会根据所使用的 body 方法自动设置合适的 `Accept` 头。与 `window.Fetch` 的 `Body` 方法不同，这些方法会在响应状态码不在 `200...299` 区间时抛出 `HTTPError`。另外，如果响应体为空或状态码为 `204`，`.json()` 将返回空字符串，而不是因空 body 抛出解析错误。

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript：** 接受一个可选的[类型参数](https://www.typescriptlang.org/docs/handbook/2/generics.html)，默认为 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)，并会传递给 `.json()` 的返回类型。

```ts
import ky from 'ky';

// user1 类型为 unknown
const user1 = await ky('/api/users/1').json();
// user2 类型为 User
const user2 = await ky<User>('/api/users/2').json();
// user3 类型为 User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

将 `options.method` 设置为方法名并发起请求。

⌨️ **TypeScript：** JSON 响应时可选类型参数（见 [`ky()`](#kyinput-options)）。

#### input

类型: `string` | `URL` | `Request`

与 [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input) 相同。

当使用 [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) 实例作为 `input` 时，任何修改 URL 的选项（如 `prefixUrl`）都将被忽略。

#### options

类型: `object`

与 [`fetch` options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options) 相同，另外还支持以下附加选项：

##### method

类型: `string`\
默认值: `'get'`

用于发起请求的 HTTP 方法。

在内部，标准方法（`GET`、`POST`、`PUT`、`PATCH`、`HEAD` 和 `DELETE`）会被转为大写，以避免因大小写敏感导致的服务器错误。

##### json

类型: `object` 及 [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) 支持的任何其他值

用于发送 JSON 的简写。使用此选项代替 `body` 选项。接受任意普通对象或值，将被 `JSON.stringify()` 并作为请求体发送，并自动设置正确的头部。

##### searchParams

类型: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
默认值: `''`

请求 URL 中要包含的查询参数。设置此项时会覆盖输入 URL 中所有已存在的查询参数。

接受 [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) 支持的任何值。

##### prefixUrl

类型: `string | URL`

在发起请求时添加到 `input` URL 前的前缀。它可以是任意有效的 URL，相对或绝对皆可。末尾斜杠 `/` 可选，必要时会自动补全。仅当 `input` 为字符串时生效。使用此选项时，`input` 参数不能以斜杠 `/` 开头。

与 [`ky.extend()`](#kyextenddefaultoptions) 配合使用时，适合创建特定领域的 Ky 实例。

```js
import ky from 'ky';

// 当前页面为 https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

注意事项：
 - `prefixUrl` 与 `input` 拼接后，会根据页面的[基础 URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI)（如有）进行解析。
 - 为保证一致性并避免对 `input` URL 处理方式产生困惑，使用此选项时禁止 `input` 以斜杠开头，因为 `prefixUrl` 会改变 URL 的解析方式，导致以斜杠开头的含义发生变化。

##### retry

类型: `object | number`\
默认值:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

一个对象，表示用于最大重试次数、允许的方法、允许的状态码、允许使用 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 时间的状态码，以及最大 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 时间的 `limit`、`methods`、`statusCodes`、`afterStatusCodes` 和 `maxRetryAfter` 字段。

如果 `retry` 是一个数字，则它将被用作 `limit`，其他默认值保持不变。

如果响应返回的 HTTP 状态码包含在 `afterStatusCodes` 中，Ky 会等待 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 头部中指定的日期、超时或时间戳过去后再重试请求。如果没有 `Retry-After`，则会使用非标准的 [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) 头作为后备。如果提供的状态码不在列表中，则会忽略 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 头。

如果 `maxRetryAfter` 设置为 `undefined`，则会使用 `options.timeout`。如果 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 头的值大于 `maxRetryAfter`，则将使用 `maxRetryAfter`。

`backoffLimit` 选项是每次重试的最大延迟（以毫秒为单位）。
例如，为了限制延迟，可以将 `backoffLimit` 设置为 1000。
默认情况下，延迟的计算公式为 `0.3 * (2 ** (attemptCount - 1)) * 1000`，即延迟呈指数增加。

`delay` 选项可用于更改重试之间的延迟计算方式。该函数接收一个参数，即尝试次数，从 `1` 开始。

重试不会在 [超时](#timeout) 后触发。

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

类型：`number | false`\
默认值：`10000`

获取响应的超时时间（以毫秒为单位），包括所有重试。不能大于 2147483647。
如果设置为 `false`，则没有超时限制。

##### hooks

类型：`object<string, Function[]>`\
默认值：`{beforeRequest: [], beforeRetry: [], afterResponse: []}`

钩子允许你在请求生命周期中进行修改。钩子函数可以是异步的，并且会串行运行。

###### hooks.beforeRequest

类型：`Function[]`\
默认值：`[]`

此钩子允许你在请求发送前修改请求。Ky 在此之后不会再对请求做任何更改。钩子函数接收 `request` 和 `options` 作为参数。例如，你可以在这里修改 `request.headers`。

钩子可以返回一个 [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) 来替换即将发送的请求，或者返回一个 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) 以完全避免发起 HTTP 请求。这可以用于模拟请求、检查内部缓存等。**重要提示**：当从该钩子返回请求或响应时，剩余的 `beforeRequest` 钩子将被跳过，因此建议仅在最后一个钩子中返回它们。

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

类型：`Function[]`\
默认值：`[]`

此钩子允许你在重试前修改请求。Ky 在此之后不会再对请求做任何更改。钩子函数接收一个包含标准化请求和选项的对象、错误实例和重试次数。例如，你可以在这里修改 `request.headers`。

如果请求收到了响应，错误类型为 `HTTPError`，`Response` 对象可通过 `error.response` 获取。请注意，一些类型的错误（如网络错误）本身意味着未收到响应。在这种情况下，错误不会是 `HTTPError` 的实例。

你可以通过抛出错误来阻止 Ky 重试请求。Ky 不会以任何方式处理该错误，错误会被传递到请求发起方。在这种情况下，剩余的 `beforeRetry` 钩子不会被调用。或者，你可以返回 [`ky.stop`](#kystop) 符号来实现同样的效果，但不会抛出错误（有一些限制，详见 `ky.stop` 文档）。

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

类型：`Function[]`\
默认值：`[]`

此钩子允许你在抛出 `HTTPError` 之前修改它。钩子函数接收一个 `HTTPError` 作为参数，并应返回一个 `HTTPError` 实例。

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

类型：`Function[]`\
默认值：`[]`

此钩子允许你读取并可选地修改响应。钩子函数接收标准化请求、选项和响应的克隆作为参数。如果返回值是 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) 的实例，则 Ky 会将其用作响应对象。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// 你可以在这里处理响应，例如日志记录。
				log(response);

				// 或返回一个 `Response` 实例以覆盖响应。
				return new Response('A different response', {status: 200});
			},

			// 或在 403 错误时使用新令牌重试
			async (request, options, response) => {
				if (response.status === 403) {
					// 获取新令牌
					const token = await ky('https://example.com/token').text();

					// 使用令牌重试
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

类型：`boolean`\
默认值：`true`

当跟随重定向后响应的状态码不是 2xx 时，抛出 `HTTPError`。如果要在遇到重定向时抛出错误而不是跟随重定向，请将 [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) 选项设置为 `'manual'`。

如果你在检查资源可用性并且期望错误响应，将此设置为 `false` 可能会很有用。

注意：如果为 `false`，错误响应将被视为成功，请求不会被重试。

##### onDownloadProgress

类型：`Function`

下载进度事件处理函数。

该函数接收以下参数：
- `progress` 是一个对象，包含以下属性：
- - `percent`：表示进度百分比的 0 到 1 之间的数字。
- - `transferredBytes`：已传输的字节数。
- - `totalBytes`：要传输的总字节数。该值为估算值，如果无法确定总大小则可能为 0。
- `chunk` 是包含已发送数据的 `Uint8Array` 实例。注意：第一次调用时为空。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// 示例输出：
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

类型：`Function`
上传进度事件处理器。

该函数接收以下参数：
- `progress` 是一个对象，包含以下属性：
- - `percent` 是一个介于 0 和 1 之间的数字，表示进度百分比。
- - `transferredBytes` 是到目前为止已传输的字节数。
- - `totalBytes` 是要传输的总字节数。该值为估算值，如果无法确定总大小，可能为 0。
- `chunk` 是包含已发送数据的 `Uint8Array` 实例。注意：最后一次调用时为空。

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// 示例输出：
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

类型: `Function`\
默认值: `JSON.parse()`

用户自定义的 JSON 解析函数。

使用场景：
1. 通过 [`bourne` 包](https://github.com/hapijs/bourne) 解析 JSON，以防止原型污染。
2. 使用 [`JSON.parse()` 的 `reviver` 选项](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) 解析 JSON。

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

类型: `Function`\
默认值: `JSON.stringify()`

用户自定义的 JSON 字符串化函数。

使用场景：
1. 使用自定义的 `replacer` 函数对 JSON 进行字符串化。

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

类型: `Function`\
默认值: `fetch`

用户自定义的 `fetch` 函数。
必须完全兼容 [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) 标准。

使用场景：
1. 使用自定义的 `fetch` 实现，如 [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch)。
2. 使用某些框架为服务端渲染（SSR）提供的 `fetch` 包装函数。

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

创建一个新的 `ky` 实例，并用你自己的默认值覆盖部分默认设置。

与 `ky.create()` 不同，`ky.extend()` 会从其父级继承默认设置。

你可以将 headers 作为 `Headers` 实例或普通对象传递。

你可以通过在 `.extend()` 中传递值为 `undefined` 的 header 来移除该 header。
以字符串形式传递 `undefined` 只会在 header 来自 `Headers` 实例时移除该 header。

同样，你可以通过将钩子（hooks）显式设置为 `undefined`，来移除已存在的 `hooks` 条目。

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

你还可以通过给 `.extend()` 提供一个函数来引用父级默认值。

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

使用全新的默认值创建一个新的 Ky 实例。

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

类型: `object`

### ky.stop

`Symbol`，可由 `beforeRetry` 钩子返回以停止重试。这也会终止剩余的 `beforeRetry` 钩子。

注意：返回该 symbol 会使 Ky 中止并返回 `undefined` 响应。在访问响应的任何属性之前务必检查响应，或使用 [可选链](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining)。这也与诸如 `.json()` 或 `.text()` 之类的 body 方法不兼容，因为没有响应可以解析。一般来说，我们建议抛出错误而不是返回该 symbol，这样 Ky 会中止并抛出异常，从而避免这些限制。

`ky.stop` 的一个合理用例是：当你进行副作用请求且返回的数据并不重要时，防止重试。例如，将客户端活动日志发送到服务器。

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
```js
// 请注意，如果返回了 `ky.stop`，则 response 会是 `undefined`。
const response = await ky.post('https://example.com', options);

// 不支持使用 `.text()` 或其他 body 方法。
const text = await ky('https://example.com', options).text();
```

### HTTPError

暴露用于 `instanceof` 检查。该错误具有一个 `response` 属性，包含 [`Response` 对象](https://developer.mozilla.org/en-US/docs/Web/API/Response)，一个 `request` 属性，包含 [`Request` 对象](https://developer.mozilla.org/en-US/docs/Web/API/Request)，以及一个 `options` 属性，包含标准化后的选项（这些选项是在使用 `ky.create()` 创建实例时传递给 `ky` 的，或直接在请求时传递的）。

请注意，某些类型的错误（如网络错误）本质上意味着没有收到响应。在这种情况下，错误不会是 HTTPError 的实例，并且不会包含 `response` 属性。

如果你需要在发生 `HTTPError` 时读取实际响应，请在响应对象上调用相应的解析方法。例如：

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript：** 接受一个可选的[类型参数](https://www.typescriptlang.org/docs/handbook/2/generics.html)，默认为 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)，该类型会传递给 `error.response.json()` 的返回类型。

### TimeoutError

请求超时时抛出的错误。它具有一个 `request` 属性，包含 [`Request` 对象](https://developer.mozilla.org/en-US/docs/Web/API/Request)。

## 小贴士

### 发送表单数据

在 Ky 中发送表单数据与 `fetch` 完全相同。只需将 [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) 实例传递给 `body` 选项即可。`Content-Type` 头会自动设置为 `multipart/form-data`。

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

如果你想以 `application/x-www-form-urlencoded` 格式发送数据，则需要使用 [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) 对数据进行编码。

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### 设置自定义 `Content-Type`

Ky 会根据请求体中的数据自动为每个请求设置合适的 [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) 头。不过，某些 API 需要自定义的、非标准的内容类型，比如 `application/x-amz-json-1.1`。你可以通过 `headers` 选项手动覆盖内容类型。

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

### 取消请求

Fetch（因此 Ky 也一样）通过 [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) 内置支持请求取消。[了解更多。](https://developers.google.com/web/updates/2017/09/abortable-fetch)

示例：

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

## 常见问题

#### 如何在 Node.js 中使用？

Node.js 18 及以上版本原生支持 `fetch`，所以可以直接使用本包。

#### 如何在使用服务端渲染（SSR）的 Web 应用（React、Vue.js 等）中使用？

同上。

#### 如何测试使用此库的浏览器库？

可以使用可在浏览器中运行的测试运行器，如 Mocha，或使用 [AVA](https://avajs.dev) 搭配 `ky-universal`。[了解更多。](https://github.com/sindresorhus/ky-universal#faq)

#### 如何在没有如 Webpack 这样的打包工具的情况下使用？

确保你的代码以 JavaScript 模块（ESM）方式运行，例如在 HTML 文档中使用 `<script type="module">` 标签。这样 Ky 可以被该模块直接导入，无需打包工具或其他工具。

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### 它与 [`got`](https://github.com/sindresorhus/got) 有何不同？

请参见我在 [这里](https://twitter.com/sindresorhus/status/1037406558945042432) 的回答。Got 由 Ky 的同一团队维护。

#### 它与 [`axios`](https://github.com/axios/axios) 有何不同？

请参见我在 [这里](https://twitter.com/sindresorhus/status/1037763588826398720) 的回答。

#### 它与 [`r2`](https://github.com/mikeal/r2) 有何不同？

请参见我在 [#10](https://github.com/sindresorhus/ky/issues/10) 的回答。

#### `ky` 是什么意思？

这只是我抢到的一个随机简短 npm 包名。不过，它在日语中确实有含义：

> 一种可用于短信的俚语，KY 是 “空気読めない (kuuki yomenai)” 的缩写，字面意思是“不会读空气”。用来形容那些没有领会言外之意的人。

## 浏览器支持

最新版的 Chrome、Firefox 和 Safari。

## Node.js 支持

Node.js 18 及以上版本。

## 相关项目

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - 用于处理 Fetch 的实用工具
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - 用于在对象的请求和响应中修改大小写的 Ky 钩子

## 维护者

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---