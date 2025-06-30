# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Uma API fetch melhor. Funciona em node, navegador e workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Início Rápido

Instale:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Importe:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Funciona com Node.js

Usamos [exports condicionais](https://nodejs.org/api/packages.html#packages_conditional_exports) para detectar o Node.js
e usar automaticamente [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Se `globalThis.fetch` estiver disponível, será usado em vez disso. Para aproveitar a API experimental fetch nativa do Node.js 17.5.0, use a flag [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Fazendo Parsing da Resposta

`ofetch` irá analisar inteligentemente valores JSON e nativos usando [destr](https://github.com/unjs/destr), voltando para texto caso não consiga analisar.

```js
const { users } = await ofetch("/api/users");
```

Para tipos de conteúdo binário, `ofetch` irá retornar um objeto `Blob`.

Você pode opcionalmente fornecer um parser diferente de `destr`, ou especificar `blob`, `arrayBuffer` ou `text` para forçar o parsing do corpo com o respectivo método do `FetchResponse`.

```js
// Usar JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Retornar texto como está
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Obter a versão blob da resposta
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Corpo JSON

Se um objeto ou uma classe com método `.toJSON()` for passado para a opção `body`, `ofetch` irá automaticamente convertê-lo em string.

`ofetch` utiliza `JSON.stringify()` para converter o objeto passado. Classes sem método `.toJSON()` precisam ser convertidas para string antecipadamente antes de serem passadas para a opção `body`.

Para métodos de requisição `PUT`, `PATCH` e `POST`, quando um corpo string ou objeto é definido, `ofetch` adiciona os headers padrão `content-type: "application/json"` e `accept: "application/json"` (que você pode sempre sobrescrever).

Adicionalmente, `ofetch` suporta respostas binárias com `Buffer`, `ReadableStream`, `Stream` e [tipos de corpo compatíveis](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` irá automaticamente definir a opção `duplex: "half"` para suporte a streaming!

**Exemplo:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Tratamento de Erros

`ofetch` lança automaticamente erros quando `response.ok` é `false`, com uma mensagem de erro amigável e stack compacta (ocultando detalhes internos).

Um corpo de erro já analisado está disponível em `error.data`. Você também pode usar o tipo `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Para capturar a resposta de erro:

```ts
await ofetch("/url").catch((error) => error.data);
```

Para ignorar o tratamento de erro de status, você pode definir a opção `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Repetição Automática

O `ofetch` automaticamente repete a requisição se ocorrer um erro e se o código de status da resposta estiver incluído na lista `retryStatusCodes`:

**Códigos de status para repetição:**

- `408` - Tempo de Requisição Esgotado
- `409` - Conflito
- `425` - Muito Cedo ([Experimental](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Muitas Requisições
- `500` - Erro Interno do Servidor
- `502` - Gateway Inválido
- `503` - Serviço Indisponível
- `504` - Tempo de Resposta do Gateway Esgotado

Você pode especificar a quantidade de tentativas e o atraso entre elas usando as opções `retry` e `retryDelay`, e também passar um array personalizado de códigos usando a opção `retryStatusCodes`.

O padrão para `retry` é `1` repetição, exceto para os métodos `POST`, `PUT`, `PATCH` e `DELETE`, nos quais o `ofetch` não repete por padrão para evitar introduzir efeitos colaterais. Se você definir um valor personalizado para `retry`, ele **sempre irá repetir** para todas as requisições.

O padrão para `retryDelay` é `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // códigos de status da resposta para repetir
});
```

## ✔️ Timeout

Você pode especificar o `timeout` em milissegundos para abortar automaticamente uma requisição após o tempo limite (o padrão é desabilitado).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Timeout após 3 segundos
});
```

## ✔️ Compatível com Tipos

A resposta pode ser assistida por tipos:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Auto complete funcionando com article.id
```

## ✔️ Adicionando `baseURL`

Usando a opção `baseURL`, o `ofetch` a adiciona antes das barras finais/iniciais e parâmetros de busca na baseURL utilizando [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Adicionando Parâmetros de Busca

Usando a opção `query` (ou `params` como alias), o `ofetch` adiciona parâmetros de busca à URL preservando a query na própria requisição usando [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptadores

É possível fornecer interceptadores assíncronos para se conectar aos eventos do ciclo de vida da chamada do `ofetch`.

Você pode querer usar `ofetch.create` para definir interceptadores compartilhados.

### `onRequest({ request, options })`

`onRequest` é chamado assim que o `ofetch` é chamado, permitindo que você modifique opções ou faça um simples log.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Log da requisição
    console.log("[fetch request]", request, options);

    // Adiciona `?t=1640125211170` aos parâmetros de busca
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` será chamado quando a requisição fetch falhar.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Registrar erro
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` será chamado após a chamada do `fetch` e o parsing do corpo.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Registrar resposta
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` é igual ao `onResponse`, mas será chamado quando o fetch ocorrer e `response.ok` não for `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Registrar erro
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Passando array de interceptadores

Se necessário, também é possível passar um array de funções que serão chamadas sequencialmente.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Faça algo */
    },
    () => {
      /* Faça outra coisa */
    },
  ],
});
```

## ✔️ Criar fetch com opções padrão

Este utilitário é útil se você precisa usar opções comuns em várias chamadas fetch.

**Nota:** Os padrões serão clonados em um nível e herdados. Tenha cuidado com opções aninhadas como `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Igual a ofetch('/test', { baseURL: '/api' })
```

## 💡 Adicionando cabeçalhos

Ao usar a opção `headers`, o `ofetch` adiciona cabeçalhos extras além dos cabeçalhos padrão da requisição:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Acesso à Resposta Bruta

Se você precisa acessar a resposta bruta (para cabeçalhos, etc), pode usar `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Usando Fetch Nativo

Como atalho, você pode usar `ofetch.native`, que fornece a API nativa do `fetch`

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Adicionando Agente HTTP(S)

Em ambientes Node.js (>= 18), você pode fornecer um dispatcher personalizado para interceptar requisições e suportar recursos como Proxy e certificados autoassinados. Este recurso é habilitado pelo [undici](https://undici.nodejs.org/) embutido no Node.js. [leia mais](https://undici.nodejs.org/#/docs/api/Dispatcher) sobre a API Dispatcher.

Alguns agentes disponíveis:

- `ProxyAgent`: Uma classe de Agente Proxy que implementa a API Agent. Permite a conexão através de um proxy de forma simples. ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Uma classe de Agente mockada que implementa a API Agent. Permite interceptar requisições HTTP feitas através do undici e retornar respostas simuladas. ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: O Agent permite o envio de requisições contra múltiplas origens diferentes. ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**Exemplo:** Definir um agente proxy para uma requisição:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Exemplo:** Criar uma instância fetch personalizada com proxy habilitado:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Exemplo:** Definir um agente proxy para todas as requisições:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Exemplo:** Permitir certificados autoassinados (USE POR SUA CONTA E RISCO!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Nota: Isto torna o fetch inseguro contra ataques MITM. USE POR SUA CONTA E RISCO!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Em versões antigas do Node.js (<18), você também pode usar `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Suporte a `keepAlive` (funciona apenas para Node < 18)

Definindo a variável de ambiente `FETCH_KEEP_ALIVE` como `true`, um agente HTTP/HTTPS será registrado que mantém os sockets ativos mesmo quando não há requisições pendentes, para que possam ser usados em requisições futuras sem precisar reestabelecer uma conexão TCP.

**Nota:** Esta opção pode potencialmente introduzir vazamentos de memória. Por favor, confira [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Notas sobre Bundler

- Todos os targets são exportados nos formatos Module e CommonJS e com exports nomeados
- Nenhuma exportação é transpilada em prol da sintaxe moderna
  - Provavelmente você precisará transpilar os pacotes `ofetch`, `destr` e `ufo` com Babel para suporte ao ES5
- Você precisa fazer o polyfill do global `fetch` para suportar navegadores antigos, como usando [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Por que o export se chama `ofetch` em vez de `fetch`?**

Usar o mesmo nome `fetch` pode ser confuso, já que a API é diferente, mas ainda assim é um fetch, então usamos a alternativa mais próxima possível. Porém, você pode importar `{ fetch }` de `ofetch`, que é auto-polyfill para Node.js e usa o nativo caso contrário.

**Por que não há exportação default?**

Exports default são sempre arriscados de serem misturados com exports CommonJS.

Isso também garante que possamos introduzir mais utilitários sem quebrar o pacote e também encoraja o uso do nome `ofetch`.

**Por que não é transpilado?**

Ao transpilar bibliotecas, empurramos a web para trás com código legado que não é necessário para a maioria dos usuários.

Se você precisa dar suporte a usuários legados, pode, opcionalmente, transpilar a biblioteca no seu pipeline de build.
```
## Licença

MIT. Feito com 💖

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