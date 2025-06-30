# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Eine bessere Fetch-API. Funktioniert in Node, Browser und Workern.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Schnellstart

Installation:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importieren:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Funktioniert mit Node.js

Wir verwenden [bedingte Exporte](https://nodejs.org/api/packages.html#packages_conditional_exports), um Node.js zu erkennen
und nutzen automatisch [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Falls `globalThis.fetch` verfügbar ist, wird dieses stattdessen verwendet. Um die experimentelle native Fetch-API von Node.js 17.5.0 zu verwenden, kann das Flag [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch) genutzt werden.

## ✔️ Antwort parsen

`ofetch` parst JSON- und native Werte intelligent mit [destr](https://github.com/unjs/destr) und greift auf Text zurück, falls das Parsen fehlschlägt.

```js
const { users } = await ofetch("/api/users");
```

Für binäre Content-Typen gibt `ofetch` stattdessen ein `Blob`-Objekt zurück.

Optional kann ein anderer Parser als `destr` angegeben werden oder mit `blob`, `arrayBuffer` oder `text` das Parsen über die jeweilige `FetchResponse`-Methode erzwungen werden.

```js
// Verwende JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Gibt den Text unverändert zurück
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Hole die Blob-Version der Antwort
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON Body

Wenn ein Objekt oder eine Klasse mit einer `.toJSON()`-Methode an die Option `body` übergeben wird, wird dieses von `ofetch` automatisch in einen String umgewandelt.

`ofetch` verwendet `JSON.stringify()`, um das übergebene Objekt zu konvertieren. Klassen ohne `.toJSON()`-Methode müssen vorab in einen String umgewandelt werden, bevor sie an die Option `body` übergeben werden.

Bei den Methoden `PUT`, `PATCH` und `POST` fügt `ofetch` beim Setzen eines String- oder Objekt-Bodys die Standard-Header `content-type: "application/json"` und `accept: "application/json"` hinzu (die jederzeit überschrieben werden können).

Zusätzlich unterstützt `ofetch` binäre Antworten mit `Buffer`, `ReadableStream`, `Stream` und [kompatiblen Body-Typen](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). Für Streaming wird automatisch die Option `duplex: "half"` gesetzt!

**Beispiel:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Fehlerbehandlung

`ofetch` wirft automatisch Fehler, wenn `response.ok` `false` ist, mit einer verständlichen Fehlermeldung und kompaktem Stack (interne Details werden ausgeblendet).

Ein geparster Fehler-Body ist mit `error.data` verfügbar. Es kann auch der Typ `FetchError` verwendet werden.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Um Fehlerantworten abzufangen:

```ts
await ofetch("/url").catch((error) => error.data);
```

Um das Abfangen von Statusfehlern zu umgehen, können Sie die Option `ignoreResponseError` setzen:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Automatisches Wiederholen (Auto Retry)

`ofetch` wiederholt automatisch die Anfrage, wenn ein Fehler auftritt und der Antwortstatuscode in der Liste `retryStatusCodes` enthalten ist:

**Statuscodes für Wiederholungen:**

- `408` - Request Timeout (Zeitüberschreitung der Anfrage)
- `409` - Conflict (Konflikt)
- `425` - Too Early ([Experimentell](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests (Zu viele Anfragen)
- `500` - Internal Server Error (Interner Serverfehler)
- `502` - Bad Gateway (Fehlerhaftes Gateway)
- `503` - Service Unavailable (Dienst nicht verfügbar)
- `504` - Gateway Timeout (Gateway-Zeitüberschreitung)

Sie können die Anzahl der Wiederholungen und die Verzögerung dazwischen mit den Optionen `retry` und `retryDelay` festlegen und außerdem ein benutzerdefiniertes Array von Codes mit der Option `retryStatusCodes` übergeben.

Der Standardwert für `retry` ist `1` Wiederholung, außer bei den Methoden `POST`, `PUT`, `PATCH` und `DELETE`, bei denen `ofetch` standardmäßig keine Wiederholungen durchführt, um Nebenwirkungen zu vermeiden. Wenn Sie einen eigenen Wert für `retry` festlegen, wird für alle Anfragen **immer** eine Wiederholung durchgeführt.

Der Standardwert für `retryDelay` ist `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // Antwortstatuscodes für Wiederholungen
});
```

## ✔️ Timeout

Sie können `timeout` in Millisekunden angeben, um eine Anfrage nach einem Timeout automatisch abzubrechen (Standard ist deaktiviert).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Timeout nach 3 Sekunden
});
```

## ✔️ Typfreundlich

Die Antwort kann typunterstützt sein:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Autovervollständigung funktioniert mit article.id
```

## ✔️ Hinzufügen von `baseURL`

Mit der Option `baseURL` fügt `ofetch` diese für nachfolgende/vorangestellte Slashes und Query-Parameter an die URL an, wobei [ufo](https://github.com/unjs/ufo) verwendet wird:

```js
await ofetch("/config", { baseURL });
```

## ✔️ Hinzufügen von Query-Parametern

Mit der Option `query` (oder `params` als Alias) fügt `ofetch` Query-Parameter zur URL hinzu und behält dabei die Query in der Anfrage selbst bei, unter Verwendung von [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptors

Es ist möglich, asynchrone Interceptors bereitzustellen, um in Lebenszyklusereignisse des `ofetch`-Aufrufs einzugreifen.

Sie können `ofetch.create` verwenden, um gemeinsame Interceptors zu setzen.

### `onRequest({ request, options })`

`onRequest` wird aufgerufen, sobald `ofetch` aufgerufen wird, und ermöglicht es Ihnen, Optionen zu ändern oder einfaches Logging durchzuführen.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Anfrage protokollieren
    console.log("[fetch request]", request, options);

    // `?t=1640125211170` zu den Query-Parametern hinzufügen
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` wird aufgerufen, wenn die Fetch-Anfrage fehlschlägt.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Fehler protokollieren
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` wird nach dem `fetch`-Aufruf und dem Parsen des Bodys aufgerufen.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Antwort protokollieren
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` ist das gleiche wie `onResponse`, wird jedoch aufgerufen, wenn ein Fetch stattfindet, aber `response.ok` nicht `true` ist.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Fehler protokollieren
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Übergeben eines Arrays von Interceptors

Falls nötig, ist es auch möglich, ein Array von Funktionen zu übergeben, die nacheinander aufgerufen werden.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Etwas ausführen */
    },
    () => {
      /* Etwas anderes ausführen */
    },
  ],
});
```

## ✔️ Fetch mit Standardoptionen erstellen

Dieses Hilfsprogramm ist nützlich, wenn Sie gemeinsame Optionen für mehrere Fetch-Aufrufe verwenden möchten.

**Hinweis:** Defaults werden auf einer Ebene geklont und vererbt. Seien Sie vorsichtig mit verschachtelten Optionen wie `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Das gleiche wie ofetch('/test', { baseURL: '/api' })
```

## 💡 Hinzufügen von Headern

Mit der Option `headers` fügt `ofetch` zusätzliche Header zu den Standard-Request-Headern hinzu:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Zugriff auf die Rohantwort

Falls Sie auf die Rohantwort zugreifen müssen (z. B. für Header), können Sie `ofetch.raw` verwenden:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Verwendung von Native Fetch

Als Abkürzung können Sie `ofetch.native` verwenden, das die native `fetch`-API bereitstellt.

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Hinzufügen eines HTTP(S)-Agents

In Node.js-Umgebungen (>= 18) können Sie einen benutzerdefinierten Dispatcher bereitstellen, um Anfragen abzufangen und Funktionen wie Proxy und selbstsignierte Zertifikate zu unterstützen. Diese Funktion wird durch [undici](https://undici.nodejs.org/) bereitgestellt, das in Node.js integriert ist. [Mehr erfahren](https://undici.nodejs.org/#/docs/api/Dispatcher) über die Dispatcher-API.

Einige verfügbare Agents:

- `ProxyAgent`: Eine Proxy-Agent-Klasse, die die Agent-API implementiert. Sie ermöglicht die Verbindung über einen Proxy auf einfache Weise. ([Dokumentation](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Eine gemockte Agent-Klasse, die die Agent-API implementiert. Sie ermöglicht das Abfangen von HTTP-Anfragen, die über undici gesendet werden, und gibt stattdessen simulierte Antworten zurück. ([Dokumentation](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent ermöglicht das Versenden von Anfragen an verschiedene Ursprünge. ([Dokumentation](https://undici.nodejs.org/#/docs/api/Agent))

**Beispiel:** Einen Proxy-Agent für eine Anfrage setzen:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Beispiel:** Eine benutzerdefinierte Fetch-Instanz mit aktiviertem Proxy erstellen:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Beispiel:** Einen Proxy-Agent für alle Anfragen setzen:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Beispiel:** Selbstsignierte Zertifikate erlauben (NUTZEN AUF EIGENE GEFAHR!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Hinweis: Dies macht Fetch anfällig für MITM-Angriffe. NUTZEN AUF EIGENE GEFAHR!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

In älteren Node.js-Versionen (<18) können Sie auch `agent` verwenden:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive`-Unterstützung (funktioniert nur für Node < 18)

