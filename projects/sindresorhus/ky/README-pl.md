<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky to niewielki i elegancki klient HTTP oparty na [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky jest przeznaczony dla [nowoczesnych przeglądarek](#browser-support), Node.js, Bun i Deno.

To po prostu niewielka paczka bez zależności.

## Zalety w porównaniu do zwykłego `fetch`

- Prostsze API
- Skróty metod (`ky.post()`)
- Traktuje kody statusu inne niż 2xx jako błędy (po przekierowaniach)
- Ponawia nieudane żądania
- Opcja JSON
- Obsługa limitu czasu (timeout)
- Opcja prefiksu URL
- Instancje z własnymi domyślnymi ustawieniami
- Hooki
- Udogodnienia TypeScript (np. `.json()` obsługuje generyki i domyślnie zwraca `unknown`, a nie `any`)

## Instalacja

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Użycie

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Za pomocą zwykłego `fetch` wyglądałoby to tak:

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

Jeśli używasz [Deno](https://github.com/denoland/deno), zaimportuj Ky z adresu URL. Na przykład, używając CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` i `options` są takie same jak w [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), z dodatkowymi opcjami (patrz poniżej).

Zwraca [`obiekt Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) z dodanymi dla wygody [metodami `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body). Dzięki temu możesz np. wywołać `ky.get(input).json()` bez konieczności oczekiwania najpierw na `Response`. Przy takim wywołaniu zostanie ustawiony odpowiedni nagłówek `Accept` w zależności od użytej metody ciała. W przeciwieństwie do metod `Body` z `window.Fetch`, te rzucą wyjątek `HTTPError`, jeśli status odpowiedzi nie mieści się w zakresie `200...299`. Ponadto `.json()` zwróci pusty string, jeśli ciało jest puste lub status odpowiedzi to `204`, zamiast rzucać błąd parsowania spowodowany pustym ciałem.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Przyjmuje opcjonalny [parametr typu](https://www.typescriptlang.org/docs/handbook/2/generics.html), który domyślnie jest [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) i jest przekazywany do typu zwracanego przez `.json()`.

```ts
import ky from 'ky';

// user1 jest unknown
const user1 = await ky('/api/users/1').json();
// user2 jest typu User
const user2 = await ky<User>('/api/users/2').json();
// user3 jest typu User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Ustawia `options.method` na nazwę metody i wykonuje żądanie.

⌨️ **TypeScript:** Przyjmuje opcjonalny parametr typu do użycia z odpowiedziami JSON (patrz [`ky()`](#kyinput-options)).

#### input

Typ: `string` | `URL` | `Request`

Tak samo jak [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Gdy używasz instancji [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) jako `input`, wszelkie opcje modyfikujące URL (takie jak `prefixUrl`) zostaną zignorowane.

#### options

Typ: `object`

Takie same jak [opcje `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), plus następujące dodatkowe opcje:

##### method

Typ: `string`\
Domyślnie: `'get'`

Metoda HTTP używana do wykonania żądania.

Wewnątrz standardowe metody (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` i `DELETE`) są zamieniane na wielkie litery, aby uniknąć błędów serwera wynikających z rozróżniania wielkości liter.

##### json

Typ: `object` oraz każda inna wartość akceptowana przez [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Skrót do wysyłania JSON. Użyj tego zamiast opcji `body`. Akceptuje dowolny zwykły obiekt lub wartość, która zostanie przekonwertowana za pomocą `JSON.stringify()` i wysłana w ciele z ustawionym odpowiednim nagłówkiem.

##### searchParams

Typ: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Domyślnie: `''`

Parametry zapytania do uwzględnienia w URL żądania. Ustawienie tej opcji nadpisze wszystkie istniejące parametry zapytania w wejściowym URL.

Akceptuje dowolną wartość obsługiwaną przez [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Typ: `string | URL`

Prefiks do dołączenia do URL `input` podczas wykonywania żądania. Może to być dowolny prawidłowy URL, względny lub bezwzględny. Końcowy ukośnik `/` jest opcjonalny i zostanie automatycznie dodany, jeśli będzie potrzebny, podczas łączenia z `input`. Działa tylko wtedy, gdy `input` jest typu string. Argument `input` nie może zaczynać się od ukośnika `/` przy użyciu tej opcji.

Przydatne w połączeniu z [`ky.extend()`](#kyextenddefaultoptions) do tworzenia wyspecjalizowanych instancji Ky.

```js
import ky from 'ky';

// Na https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Uwagi:
 - Po połączeniu `prefixUrl` i `input`, wynik jest rozwiązywany względem [bazowego URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) strony (jeśli istnieje).
 - Wiodące ukośniki w `input` są niedozwolone przy użyciu tej opcji, aby zapewnić spójność i uniknąć nieporozumień związanych z tym, jak obsługiwany jest URL `input`, ponieważ nie będzie on podlegał normalnym zasadom rozwiązywania URL, gdy używany jest `prefixUrl`, co zmienia znaczenie wiodącego ukośnika.

##### retry

Typ: `object | number`\
Domyślnie:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Obiekt reprezentujący pola `limit`, `methods`, `statusCodes`, `afterStatusCodes` oraz `maxRetryAfter` dla maksymalnej liczby prób, dozwolonych metod, dozwolonych kodów statusu, kodów statusu, dla których można użyć czasu z nagłówka [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), oraz maksymalnego czasu [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Jeśli `retry` jest liczbą, zostanie ona użyta jako `limit`, a pozostałe domyślne wartości pozostaną bez zmian.

Jeśli odpowiedź zawiera kod HTTP znajdujący się w `afterStatusCodes`, Ky poczeka do momentu upłynięcia daty, limitu czasu lub znacznika czasu podanego w nagłówku [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) przed ponowną próbą żądania. Jeśli `Retry-After` jest nieobecny, w jego miejsce używany jest niestandardowy nagłówek [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) jako rozwiązanie zapasowe. Jeśli podany kod statusu nie znajduje się na liście, nagłówek [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) zostanie zignorowany.

Jeśli `maxRetryAfter` jest ustawiony na `undefined`, zostanie użyta wartość `options.timeout`. Jeśli nagłówek [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) jest większy niż `maxRetryAfter`, zostanie użyta wartość `maxRetryAfter`.

Opcja `backoffLimit` jest górnym limitem opóźnienia na próbę (w milisekundach).
Aby ograniczyć opóźnienie, ustaw na przykład `backoffLimit` na 1000.
Domyślnie opóźnienie obliczane jest według wzoru `0.3 * (2 ** (attemptCount - 1)) * 1000`. Opóźnienie rośnie wykładniczo.

Opcja `delay` umożliwia zmianę sposobu obliczania opóźnienia między próbami. Funkcja otrzymuje jeden parametr — licznik prób, zaczynając od `1`.

Ponowienia nie są wywoływane po [przekroczeniu limitu czasu](#timeout).

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
Domyślnie: `10000`

Limit czasu (w milisekundach) na uzyskanie odpowiedzi, wliczając wszystkie ponowienia. Nie może być większy niż 2147483647.
Jeśli ustawiony na `false`, limit czasu nie będzie stosowany.

##### hooks

Typ: `object<string, Function[]>`\
Domyślnie: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooki umożliwiają modyfikacje podczas cyklu życia żądania. Funkcje hooków mogą być asynchroniczne i są wykonywane sekwencyjnie.

###### hooks.beforeRequest

Typ: `Function[]`\
Domyślnie: `[]`

Ten hook umożliwia modyfikację żądania tuż przed jego wysłaniem. Ky nie wprowadzi żadnych dalszych zmian do żądania po tym momencie. Funkcja hooka otrzymuje jako argumenty `request` oraz `options`. Możesz na przykład modyfikować tutaj `request.headers`.

Hook może zwrócić instancję [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), aby zastąpić wychodzące żądanie, lub [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), by całkowicie uniknąć wysyłania żądania HTTP. Może to służyć do mockowania żądania, sprawdzania wewnętrznego cache itp. **Ważne:** Jeśli zwrócisz żądanie lub odpowiedź z tego hooka, pozostałe hooki `beforeRequest` zostaną pominięte, więc zaleca się zwracać je tylko z ostatniego hooka.

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
Domyślnie: `[]`

Ten hook umożliwia modyfikację żądania tuż przed ponowną próbą. Ky nie wprowadzi żadnych dalszych zmian do żądania po tym momencie. Funkcja hooka otrzymuje jako argument obiekt z normalizowanym żądaniem i opcjami, instancję błędu oraz licznik prób. Możesz na przykład modyfikować tutaj `request.headers`.

Jeśli żądanie otrzymało odpowiedź, błąd będzie typu `HTTPError`, a obiekt `Response` będzie dostępny pod `error.response`. Pamiętaj, że niektóre typy błędów, takie jak błędy sieciowe, z natury oznaczają brak odpowiedzi. W takim przypadku błąd nie będzie instancją `HTTPError`.

Możesz zapobiec ponowieniu żądania przez Ky, rzucając błąd. Ky nie obsłuży go w żaden sposób, a błąd zostanie przekazany do inicjatora żądania. Pozostałe hooki `beforeRetry` nie zostaną wtedy wywołane. Alternatywnie możesz zwrócić symbol [`ky.stop`](#kystop), aby uzyskać ten sam efekt bez propagowania błędu (ma to pewne ograniczenia, zobacz dokumentację `ky.stop` po szczegóły).

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
Domyślnie: `[]`

Ten hook umożliwia modyfikację `HTTPError` tuż przed jego wyrzuceniem. Funkcja hooka otrzymuje jako argument `HTTPError` i powinna zwrócić instancję `HTTPError`.

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
Domyślnie: `[]`

Ten hook umożliwia odczytanie i opcjonalną modyfikację odpowiedzi. Funkcja hooka otrzymuje jako argumenty normalizowane żądanie, opcje oraz klon odpowiedzi. Wartość zwrócona przez funkcję hooka zostanie użyta przez Ky jako obiekt odpowiedzi, jeśli będzie to instancja [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Możesz coś zrobić z odpowiedzią, na przykład logować.
				log(response);

				// Lub zwrócić instancję `Response`, aby nadpisać odpowiedź.
				return new Response('A different response', {status: 200});
			},

			// Lub ponowić próbę z nowym tokenem przy błędzie 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Pobierz nowy token
					const token = await ky('https://example.com/token').text();

					// Ponów próbę z tokenem
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
Domyślnie: `true`

Rzuć `HTTPError`, gdy po przekierowaniach odpowiedź ma kod inny niż 2xx. Aby również rzucać błędy dla przekierowań zamiast je śledzić, ustaw opcję [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) na `'manual'`.

Ustawienie tej opcji na `false` może być przydatne, jeśli sprawdzasz dostępność zasobu i spodziewasz się odpowiedzi z błędem.

Uwaga: Jeśli `false`, odpowiedzi z błędem są traktowane jako udane i żądanie nie zostanie ponowione.

##### onDownloadProgress

Typ: `Function`

Obsługa zdarzenia postępu pobierania.

Funkcja otrzymuje następujące argumenty:
- `progress` to obiekt z następującymi właściwościami:
- - `percent` — liczba z zakresu 0–1 oznaczająca procent ukończenia.
- - `transferredBytes` — liczba bajtów przesłanych do tej pory.
- - `totalBytes` — całkowita liczba bajtów do przesłania. To wartość szacunkowa i może wynosić 0, jeśli nie można określić całkowitego rozmiaru.
- `chunk` to instancja `Uint8Array` zawierająca przesłane dane. Uwaga: Przy pierwszym wywołaniu jest pusta.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Przykładowy wynik:
		// `0% - 0 z 1271 bajtów`
		// `100% - 1271 z 1271 bajtów`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} z ${progress.totalBytes} bajtów`);
	}
});
```

##### onUploadProgress

Typ: `Function`
Obsługa zdarzenia postępu przesyłania.

Funkcja otrzymuje następujące argumenty:
- `progress` to obiekt o następujących właściwościach:
- - `percent` to liczba z zakresu od 0 do 1, reprezentująca procentowy postęp.
- - `transferredBytes` to liczba bajtów przesłanych do tej pory.
- - `totalBytes` to całkowita liczba bajtów do przesłania. Jest to szacunkowa wartość i może wynosić 0, jeśli nie można określić całkowitego rozmiaru.
- `chunk` to instancja `Uint8Array` zawierająca dane, które zostały wysłane. Uwaga: Dla ostatniego wywołania jest pusta.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Przykładowy wynik:
		// `0% - 0 z 1271 bajtów`
		// `100% - 1271 z 1271 bajtów`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} z ${progress.totalBytes} bajtów`);
	}
});
```

##### parseJson

Typ: `Function`\
Domyślnie: `JSON.parse()`

Użytkownik może zdefiniować własną funkcję do parsowania JSON.

Przykłady użycia:
1. Parsowanie JSON przy pomocy pakietu [`bourne`](https://github.com/hapijs/bourne) w celu ochrony przed zanieczyszczeniem prototypu.
2. Parsowanie JSON z opcją [`reviver` w `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Typ: `Function`\
Domyślnie: `JSON.stringify()`

