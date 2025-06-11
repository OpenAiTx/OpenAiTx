<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky est un client HTTP minuscule et élégant basé sur l'[API Fetch](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky cible les [navigateurs modernes](#browser-support), Node.js, Bun et Deno.

C'est juste un petit paquet sans dépendances.

## Avantages par rapport à `fetch` natif

- API plus simple
- Raccourcis de méthode (`ky.post()`)
- Considère les codes de statut non 2xx comme des erreurs (après les redirections)
- Relance les requêtes échouées
- Option JSON
- Prise en charge du timeout
- Option de préfixe d’URL
- Instances avec des valeurs par défaut personnalisées
- Hooks
- Fonctionnalités TypeScript agréables (par exemple, `.json()` prend en charge les génériques et a `unknown` comme valeur par défaut, pas `any`)

## Installation

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Utilisation

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Avec `fetch` natif, cela serait :

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

Si vous utilisez [Deno](https://github.com/denoland/deno), importez Ky depuis une URL. Par exemple, via un CDN :

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

Les paramètres `input` et `options` sont identiques à ceux de [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), avec des `options` supplémentaires disponibles (voir ci-dessous).

Retourne un [objet `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) avec des [méthodes `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) ajoutées pour plus de commodité. Vous pouvez ainsi, par exemple, appeler directement `ky.get(input).json()` sans avoir à attendre d’abord la `Response`. Lorsqu’on l’appelle ainsi, un en-tête `Accept` approprié sera défini en fonction de la méthode body utilisée. Contrairement aux méthodes `Body` de `window.Fetch`, celles-ci lanceront une exception `HTTPError` si le statut de la réponse n’est pas dans la plage `200...299`. De plus, `.json()` retournera une chaîne vide si le body est vide ou si le statut de la réponse est `204` au lieu de lancer une erreur de parsing en raison d’un corps vide.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript :** Accepte un [paramètre de type optionnel](https://www.typescriptlang.org/docs/handbook/2/generics.html), qui vaut par défaut [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), et est transmis au type de retour de `.json()`.

```ts
import ky from 'ky';

// user1 est unknown
const user1 = await ky('/api/users/1').json();
// user2 est un User
const user2 = await ky<User>('/api/users/2').json();
// user3 est un User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Définit `options.method` sur le nom de la méthode et effectue la requête.

⌨️ **TypeScript :** Accepte un paramètre de type optionnel à utiliser avec les réponses JSON (voir [`ky()`](#kyinput-options)).

#### input

Type : `string` | `URL` | `Request`

Identique à l’[entrée de `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Lorsque vous utilisez une instance [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) comme `input`, toutes les options modifiant l’URL (telles que `prefixUrl`) seront ignorées.

#### options

Type : `object`

Identique aux [options de `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), plus les options supplémentaires suivantes :

##### method

Type : `string`\
Valeur par défaut : `'get'`

Méthode HTTP utilisée pour effectuer la requête.

En interne, les méthodes standard (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` et `DELETE`) sont mises en majuscule afin d’éviter les erreurs côté serveur dues à la sensibilité à la casse.

##### json

Type : `object` et toute autre valeur acceptée par [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Raccourci pour l’envoi de JSON. À utiliser à la place de l’option `body`. Accepte tout objet ou valeur simple, qui sera converti en JSON via `JSON.stringify()` et envoyé dans le body avec l’en-tête approprié.

##### searchParams

Type : `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Valeur par défaut : `''`

Paramètres de recherche à inclure dans l’URL de la requête. Les définir écrasera tous les paramètres de recherche existants dans l’URL d’entrée.

Accepte toute valeur supportée par [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Type : `string | URL`

Un préfixe à ajouter à l’URL `input` lors de la requête. Cela peut être n’importe quelle URL valide, relative ou absolue. Un slash final `/` est optionnel et sera ajouté automatiquement, si besoin, lorsqu’il est combiné avec `input`. Prend effet uniquement lorsque `input` est une chaîne. L’argument `input` ne peut pas commencer par un slash `/` lors de l’utilisation de cette option.

Utile en combinaison avec [`ky.extend()`](#kyextenddefaultoptions) pour créer des instances Ky spécifiques à un usage particulier.

```js
import ky from 'ky';

// Sur https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Notes :
 - Après la combinaison de `prefixUrl` et `input`, le résultat est résolu par rapport à l’[URL de base](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) de la page (si elle existe).
 - Les slashes initiaux dans `input` sont interdits lors de l’utilisation de cette option afin d’assurer la cohérence et d’éviter toute confusion sur la façon dont l’URL `input` est traitée, puisque `input` ne suivra pas les règles normales de résolution d’URL quand `prefixUrl` est utilisé, ce qui change la signification d’un slash initial.

##### retry

Type : `object | number`\
Valeur par défaut :
- `limit` : `2`
- `methods` : `get` `put` `head` `delete` `options` `trace`
- `statusCodes` : [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes` : [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter` : `undefined`
- `backoffLimit` : `undefined`
- `delay` : `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Un objet représentant les champs `limit`, `methods`, `statusCodes`, `afterStatusCodes` et `maxRetryAfter` pour le nombre maximal de tentatives, les méthodes autorisées, les codes de statut autorisés, les codes de statut autorisés à utiliser le temps [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) et le temps maximal [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Si `retry` est un nombre, il sera utilisé comme `limit` et les autres valeurs par défaut resteront inchangées.

Si la réponse fournit un code HTTP contenu dans `afterStatusCodes`, Ky attendra que la date, le délai d'attente ou le timestamp donné dans l’en-tête [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) soit passé pour réessayer la requête. Si `Retry-After` est absent, l’en-tête non standard [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) est utilisé comme solution de repli. Si le code de statut fourni n'est pas dans la liste, l’en-tête [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) sera ignoré.

Si `maxRetryAfter` est défini sur `undefined`, il utilisera `options.timeout`. Si l’en-tête [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) est supérieur à `maxRetryAfter`, il utilisera `maxRetryAfter`.

L'option `backoffLimit` est la limite supérieure du délai par tentative en millisecondes.
Pour limiter le délai, définissez `backoffLimit` à 1000, par exemple.
Par défaut, le délai est calculé avec `0.3 * (2 ** (attemptCount - 1)) * 1000`. Le délai augmente exponentiellement.

L’option `delay` peut être utilisée pour changer la façon dont le délai entre les tentatives est calculé. La fonction reçoit un paramètre, le nombre de tentatives, commençant à `1`.

Les tentatives ne sont pas déclenchées suite à un [timeout](#timeout).

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

Type : `number | false`\
Par défaut : `10000`

Délai d'attente en millisecondes pour obtenir une réponse, y compris toutes les tentatives. Ne peut pas dépasser 2147483647.
Si défini à `false`, il n’y aura pas de délai d’attente.

##### hooks

Type : `object<string, Function[]>`\
Par défaut : `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Les hooks permettent des modifications pendant le cycle de vie de la requête. Les fonctions hook peuvent être asynchrones et sont exécutées en série.

###### hooks.beforeRequest

Type : `Function[]`\
Par défaut : `[]`

Ce hook permet de modifier la requête juste avant qu'elle ne soit envoyée. Ky n’apportera plus aucun changement à la requête après cela. La fonction hook reçoit `request` et `options` en arguments. Vous pouvez, par exemple, modifier ici les `request.headers`.

Le hook peut retourner un [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) pour remplacer la requête sortante, ou retourner une [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) pour éviter complètement de faire une requête HTTP. Cela peut être utilisé pour simuler une requête, vérifier un cache interne, etc. Une considération **importante** lors du retour d'une requête ou d'une réponse depuis ce hook est que tous les hooks `beforeRequest` restants seront ignorés, il peut donc être préférable de ne les retourner que depuis le dernier hook.

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

Type : `Function[]`\
Par défaut : `[]`

Ce hook permet de modifier la requête juste avant la nouvelle tentative. Ky n’apportera plus aucun changement à la requête après cela. La fonction hook reçoit un objet avec la requête et les options normalisées, une instance d’erreur et le nombre de tentatives. Vous pouvez, par exemple, modifier ici les `request.headers`.

Si la requête a reçu une réponse, l’erreur sera de type `HTTPError` et l’objet `Response` sera disponible via `error.response`. Notez que certains types d’erreurs, comme les erreurs réseau, signifient par nature qu’aucune réponse n’a été reçue. Dans ce cas, l’erreur ne sera pas une instance de `HTTPError`.

Vous pouvez empêcher Ky de réessayer la requête en lançant une erreur. Ky ne la gérera d’aucune façon et l’erreur sera propagée à l’initiateur de la requête. Le reste des hooks `beforeRetry` ne sera pas appelé dans ce cas. Alternativement, vous pouvez retourner le symbole [`ky.stop`](#kystop) pour faire la même chose mais sans propager d’erreur (cela a quelques limitations, voir la documentation de `ky.stop` pour les détails).

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

Type : `Function[]`\
Par défaut : `[]`

Ce hook permet de modifier le `HTTPError` juste avant qu’il ne soit levé. La fonction hook reçoit un `HTTPError` en argument et doit retourner une instance de `HTTPError`.

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

Type : `Function[]`\
Par défaut : `[]`

Ce hook permet de lire et éventuellement de modifier la réponse. La fonction hook reçoit la requête normalisée, les options et un clone de la réponse en arguments. La valeur de retour de la fonction hook sera utilisée par Ky comme objet réponse si c’est une instance de [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Vous pouvez faire quelque chose avec la réponse, par exemple, un log.
				log(response);

				// Ou retourner une instance de `Response` pour remplacer la réponse.
				return new Response('A different response', {status: 200});
			},

			// Ou refaire une tentative avec un nouveau token sur une erreur 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Obtenir un nouveau token
					const token = await ky('https://example.com/token').text();

					// Réessayer avec le token
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Type : `boolean`\
Par défaut : `true`

Lève une `HTTPError` lorsque, après avoir suivi les redirections, la réponse a un code de statut non-2xx. Pour lever également pour les redirections au lieu de les suivre, définissez l’option [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) à `'manual'`.

Définir ceci à `false` peut être utile si vous vérifiez la disponibilité d'une ressource et attendez des réponses d’erreur.

Remarque : Si `false`, les réponses d’erreur sont considérées comme réussies et la requête ne sera pas réessayée.

##### onDownloadProgress

Type : `Function`

Gestionnaire d’événement de progression du téléchargement.

La fonction reçoit les arguments suivants :
- `progress` est un objet avec les propriétés suivantes :
- - `percent` est un nombre entre 0 et 1 représentant le pourcentage de progression.
- - `transferredBytes` est le nombre d’octets transférés jusqu’à présent.
- - `totalBytes` est le nombre total d’octets à transférer. Il s’agit d’une estimation et peut être 0 si la taille totale ne peut pas être déterminée.
- `chunk` est une instance de `Uint8Array` contenant les données envoyées. Remarque : Elle est vide lors du premier appel.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Exemple d’affichage :
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Type : `Function`
Gestionnaire d'événement de progression de l’envoi.

La fonction reçoit les arguments suivants :
- `progress` est un objet avec les propriétés suivantes :
- - `percent` est un nombre compris entre 0 et 1 représentant le pourcentage de progression.
- - `transferredBytes` est le nombre d’octets transférés jusqu’à présent.
- - `totalBytes` est le nombre total d’octets à transférer. Il s’agit d’une estimation et il peut être égal à 0 si la taille totale ne peut pas être déterminée.
- `chunk` est une instance de `Uint8Array` contenant les données qui ont été envoyées. Remarque : Il est vide lors du dernier appel.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Exemple de sortie :
		// `0% - 0 sur 1271 octets`
		// `100% - 1271 sur 1271 octets`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} sur ${progress.totalBytes} octets`);
	}
});
```

##### parseJson

Type : `Function`\
Par défaut : `JSON.parse()`

Fonction de parsing JSON définie par l’utilisateur.

Cas d’utilisation :
1. Parser le JSON via le paquet [`bourne`](https://github.com/hapijs/bourne) pour se protéger contre la pollution du prototype.
2. Parser le JSON avec l’option [`reviver` de `JSON.parse()`](https://developer.mozilla.org/fr/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Type : `Function`\
Par défaut : `JSON.stringify()`

Fonction de transformation JSON en chaîne définie par l’utilisateur.

Cas d’utilisation :
1. Transformer le JSON avec une fonction `replacer` personnalisée.

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

Type : `Function`\
Par défaut : `fetch`

Fonction `fetch` définie par l’utilisateur.
Doit être entièrement compatible avec le standard [Fetch API](https://developer.mozilla.org/fr/docs/Web/API/Fetch_API).

Cas d’utilisation :
1. Utiliser des implémentations personnalisées de `fetch` comme [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Utiliser la fonction wrapper `fetch` fournie par certains frameworks qui utilisent le rendu côté serveur (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Crée une nouvelle instance de `ky` avec certains paramètres par défaut remplacés par les vôtres.

Contrairement à `ky.create()`, `ky.extend()` hérite des valeurs par défaut de son parent.

Vous pouvez passer les en-têtes comme une instance de `Headers` ou comme un objet classique.

Vous pouvez supprimer un en-tête avec `.extend()` en passant l’en-tête avec une valeur `undefined`.
Passer `undefined` sous forme de chaîne supprime l’en-tête uniquement s’il provient d’une instance `Headers`.

De même, vous pouvez supprimer des entrées de `hooks` existantes en étendant le hook avec un `undefined` explicite.

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

Vous pouvez également référencer les valeurs par défaut du parent en fournissant une fonction à `.extend()`.

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

Crée une nouvelle instance Ky avec de nouveaux paramètres par défaut.

```js
import ky from 'ky';

// Sur https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Type : `object`

### ky.stop

Un `Symbol` qui peut être retourné par un hook `beforeRetry` pour arrêter la nouvelle tentative. Cela court-circuite également les hooks `beforeRetry` restants.

Remarque : Retourner ce symbole fait que Ky s’arrête et retourne une réponse `undefined`. Assurez-vous de vérifier la présence d’une réponse avant d’accéder à ses propriétés ou utilisez le [chaînage optionnel](https://developer.mozilla.org/fr/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Il est également incompatible avec les méthodes de corps, telles que `.json()` ou `.text()`, car il n’y a pas de réponse à analyser. En général, nous recommandons de lever une erreur plutôt que de retourner ce symbole, car cela fera que Ky s’arrêtera puis lèvera une exception, ce qui évite ces limitations.

Un cas d’utilisation valide pour `ky.stop` est d’empêcher les nouvelles tentatives lors de requêtes à effet de bord, lorsque les données retournées ne sont pas importantes. Par exemple, la journalisation de l’activité client vers le serveur.

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
// Notez que la réponse sera `undefined` dans le cas où `ky.stop` est retourné.
const response = await ky.post('https://example.com', options);

// L'utilisation de `.text()` ou d'autres méthodes de corps n'est pas prise en charge.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Exposé pour les vérifications `instanceof`. L'erreur possède une propriété `response` avec l'objet [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), une propriété `request` avec l'objet [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), et une propriété `options` avec les options normalisées (soit passées à `ky` lors de la création d'une instance avec `ky.create()`, soit directement lors de l'exécution de la requête).

Sachez que certains types d'erreurs, comme les erreurs réseau, impliquent intrinsèquement qu'aucune réponse n'a été reçue. Dans ce cas, l'erreur ne sera pas une instance de HTTPError et ne contiendra pas de propriété `response`.

Si vous avez besoin de lire la réponse réelle lorsqu'une `HTTPError` s'est produite, appelez la méthode d'analyseur respective sur l'objet response. Par exemple :

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript :** Accepte un [paramètre de type](https://www.typescriptlang.org/docs/handbook/2/generics.html) optionnel, qui par défaut est [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), et est transmis au type de retour de `error.response.json()`.

### TimeoutError

L'erreur levée lorsque la requête expire. Elle possède une propriété `request` avec l'objet [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Conseils

### Envoi de données de formulaire

L'envoi de données de formulaire dans Ky est identique à `fetch`. Il suffit de passer une instance [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) à l'option `body`. L'en-tête `Content-Type` sera automatiquement défini sur `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Si vous souhaitez envoyer les données au format `application/x-www-form-urlencoded`, vous devrez encoder les données avec [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Définir un `Content-Type` personnalisé

Ky définit automatiquement un en-tête [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) approprié pour chaque requête en fonction des données dans le corps de la requête. Cependant, certaines API nécessitent des types de contenu personnalisés ou non standards, comme `application/x-amz-json-1.1`. À l'aide de l'option `headers`, vous pouvez remplacer manuellement le type de contenu.

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

### Annulation

Fetch (et donc Ky) prend en charge nativement l'annulation de requête via l'API [`AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [En savoir plus.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Exemple :

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
		console.log('Fetch annulé');
	} else {
		console.error('Erreur fetch :', error);
	}
}
```

## FAQ

#### Comment utiliser ceci dans Node.js ?

Node.js 18 et versions ultérieures prennent en charge `fetch` nativement, vous pouvez donc utiliser ce package directement.

#### Comment utiliser ceci avec une application web (React, Vue.js, etc.) qui utilise le rendu côté serveur (SSR) ?

Comme ci-dessus.

#### Comment tester une bibliothèque navigateur qui utilise ceci ?

Utilisez soit un lanceur de tests qui peut s'exécuter dans le navigateur, comme Mocha, soit [AVA](https://avajs.dev) avec `ky-universal`. [En savoir plus.](https://github.com/sindresorhus/ky-universal#faq)

#### Comment utiliser ceci sans un bundler comme Webpack ?

Assurez-vous que votre code s'exécute en tant que module JavaScript (ESM), par exemple en utilisant une balise `<script type="module">` dans votre document HTML. Ky peut alors être importé directement par ce module sans bundler ni autres outils.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### En quoi est-ce différent de [`got`](https://github.com/sindresorhus/got)

Voir ma réponse [ici](https://twitter.com/sindresorhus/status/1037406558945042432). Got est maintenu par les mêmes personnes que Ky.

#### En quoi est-ce différent de [`axios`](https://github.com/axios/axios) ?

Voir ma réponse [ici](https://twitter.com/sindresorhus/status/1037763588826398720).

#### En quoi est-ce différent de [`r2`](https://github.com/mikeal/r2) ?

Voir ma réponse dans [#10](https://github.com/sindresorhus/ky/issues/10).

#### Que signifie `ky` ?

C'est juste un nom de package npm court et aléatoire que j'ai réussi à obtenir. Cependant, il a une signification en japonais :

> Une forme d'argot textuel, KY est une abréviation de 空気読めない (kuuki yomenai), qui se traduit littéralement par « ne peut pas lire l'air ». C'est une expression appliquée à quelqu'un qui manque le sens implicite.

## Compatibilité navigateur

La dernière version de Chrome, Firefox et Safari.

## Compatibilité Node.js

Node.js 18 et versions ultérieures.

## Liens connexes

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Utilitaires pratiques pour travailler avec Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Hooks Ky pour modifier les cas sur les requêtes et réponses des objets

## Mainteneurs

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---