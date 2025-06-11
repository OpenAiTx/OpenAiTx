<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky는 [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)를 기반으로 한 작고 우아한 HTTP 클라이언트입니다.

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky는 [최신 브라우저](#browser-support), Node.js, Bun, 그리고 Deno를 지원합니다.

이 패키지는 의존성이 없는 매우 작은 패키지입니다.

## 순수 `fetch` 대비 장점

- 더 간단한 API
- 메서드 단축키 (`ky.post()`)
- 2xx가 아닌 상태 코드를 오류로 처리 (리디렉션 이후)
- 실패한 요청 재시도
- JSON 옵션
- 타임아웃 지원
- URL prefix 옵션
- 사용자 정의 기본값이 적용된 인스턴스
- Hooks
- TypeScript 편의성 (예: `.json()`은 제네릭을 지원하며 기본값이 `any`가 아닌 `unknown`)

## 설치

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## 사용법

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

순수 `fetch`를 사용할 경우:

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

[Deno](https://github.com/denoland/deno)를 사용하는 경우, Ky를 URL에서 import 하십시오. 예를 들어 CDN을 사용할 때:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input`과 `options`는 [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)와 동일하며, 추가적인 `options`도 사용할 수 있습니다(아래 참고).

[`Body` 메서드](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body)가 추가된 [`Response` 객체](https://developer.mozilla.org/en-US/docs/Web/API/Response)를 반환합니다. 따라서, 예를 들어 `ky.get(input).json()`을 바로 호출할 수 있으며 `Response`를 먼저 await 할 필요가 없습니다. 이렇게 호출할 경우, 사용된 body 메서드에 따라 적절한 `Accept` 헤더가 설정됩니다. `window.Fetch`의 `Body` 메서드와 달리, 응답 상태가 `200...299` 범위가 아니면 `HTTPError`를 throw 합니다. 또한, `.json()`은 body가 비어있거나 응답 상태가 `204`일 경우 파싱 오류를 발생시키지 않고 빈 문자열을 반환합니다.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** 선택적으로 [타입 파라미터](https://www.typescriptlang.org/docs/handbook/2/generics.html)를 받을 수 있으며, 기본값은 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)이고, `.json()`의 반환 타입으로 전달됩니다.

```ts
import ky from 'ky';

// user1의 타입은 unknown
const user1 = await ky('/api/users/1').json();
// user2의 타입은 User
const user2 = await ky<User>('/api/users/2').json();
// user3의 타입은 User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

`options.method`를 해당 메서드명으로 설정하고 요청을 보냅니다.

⌨️ **TypeScript:** JSON 응답에 사용할 선택적 타입 파라미터를 받을 수 있습니다([`ky()`](#kyinput-options) 참고).

#### input

타입: `string` | `URL` | `Request`

[`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input)과 동일합니다.

[`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) 인스턴스를 `input`으로 사용할 때는, URL을 변경하는 옵션(예: `prefixUrl`)이 무시됩니다.

#### options

타입: `object`

[`fetch` 옵션](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options)과 동일하며, 다음과 같은 추가 옵션이 있습니다:

##### method

타입: `string`\
기본값: `'get'`

요청에 사용할 HTTP 메서드입니다.

내부적으로 표준 메서드(`GET`, `POST`, `PUT`, `PATCH`, `HEAD`, `DELETE`)는 대문자로 변환되어 서버의 대소문자 구분 오류를 방지합니다.

##### json

타입: `object` 및 [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)가 허용하는 기타 값

JSON 전송을 위한 단축키입니다. `body` 옵션 대신 사용하세요. 일반 객체나 값을 받아 `JSON.stringify()`로 변환 후, 적절한 헤더와 함께 body에 전송합니다.

##### searchParams

타입: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
기본값: `''`

요청 URL에 포함할 쿼리 파라미터입니다. 설정 시 input URL의 기존 쿼리 파라미터를 모두 덮어씁니다.

[`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams)가 지원하는 모든 값을 허용합니다.

##### prefixUrl

타입: `string | URL`

요청 시 `input` URL 앞에 붙일 prefix입니다. 상대 또는 절대 경로 모두 허용합니다. 후행 슬래시 `/`는 필요시 자동으로 추가됩니다. 문자열로 `input`을 사용할 때만 적용됩니다. 이 옵션을 사용할 때 `input` 인자는 슬래시 `/`로 시작할 수 없습니다.

[`ky.extend()`](#kyextenddefaultoptions)와 함께 사용하여 특정 목적에 맞는 Ky 인스턴스를 만들 때 유용합니다.

```js
import ky from 'ky';

// https://example.com에서

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

참고:
 - `prefixUrl`과 `input`이 결합된 후, 결과는 페이지의 [base URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI)(있을 경우)을 기준으로 해석됩니다.
 - 이 옵션을 사용할 때 `input`에 슬래시(`/`)로 시작하는 것은 허용되지 않습니다. 일관성 및 URL 처리 방식의 혼란을 방지하기 위함이며, `prefixUrl` 사용 시 `input`이 일반적인 URL 해석 규칙을 따르지 않기 때문입니다.

##### retry

타입: `object | number`\
기본값:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

`limit`, `methods`, `statusCodes`, `afterStatusCodes`, 그리고 `maxRetryAfter` 필드를 나타내는 객체로, 최대 재시도 횟수, 허용되는 메서드, 허용되는 상태 코드, [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 시간을 사용할 수 있는 상태 코드, 그리고 최대 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 시간을 지정합니다.

`retry`가 숫자인 경우, 해당 값이 `limit`으로 사용되며 나머지 기본값은 그대로 유지됩니다.

응답이 `afterStatusCodes`에 포함된 HTTP 상태 코드를 제공하면 Ky는 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 헤더에 명시된 날짜, 타임아웃 또는 타임스탬프가 지난 후 요청을 재시도합니다. 만약 `Retry-After`가 없으면, 비표준 [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) 헤더가 대체로 사용됩니다. 제공된 상태 코드가 목록에 없으면 [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 헤더는 무시됩니다.

`maxRetryAfter`가 `undefined`로 설정되면, `options.timeout`이 사용됩니다. [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 헤더 값이 `maxRetryAfter`보다 크면, `maxRetryAfter` 값이 사용됩니다.

`backoffLimit` 옵션은 재시도마다 최대 지연 시간을 밀리초 단위로 지정합니다.
예를 들어, 지연 시간을 제한하려면 `backoffLimit`을 1000으로 설정하십시오.
기본적으로 지연 시간은 `0.3 * (2 ** (attemptCount - 1)) * 1000`으로 계산됩니다. 지연 시간은 지수적으로 증가합니다.

`delay` 옵션을 사용하여 재시도 간 지연 시간 계산 방식을 변경할 수 있습니다. 이 함수는 시도 횟수(1부터 시작)를 인자로 받습니다.

[timeout](#timeout) 이후에는 재시도가 발생하지 않습니다.

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

타입: `number | false`\
기본값: `10000`

응답을 받기 위한 타임아웃(밀리초 단위, 재시도 포함)입니다. 2147483647보다 클 수 없습니다.
`false`로 설정하면 타임아웃이 없습니다.

##### hooks

타입: `object<string, Function[]>`\
기본값: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks는 요청 라이프사이클 중에 수정 작업을 허용합니다. Hook 함수는 async일 수 있으며 순차적으로 실행됩니다.

###### hooks.beforeRequest

타입: `Function[]`\
기본값: `[]`

이 훅을 사용하면 요청이 전송되기 직전에 요청을 수정할 수 있습니다. 이 이후로 Ky는 요청에 대해 추가로 변경하지 않습니다. 훅 함수는 `request`와 `options`를 인수로 받습니다. 예를 들어, 여기서 `request.headers`를 수정할 수 있습니다.

훅은 나가는 요청을 대체할 [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request)를 반환하거나, HTTP 요청 자체를 하지 않도록 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response)를 반환할 수 있습니다. 이를 통해 요청을 모킹하거나, 내부 캐시를 확인하는 등의 작업이 가능합니다. **중요:** 이 훅에서 request나 response를 반환하면 남은 `beforeRequest` 훅들은 건너뛰게 되므로, 마지막 훅에서만 반환하는 것이 좋습니다.

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

타입: `Function[]`\
기본값: `[]`

이 훅을 사용하면 재시도 직전에 요청을 수정할 수 있습니다. 이 이후로 Ky는 요청에 대해 추가로 변경하지 않습니다. 훅 함수는 정규화된 request, options, 에러 인스턴스, 재시도 횟수가 포함된 객체를 인수로 받습니다. 예를 들어 여기서 `request.headers`를 수정할 수 있습니다.

요청이 응답을 받았다면, 에러는 `HTTPError` 타입이며 `error.response`에서 `Response` 객체를 사용할 수 있습니다. 네트워크 오류 등 일부 에러는 응답을 받지 못할 수 있으니, 이 경우에는 에러가 `HTTPError` 인스턴스가 아닐 수 있습니다.

재시도를 방지하려면 에러를 throw 하십시오. Ky는 해당 에러를 처리하지 않으며, 요청을 시작한 쪽으로 에러가 전파됩니다. 이런 경우 남은 `beforeRetry` 훅들은 호출되지 않습니다. 또는 [`ky.stop`](#kystop) 심볼을 반환하여 에러를 전파하지 않고 같은 효과를 낼 수 있습니다(자세한 내용은 `ky.stop` 문서 참조).

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

타입: `Function[]`\
기본값: `[]`

이 훅을 사용하면 `HTTPError`가 throw 되기 직전에 수정할 수 있습니다. 훅 함수는 `HTTPError`를 인수로 받고, `HTTPError` 인스턴스를 반환해야 합니다.

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

타입: `Function[]`\
기본값: `[]`

이 훅을 사용하면 응답을 읽고 선택적으로 수정할 수 있습니다. 훅 함수는 정규화된 request, options, 복제된 response를 인수로 받습니다. 훅 함수의 반환값이 [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) 인스턴스라면 Ky는 이를 응답 객체로 사용합니다.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// 예시: 응답을 로깅하는 등
				log(response);

				// 또는 응답을 덮어쓸 `Response` 인스턴스 반환
				return new Response('A different response', {status: 200});
			},

			// 또는 403 에러 시 토큰 갱신 후 재시도
			async (request, options, response) => {
				if (response.status === 403) {
					// 새 토큰 발급
					const token = await ky('https://example.com/token').text();

					// 토큰과 함께 재시도
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

타입: `boolean`\
기본값: `true`

리디렉션을 따른 후에도 응답이 2xx가 아닌 상태 코드일 때 `HTTPError`를 throw 합니다. 리디렉션도 예외로 처리하려면 [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) 옵션을 `'manual'`로 설정하세요.

리소스 가용성 확인 등 에러 응답이 예상되는 경우, 이 값을 `false`로 설정하는 것이 유용할 수 있습니다.

참고: `false`인 경우 에러 응답도 성공으로 간주되며, 요청이 재시도되지 않습니다.

##### onDownloadProgress

타입: `Function`

다운로드 진행 상황 이벤트 핸들러입니다.

함수는 다음 인자를 받습니다:
- `progress`: 아래 속성을 가진 객체
- - `percent`: 진행률(0과 1 사이의 숫자)
- - `transferredBytes`: 지금까지 전송된 바이트 수
- - `totalBytes`: 전체 전송 바이트 수(추정치, 전체 크기를 알 수 없는 경우 0일 수 있음)
- `chunk`: 전송된 데이터가 담긴 `Uint8Array` 인스턴스. 참고: 첫 호출에서는 비어 있음.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// 예시 출력:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

타입: `Function`
업로드 진행 이벤트 핸들러.

이 함수는 다음과 같은 인수를 받습니다:
- `progress`는 다음 속성을 가진 객체입니다:
  - `percent`는 진행 퍼센티지를 나타내는 0과 1 사이의 숫자입니다.
  - `transferredBytes`는 지금까지 전송된 바이트 수입니다.
  - `totalBytes`는 전송될 전체 바이트 수입니다. 이는 추정치이며 전체 크기를 알 수 없을 경우 0일 수 있습니다.
- `chunk`는 전송된 데이터를 포함하는 `Uint8Array` 인스턴스입니다. 참고: 마지막 호출에서는 비어 있습니다.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// 예시 출력:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

타입: `Function`\
기본값: `JSON.parse()`

사용자 정의 JSON 파싱 함수.

사용 사례:
1. [`bourne` 패키지](https://github.com/hapijs/bourne)를 통해 JSON을 파싱하여 프로토타입 오염을 방지.
2. [`JSON.parse()`의 `reviver` 옵션](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse)을 사용하여 JSON 파싱.

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

타입: `Function`\
기본값: `JSON.stringify()`

사용자 정의 JSON 문자열화 함수.

사용 사례:
1. 사용자 정의 `replacer` 함수를 사용하여 JSON을 문자열화.

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

타입: `Function`\
기본값: `fetch`

사용자 정의 `fetch` 함수.
[Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) 표준과 완전히 호환되어야 합니다.

사용 사례:
1. [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch)과 같은 사용자 정의 `fetch` 구현 사용.
2. 서버 사이드 렌더링(SSR)을 사용하는 일부 프레임워크에서 제공하는 `fetch` 래퍼 함수 사용.

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

기본값 중 일부를 자신의 값으로 덮어쓴 새로운 `ky` 인스턴스를 생성합니다.

`ky.create()`와 달리, `ky.extend()`는 부모의 기본값을 상속합니다.

헤더는 `Headers` 인스턴스나 일반 객체로 전달할 수 있습니다.

`.extend()`에 헤더를 `undefined` 값으로 전달하여 헤더를 제거할 수 있습니다.
문자열로서 `undefined`를 전달하면 해당 헤더가 `Headers` 인스턴스에서 온 경우에만 제거됩니다.

마찬가지로, 명시적으로 `undefined`로 후크를 확장하여 기존 `hooks` 항목을 제거할 수 있습니다.

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

함수를 `.extend()`에 제공하여 부모 기본값을 참조할 수도 있습니다.

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

완전히 새로운 기본값으로 새로운 Ky 인스턴스를 생성합니다.

```js
import ky from 'ky';

// https://my-site.com 에서

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

타입: `object`

### ky.stop

재시도를 중지하기 위해 `beforeRetry` 훅에서 반환할 수 있는 `Symbol`입니다. 이것은 남은 `beforeRetry` 훅도 단락(short circuit)됩니다.

참고: 이 심볼을 반환하면 Ky는 중단되고 `undefined` 응답을 반환합니다. 응답의 속성에 접근하기 전에 반드시 응답이 있는지 확인하거나 [옵셔널 체이닝](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining)을 사용하세요. 또한, 본문 메서드(예: `.json()`, `.text()` 등)와는 호환되지 않습니다. 응답이 없기 때문입니다. 일반적으로 이 심볼을 반환하는 것보다 오류를 throw하는 것이 더 낫습니다. 오류를 throw하면 Ky가 중단되고 예외를 발생시키므로 이런 제한을 피할 수 있습니다.

`ky.stop`의 유효한 사용 사례는 반환 데이터가 중요하지 않은 부수 효과(side effect)를 위한 요청에서 재시도를 방지하는 것입니다. 예: 클라이언트 활동을 서버에 로깅할 때.

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
// `ky.stop`이 반환된 경우 `response`는 `undefined`가 됩니다.
const response = await ky.post('https://example.com', options);

// `.text()` 또는 기타 body 메서드는 지원되지 않습니다.
const text = await ky('https://example.com', options).text();
```

### HTTPError

`instanceof` 체크를 위해 노출되어 있습니다. 이 에러는 [`Response` 객체](https://developer.mozilla.org/en-US/docs/Web/API/Response)를 가진 `response` 속성, [`Request` 객체](https://developer.mozilla.org/en-US/docs/Web/API/Request)를 가진 `request` 속성, 그리고 정규화된 옵션(인스턴스를 `ky.create()`로 생성할 때 또는 요청 수행 시 직접 `ky`에 전달된 옵션)을 가진 `options` 속성을 가집니다.

일부 에러 유형, 예를 들어 네트워크 에러 등은 본질적으로 응답을 받지 못했음을 의미합니다. 이 경우 에러는 HTTPError의 인스턴스가 아니며 `response` 속성을 포함하지 않습니다.

`HTTPError`가 발생했을 때 실제 응답을 읽어야 한다면, response 객체에서 해당 파서 메서드를 호출하세요. 예시:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** [타입 매개변수](https://www.typescriptlang.org/docs/handbook/2/generics.html)를 옵션으로 받아들이며, 기본값은 [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)이고, `error.response.json()`의 반환 타입으로 전달됩니다.

### TimeoutError

요청이 타임아웃될 때 발생하는 에러입니다. [`Request` 객체](https://developer.mozilla.org/en-US/docs/Web/API/Request)를 가진 `request` 속성을 가집니다.

## Tips

### 폼 데이터 전송

Ky에서 폼 데이터를 전송하는 방법은 `fetch`와 동일합니다. `body` 옵션에 [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) 인스턴스를 전달하세요. `Content-Type` 헤더는 자동으로 `multipart/form-data`로 설정됩니다.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

`application/x-www-form-urlencoded` 형식으로 데이터를 보내고 싶다면, [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams)로 데이터를 인코딩해야 합니다.

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### 사용자 지정 `Content-Type` 설정

Ky는 요청 본문의 데이터에 따라 적절한 [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) 헤더를 자동으로 설정합니다. 하지만 일부 API는 `application/x-amz-json-1.1`과 같은 비표준 콘텐츠 타입을 요구할 수 있습니다. 이 경우 `headers` 옵션을 사용해 수동으로 콘텐츠 타입을 오버라이드할 수 있습니다.

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

### 요청 취소

Fetch(그리고 Ky)는 [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController)를 통한 요청 취소를 기본적으로 지원합니다. [더 알아보기.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

예시:

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

## FAQ

#### Node.js에서 어떻게 사용하나요?

Node.js 18 이상에서는 `fetch`를 네이티브로 지원하므로 이 패키지를 바로 사용할 수 있습니다.

#### 서버 사이드 렌더링(SSR)을 사용하는 웹 앱(React, Vue.js 등)에서 어떻게 사용하나요?

위와 동일하게 사용하면 됩니다.

#### 이 패키지를 사용하는 브라우저 라이브러리를 어떻게 테스트하나요?

Mocha와 같이 브라우저에서 실행 가능한 테스트 러너를 사용하거나, [AVA](https://avajs.dev)와 `ky-universal`을 사용하세요. [더 알아보기.](https://github.com/sindresorhus/ky-universal#faq)

#### Webpack과 같은 번들러 없이 사용하려면 어떻게 하나요?

코드가 JavaScript 모듈(ESM)로 실행되고 있는지 확인하세요. 예를 들어 HTML 문서에서 `<script type="module">` 태그를 사용하세요. 그러면 Ky를 번들러나 다른 도구 없이 해당 모듈에서 직접 임포트할 수 있습니다.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### [`got`](https://github.com/sindresorhus/got)과의 차이점은 무엇인가요?

[여기](https://twitter.com/sindresorhus/status/1037406558945042432)에서 답변을 확인하세요. Got은 Ky와 동일한 사람들이 관리합니다.

#### [`axios`](https://github.com/axios/axios)와의 차이점은 무엇인가요?

[여기](https://twitter.com/sindresorhus/status/1037763588826398720)에서 답변을 확인하세요.

#### [`r2`](https://github.com/mikeal/r2)와의 차이점은 무엇인가요?

[#10](https://github.com/sindresorhus/ky/issues/10)에서 답변을 확인하세요.

#### `ky`는 무슨 뜻인가요?

그냥 운좋게 얻은 짧은 npm 패키지명입니다. 하지만 일본어로 의미가 있긴 합니다:

> 문자로 표현 가능한 속어의 한 형태인 KY는 空気読めない(쿠키 요메나이)의 약자로, 직역하면 "공기를 읽지 못한다"라는 뜻입니다. 암시된 의미를 읽지 못하는 사람에게 사용되는 표현입니다.

## 브라우저 지원

최신 버전의 Chrome, Firefox, Safari를 지원합니다.

## Node.js 지원

Node.js 18 이상.

## 관련

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Fetch 작업에 유용한 유틸리티
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - 객체의 요청과 응답 케이스를 변경하는 Ky 훅

## 유지관리자

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---