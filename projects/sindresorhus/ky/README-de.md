<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky ist ein kleines und elegantes HTTP-Client auf Basis der [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky richtet sich an [moderne Browser](#browser-support), Node.js, Bun und Deno.

Es ist einfach ein kleines Paket ohne Abhängigkeiten.

## Vorteile gegenüber einfachem `fetch`

- Einfachere API
- Methoden-Kurzbefehle (`ky.post()`)
- Behandelt Statuscodes außerhalb von 2xx als Fehler (nach Weiterleitungen)
- Wiederholt fehlgeschlagene Anfragen
- JSON-Option
- Timeout-Unterstützung
- URL-Präfix-Option
- Instanzen mit benutzerdefinierten Standardwerten
- Hooks
- TypeScript-Annehmlichkeiten (z. B. `.json()` unterstützt Generics und verwendet standardmäßig `unknown` statt `any`)

## Installation

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Verwendung

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Mit einfachem `fetch` sähe das so aus:

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

Wenn du [Deno](https://github.com/denoland/deno) verwendest, importiere Ky von einer URL. Zum Beispiel mit einem CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

Die `input` und `options` sind die gleichen wie bei [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), mit zusätzlichen verfügbaren `options` (siehe unten).

Gibt ein [`Response`-Objekt](https://developer.mozilla.org/en-US/docs/Web/API/Response) mit hinzugefügten [`Body`-Methoden](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) für den Komfort zurück. So kannst du zum Beispiel direkt `ky.get(input).json()` aufrufen, ohne vorher auf die `Response` zu warten. In diesem Fall wird je nach verwendeter Body-Methode ein entsprechender `Accept`-Header gesetzt. Anders als bei den `Body`-Methoden von `window.Fetch` werfen diese eine `HTTPError`, wenn der Antwortstatus nicht im Bereich von `200...299` liegt. Außerdem gibt `.json()` einen leeren String zurück, wenn der Body leer ist oder der Antwortstatus `204` ist, anstatt wegen eines leeren Bodys einen Parsing-Fehler zu werfen.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Akzeptiert einen optionalen [Type Parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html), der standardmäßig auf [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) gesetzt ist und an den Rückgabetyp von `.json()` weitergegeben wird.

```ts
import ky from 'ky';

// user1 ist unknown
const user1 = await ky('/api/users/1').json();
// user2 ist ein User
const user2 = await ky<User>('/api/users/2').json();
// user3 ist ein User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Setzt `options.method` auf den Methodennamen und führt eine Anfrage aus.

⌨️ **TypeScript:** Akzeptiert einen optionalen Type Parameter für die Verwendung mit JSON-Antworten (siehe [`ky()`](#kyinput-options)).

#### input

Typ: `string` | `URL` | `Request`

Wie [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Wenn eine [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request)-Instanz als `input` verwendet wird, werden alle URL-verändernden Optionen (wie `prefixUrl`) ignoriert.

#### options

Typ: `object`

Wie [`fetch` options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), plus folgende zusätzliche Optionen:

##### method

Typ: `string`\
Standard: `'get'`

HTTP-Methode, die für die Anfrage verwendet wird.

Intern werden die Standardmethoden (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` und `DELETE`) in Großbuchstaben umgewandelt, um Serverfehler aufgrund von Groß-/Kleinschreibung zu vermeiden.

##### json

Typ: `object` und jeder andere Wert, der von [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) akzeptiert wird

Kurzschreibweise zum Senden von JSON. Verwende dies anstelle der `body`-Option. Akzeptiert jedes einfache Objekt oder jeden Wert, der mit `JSON.stringify()` serialisiert und mit gesetztem korrektem Header im Body gesendet wird.

##### searchParams

Typ: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Standard: `''`

Suchparameter, die in die Anfrage-URL aufgenommen werden. Wenn gesetzt, werden alle bestehenden Suchparameter in der Eingabe-URL überschrieben.

Akzeptiert jeden Wert, der von [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) unterstützt wird.

##### prefixUrl

Typ: `string | URL`

Ein Präfix, das der `input`-URL bei der Anfrage vorangestellt wird. Kann jede gültige URL sein, entweder relativ oder absolut. Ein abschließender Slash `/` ist optional und wird bei Bedarf automatisch hinzugefügt, wenn sie mit `input` verbunden wird. Wirkt nur, wenn `input` ein String ist. Das `input`-Argument darf bei Verwendung dieser Option nicht mit einem Slash `/` beginnen.

Nützlich in Verbindung mit [`ky.extend()`](#kyextenddefaultoptions), um Ky-Instanzen für spezielle Anwendungsfälle zu erstellen.

```js
import ky from 'ky';

// Auf https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Hinweise:
 - Nachdem `prefixUrl` und `input` verbunden wurden, wird das Ergebnis relativ zur [Basis-URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) der Seite (falls vorhanden) aufgelöst.
 - Führende Slashes in `input` sind bei Verwendung dieser Option nicht erlaubt, um Konsistenz zu erzwingen und Verwirrung darüber zu vermeiden, wie die `input`-URL behandelt wird, da `input` nicht den normalen URL-Auflösungsregeln folgt, wenn `prefixUrl` verwendet wird, was die Bedeutung eines führenden Slashes verändert.

##### retry

Typ: `object | number`\
Standard:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Ein Objekt, das die Felder `limit`, `methods`, `statusCodes`, `afterStatusCodes` und `maxRetryAfter` für die maximale Anzahl der Wiederholungsversuche, erlaubte Methoden, erlaubte Statuscodes, Statuscodes, bei denen die [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-Zeit verwendet werden darf, und maximale [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-Zeit repräsentiert.

Wenn `retry` eine Zahl ist, wird sie als `limit` verwendet und andere Standardwerte bleiben erhalten.

Wenn die Antwort einen HTTP-Status enthält, der in `afterStatusCodes` enthalten ist, wartet Ky, bis das im [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-Header angegebene Datum, der Timeout oder der Zeitstempel erreicht ist, bevor die Anfrage erneut gesendet wird. Fehlt `Retry-After`, wird der nicht standardisierte [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3)-Header als Fallback verwendet. Ist der bereitgestellte Statuscode nicht in der Liste, wird der [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-Header ignoriert.

Wenn `maxRetryAfter` auf `undefined` gesetzt ist, wird `options.timeout` verwendet. Ist der Wert des [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)-Headers größer als `maxRetryAfter`, wird `maxRetryAfter` verwendet.

Die Option `backoffLimit` ist das obere Limit für die Verzögerung pro Wiederholungsversuch in Millisekunden.
Um die Verzögerung zu begrenzen, setzen Sie zum Beispiel `backoffLimit` auf 1000.
Standardmäßig wird die Verzögerung mit `0.3 * (2 ** (attemptCount - 1)) * 1000` berechnet. Die Verzögerung steigt exponentiell an.

Die Option `delay` kann verwendet werden, um zu ändern, wie die Verzögerung zwischen Wiederholungsversuchen berechnet wird. Die Funktion erhält einen Parameter, den Versuchszähler, der bei `1` beginnt.

Wiederholungsversuche werden nach einem [Timeout](#timeout) nicht ausgelöst.

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

Typ: `number | false`\
Standard: `10000`

Timeout in Millisekunden für den Erhalt einer Antwort, einschließlich aller Wiederholungsversuche. Kann nicht größer als 2147483647 sein.
Wenn auf `false` gesetzt, gibt es keinen Timeout.

##### hooks

Typ: `object<string, Function[]>`\
Standard: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks ermöglichen Modifikationen während des Anfrage-Lebenszyklus. Hook-Funktionen können asynchron sein und werden seriell ausgeführt.

###### hooks.beforeRequest

Typ: `Function[]`\
Standard: `[]`

Mit diesem Hook können Sie die Anfrage direkt vor dem Absenden ändern. Ky nimmt danach keine weiteren Änderungen an der Anfrage vor. Die Hook-Funktion erhält `request` und `options` als Argumente. Sie könnten hier zum Beispiel die `request.headers` ändern.

Der Hook kann ein [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request)-Objekt zurückgeben, um die ausgehende Anfrage zu ersetzen, oder eine [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) zurückgeben, um das Absenden einer HTTP-Anfrage vollständig zu vermeiden. Dies kann genutzt werden, um eine Anfrage zu simulieren, einen internen Cache zu prüfen usw. Eine **wichtige** Überlegung beim Zurückgeben einer Anfrage oder Antwort aus diesem Hook ist, dass alle verbleibenden `beforeRequest`-Hooks übersprungen werden. Sie sollten sie also nur vom letzten Hook zurückgeben.

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

Typ: `Function[]`\
Standard: `[]`

Mit diesem Hook können Sie die Anfrage direkt vor dem Wiederholungsversuch ändern. Ky nimmt danach keine weiteren Änderungen an der Anfrage vor. Die Hook-Funktion erhält ein Objekt mit der normalisierten Anfrage und den Optionen, eine Fehlerinstanz sowie die Anzahl der Wiederholungen. Sie können hier zum Beispiel die `request.headers` ändern.

Wenn die Anfrage eine Antwort erhalten hat, ist der Fehler vom Typ `HTTPError` und das `Response`-Objekt ist unter `error.response` verfügbar. Beachten Sie, dass einige Fehlertypen, wie z. B. Netzwerkfehler, implizieren, dass keine Antwort erhalten wurde. In diesem Fall ist der Fehler keine Instanz von `HTTPError`.

Sie können verhindern, dass Ky die Anfrage wiederholt, indem Sie einen Fehler auslösen. Ky behandelt diesen Fehler nicht weiter und er wird an den Anfragestarter weitergegeben. Die restlichen `beforeRetry`-Hooks werden in diesem Fall nicht mehr aufgerufen. Alternativ können Sie das Symbol [`ky.stop`](#kystop) zurückgeben, um dasselbe zu erreichen, jedoch ohne einen Fehler weiterzugeben (dies hat einige Einschränkungen, siehe die Dokumentation zu `ky.stop` für Details).

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

Typ: `Function[]`\
Standard: `[]`

Mit diesem Hook können Sie den `HTTPError` direkt vor dem Auslösen ändern. Die Hook-Funktion erhält einen `HTTPError` als Argument und sollte eine Instanz von `HTTPError` zurückgeben.

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

Typ: `Function[]`\
Standard: `[]`

Mit diesem Hook können Sie die Antwort lesen und optional ändern. Die Hook-Funktion erhält die normalisierte Anfrage, Optionen und einen Klon der Antwort als Argumente. Der Rückgabewert der Hook-Funktion wird von Ky als Antwortobjekt verwendet, wenn es sich um eine Instanz von [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) handelt.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Sie könnten hier etwas mit der Antwort machen, z. B. Logging.
				log(response);

				// Oder eine `Response`-Instanz zurückgeben, um die Antwort zu überschreiben.
				return new Response('A different response', {status: 200});
			},

			// Oder bei einem 403-Fehler mit einem neuen Token erneut versuchen
			async (request, options, response) => {
				if (response.status === 403) {
					// Neues Token holen
					const token = await ky('https://example.com/token').text();

					// Mit Token erneut versuchen
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Typ: `boolean`\
Standard: `true`

Löst einen `HTTPError` aus, wenn nach dem Folgen von Weiterleitungen die Antwort keinen 2xx-Statuscode hat. Um auch bei Weiterleitungen einen Fehler auszulösen, anstatt ihnen zu folgen, setzen Sie die Option [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) auf `'manual'`.

Das Setzen auf `false` kann nützlich sein, wenn Sie die Verfügbarkeit einer Ressource prüfen und Fehlerantworten erwarten.

Hinweis: Wenn `false`, werden Fehlerantworten als erfolgreich betrachtet und die Anfrage wird nicht wiederholt.

##### onDownloadProgress

Typ: `Function`

Event-Handler für den Download-Fortschritt.

Die Funktion erhält folgende Argumente:
- `progress` ist ein Objekt mit diesen Eigenschaften:
- - `percent` ist eine Zahl zwischen 0 und 1 und repräsentiert den Fortschritt in Prozent.
- - `transferredBytes` ist die Anzahl der bisher übertragenen Bytes.
- - `totalBytes` ist die Gesamtanzahl der zu übertragenden Bytes. Dies ist ein Schätzwert und kann 0 sein, wenn die Gesamtgröße nicht bestimmt werden kann.
- `chunk` ist eine Instanz von `Uint8Array`, die die gesendeten Daten enthält. Hinweis: Beim ersten Aufruf ist sie leer.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Beispielausgabe:
		// `0% - 0 von 1271 Bytes`
		// `100% - 1271 von 1271 Bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} von ${progress.totalBytes} Bytes`);
	}
});
```

##### onUploadProgress

Typ: `Function`

Upload-Fortschritts-Ereignis-Handler.

Die Funktion erhält folgende Argumente:
- `progress` ist ein Objekt mit diesen Eigenschaften:
- - `percent` ist eine Zahl zwischen 0 und 1, die den Fortschrittsprozentsatz darstellt.
- - `transferredBytes` ist die Anzahl der bisher übertragenen Bytes.
- - `totalBytes` ist die Gesamtzahl der zu übertragenden Bytes. Dies ist ein Schätzwert und kann 0 sein, wenn die Gesamtgröße nicht bestimmt werden kann.
- `chunk` ist eine Instanz von `Uint8Array`, die die gesendeten Daten enthält. Hinweis: Beim letzten Aufruf ist sie leer.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Beispielausgabe:
		// `0% - 0 von 1271 Bytes`
		// `100% - 1271 von 1271 Bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} von ${progress.totalBytes} Bytes`);
	}
});
```

##### parseJson

Typ: `Function`\
Standard: `JSON.parse()`

Benutzerdefinierte JSON-Parsing-Funktion.

Anwendungsfälle:
1. JSON über das [`bourne`-Paket](https://github.com/hapijs/bourne) parsen, um sich vor Prototype Pollution zu schützen.
2. JSON mit der [`reviver`-Option von `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) parsen.

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Typ: `Function`\
Standard: `JSON.stringify()`

