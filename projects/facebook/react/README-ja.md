# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

Reactは、ユーザーインターフェース構築のためのJavaScriptライブラリです。

* **宣言的:** ReactはインタラクティブなUIの作成を簡単にします。アプリケーションの各状態ごとにシンプルなビューを設計し、データが変化したときにReactが効率的に正しいコンポーネントだけを更新・描画します。宣言的なビューはコードをより予測可能にし、理解しやすく、デバッグも容易にします。
* **コンポーネントベース:** 独立したコンポーネントを構築してそれぞれの状態を管理し、それらを組み合わせて複雑なUIを作成できます。コンポーネントのロジックはテンプレートではなくJavaScriptで記述されるため、アプリ全体でリッチなデータの受け渡しや、状態をDOMの外で管理することが容易です。
* **一度学べばどこでも使える:** Reactは他の技術スタックについて前提を設けていないため、既存コードを書き換えることなくReactで新機能を開発できます。また、Reactは[Node](https://nodejs.org/en)を利用したサーバーサイドレンダリングや、[React Native](https://reactnative.dev/)を使ったモバイルアプリの開発にも対応しています。

[Reactをプロジェクトで使う方法を学ぶ](https://react.dev/learn)

## インストール

Reactは最初から段階的な導入を想定して設計されており、**必要な分だけReactを使うことができます**:

* [クイックスタート](https://react.dev/learn)を使ってReactを体験してみましょう。
* [既存プロジェクトにReactを追加](https://react.dev/learn/add-react-to-an-existing-project)して、必要なだけReactを利用できます。
* 強力なJavaScriptツールチェーンを求めているなら、[新しいReactアプリを作成](https://react.dev/learn/start-a-new-react-project)しましょう。

## ドキュメント

Reactのドキュメントは[公式ウェブサイト](https://react.dev/)で参照できます。

概要を素早く把握したい場合は、[はじめに](https://react.dev/learn)ページをご覧ください。

ドキュメントは以下のセクションに分かれています:

* [クイックスタート](https://react.dev/learn)
* [チュートリアル](https://react.dev/learn/tutorial-tic-tac-toe)
* [React的思考法](https://react.dev/learn/thinking-in-react)
* [インストール](https://react.dev/learn/installation)
* [UIの記述](https://react.dev/learn/describing-the-ui)
* [インタラクティビティの追加](https://react.dev/learn/adding-interactivity)
* [状態管理](https://react.dev/learn/managing-state)
* [上級ガイド](https://react.dev/learn/escape-hatches)
* [APIリファレンス](https://react.dev/reference/react)
* [サポートの受け方](https://react.dev/community)
* [コントリビューションガイド](https://legacy.reactjs.org/docs/how-to-contribute.html)

[このリポジトリ](https://github.com/reactjs/react.dev)にプルリクエストを送ることで、ドキュメントを改善できます。

## サンプル

いくつかのサンプルが[公式ウェブサイト](https://react.dev/)に掲載されています。まずは以下の例から始めてみましょう:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

このサンプルでは、ページ上のコンテナに「Hello Taylor」と表示されます。

HTMLに似た構文を使っていることに気づくでしょう。これは[JSXと呼ばれています](https://react.dev/learn#writing-markup-with-jsx)。Reactを使うのにJSXは必須ではありませんが、コードの可読性が向上し、HTMLを書く感覚で記述できます。

## コントリビューション

このリポジトリの主な目的は、Reactコアを進化させ続け、より高速で使いやすくすることです。Reactの開発はGitHub上で公開して行われており、バグ修正や改善へのコミュニティからの貢献に感謝しています。Reactの改善に参加する方法について、以下をご覧ください。

### [行動規範](https://code.fb.com/codeofconduct)

Facebookは、プロジェクト参加者が遵守すべき行動規範を採用しています。どのような行動が許容され、どのような行動が許容されないのかを理解するために、[全文](https://code.fb.com/codeofconduct)をお読みください。

### [コントリビューションガイド](https://legacy.reactjs.org/docs/how-to-contribute.html)

[コントリビューションガイド](https://legacy.reactjs.org/docs/how-to-contribute.html)を読み、開発プロセス、バグ修正や改善提案の方法、Reactへの変更のビルドやテスト方法について学んでください。

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

コントリビューションプロセスに慣れてもらうために、比較的スコープの限定されたバグをまとめた[Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)のリストを用意しています。まずはこちらから始めるのがおすすめです。

### ライセンス

Reactは[MITライセンス](./LICENSE)です。

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---