Indem Sie die Umgebungsvariable `FETCH_KEEP_ALIVE` auf `true` setzen, wird ein HTTP/HTTPS-Agent registriert, der Sockets auch dann offen hält, wenn keine ausstehenden Anfragen bestehen, sodass diese für zukünftige Anfragen wiederverwendet werden können, ohne dass eine neue TCP-Verbindung aufgebaut werden muss.

**Hinweis:** Diese Option kann potenziell zu Speicherlecks führen. Bitte beachten Sie [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Hinweise für Bundler

- Alle Targets werden mit Modul- und CommonJS-Format sowie als benannte Exporte ausgeliefert
- Kein Export wird transpiliert, um moderne Syntax beizubehalten
  - Wahrscheinlich müssen Sie die Pakete `ofetch`, `destr` und `ufo` mit Babel transpiliert werden, um ES5 zu unterstützen
- Sie müssen das globale `fetch` polyfillen, um Legacy-Browser wie mit [unfetch](https://github.com/developit/unfetch) zu unterstützen

## ❓ FAQ

**Warum heißt der Export `ofetch` statt `fetch`?**

Die Verwendung des gleichen Namens wie `fetch` kann verwirrend sein, da die API unterschiedlich ist, aber es handelt sich dennoch um ein Fetch – daher wird die nächstmögliche Alternative verwendet. Sie können jedoch `{ fetch }` aus `ofetch` importieren, das für Node.js automatisch ein Polyfill verwendet und ansonsten das native Fetch nutzt.

**Warum gibt es keinen Default-Export?**

Default-Exporte sind immer riskant, da sie mit CommonJS-Exporten vermischt werden können.

Dies stellt auch sicher, dass wir weitere Utils hinzufügen können, ohne das Paket zu brechen, und fördert zudem die Verwendung des Namens `ofetch`.

**Warum nicht transpiliert?**

Durch das Transpilieren von Bibliotheken wird das Web mit Legacy-Code zurückgeworfen, was für die meisten Nutzer unnötig ist.

Wenn Sie Legacy-Nutzer unterstützen müssen, können Sie die Bibliothek optional in Ihrer Build-Pipeline transpiliert verwenden.
```
## Lizenz

MIT. Erstellt mit 💖

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