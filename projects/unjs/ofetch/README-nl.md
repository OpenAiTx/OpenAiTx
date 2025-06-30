# ofetch

[![npm versie][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![Licentie][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Een betere fetch API. Werkt op node, browser en workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Snel Starten

Installeren:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importeren:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Werkt met Node.js

We gebruiken [conditionele exports](https://nodejs.org/api/packages.html#packages_conditional_exports) om Node.js te detecteren
en gebruiken automatisch [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Als `globalThis.fetch` beschikbaar is, wordt deze gebruikt. Om de experimentele native fetch API van Node.js 17.5.0 te gebruiken, gebruik de [`--experimental-fetch` vlag](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Response Parsen

`ofetch` zal JSON en native waarden slim parsen met behulp van [destr](https://github.com/unjs/destr), en terugvallen op tekst als het niet lukt te parsen.

```js
const { users } = await ofetch("/api/users");
```

Voor binaire content types retourneert `ofetch` in plaats daarvan een `Blob` object.

Je kunt optioneel een andere parser dan `destr` opgeven, of `blob`, `arrayBuffer` of `text` specificeren om het body te forceren te parsen met de respectievelijke `FetchResponse` methode.

```js
// Gebruik JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Retourneer tekst zoals het is
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Verkrijg de blob-versie van de response
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON Body

Als een object of een klasse met een `.toJSON()` methode wordt doorgegeven aan de `body` optie, stringifyt `ofetch` deze automatisch.

`ofetch` gebruikt `JSON.stringify()` om het doorgegeven object te converteren. Klassen zonder een `.toJSON()` methode moeten vooraf worden omgezet naar een string voordat ze aan de `body` optie worden doorgegeven.

Voor de request-methoden `PUT`, `PATCH` en `POST`, wanneer een string of object body is ingesteld, voegt `ofetch` standaard de headers `content-type: "application/json"` en `accept: "application/json"` toe (deze kun je altijd overschrijven).

Daarnaast ondersteunt `ofetch` binaire responses met `Buffer`, `ReadableStream`, `Stream` en [compatibele bodytypes](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` stelt automatisch de optie `duplex: "half"` in voor streaming-ondersteuning!

**Voorbeeld:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Foutafhandeling

`ofetch` gooit automatisch fouten als `response.ok` `false` is, met een duidelijke foutmelding en compacte stack (zonder interne details).

Een geparseerd error-body is beschikbaar met `error.data`. Je kunt ook het type `FetchError` gebruiken.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Om een foutresponse op te vangen:

```ts
```ts
await ofetch("/url").catch((error) => error.data);
```

Om het afvangen van statusfouten te omzeilen kun je de optie `ignoreResponseError` instellen:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Automatisch Opnieuw Proberen

`ofetch` probeert automatisch het verzoek opnieuw als er een fout optreedt en als de statuscode van het antwoord is opgenomen in de lijst `retryStatusCodes`:

**Statuscodes voor opnieuw proberen:**

- `408` - Request Timeout (Verzoek Time-out)
- `409` - Conflict (Conflict)
- `425` - Too Early ([Experimenteel](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests (Te veel verzoeken)
- `500` - Internal Server Error (Interne serverfout)
- `502` - Bad Gateway (Ongeldige gateway)
- `503` - Service Unavailable (Dienst niet beschikbaar)
- `504` - Gateway Timeout (Gateway time-out)

Je kunt het aantal pogingen en de vertraging ertussen specificeren met de opties `retry` en `retryDelay`, en ook een aangepaste array van codes meegeven via de optie `retryStatusCodes`.

De standaardwaarde voor `retry` is `1` poging, behalve voor de methoden `POST`, `PUT`, `PATCH` en `DELETE`, waarbij `ofetch` standaard niet opnieuw probeert om bijwerkingen te voorkomen. Als je een aangepaste waarde instelt voor `retry`, zal deze **altijd opnieuw proberen** voor alle verzoeken.

De standaardwaarde voor `retryDelay` is `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // statuscodes om opnieuw te proberen
});
```

## ✔️ Timeout

Je kunt `timeout` in milliseconden opgeven om een verzoek automatisch af te breken na een timeout (standaard is dit uitgeschakeld).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Time-out na 3 seconden
});
```

## ✔️ Typevriendelijk

Het antwoord kan type-ondersteund zijn:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Auto-aanvullen werkt met article.id
```

## ✔️ Toevoegen van `baseURL`

Door de optie `baseURL` te gebruiken, voegt `ofetch` deze toe voor/na schuine strepen en query-zoekparameters voor baseURL met behulp van [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Toevoegen van Query Zoekparameters

Door de optie `query` (of `params` als alias) te gebruiken, voegt `ofetch` zoekparameters toe aan de URL waarbij de query in het verzoek zelf behouden blijft met behulp van [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptors

Het is mogelijk om asynchrone interceptors te leveren om in te haken op de levenscyclusgebeurtenissen van een `ofetch`-aanroep.

Je kunt `ofetch.create` gebruiken om gedeelde interceptors in te stellen.

### `onRequest({ request, options })`

`onRequest` wordt aangeroepen zodra `ofetch` wordt aangeroepen, zodat je opties kunt wijzigen of eenvoudige logging kunt uitvoeren.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Log verzoek
    console.log("[fetch request]", request, options);

    // Voeg `?t=1640125211170` toe aan de zoekparameters
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` wordt aangeroepen wanneer het fetch-verzoek mislukt.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Log fout
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` wordt aangeroepen na de `fetch`-aanroep en het parsen van de body.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Log response
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` is hetzelfde als `onResponse`, maar wordt aangeroepen wanneer fetch plaatsvindt, maar `response.ok` niet `true` is.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Log fout
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Array van interceptors doorgeven

Indien nodig is het ook mogelijk om een array van functies door te geven die achtereenvolgens worden aangeroepen.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Doe iets */
    },
    () => {
      /* Doe iets anders */
    },
  ],
});
```

## ✔️ Fetch aanmaken met standaardopties

Deze utility is handig als je gemeenschappelijke opties wilt gebruiken voor meerdere fetch-aanroepen.

**Let op:** Standaardinstellingen worden één niveau diep gekloond en geërfd. Let op met geneste opties zoals `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Hetzelfde als ofetch('/test', { baseURL: '/api' })
```

## 💡 Headers toevoegen

Door de optie `headers` te gebruiken, voegt `ofetch` extra headers toe naast de standaard headers van het verzoek:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Toegang tot ruwe respons

Als je toegang nodig hebt tot de ruwe respons (voor headers, enz.), kun je `ofetch.raw` gebruiken:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Gebruik van Native Fetch

Als snelkoppeling kun je `ofetch.native` gebruiken, dat de native `fetch` API biedt

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ HTTP(S)-agent toevoegen

In Node.js (>= 18)-omgevingen kun je een aangepaste dispatcher opgeven om verzoeken te onderscheppen en functies zoals Proxy en zelfondertekende certificaten te ondersteunen. Deze functie is ingeschakeld door [undici](https://undici.nodejs.org/) ingebouwd in Node.js. [lees meer](https://undici.nodejs.org/#/docs/api/Dispatcher) over de Dispatcher API.

Enkele beschikbare agents:

- `ProxyAgent`: Een Proxy Agent-klasse die de Agent API implementeert. Hiermee kan de verbinding eenvoudig via een proxy verlopen. ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Een gemockte Agent-klasse die de Agent API implementeert. Hiermee kun je HTTP-verzoeken die via undici worden gedaan onderscheppen en in plaats daarvan gemockte responses retourneren. ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent maakt het mogelijk om verzoeken uit te voeren naar verschillende origins. ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**Voorbeeld:** Stel een proxy-agent in voor één verzoek:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Voorbeeld:** Maak een aangepaste fetch-instantie met proxy ingeschakeld:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Voorbeeld:** Stel een proxy-agent in voor alle verzoeken:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Voorbeeld:** Sta zelfondertekende certificaten toe (GEBRUIK OP EIGEN RISICO!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Let op: Dit maakt fetch onveilig tegen MITM-aanvallen. GEBRUIK OP EIGEN RISICO!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Op oudere Node.js-versies (<18), kun je ook `agent` gebruiken:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive`-ondersteuning (werkt alleen voor Node < 18)

Door de omgevingsvariabele `FETCH_KEEP_ALIVE` op `true` te zetten, wordt er een HTTP/HTTPS-agent geregistreerd die sockets vasthoudt, zelfs wanneer er geen openstaande verzoeken zijn, zodat ze gebruikt kunnen worden voor toekomstige verzoeken zonder opnieuw een TCP-verbinding op te zetten.

**Let op:** Deze optie kan mogelijk geheugenlekken veroorzaken. Controleer [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Bundler-notities

- Alle targets worden geëxporteerd met Module- en CommonJS-formaat en named exports
- Geen enkele export wordt getranspiled ten behoeve van moderne syntaxis
  - Je zult waarschijnlijk de pakketten `ofetch`, `destr` en `ufo` met Babel moeten transpilen voor ES5-ondersteuning
- Je moet de globale `fetch` polyfillen om legacy browsers te ondersteunen, bijvoorbeeld met [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Waarom heet de export `ofetch` in plaats van `fetch`?**

Het gebruik van dezelfde naam als `fetch` kan verwarrend zijn omdat de API anders is, maar het blijft fetch, dus wordt de dichtst mogelijke alternatieve naam gebruikt. Je kunt echter `{ fetch }` importeren uit `ofetch`, wat automatisch een polyfill is voor Node.js en anders de native versie gebruikt.

**Waarom geen default export?**

Standaard exports zijn altijd riskant om te mengen met CommonJS-exports.

Dit garandeert ook dat we meer utils kunnen introduceren zonder het pakket te breken en moedigt het gebruik van de naam `ofetch` aan.

**Waarom niet getranspiled?**

Door libraries te transpilen, dringen we het web terug met legacy code die voor de meeste gebruikers niet nodig is.

Als je legacy gebruikers wilt ondersteunen, kun je er optioneel voor kiezen om de library in je build-pijplijn te transpilen.
```
## Licentie

MIT. Gemaakt met 💖

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