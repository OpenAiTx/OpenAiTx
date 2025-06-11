<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky es un cliente HTTP pequeño y elegante basado en la [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky está orientado a [navegadores modernos](#browser-support), Node.js, Bun y Deno.

Es solo un paquete pequeño sin dependencias.

## Ventajas sobre el `fetch` puro

- API más simple
- Atajos para métodos (`ky.post()`)
- Trata los códigos de estado no 2xx como errores (después de redirecciones)
- Reintenta solicitudes fallidas
- Opción para JSON
- Soporte para tiempo de espera (timeout)
- Opción de prefijo de URL
- Instancias con valores predeterminados personalizados
- Hooks
- Mejoras para TypeScript (por ejemplo, `.json()` soporta genéricos y por defecto retorna `unknown`, no `any`)

## Instalación

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Uso

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Con `fetch` puro, sería:

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

Si usas [Deno](https://github.com/denoland/deno), importa Ky desde una URL. Por ejemplo, usando un CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

El `input` y las `options` son las mismas que en [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), con opciones adicionales disponibles (ver más abajo).

Devuelve un [objeto `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) con [métodos de `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) añadidos para mayor comodidad. Así puedes, por ejemplo, llamar a `ky.get(input).json()` directamente sin tener que esperar primero el `Response`. Cuando se llama de esta manera, se establecerá una cabecera `Accept` apropiada dependiendo del método de cuerpo utilizado. A diferencia de los métodos `Body` de `window.Fetch`, estos lanzarán un `HTTPError` si el estado de la respuesta no está en el rango de `200...299`. Además, `.json()` devolverá una cadena vacía si el cuerpo está vacío o el estado de la respuesta es `204` en lugar de lanzar un error de análisis debido a un cuerpo vacío.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Acepta un [parámetro de tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opcional, que por defecto es [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), y se pasa al tipo de retorno de `.json()`.

```ts
import ky from 'ky';

// user1 es unknown
const user1 = await ky('/api/users/1').json();
// user2 es un User
const user2 = await ky<User>('/api/users/2').json();
// user3 es un User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Establece `options.method` al nombre del método y realiza una solicitud.

⌨️ **TypeScript:** Acepta un parámetro de tipo opcional para usar con respuestas JSON (ver [`ky()`](#kyinput-options)).

#### input

Tipo: `string` | `URL` | `Request`

Igual que el [input de `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Cuando se usa una instancia de [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) como `input`, se ignorarán todas las opciones que alteran la URL (como `prefixUrl`).

#### options

Tipo: `object`

Igual que las [opciones de `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), más las siguientes opciones adicionales:

##### method

Tipo: `string`\
Por defecto: `'get'`

Método HTTP utilizado para realizar la solicitud.

Internamente, los métodos estándar (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` y `DELETE`) se convierten a mayúsculas para evitar errores del servidor debido a la sensibilidad de mayúsculas y minúsculas.

##### json

Tipo: `object` y cualquier otro valor aceptado por [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Atajo para enviar JSON. Usa esto en lugar de la opción `body`. Acepta cualquier objeto plano o valor, que será convertido con `JSON.stringify()` y enviado en el cuerpo con la cabecera correcta establecida.

##### searchParams

Tipo: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Por defecto: `''`

Parámetros de búsqueda para incluir en la URL de la solicitud. Establecer esto sobrescribirá todos los parámetros de búsqueda existentes en la URL de entrada.

Acepta cualquier valor soportado por [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Tipo: `string | URL`

Un prefijo para anteponer a la URL de `input` al realizar la solicitud. Puede ser cualquier URL válida, relativa o absoluta. Una barra final `/` es opcional y se añadirá automáticamente, si es necesario, cuando se combine con `input`. Solo tiene efecto cuando `input` es una cadena. El argumento `input` no puede comenzar con una barra `/` cuando se usa esta opción.

Útil cuando se usa con [`ky.extend()`](#kyextenddefaultoptions) para crear instancias de Ky específicas para un nicho.

```js
import ky from 'ky';

// En https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Notas:
 - Después de unir `prefixUrl` e `input`, el resultado se resuelve contra la [URL base](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) de la página (si la hay).
 - No se permiten barras iniciales en `input` al usar esta opción para reforzar la consistencia y evitar confusiones sobre cómo se maneja la URL de `input`, dado que `input` no seguirá las reglas normales de resolución de URL cuando se utilice `prefixUrl`, lo que cambia el significado de una barra inicial.

##### retry

Tipo: `object | number`\
Por defecto:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Un objeto que representa los campos `limit`, `methods`, `statusCodes`, `afterStatusCodes` y `maxRetryAfter` para el número máximo de reintentos, métodos permitidos, códigos de estado permitidos, códigos de estado permitidos para usar el tiempo de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), y el tiempo máximo de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Si `retry` es un número, se utilizará como `limit` y los demás valores predeterminados permanecerán.

Si la respuesta proporciona un código de estado HTTP contenido en `afterStatusCodes`, Ky esperará hasta la fecha, tiempo de espera o marca de tiempo indicada en la cabecera [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) antes de reintentar la solicitud. Si falta el encabezado `Retry-After`, se utiliza en su lugar la cabecera no estándar [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) como alternativa. Si el código de estado proporcionado no está en la lista, se ignorará la cabecera [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Si `maxRetryAfter` se establece en `undefined`, utilizará `options.timeout`. Si el encabezado [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) es mayor que `maxRetryAfter`, se usará `maxRetryAfter`.

La opción `backoffLimit` es el límite superior del retraso por reintento en milisegundos.
Para limitar el retraso, establece `backoffLimit` en 1000, por ejemplo.
Por defecto, el retraso se calcula con `0.3 * (2 ** (attemptCount - 1)) * 1000`. El retraso aumenta exponencialmente.

La opción `delay` se puede utilizar para cambiar cómo se calcula el retraso entre reintentos. La función recibe un parámetro, el número de intento, comenzando en `1`.

Los reintentos no se activan tras un [timeout](#timeout).

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
Predeterminado: `10000`

Tiempo de espera en milisegundos para obtener una respuesta, incluyendo cualquier reintento. No puede ser mayor que 2147483647.
Si se establece en `false`, no habrá límite de tiempo de espera.

##### hooks

Tipo: `object<string, Function[]>`\
Predeterminado: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Los hooks permiten modificaciones durante el ciclo de vida de la solicitud. Las funciones hook pueden ser asíncronas y se ejecutan en serie.

###### hooks.beforeRequest

Tipo: `Function[]`\
Predeterminado: `[]`

Este hook te permite modificar la solicitud justo antes de que sea enviada. Ky no realizará más cambios en la solicitud después de esto. La función del hook recibe `request` y `options` como argumentos. Por ejemplo, podrías modificar aquí `request.headers`.

El hook puede devolver un [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) para reemplazar la solicitud saliente, o devolver un [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) para evitar completamente hacer una solicitud HTTP. Esto se puede usar para simular una solicitud, consultar una caché interna, etc. Una consideración **importante** al devolver una solicitud o respuesta desde este hook es que cualquier hook `beforeRequest` restante será omitido, por lo que puede que solo desees devolverlos desde el último hook.

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
Predeterminado: `[]`

Este hook te permite modificar la solicitud justo antes del reintento. Ky no realizará más cambios en la solicitud después de esto. La función hook recibe un objeto con la solicitud y opciones normalizadas, una instancia de error y el número de reintento. Por ejemplo, podrías modificar aquí `request.headers`.

Si la solicitud recibió una respuesta, el error será de tipo `HTTPError` y el objeto `Response` estará disponible en `error.response`. Ten en cuenta que algunos tipos de errores, como errores de red, implican que no se recibió una respuesta. En ese caso, el error no será una instancia de `HTTPError`.

Puedes evitar que Ky reintente la solicitud lanzando un error. Ky no lo manejará de ninguna manera y el error será propagado al iniciador de la solicitud. El resto de los hooks `beforeRetry` no serán llamados en este caso. Alternativamente, puedes devolver el símbolo [`ky.stop`](#kystop) para hacer lo mismo pero sin propagar un error (esto tiene algunas limitaciones, consulta la documentación de `ky.stop` para más detalles).

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
Predeterminado: `[]`

Este hook te permite modificar el `HTTPError` justo antes de que sea lanzado. La función del hook recibe un `HTTPError` como argumento y debe devolver una instancia de `HTTPError`.

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
Predeterminado: `[]`

Este hook te permite leer y, opcionalmente, modificar la respuesta. La función hook recibe la solicitud normalizada, las opciones y un clon de la respuesta como argumentos. El valor devuelto por la función hook será usado por Ky como el objeto de respuesta si es una instancia de [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Podrías hacer algo con la respuesta, por ejemplo, registrar.
				log(response);

				// O devolver una instancia de `Response` para sobrescribir la respuesta.
				return new Response('Una respuesta diferente', {status: 200});
			},

			// O reintentar con un token nuevo ante un error 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Obtener un token nuevo
					const token = await ky('https://example.com/token').text();

					// Reintentar con el token
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
Predeterminado: `true`

Lanza un `HTTPError` cuando, después de seguir redirecciones, la respuesta tiene un código de estado que no es 2xx. Para lanzar también en caso de redirecciones en vez de seguirlas, establece la opción [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) en `'manual'`.

Poner esto en `false` puede ser útil si estás comprobando la disponibilidad de un recurso y esperas respuestas de error.

Nota: Si es `false`, las respuestas de error se consideran exitosas y la solicitud no se reintentará.

##### onDownloadProgress

Tipo: `Function`

Manejador de eventos para el progreso de descarga.

La función recibe estos argumentos:
- `progress` es un objeto con las siguientes propiedades:
- - `percent` es un número entre 0 y 1 que representa el porcentaje de progreso.
- - `transferredBytes` es el número de bytes transferidos hasta el momento.
- - `totalBytes` es el número total de bytes a transferir. Esto es una estimación y puede ser 0 si no se puede determinar el tamaño total.
- `chunk` es una instancia de `Uint8Array` que contiene los datos enviados. Nota: Está vacío en la primera llamada.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Ejemplo de salida:
		// `0% - 0 de 1271 bytes`
		// `100% - 1271 de 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} de ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Tipo: `Function`

Controlador de eventos de progreso de carga.

La función recibe estos argumentos:
- `progress` es un objeto con las siguientes propiedades:
- - `percent` es un número entre 0 y 1 que representa el porcentaje de progreso.
- - `transferredBytes` es el número de bytes transferidos hasta el momento.
- - `totalBytes` es el total de bytes que se van a transferir. Esto es una estimación y puede ser 0 si no se puede determinar el tamaño total.
- `chunk` es una instancia de `Uint8Array` que contiene los datos que se enviaron. Nota: Está vacío en la última llamada.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Salida de ejemplo:
		// `0% - 0 de 1271 bytes`
		// `100% - 1271 de 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} de ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

Tipo: `Function`\
Por defecto: `JSON.parse()`

Función personalizada de análisis de JSON.

Casos de uso:
1. Analizar JSON mediante el paquete [`bourne`](https://github.com/hapijs/bourne) para proteger contra la contaminación de prototipos.
2. Analizar JSON con la opción [`reviver` de `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Tipo: `Function`\
Por defecto: `JSON.stringify()`

Función personalizada para convertir a JSON.

Casos de uso:
1. Convertir a JSON con una función personalizada `replacer`.

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
Por defecto: `fetch`

Función `fetch` definida por el usuario.
Debe ser completamente compatible con el estándar de la [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Casos de uso:
1. Usar implementaciones personalizadas de `fetch` como [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Usar la función envoltorio de `fetch` proporcionada por algunos frameworks que usan renderizado del lado del servidor (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Crea una nueva instancia de `ky` con algunos valores por defecto sobrescritos por los tuyos.

A diferencia de `ky.create()`, `ky.extend()` hereda los valores por defecto de su padre.

Puedes pasar cabeceras como una instancia de `Headers` o como un objeto plano.

Puedes eliminar una cabecera con `.extend()` pasando la cabecera con un valor `undefined`.
Pasar `undefined` como cadena elimina la cabecera solo si proviene de una instancia de `Headers`.

De manera similar, puedes eliminar entradas existentes de `hooks` extendiendo el hook con un `undefined` explícito.

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

También puedes referenciar los valores por defecto del padre proporcionando una función a `.extend()`.

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

Crea una nueva instancia de Ky con valores por defecto completamente nuevos.

```js
import ky from 'ky';

// En https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Tipo: `object`

### ky.stop

Un `Symbol` que puede ser retornado por un hook `beforeRetry` para detener el reintento. Esto también interrumpe los hooks `beforeRetry` restantes.

Nota: Retornar este símbolo hace que Ky aborte y devuelva una respuesta `undefined`. Asegúrate de comprobar la existencia de una respuesta antes de acceder a cualquiera de sus propiedades o utiliza [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). También es incompatible con los métodos del cuerpo, como `.json()` o `.text()`, ya que no hay respuesta para analizar. En general, recomendamos lanzar un error en lugar de retornar este símbolo, ya que eso hará que Ky aborte y luego lance una excepción, lo que evita estas limitaciones.

Un caso de uso válido para `ky.stop` es evitar reintentos al hacer solicitudes para efectos secundarios, donde los datos devueltos no son importantes. Por ejemplo, registrar la actividad del cliente en el servidor.

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
// Ten en cuenta que la respuesta será `undefined` en caso de que se retorne `ky.stop`.
const response = await ky.post('https://example.com', options);

// No se admite el uso de `.text()` u otros métodos de cuerpo.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Expuesto para comprobaciones con `instanceof`. El error tiene una propiedad `response` con el [objeto `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), una propiedad `request` con el [objeto `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), y una propiedad `options` con las opciones normalizadas (ya sea pasadas a `ky` al crear una instancia con `ky.create()` o directamente al realizar la solicitud).

Ten en cuenta que algunos tipos de errores, como los errores de red, implican inherentemente que no se recibió una respuesta. En ese caso, el error no será una instancia de HTTPError y no contendrá una propiedad `response`.

Si necesitas leer la respuesta real cuando ha ocurrido un `HTTPError`, llama al método de análisis respectivo en el objeto response. Por ejemplo:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Acepta un [parámetro de tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opcional, que por defecto es [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), y se pasa al tipo de retorno de `error.response.json()`.

### TimeoutError

El error lanzado cuando la solicitud supera el tiempo de espera. Tiene una propiedad `request` con el [objeto `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Consejos

### Enviar datos de formulario

Enviar datos de formulario en Ky es idéntico a `fetch`. Simplemente pasa una instancia de [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) a la opción `body`. El encabezado `Content-Type` se establecerá automáticamente en `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Si deseas enviar los datos en formato `application/x-www-form-urlencoded`, deberás codificar los datos con [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Establecer un `Content-Type` personalizado

Ky establece automáticamente un encabezado [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) apropiado para cada solicitud según los datos en el cuerpo de la solicitud. Sin embargo, algunas APIs requieren tipos de contenido personalizados o no estándar, como `application/x-amz-json-1.1`. Usando la opción `headers`, puedes sobrescribir manualmente el tipo de contenido.

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

### Cancelación

Fetch (y por lo tanto Ky) tiene soporte integrado para la cancelación de solicitudes mediante la [API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Leer más.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Ejemplo:

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
		console.log('Fetch abortado');
	} else {
		console.error('Error de fetch:', error);
	}
}
```

## Preguntas frecuentes (FAQ)

#### ¿Cómo uso esto en Node.js?

Node.js 18 y versiones posteriores soportan `fetch` de forma nativa, así que puedes usar este paquete directamente.

#### ¿Cómo uso esto con una aplicación web (React, Vue.js, etc.) que utiliza renderizado del lado del servidor (SSR)?

Igual que lo anterior.

#### ¿Cómo pruebo una librería de navegador que usa esto?

Usa un test runner que pueda ejecutarse en el navegador, como Mocha, o utiliza [AVA](https://avajs.dev) con `ky-universal`. [Leer más.](https://github.com/sindresorhus/ky-universal#faq)

#### ¿Cómo uso esto sin un empaquetador como Webpack?

Asegúrate de que tu código se esté ejecutando como un módulo de JavaScript (ESM), por ejemplo usando una etiqueta `<script type="module">` en tu documento HTML. Entonces Ky puede ser importado directamente por ese módulo sin un empaquetador u otras herramientas.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### ¿En qué se diferencia de [`got`](https://github.com/sindresorhus/got)?

Mira mi respuesta [aquí](https://twitter.com/sindresorhus/status/1037406558945042432). Got es mantenido por las mismas personas que Ky.

#### ¿En qué se diferencia de [`axios`](https://github.com/axios/axios)?

Mira mi respuesta [aquí](https://twitter.com/sindresorhus/status/1037763588826398720).

#### ¿En qué se diferencia de [`r2`](https://github.com/mikeal/r2)?

Mira mi respuesta en [#10](https://github.com/sindresorhus/ky/issues/10).

#### ¿Qué significa `ky`?

Es solo un nombre corto aleatorio de paquete npm que logré conseguir. Sin embargo, sí tiene un significado en japonés:

> Una forma de jerga textual, KY es una abreviatura de 空気読めない (kuuki yomenai), que literalmente se traduce como “no puede leer el aire”. Es una frase que se aplica a alguien que no capta el significado implícito.

## Compatibilidad con navegadores

La última versión de Chrome, Firefox y Safari.

## Compatibilidad con Node.js

Node.js 18 y posteriores.

## Relacionados

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Utilidades útiles para trabajar con Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Hooks de Ky para modificar los casos en solicitudes y respuestas de objetos

## Mantenedores

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---