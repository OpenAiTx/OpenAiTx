<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky は [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) に基づく小さくてエレガントな HTTP クライアントです。

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky は [モダンブラウザ](#browser-support)、Node.js、Bun、Deno をターゲットにしています。

依存関係のない小さなパッケージです。

## プレーンな `fetch` より優れている点

- シンプルな API
- メソッドショートカット（`ky.post()` など）
- 2xx 以外のステータスコードをエラーとして扱う（リダイレクト後）
- 失敗したリクエストのリトライ
- JSON オプション
- タイムアウト対応
- URL プレフィックスオプション
- カスタムデフォルトを持つインスタンス
- フック
- TypeScript との親和性（例：`.json()` はジェネリクスをサポートし、デフォルトは `any` ではなく `unknown`）

## インストール

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## 使い方

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

プレーンな `fetch` で書くと、次のようになります:

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

[Deno](https://github.com/denoland/deno) を利用する場合は、URL から Ky をインポートしてください。例えば CDN を利用する場合:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` と `options` は [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) と同じですが、追加の `options` も利用できます（下記参照）。

[`Response` オブジェクト](https://developer.mozilla.org/en-US/docs/Web/API/Response) を返し、利便性のために [`Body` メソッド](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) が追加されています。したがって、例えば `ky.get(input).json()` のように、まず `Response` を await せずに直接呼び出すことができます。このように呼び出すと、使用されるボディメソッドに応じて適切な `Accept` ヘッダーが設定されます。`window.Fetch` の `Body` メソッドとは異なり、レスポンスステータスが `200...299` の範囲外の場合は `HTTPError` をスローします。また、`.json()` はボディが空の場合やレスポンスステータスが `204` の場合、パースエラーをスローする代わりに空文字列を返します。

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** オプションの [型パラメータ](https://www.typescriptlang.org/docs/handbook/2/generics.html) を受け付けます（デフォルトは [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)）。この型は `.json()` の戻り値の型として反映されます。

```ts
import ky from 'ky';

// user1 の型は unknown
const user1 = await ky('/api/users/1').json();
// user2 の型は User
const user2 = await ky<User>('/api/users/2').json();
// user3 の型は User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

`options.method` をメソッド名に設定してリクエストを実行します。

⌨️ **TypeScript:** JSON レスポンスと併用するためのオプションの型パラメータを受け付けます（[`ky()`](#kyinput-options) を参照）。

#### input

型: `string` | `URL` | `Request`

[`fetch` の input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input) と同じです。

[`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) インスタンスを `input` として使用する場合、URL を変更するオプション（`prefixUrl` など）は無視されます。

#### options

型: `object`

[`fetch` の options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options) と同じですが、以下の追加オプションがあります:

##### method

型: `string`\
デフォルト: `'get'`

リクエストで使用する HTTP メソッド。

内部的には、標準メソッド（`GET`, `POST`, `PUT`, `PATCH`, `HEAD`, `DELETE`）は大文字に変換され、サーバーの大文字小文字区別によるエラーを回避します。

##### json

型: `object` および [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) で受け付けられるその他の値

JSON を送信するためのショートカットです。`body` オプションの代わりにこちらを使用してください。プレーンなオブジェクトや値を受け付け、`JSON.stringify()` された上で正しいヘッダーとともにボディに送信されます。

##### searchParams

型: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
デフォルト: `''`

リクエスト URL に含める検索パラメータ。これを設定すると、input URL に存在するすべての検索パラメータが上書きされます。

[`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) でサポートされているすべての値を受け付けます。

##### prefixUrl

型: `string | URL`

リクエスト時に `input` URL の前に付加するプレフィックス。相対または絶対の有効な URL であれば何でも指定できます。末尾のスラッシュ `/` は任意で、必要に応じて自動的に追加されます。`input` が文字列の場合のみ有効です。このオプションを使用する場合、`input` 引数はスラッシュ `/` で始めてはいけません。

[`ky.extend()`](#kyextenddefaultoptions) と組み合わせて、用途に応じた Ky インスタンスを作成する際に便利です。

```js
import ky from 'ky';

// https://example.com で

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

注意事項:
 - `prefixUrl` と `input` が結合された後、その結果はページの [ベースURL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI)（存在する場合）を基準に解決されます。
 - このオプションを使用する場合、`input` の先頭にスラッシュを付けることは禁止されています。これは一貫性を持たせるためと、`prefixUrl` 使用時は通常の URL 解決ルールが適用されず、スラッシュの意味が変わるため混乱を避けるためです。

##### retry

型: `object | number`\
デフォルト:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

`limit`、`methods`、`statusCodes`、`afterStatusCodes`、および `maxRetryAfter` フィールドを表すオブジェクトで、最大リトライ回数、許可されるメソッド、許可されるステータスコード、[`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 時間を使用できるステータスコード、最大の [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) 時間を指定します。

`retry` が数値の場合、その値が `limit` として使用され、その他のデフォルト値はそのまま適用されます。

レスポンスが `afterStatusCodes` に含まれる HTTP ステータスを返した場合、Ky は [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) ヘッダーで指定された日時、タイムアウト、またはタイムスタンプが経過するまでリクエストの再試行を待ちます。`Retry-After` が存在しない場合、標準外の [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) ヘッダーが代わりにフォールバックとして使用されます。指定されたステータスコードがリストにない場合、[`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) ヘッダーは無視されます。

`maxRetryAfter` が `undefined` に設定されている場合は、`options.timeout` が使用されます。[`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) ヘッダーの値が `maxRetryAfter` より大きい場合は、`maxRetryAfter` が使用されます。

`backoffLimit` オプションは、リトライごとのディレイ（遅延）の上限（ミリ秒単位）です。
遅延を制限するには、例えば `backoffLimit` を 1000 に設定します。
デフォルトでは、遅延は `0.3 * (2 ** (attemptCount - 1)) * 1000` で計算されます。遅延は指数関数的に増加します。

`delay` オプションを使うことで、リトライ間の遅延の計算方法を変更できます。この関数は、1 から始まる試行回数をパラメータとして受け取ります。

[タイムアウト](#timeout) 発生後にはリトライは実行されません。

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

型: `number | false`\
デフォルト: `10000`

レスポンス取得までのタイムアウト（ミリ秒単位）。リトライも含みます。2147483647 より大きい値は指定できません。
`false` に設定するとタイムアウトは発生しません。

##### hooks

型: `object<string, Function[]>`\
デフォルト: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

フックはリクエストライフサイクル中の変更を可能にします。フック関数は非同期でもよく、直列で実行されます。

###### hooks.beforeRequest

型: `Function[]`\
デフォルト: `[]`

このフックにより、リクエスト送信直前にリクエストを変更できます。Ky はこの後、リクエストに変更を加えません。フック関数は `request` と `options` を引数に受け取ります。例えば、ここで `request.headers` を変更できます。

このフックは、送信するリクエストを置き換えるために [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) を返すか、HTTP リクエスト自体を完全に回避するために [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) を返すことができます。これにより、リクエストのモックや内部キャッシュの確認などが可能です。このフックからリクエストまたはレスポンスを返す場合、残りの `beforeRequest` フックはスキップされるため、最後のフックでのみ返すことを推奨します。

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

型: `Function[]`\
デフォルト: `[]`

このフックにより、リトライ直前にリクエストを変更できます。Ky はこの後、リクエストに変更を加えません。フック関数は正規化されたリクエストとオプション、エラーインスタンス、リトライ回数を含むオブジェクトを受け取ります。ここで `request.headers` を変更することもできます。

リクエストがレスポンスを受信している場合、エラーは `HTTPError` 型となり、`error.response` で `Response` オブジェクトが利用できます。ネットワークエラーなど一部のエラーはレスポンスが存在しないため、その場合エラーは `HTTPError` のインスタンスではありません。

エラーを throw することで Ky のリトライを防げます。Ky はこのエラーを処理せず、リクエスト発行元に伝播されます。残りの `beforeRetry` フックは呼び出されません。あるいは、エラーを伝播させずに同じ動作をさせたい場合は [`ky.stop`](#kystop) シンボルを返すことも可能です（詳細は `ky.stop` ドキュメント参照）。

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

型: `Function[]`\
デフォルト: `[]`

このフックにより、`HTTPError` が throw される直前に修正できます。フック関数は `HTTPError` を引数に受け取り、`HTTPError` のインスタンスを返す必要があります。

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

型: `Function[]`\
デフォルト: `[]`

このフックにより、レスポンスを読み取り、必要に応じて修正できます。フック関数は正規化されたリクエスト、オプション、レスポンスのクローンを引数に受け取ります。フック関数の戻り値が [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) のインスタンスであれば、Ky はそれをレスポンスオブジェクトとして使用します。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// 例えばレスポンスをログ出力できます。
				log(response);

				// または `Response` インスタンスを返してレスポンスを上書きできます。
				return new Response('A different response', {status: 200});
			},

			// 403 エラー時に新しいトークンで再試行する例
			async (request, options, response) => {
				if (response.status === 403) {
					// 新しいトークンを取得
					const token = await ky('https://example.com/token').text();

					// トークン付きで再試行
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

型: `boolean`\
デフォルト: `true`

リダイレクト後、レスポンスのステータスコードが 2xx 以外の場合に `HTTPError` を throw します。リダイレクトもエラーとして投げたい場合は、[`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) オプションを `'manual'` に設定してください。

リソースの存在確認などでエラーレスポンスを想定している場合、これを `false` にすることが有用です。

注意: `false` の場合、エラーレスポンスも成功と見なされ、リトライは行われません。

##### onDownloadProgress

型: `Function`

ダウンロード進捗イベントハンドラー。

関数は以下の引数を受け取ります:
- `progress` は以下のプロパティを持つオブジェクトです:
- - `percent` は進捗率を表す 0 から 1 の数値です。
- - `transferredBytes` はこれまでに転送されたバイト数です。
- - `totalBytes` は転送予定の総バイト数です。これは推定値であり、総サイズが判定できない場合は 0 になります。
- `chunk` は送信されたデータを含む `Uint8Array` のインスタンスです。注意: 最初の呼び出し時は空です。

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// 例:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

型: `Function`
アップロード進行状況イベントハンドラー

この関数は以下の引数を受け取ります:
- `progress` は以下のプロパティを持つオブジェクトです:
  - `percent` は進捗率を表す0から1の数値です。
  - `transferredBytes` はこれまでに転送されたバイト数です。
  - `totalBytes` は転送される合計バイト数です。これは推定値であり、合計サイズが判別できない場合は0となります。
- `chunk` は送信されたデータを含む `Uint8Array` のインスタンスです。注意: 最後の呼び出し時には空です。

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// 出力例:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

型: `Function`\
デフォルト: `JSON.parse()`

ユーザー定義のJSONパース関数。

ユースケース:
1. [`bourne` パッケージ](https://github.com/hapijs/bourne) を用いてプロトタイプ汚染から保護しつつJSONをパースする場合。
2. `JSON.parse()` の [`reviver` オプション](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) を使ってJSONをパースする場合。

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

型: `Function`\
デフォルト: `JSON.stringify()`

ユーザー定義のJSON文字列化関数。

ユースケース:
1. カスタム `replacer` 関数を用いてJSONを文字列化する場合。

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

型: `Function`\
デフォルト: `fetch`

ユーザー定義の `fetch` 関数。
[Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) 標準と完全互換である必要があります。

ユースケース:
1. [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch) のようなカスタム `fetch` 実装を使用する場合。
2. サーバーサイドレンダリング (SSR) を利用するフレームワークが提供する `fetch` ラッパー関数を利用する場合。

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

デフォルト値の一部を独自に上書きして新しい `ky` インスタンスを作成します。

`ky.create()` とは異なり、`ky.extend()` は親のデフォルト値を継承します。

ヘッダーは `Headers` インスタンスまたはプレーンなオブジェクトとして渡せます。

`.extend()` でヘッダーに `undefined` 値を渡すことで、ヘッダーを削除できます。
文字列の `undefined` を渡した場合、`Headers` インスタンス由来の場合のみヘッダーが削除されます。

同様に、既存の `hooks` エントリも、明示的に `undefined` で拡張することで削除できます。

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

`.extend()` に関数を渡すことで親のデフォルト値を参照することもできます。

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

完全に新しいデフォルト値で新しいKyインスタンスを作成します。

```js
import ky from 'ky';

// https://my-site.com 上で

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

型: `object`

### ky.stop

`beforeRetry` フックから返すことでリトライを停止できる `Symbol` です。これにより残りの `beforeRetry` フックも短絡されます。

注意: このシンボルを返すとKyは中断し、`undefined` のレスポンスを返します。レスポンスのプロパティにアクセスする前にレスポンスが存在するか確認するか、[オプショナルチェーン](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining) を使ってください。また、`.json()` や `.text()` などのボディメソッドとは互換性がありません。パースするレスポンスが存在しないためです。一般的に、このシンボルを返すのではなくエラーをスローすることを推奨します。そうすればKyは中断してスローし、これらの制限を回避できます。

`ky.stop` の正当なユースケースは、副作用のためにリクエストを行い、返却データが重要でない場合にリトライを防ぐことです。例として、クライアントのアクティビティをサーバーに記録する場合などです。

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
// 注意：`ky.stop`が返された場合、responseは`undefined`になります。
const response = await ky.post('https://example.com', options);

// `.text()`や他のボディメソッドの使用はサポートされていません。
const text = await ky('https://example.com', options).text();
```

### HTTPError

`instanceof`チェックのために公開されています。エラーには[`Response`オブジェクト](https://developer.mozilla.org/en-US/docs/Web/API/Response)を持つ`response`プロパティ、[`Request`オブジェクト](https://developer.mozilla.org/en-US/docs/Web/API/Request)を持つ`request`プロパティ、正規化されたオプション（`ky.create()`でインスタンス作成時、またはリクエスト実行時に直接渡されたもの）を持つ`options`プロパティがあります。

ネットワークエラーのような一部のエラータイプは、本質的にレスポンスが受信されなかったことを意味します。その場合、エラーはHTTPErrorのインスタンスではなく、`response`プロパティも含みません。

`HTTPError`が発生した際に実際のレスポンスを読みたい場合は、レスポンスオブジェクトの該当するパーサーメソッドを呼び出してください。例：

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** オプションの[型パラメータ](https://www.typescriptlang.org/docs/handbook/2/generics.html)を受け入れ、デフォルトは[`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)で、これは`error.response.json()`の返り値型に渡されます。

### TimeoutError

リクエストがタイムアウトした時にスローされるエラーです。[`Request`オブジェクト](https://developer.mozilla.org/en-US/docs/Web/API/Request)を持つ`request`プロパティがあります。

## Tips

### フォームデータの送信

Kyでのフォームデータ送信は`fetch`と同様です。ただ[`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData)インスタンスを`body`オプションに渡すだけです。`Content-Type`ヘッダーは自動的に`multipart/form-data`に設定されます。

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

`application/x-www-form-urlencoded`形式でデータを送信したい場合は、[`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams)でデータをエンコードしてください。

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### カスタム`Content-Type`の設定

Kyはリクエストボディのデータに基づいて適切な[`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type)ヘッダーを自動的に設定しますが、`application/x-amz-json-1.1`のようなカスタム・非標準のコンテンツタイプを必要とするAPIもあります。`headers`オプションを使えば、コンテンツタイプを手動で上書きできます。

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

### キャンセル処理

Fetch（およびKy）は、[`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController)によるリクエストのキャンセルを標準でサポートしています。[詳しくはこちら](https://developers.google.com/web/updates/2017/09/abortable-fetch)

例：

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

#### Node.jsでの使い方は？

Node.js 18以降では`fetch`がネイティブサポートされているので、このパッケージをそのまま使えます。

#### サーバーサイドレンダリング（SSR）を使うWebアプリ（React, Vue.jsなど）では？

上記と同じです。

#### これを使用するブラウザライブラリのテスト方法は？

Mochaのようにブラウザで実行できるテストランナーを使うか、[AVA](https://avajs.dev)と`ky-universal`を使ってください。[詳しくはこちら](https://github.com/sindresorhus/ky-universal#faq)

#### Webpackのようなバンドラなしで使うには？

コードがJavaScriptモジュール（ESM）として実行されていることを確認してください。例えばHTMLドキュメントで`<script type="module">`タグを使う方法があります。その場合、Kyはバンドラや他のツールなしで直接インポート可能です。

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### [`got`](https://github.com/sindresorhus/got)との違いは？

[こちらの回答](https://twitter.com/sindresorhus/status/1037406558945042432)をご覧ください。GotはKyと同じ開発者によってメンテナンスされています。

#### [`axios`](https://github.com/axios/axios)との違いは？

[こちらの回答](https://twitter.com/sindresorhus/status/1037763588826398720)をご覧ください。

#### [`r2`](https://github.com/mikeal/r2)との違いは？

[#10の回答](https://github.com/sindresorhus/ky/issues/10)をご覧ください。

#### `ky`の意味は？

npmで取得できたランダムな短いパッケージ名です。ただし、日本語では意味があります：

> テキストスラングの一種で、KYは「空気読めない（kuuki yomenai）」の略。直訳すると「空気が読めない」。「場の雰囲気や暗黙の意味を読み取れない人」を指す言葉です。

## ブラウザ対応

最新バージョンのChrome、Firefox、Safari。

## Node.js対応

Node.js 18以降。

## 関連リンク

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Fetchを扱うための便利なユーティリティ
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - オブジェクトのリクエスト・レスポンスのケースを変更するためのKyフック

## メンテナー

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---