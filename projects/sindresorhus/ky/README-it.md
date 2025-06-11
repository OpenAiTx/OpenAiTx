<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky è un client HTTP piccolo ed elegante basato su [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky è progettato per [browser moderni](#browser-support), Node.js, Bun e Deno.

È solo un piccolo pacchetto senza dipendenze.

## Vantaggi rispetto a `fetch` puro

- API più semplice
- Scorciatoie per i metodi (`ky.post()`)
- Tratta i codici di stato non-2xx come errori (dopo i redirect)
- Ritenta le richieste fallite
- Opzione JSON
- Supporto timeout
- Opzione prefisso URL
- Istanza con impostazioni predefinite personalizzate
- Hook
- Funzionalità TypeScript (ad es. `.json()` supporta generics e predefinito su `unknown`, non su `any`)

## Installazione

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Utilizzo

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Con `fetch` puro, sarebbe:

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

Se stai usando [Deno](https://github.com/denoland/deno), importa Ky da un URL. Ad esempio, usando un CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` e `options` sono gli stessi di [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), con opzioni aggiuntive disponibili (vedi sotto).

Restituisce un [`oggetto Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) con i [metodi `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) aggiunti per comodità. Quindi puoi, ad esempio, chiamare direttamente `ky.get(input).json()` senza dover prima attendere la `Response`. Quando chiamato in questo modo, verrà impostata un'intestazione `Accept` appropriata a seconda del metodo body utilizzato. A differenza dei metodi `Body` di `window.Fetch`, questi genereranno un `HTTPError` se lo stato della risposta non è compreso nell'intervallo `200...299`. Inoltre, `.json()` restituirà una stringa vuota se il body è vuoto o lo stato della risposta è `204` invece di generare un errore di parsing a causa di un body vuoto.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Accetta un [parametro di tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opzionale, che per impostazione predefinita è [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), e viene passato al tipo restituito di `.json()`.

```ts
import ky from 'ky';

// user1 è unknown
const user1 = await ky('/api/users/1').json();
// user2 è di tipo User
const user2 = await ky<User>('/api/users/2').json();
// user3 è di tipo User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Imposta `options.method` con il nome del metodo ed effettua una richiesta.

⌨️ **TypeScript:** Accetta un parametro di tipo opzionale da usare con le risposte JSON (vedi [`ky()`](#kyinput-options)).

#### input

Tipo: `string` | `URL` | `Request`

Uguale all'[`input` di fetch](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Quando si utilizza un'istanza [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) come `input`, qualsiasi opzione che altera l'URL (come `prefixUrl`) verrà ignorata.

#### options

Tipo: `object`

Uguale alle [opzioni di `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), più le seguenti opzioni aggiuntive:

##### method

Tipo: `string`\
Predefinito: `'get'`

Metodo HTTP utilizzato per effettuare la richiesta.

Internamente, i metodi standard (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` e `DELETE`) vengono convertiti in maiuscolo per evitare errori del server dovuti alla sensibilità alle maiuscole.

##### json

Tipo: `object` e qualsiasi altro valore accettato da [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Scorciatoia per inviare JSON. Usa questa opzione invece dell'opzione `body`. Accetta qualsiasi oggetto semplice o valore, che verrà convertito in stringa da `JSON.stringify()` e inviato nel body con l'intestazione corretta impostata.

##### searchParams

Tipo: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Predefinito: `''`

Parametri di ricerca da includere nell'URL della richiesta. Impostando questo valore sovrascriverai tutti i parametri di ricerca esistenti nell'URL di input.

Accetta qualsiasi valore supportato da [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Tipo: `string | URL`

Un prefisso da anteporre all'URL `input` durante la richiesta. Può essere qualsiasi URL valido, relativo o assoluto. Una barra finale `/` è opzionale e verrà aggiunta automaticamente, se necessario, quando viene unito a `input`. Ha effetto solo quando `input` è una stringa. L'argomento `input` non può iniziare con una barra `/` quando si utilizza questa opzione.

Utile se usato con [`ky.extend()`](#kyextenddefaultoptions) per creare istanze di Ky specifiche per una nicchia.

```js
import ky from 'ky';

// Su https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Note:
 - Dopo che `prefixUrl` e `input` sono stati uniti, il risultato viene risolto rispetto all'[URL di base](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) della pagina (se presente).
 - I caratteri di slash iniziali in `input` non sono consentiti quando si utilizza questa opzione per garantire coerenza ed evitare confusione su come viene gestito l'URL `input`, dato che non seguirà le normali regole di risoluzione degli URL quando viene usato `prefixUrl`, il che cambia il significato di uno slash iniziale.

##### retry

Tipo: `object | number`\
Predefinito:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Un oggetto che rappresenta i campi `limit`, `methods`, `statusCodes`, `afterStatusCodes` e `maxRetryAfter` per il conteggio massimo dei tentativi, i metodi consentiti, i codici di stato consentiti, i codici di stato autorizzati a utilizzare il tempo specificato nell'header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) e il tempo massimo [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Se `retry` è un numero, verrà utilizzato come `limit` e gli altri valori predefiniti rimarranno invariati.

Se la risposta fornisce un codice di stato HTTP contenuto in `afterStatusCodes`, Ky attenderà fino alla data, timeout o timestamp specificato nell'header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) prima di riprovare la richiesta. Se `Retry-After` è assente, viene utilizzato come fallback l'header non standard [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3). Se il codice di stato fornito non è nell'elenco, l'header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) verrà ignorato.

Se `maxRetryAfter` è impostato su `undefined`, verrà utilizzato `options.timeout`. Se l'header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) supera `maxRetryAfter`, verrà utilizzato `maxRetryAfter`.

L'opzione `backoffLimit` è il limite superiore del ritardo per ogni tentativo di retry, espresso in millisecondi.
Per limitare il ritardo, ad esempio, impostare `backoffLimit` a 1000.
Per impostazione predefinita, il ritardo è calcolato con `0.3 * (2 ** (attemptCount - 1)) * 1000`. Il ritardo aumenta in modo esponenziale.

L'opzione `delay` può essere utilizzata per cambiare come viene calcolato il ritardo tra i tentativi. La funzione riceve come parametro il numero di tentativi, a partire da `1`.

I tentativi di retry non vengono attivati dopo un [timeout](#timeout).

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

Tipo: `number | false`\
Predefinito: `10000`

Timeout in millisecondi per ottenere una risposta, inclusi eventuali retry. Non può essere superiore a 2147483647.
Se impostato su `false`, non ci sarà alcun timeout.

##### hooks

Tipo: `object<string, Function[]>`\
Predefinito: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Gli hooks permettono modifiche durante il ciclo di vita della richiesta. Le funzioni hook possono essere asincrone e vengono eseguite in serie.

###### hooks.beforeRequest

Tipo: `Function[]`\
Predefinito: `[]`

Questo hook consente di modificare la richiesta subito prima che venga inviata. Ky non apporterà ulteriori modifiche alla richiesta dopo questo punto. La funzione hook riceve `request` e `options` come argomenti. Ad esempio, qui potresti modificare `request.headers`.

L'hook può restituire un oggetto [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) per sostituire la richiesta in uscita, oppure restituire un oggetto [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) per evitare completamente l'invio della richiesta HTTP. Questo può essere utilizzato per simulare una richiesta, controllare una cache interna, ecc. Una considerazione **importante** quando si restituisce una richiesta o una risposta da questo hook è che tutti gli altri hook `beforeRequest` rimanenti verranno saltati, quindi potresti volerli restituire solo dall'ultimo hook.

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

Tipo: `Function[]`\
Predefinito: `[]`

Questo hook consente di modificare la richiesta subito prima del retry. Ky non apporterà ulteriori modifiche alla richiesta dopo questo punto. La funzione hook riceve un oggetto con la richiesta normalizzata e le opzioni, un'istanza di errore e il numero di retry. Ad esempio, qui potresti modificare `request.headers`.

Se la richiesta ha ricevuto una risposta, l'errore sarà di tipo `HTTPError` e l'oggetto `Response` sarà disponibile in `error.response`. Tieni presente che alcuni tipi di errori, come gli errori di rete, implicano che una risposta non è stata ricevuta. In tal caso, l'errore non sarà un'istanza di `HTTPError`.

Puoi impedire a Ky di effettuare il retry della richiesta lanciando un errore. Ky non lo gestirà in alcun modo e l'errore verrà propagato all'iniziatore della richiesta. Il resto degli hook `beforeRetry` non verrà chiamato in questo caso. In alternativa, puoi restituire il simbolo [`ky.stop`](#kystop) per ottenere lo stesso risultato ma senza propagare un errore (questo ha alcune limitazioni, vedi la documentazione di `ky.stop` per i dettagli).

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

Tipo: `Function[]`\
Predefinito: `[]`

Questo hook permette di modificare l'oggetto `HTTPError` subito prima che venga lanciato. La funzione hook riceve un oggetto `HTTPError` come argomento e dovrebbe restituire un'istanza di `HTTPError`.

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

Tipo: `Function[]`\
Predefinito: `[]`

Questo hook permette di leggere e opzionalmente modificare la risposta. La funzione hook riceve la richiesta normalizzata, le opzioni e una copia della risposta come argomenti. Il valore restituito dalla funzione hook verrà utilizzato da Ky come oggetto risposta se è un'istanza di [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Puoi fare qualcosa con la risposta, ad esempio il logging.
				log(response);

				// Oppure restituire un'istanza di `Response` per sovrascrivere la risposta.
				return new Response('A different response', {status: 200});
			},

			// Oppure riprovare con un nuovo token in caso di errore 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Ottieni un nuovo token
					const token = await ky('https://example.com/token').text();

					// Riprova con il token
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Tipo: `boolean`\
Predefinito: `true`

Lancia un `HTTPError` quando, dopo aver seguito i redirect, la risposta ha un codice di stato non 2xx. Per lanciare errori anche per i redirect invece di seguirli, imposta l'opzione [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) su `'manual'`.

Impostare questo valore su `false` può essere utile se stai verificando la disponibilità di una risorsa e ti aspetti risposte di errore.

Nota: Se impostato su `false`, le risposte di errore sono considerate di successo e la richiesta non verrà riprovata.

##### onDownloadProgress

Tipo: `Function`

Gestore evento per il progresso del download.

La funzione riceve questi argomenti:
- `progress` è un oggetto con queste proprietà:
- - `percent` è un numero compreso tra 0 e 1 che rappresenta la percentuale di avanzamento.
- - `transferredBytes` è il numero di byte trasferiti finora.
- - `totalBytes` è il numero totale di byte da trasferire. Questo è una stima e può essere 0 se la dimensione totale non può essere determinata.
- `chunk` è un'istanza di `Uint8Array` contenente i dati inviati. Nota: è vuoto alla prima chiamata.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Esempio di output:
		// `0% - 0 di 1271 byte`
		// `100% - 1271 di 1271 byte`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} di ${progress.totalBytes} byte`);
	}
});
```

##### onUploadProgress

Tipo: `Function`
Gestore dell’evento di avanzamento del caricamento.

La funzione riceve questi argomenti:
- `progress` è un oggetto con le seguenti proprietà:
- - `percent` è un numero compreso tra 0 e 1 che rappresenta la percentuale di avanzamento.
- - `transferredBytes` è il numero di byte trasferiti finora.
- - `totalBytes` è il numero totale di byte da trasferire. Questo è una stima e può essere 0 se la dimensione totale non può essere determinata.
- `chunk` è un’istanza di `Uint8Array` contenente i dati che sono stati inviati. Nota: È vuoto per l’ultima chiamata.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Esempio di output:
		// `0% - 0 di 1271 byte`
		// `100% - 1271 di 1271 byte`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} di ${progress.totalBytes} byte`);
	}
});
```

##### parseJson

Tipo: `Function`\
Predefinito: `JSON.parse()`

Funzione di parsing JSON definita dall’utente.

Casi d’uso:
1. Analizzare JSON tramite il pacchetto [`bourne`](https://github.com/hapijs/bourne) per proteggere da inquinamento del prototipo.
2. Analizzare JSON con l’opzione [`reviver` di `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Tipo: `Function`\
Predefinito: `JSON.stringify()`

