<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky é um cliente HTTP pequeno e elegante baseado na [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky tem como alvo [navegadores modernos](#browser-support), Node.js, Bun e Deno.

É apenas um pacote pequeno, sem dependências.

## Benefícios em relação ao `fetch` puro

- API mais simples
- Atalhos de método (`ky.post()`)
- Trata códigos de status não 2xx como erros (após redirecionamentos)
- Re-tenta solicitações com falha
- Opção JSON
- Suporte a timeout
- Opção de prefixo de URL
- Instâncias com padrões personalizados
- Hooks
- Recursos de TypeScript (por exemplo, `.json()` suporta genéricos e tem como padrão `unknown`, não `any`)

## Instalação

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

Com o `fetch` puro, seria assim:

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

Se você estiver usando [Deno](https://github.com/denoland/deno), importe o Ky de uma URL. Por exemplo, usando um CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

Os parâmetros `input` e `options` são os mesmos do [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), com opções adicionais disponíveis (veja abaixo).

Retorna um [objeto `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) com [métodos de `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) adicionados para conveniência. Assim, você pode, por exemplo, chamar `ky.get(input).json()` diretamente, sem precisar aguardar a `Response` primeiro. Quando chamado desta forma, um cabeçalho `Accept` apropriado será definido dependendo do método de corpo usado. Diferente dos métodos `Body` do `window.Fetch`, estes lançarão um `HTTPError` se o status da resposta não estiver na faixa de `200...299`. Além disso, `.json()` retornará uma string vazia se o corpo estiver vazio ou se o status da resposta for `204`, ao invés de lançar um erro de parsing devido ao corpo vazio.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Aceita um [parâmetro de tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opcional, que tem como padrão [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), e é passado para o tipo de retorno de `.json()`.

```ts
import ky from 'ky';

// user1 é unknown
const user1 = await ky('/api/users/1').json();
// user2 é um User
const user2 = await ky<User>('/api/users/2').json();
// user3 é um User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Define `options.method` para o nome do método e faz uma requisição.

⌨️ **TypeScript:** Aceita um parâmetro de tipo opcional para uso com respostas JSON (veja [`ky()`](#kyinput-options)).

#### input

Tipo: `string` | `URL` | `Request`

Igual ao [input do `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Ao usar uma instância de [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) como `input`, quaisquer opções que alterem a URL (como `prefixUrl`) serão ignoradas.

#### options

Tipo: `object`

Igual às [opções do `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), mais as seguintes opções adicionais:

##### method

Tipo: `string`\
Padrão: `'get'`

Método HTTP usado para fazer a solicitação.

Internamente, os métodos padrões (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` e `DELETE`) são convertidos para maiúsculas para evitar erros de servidor devido à sensibilidade de caixa.

##### json

Tipo: `object` e qualquer outro valor aceito por [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Atalho para envio de JSON. Use isto em vez da opção `body`. Aceita qualquer objeto simples ou valor, que será convertido com `JSON.stringify()` e enviado no corpo com o cabeçalho correto definido.

##### searchParams

Tipo: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Padrão: `''`

Parâmetros de busca a serem incluídos na URL da solicitação. Definir isso irá sobrescrever todos os parâmetros de busca existentes na URL de entrada.

Aceita qualquer valor suportado por [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Tipo: `string | URL`

Um prefixo para ser adicionado à URL de `input` ao fazer a solicitação. Pode ser qualquer URL válida, relativa ou absoluta. Uma barra `/` no final é opcional e será adicionada automaticamente, se necessário, ao ser juntada com o `input`. Só tem efeito quando `input` é uma string. O argumento `input` não pode começar com uma barra `/` ao usar esta opção.

Útil quando usado com [`ky.extend()`](#kyextenddefaultoptions) para criar instâncias Ky específicas para nichos.

```js
import ky from 'ky';

// Em https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Notas:
 - Após juntar `prefixUrl` e `input`, o resultado é resolvido em relação à [URL base](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) da página (se houver).
 - Barras iniciais em `input` não são permitidas ao usar esta opção para garantir consistência e evitar confusão sobre como a URL de `input` é tratada, dado que `input` não seguirá as regras normais de resolução de URL quando `prefixUrl` estiver sendo usado, o que muda o significado de uma barra inicial.

##### retry

Tipo: `object | number`\
Padrão:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Um objeto que representa os campos `limit`, `methods`, `statusCodes`, `afterStatusCodes` e `maxRetryAfter` para contagem máxima de tentativas, métodos permitidos, códigos de status permitidos, códigos de status permitidos para usar o tempo do [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) e tempo máximo de [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Se `retry` for um número, ele será usado como `limit` e os outros padrões permanecerão em vigor.

Se a resposta fornecer um status HTTP contido em `afterStatusCodes`, o Ky aguardará até a data, timeout ou timestamp fornecido no cabeçalho [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) para tentar novamente a requisição. Se `Retry-After` estiver ausente, o cabeçalho não padrão [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) será usado como fallback. Se o código de status fornecido não estiver na lista, o cabeçalho [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) será ignorado.

Se `maxRetryAfter` for definido como `undefined`, será usado `options.timeout`. Se o cabeçalho [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) for maior que `maxRetryAfter`, será usado `maxRetryAfter`.

A opção `backoffLimit` é o limite superior do atraso por tentativa em milissegundos.
Para limitar o atraso, defina `backoffLimit` como 1000, por exemplo.
Por padrão, o atraso é calculado com `0.3 * (2 ** (attemptCount - 1)) * 1000`. O atraso aumenta exponencialmente.

A opção `delay` pode ser usada para alterar como o atraso entre as tentativas é calculado. A função recebe um parâmetro, a contagem de tentativas, começando em `1`.

Tentativas de repetição não são disparadas após um [timeout](#timeout).

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
Padrão: `10000`

Tempo limite em milissegundos para obter uma resposta, incluindo qualquer tentativa de repetição. Não pode ser maior que 2147483647.
Se definido como `false`, não haverá tempo limite.

##### hooks

Tipo: `object<string, Function[]>`\
Padrão: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks permitem modificações durante o ciclo de vida da requisição. As funções dos hooks podem ser assíncronas e são executadas em série.

###### hooks.beforeRequest

Tipo: `Function[]`\
Padrão: `[]`

Este hook permite modificar a requisição logo antes de ser enviada. O Ky não fará mais alterações na requisição após isso. A função do hook recebe `request` e `options` como argumentos. Você pode, por exemplo, modificar os `request.headers` aqui.

O hook pode retornar um [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) para substituir a requisição de saída, ou retornar um [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) para evitar completamente a realização de uma requisição HTTP. Isso pode ser usado para simular uma requisição, verificar um cache interno etc. Uma consideração **importante** ao retornar uma requisição ou resposta deste hook é que quaisquer hooks `beforeRequest` restantes serão ignorados, então talvez você queira retorná-los apenas no último hook.

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
Padrão: `[]`

Este hook permite modificar a requisição logo antes de uma nova tentativa. O Ky não fará mais alterações na requisição após isso. A função do hook recebe um objeto com a requisição normalizada e opções, uma instância de erro e a contagem de tentativas. Você pode, por exemplo, modificar os `request.headers` aqui.

Se a requisição recebeu uma resposta, o erro será do tipo `HTTPError` e o objeto `Response` estará disponível em `error.response`. Esteja ciente de que alguns tipos de erros, como erros de rede, significam inerentemente que uma resposta não foi recebida. Nesse caso, o erro não será uma instância de `HTTPError`.

Você pode impedir que o Ky tente novamente a requisição lançando um erro. O Ky não irá tratá-lo de nenhuma forma e o erro será propagado para quem iniciou a requisição. O restante dos hooks `beforeRetry` não será chamado nesse caso. Alternativamente, você pode retornar o símbolo [`ky.stop`](#kystop) para fazer o mesmo, mas sem propagar um erro (isso possui algumas limitações, veja a documentação de `ky.stop` para detalhes).

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
Padrão: `[]`

Este hook permite modificar o `HTTPError` logo antes de ele ser lançado. A função do hook recebe um `HTTPError` como argumento e deve retornar uma instância de `HTTPError`.

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
Padrão: `[]`

Este hook permite ler e opcionalmente modificar a resposta. A função do hook recebe a requisição normalizada, as opções e um clone da resposta como argumentos. O valor de retorno da função do hook será usado pelo Ky como objeto de resposta se for uma instância de [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Você pode fazer algo com a resposta, por exemplo, logar.
				log(response);

				// Ou retornar uma instância de `Response` para sobrescrever a resposta.
				return new Response('Uma resposta diferente', {status: 200});
			},

			// Ou tentar novamente com um token novo em caso de erro 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Obter um novo token
					const token = await ky('https://example.com/token').text();

					// Tentar novamente com o token
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
Padrão: `true`

Lança um `HTTPError` quando, após seguir redirecionamentos, a resposta tem um código de status não-2xx. Para também lançar erro em redirecionamentos em vez de segui-los, defina a opção [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) como `'manual'`.

Definir isto como `false` pode ser útil se você está checando a disponibilidade de um recurso e espera respostas de erro.

Nota: Se `false`, respostas de erro são consideradas bem-sucedidas e a requisição não será tentada novamente.

##### onDownloadProgress

Tipo: `Function`

Manipulador de evento de progresso de download.

A função recebe estes argumentos:
- `progress` é um objeto com as seguintes propriedades:
- - `percent` é um número entre 0 e 1 representando a porcentagem do progresso.
- - `transferredBytes` é o número de bytes transferidos até o momento.
- - `totalBytes` é o total estimado de bytes a serem transferidos. Este valor pode ser 0 se o tamanho total não puder ser determinado.
- `chunk` é uma instância de `Uint8Array` contendo os dados enviados. Nota: Está vazio na primeira chamada.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Exemplo de saída:
		// `0% - 0 de 1271 bytes`
		// `100% - 1271 de 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} de ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Tipo: `Function`
Manipulador de evento de progresso de upload.

A função recebe os seguintes argumentos:
- `progress` é um objeto com as seguintes propriedades:
- - `percent` é um número entre 0 e 1 representando a porcentagem de progresso.
- - `transferredBytes` é o número de bytes transferidos até o momento.
- - `totalBytes` é o total de bytes a serem transferidos. Isso é uma estimativa e pode ser 0 se o tamanho total não puder ser determinado.
- `chunk` é uma instância de `Uint8Array` contendo os dados que foram enviados. Nota: Está vazio na última chamada.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Exemplo de saída:
		// `0% - 0 de 1271 bytes`
		// `100% - 1271 de 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} de ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

Tipo: `Function`\
Padrão: `JSON.parse()`

Função de análise de JSON definida pelo usuário.

Casos de uso:
1. Analisar JSON via o pacote [`bourne`](https://github.com/hapijs/bourne) para proteger contra poluição de protótipo.
2. Analisar JSON com a opção [`reviver` do `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Tipo: `Function`\
Padrão: `JSON.stringify()`

Função de serialização de JSON definida pelo usuário.

Casos de uso:
1. Serializar JSON com uma função `replacer` personalizada.

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
Padrão: `fetch`

Função `fetch` definida pelo usuário.
Precisa ser totalmente compatível com o padrão da [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Casos de uso:
1. Usar implementações personalizadas de `fetch` como [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Usar a função wrapper de `fetch` fornecida por alguns frameworks que utilizam renderização do lado do servidor (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Crie uma nova instância do `ky` com alguns padrões substituídos pelos seus próprios.

Em contraste com `ky.create()`, `ky.extend()` herda os padrões de seu pai.

Você pode passar cabeçalhos como uma instância de `Headers` ou um objeto simples.

Você pode remover um cabeçalho com `.extend()` passando o cabeçalho com valor `undefined`.
Passar `undefined` como string remove o cabeçalho apenas se ele vier de uma instância de `Headers`.

Da mesma forma, você pode remover entradas existentes de `hooks` estendendo o hook com um `undefined` explícito.

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

Você também pode referenciar padrões do pai fornecendo uma função para `.extend()`.

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

Crie uma nova instância Ky com padrões totalmente novos.

```js
import ky from 'ky';

// Em https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Tipo: `object`

### ky.stop

Um `Symbol` que pode ser retornado por um hook `beforeRetry` para interromper a repetição. Isso também interrompe os hooks `beforeRetry` restantes.

Nota: Retornar esse símbolo faz o Ky abortar e retornar com uma resposta `undefined`. Certifique-se de verificar uma resposta antes de acessar qualquer propriedade nela ou use [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Também é incompatível com métodos de corpo, como `.json()` ou `.text()`, porque não há resposta para analisar. Em geral, recomendamos lançar um erro em vez de retornar esse símbolo, pois isso fará com que o Ky aborte e lance, evitando essas limitações.

Um caso de uso válido para `ky.stop` é prevenir tentativas de repetição ao fazer requisições para efeitos colaterais, onde os dados retornados não são importantes. Por exemplo, registrar atividade do cliente no servidor.

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
// Note que `response` será `undefined` caso `ky.stop` seja retornado.
const response = await ky.post('https://example.com', options);

// O uso de `.text()` ou outros métodos de corpo não é suportado.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Exposto para verificações com `instanceof`. O erro possui uma propriedade `response` com o [objeto `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), propriedade `request` com o [objeto `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), e propriedade `options` com as opções normalizadas (sejam passadas para o `ky` ao criar uma instância com `ky.create()` ou diretamente ao realizar a requisição).

Esteja ciente de que alguns tipos de erros, como erros de rede, significam inerentemente que uma resposta não foi recebida. Nesse caso, o erro não será uma instância de HTTPError e não conterá uma propriedade `response`.

Se você precisar ler a resposta real quando um `HTTPError` ocorrer, chame o método de análise respectivo no objeto response. Por exemplo:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Aceita um [parâmetro de tipo](https://www.typescriptlang.org/docs/handbook/2/generics.html) opcional, que por padrão é [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), e é repassado para o tipo de retorno de `error.response.json()`.

### TimeoutError

O erro lançado quando a requisição atinge o tempo limite. Possui uma propriedade `request` com o [objeto `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Dicas

### Enviando dados de formulário

Enviar dados de formulário no Ky é idêntico ao `fetch`. Basta passar uma instância de [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) para a opção `body`. O cabeçalho `Content-Type` será automaticamente definido como `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Se você quiser enviar os dados no formato `application/x-www-form-urlencoded`, será necessário codificar os dados com [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Definindo um `Content-Type` personalizado

Ky define automaticamente um cabeçalho [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) apropriado para cada requisição com base nos dados enviados no corpo da requisição. No entanto, algumas APIs exigem tipos de conteúdo personalizados e não padronizados, como `application/x-amz-json-1.1`. Usando a opção `headers`, você pode sobrescrever manualmente o tipo de conteúdo.

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

### Cancelamento

Fetch (e, portanto, Ky) possui suporte nativo ao cancelamento de requisições através da [API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Leia mais.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Exemplo:

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
		console.error('Erro no fetch:', error);
	}
}
```

## FAQ

#### Como uso isso no Node.js?

Node.js 18 e posteriores suportam `fetch` nativamente, então você pode usar este pacote diretamente.

#### Como uso isso em um app web (React, Vue.js, etc.) que usa server-side rendering (SSR)?

O mesmo que acima.

#### Como faço testes em uma biblioteca de navegador que usa isso?

Use um test runner que possa rodar no navegador, como Mocha, ou utilize [AVA](https://avajs.dev) com `ky-universal`. [Leia mais.](https://github.com/sindresorhus/ky-universal#faq)

#### Como uso isso sem um empacotador como Webpack?

Certifique-se de que seu código está rodando como um módulo JavaScript (ESM), por exemplo, usando uma tag `<script type="module">` em seu documento HTML. Assim, o Ky pode ser importado diretamente por esse módulo sem um empacotador ou outras ferramentas.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Em que é diferente de [`got`](https://github.com/sindresorhus/got)

Veja minha resposta [aqui](https://twitter.com/sindresorhus/status/1037406558945042432). Got é mantido pelas mesmas pessoas que Ky.

#### Em que é diferente de [`axios`](https://github.com/axios/axios)?

Veja minha resposta [aqui](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Em que é diferente de [`r2`](https://github.com/mikeal/r2)?

Veja minha resposta em [#10](https://github.com/sindresorhus/ky/issues/10).

#### O que significa `ky`?

É apenas um nome curto e aleatório que consegui no npm. No entanto, tem um significado em japonês:

> Uma forma de gíria, KY é a abreviação de 空気読めない (kuuki yomenai), que literalmente significa “não consegue ler o ar”. É uma frase aplicada a alguém que não percebe o significado implícito.

## Suporte a navegadores

A versão mais recente do Chrome, Firefox e Safari.

## Suporte a Node.js

Node.js 18 e posteriores.

## Relacionados

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Utilitários úteis para trabalhar com Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Hooks do Ky para modificar casos em requisições e respostas de objetos

## Mantenedores

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---