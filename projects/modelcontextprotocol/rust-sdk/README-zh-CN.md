<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
等待首次发布。
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](docs/coverage.svg)

官方 Rust Model Context Protocol SDK 实现，基于 tokio 异步运行时。

本仓库包含以下 crate：

- [rmcp](crates/rmcp): 提供 RMCP 协议实现的核心 crate（如需获取更多信息，请访问 [rmcp](crates/rmcp/README.md)）
- [rmcp-macros](crates/rmcp-macros): 用于生成 RMCP 工具实现的过程宏 crate（如需获取更多信息，请访问 [rmcp-macros](crates/rmcp-macros/README.md)）

## 用法

### 导入 crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## 或开发通道
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### 第三方依赖
基本依赖：
- [tokio 必需](https://github.com/tokio-rs/tokio)
- [serde 必需](https://github.com/serde-rs/serde)



### 构建客户端
<details>
<summary>启动客户端</summary>

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

### 构建服务端

<details>
<summary>构建传输通道</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>构建服务</summary>

你可以通过 [`ServerHandler`](crates/rmcp/src/handler/server.rs) 或 [`ClientHandler`](crates/rmcp/src/handler/client.rs) 轻松构建服务。

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>启动服务端</summary>

```rust, ignore
// 该调用将完成初始化流程
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>与服务端交互</summary>

服务初始化后，你可以发送请求或通知：

```rust, ignore
// 请求
let roots = server.list_roots().await?;

// 或发送通知
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>等待服务关闭</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// 或取消
let quit_reason = server.cancel().await?;
```
</details>


## 示例

参见 [examples](examples/README.md)

## OAuth 支持

详情请参见 [oauth_support](docs/OAUTH_SUPPORT.md)。

## 相关资源

- [MCP 规范](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## 相关项目
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - 基于 containerd 的 MCP 服务器实现

## Dev Container 开发
关于如何使用 Dev Container 进行开发，请参见 [docs/DEVCONTAINER.md](docs/DEVCONTAINER.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---