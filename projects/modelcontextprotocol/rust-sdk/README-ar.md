<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
انتظر الإصدار الأول.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![التغطية](docs/coverage.svg)

تنفيذ رسمي لـ Model Context Protocol SDK بلغة Rust مع دعم tokio async runtime.

يحتوي هذا المستودع على الحزم التالية:

- [rmcp](crates/rmcp): الحزمة الأساسية التي توفر تنفيذ بروتوكول RMCP (للمزيد من المعلومات يرجى زيارة [rmcp](crates/rmcp/README.md))
- [rmcp-macros](crates/rmcp-macros): حزمة ماكرو إجرائية لتوليد أدوات تنفيذ RMCP (للمزيد من المعلومات يرجى زيارة [rmcp-macros](crates/rmcp-macros/README.md))

## الاستخدام

### استيراد الحزمة

```toml
rmcp = { version = "0.1", features = ["server"] }
## أو قناة التطوير
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### الاعتمادات الخارجية
الاعتمادات الأساسية:
- [tokio مطلوب](https://github.com/tokio-rs/tokio)
- [serde مطلوب](https://github.com/serde-rs/serde)



### بناء عميل
<details>
<summary>بدء عميل</summary>

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

### بناء خادم

<details>
<summary>بناء وسيلة نقل</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>بناء خدمة</summary>

يمكنك بسهولة بناء خدمة باستخدام [`ServerHandler`](crates/rmcp/src/handler/server.rs) أو [`ClientHandler`](crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>بدء الخادم</summary>

```rust, ignore
// هذا الاستدعاء سينهي عملية التهيئة
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>التفاعل مع الخادم</summary>

بمجرد تهيئة الخادم، يمكنك إرسال الطلبات أو الإشعارات:

```rust, ignore
// طلب
let roots = server.list_roots().await?;

// أو إرسال إشعار
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>انتظار إيقاف الخدمة</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// أو إلغاؤها
let quit_reason = server.cancel().await?;
```
</details>


## أمثلة

انظر [examples](examples/README.md)

## دعم OAuth

انظر [oauth_support](docs/OAUTH_SUPPORT.md) لمزيد من التفاصيل.


## موارد ذات صلة

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## مشاريع ذات صلة
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - تنفيذ خادم MCP قائم على containerd

## التطوير باستخدام Dev Container
انظر [docs/DEVCONTAINER.md](docs/DEVCONTAINER.md) للحصول على تعليمات حول استخدام Dev Container للتطوير.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---