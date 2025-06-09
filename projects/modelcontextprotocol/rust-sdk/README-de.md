<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Warten auf die erste Veröffentlichung.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Eine offizielle Rust Model Context Protocol SDK-Implementierung mit Tokio-Async-Runtime.


Dieses Repository enthält die folgenden Crates:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): Das Kern-Crate, das die RMCP-Protokollimplementierung bereitstellt (Wenn Sie mehr Informationen erhalten möchten, besuchen Sie bitte [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Ein Prozedur-Makro-Crate zur Generierung von RMCP-Tool-Implementierungen (Wenn Sie mehr Informationen erhalten möchten, besuchen Sie bitte [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Verwendung

### Importieren des Crates

```toml
rmcp = { version = "0.1", features = ["server"] }
## oder Dev-Channel
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Drittabhängigkeiten
Grundlegende Abhängigkeiten:
- [tokio erforderlich](https://github.com/tokio-rs/tokio)
- [serde erforderlich](https://github.com/serde-rs/serde)



### Client erstellen
<details>
<summary>Client starten</summary>

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

### Server erstellen

<details>
<summary>Transport aufbauen</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Service aufbauen</summary>

Sie können ganz einfach einen Service mit [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) oder [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs) erstellen.

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Server starten</summary>

```rust, ignore
// Dieser Aufruf schließt den Initialisierungsprozess ab
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Mit dem Server interagieren</summary>

Sobald der Server initialisiert ist, können Sie Anfragen oder Benachrichtigungen senden:

```rust, ignore
// Anfrage
let roots = server.list_roots().await?;

// oder Benachrichtigung senden
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Warten auf das Herunterfahren des Dienstes</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// oder abbrechen
let quit_reason = server.cancel().await?;
```
</details>


## Beispiele

Siehe [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## OAuth-Unterstützung

Siehe [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) für Details.


## Verwandte Ressourcen

- [MCP Spezifikation](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Verwandte Projekte
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Eine containerd-basierte MCP-Server-Implementierung

## Entwicklung mit Dev Container
Siehe [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) für Anweisungen zur Verwendung von Dev Container für die Entwicklung.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---