<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Tunggu rilis pertama.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Implementasi resmi SDK Model Context Protocol untuk Rust dengan runtime async tokio.

Repositori ini berisi crate berikut:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): Crate inti yang menyediakan implementasi protokol RMCP (Untuk informasi lebih lanjut, silakan kunjungi [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Crate macro prosedural untuk menghasilkan implementasi alat RMCP (Untuk informasi lebih lanjut, silakan kunjungi [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Penggunaan

### Impor crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## atau channel dev
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Ketergantungan Pihak Ketiga
Ketergantungan dasar:
- [tokio diperlukan](https://github.com/tokio-rs/tokio)
- [serde diperlukan](https://github.com/serde-rs/serde)

### Membangun Klien
<details>
<summary>Memulai klien</summary>

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

### Membangun Server

<details>
<summary>Membangun transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Membangun service</summary>

Anda dapat dengan mudah membangun service menggunakan [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) atau [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Menjalankan server</summary>

```rust, ignore
// panggilan ini akan menyelesaikan proses inisialisasi
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Berinteraksi dengan server</summary>

Setelah server diinisialisasi, Anda dapat mengirim permintaan atau notifikasi:

```rust, ignore
// request
let roots = server.list_roots().await?;

// atau kirim notifikasi
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Menunggu penghentian service</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// atau batalkan
let quit_reason = server.cancel().await?;
```
</details>

## Contoh

Lihat [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Dukungan OAuth

Lihat [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) untuk detailnya.

## Sumber Daya Terkait

- [Spesifikasi MCP](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Skema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Proyek Terkait
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Implementasi server MCP berbasis containerd

## Pengembangan dengan Dev Container
Lihat [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) untuk instruksi penggunaan Dev Container dalam pengembangan.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---