# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

より優れた fetch API。Node、ブラウザ、ワーカーで動作します。

<details>
  <summary>ネタバレ</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 クイックスタート

インストール:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

インポート:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Node.js で動作

[条件付きエクスポート](https://nodejs.org/api/packages.html#packages_conditional_exports)を使用して Node.js を検出し、自動的に [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) を利用します。`globalThis.fetch` が利用可能な場合は、そちらが優先されます。Node.js 17.5.0 の実験的なネイティブ fetch API を利用するには [`--experimental-fetch` フラグ](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch)を使用してください。

## ✔️ レスポンスのパース

`ofetch` は [destr](https://github.com/unjs/destr) を使用して、JSON やネイティブ値をスマートにパースし、失敗した場合はテキストにフォールバックします。

```js
const { users } = await ofetch("/api/users");
```

バイナリコンテンツタイプの場合、`ofetch` は `Blob` オブジェクトを返します。

任意で `destr` 以外のパーサーを指定したり、`blob`、`arrayBuffer`、`text` を指定して、それぞれの `FetchResponse` メソッドでボディのパースを強制することもできます。

```js
// JSON.parse を使用
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// テキストをそのまま返す
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// レスポンスの blob バージョンを取得
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON ボディ

`body` オプションにオブジェクトまたは `.toJSON()` メソッドを持つクラスを渡した場合、`ofetch` は自動的に文字列化します。

`ofetch` は `JSON.stringify()` を利用して、渡されたオブジェクトを変換します。`.toJSON()` メソッドのないクラスは、`body` オプションに渡す前に文字列値へ変換しておく必要があります。

`PUT`、`PATCH`、`POST` リクエストメソッドの場合、ボディに文字列またはオブジェクトが設定されていると、`ofetch` はデフォルトで `content-type: "application/json"` および `accept: "application/json"` ヘッダーを追加します（上書きも可能です）。

さらに、`ofetch` は `Buffer`、`ReadableStream`、`Stream`、および [対応するボディタイプ](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body)でのバイナリレスポンスもサポートします。ストリーミング対応のため、`duplex: "half"` オプションも自動的に設定します！

**例:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ エラー処理

`ofetch` は、`response.ok` が `false` の場合、自動的にエラーをスローし、分かりやすいエラーメッセージと簡潔なスタックトレース（内部処理を隠す）を表示します。

パースされたエラーボディは `error.data` で利用できます。また、`FetchError` 型も使用可能です。

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

エラーレスポンスをキャッチするには:

```ts
await ofetch("/url").catch((error) => error.data);
```

ステータスエラーのキャッチを回避するには、`ignoreResponseError` オプションを設定します:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ 自動リトライ

`ofetch` は、エラーが発生し、レスポンスのステータスコードが `retryStatusCodes` リストに含まれている場合、自動的にリクエストをリトライします。

**リトライ対象ステータスコード:**

- `408` - リクエストタイムアウト
- `409` - コンフリクト
- `425` - 早すぎる ([実験的](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - リクエストが多すぎる
- `500` - サーバ内部エラー
- `502` - 不正なゲートウェイ
- `503` - サービス利用不可
- `504` - ゲートウェイタイムアウト

`retry` および `retryDelay` オプションを使用してリトライ回数とリトライ間隔を指定でき、`retryStatusCodes` オプションでカスタムのステータスコード配列も指定できます。

`retry` のデフォルトは `1` 回のリトライですが、`POST`、`PUT`、`PATCH`、`DELETE` メソッドの場合は副作用を避けるためデフォルトでリトライしません。`retry` にカスタム値を設定すると、**全てのリクエストに対して常にリトライ** します。

`retryDelay` のデフォルトは `0` ミリ秒です。

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ミリ秒
  retryStatusCodes: [ 404, 500 ], // リトライするレスポンスステータスコード
});
```

## ✔️ タイムアウト

`timeout` をミリ秒単位で指定すると、指定時間後に自動的にリクエストを中断できます（デフォルトは無効）。

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3秒後にタイムアウト
});
```

## ✔️ 型安全

レスポンスは型アシストが利用可能です:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// article.id でオートコンプリートが動作
```

## ✔️ `baseURL` の追加

