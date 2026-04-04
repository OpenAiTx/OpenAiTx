<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" height=170 srcset="docs/images/icon-dark.svg">
    <source media="(prefers-color-scheme: light)" height=170 srcset="docs/images/icon-light.svg">
    <img alt="venator ロゴ" height=170 src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/icon-light.svg">
  </picture>
</p>

Venatorは、Rustのtracingクレートで計装されたプログラムやOpenTelemetryを使用したプログラムからのログおよびスパンを記録、表示、フィルタリングするためのアプリケーションです。
高速なローカル開発向けに特化して設計されています。

<picture>
  <img alt="デモ" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-demo.gif">
</picture>

## インストール

### 事前ビルド済みバイナリを使用する場合：

バイナリは[リリースページ](https://github.com/kmdreko/venator/releases)で事前ビルドされており、以下のプラットフォームに対応しています：
- Windows (x64)
- MacOS (Intel、Apple silicon)

### Cargoを使う場合：

Cargoを使ってソースから`venator`をコンパイルおよびインストールします（Rust 1.76以降が必要です）：



```
cargo install venator-app
```

## 使用方法

### OpenTelemetry の使用:

プログラムの OpenTelemetry SDK を設定して、ログとトレースを
`127.0.0.1:8362`（Venator のデフォルトリスニングポート）にエクスポートし、
`grpc` または `http/protobuf` を使用するようにします。

### Rust Tracing の使用:

インストルメントされたプログラム内で:

```toml
[dependencies]
venator = "1.1.0"
```

```rust
use venator::Venator;

Venator::default().install();
```
詳細は[ドキュメント](https://docs.rs/venator/latest/venator/)をご覧ください。

## 機能

イベントは、期間で絞り込み、属性、レベル、その他のプロパティでフィルタリングできます。  
レコードの表にはカスタムプロパティの列を含めることができます。  
グラフは各バーごとのレベル別のカウントを表示します。

<picture>
  <img alt="イベント画面のスクリーンショット" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-events.png">
</picture>

スパンも同様に期間とフィルタで絞り込めます。  
詳細ペインでは選択したイベントとスパンのすべてのプロパティを表示できます。  
グラフは階層的に重ねられたスパンを示します。

<picture>
  <img alt="スパン画面のスクリーンショット" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-spans.png">
</picture>

トレースは、単一の実行内のイベントとスパンの両方を表示できます。

<picture>
  <img alt="トレース画面のスクリーンショット" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-traces.png">
</picture>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---