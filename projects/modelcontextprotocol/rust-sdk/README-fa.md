<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
منتظر اولین انتشار باشید.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

یک پیاده‌سازی رسمی SDK پروتکل Model Context به زبان rust با اجرای async توسط tokio.

این مخزن شامل کرِیت‌های زیر است:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): کرِیت اصلی که پیاده‌سازی پروتکل RMCP را فراهم می‌کند (برای اطلاعات بیشتر به [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md) مراجعه کنید)
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): یک کرِیت macro رویه‌ای برای تولید پیاده‌سازی ابزارهای RMCP (برای اطلاعات بیشتر به [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md) مراجعه کنید)

## نحوه استفاده

### وارد کردن کرِیت

```toml
rmcp = { version = "0.1", features = ["server"] }
## یا شاخه توسعه
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### وابستگی‌های ثالث
وابستگی‌های پایه:
- [tokio مورد نیاز](https://github.com/tokio-rs/tokio)
- [serde مورد نیاز](https://github.com/serde-rs/serde)



### ساخت کلاینت
<details>
<summary>راه‌اندازی یک کلاینت</summary>

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

### ساخت سرور

<details>
<summary>ساخت ترنسپورت</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>ساخت سرویس</summary>

شما می‌توانید به راحتی یک سرویس با استفاده از [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) یا [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs) بسازید.

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>راه‌اندازی سرور</summary>

```rust, ignore
// این فراخوانی فرایند مقداردهی اولیه را تکمیل می‌کند
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>تعامل با سرور</summary>

پس از مقداردهی اولیه سرور، می‌توانید درخواست‌ها یا اعلان‌ها را ارسال کنید:

```rust, ignore
// درخواست
let roots = server.list_roots().await?;

// یا ارسال اعلان
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>منتظر خاموش شدن سرویس باشید</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// یا آن را لغو کنید
let quit_reason = server.cancel().await?;
```
</details>


## مثال‌ها

به [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md) مراجعه کنید

## پشتیبانی OAuth

برای جزئیات به [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) مراجعه کنید.


## منابع مرتبط

- [مشخصات MCP](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [اسکیما](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## پروژه‌های مرتبط
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - پیاده‌سازی سرور MCP مبتنی بر containerd

## توسعه با Dev Container
برای دستورالعمل‌های استفاده از Dev Container برای توسعه، به [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) مراجعه کنید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---