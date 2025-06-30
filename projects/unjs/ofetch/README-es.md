# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Una mejor API de fetch. Funciona en node, navegador y workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Inicio Rápido

Instalar:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importar:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Funciona con Node.js

Usamos [exports condicionales](https://nodejs.org/api/packages.html#packages_conditional_exports) para detectar Node.js
y usar automáticamente [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Si `globalThis.fetch` está disponible, será usado en su lugar. Para aprovechar la API experimental nativa de fetch de Node.js 17.5.0 usa la opción [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Parseo de la Respuesta

`ofetch` analizará de forma inteligente valores JSON y nativos usando [destr](https://github.com/unjs/destr), volviendo al texto si falla el parseo.

```js
const { users } = await ofetch("/api/users");
```

Para tipos de contenido binario, `ofetch` devolverá un objeto `Blob`.

Opcionalmente puedes proporcionar un parser diferente a `destr`, o especificar `blob`, `arrayBuffer` o `text` para forzar el parseo del cuerpo con el método respectivo de `FetchResponse`.

```js
// Usar JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Devolver el texto tal cual
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Obtener la versión blob de la respuesta
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Cuerpo JSON

Si se pasa un objeto o una clase con un método `.toJSON()` a la opción `body`, `ofetch` lo convierte automáticamente a cadena.

`ofetch` utiliza `JSON.stringify()` para convertir el objeto pasado. Las clases sin un método `.toJSON()` deben convertirse en un valor de tipo cadena previamente antes de pasarlas a la opción `body`.

Para los métodos de petición `PUT`, `PATCH` y `POST`, cuando se establece un cuerpo como cadena u objeto, `ofetch` añade por defecto las cabeceras `content-type: "application/json"` y `accept: "application/json"` (que siempre puedes sobrescribir).

Adicionalmente, `ofetch` soporta respuestas binarias con `Buffer`, `ReadableStream`, `Stream` y [tipos de cuerpo compatibles](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). ¡`ofetch` configurará automáticamente la opción `duplex: "half"` para soporte de streaming!

**Ejemplo:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Manejo de Errores

`ofetch` lanza errores automáticamente cuando `response.ok` es `false` con un mensaje de error amigable y un stack compacto (ocultando detalles internos).

Un cuerpo de error parseado está disponible con `error.data`. También puedes usar el tipo `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Para capturar la respuesta de error:

```ts
await ofetch("/url").catch((error) => error.data);
```

Para omitir el control de errores de estado, puedes establecer la opción `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Reintento Automático

`ofetch` reintenta automáticamente la solicitud si ocurre un error y si el código de estado de la respuesta está incluido en la lista `retryStatusCodes`:

**Códigos de estado para reintentos:**

- `408` - Tiempo de espera de la solicitud agotado
- `409` - Conflicto
- `425` - Demasiado temprano ([Experimental](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Demasiadas solicitudes
- `500` - Error interno del servidor
- `502` - Puerta de enlace incorrecta
- `503` - Servicio no disponible
- `504` - Tiempo de espera de la puerta de enlace agotado

Puedes especificar la cantidad de reintentos y el tiempo de espera entre ellos usando las opciones `retry` y `retryDelay`, y también pasar un arreglo personalizado de códigos usando la opción `retryStatusCodes`.

El valor predeterminado de `retry` es `1` reintento, excepto para los métodos `POST`, `PUT`, `PATCH` y `DELETE` donde `ofetch` no realiza reintentos por defecto para evitar efectos secundarios. Si estableces un valor personalizado para `retry` **siempre reintentará** para todas las solicitudes.

El valor predeterminado de `retryDelay` es `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // códigos de estado de respuesta para reintentar
});
```

## ✔️ Tiempo de Espera (Timeout)

Puedes especificar `timeout` en milisegundos para abortar automáticamente una solicitud después de un tiempo de espera (por defecto está deshabilitado).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Tiempo de espera de 3 segundos
});
```

## ✔️ Compatible con Tipos

La respuesta puede tener asistencia de tipos:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Autocompletado funcionando con article.id
```

## ✔️ Añadiendo `baseURL`

Usando la opción `baseURL`, `ofetch` la antepone manejando las barras diagonales y los parámetros de búsqueda para baseURL usando [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Añadiendo Parámetros de Consulta

Usando la opción `query` (o `params` como alias), `ofetch` añade parámetros de búsqueda a la URL conservando la consulta en la propia solicitud usando [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptores

Es posible proporcionar interceptores asíncronos para engancharse en los eventos del ciclo de vida de la llamada de `ofetch`.

Puede que desees usar `ofetch.create` para establecer interceptores compartidos.

### `onRequest({ request, options })`

`onRequest` se llama tan pronto como se invoca `ofetch`, permitiéndote modificar opciones o realizar un registro simple.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Registrar solicitud
    console.log("[fetch request]", request, options);

    // Agregar `?t=1640125211170` a los parámetros de búsqueda
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` se llamará cuando la solicitud fetch falle.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Registrar error
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` será llamado después de la llamada a `fetch` y de analizar el cuerpo.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Registrar respuesta
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` es igual que `onResponse` pero se llamará cuando fetch ocurra pero `response.ok` no sea `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Registrar error
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Pasando un array de interceptores

Si es necesario, también es posible pasar un array de funciones que serán llamadas secuencialmente.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Hacer algo */
    },
    () => {
      /* Hacer otra cosa */
    },
  ],
});
```

## ✔️ Crear fetch con opciones predeterminadas

Esta utilidad es útil si necesitas usar opciones comunes en varias llamadas fetch.

**Nota:** Los valores predeterminados serán clonados a un nivel e heredados. Ten cuidado con opciones anidadas como `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Igual que ofetch('/test', { baseURL: '/api' })
```

## 💡 Añadir encabezados

Usando la opción `headers`, `ofetch` añade encabezados extra además de los encabezados predeterminados de la solicitud:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Acceso a la respuesta cruda

Si necesitas acceder a la respuesta cruda (para encabezados, etc.), puedes usar `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Usando Fetch Nativo

Como atajo, puedes usar `ofetch.native` que proporciona la API nativa de `fetch`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Añadiendo Agente HTTP(S)

En entornos Node.js (>= 18), puedes proporcionar un dispatcher personalizado para interceptar solicitudes y soportar características como Proxy y certificados autofirmados. Esta funcionalidad es posible gracias a [undici](https://undici.nodejs.org/) integrado en Node.js. [lee más](https://undici.nodejs.org/#/docs/api/Dispatcher) sobre la API de Dispatcher.

Algunos agentes disponibles:

- `ProxyAgent`: Una clase de Proxy Agent que implementa la API de Agent. Permite la conexión a través de un proxy de manera sencilla. ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Una clase Agent simulada que implementa la API de Agent. Permite interceptar solicitudes HTTP hechas a través de undici y devolver respuestas simuladas en su lugar. ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent permite despachar solicitudes contra múltiples orígenes diferentes. ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**Ejemplo:** Establecer un agente proxy para una solicitud:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Ejemplo:** Crear una instancia personalizada de fetch con proxy habilitado:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Ejemplo:** Establecer un agente proxy para todas las solicitudes:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Ejemplo:** Permitir certificados autofirmados (¡USAR BAJO TU PROPIO RIESGO!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Nota: Esto hace que fetch sea inseguro contra ataques MITM. ¡USAR BAJO TU PROPIO RIESGO!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

En versiones antiguas de Node.js (<18), también puedes usar `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Soporte para `keepAlive` (solo funciona para Node < 18)

Estableciendo la variable de entorno `FETCH_KEEP_ALIVE` en `true`, se registrará un agente HTTP/HTTPS que mantiene los sockets abiertos incluso cuando no hay solicitudes pendientes, por lo que pueden usarse para futuras solicitudes sin tener que volver a establecer una conexión TCP.

**Nota:** Esta opción puede potencialmente introducir fugas de memoria. Por favor revisa [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Notas para Bundlers

- Todos los targets se exportan con formato Module y CommonJS y exports nombrados
- Ninguna exportación está transpilada para mantener la sintaxis moderna
  - Probablemente necesitarás transpilar los paquetes `ofetch`, `destr` y `ufo` con Babel para soporte ES5
- Necesitas hacer un polyfill del global `fetch` para soportar navegadores antiguos, por ejemplo usando [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**¿Por qué la exportación se llama `ofetch` en vez de `fetch`?**

Usar el mismo nombre de `fetch` puede ser confuso ya que la API es diferente, pero sigue siendo un fetch, por lo que se usa la alternativa más cercana posible. Sin embargo, puedes importar `{ fetch }` de `ofetch`, que es un auto-polyfill para Node.js y usa el nativo en otros casos.

**¿Por qué no hay exportación por defecto?**

Las exportaciones por defecto siempre son arriesgadas de mezclar con exports CommonJS.

Esto también garantiza que podemos introducir más utilidades sin romper el paquete y fomenta el uso del nombre `ofetch`.

**¿Por qué no está transpilado?**

Al transpilar librerías, empujamos la web hacia atrás con código legado que no es necesario para la mayoría de los usuarios.

Si necesitas soportar usuarios antiguos, puedes transpilar la librería opcionalmente en tu pipeline de construcción.
```
## Licencia

MIT. Hecho con 💖

<!-- Insignias -->

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