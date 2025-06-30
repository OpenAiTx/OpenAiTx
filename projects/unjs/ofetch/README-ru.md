# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Улучшенный fetch API. Работает в node, браузере и воркерах.

<details>
  <summary>Спойлер</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Быстрый старт

Установка:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Импорт:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Работает с Node.js

Мы используем [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) для обнаружения Node.js
и автоматически используем [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Если доступен `globalThis.fetch`, будет использоваться он. Чтобы использовать экспериментальный нативный fetch API в Node.js 17.5.0, используйте флаг [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Парсинг ответа

`ofetch` умно парсит JSON и нативные значения с помощью [destr](https://github.com/unjs/destr), возвращаясь к тексту, если парсинг не удался.

```js
const { users } = await ofetch("/api/users");
```

Для бинарных типов контента `ofetch` возвращает объект `Blob`.

Вы можете опционально указать другой парсер, отличный от `destr`, или указать `blob`, `arrayBuffer` или `text`, чтобы принудительно распарсить тело с помощью соответствующего метода `FetchResponse`.

```js
// Использовать JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Вернуть текст как есть
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Получить версию ответа в виде blob
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON Body

Если в опцию `body` передан объект или класс с методом `.toJSON()`, `ofetch` автоматически преобразует его в строку.

`ofetch` использует `JSON.stringify()` для преобразования переданного объекта. Классы без метода `.toJSON()` должны быть предварительно преобразованы в строку перед передачей в опцию `body`.

Для методов запросов `PUT`, `PATCH` и `POST`, когда задано тело-строка или объект, `ofetch` добавляет по умолчанию заголовки `content-type: "application/json"` и `accept: "application/json"` (которые вы всегда можете переопределить).

Кроме того, `ofetch` поддерживает бинарные ответы с помощью `Buffer`, `ReadableStream`, `Stream` и [совместимых типов body](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). Для поддержки стриминга `ofetch` автоматически установит опцию `duplex: "half"`!

**Пример:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Обработка ошибок

`ofetch` автоматически выбрасывает ошибки, когда `response.ok` равно `false`, с дружелюбным сообщением об ошибке и компактным стеком (скрывая внутренности).

Распарсенное тело ошибки доступно через `error.data`. Также можно использовать тип `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Чтобы перехватить ответ с ошибкой:

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

Чтобы обойти перехват ошибок по статусу, вы можете установить опцию `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Автоматический повтор (Auto Retry)

`ofetch` автоматически повторяет запрос, если произошла ошибка и если код статуса ответа содержится в списке `retryStatusCodes`:

**Коды статусов для повтора:**

- `408` — Тайм-аут запроса (Request Timeout)
- `409` — Конфликт (Conflict)
- `425` — Слишком рано (Too Early) ([Экспериментально](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` — Слишком много запросов (Too Many Requests)
- `500` — Внутренняя ошибка сервера (Internal Server Error)
- `502` — Плохой шлюз (Bad Gateway)
- `503` — Сервис недоступен (Service Unavailable)
- `504` — Тайм-аут шлюза (Gateway Timeout)

Вы можете указать количество повторов и задержку между ними с помощью опций `retry` и `retryDelay`, а также передать пользовательский массив кодов через опцию `retryStatusCodes`.

По умолчанию для `retry` установлен 1 повтор, за исключением методов `POST`, `PUT`, `PATCH` и `DELETE`, для которых `ofetch` по умолчанию не повторяет запросы во избежание побочных эффектов. Если вы задаёте собственное значение для `retry`, повтор будет происходить **всегда** для всех запросов.

По умолчанию для `retryDelay` установлено значение `0` мс.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // мс
  retryStatusCodes: [ 404, 500 ], // коды статусов ответа для повтора
});
```

## ✔️ Тайм-аут (Timeout)

Вы можете указать `timeout` в миллисекундах для автоматической отмены запроса по истечении времени ожидания (по умолчанию отключено).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Тайм-аут через 3 секунды
});
```

## ✔️ Типобезопасность (Type Friendly)

Ответ может быть типизирован:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Автодополнение работает с article.id
```

## ✔️ Добавление `baseURL`

Используя опцию `baseURL`, `ofetch` добавляет её к URL, корректируя начальные/конечные слэши и параметры поиска запроса для baseURL с помощью [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Добавление параметров поиска (Query Search Params)

Используя опцию `query` (или `params` в качестве псевдонима), `ofetch` добавляет параметры поиска к URL, при этом сохраняя параметры запроса непосредственно в запросе с помощью [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Перехватчики (Interceptors)

Возможно использование асинхронных перехватчиков для подключения к жизненному циклу вызова `ofetch`.

Возможно использовать `ofetch.create` для задания общих перехватчиков.

### `onRequest({ request, options })`

`onRequest` вызывается сразу после вызова `ofetch`, позволяя вам изменять опции или выполнять простое логирование.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Логирование запроса
    console.log("[fetch request]", request, options);

    // Добавить `?t=1640125211170` к параметрам поиска запроса
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` будет вызван, если запрос fetch завершился неудачно.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Логируем ошибку
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` будет вызван после выполнения `fetch` и парсинга тела ответа.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Логируем ответ
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` работает так же, как и `onResponse`, но будет вызван, когда fetch выполнен, но `response.ok` не равен `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Логируем ошибку
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Передача массива перехватчиков

При необходимости можно также передать массив функций, которые будут вызваны последовательно.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Сделать что-то */
    },
    () => {
      /* Сделать что-то еще */
    },
  ],
});
```

## ✔️ Создание fetch с опциями по умолчанию

Этот инструмент полезен, если вам нужно использовать общие опции для нескольких вызовов fetch.

**Примечание:** Значения по умолчанию будут клонированы на один уровень и унаследованы. Будьте внимательны с вложенными опциями, такими как `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // То же, что и ofetch('/test', { baseURL: '/api' })
```

## 💡 Добавление заголовков

Используя опцию `headers`, `ofetch` добавляет дополнительные заголовки в дополнение к заголовкам запроса по умолчанию:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Доступ к необработанному ответу

Если вам нужен доступ к необработанному ответу (для заголовков и т.д.), вы можете использовать `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Использование нативного Fetch

Для удобства вы можете использовать `ofetch.native`, который предоставляет нативный API `fetch`:

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Добавление HTTP(S) агента

В средах Node.js (>= 18) вы можете предоставить собственный диспетчер для перехвата запросов и поддержки таких возможностей, как прокси и самоподписанные сертификаты. Эта функция включена благодаря [undici](https://undici.nodejs.org/), встроенному в Node.js. [подробнее](https://undici.nodejs.org/#/docs/api/Dispatcher) о Dispatcher API.

Доступные агенты:

- `ProxyAgent`: Класс Proxy Agent, реализующий API агента. Позволяет подключаться через прокси простым способом. ([документация](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Класс Mock Agent, реализующий API агента. Позволяет перехватывать HTTP-запросы, выполненные через undici, и возвращать смоделированные ответы. ([документация](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent позволяет отправлять запросы к нескольким разным источникам. ([документация](https://undici.nodejs.org/#/docs/api/Agent))

**Пример:** Установить прокси-агент для одного запроса:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Пример:** Создать экземпляр fetch с включенным прокси:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Пример:** Установить прокси-агент для всех запросов:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Пример:** Разрешить самоподписанные сертификаты (ИСПОЛЬЗУЙТЕ НА СВОЙ СТРАХ И РИСК!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Внимание: Это делает fetch уязвимым к MITM-атакам. ИСПОЛЬЗУЙТЕ НА СВОЙ СТРАХ И РИСК!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

В старых версиях Node.js (<18) вы также можете использовать `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Поддержка `keepAlive` (работает только для Node < 18)

Если установить переменную окружения `FETCH_KEEP_ALIVE` в значение `true`, будет зарегистрирован HTTP/HTTPS агент, который сохраняет соединения даже при отсутствии активных запросов, чтобы их можно было использовать для будущих запросов без повторного установления TCP-соединения.

**Внимание:** Эта опция может потенциально привести к утечкам памяти. Пожалуйста, ознакомьтесь с [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Заметки по сборщикам

- Все цели экспортируются в форматах Module и CommonJS с именованными экспортами
- Ни один экспорт не транспилируется ради поддержки современного синтаксиса
  - Возможно, вам потребуется транспилировать пакеты `ofetch`, `destr` и `ufo` с помощью Babel для поддержки ES5
- Для поддержки устаревших браузеров необходимо добавить полифилл для глобального `fetch`, например с помощью [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Почему экспорт называется `ofetch`, а не `fetch`?**

Использование названия `fetch` может быть запутанным, так как API отличается, но всё же это fetch, поэтому используется максимально похожая альтернатива. Однако вы можете импортировать `{ fetch }` из `ofetch`, который автоматически полифиллит fetch для Node.js и использует нативный вариант в других случаях.

**Почему нет экспорта по умолчанию?**

Экспорты по умолчанию всегда рискованы при смешивании с CommonJS-экспортами.

Это также гарантирует возможность добавлять новые утилиты, не ломая пакет, и поощряет использование имени `ofetch`.

**Почему не транспилируется?**

Транспиляция библиотек откатывает веб назад к устаревшему коду, который не нужен большинству пользователей.

Если вам нужно поддерживать устаревших пользователей, вы можете опционально транспилировать библиотеку в своем пайплайне сборки.
```
## Лицензия

MIT. Сделано с 💖

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