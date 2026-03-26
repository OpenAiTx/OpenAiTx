
<a href="https://www.facebook.com/amplifr/">
  <img width="80" height="80" align="right"
    alt="Sponsored by Amplifr" src="https://raw.githubusercontent.com/vrizo/uibook/master/./amplifr-logo.png" style="border-radius: 100%; margin: 10px;"/>
</a>


# Uibook

UibookはReactコンポーネントの視覚的テストツールです。  
実際のメディアクエリとさまざまなpropsの組み合わせで、デスクトップおよびモバイルビューのコンポーネントを素早く確認できます。

主な機能:  
- 開発者向けの**実際のメディアクエリ**を使ったレスポンシブテスト  
- デザイナーや編集者向けのライブテキスト編集でコンテンツを確認  
- Webpackプラグインとしてインストールし、追加のビルダーは不要

<img src="/docs/uibook.gif" align="center" alt="Uibook key features" >

:triangular_flag_on_post: Uibookのデモプロジェクトはこちらからご覧いただけます:  
[https://uibook.vrizo.net/](https://uibook.vrizo.net/#Presets:ru).

## 使い方

### クイックインストール :hatching_chick:

Uibookはプロジェクトへのシームレスな統合を念頭に設計されています。  
Webpackプラグインとしてインストールするだけで準備完了です。  
Uibookは別途バンドラーを必要としません。

_webpack.config.js_

```js
const UibookPlugin = require('uibook/plugin')

module.exports = {
  …
  plugins: [
    new UibookPlugin({
      outputPath: '/uibook',
      controller: path.join(__dirname, '../src/uibook-controller.js'),
      hot: true
    })
  ],
}
```
[インストールの詳細はこちら →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install.md)
[CRACOを使ったCreate React Appへのインストール →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install_craco.md)

### ページ内のコンポーネントを記述する :hatched_chick:

定義すべきは次の2つだけです：

1. ページ — テストするコンポーネント名とケースを持つ単純なオブジェクト；
2. ケース — コンポーネントへのpropsとコールバックのセット。

_button.uibook.js_

```js
import UibookCase from 'uibook/case'
import Button from '../src/button'

export default {
  component: Button,
  cases: [
    () => <UibookCase>Button</UibookCase>,
    () => <UibookCase props={{ isSmall: true }}>Small button</UibookCase>
  ]
}
```

[設定についてもっと読む →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/configure.md)

### ページをコントローラーに渡す :baby_chick:

最初のUibookページが完成したら、Uibookコントローラーを書く準備ができています。
ここはすべてのページが含まれ、
UibookStarterに渡される場所です :sparkles:

_uibook-controller.js_
```js
import UibookStarter from 'uibook/starter'
import ButtonUibook from './button.uibook'

export default UibookStarter({
  pages: {
    Button: ButtonUibook
  }
})
```
[コントローラーについてもっと読む →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/controller.md)

### 起動 :rocket:

追加のサーバーやwebpackインスタンスは不要です。  
Uibookはあなたのプロジェクトに統合されるため、バンドラーを実行して  
ブラウザで`/uibook`（またはカスタムアドレス—`outputPath`）を開くだけです。

### さらに詳しく

- **[トラブルシューティング](https://raw.githubusercontent.com/vrizo/uibook/master/docs/troubleshooting.md)**
- [例](https://raw.githubusercontent.com/vrizo/uibook/master/docs/examples.md)
- [質問はこちら](https://twitter.com/vitaliirizo)

## ライブテキスト編集

このモードは各ケースで`contentEditable`を有効にし、マネージャー、  
デザイナー、インターフェース編集者がコンポーネント内のコンテンツをプレビューできます。

<img src="/docs/text-edit-mode.gif" align="center" alt="テキスト編集モード" >

## 特別感謝

- [@ai](https://github.com/ai)
- [@demiazz](https://github.com/demiazz)
- [@marfitsin](https://github.com/marfitsin)
- [@iadramelk](https://github.com/iadramelk)
- [@ikowalsker](https://www.facebook.com/ikowalsker)
- [@antiflasher](https://github.com/antiflasher)
- [@HellSquirrel](https://github.com/HellSquirrel)

どなたでも貢献を歓迎します。現在のタスクは  
[PLAN.md](https://raw.githubusercontent.com/vrizo/uibook/master/PLAN.md)で確認できます。  
プロジェクトに関する質問には喜んでお答えします。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---