Benutzerdefinierte JSON-Stringify-Funktion.

Anwendungsfälle:
1. JSON mit einer benutzerdefinierten `replacer`-Funktion serialisieren.

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

Typ: `Function`\
Standard: `fetch`

Benutzerdefinierte `fetch`-Funktion.
Muss vollständig mit dem [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API)-Standard kompatibel sein.

Anwendungsfälle:
1. Verwendung von benutzerdefinierten `fetch`-Implementierungen wie [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Verwendung der von einigen Frameworks bereitgestellten `fetch`-Wrapper-Funktion, die serverseitiges Rendering (SSR) nutzen.

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Erstellt eine neue `ky`-Instanz mit einigen durch eigene Werte überschriebenen Standardwerten.

Im Gegensatz zu `ky.create()` erbt `ky.extend()` die Standardwerte vom Elternteil.

Du kannst Header als `Headers`-Instanz oder als einfaches Objekt übergeben.

Du kannst einen Header mit `.extend()` entfernen, indem du den Header mit dem Wert `undefined` übergibst.
Das Übergeben von `undefined` als String entfernt den Header nur, wenn er aus einer `Headers`-Instanz stammt.

Ebenso kannst du bestehende `hooks`-Einträge entfernen, indem du den Hook explizit mit `undefined` überschreibst.

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

Du kannst auch auf Elterndefaults verweisen, indem du eine Funktion an `.extend()` übergibst.

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

Erstellt eine neue Ky-Instanz mit komplett neuen Standardwerten.

```js
import ky from 'ky';

// Auf https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Typ: `object`

### ky.stop

Ein `Symbol`, das von einem `beforeRetry`-Hook zurückgegeben werden kann, um das erneute Versuchen zu stoppen. Dies beendet auch die verbleibenden `beforeRetry`-Hooks.

Hinweis: Wenn dieses Symbol zurückgegeben wird, bricht Ky ab und gibt eine `undefined`-Antwort zurück. Stelle sicher, dass du auf eine Antwort prüfst, bevor du auf deren Eigenschaften zugreifst, oder verwende [optionale Verkettung](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Es ist auch nicht kompatibel mit Body-Methoden wie `.json()` oder `.text()`, da keine Antwort zum Parsen vorhanden ist. Generell empfehlen wir, stattdessen einen Fehler auszulösen, da Ky dann abbricht und eine Ausnahme wirft, was diese Einschränkungen vermeidet.

Ein sinnvoller Anwendungsfall für `ky.stop` ist das Verhindern von Wiederholungsversuchen bei Anfragen, die Nebenwirkungen haben, bei denen die zurückgegebenen Daten nicht wichtig sind. Zum Beispiel, um Client-Aktivitäten an den Server zu protokollieren.

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
```markdown
// Beachten Sie, dass die Antwort `undefined` ist, falls `ky.stop` zurückgegeben wird.
const response = await ky.post('https://example.com', options);

// Die Verwendung von `.text()` oder anderen Body-Methoden wird nicht unterstützt.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Wird für `instanceof`-Prüfungen offengelegt. Der Fehler besitzt eine `response`-Eigenschaft mit dem [`Response`-Objekt](https://developer.mozilla.org/en-US/docs/Web/API/Response), eine `request`-Eigenschaft mit dem [`Request`-Objekt](https://developer.mozilla.org/en-US/docs/Web/API/Request) und eine `options`-Eigenschaft mit normalisierten Optionen (entweder an `ky` beim Erstellen einer Instanz mit `ky.create()` übergeben oder direkt beim Ausführen der Anfrage).

Beachten Sie, dass einige Fehlertypen, wie Netzwerkfehler, grundsätzlich bedeuten, dass keine Antwort empfangen wurde. In diesem Fall ist der Fehler keine Instanz von HTTPError und enthält keine `response`-Eigenschaft.

Wenn Sie die tatsächliche Antwort lesen müssen, wenn ein `HTTPError` aufgetreten ist, rufen Sie die entsprechende Parser-Methode für das Response-Objekt auf. Zum Beispiel:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Akzeptiert einen optionalen [Typparameter](https://www.typescriptlang.org/docs/handbook/2/generics.html), der standardmäßig auf [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) gesetzt ist und an den Rückgabetyp von `error.response.json()` weitergegeben wird.

### TimeoutError

Der Fehler, der ausgelöst wird, wenn die Anfrage abläuft. Er enthält eine `request`-Eigenschaft mit dem [`Request`-Objekt](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Tipps

### Senden von Formulardaten

Das Senden von Formulardaten in Ky ist identisch zu `fetch`. Übergeben Sie einfach eine [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData)-Instanz an die Option `body`. Der `Content-Type`-Header wird automatisch auf `multipart/form-data` gesetzt.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Wenn Sie die Daten im Format `application/x-www-form-urlencoded` senden möchten, müssen Sie die Daten mit [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) kodieren.

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Setzen eines eigenen `Content-Type`

Ky setzt für jede Anfrage automatisch einen passenden [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type)-Header basierend auf den Daten im Request-Body. Einige APIs erfordern jedoch benutzerdefinierte, nicht standardisierte Content-Types, wie zum Beispiel `application/x-amz-json-1.1`. Über die Option `headers` können Sie den Content-Type manuell überschreiben.

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

### Abbrechen

Fetch (und damit auch Ky) unterstützt das Abbrechen von Requests nativ über die [`AbortController`-API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Mehr dazu.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Beispiel:

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
		console.log('Fetch abgebrochen');
	} else {
		console.error('Fetch-Fehler:', error);
	}
}
```

## FAQ

#### Wie verwende ich dies in Node.js?

Node.js 18 und neuer unterstützt `fetch` nativ, Sie können dieses Paket also direkt verwenden.

#### Wie verwende ich dies mit einer Web-App (React, Vue.js, etc.), die Server-Side-Rendering (SSR) nutzt?

Genauso wie oben beschrieben.

#### Wie teste ich eine Browser-Bibliothek, die dies nutzt?

Verwenden Sie entweder einen Testrunner, der im Browser läuft, wie Mocha, oder nutzen Sie [AVA](https://avajs.dev) mit `ky-universal`. [Mehr dazu.](https://github.com/sindresorhus/ky-universal#faq)

#### Wie verwende ich dies ohne einen Bundler wie Webpack?

Stellen Sie sicher, dass Ihr Code als JavaScript-Modul (ESM) ausgeführt wird, zum Beispiel durch die Verwendung eines `<script type="module">`-Tags in Ihrem HTML-Dokument. Dann kann Ky direkt von diesem Modul ohne Bundler oder andere Tools importiert werden.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Wie unterscheidet es sich von [`got`](https://github.com/sindresorhus/got)

Siehe meine Antwort [hier](https://twitter.com/sindresorhus/status/1037406558945042432). Got wird von den gleichen Personen wie Ky gepflegt.

#### Wie unterscheidet es sich von [`axios`](https://github.com/axios/axios)?

Siehe meine Antwort [hier](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Wie unterscheidet es sich von [`r2`](https://github.com/mikeal/r2)?

Siehe meine Antwort in [#10](https://github.com/sindresorhus/ky/issues/10).

#### Was bedeutet `ky`?

Es ist einfach ein zufällig kurzer npm-Paketname, den ich bekommen konnte. Allerdings hat es im Japanischen eine Bedeutung:

> Eine Form von textbarem Slang, KY ist eine Abkürzung für 空気読めない (kuuki yomenai), was wörtlich übersetzt „kann die Luft nicht lesen“ bedeutet. Es wird für Personen verwendet, die die implizite Bedeutung nicht erkennen.

## Browser-Support

Die jeweils aktuelle Version von Chrome, Firefox und Safari.

## Node.js-Support

Node.js 18 und neuer.

## Verwandtes

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) – Nützliche Hilfsmittel für die Arbeit mit Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) – Ky-Hooks zur Modifikation von Schreibweisen bei Requests und Responses von Objekten

## Maintainer

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---