Funzione di serializzazione JSON definita dall’utente.

Casi d’uso:
1. Serializzare JSON con una funzione `replacer` personalizzata.

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

Tipo: `Function`\
Predefinito: `fetch`

Funzione `fetch` definita dall’utente.
Deve essere completamente compatibile con lo standard [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Casi d’uso:
1. Utilizzare implementazioni personalizzate di `fetch` come [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Utilizzare la funzione wrapper `fetch` fornita da alcuni framework che usano il server-side rendering (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Crea una nuova istanza di `ky` con alcune impostazioni predefinite sovrascritte con le tue.

A differenza di `ky.create()`, `ky.extend()` eredita le impostazioni predefinite dal suo genitore.

Puoi passare le intestazioni come istanza di `Headers` o come oggetto semplice.

Puoi rimuovere un’intestazione con `.extend()` passando l’intestazione con valore `undefined`.
Passando `undefined` come stringa si rimuove l’intestazione solo se proviene da un’istanza di `Headers`.

Allo stesso modo, puoi rimuovere le voci esistenti di `hooks` estendendo l’hook con un esplicito `undefined`.

```js
import ky from 'ky';

const url = 'https://sindresorhus.com';

const original = ky.create({
	headers: {
		rainbow: 'rainbow',
		unicorn: 'unicorn'
	},
	hooks: {
		beforeRequest: [ () => console.log('prima 1') ],
		afterResponse: [ () => console.log('dopo 1') ],
	},
});

const extended = original.extend({
	headers: {
		rainbow: undefined
	},
	hooks: {
		beforeRequest: undefined,
		afterResponse: [ () => console.log('dopo 2') ],
	}
});

const response = await extended(url).json();
//=> dopo 1
//=> dopo 2

console.log('rainbow' in response);
//=> false

console.log('unicorn' in response);
//=> true
```

Puoi anche fare riferimento alle impostazioni predefinite del genitore fornendo una funzione a `.extend()`.

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

Crea una nuova istanza di Ky con impostazioni predefinite completamente nuove.

```js
import ky from 'ky';

// Su https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Tipo: `object`

### ky.stop

Un `Symbol` che può essere restituito da un hook `beforeRetry` per interrompere il tentativo di ripetizione. Questo interromperà anche i restanti hook `beforeRetry`.

Nota: Restituire questo simbolo fa sì che Ky si interrompa e restituisca una risposta `undefined`. Assicurati di verificare la presenza di una risposta prima di accedere a qualsiasi proprietà o usa [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). È anche incompatibile con i metodi del body, come `.json()` o `.text()`, perché non c’è risposta da analizzare. In generale, si consiglia di generare un errore invece di restituire questo simbolo, poiché ciò farà sì che Ky si interrompa e poi generi un’eccezione, evitando queste limitazioni.

Un caso d’uso valido per `ky.stop` è prevenire i tentativi di ripetizione quando si effettuano richieste per effetti collaterali, dove i dati restituiti non sono importanti. Ad esempio, registrare l’attività del client sul server.

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
// Nota che la risposta sarà `undefined` nel caso venga restituito `ky.stop`.
const response = await ky.post('https://example.com', options);

// L'utilizzo di `.text()` o di altri metodi del corpo non è supportato.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Esportato per i controlli `instanceof`. L'errore ha una proprietà `response` con l'oggetto [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), una proprietà `request` con l'oggetto [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) e una proprietà `options` con le opzioni normalizzate (o passate a `ky` durante la creazione di un'istanza con `ky.create()` o direttamente durante l'esecuzione della richiesta).

Tieni presente che alcuni tipi di errori, come gli errori di rete, implicano intrinsecamente che non sia stata ricevuta alcuna risposta. In tal caso, l'errore non sarà un'istanza di HTTPError e non conterrà la proprietà `response`.

Se hai bisogno di leggere la risposta effettiva quando si verifica un `HTTPError`, chiama il rispettivo metodo di parsing sull'oggetto response. Ad esempio:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Accetta un [parametro di tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opzionale, che per impostazione predefinita è [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), e viene passato al tipo di ritorno di `error.response.json()`.

### TimeoutError

L'errore lanciato quando la richiesta va in timeout. Ha una proprietà `request` con l'oggetto [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Suggerimenti

### Invio di dati di form

L'invio di dati di form in Ky è identico a `fetch`. Basta passare un'istanza di [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) all'opzione `body`. L'intestazione `Content-Type` verrà impostata automaticamente su `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Se vuoi inviare i dati in formato `application/x-www-form-urlencoded`, dovrai codificare i dati con [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Impostare un `Content-Type` personalizzato

Ky imposta automaticamente un'intestazione [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) appropriata per ogni richiesta in base ai dati nel corpo della richiesta. Tuttavia, alcune API richiedono tipi di contenuto personalizzati o non standard, come `application/x-amz-json-1.1`. Utilizzando l'opzione `headers`, puoi sovrascrivere manualmente il content type.

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

### Cancellazione

Fetch (e quindi Ky) supporta nativamente la cancellazione delle richieste tramite l'[API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Leggi di più.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Esempio:

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
		console.log('Fetch annullato');
	} else {
		console.error('Errore fetch:', error);
	}
}
```

## FAQ

#### Come si usa in Node.js?

Node.js 18 e versioni successive supportano nativamente `fetch`, quindi puoi semplicemente usare questo pacchetto direttamente.

#### Come si usa con una web app (React, Vue.js, ecc.) che utilizza il server-side rendering (SSR)?

Come sopra.

#### Come posso testare una libreria browser che utilizza questo?

Usa un test runner che può essere eseguito nel browser, come Mocha, oppure usa [AVA](https://avajs.dev) con `ky-universal`. [Leggi di più.](https://github.com/sindresorhus/ky-universal#faq)

#### Come lo uso senza un bundler come Webpack?

Assicurati che il tuo codice venga eseguito come modulo JavaScript (ESM), ad esempio utilizzando un tag `<script type="module">` nel documento HTML. Ky può quindi essere importato direttamente da quel modulo senza un bundler o altri strumenti.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### In cosa è diverso da [`got`](https://github.com/sindresorhus/got)

Vedi la mia risposta [qui](https://twitter.com/sindresorhus/status/1037406558945042432). Got è mantenuto dalle stesse persone di Ky.

#### In cosa è diverso da [`axios`](https://github.com/axios/axios)?

Vedi la mia risposta [qui](https://twitter.com/sindresorhus/status/1037763588826398720).

#### In cosa è diverso da [`r2`](https://github.com/mikeal/r2)?

Vedi la mia risposta in [#10](https://github.com/sindresorhus/ky/issues/10).

#### Cosa significa `ky`?

È semplicemente un nome di pacchetto npm breve e casuale che sono riuscito a ottenere. Tuttavia, ha un significato in giapponese:

> Una forma di gergo testuale, KY è un'abbreviazione di 空気読めない (kuuki yomenai), che letteralmente si traduce in “non sa leggere l'aria.” È una frase applicata a qualcuno che non coglie il significato implicito.

## Compatibilità browser

Le ultime versioni di Chrome, Firefox e Safari.

## Compatibilità Node.js

Node.js 18 e versioni successive.

## Correlati

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Utilità utili per lavorare con Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Ky hooks per modificare i casi su richieste e risposte di oggetti

## Maintainer

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---