<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>あなたのフロントエンドを輝かせよう</strong> ✨
</div>

<div align="center">
  GleamでWebアプリを構築するためのフレームワーク！
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Available on Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentation" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      クイックスタート
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      リファレンス
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>❤︎ を込めて
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> と
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    コントリビューター
  </a>
  によって開発されています
</div>

---

## 目次

- [特徴](#features)
- [例](#example)
- [思想](#philosophy)
- [インストール](#installation)
- [次のステップ](#where-next)
- [サポート](#support)

## 特徴 {#features}

- HTMLを構築するための**宣言的**かつ関数型API。テンプレートもマクロも不要、
  Gleamだけで完結。

- **状態管理**のためのErlangとElmに触発されたアーキテクチャ。

- 予測可能でテスト可能なコードのための**管理された副作用**。

- ユニバーサルコンポーネント。**一度書けばどこでも動作**。ElmとPhoenix LiveViewの融合。

- アプリのスキャフォールディングやビルドを簡単にする**バッテリー同梱CLI**。

- 静的HTMLテンプレートのための**サーバーサイドレンダリング**。

## 例 {#example}

Lustreには[20以上の例](https://hexdocs.pm/lustre/reference/examples.html)が付属しています！
以下はその一例です:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## 思想 {#philosophy}

Lustreは、小〜中規模のWebアプリケーション構築のための_意見のある_フレームワークです。現代のフロントエンド開発は難しく複雑です。その複雑さの一部は必要ですが、多くは偶発的なものであり、選択肢が多すぎることに起因しています。LustreはGleamと同じ設計思想を持っています：可能な限り、物事のやり方は一つだけであるべきです。

つまり、ElmとErlang/OTPをモデルにした単一の状態管理システムが最初から組み込まれています。どのLustreアプリケーションを開いても、すぐに馴染みを感じられるはずです。

また、複雑な方法よりシンプルな方法でビューを構築することを推奨します。Lustreにはカプセル化されたステートフルコンポーネントを作成する方法（Elmで恋しかったもの）もありますが、それがデフォルトではありません。ステートフルコンポーネントよりシンプルな関数を優先してください。

コンポーネントが_必要_な場合は、Lustreのコンポーネントが_どこでも動作可能_であることを活かしましょう。Lustreは、既存のLustreアプリケーション内で動作するコンポーネント、単体Webコンポーネントとしてエクスポートする、またはサーバー上で最小限のランタイムでDOMをパッチするなど、どこでも動作するコンポーネントを作成するためのツールを提供します。Lustreはこれらを**ユニバーサルコンポーネント**と呼び、Gleamのマルチターゲットを念頭に置いて記述されています。

## インストール {#installation}

Lustreは[Hex](https://hex.pm/packages/lustre)で公開されています！コマンドラインからGleamプロジェクトに追加できます:

```sh
gleam add lustre
```

Lustreには開発用ツールを含むコンパニオンパッケージもあります。必要に応じてインストールしてください:

> **注**: lustre_dev_tools開発サーバーは、Gleamコードのファイルシステム変更を監視し、ブラウザを自動リロードできます。Linuxユーザーは[inotify-tools]()のインストールが必要です

```sh
gleam add --dev lustre_dev_tools
```

## 次のステップ {#where-next}

Lustreをすぐに使いこなすには、[クイックスタートガイド](https://hexdocs.pm/lustre/guide/01-quickstart.html)をチェックしてください。
コードを見たい場合は、[examples](https://github.com/lustre-labs/lustre/tree/main/examples)
ディレクトリにフレームワークのさまざまな側面を示す小さなアプリケーション例が含まれています。

また、[HexDocs](https://hexdocs.pm/lustre)でドキュメントやAPIリファレンスを読むこともできます。

## サポート {#support}

Lustreは主に私、[Hayleigh](https://github.com/hayleigh-dot-dev)が2つの仕事の合間に開発しています。もし私の活動を支援したい方は、[GitHubでスポンサー](https://github.com/sponsors/hayleigh-dot-dev)になっていただけると嬉しいです。

コントリビューションも大歓迎です！バグを見つけたり、機能提案がある場合は、イシューやプルリクエストを気軽に送ってください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---