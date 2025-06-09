<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
最初のリリースをお待ちください。
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Tokio非同期ランタイムを用いた公式Rust Model Context Protocol SDK実装です。

このリポジトリには以下のクレートが含まれています：

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): RMCPプロトコルの実装を提供するコアクレート（詳細は[rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md)をご覧ください）
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): RMCPツール実装生成用のプロシージャルマクロクレート（詳細は[rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md)をご覧ください）

## 使用方法

### クレートのインポート

```toml
rmcp = { version = "0.1", features = ["server"] }
## または開発チャンネル
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### サードパーティ依存関係
基本依存関係：
- [tokio 必須](https://github.com/tokio-rs/tokio)
- [serde 必須](https://github.com/serde-rs/serde)

### クライアントを構築する
<details>
<summary>クライアントの起動</summary>

```rust, ignore
use rmcp::{ServiceExt, transport::{TokioChildProcess, ConfigureCommandExt}};
use tokio::process::Command;

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    let client = ().serve(TokioChildProcess::new(Command::new("npx").configure(|cmd| {
        cmd.arg("-y").arg("@modelcontextprotocol/server-everything");
    }))?).await?;
    Ok(())
}
```
</details>

### サーバーを構築する

<details>
<summary>トランスポートの構築</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>サービスの構築</summary>

[`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) または [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs) を使用して簡単にサービスを構築できます。

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>サーバーの起動</summary>

```rust, ignore
// この呼び出しで初期化プロセスが完了します
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>サーバーとのやり取り</summary>

サーバーが初期化されたら、リクエストや通知を送信できます：

```rust, ignore
// リクエスト
let roots = server.list_roots().await?;

// または通知を送信
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>サービスのシャットダウン待機</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// またはキャンセル
let quit_reason = server.cancel().await?;
```
</details>

## サンプル

[examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md) をご覧ください。

## OAuth サポート

詳細は [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) を参照してください。

## 関連リソース

- [MCP 仕様](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [スキーマ](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## 関連プロジェクト
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - containerdベースのMCPサーバー実装

## Dev Container での開発
Dev Containerを使った開発手順については [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---