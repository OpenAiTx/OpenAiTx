<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky — это миниатюрный и элегантный HTTP-клиент, основанный на [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky ориентирован на [современные браузеры](#browser-support), Node.js, Bun и Deno.

Это всего лишь небольшой пакет без зависимостей.

## Преимущества по сравнению с обычным `fetch`

- Более простой API
- Сокращения для методов (`ky.post()`)
- Рассматривает коды состояния, отличные от 2xx, как ошибки (после редиректов)
- Повторяет неудачные запросы
- Опция для работы с JSON
- Поддержка таймаутов
- Опция префикса URL
- Инстансы с пользовательскими настройками по умолчанию
- Хуки
- Преимущества TypeScript (например, `.json()` поддерживает дженерики и по умолчанию возвращает `unknown`, а не `any`)

## Установка

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Использование

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

С обычным `fetch` это выглядело бы так:

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

Если вы используете [Deno](https://github.com/denoland/deno), импортируйте Ky по URL. Например, используя CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

Параметры `input` и `options` такие же, как у [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), но доступны дополнительные опции (см. ниже).

Возвращает [объект `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) с добавленными для удобства [методами `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body). Таким образом, вы можете, например, вызывать `ky.get(input).json()` напрямую, не дожидаясь сначала `Response`. При таком вызове будет автоматически установлен соответствующий заголовок `Accept` в зависимости от используемого метода тела. В отличие от методов `Body` в `window.Fetch`, эти методы выбросят исключение `HTTPError`, если статус ответа не в диапазоне `200...299`. Также `.json()` вернет пустую строку, если тело пустое или статус ответа `204`, вместо того чтобы выбрасывать ошибку разбора из-за пустого тела.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Принимает необязательный [типовой параметр](https://www.typescriptlang.org/docs/handbook/2/generics.html), который по умолчанию равен [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) и передается в возвращаемый тип метода `.json()`.

```ts
import ky from 'ky';

// user1 имеет тип unknown
const user1 = await ky('/api/users/1').json();
// user2 имеет тип User
const user2 = await ky<User>('/api/users/2').json();
// user3 имеет тип User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Устанавливает `options.method` в имя метода и выполняет запрос.

⌨️ **TypeScript:** Принимает необязательный типовой параметр для работы с JSON-ответами (см. [`ky()`](#kyinput-options)).

#### input

Тип: `string` | `URL` | `Request`

То же, что и [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Если в качестве `input` используется экземпляр [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), любые опции, изменяющие URL (например, `prefixUrl`), будут проигнорированы.

#### options

Тип: `object`

То же, что и [опции `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), плюс следующие дополнительные опции:

##### method

Тип: `string`\
По умолчанию: `'get'`

HTTP-метод, используемый для выполнения запроса.

Внутри стандартные методы (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` и `DELETE`) преобразуются к верхнему регистру, чтобы избежать ошибок сервера из-за чувствительности к регистру.

##### json

Тип: `object` и любое другое значение, принимаемое [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Удобный способ отправки JSON. Используйте это вместо опции `body`. Принимает любой обычный объект или значение, который будет сериализован через `JSON.stringify()` и отправлен в теле с правильным заголовком.

##### searchParams

Тип: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
По умолчанию: `''`

Параметры запроса, которые будут включены в URL запроса. Установка этого значения перезапишет все существующие параметры запроса в исходном URL.

Принимает любые значения, поддерживаемые [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Тип: `string | URL`

Префикс, который добавляется к URL `input` при выполнении запроса. Это может быть любой валидный URL, относительный или абсолютный. Заключительный слэш `/` опционален и будет добавлен автоматически при необходимости при объединении с `input`. Действует только если `input` — строка. Аргумент `input` не может начинаться со слэша `/` при использовании этой опции.

Полезно использовать с [`ky.extend()`](#kyextenddefaultoptions) для создания специализированных экземпляров Ky.

```js
import ky from 'ky';

// На https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Примечания:
 - После объединения `prefixUrl` и `input` результат разрешается относительно [базового URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) страницы (если он есть).
 - Начальные слэши в `input` запрещены при использовании этой опции для обеспечения согласованности и предотвращения путаницы в том, как обрабатывается URL `input`, учитывая, что `input` не будет следовать обычным правилам разрешения URL, если используется `prefixUrl`, что изменяет смысл начального слэша.

##### retry

Тип: `object | number`\
По умолчанию:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`
Объект, представляющий поля `limit`, `methods`, `statusCodes`, `afterStatusCodes` и `maxRetryAfter` для максимального количества попыток повторения, разрешённых методов, разрешённых кодов состояния, кодов состояния, для которых разрешено использовать время из заголовка [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), и максимального времени [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Если `retry` — это число, оно будет использовано как `limit`, а остальные значения по умолчанию сохранятся.

Если ответ содержит HTTP-статус, указанный в `afterStatusCodes`, Ky будет ждать до даты, таймаута или метки времени, указанных в заголовке [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), прежде чем повторить запрос. Если `Retry-After` отсутствует, вместо него используется нестандартный заголовок [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) в качестве запасного варианта. Если предоставленный код состояния отсутствует в списке, заголовок [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) будет проигнорирован.

Если `maxRetryAfter` установлен в `undefined`, будет использовано значение `options.timeout`. Если значение из заголовка [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) больше, чем `maxRetryAfter`, будет использовано `maxRetryAfter`.

Параметр `backoffLimit` — это верхний предел задержки между попытками в миллисекундах.
Чтобы ограничить задержку, например, установите `backoffLimit` в 1000.
По умолчанию задержка вычисляется как `0.3 * (2 ** (attemptCount - 1)) * 1000`. Задержка увеличивается экспоненциально.

Опция `delay` может быть использована для изменения способа расчёта задержки между попытками. Функция получает один параметр — номер попытки, начиная с `1`.

Повторные попытки не выполняются после [таймаута](#timeout).

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

Тип: `number | false`\
Значение по умолчанию: `10000`

Таймаут в миллисекундах для получения ответа, включая все повторные попытки. Не может быть больше 2147483647.
Если установлено значение `false`, таймаута не будет.

##### hooks

Тип: `object<string, Function[]>`\
Значение по умолчанию: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Хуки позволяют вносить изменения в процессе выполнения запроса. Функции-хуки могут быть асинхронными и выполняются последовательно.

###### hooks.beforeRequest

Тип: `Function[]`\
Значение по умолчанию: `[]`

Этот хук позволяет вам изменить запрос непосредственно перед его отправкой. После этого Ky больше не будет вносить изменений в запрос. Функция-хук получает в качестве аргументов `request` и `options`. Например, здесь вы можете изменить `request.headers`.

Хук может вернуть объект [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) для замены исходящего запроса или объект [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), чтобы полностью избежать выполнения HTTP-запроса. Это может быть использовано для имитации запроса, проверки внутреннего кэша и т. д. **Важно:** если вы возвращаете объект запроса или ответа из этого хука, все оставшиеся хуки `beforeRequest` будут пропущены, поэтому рекомендуется возвращать их только из последнего хука.

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

Тип: `Function[]`\
Значение по умолчанию: `[]`

Этот хук позволяет изменить запрос непосредственно перед повторной попыткой. После этого Ky больше не будет вносить изменений в запрос. Функция-хук получает объект с нормализованным запросом и опциями, экземпляр ошибки и количество попыток. Например, здесь вы можете изменить `request.headers`.

Если на запрос получен ответ, ошибка будет типа `HTTPError`, и объект `Response` будет доступен в `error.response`. Обратите внимание, что некоторые типы ошибок, например сетевые ошибки, по своей природе означают, что ответа не было получено. В этом случае ошибка не будет экземпляром `HTTPError`.

Вы можете предотвратить повторную попытку запроса в Ky, выбросив ошибку. Ky не будет её обрабатывать и ошибка будет передана инициатору запроса. Остальные хуки `beforeRetry` в этом случае вызваны не будут. Альтернативно, вы можете вернуть символ [`ky.stop`](#kystop), чтобы сделать то же самое, но без проброса ошибки (имеет некоторые ограничения, смотрите документацию по `ky.stop`).

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

Тип: `Function[]`\
Значение по умолчанию: `[]`

Этот хук позволяет изменить объект `HTTPError` непосредственно перед тем, как он будет выброшен. Функция-хук получает в качестве аргумента объект `HTTPError` и должна вернуть экземпляр `HTTPError`.

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

Тип: `Function[]`\
Значение по умолчанию: `[]`

Этот хук позволяет прочитать и, при необходимости, изменить ответ. Функция-хук получает нормализованный запрос, опции и клон ответа в качестве аргументов. Возвращаемое значение функции-хука будет использовано Ky как объект ответа, если оно является экземпляром [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Здесь можно что-то сделать с ответом, например, залогировать его.
				log(response);

				// Или вернуть экземпляр `Response`, чтобы перезаписать ответ.
				return new Response('A different response', {status: 200});
			},

			// Или выполнить повторную попытку с новым токеном при ошибке 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Получить новый токен
					const token = await ky('https://example.com/token').text();

					// Повторить попытку с токеном
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Тип: `boolean`\
Значение по умолчанию: `true`

Выбрасывать `HTTPError`, если после всех перенаправлений ответ содержит статус-код, отличный от 2xx. Чтобы также выбрасывать ошибку для перенаправлений вместо следования за ними, установите параметр [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) в значение `'manual'`.

Установка этого параметра в `false` может быть полезна, если вы проверяете доступность ресурса и ожидаете ошибочные ответы.

Примечание: Если установлено в `false`, ошибочные ответы считаются успешными и повторные попытки предприняты не будут.

##### onDownloadProgress

Тип: `Function`

Обработчик событий прогресса загрузки.

Функция получает следующие аргументы:
- `progress` — объект со следующими свойствами:
- - `percent` — число от 0 до 1, отражающее процент выполнения.
- - `transferredBytes` — количество байт, переданных на данный момент.
- - `totalBytes` — общее количество байт для передачи. Это оценка и может быть 0, если общий размер нельзя определить.
- `chunk` — экземпляр `Uint8Array`, содержащий отправленные данные. Примечание: при первом вызове он пустой.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Пример вывода:
		// `0% - 0 из 1271 байт`
		// `100% - 1271 из 1271 байт`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} из ${progress.totalBytes} байт`);
	}
});
```

##### onUploadProgress

Тип: `Function`

Обработчик событий прогресса загрузки.

Функция получает следующие аргументы:
- `progress` — объект со следующими свойствами:
- - `percent` — число от 0 до 1, представляющее процент выполнения.
- - `transferredBytes` — количество байт, переданных на данный момент.
- - `totalBytes` — общее количество байт, которые необходимо передать. Это оценка и может быть равно 0, если общий размер не может быть определён.
- `chunk` — экземпляр `Uint8Array`, содержащий отправленные данные. Примечание: для последнего вызова массив пустой.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Пример вывода:
		// `0% - 0 из 1271 байт`
		// `100% - 1271 из 1271 байт`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} из ${progress.totalBytes} байт`);
	}
});
```

##### parseJson

Тип: `Function`\
По умолчанию: `JSON.parse()`

Пользовательская функция для парсинга JSON.

Варианты использования:
1. Разбор JSON с помощью пакета [`bourne`](https://github.com/hapijs/bourne) для защиты от загрязнения прототипа.
2. Разбор JSON с помощью [`reviver`-опции для `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Тип: `Function`\
По умолчанию: `JSON.stringify()`

