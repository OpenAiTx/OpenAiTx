<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Wacht op de eerste release.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Een officiële rust Model Context Protocol SDK-implementatie met tokio async runtime.


Deze repository bevat de volgende crates:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): De kerncrate die de RMCP-protocolimplementatie biedt (Als je meer informatie wilt, bezoek [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Een proc-macro crate voor het genereren van RMCP tool-implementaties (Als je meer informatie wilt, bezoek [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Gebruik

### Importeer de crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## of dev channel
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Derde afhankelijkheden
Basisafhankelijkheden:
- [tokio vereist](https://github.com/tokio-rs/tokio)
- [serde vereist](https://github.com/serde-rs/serde)



### Bouw een Client
<details>
<summary>Start een client</summary>

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

### Bouw een Server

<details>
<summary>Bouw een transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Bouw een service</summary>

Je kunt eenvoudig een service bouwen met [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) of [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Start de server</summary>

```rust, ignore
// deze aanroep zal het initialisatieproces afronden
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interactie met de server</summary>

Zodra de server is geïnitialiseerd, kun je verzoeken of notificaties sturen:

```rust, ignore
// verzoek
let roots = server.list_roots().await?;

// of stuur een notificatie
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Wachten op het afsluiten van de service</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// of annuleer het
let quit_reason = server.cancel().await?;
```
</details>


## Voorbeelden

Zie [voorbeelden](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## OAuth-ondersteuning

Zie [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) voor details.


## Gerelateerde Bronnen

- [MCP Specificatie](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Gerelateerde Projecten
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Een containerd-gebaseerde MCP-serverimplementatie

## Ontwikkelen met Dev Container
Zie [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) voor instructies voor het gebruik van Dev Container voor ontwikkeling.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---