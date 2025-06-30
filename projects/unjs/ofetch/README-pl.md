# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Lepsze API fetch. Działa na node, w przeglądarce i w workerach.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Szybki start

Instalacja:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Import:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Działa z Node.js

Używamy [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) do wykrywania Node.js
i automatycznego korzystania z [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Jeśli `globalThis.fetch` jest dostępne, zostanie ono użyte zamiast tego. Aby wykorzystać eksperymentalne natywne API fetch w Node.js 17.5.0 użyj flagi [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Parsowanie odpowiedzi

`ofetch` inteligentnie parsuje JSON i natywne wartości używając [destr](https://github.com/unjs/destr), przechodząc do tekstu w przypadku niepowodzenia parsowania.

```js
const { users } = await ofetch("/api/users");
```

Dla binarnych typów zawartości, `ofetch` zwróci obiekt `Blob`.

Możesz opcjonalnie podać własny parser zamiast `destr`, lub określić `blob`, `arrayBuffer` albo `text`, aby wymusić parsowanie ciała odpowiedzi daną metodą `FetchResponse`.

```js
// Użyj JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Zwróć tekst bez zmian
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Pobierz wersję blob odpowiedzi
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Ciało JSON

Jeśli do opcji `body` zostanie przekazany obiekt lub klasa z metodą `.toJSON()`, `ofetch` automatycznie zamieni ją na tekst.

`ofetch` wykorzystuje `JSON.stringify()` do konwersji przekazanego obiektu. Klasy bez metody `.toJSON()` muszą być zamienione na wartość tekstową wcześniej, zanim zostaną przekazane do opcji `body`.

Dla metod żądań `PUT`, `PATCH` oraz `POST`, gdy przekazany jest tekst lub obiekt jako ciało, `ofetch` dodaje domyślne nagłówki `content-type: "application/json"` i `accept: "application/json"` (które można zawsze nadpisać).

Dodatkowo, `ofetch` obsługuje odpowiedzi binarne z `Buffer`, `ReadableStream`, `Stream` oraz [zgodnymi typami ciał](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` automatycznie ustawi opcję `duplex: "half"` dla obsługi streamingu!

**Przykład:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Obsługa błędów

`ofetch` automatycznie zgłasza błędy, gdy `response.ok` jest `false`, z czytelnym komunikatem i skróconym stosem (ukrywając szczegóły wewnętrzne).

Sparsowane ciało błędu dostępne jest jako `error.data`. Możesz także użyć typu `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Aby przechwycić odpowiedź błędu:

```ts
```ts
await ofetch("/url").catch((error) => error.data);
```

Aby pominąć obsługę błędów statusu, możesz ustawić opcję `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Automatyczne Ponawianie (Auto Retry)

`ofetch` automatycznie ponawia żądanie, jeśli wystąpi błąd i jeśli kod statusu odpowiedzi znajduje się na liście `retryStatusCodes`:

**Kody statusów do ponawiania:**

- `408` - Przekroczony czas żądania (Request Timeout)
- `409` - Konflikt (Conflict)
- `425` - Zbyt wcześnie (Too Early) ([Eksperymentalne](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Zbyt wiele żądań (Too Many Requests)
- `500` - Wewnętrzny błąd serwera (Internal Server Error)
- `502` - Zły gateway (Bad Gateway)
- `503` - Usługa niedostępna (Service Unavailable)
- `504` - Przekroczony czas gatewaya (Gateway Timeout)

Możesz określić liczbę ponowień i opóźnienie między nimi, używając opcji `retry` oraz `retryDelay`, a także przekazać własną tablicę kodów za pomocą opcji `retryStatusCodes`.

Domyślnie `retry` to `1` ponowienie, z wyjątkiem metod `POST`, `PUT`, `PATCH` i `DELETE`, dla których `ofetch` domyślnie nie ponawia, aby uniknąć potencjalnych skutków ubocznych. Jeśli ustawisz własną wartość dla `retry`, będzie ona **zawsze ponawiać** dla wszystkich żądań.

Domyślnie `retryDelay` to `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // kody statusów odpowiedzi do ponowienia
});
```

## ✔️ Timeout

Możesz określić `timeout` w milisekundach, aby automatycznie przerwać żądanie po przekroczeniu czasu (domyślnie wyłączone).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Przerwanie po 3 sekundach
});
```

## ✔️ Przyjazny Typom (Type Friendly)

Odpowiedź może być wspomagana przez typy:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Autouzupełnianie działa z article.id
```

## ✔️ Dodawanie `baseURL`

Używając opcji `baseURL`, `ofetch` dodaje ją do końcowych/początkowych ukośników oraz parametrów zapytania dla baseURL przy użyciu [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Dodawanie parametrów zapytania (Query Search Params)

Używając opcji `query` (lub `params` jako aliasu), `ofetch` dodaje parametry zapytania do adresu URL, zachowując zapytanie w samym żądaniu przy użyciu [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptory

Możliwe jest przekazanie asynchronicznych interceptorów, aby podpiąć się pod zdarzenia cyklu życia wywołania `ofetch`.

Możesz użyć `ofetch.create`, aby ustawić współdzielone interceptory.

### `onRequest({ request, options })`

`onRequest` jest wywoływany natychmiast po wywołaniu `ofetch`, umożliwiając modyfikację opcji lub proste logowanie.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Logowanie żądania
    console.log("[fetch request]", request, options);

    // Dodanie `?t=1640125211170` do parametrów zapytania
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` zostanie wywołany, gdy żądanie fetch zakończy się niepowodzeniem.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Zaloguj błąd
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` zostanie wywołane po wywołaniu `fetch` i sparsowaniu ciała odpowiedzi.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Zaloguj odpowiedź
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` działa tak samo jak `onResponse`, ale zostanie wywołane, gdy fetch się powiedzie, ale `response.ok` nie jest `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Zaloguj błąd
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Przekazywanie tablicy interceptorów

Jeśli jest to konieczne, można również przekazać tablicę funkcji, które zostaną wywołane sekwencyjnie.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Wykonaj coś */
    },
    () => {
      /* Wykonaj coś innego */
    },
  ],
});
```

## ✔️ Tworzenie fetch z domyślnymi opcjami

To narzędzie jest przydatne, jeśli musisz używać wspólnych opcji w kilku wywołaniach fetch.

**Uwaga:** Wartości domyślne będą klonowane na jednym poziomie i dziedziczone. Zachowaj ostrożność przy zagnieżdżonych opcjach, takich jak `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // To samo co ofetch('/test', { baseURL: '/api' })
```

## 💡 Dodawanie nagłówków

Korzystając z opcji `headers`, `ofetch` dodaje dodatkowe nagłówki oprócz domyślnych nagłówków żądania:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Dostęp do surowej odpowiedzi

Jeśli potrzebujesz dostępu do surowej odpowiedzi (np. dla nagłówków), możesz użyć `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Używanie natywnego Fetch

Dla wygody możesz użyć `ofetch.native`, który udostępnia natywne API `fetch`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Dodawanie agenta HTTP(S)

W środowiskach Node.js (>= 18) możesz dostarczyć własny dispatcher, aby przechwytywać żądania i obsługiwać funkcje takie jak Proxy oraz certyfikaty samopodpisane. Funkcja ta jest dostępna dzięki [undici](https://undici.nodejs.org/) wbudowanemu w Node.js. [Dowiedz się więcej](https://undici.nodejs.org/#/docs/api/Dispatcher) o API Dispatcher.

Dostępne agenty:

- `ProxyAgent`: Klasa Proxy Agent implementująca API Agenta. Umożliwia łatwe połączenie przez proxy. ([dokumentacja](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Zmockowana klasa Agenta implementująca API Agenta. Pozwala przechwytywać żądania HTTP wykonywane przez undici i zwracać zamiast nich odpowiedzi mockowane. ([dokumentacja](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent pozwalający na wysyłanie żądań do wielu różnych źródeł. ([dokumentacja](https://undici.nodejs.org/#/docs/api/Agent))

**Przykład:** Ustawienie agenta proxy dla jednego żądania:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Przykład:** Utworzenie własnej instancji fetch z włączonym proxy:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Przykład:** Ustawienie agenta proxy dla wszystkich żądań:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Przykład:** Zezwolenie na certyfikaty samopodpisane (UŻYWAJ NA WŁASNĄ ODPOWIEDZIALNOŚĆ!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Uwaga: To sprawia, że fetch jest niebezpieczny wobec ataków MITM. UŻYWAJ NA WŁASNĄ ODPOWIEDZIALNOŚĆ!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

W starszych wersjach Node.js (<18), możesz także użyć `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Wsparcie `keepAlive` (działa tylko dla Node < 18)

Ustawiając zmienną środowiskową `FETCH_KEEP_ALIVE` na `true`, zostanie zarejestrowany agent HTTP/HTTPS, który utrzymuje otwarte połączenia, nawet jeśli nie ma żadnych oczekujących żądań, dzięki czemu mogą być użyte do przyszłych żądań bez konieczności ponownego ustanawiania połączenia TCP.

**Uwaga:** Ta opcja potencjalnie może powodować wycieki pamięci. Proszę sprawdzić [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Uwagi dla bundlerów

- Wszystkie cele są eksportowane w formacie Module i CommonJS oraz jako eksporty nazwane
- Żaden eksport nie jest transpilowany dla zachowania nowoczesnej składni
  - Prawdopodobnie musisz transpilować pakiety `ofetch`, `destr` i `ufo` za pomocą Babel, aby uzyskać wsparcie dla ES5
- Musisz dodać polyfill dla globalnego `fetch`, aby wspierać starsze przeglądarki, np. używając [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Dlaczego eksport nazywa się `ofetch`, a nie `fetch`?**

Użycie tej samej nazwy co `fetch` może być mylące, ponieważ API jest inne, ale nadal jest to fetch, więc użyto najbliższej możliwej alternatywy. Możesz jednak zaimportować `{ fetch }` z `ofetch`, co automatycznie zapewnia polyfill dla Node.js, a w innym przypadku używa natywnego fetch.

**Dlaczego nie ma eksportu domyślnego?**

Eksporty domyślne zawsze niosą ryzyko pomylenia z eksportami CommonJS.

To również zapewnia możliwość dodania kolejnych narzędzi bez psucia paczki, a także zachęca do używania nazwy `ofetch`.

**Dlaczego nie jest transpilowany?**

Transpilowanie bibliotek cofa rozwój sieci poprzez wprowadzanie zbędnego, przestarzałego kodu, który jest niepotrzebny większości użytkowników.

Jeśli musisz wspierać starszych użytkowników, możesz opcjonalnie transpilować bibliotekę w swoim pipeline budowania.
```
## Licencja

MIT. Stworzone z 💖

<!-- Odznaki -->

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