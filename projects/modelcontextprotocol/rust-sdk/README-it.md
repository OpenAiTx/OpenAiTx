<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Attendere la prima release.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](docs/coverage.svg)

Un'implementazione ufficiale dell'SDK Model Context Protocol in Rust con runtime asincrono tokio.


Questo repository contiene i seguenti crate:

- [rmcp](crates/rmcp): Il crate principale che fornisce l'implementazione del protocollo RMCP (per ulteriori informazioni, visita [rmcp](crates/rmcp/README.md))
- [rmcp-macros](crates/rmcp-macros): Un crate di macro procedurali per generare implementazioni di tool RMCP (per ulteriori informazioni, visita [rmcp-macros](crates/rmcp-macros/README.md))

## Utilizzo

### Importa il crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## oppure canale dev
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Dipendenze di terze parti
Dipendenze di base:
- [tokio richiesto](https://github.com/tokio-rs/tokio)
- [serde richiesto](https://github.com/serde-rs/serde)



### Costruire un Client
<details>
<summary>Avvia un client</summary>

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

### Costruire un Server

<details>
<summary>Costruire un transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Costruire un servizio</summary>

Puoi facilmente costruire un servizio utilizzando [`ServerHandler`](crates/rmcp/src/handler/server.rs) o [`ClientHandler`](crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Avvia il server</summary>

```rust, ignore
// questa chiamata completerà il processo di inizializzazione
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interagire con il server</summary>

Una volta che il server è stato inizializzato, puoi inviare richieste o notifiche:

```rust, ignore
// richiesta
let roots = server.list_roots().await?;

// oppure invia una notifica
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Attendere l'arresto del servizio</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// oppure annullalo
let quit_reason = server.cancel().await?;
```
</details>


## Esempi

Vedi [examples](examples/README.md)

## Supporto OAuth

Vedi [oauth_support](docs/OAUTH_SUPPORT.md) per dettagli.


## Risorse correlate

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Progetti correlati
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Un'implementazione MCP server basata su containerd

## Sviluppo con Dev Container
Vedi [docs/DEVCONTAINER.md](docs/DEVCONTAINER.md) per istruzioni sull'uso di Dev Container per lo sviluppo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---