`baseURL` オプションを使用することで、[ufo](https://github.com/unjs/ufo) を使い、`ofetch` は baseURL の末尾・先頭スラッシュやクエリ検索パラメータを補完します:

```js
await ofetch("/config", { baseURL });
```

## ✔️ クエリ検索パラメータの追加

`query` オプション（またはエイリアスの `params`）を使うことで、[ufo](https://github.com/unjs/ufo) を利用し、リクエストのクエリを保持したまま URL にクエリ検索パラメータを追加できます:

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ インターセプター

`ofetch` 呼び出しのライフサイクルイベントにフックするための非同期インターセプターを提供できます。

共通のインターセプターを設定する場合は `ofetch.create` を使うことを推奨します。

### `onRequest({ request, options })`

`onRequest` は `ofetch` が呼び出されるとすぐに実行され、オプションの変更や簡単なロギングが可能です。

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // リクエストをログ出力
    console.log("[fetch request]", request, options);

    // クエリ検索パラメータに `?t=1640125211170` を追加
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` は fetch リクエストが失敗した際に呼び出されます。
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // エラーをログ出力
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse`は、`fetch`呼び出しとボディのパース後に呼び出されます。

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // レスポンスをログ出力
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError`は`onResponse`と同じですが、fetchが実行され、かつ`response.ok`が`true`でない場合に呼び出されます。

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // エラーをログ出力
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### インターセプターの配列を渡す

必要に応じて、順番に呼び出される関数の配列を渡すことも可能です。

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* 何か処理を行う */
    },
    () => {
      /* 別の処理を行う */
    },
  ],
});
```

## ✔️ デフォルトオプション付きのfetchを作成

このユーティリティは、複数のfetch呼び出しで共通のオプションを使う必要がある場合に便利です。

**注意:** デフォルトは一階層でクローンされ、継承されます。`headers`のようなネストされたオプションには注意してください。

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // ofetch('/test', { baseURL: '/api' }) と同じ
```

## 💡 ヘッダーの追加

`headers`オプションを使うことで、`ofetch`はリクエストのデフォルトヘッダーに加えて追加ヘッダーを設定します。

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 生のレスポンスへアクセス

ヘッダーなどのために生のレスポンスへアクセスする必要がある場合は、`ofetch.raw`を使うことができます。

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 ネイティブFetchの使用

ショートカットとして、ネイティブの`fetch`APIを提供する`ofetch.native`を利用できます。

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ HTTP(S) エージェントの追加

Node.js（>= 18）環境では、カスタムディスパッチャーを指定してリクエストをインターセプトし、プロキシや自己署名証明書などの機能をサポートできます。この機能はNode.jsに組み込まれている [undici](https://undici.nodejs.org/) により有効化されています。Dispatcher API については[こちら](https://undici.nodejs.org/#/docs/api/Dispatcher)を参照してください。

利用可能なエージェントの例:

- `ProxyAgent`: Agent API を実装したプロキシエージェントクラスです。シンプルな方法でプロキシ経由の接続を可能にします。([ドキュメント](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Agent API を実装したモックエージェントクラスです。undici 経由の HTTP リクエストをインターセプトし、モックレスポンスを返すことができます。([ドキュメント](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: 複数の異なるオリジンに対してリクエストをディスパッチできます。([ドキュメント](https://undici.nodejs.org/#/docs/api/Agent))

**例:** 1つのリクエストにプロキシエージェントを設定する:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**例:** プロキシ有効なカスタム fetch インスタンスを作成する:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**例:** すべてのリクエストにプロキシエージェントを設定する:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**例:** 自己署名証明書を許可する（自己責任でご利用ください！）

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// 注意: これにより MITM 攻撃に対して fetch が安全でなくなります。自己責任でご利用ください！
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

古い Node.js バージョン（<18）では、`agent` を使用することもできます:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` サポート（Node < 18 のみ有効）

`FETCH_KEEP_ALIVE` 環境変数を `true` に設定することで、未処理のリクエストがなくてもソケットを維持し、将来のリクエストで TCP 接続を再確立せずに利用できる HTTP/HTTPS エージェントが登録されます。

**注意:** このオプションはメモリリークを引き起こす可能性があります。[node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325) をご確認ください。

## 📦 バンドラーノート

- すべてのターゲットは Module および CommonJS 形式、名前付きエクスポートでエクスポートされています
- モダンな構文維持のため、エクスポートはトランスパイルされていません
  - ES5 サポートが必要な場合は、`ofetch`, `destr`, `ufo` パッケージを Babel でトランスパイルする必要があります
- レガシーブラウザ対応には、[unfetch](https://github.com/developit/unfetch) などを使い `fetch` グローバルをポリフィルしてください

## ❓ FAQ

**なぜエクスポート名が `fetch` ではなく `ofetch` なのですか？**

`fetch` と同じ名前を使うと API が異なるため混乱を招く可能性がありますが、fetch であることに違いはないので、できるだけ近い代替案として `ofetch` を利用しています。ただし、`ofetch` から `{ fetch }` をインポートすることもでき、Node.js では自動的にポリフィルされ、それ以外ではネイティブが使われます。

**なぜデフォルトエクスポートがないのですか？**

デフォルトエクスポートは CommonJS エクスポートと混在すると常にリスクがあります。

この方針により、パッケージを壊すことなく他のユーティリティを追加でき、`ofetch` という名前の利用も促進できます。

**なぜトランスパイルされていないのですか？**

ライブラリをトランスパイルすると、ほとんどのユーザーには不要なレガシーコードによってウェブの進化を妨げてしまいます。

レガシーユーザーをサポートする必要がある場合は、ビルドパイプラインでライブラリを任意にトランスパイルしてください。
```
## ライセンス

MIT。💖で作られました

<!-- バッジ -->

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