<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
等待首次發佈。
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

一個官方 Rust Model Context Protocol SDK 實現，採用 tokio 非同步運行時。

本倉庫包含以下 Crate：

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): 提供 RMCP 協議實現的核心 Crate（若需瞭解更多資訊，請參閱 [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md)）
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): 用於生成 RMCP 工具實現的程序式巨集 Crate（若需瞭解更多資訊，請參閱 [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md)）

## 用法

### 匯入 Crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## 或 dev channel
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### 第三方依賴
基本依賴：
- [tokio 必須](https://github.com/tokio-rs/tokio)
- [serde 必須](https://github.com/serde-rs/serde)



### 建立 Client
<details>
<summary>啟動 client</summary>

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

### 建立 Server

<details>
<summary>建立 transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>建立 service</summary>

你可以很容易地使用 [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) 或 [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs) 來建立服務。

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>啟動 server</summary>

```rust, ignore
// 此呼叫將完成初始化流程
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>與 server 互動</summary>

一旦 server 初始化後，你可以發送請求或通知：

```rust, ignore
// 請求
let roots = server.list_roots().await?;

// 或發送通知
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>等待服務關閉</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// 或取消
let quit_reason = server.cancel().await?;
```
</details>


## 範例

請參閱 [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## OAuth 支援

詳情請見 [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md)。

## 相關資源

- [MCP 規範](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## 相關專案
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - 基於 containerd 的 MCP server 實現

## 使用 Dev Container 進行開發
請參閱 [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) 以獲取有關使用 Dev Container 進行開發的說明。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---