# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Una fetch API migliore. Funziona su node, browser e workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Avvio Rapido

Installa:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importa:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Funziona con Node.js

Utilizziamo [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) per rilevare Node.js
e usare automaticamente [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Se `globalThis.fetch` è disponibile, verrà utilizzato invece. Per sfruttare la fetch API nativa sperimentale di Node.js 17.5.0 usa il flag [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Parsing della Risposta

`ofetch` analizzerà in modo intelligente valori JSON e nativi usando [destr](https://github.com/unjs/destr), tornando al testo se la conversione fallisce.

```js
const { users } = await ofetch("/api/users");
```

Per i tipi di contenuto binari, `ofetch` restituirà invece un oggetto `Blob`.

Puoi opzionalmente fornire un parser diverso da `destr`, oppure specificare `blob`, `arrayBuffer` o `text` per forzare il parsing del body con il relativo metodo di `FetchResponse`.

```js
// Usa JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Restituisci il testo così com'è
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Ottieni la versione blob della risposta
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Corpo JSON

Se viene passato un oggetto o una classe con un metodo `.toJSON()` nell'opzione `body`, `ofetch` lo converte automaticamente in stringa.

`ofetch` utilizza `JSON.stringify()` per convertire l'oggetto passato. Le classi senza un metodo `.toJSON()` devono essere convertite in valore stringa in anticipo prima di essere passate all'opzione `body`.

Per i metodi di richiesta `PUT`, `PATCH` e `POST`, quando viene impostato un body di tipo stringa o oggetto, `ofetch` aggiunge di default le intestazioni `content-type: "application/json"` e `accept: "application/json"` (che puoi sempre sovrascrivere).

Inoltre, `ofetch` supporta risposte binarie con `Buffer`, `ReadableStream`, `Stream` e [tipi di body compatibili](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` imposterà automaticamente l'opzione `duplex: "half"` per il supporto dello streaming!

**Esempio:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Gestione degli Errori

`ofetch` genera automaticamente errori quando `response.ok` è `false` con un messaggio di errore amichevole e uno stack compatto (nascondendo i dettagli interni).

Un body di errore già interpretato è disponibile con `error.data`. Puoi anche usare il tipo `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Per catturare la risposta di errore:

```ts
await ofetch("/url").catch((error) => error.data);
```

Per bypassare il catching degli errori di stato puoi impostare l'opzione `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Auto Retry

`ofetch` ritenta automaticamente la richiesta se si verifica un errore e se il codice di stato della risposta è incluso nella lista `retryStatusCodes`:

**Codici di stato per il retry:**

- `408` - Request Timeout
- `409` - Conflict
- `425` - Too Early ([Sperimentale](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests
- `500` - Internal Server Error
- `502` - Bad Gateway
- `503` - Service Unavailable
- `504` - Gateway Timeout

Puoi specificare il numero di tentativi e il ritardo tra essi utilizzando le opzioni `retry` e `retryDelay` e anche passare un array personalizzato di codici tramite l'opzione `retryStatusCodes`.

Il valore predefinito per `retry` è `1` retry, tranne che per i metodi `POST`, `PUT`, `PATCH` e `DELETE` dove `ofetch` non ritenta di default per evitare effetti collaterali. Se imposti un valore personalizzato per `retry`, **verrà sempre effettuato il retry** per tutte le richieste.

Il valore predefinito per `retryDelay` è `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // codici di stato della risposta da ritentare
});
```

## ✔️ Timeout

Puoi specificare `timeout` in millisecondi per interrompere automaticamente una richiesta dopo un timeout (impostazione predefinita disabilitata).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Timeout dopo 3 secondi
});
```

## ✔️ Type Friendly

La risposta può essere assistita dal tipo:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Autocompletamento funzionante con article.id
```

## ✔️ Aggiunta di `baseURL`

Utilizzando l'opzione `baseURL`, `ofetch` la antepone per slash iniziali/finali e parametri di query per baseURL usando [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Aggiunta di Query Search Params

Utilizzando l'opzione `query` (o `params` come alias), `ofetch` aggiunge i parametri di ricerca della query all'URL preservando la query nella richiesta stessa tramite [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptors

È possibile fornire interceptor asincroni per agganciarsi agli eventi del ciclo di vita della chiamata `ofetch`.

Potresti voler usare `ofetch.create` per impostare interceptor condivisi.

### `onRequest({ request, options })`

`onRequest` viene chiamato non appena viene chiamato `ofetch`, permettendoti di modificare le opzioni o effettuare un semplice logging.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Log della richiesta
    console.log("[fetch request]", request, options);

    // Aggiungi `?t=1640125211170` ai parametri di ricerca della query
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` verrà chiamato quando la richiesta fetch fallisce.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Registra l'errore
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` verrà chiamato dopo la chiamata a `fetch` e il parsing del body.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Registra la risposta
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` è lo stesso di `onResponse` ma verrà chiamato quando la richiesta fetch avviene ma `response.ok` non è `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Registra l'errore
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Passare un array di interceptor

Se necessario, è anche possibile passare un array di funzioni che verranno chiamate in sequenza.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Fai qualcosa */
    },
    () => {
      /* Fai qualcos'altro */
    },
  ],
});
```

## ✔️ Creare fetch con opzioni di default

Questa utility è utile se hai bisogno di usare opzioni comuni in diverse chiamate fetch.

**Nota:** I valori di default verranno clonati a un livello e ereditati. Fai attenzione alle opzioni annidate come `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Uguale a ofetch('/test', { baseURL: '/api' })
```

## 💡 Aggiunta di headers

Usando l'opzione `headers`, `ofetch` aggiunge header extra in aggiunta agli header di default della richiesta:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Accesso alla risposta grezza

Se hai bisogno di accedere alla risposta grezza (per gli header, ecc.), puoi usare `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Uso del Native Fetch

