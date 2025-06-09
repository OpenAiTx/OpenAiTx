<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
รอการปล่อยเวอร์ชันแรก
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

เป็นการติดตั้ง SDK อย่างเป็นทางการของ Model Context Protocol ในภาษา Rust ที่ใช้ tokio async runtime

ที่เก็บนี้ประกอบด้วย crate ดังต่อไปนี้:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): crate หลักที่ให้การติดตั้งโปรโตคอล RMCP (หากต้องการข้อมูลเพิ่มเติม กรุณาเยี่ยมชม [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): crate procedural macro สำหรับสร้างเครื่องมือ RMCP (หากต้องการข้อมูลเพิ่มเติม กรุณาเยี่ยมชม [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## การใช้งาน

### นำเข้า crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## หรือ dev channel
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Third Dependencies
การขึ้นต่อพื้นฐาน:
- [tokio required](https://github.com/tokio-rs/tokio)
- [serde required](https://github.com/serde-rs/serde)



### สร้าง Client
<details>
<summary>เริ่มต้น client</summary>

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

### สร้าง Server

<details>
<summary>สร้าง transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>สร้าง service</summary>

คุณสามารถสร้าง service ได้อย่างง่ายดายโดยใช้ [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) หรือ [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs)

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>เริ่มต้น server</summary>

```rust, ignore
// การเรียกนี้จะจบกระบวนการ initialization
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>โต้ตอบกับ server</summary>

เมื่อ server ถูก initialize แล้ว คุณสามารถส่ง request หรือ notification ได้:

```rust, ignore
// request
let roots = server.list_roots().await?;

// หรือส่ง notification
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>รอให้ service ปิดตัวลง</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// หรือยกเลิกมัน
let quit_reason = server.cancel().await?;
```
</details>


## ตัวอย่าง

ดู [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## รองรับ OAuth

ดูรายละเอียดได้ที่ [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md)


## แหล่งข้อมูลที่เกี่ยวข้อง

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## โปรเจกต์ที่เกี่ยวข้อง
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - การติดตั้ง MCP server บน containerd

## การพัฒนาด้วย Dev Container
ดู [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) สำหรับคำแนะนำในการใช้งาน Dev Container เพื่อการพัฒนา

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---