Пользовательская функция для преобразования в JSON.

Варианты использования:
1. Преобразование в JSON с помощью пользовательской функции `replacer`.

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

Тип: `Function`\
По умолчанию: `fetch`

Пользовательская функция `fetch`.
Должна быть полностью совместима со стандартом [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Варианты использования:
1. Использование пользовательских реализаций `fetch`, таких как [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Использование обёртки над `fetch`, предоставленной некоторыми фреймворками, использующими серверный рендеринг (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Создаёт новый экземпляр `ky` с некоторыми переопределёнными по умолчанию значениями.

В отличие от `ky.create()`, `ky.extend()` наследует значения по умолчанию от родителя.

Заголовки можно передавать как экземпляр `Headers`, так и обычный объект.

Заголовок можно удалить через `.extend()`, передав заголовок со значением `undefined`.
Передача `undefined` как строки удаляет заголовок только в случае, если он был из экземпляра `Headers`.

Аналогично, можно удалить существующие записи `hooks`, расширив хук явно заданным значением `undefined`.

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

Также можно обратиться к значениям по умолчанию родителя, передав функцию в `.extend()`.

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

Создаёт новый экземпляр Ky с полностью новыми значениями по умолчанию.

```js
import ky from 'ky';

// На https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Тип: `object`

### ky.stop

`Symbol`, который может быть возвращён хуком `beforeRetry` для остановки повторной попытки. Это также прерывает выполнение оставшихся хуков `beforeRetry`.

Примечание: Возврат этого символа заставляет Ky прервать выполнение и вернуть `undefined` в качестве ответа. Обязательно проверьте наличие ответа перед обращением к его свойствам или используйте [опциональную цепочку](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Также это несовместимо с методами для работы с телом ответа, такими как `.json()` или `.text()`, потому что ответа для разбора нет. В целом рекомендуется выбрасывать ошибку вместо возврата этого символа, так как это заставит Ky прервать выполнение и выбросить исключение, что позволит избежать этих ограничений.

Корректный вариант использования `ky.stop` — предотвращать повторные попытки при выполнении запросов с побочными эффектами, когда возвращаемые данные не важны. Например, при логировании активности клиента на сервере.

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
// Обратите внимание, что response будет `undefined`, если возвращается `ky.stop`.
const response = await ky.post('https://example.com', options);

// Использование `.text()` или других методов работы с телом не поддерживается.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Открыт для проверок с помощью `instanceof`. Ошибка содержит свойство `response` с объектом [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), свойство `request` с объектом [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) и свойство `options` с нормализованными опциями (переданными либо при создании экземпляра через `ky.create()`, либо напрямую при выполнении запроса).

Имейте в виду, что некоторые типы ошибок, такие как сетевые ошибки, по своей сути означают, что ответ не был получен. В этом случае ошибка не будет экземпляром HTTPError и не будет содержать свойство `response`.

Если вам нужно прочитать фактический ответ при возникновении `HTTPError`, вызовите соответствующий метод парсера на объекте ответа. Например:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Принимает необязательный [типовой параметр](https://www.typescriptlang.org/docs/handbook/2/generics.html), который по умолчанию равен [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), и передается в возвращаемый тип метода `error.response.json()`.

### TimeoutError

Ошибка, выбрасываемая при истечении времени ожидания запроса. Содержит свойство `request` с объектом [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Советы

### Отправка данных формы

Отправка данных формы в Ky идентична `fetch`. Просто передайте экземпляр [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) в опцию `body`. Заголовок `Content-Type` будет автоматически установлен в `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Если вы хотите отправить данные в формате `application/x-www-form-urlencoded`, вам нужно закодировать данные с помощью [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Установка собственного `Content-Type`

Ky автоматически устанавливает соответствующий заголовок [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) для каждого запроса на основе данных в теле запроса. Однако некоторые API требуют нестандартных типов содержимого, например, `application/x-amz-json-1.1`. Используя опцию `headers`, вы можете вручную переопределить тип содержимого.

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

### Отмена запроса

Fetch (и, соответственно, Ky) поддерживает отмену запроса через [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Подробнее.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Пример:

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

#### Как использовать это в Node.js?

Node.js 18 и выше поддерживает `fetch` нативно, поэтому вы можете использовать этот пакет напрямую.

#### Как использовать это с веб-приложением (React, Vue.js и т. д.) с серверным рендерингом (SSR)?

Аналогично вышеуказанному.

#### Как тестировать библиотеку для браузера, использующую это?

Используйте тестовый раннер, который может запускаться в браузере, например Mocha, или используйте [AVA](https://avajs.dev) с `ky-universal`. [Подробнее.](https://github.com/sindresorhus/ky-universal#faq)

#### Как использовать это без сборщика, такого как Webpack?

Убедитесь, что ваш код выполняется как модуль JavaScript (ESM), например, с помощью тега `<script type="module">` в вашем HTML-документе. Затем Ky можно импортировать непосредственно этим модулем без сборщика или других инструментов.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Чем отличается от [`got`](https://github.com/sindresorhus/got)

Смотрите мой ответ [здесь](https://twitter.com/sindresorhus/status/1037406558945042432). Got поддерживается теми же людьми, что и Ky.

#### Чем отличается от [`axios`](https://github.com/axios/axios)?

Смотрите мой ответ [здесь](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Чем отличается от [`r2`](https://github.com/mikeal/r2)?

Смотрите мой ответ в [#10](https://github.com/sindresorhus/ky/issues/10).

#### Что означает `ky`?

Это просто случайное короткое имя npm-пакета, которое мне удалось получить. Однако оно имеет значение на японском языке:

> Форма сленга для сообщений, KY — это сокращение от 空気読めない (kuuki yomenai), что буквально переводится как «не может читать воздух». Этой фразой называют человека, который не улавливает скрытый смысл.

## Поддержка браузеров

Последние версии Chrome, Firefox и Safari.

## Поддержка Node.js

Node.js 18 и выше.

## Связанные проекты

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Полезные утилиты для работы с Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Хуки Ky для изменения регистра в запросах и ответах объектов

## Мейнтейнеры

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---