<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky is een kleine en elegante HTTP-client gebaseerd op de [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky richt zich op [moderne browsers](#browser-support), Node.js, Bun en Deno.

Het is slechts een klein pakketje zonder afhankelijkheden.

## Voordelen ten opzichte van gewone `fetch`

- Eenvoudigere API
- Methode-shortcuts (`ky.post()`)
- Behandelt niet-2xx statuscodes als fouten (na redirects)
- Probeert mislukte verzoeken opnieuw
- JSON-optie
- Ondersteuning voor time-outs
- URL-voorvoegsel optie
- Instanties met aangepaste standaardinstellingen
- Hooks
- TypeScript-voordelen (bijv. `.json()` ondersteunt generics en standaard op `unknown`, niet `any`)

## Installeren

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Gebruik

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Met gewone `fetch` zou dit zijn:

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

Als je [Deno](https://github.com/denoland/deno) gebruikt, importeer Ky dan vanaf een URL. Bijvoorbeeld, via een CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

De `input` en `options` zijn hetzelfde als bij [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), met extra beschikbare `options` (zie hieronder).

Geeft een [`Response` object](https://developer.mozilla.org/en-US/docs/Web/API/Response) terug met [`Body` methoden](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) toegevoegd voor gemak. Je kunt dus bijvoorbeeld direct `ky.get(input).json()` aanroepen zonder eerst de `Response` te hoeven afwachten. Wanneer je dat zo aanroept, wordt er afhankelijk van de gebruikte body-methode een geschikte `Accept`-header gezet. In tegenstelling tot de `Body`-methoden van `window.Fetch`, zullen deze een `HTTPError` gooien als de response status niet in het bereik van `200...299` valt. Ook zal `.json()` een lege string retourneren als de body leeg is of de response status `204` is, in plaats van een parse-fout te gooien wegens een lege body.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Accepteert een optionele [typeparameter](https://www.typescriptlang.org/docs/handbook/2/generics.html), die standaard [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) is, en wordt doorgegeven aan het returntype van `.json()`.

```ts
import ky from 'ky';

// user1 is unknown
const user1 = await ky('/api/users/1').json();
// user2 is een User
const user2 = await ky<User>('/api/users/2').json();
// user3 is een User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Stelt `options.method` in op de methodenaam en voert een verzoek uit.

⌨️ **TypeScript:** Accepteert een optionele typeparameter voor gebruik met JSON-responses (zie [`ky()`](#kyinput-options)).

#### input

Type: `string` | `URL` | `Request`

Hetzelfde als [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Wanneer je een [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) instantie als `input` gebruikt, worden alle URL-aanpassende opties (zoals `prefixUrl`) genegeerd.

#### options

Type: `object`

Hetzelfde als [`fetch` options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), plus de volgende extra opties:

##### method

Type: `string`\
Standaard: `'get'`

HTTP-methode die wordt gebruikt om het verzoek te doen.

Intern worden de standaardmethoden (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` en `DELETE`) in hoofdletters omgezet om serverfouten door hoofdlettergevoeligheid te voorkomen.

##### json

Type: `object` en elke andere waarde die wordt geaccepteerd door [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Snelkoppeling voor het verzenden van JSON. Gebruik dit in plaats van de `body` optie. Accepteert elk gewoon object of waarde, die met `JSON.stringify()` wordt omgezet en met de juiste header in de body wordt verzonden.

##### searchParams

Type: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Standaard: `''`

Zoekparameters die in de request-URL moeten worden opgenomen. Als je dit instelt, overschrijft het alle bestaande zoekparameters in de input-URL.

Accepteert elke waarde die wordt ondersteund door [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Type: `string | URL`

Een voorvoegsel dat aan de `input`-URL wordt toegevoegd bij het uitvoeren van het verzoek. Dit kan elke geldige URL zijn, relatief of absoluut. Een afsluitende slash `/` is optioneel en wordt automatisch toegevoegd indien nodig, wanneer deze wordt samengevoegd met `input`. Heeft alleen effect als `input` een string is. Het `input`-argument mag niet beginnen met een slash `/` wanneer je deze optie gebruikt.

Handig in combinatie met [`ky.extend()`](#kyextenddefaultoptions) om specifieke Ky-instanties te maken.

```js
import ky from 'ky';

// Op https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Opmerkingen:
 - Nadat `prefixUrl` en `input` zijn samengevoegd, wordt het resultaat vergeleken met de [basis-URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) van de pagina (indien aanwezig).
 - Voorloopslashes in `input` zijn niet toegestaan bij gebruik van deze optie om consistentie te waarborgen en verwarring te voorkomen over hoe de `input`-URL wordt behandeld, aangezien `input` niet de normale URL-resolutieregels volgt wanneer `prefixUrl` wordt gebruikt, wat de betekenis van een voorloopslash verandert.

##### retry

Type: `object | number`\
Standaard:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`
Een object dat de velden `limit`, `methods`, `statusCodes`, `afterStatusCodes`, en `maxRetryAfter` vertegenwoordigt voor het maximaal aantal pogingen, toegestane methoden, toegestane statuscodes, statuscodes waarvoor de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-tijd gebruikt mag worden, en maximale [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-tijd.

Als `retry` een getal is, wordt dit gebruikt als `limit` en blijven de overige standaardwaarden gehandhaafd.

Als de respons een HTTP-status bevat die in `afterStatusCodes` staat, wacht Ky tot de datum, time-out of timestamp die is opgegeven in de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-header is verstreken voordat het verzoek opnieuw wordt geprobeerd. Als `Retry-After` ontbreekt, wordt de niet-standaard [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3)-header gebruikt als alternatief. Als de opgegeven statuscode niet in de lijst staat, wordt de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-header genegeerd.

Als `maxRetryAfter` is ingesteld op `undefined`, gebruikt het `options.timeout`. Als de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-header groter is dan `maxRetryAfter`, wordt `maxRetryAfter` gebruikt.

De `backoffLimit`-optie is de bovengrens voor de vertraging per poging in milliseconden.
Om de vertraging te beperken, stel je bijvoorbeeld `backoffLimit` in op 1000.
Standaard wordt de vertraging berekend met `0.3 * (2 ** (attemptCount - 1)) * 1000`. De vertraging neemt exponentieel toe.

Met de optie `delay` kun je aanpassen hoe de vertraging tussen pogingen wordt berekend. De functie ontvangt één parameter, het aantal pogingen, te beginnen bij `1`.

Opnieuw proberen wordt niet geactiveerd na een [timeout](#timeout).

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

Type: `number | false`\
Standaard: `10000`

Time-out in milliseconden voor het ontvangen van een respons, inclusief eventuele herhalingen. Kan niet groter zijn dan 2147483647.
Indien ingesteld op `false`, geldt er geen time-out.

##### hooks

Type: `object<string, Function[]>`\
Standaard: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks maken aanpassingen mogelijk tijdens de levenscyclus van het verzoek. Hook-functies mogen asynchroon zijn en worden serieel uitgevoerd.

###### hooks.beforeRequest

Type: `Function[]`\
Standaard: `[]`

Met deze hook kun je het verzoek aanpassen vlak voordat het wordt verzonden. Ky zal daarna geen verdere wijzigingen meer aanbrengen aan het verzoek. De hook-functie ontvangt `request` en `options` als argumenten. Je kunt hier bijvoorbeeld de `request.headers` aanpassen.

De hook kan een [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) retourneren om het uitgaande verzoek te vervangen, of een [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) retourneren om het HTTP-verzoek volledig over te slaan. Dit kan gebruikt worden om een verzoek te mocken, een interne cache te controleren, enzovoort. Een **belangrijke** overweging bij het retourneren van een request of response uit deze hook is dat resterende `beforeRequest`-hooks worden overgeslagen, dus je wilt deze mogelijk alleen uit de laatste hook retourneren.

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

Type: `Function[]`\
Standaard: `[]`

Met deze hook kun je het verzoek aanpassen vlak voor een herhaling. Ky zal daarna geen verdere wijzigingen meer aanbrengen aan het verzoek. De hook-functie ontvangt een object met het genormaliseerde verzoek en opties, een error-instantie en het aantal herhalingen. Je kunt hier bijvoorbeeld `request.headers` aanpassen.

Als het verzoek een respons heeft ontvangen, is de error van het type `HTTPError` en is het `Response`-object beschikbaar op `error.response`. Let op: sommige fouten, zoals netwerkfouten, betekenen per definitie dat er geen respons is ontvangen. In dat geval is de error geen instantie van `HTTPError`.

Je kunt voorkomen dat Ky het verzoek opnieuw probeert door een fout te gooien. Ky zal deze op geen enkele manier afhandelen en de fout wordt doorgegeven aan de initiator van het verzoek. De overige `beforeRetry`-hooks worden in dit geval niet aangeroepen. Je kunt ook het [`ky.stop`](#kystop)-symbool retourneren om hetzelfde te doen, maar dan zonder een fout door te geven (dit heeft enkele beperkingen, zie de documentatie van `ky.stop` voor details).

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

Type: `Function[]`\
Standaard: `[]`

Met deze hook kun je de `HTTPError` aanpassen vlak voordat deze wordt gegooid. De hook-functie ontvangt een `HTTPError` als argument en moet een instantie van `HTTPError` retourneren.

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

Type: `Function[]`\
Standaard: `[]`

Met deze hook kun je de response lezen en eventueel aanpassen. De hook-functie ontvangt het genormaliseerde verzoek, opties en een kloon van de response als argumenten. De returnwaarde van de hook-functie wordt door Ky als responsobject gebruikt als het een instantie is van [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Je kunt bijvoorbeeld iets doen met de response, bijvoorbeeld logging.
				log(response);

				// Of een `Response`-instantie retourneren om de response te overschrijven.
				return new Response('A different response', {status: 200});
			},

			// Of opnieuw proberen met een verse token bij een 403-fout
			async (request, options, response) => {
				if (response.status === 403) {
					// Verkrijg een nieuwe token
					const token = await ky('https://example.com/token').text();

					// Probeer opnieuw met de token
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Type: `boolean`\
Standaard: `true`

Gooi een `HTTPError` wanneer, na het volgen van redirects, de respons een niet-2xx statuscode heeft. Om ook te gooien bij redirects in plaats van deze te volgen, stel je de [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters)-optie in op `'manual'`.

Dit op `false` zetten kan nuttig zijn als je controleert op beschikbaarheid van een resource en foutresponsen verwacht.

Let op: Als `false`, worden foutresponsen als succesvol beschouwd en wordt het verzoek niet opnieuw geprobeerd.

##### onDownloadProgress

Type: `Function`

Event handler voor downloadvoortgang.

De functie ontvangt deze argumenten:
- `progress` is een object met de volgende eigenschappen:
- - `percent` is een getal tussen 0 en 1 dat het voortgangspercentage aangeeft.
- - `transferredBytes` is het aantal tot nu toe overgedragen bytes.
- - `totalBytes` is het totaal aantal bytes dat moet worden overgedragen. Dit is een schatting en kan 0 zijn als de totale grootte niet kan worden bepaald.
- `chunk` is een instantie van `Uint8Array` met de verzonden data. Let op: bij de eerste aanroep is deze leeg.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Voorbeeldoutput:
		// `0% - 0 van 1271 bytes`
		// `100% - 1271 van 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} van ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Type: `Function`
Upload voortgangsevenement handler.

De functie ontvangt deze argumenten:
- `progress` is een object met de volgende eigenschappen:
- - `percent` is een getal tussen 0 en 1 dat het voortgangspercentage weergeeft.
- - `transferredBytes` is het aantal bytes dat tot nu toe is overgedragen.
- - `totalBytes` is het totale aantal bytes dat overgedragen moet worden. Dit is een schatting en kan 0 zijn als de totale grootte niet kan worden bepaald.
- `chunk` is een instantie van `Uint8Array` die de verzonden gegevens bevat. Opmerking: deze is leeg bij de laatste aanroep.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Voorbeeld output:
		// `0% - 0 van 1271 bytes`
		// `100% - 1271 van 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} van ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

Type: `Function`\
Standaard: `JSON.parse()`

Door de gebruiker gedefinieerde JSON-parseringsfunctie.

Gebruikssituaties:
1. Parseer JSON via het [`bourne`-pakket](https://github.com/hapijs/bourne) om te beschermen tegen prototype-vervuiling.
2. Parseer JSON met de [`reviver` optie van `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Type: `Function`\
Standaard: `JSON.stringify()`

Door de gebruiker gedefinieerde JSON-stringifieringsfunctie.

Gebruikssituaties:
1. Stringify JSON met een aangepaste `replacer` functie.

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

Type: `Function`\
Standaard: `fetch`

Door de gebruiker gedefinieerde `fetch` functie.
Moet volledig compatibel zijn met de [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) standaard.

Gebruikssituaties:
1. Gebruik aangepaste `fetch` implementaties zoals [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Gebruik de `fetch` wrapperfunctie geleverd door sommige frameworks die server-side rendering (SSR) gebruiken.

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Maak een nieuwe `ky` instantie aan met enkele standaardinstellingen die zijn overschreven met je eigen instellingen.

In tegenstelling tot `ky.create()`, erft `ky.extend()` standaardwaarden van zijn ouder.

Je kunt headers doorgeven als een `Headers` instantie of als een gewoon object.

Je kunt een header verwijderen met `.extend()` door de header met een `undefined` waarde door te geven.
Als je `undefined` als string doorgeeft, wordt de header alleen verwijderd als deze uit een `Headers` instantie komt.

Op dezelfde manier kun je bestaande `hooks`-vermeldingen verwijderen door de hook uit te breiden met een expliciete `undefined`.

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

Je kunt ook verwijzen naar de ouderstandaarden door een functie aan `.extend()` te geven.

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

Maak een nieuwe Ky-instantie aan met volledig nieuwe standaardinstellingen.

```js
import ky from 'ky';

// Op https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Type: `object`

### ky.stop

Een `Symbol` dat kan worden geretourneerd door een `beforeRetry` hook om het opnieuw proberen te stoppen. Dit zal ook de resterende `beforeRetry` hooks kortsluiten.

Opmerking: Het retourneren van dit symbool zorgt ervoor dat Ky afbreekt en terugkeert met een `undefined` response. Zorg ervoor dat je controleert op een response voordat je eigenschappen ervan benadert of gebruik [optionele chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Het is ook niet compatibel met body-methoden, zoals `.json()` of `.text()`, omdat er geen response is om te parsen. In het algemeen raden we aan een fout te gooien in plaats van dit symbool te retourneren, omdat Ky dan zal afbreken en gooien, wat deze beperkingen voorkomt.

Een geldig gebruik van `ky.stop` is om te voorkomen dat verzoeken opnieuw worden geprobeerd wanneer je verzoeken doet voor neveneffecten, waarbij de geretourneerde gegevens niet belangrijk zijn. Bijvoorbeeld, het loggen van cliëntactiviteit naar de server.

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
// Merk op dat response `undefined` zal zijn in het geval dat `ky.stop` wordt geretourneerd.
const response = await ky.post('https://example.com', options);

// Het gebruik van `.text()` of andere body-methoden wordt niet ondersteund.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Blootgesteld voor `instanceof`-controles. De error heeft een `response`-eigenschap met het [`Response` object](https://developer.mozilla.org/en-US/docs/Web/API/Response), een `request`-eigenschap met het [`Request` object](https://developer.mozilla.org/en-US/docs/Web/API/Request), en een `options`-eigenschap met genormaliseerde opties (ofwel doorgegeven aan `ky` bij het aanmaken van een instantie met `ky.create()`, of direct bij het uitvoeren van het verzoek).

Wees ervan bewust dat sommige soorten fouten, zoals netwerkfouten, inherent betekenen dat er geen response is ontvangen. In dat geval zal de error geen instantie van HTTPError zijn en geen `response`-eigenschap bevatten.

Als je de daadwerkelijke response wilt lezen wanneer een `HTTPError` is opgetreden, roep dan de betreffende parser-methode aan op het response-object. Bijvoorbeeld:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Accepteert een optionele [typeparameter](https://www.typescriptlang.org/docs/handbook/2/generics.html), die standaard [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) is, en wordt doorgegeven aan het returntype van `error.response.json()`.

### TimeoutError

De error die wordt opgegooid wanneer het verzoek een timeout heeft. Het bevat een `request`-eigenschap met het [`Request` object](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Tips

### Verzenden van form data

Het verzenden van form data in Ky is identiek aan `fetch`. Geef gewoon een [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) instantie door aan de `body` optie. De `Content-Type` header wordt automatisch ingesteld op `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Als je de data in `application/x-www-form-urlencoded` formaat wilt verzenden, moet je de data encoderen met [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Instellen van een aangepaste `Content-Type`

Ky stelt automatisch een geschikte [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) header in voor elk verzoek op basis van de data in de request body. Sommige API's vereisen echter aangepaste, niet-standaard content types, zoals `application/x-amz-json-1.1`. Met de `headers` optie kun je het content type handmatig overschrijven.

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

### Annuleren

Fetch (en dus Ky) heeft ingebouwde ondersteuning voor het annuleren van verzoeken via de [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Lees meer.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Voorbeeld:

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
		console.log('Fetch afgebroken');
	} else {
		console.error('Fetch-fout:', error);
	}
}
```

## FAQ

#### Hoe gebruik ik dit in Node.js?

Node.js 18 en later ondersteunt `fetch` native, dus je kunt dit pakket direct gebruiken.

#### Hoe gebruik ik dit met een webapp (React, Vue.js, enz.) die server-side rendering (SSR) gebruikt?

Hetzelfde als hierboven.

#### Hoe test ik een browserbibliotheek die dit gebruikt?

Gebruik ofwel een testrunner die in de browser kan draaien, zoals Mocha, of gebruik [AVA](https://avajs.dev) met `ky-universal`. [Lees meer.](https://github.com/sindresorhus/ky-universal#faq)

#### Hoe gebruik ik dit zonder een bundler zoals Webpack?

Zorg ervoor dat je code wordt uitgevoerd als een JavaScript-module (ESM), bijvoorbeeld door een `<script type="module">`-tag te gebruiken in je HTML-document. Dan kan Ky direct door die module worden geïmporteerd zonder een bundler of andere tools.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Hoe verschilt het van [`got`](https://github.com/sindresorhus/got)

Zie mijn antwoord [hier](https://twitter.com/sindresorhus/status/1037406558945042432). Got wordt onderhouden door dezelfde mensen als Ky.

#### Hoe verschilt het van [`axios`](https://github.com/axios/axios)?

Zie mijn antwoord [hier](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Hoe verschilt het van [`r2`](https://github.com/mikeal/r2)?

Zie mijn antwoord in [#10](https://github.com/sindresorhus/ky/issues/10).

#### Wat betekent `ky`?

Het is gewoon een willekeurige, korte npm-pakketnaam die ik heb kunnen bemachtigen. Het heeft echter wel een betekenis in het Japans:

> Een vorm van tekstbare slang, KY is een afkorting voor 空気読めない (kuuki yomenai), wat letterlijk betekent “kan de sfeer niet lezen.” Het is een uitdrukking voor iemand die de impliciete betekenis mist.

## Browserondersteuning

De nieuwste versie van Chrome, Firefox en Safari.

## Node.js-ondersteuning

Node.js 18 en later.

## Gerelateerd

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Nuttige hulpmiddelen voor werken met Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Ky-hooks om hoofdlettergebruik te wijzigen bij requests en responses van objecten

## Onderhouders

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---