Come scorciatoia, puoi usare `ofetch.native` che fornisce la API nativa `fetch`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Aggiunta di un Agente HTTP(S)

Negli ambienti Node.js (>= 18), è possibile fornire un dispatcher personalizzato per intercettare le richieste e supportare funzionalità come Proxy e certificati self-signed. Questa funzionalità è abilitata da [undici](https://undici.nodejs.org/) integrato in Node.js. [leggi di più](https://undici.nodejs.org/#/docs/api/Dispatcher) sull’API Dispatcher.

Alcuni agenti disponibili:

- `ProxyAgent`: Una classe Proxy Agent che implementa l’API Agent. Permette la connessione tramite proxy in modo semplice. ([documentazione](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Una classe Agent simulata che implementa l’API Agent. Permette di intercettare le richieste HTTP effettuate tramite undici e restituire risposte simulate invece di quelle reali. ([documentazione](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent permette di inviare richieste verso molteplici origini diverse. ([documentazione](https://undici.nodejs.org/#/docs/api/Agent))

**Esempio:** Impostare un proxy agent per una richiesta:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Esempio:** Creare un’istanza fetch personalizzata con proxy abilitato:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Esempio:** Impostare un proxy agent per tutte le richieste:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Esempio:** Consentire certificati self-signed (USARE A PROPRIO RISCHIO!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Nota: Questo rende fetch insicuro contro attacchi MITM. USARE A PROPRIO RISCHIO!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Su versioni Node.js più vecchie (<18), puoi anche usare `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Supporto `keepAlive` (funziona solo per Node < 18)

Impostando la variabile d’ambiente `FETCH_KEEP_ALIVE` su `true`, verrà registrato un agente HTTP/HTTPS che mantiene attivi i socket anche quando non ci sono richieste in sospeso, così da poterli riutilizzare per richieste future senza dover ristabilire una connessione TCP.

**Nota:** Questa opzione può potenzialmente introdurre memory leak. Consulta [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Note sul Bundler

- Tutti i target sono esportati sia in formato Module che CommonJS ed esportazioni nominate
- Nessuna esportazione viene transpile per mantenere la sintassi moderna
  - Probabilmente dovrai transpile i pacchetti `ofetch`, `destr` e `ufo` con Babel per il supporto ES5
- È necessario effettuare il polyfill della globale `fetch` per supportare browser legacy, ad esempio usando [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Perché l’export si chiama `ofetch` invece di `fetch`?**

Usare lo stesso nome di `fetch` può essere fonte di confusione poiché l’API è diversa, ma è comunque un fetch quindi si è scelto l’alternativa più vicina possibile. Puoi comunque importare `{ fetch }` da `ofetch`, che è un auto-polyfill per Node.js e usa quello nativo altrimenti.

**Perché non c’è un export di default?**

Gli export di default sono sempre rischiosi da mischiare con export CommonJS.

Questo garantisce anche che si possano introdurre altri util senza rompere il pacchetto e inoltre incoraggia l’uso del nome `ofetch`.

**Perché non viene transpile?**

Transpilare le librerie significa rallentare il web con codice legacy, il che non è necessario per la maggior parte degli utenti.

Se hai bisogno di supportare utenti legacy, puoi opzionalmente transpile la libreria nella tua pipeline di build.
```
## Licenza

MIT. Fatto con 💖

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