Użytkownik może zdefiniować własną funkcję do konwertowania obiektu na JSON.

Przykłady użycia:
1. Konwertowanie JSON przy użyciu niestandardowej funkcji `replacer`.

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
Domyślnie: `fetch`

Użytkownik może zdefiniować własną funkcję `fetch`.
Musi być ona w pełni zgodna ze standardem [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Przykłady użycia:
1. Użycie niestandardowej implementacji `fetch`, takiej jak [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Użycie funkcji `fetch` dostarczonej przez niektóre frameworki wykorzystujące SSR (renderowanie po stronie serwera).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Tworzy nową instancję `ky` z nadpisanymi domyślnymi ustawieniami.

W przeciwieństwie do `ky.create()`, `ky.extend()` dziedziczy domyślne ustawienia od swojego rodzica.

Nagłówki można przekazać jako instancję `Headers` lub zwykły obiekt.

Możesz usunąć nagłówek za pomocą `.extend()`, przekazując nagłówek z wartością `undefined`.
Przekazanie `undefined` jako string usuwa nagłówek tylko wtedy, gdy pochodzi on z instancji `Headers`.

Podobnie, można usuwać istniejące wpisy `hooks`, rozszerzając hook z jawnie ustawioną wartością `undefined`.

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

Możesz również odwołać się do domyślnych ustawień rodzica, przekazując funkcję do `.extend()`.

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

Tworzy nową instancję Ky z całkowicie nowymi domyślnymi ustawieniami.

```js
import ky from 'ky';

// Na https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Typ: `object`

### ky.stop

`Symbol`, który może zostać zwrócony przez hook `beforeRetry`, aby zatrzymać ponawianie żądania. Powoduje to również przerwanie pozostałych hooków `beforeRetry`.

Uwaga: Zwrócenie tego symbolu powoduje, że Ky przerywa działanie i zwraca odpowiedź `undefined`. Przed dostępem do jakichkolwiek właściwości odpowiedzi upewnij się, że odpowiedź istnieje lub użyj [opcjonalnego łańcuchowania](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Symbol ten jest także niekompatybilny z metodami operującymi na treści odpowiedzi, takimi jak `.json()` czy `.text()`, ponieważ nie ma odpowiedzi do sparsowania. Ogólnie zalecamy zgłaszanie błędu zamiast zwracania tego symbolu, ponieważ spowoduje to przerwanie Ky i wyrzucenie błędu, co pozwala uniknąć tych ograniczeń.

Prawidłowym przypadkiem użycia `ky.stop` jest zapobieganie ponowieniom przy żądaniach wywołujących efekty uboczne, gdzie zwracane dane nie są istotne. Na przykład przy logowaniu aktywności klienta na serwerze.

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
// Zwróć uwagę, że odpowiedź będzie `undefined` w przypadku, gdy zostanie zwrócone `ky.stop`.
const response = await ky.post('https://example.com', options);

// Używanie `.text()` lub innych metod ciała nie jest obsługiwane.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Udostępnione do sprawdzania przez `instanceof`. Błąd posiada właściwość `response` z [obiektem Response](https://developer.mozilla.org/en-US/docs/Web/API/Response), właściwość `request` z [obiektem Request](https://developer.mozilla.org/en-US/docs/Web/API/Request) oraz właściwość `options` z normalizowanymi opcjami (przekazanymi do `ky` podczas tworzenia instancji za pomocą `ky.create()` lub bezpośrednio podczas wykonywania żądania).

Pamiętaj, że niektóre typy błędów, takie jak błędy sieciowe, z natury oznaczają, że nie otrzymano odpowiedzi. W takim przypadku błąd nie będzie instancją HTTPError i nie będzie zawierał właściwości `response`.

Jeśli chcesz odczytać faktyczną odpowiedź, gdy wystąpił `HTTPError`, wywołaj odpowiednią metodę parsera na obiekcie response. Na przykład:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Akceptuje opcjonalny [parametr typu](https://www.typescriptlang.org/docs/handbook/2/generics.html), który domyślnie jest [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) i jest przekazywany do typu zwracanego przez `error.response.json()`.

### TimeoutError

Błąd rzucany, gdy żądanie przekroczy limit czasu. Posiada właściwość `request` z [obiektem Request](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Porady

### Wysyłanie danych formularza

Wysyłanie danych formularza w Ky jest identyczne jak w `fetch`. Po prostu przekaż instancję [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) do opcji `body`. Nagłówek `Content-Type` zostanie automatycznie ustawiony na `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Jeśli chcesz wysłać dane w formacie `application/x-www-form-urlencoded`, musisz zakodować dane za pomocą [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Ustawianie niestandardowego `Content-Type`

Ky automatycznie ustawia odpowiedni nagłówek [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) dla każdego żądania na podstawie danych w ciele żądania. Jednak niektóre API wymagają niestandardowych, niestandardowych typów treści, takich jak `application/x-amz-json-1.1`. Używając opcji `headers`, możesz ręcznie nadpisać typ treści.

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

### Anulowanie

Fetch (a zatem Ky) ma wbudowaną obsługę anulowania żądań przez API [`AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Przeczytaj więcej.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Przykład:

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
		console.log('Fetch aborted');
	} else {
		console.error('Fetch error:', error);
	}
}
```

## FAQ

#### Jak używać tego w Node.js?

Node.js 18 i nowsze obsługują natywnie `fetch`, więc możesz po prostu użyć tego pakietu bezpośrednio.

#### Jak używać tego z aplikacją webową (React, Vue.js itp.) używającą server-side rendering (SSR)?

Tak samo jak powyżej.

#### Jak testować bibliotekę przeglądarkową, która tego używa?

Możesz użyć runnera testów działającego w przeglądarce, jak Mocha, lub użyć [AVA](https://avajs.dev) z `ky-universal`. [Przeczytaj więcej.](https://github.com/sindresorhus/ky-universal#faq)

#### Jak użyć tego bez bundlera jak Webpack?

Upewnij się, że twój kod działa jako moduł JavaScript (ESM), na przykład używając znacznika `<script type="module">` w dokumencie HTML. Wtedy Ky może być importowane bezpośrednio przez ten moduł, bez bundlera czy innych narzędzi.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Czym różni się to od [`got`](https://github.com/sindresorhus/got)

Zobacz moją odpowiedź [tutaj](https://twitter.com/sindresorhus/status/1037406558945042432). Got jest utrzymywany przez tych samych ludzi co Ky.

#### Czym różni się to od [`axios`](https://github.com/axios/axios)?

Zobacz moją odpowiedź [tutaj](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Czym różni się to od [`r2`](https://github.com/mikeal/r2)?

Zobacz moją odpowiedź w [#10](https://github.com/sindresorhus/ky/issues/10).

#### Co oznacza `ky`?

To po prostu losowa, krótka nazwa pakietu npm, którą udało mi się zdobyć. Jednak po japońsku ma również znaczenie:

> Forma slangu tekstowego, KY to skrót od 空気読めない (kuuki yomenai), co dosłownie oznacza „nie potrafi czytać powietrza”. To fraza używana wobec kogoś, kto nie odczytuje ukrytego znaczenia.

## Obsługa przeglądarek

Najnowsze wersje Chrome, Firefox i Safari.

## Obsługa Node.js

Node.js 18 i nowsze.

## Powiązane

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Przydatne narzędzia do pracy z Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Hooki Ky do zmiany stylu zapytań i odpowiedzi obiektów

## Utrzymujący

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---