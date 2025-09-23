# Node Monkey

Node.jsアプリケーションをウェブブラウザやSSHインターフェースを通じて（独自のカスタムコマンドで）検査、デバッグ、操作するためのツールです。

Node Monkeyはシンプルなサーバーを起動するか（または既存のサーバーにアタッチして）、[Socket.IO](https://github.com/LearnBoost/socket.io)を使ってブラウザとサーバー間にWebSocket接続を作成します。主な機能は、通常ターミナルにログされる内容をキャプチャし、それをブラウザで検査できるように渡すことです。

非常に簡単に始められます（以下の[Quick Usage](#quick-usage)を参照）が、Node Monkeyはより高度な使用のための追加機能や大きな柔軟性も提供します。実際にNode Monkeyを介してアプリにSSH接続し、独自のカスタムコマンドを実行するためのコマンドラインインターフェースを利用できます。これはアプリケーションのデバッグ、監視、または制御に非常に役立ちます。プロダクション環境でのセキュリティのために認証も提供しています。

## Contents

- [Motivation](#motivation)
- [Features](#features)
- [Installation](#installation)
- [Quick Usage](#quick-usage)
- [Server](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [Provide your own](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [Options](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [Properties](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [Methods](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [Client (browser)](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [Properties](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [Methods](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [Setup](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [Usage](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [User Management](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [Contributing](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [Changelog](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [MIT License](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## Motivation

このプロジェクトの動機は、私が書いたWebSocketを使うNode.jsサーバーのデバッグを試みたことにあります。オブジェクトを端末上で検査しようとしたところ、出力が大きすぎて閲覧しづらい問題がありました。Eclipse用の[Chrome Developer Toolsプラグイン](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger)を使った組み込みのデバッグを試しましたが、オブジェクトを検査するためにブレークポイントを設定するとサーバーがハートビートに応答しなくなり、クライアントが切断されてしまう問題に遭遇しました。これがデバッグを完全に妨げてしまいました。私が本当に必要だったのは、オブジェクトをうまく検査する方法でした。

Googleで検索したところ、[node-inspector](https://github.com/dannycoates/node-inspector)のようなプロジェクトを見つけましたが、最新のNodeバージョンに対応しておらず、[node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/)は多くのバグを抱えていました。しかもどちらもFirefoxでは動作しませんでした。そこで、Node Monkeyが生まれました！

## Features

- アプリのコンソール出力をブラウザコンソールにログとして送信し、検査を容易にする
  - Bunyanを使う人向けにストリームも提供（詳細は[こちら](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream)）
- アプリの検査、デバッグ、または制御のためにシェルにアクセスできるSSH機能を提供します
- ブラウザコンソールまたはSSHインターフェースから実行できるアプリケーション用のコマンドを登録します

## インストール

```
npm install --save node-monkey
```
もし実験的かつ今後の機能を試したい場合は、代わりにこちらを実行してください:


```
npm install --save node-monkey@next
```

## クイック使用法

Node Monkey は多くの機能をサポートしていますが、始めるのは非常に簡単に設計されています。アプリケーションに1行か2行を追加するだけです。この後にコンソールにログ出力されたものは、接続後にブラウザのコンソールに表示されます。ほとんどの `console.*` 関数呼び出しの出力をキャプチャし、検査のためにブラウザに転送します。

最も簡単な使用例は次のようになります：

```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```

Node Monkey は、多くの設定[オプション](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)や名前付きインスタンスもサポートしています。呼び出しは `NodeMonkey([options[, name])` の形式を取ります。例えば、ローカルのコンソール出力を抑制し、接続されたブラウザやターミナルでのみ出力を表示したい場合は、次のようにします:

```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

アプリ内の任意のファイルにNode Monkeyを含めることができ、上記の例のように使用した場合、`NodeMonkey()`への各呼び出しは最初に構築した同じインスタンスを常に返し、後続の呼び出しで渡されたオプションは無視されます。ただし、異なるオプションで新しいインスタンスを構築したい場合があります。その場合は、インスタンスに名前を付けてください：

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```

追加のインスタンスのポートを指定しない場合、自動的に設定され、デフォルトからインクリメントされます（例：WebSocketサーバーは50502、50504、SSHサーバーは50503、50505）。

別のファイルで既に構築されたインスタンスを取得するには、名前を再度呼び出すだけです：

```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

アプリを起動すると、次の出力が表示されます：

```
Node Monkey listening at http://0.0.0.0:50500
```
ブラウザに接続するには、単にブラウザに表示されているアドレス（この場合は`http://0.0.0.0:50500`）にアクセスしてください。デフォルトの`host`や`port`の設定を変更したり、独自のサーバーを指定した場合は、それに応じてURLを調整してください。ユーザー名とパスワードの入力を求められます。ユーザーを設定するまでは、デフォルトで`guest`と`guest`です。

独自のサーバーを提供した場合は、自分のウェブアプリケーションのコンソールで出力を表示できます。独自のサーバーの提供方法については、[ドキュメント](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)を参照してください。Node Monkeyの出力をアプリと統合するためには、HTMLソースに以下の`<script>`タグを含める必要があります。


```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---