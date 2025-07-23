<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors_dark.svg"/>
  <img alt="log-process-errors ロゴ" src="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors.svg" width="500"/>
</picture>

[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/log-process-errors)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/log-process-errors)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

[📰 Medium記事.](https://medium.com/@ehmicky/node-js-process-errors-are-broken-193980f0a77b)

Node.jsのプロセスエラーに❤️を。

これはプロセスエラーを改善します：
[未捕捉](https://nodejs.org/api/process.html#process_event_uncaughtexception)
例外、
[未処理](https://nodejs.org/api/process.html#process_event_unhandledrejection)
のプロミス、遅れて
[処理された](https://nodejs.org/api/process.html#process_event_rejectionhandled)
プロミス、および[警告](https://nodejs.org/api/process.html#process_event_warning)。

# 特徴

- 警告および
  [`rejectionHandled`](https://nodejs.org/api/process.html#process_event_rejectionhandled)
  のスタックトレース
- すべてのプロセスエラーに対する[単一のイベントハンドラ](#onerror)
- [重複](#onerror)したプロセスエラーの無視
- 無効なエラーの[正規化](#error)
- [プロセス終了](#exit)は優雅に行われ、防止可能

# インストール

本番コード（例：サーバー）は、本番依存関係または
開発依存関係のいずれかとしてこれをインストールできます：
```bash
npm install log-process-errors
```
しかし、ライブラリはこれを開発依存としてインストールするべきです：


```bash
npm install -D log-process-errors
```


これはログ記録がグローバルに変更され、ライブラリの利用者がこの副作用を予期しない可能性があるためです。 また、これによりライブラリ間での競合が発生する可能性があります。

このパッケージは Node.js >=18.18.0 で動作します。

これは ES モジュールです。  
[ `import` または `import()` 文](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c) を使って読み込む必要があり、  
`require()` は使えません。TypeScript を使用する場合は、  
[ES モジュールを出力するように設定](https://www.typescriptlang.org/docs/handbook/esm-node.html) し、  
CommonJS ではないようにしてください。

# API

## logProcessErrors(options?)

[`options`](#options) `オブジェクト?`\
_戻り値_: `() => void`

プロセスエラーの処理を開始します。



```js
import logProcessErrors from 'log-process-errors'
logProcessErrors(options)
```


戻り値はNode.jsのデフォルトの動作を復元します。


```js
const restore = logProcessErrors(options)
restore()
```
## オプション

### exit

_型_: `boolean`

[キャッチされない例外](https://nodejs.org/api/process.html#process_event_uncaughtexception)
や
[未処理のプロミス](https://nodejs.org/api/process.html#process_event_unhandledrejection)
でプロセスを終了するかどうか。

他のライブラリがこれらのイベントを監視している場合はデフォルトで `false` で、
代わりにそれらが終了処理を行えます。そうでなければ `true` です。

一部のタスクがまだ実行中の場合、終了は最大3秒間それらの完了を待ちます。

### onError

_型_: `(error, event) => Promise<void> | void`\
_デフォルト_: `console.error(error)`

プロセスエラーごとに1回呼び出される関数。重複したプロセスエラーは無視されます。



```js
// Log process errors with Winston instead
logProcessErrors({
  onError: (error, event) => {
    winstonLogger.error(error.stack)
  },
})
```
#### error

_Type_: `Error`

プロセスエラーです。これは
[正規化](https://github.com/ehmicky/normalize-exception)されたエラーインスタンスであることが保証されています。
[イベント](#event)の簡単な説明もメッセージに付加されています。

#### event

_Type_: `Event`

以下のいずれかのプロセスイベント名:
[`'uncaughtException'`](https://nodejs.org/api/process.html#process_event_uncaughtexception),
[`'unhandledRejection'`](https://nodejs.org/api/process.html#process_event_unhandledrejection),
[`'rejectionHandled'`](https://nodejs.org/api/process.html#process_event_rejectionhandled),
[`'warning'`](https://nodejs.org/api/process.html#process_event_warning)。

# 関連プロジェクト

- [`modern-errors`](https://github.com/ehmicky/modern-errors): シンプルで安定した一貫性のあるエラー処理
- [`modern-errors-process`](https://github.com/ehmicky/modern-errors-process):
  プロセスエラーの処理
- [`error-custom-class`](https://github.com/ehmicky/error-custom-class): 単一のエラークラスの作成
- [`error-class-utils`](https://github.com/ehmicky/error-class-utils): エラークラスを適切に作成するユーティリティ
- [`error-serializer`](https://github.com/ehmicky/error-serializer): エラーをプレーンオブジェクトに変換/復元
- [`normalize-exception`](https://github.com/ehmicky/normalize-exception):
  例外/エラーを正規化
- [`is-error-instance`](https://github.com/ehmicky/is-error-instance): 値が`Error`インスタンスかをチェック
- [`merge-error-cause`](https://github.com/ehmicky/merge-error-cause): エラーとその`cause`をマージ
- [`set-error-class`](https://github.com/ehmicky/set-error-class): エラーのクラスを適切に更新
- [`set-error-message`](https://github.com/ehmicky/set-error-message): エラーメッセージを適切に更新
- [`wrap-error-message`](https://github.com/ehmicky/wrap-error-message):
  エラーメッセージを適切にラップ
- [`set-error-props`](https://github.com/ehmicky/set-error-props): エラーのプロパティを適切に更新
- [`set-error-stack`](https://github.com/ehmicky/set-error-stack): エラースタックを適切に更新
- [`error-cause-polyfill`](https://github.com/ehmicky/error-cause-polyfill):
  `error.cause`のポリフィル
- [`handle-cli-error`](https://github.com/ehmicky/handle-cli-error): 💣 CLIアプリケーション用のエラーハンドラ 💥
- [`beautiful-error`](https://github.com/ehmicky/beautiful-error): エラーメッセージとスタックの美化
- [`error-http-response`](https://github.com/ehmicky/error-http-response):
  HTTPエラー応答の作成
- [`winston-error-format`](https://github.com/ehmicky/winston-error-format): Winstonでのエラーログ記録

# サポート

ご質問があれば、_遠慮なく_ [GitHubでIssueを提出してください](../../issues)。

個人の背景に関係なく誰でも歓迎します。ポジティブで包括的な環境を促進するために
[行動規範](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CODE_OF_CONDUCT.md)を施行しています。

# コントリビュート

このプロジェクトは❤️で作られています。スターを付けたりオンラインで共有することが最も簡単な支援方法です。

ドキュメントが不明瞭または誤字があれば、ページの`Edit`ボタン（鉛筆アイコン）をクリックして修正提案をしてください。

バグ修正や新機能の追加をお手伝いいただける場合は、当社の
[ガイドライン](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CONTRIBUTING.md)をご覧ください。プルリクエストは歓迎です！

素晴らしいコントリビューターに感謝します：

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4" width="100px;" alt=""/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Documentation">📖</a></td>
    <td align="center"><a href="https://svachon.com"><img src="https://avatars0.githubusercontent.com/u/170197?v=4" width="100px;" alt=""/><br /><sub><b>Steven Vachon</b></sub></a><br /><a href="#question-stevenvachon" title="Answering Questions">💬</a></td>
    <td align="center"><a href="https://github.com/Hongarc"><img src="https://avatars1.githubusercontent.com/u/19208123?v=4" width="100px;" alt=""/><br /><sub><b>Hongarc</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Documentation">📖</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/abrenneke"><img src="https://avatars0.githubusercontent.com/u/342540?v=4" width="100px;" alt=""/><br /><sub><b>Andy Brenneke</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/issues?q=author%3Aabrenneke" title="Bug reports">🐛</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->



















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---