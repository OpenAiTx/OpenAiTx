<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
İlk sürüm için bekleyin.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Tokio async çalışma zamanı ile resmi bir Rust Model Context Protocol SDK uygulaması.


Bu depo aşağıdaki paketleri içerir:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): RMCP protokol uygulamasını sağlayan çekirdek paket (Daha fazla bilgi almak için lütfen [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md) adresini ziyaret edin)
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): RMCP araç uygulamaları oluşturmak için prosedürel makro paketi (Daha fazla bilgi almak için lütfen [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md) adresini ziyaret edin)

## Kullanım

### Paketi içe aktar

```toml
rmcp = { version = "0.1", features = ["server"] }
## veya geliştirme kanalı
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Üçüncü Parti Bağımlılıklar
Temel bağımlılıklar:
- [tokio gereklidir](https://github.com/tokio-rs/tokio)
- [serde gereklidir](https://github.com/serde-rs/serde)



### Bir İstemci Oluşturma
<details>
<summary>Bir istemci başlat</summary>

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

### Bir Sunucu Oluşturma

<details>
<summary>Bir taşıma katmanı oluştur</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Bir servis oluştur</summary>

[`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) veya [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs) kullanarak kolayca bir servis oluşturabilirsiniz.

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Sunucuyu başlat</summary>

```rust, ignore
// bu çağrı başlatma işlemini tamamlar
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Sunucu ile etkileşim</summary>

Sunucu başlatıldıktan sonra, istek veya bildirim gönderebilirsiniz:

```rust, ignore
// istek
let roots = server.list_roots().await?;

// veya bildirim gönder
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Servisin kapanmasını bekleme</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// veya iptal et
let quit_reason = server.cancel().await?;
```
</details>


## Örnekler

[examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md) bölümüne bakınız

## OAuth Desteği

Ayrıntılar için [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) bölümüne bakınız.


## İlgili Kaynaklar

- [MCP Spesifikasyonu](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Şema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## İlgili Projeler
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Containerd tabanlı MCP sunucu uygulaması

## Dev Container ile Geliştirme
Geliştirme için Dev Container kullanım talimatları için [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) dosyasına bakınız.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---