# Vimesh Headless UI
## 特徴
これは [Tailwind Headless UI](https://headlessui.com/) の Alpine.js 実装です。[Vimesh UI](https://github.com/vimeshjs/vimesh-ui) フレームワークで構築された Vimesh Headless UI はいくつかの優れた特徴を持っています：
### 超軽量
Vimesh Headless UI はコードサイズがはるかに小さいです

| コンポーネント   | Vimesh Headless UI   | Tailwind Headless UI for Vue | Tailwind Headless UI for React |
| ----------- | -------------------- | -------- | ----- |
| Listbox   | 8k  | 34k | 30k | 
| Combobox  | 9k  | 25k | 39k |
| Menu      | 7k  | 18k | 20k |
| Switch    | 0.6k | 5k | 6k |
| Tabs      | 4k  | 12k | 16k |
| Dialog    | 2k  | 15k | 17k |
| Popover   | 6k  | 23k | 28k |
| Radio Group | 1k | 11k | 14k |

Vimesh と Tailwind のヘッドレスダイアログ例の本番版ページサイズを比較すると、Vimesh のほうが機能が多くバグが少ないにもかかわらずはるかに小さいです（Tailwind のポップアップダイアログ内のメニュー表示を確認してください）。

* Vimesh (192k) 
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh001.png) 
* Tailwind (425k)
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/tailwind001.png)

### 使用するコンポーネントのみを動的に読み込み
コンポーネントはプレーンなHTMLファイルで、通常CDNなどどこにでもホスト可能です。追加のツリーシェイキングなしで異なるプロジェクト間で共有可能です。例えば、ダイアログの基本例は `hui-dialog` と `hui-menu` の2つのコンポーネントを使います。`x-import` で非同期に読み込むだけです。Vimesh UI は対応するネイティブカスタム要素を登録し初期化します。

```html
<template x-component:page="dialog-basic" x-import="hui:dialog,menu" x-data="setupDialogBasicData()"
    class="overflow-y-auto">
    ...
    <hui-dialog :open="isOpen" @close="setIsOpen(false)">
        ...
        <hui-menu>
        </hui-menu>
    </hui-dialog>
    ...
</template>
```

### ビルド不要、バンドル不要
書いたものがそのまま出力されます。コンポーネントを意味のある名前空間の下にHTMLファイルとして整理します。webpack、rollup、viteなどは必要ありません。

## はじめに
### 開発モード
alpinejs、@vimesh/style、@vimesh/ui、universal-router、http-serverなどの開発依存関係をインストールします。
```
yarn
```
静的HTTPサーバーを実行する
```
yarn dev
```
`http://127.0.0.1:8080/playground/dev.html` のURLを開いてください

インデックスページが表示されます
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh002.jpg)

さまざまなコンポーネントの例とそれに対応するソースコードが多数あります。

![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh003.jpg)

node_modulesフォルダ内の開発版のalpinejsと@vimesh/uiを使用しています。

### 本番モード
`playground/index.html` をご確認ください。こちらは最新のalpinejsと@vimesh/uiを `unpkg.com` から使用しています。実際、Vimesh Headless UIを実際のプロジェクトで使用する場合もこれが基本となります。
``` html
<head>
    <link rel="icon" type="image/x-icon" href="./assets/favicon.ico">

    <script src="https://unpkg.com/@vimesh/style"></script>
    <script src="https://unpkg.com/@vimesh/ui"></script>
    <script src="https://unpkg.com/alpinejs" defer></script>
    <script src="https://unpkg.com/universal-router/universal-router.min.js"></script>

    <script>
        const DEBUG = false
        $vui.config.debug = DEBUG
        $vui.config.importMap = {
            "hui": '../components/${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "app": './components/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "page": './pages/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
        }
    </script>
    ...
</head>
```

[Online Playground](https://unpkg.com/@vimesh/headless/playground/index.html)

Yes, the online playground are 100% plain html hosted at `unpkg.com`. It is very old school style, right? Let's make frondend development back to what it should be.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---