<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Chờ phát hành phiên bản đầu tiên.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Một SDK chính thức của Model Context Protocol cho Rust với runtime bất đồng bộ tokio.


Kho lưu trữ này bao gồm các crate sau:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): Crate lõi cung cấp triển khai giao thức RMCP (Nếu bạn muốn biết thêm thông tin, vui lòng truy cập [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Crate macro thủ tục dùng để sinh các triển khai công cụ RMCP (Nếu bạn muốn biết thêm thông tin, vui lòng truy cập [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Sử dụng

### Thêm crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## hoặc kênh dev
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Phụ thuộc bên thứ ba
Các phụ thuộc cơ bản:
- [tokio yêu cầu](https://github.com/tokio-rs/tokio)
- [serde yêu cầu](https://github.com/serde-rs/serde)



### Xây dựng Client
<details>
<summary>Khởi động một client</summary>

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

### Xây dựng Server

<details>
<summary>Tạo một transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Xây dựng một service</summary>

Bạn có thể dễ dàng xây dựng một service bằng cách sử dụng [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) hoặc [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Khởi động server</summary>

```rust, ignore
// lệnh này sẽ hoàn tất quá trình khởi tạo
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Tương tác với server</summary>

Sau khi server đã khởi tạo, bạn có thể gửi các yêu cầu hoặc thông báo:

```rust, ignore
// request
let roots = server.list_roots().await?;

// hoặc gửi notification
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Chờ server tắt</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// hoặc hủy bỏ
let quit_reason = server.cancel().await?;
```
</details>


## Ví dụ

Xem [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Hỗ trợ OAuth

Xem [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) để biết chi tiết.


## Tài liệu liên quan

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Dự án liên quan
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Một triển khai server MCP dựa trên containerd

## Phát triển với Dev Container
Xem [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) để biết hướng dẫn sử dụng Dev Container cho phát triển.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---