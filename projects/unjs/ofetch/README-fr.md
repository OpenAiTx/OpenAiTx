# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Une meilleure API fetch. Fonctionne sur node, navigateur et workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Démarrage rapide

Installation :

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importation :

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Fonctionne avec Node.js

Nous utilisons les [exports conditionnels](https://nodejs.org/api/packages.html#packages_conditional_exports) pour détecter Node.js
et utiliser automatiquement [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Si `globalThis.fetch` est disponible, il sera utilisé à la place. Pour profiter de l’API fetch native expérimentale de Node.js 17.5.0, utilisez le paramètre [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Analyse de la réponse

`ofetch` analysera intelligemment le JSON et les valeurs natives à l’aide de [destr](https://github.com/unjs/destr), et reviendra au texte si l’analyse échoue.

```js
const { users } = await ofetch("/api/users");
```

Pour les types de contenu binaire, `ofetch` retournera à la place un objet `Blob`.

Vous pouvez optionnellement fournir un analyseur différent de `destr`, ou spécifier `blob`, `arrayBuffer` ou `text` pour forcer l'analyse du corps avec la méthode `FetchResponse` correspondante.

```js
// Utiliser JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Retourner le texte tel quel
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Obtenir la version blob de la réponse
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Corps JSON

Si un objet ou une classe avec une méthode `.toJSON()` est passé à l’option `body`, `ofetch` le convertit automatiquement en chaîne JSON.

`ofetch` utilise `JSON.stringify()` pour convertir l’objet passé. Les classes sans méthode `.toJSON()` doivent être converties en une valeur chaîne à l’avance avant d’être passées à l’option `body`.

Pour les méthodes de requête `PUT`, `PATCH` et `POST`, lorsqu’un corps de type chaîne ou objet est défini, `ofetch` ajoute par défaut les en-têtes `content-type: "application/json"` et `accept: "application/json"` (que vous pouvez toujours remplacer).

De plus, `ofetch` prend en charge les réponses binaires avec `Buffer`, `ReadableStream`, `Stream` et [types de corps compatibles](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` ajoutera automatiquement l’option `duplex: "half"` pour la prise en charge du streaming !

**Exemple :**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Gestion des erreurs

`ofetch` lève automatiquement des erreurs lorsque `response.ok` est `false`, avec un message d’erreur explicite et une pile compacte (qui masque les internes).

Un corps d’erreur analysé est disponible via `error.data`. Vous pouvez également utiliser le type `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Pour intercepter la réponse d’erreur :

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

Pour contourner la capture des erreurs de statut, vous pouvez définir l’option `ignoreResponseError` :

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Reprise Automatique

`ofetch` réessaie automatiquement la requête si une erreur se produit et si le code de statut de la réponse est inclus dans la liste `retryStatusCodes` :

**Codes de statut de reprise :**

- `408` - Délai d’attente de la requête dépassé
- `409` - Conflit
- `425` - Trop tôt ([Expérimental](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Trop de requêtes
- `500` - Erreur interne du serveur
- `502` - Mauvaise passerelle
- `503` - Service indisponible
- `504` - Délai d’attente de la passerelle dépassé

Vous pouvez spécifier le nombre de tentatives et le délai entre elles à l’aide des options `retry` et `retryDelay`, et également passer un tableau personnalisé de codes avec l’option `retryStatusCodes`.

La valeur par défaut pour `retry` est `1` tentative, sauf pour les méthodes `POST`, `PUT`, `PATCH` et `DELETE` où `ofetch` ne réessaie pas par défaut afin d’éviter d’introduire des effets secondaires. Si vous définissez une valeur personnalisée pour `retry`, il y aura **toujours une reprise** pour toutes les requêtes.

La valeur par défaut pour `retryDelay` est `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // codes de statut de réponse à reprendre
});
```

## ✔️ Délai d’expiration (Timeout)

Vous pouvez spécifier un `timeout` en millisecondes pour interrompre automatiquement une requête après un délai d’expiration (par défaut, désactivé).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Délai d’expiration après 3 secondes
});
```

## ✔️ Compatible avec les types

La réponse peut être assistée par type :

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// L’autocomplétion fonctionne avec article.id
```

## ✔️ Ajout de `baseURL`

En utilisant l’option `baseURL`, `ofetch` la préfixe en gérant les barres obliques de fin/début et les paramètres de recherche de la baseURL avec [ufo](https://github.com/unjs/ufo) :

```js
await ofetch("/config", { baseURL });
```

## ✔️ Ajout de paramètres de recherche

En utilisant l’option `query` (ou `params` comme alias), `ofetch` ajoute des paramètres de recherche à l’URL tout en préservant la requête elle-même à l’aide de [ufo](https://github.com/unjs/ufo) :

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Intercepteurs

Il est possible de fournir des intercepteurs asynchrones pour s’insérer dans les événements du cycle de vie de l’appel `ofetch`.

Vous pouvez utiliser `ofetch.create` pour définir des intercepteurs partagés.

### `onRequest({ request, options })`

`onRequest` est appelé dès que `ofetch` est appelé, ce qui vous permet de modifier les options ou d’effectuer une simple journalisation.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Journaliser la requête
    console.log("[fetch request]", request, options);

    // Ajouter `?t=1640125211170` aux paramètres de recherche
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` sera appelé lorsque la requête fetch échoue.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Journaliser l'erreur
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` sera appelé après l'appel `fetch` et l'analyse du corps.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Journaliser la réponse
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` fonctionne comme `onResponse` mais sera appelé lorsque le fetch a lieu mais que `response.ok` n'est pas `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Journaliser l'erreur
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Passer un tableau d'intercepteurs

Si nécessaire, il est également possible de passer un tableau de fonctions qui seront appelées séquentiellement.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Faire quelque chose */
    },
    () => {
      /* Faire autre chose */
    },
  ],
});
```

## ✔️ Créer un fetch avec des options par défaut

Cet utilitaire est utile si vous avez besoin d'utiliser des options communes pour plusieurs appels fetch.

**Note :** Les valeurs par défaut seront clonées à un niveau et héritées. Soyez prudent avec les options imbriquées comme `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Équivaut à ofetch('/test', { baseURL: '/api' })
```

## 💡 Ajouter des en-têtes

En utilisant l'option `headers`, `ofetch` ajoute des en-têtes supplémentaires en plus des en-têtes par défaut de la requête :

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Accès à la réponse brute

Si vous avez besoin d'accéder à la réponse brute (pour les en-têtes, etc.), vous pouvez utiliser `ofetch.raw` :

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Utiliser le Fetch natif

En raccourci, vous pouvez utiliser `ofetch.native` qui fournit l'API native `fetch`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Ajout d’un agent HTTP(S)

Dans les environnements Node.js (>= 18), vous pouvez fournir un dispatcher personnalisé pour intercepter les requêtes et prendre en charge des fonctionnalités telles que le proxy et les certificats auto-signés. Cette fonctionnalité est activée par [undici](https://undici.nodejs.org/) intégré à Node.js. [en savoir plus](https://undici.nodejs.org/#/docs/api/Dispatcher) sur l’API Dispatcher.

Quelques agents disponibles :

- `ProxyAgent` : Une classe Proxy Agent qui implémente l’API Agent. Elle permet la connexion via un proxy de manière simple. ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent` : Une classe Agent simulée qui implémente l’API Agent. Elle permet d’intercepter les requêtes HTTP effectuées via undici et de renvoyer des réponses simulées à la place. ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent` : Agent permet de dispatcher des requêtes vers plusieurs origines différentes. ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**Exemple :** Définir un proxy agent pour une requête :

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Exemple :** Créer une instance fetch personnalisée avec le proxy activé :

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Exemple :** Définir un proxy agent pour toutes les requêtes :

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Exemple :** Autoriser les certificats auto-signés (À UTILISER À VOS RISQUES ET PÉRILS !)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Remarque : cela rend fetch non sécurisé contre les attaques MITM. À UTILISER À VOS RISQUES ET PÉRILS !
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Sur les versions plus anciennes de Node.js (<18), vous pouvez également utiliser `agent` :

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Support de `keepAlive` (fonctionne uniquement pour Node < 18)

En définissant la variable d’environnement `FETCH_KEEP_ALIVE` à `true`, un agent HTTP/HTTPS sera enregistré pour conserver les sockets même lorsqu’il n’y a pas de requêtes en cours, afin qu’ils puissent être utilisés pour de futures requêtes sans avoir à rétablir une connexion TCP.

**Remarque :** Cette option peut potentiellement introduire des fuites de mémoire. Merci de consulter [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Notes sur le bundler

- Toutes les cibles sont exportées aux formats Module et CommonJS avec des exports nommés
- Aucun export n’est transpilé afin de conserver une syntaxe moderne
  - Il vous faudra probablement transpiler les packages `ofetch`, `destr` et `ufo` avec Babel pour la prise en charge d’ES5
- Vous devez polyfiller le global `fetch` pour prendre en charge les anciens navigateurs, par exemple en utilisant [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Pourquoi l’export s’appelle-t-il `ofetch` au lieu de `fetch` ?**

Utiliser le même nom que `fetch` peut prêter à confusion car l’API est différente, même si cela reste un fetch, donc on utilise l’alternative la plus proche possible. Cependant, vous pouvez importer `{ fetch }` depuis `ofetch`, qui est un auto-polyfill pour Node.js et utilise le natif sinon.

**Pourquoi ne pas avoir d’export par défaut ?**

Les exports par défaut sont toujours risqués car ils peuvent être confondus avec les exports CommonJS.

Cela garantit aussi que nous pouvons introduire plus d’utilitaires sans casser le package et encourage également l’utilisation du nom `ofetch`.

**Pourquoi ne pas transpiler ?**

En transpilant les bibliothèques, nous faisons reculer le web avec du code obsolète qui est inutile pour la plupart des utilisateurs.

Si vous devez prendre en charge des utilisateurs anciens, vous pouvez optionnellement transpiler la bibliothèque dans votre pipeline de build.
```
## Licence

MIT. Fait avec 💖

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