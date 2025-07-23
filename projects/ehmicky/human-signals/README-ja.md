
[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/human-signals)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/human-signals)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

人に優しいプロセスシグナル。

これは、各シグナルに関する情報を含む既知のプロセスシグナルのマップです。

[`os.constants.signals`](https://nodejs.org/api/os.html#os_signal_constants)とは異なり、
以下を含みます：

- 人に優しい[説明](#description)
- [デフォルトの動作](#action)、およびそれが[防止可能かどうか](#forced)
- 現在のOSで[サポートされているか](#supported)

# 例


```js
import { signalsByName, signalsByNumber } from 'human-signals'

console.log(signalsByName.SIGINT)
// {
//   name: 'SIGINT',
//   number: 2,
//   description: 'User interruption with CTRL-C',
//   supported: true,
//   action: 'terminate',
//   forced: false,
//   standard: 'ansi'
// }

console.log(signalsByNumber[8])
// {
//   name: 'SIGFPE',
//   number: 8,
//   description: 'Floating point arithmetic error',
//   supported: true,
//   action: 'core',
//   forced: false,
//   standard: 'ansi'
// }
```
# インストール


```bash
npm install human-signals
```
このパッケージは Node.js >=18.18.0 で動作します。

これは ES モジュールです。  
[ `import` または `import()` 文](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c)を使用して読み込む必要があり、  
`require()` ではありません。TypeScript を使用する場合は、  
[ES モジュールを出力するように設定](https://www.typescriptlang.org/docs/handbook/esm-node.html)し、  
CommonJS ではないようにしてください。

# 使用方法

## signalsByName

_型_: `object`

キーがシグナルの[名前](#name)、値が  
[シグナルオブジェクト](#signal)であるオブジェクト。

## signalsByNumber

_型_: `object`

キーがシグナルの[番号](#number)、値が  
[シグナルオブジェクト](#signal)であるオブジェクト。

## signal

_型_: `object`

以下のプロパティを持つシグナルオブジェクト。

### name

_型_: `string`

シグナルの標準名。例：`'SIGINT'`。

### number

_型_: `number`

シグナルのコード番号。例：`2`。ほとんどの `number` は  
クロスプラットフォームですが、OSによって異なる場合があります。

### description

_型_: `string`

シグナルのわかりやすい説明。例：  
`'User interruption with CTRL-C'`。

### supported

_型_: `boolean`

現在の OS が Node.js でこのシグナルを  
[`process.on(name, handler)`](https://nodejs.org/api/process.html#process_signal_events)を使って処理可能かどうか。

対応しているシグナルの一覧は  
[OSごとに異なります](https://github.com/ehmicky/cross-platform-node-guide/blob/main/docs/6_networking_ipc/signals.md#cross-platform-signals)。

### action

_型_: `string`\
_列挙型_: `'terminate'`, `'core'`, `'ignore'`, `'pause'`, `'unpause'`

ハンドルされていない場合のこのシグナルのデフォルトの動作。

### forced

_型_: `boolean`

シグナルのデフォルト動作を防止できないかどうか。  
`SIGTERM`、`SIGKILL`、`SIGSTOP` はこれが `true` です。

### standard

_型_: `string`\
_列挙型_: `'ansi'`, `'posix'`, `'bsd'`, `'systemv'`, `'other'`

どの標準がこのシグナルを定義したか。

# サポート

質問があれば、_遠慮なく_ [GitHubでIssueを提出してください](../../issues)。

個人の背景に関係なく誰でも歓迎します。  
前向きで包括的な環境を促進するために  
[行動規範](https://raw.githubusercontent.com/ehmicky/human-signals/main/CODE_OF_CONDUCT.md)を適用しています。

# コントリビュート

このプロジェクトは ❤️ を込めて作られました。  
最も簡単な支援方法はスターをつけてオンラインで共有することです。

ドキュメントが不明瞭または誤字があれば、ページの `Edit` ボタン（鉛筆アイコン）をクリックして修正案を提案してください。

バグ修正や新機能追加で協力してくださる場合は、  
[ガイドライン](https://raw.githubusercontent.com/ehmicky/human-signals/main/CONTRIBUTING.md)をご確認ください。プルリクエストは歓迎します！


ありがとうございます、素晴らしい貢献者の皆様へ：

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4?s=100" width="100px;" alt="ehmicky"/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="Documentation">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://www.electrovir.com"><img src="https://avatars0.githubusercontent.com/u/1205860?v=4?s=100" width="100px;" alt="electrovir"/><br /><sub><b>electrovir</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=electrovir" title="Code">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://fzy.se"><img src="https://avatars.githubusercontent.com/u/2656517?v=4?s=100" width="100px;" alt="Felix Zedén Yverås"/><br /><sub><b>Felix Zedén Yverås</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="Code">💻</a> <a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="Tests">⚠️</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---