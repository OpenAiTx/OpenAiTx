<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Poczekaj na pierwsze wydanie.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Oficjalna implementacja Model Context Protocol SDK w języku Rust z wykorzystaniem asynchronicznego środowiska uruchomieniowego tokio.

To repozytorium zawiera następujące craty:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): Główny crate dostarczający implementację protokołu RMCP (Aby uzyskać więcej informacji, odwiedź [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Crate proceduralny do generowania implementacji narzędzi RMCP (Aby uzyskać więcej informacji, odwiedź [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Użycie

### Importuj crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## lub kanał deweloperski
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Zewnętrzne zależności
Podstawowe zależności:
- [wymagany tokio](https://github.com/tokio-rs/tokio)
- [wymagany serde](https://github.com/serde-rs/serde)



### Budowanie klienta
<details>
<summary>Uruchom klienta</summary>

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

### Budowanie serwera

<details>
<summary>Budowanie transportu</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Budowanie usługi</summary>

Możesz łatwo zbudować usługę używając [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) lub [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Uruchom serwer</summary>

```rust, ignore
// to wywołanie zakończy proces inicjalizacji
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interakcja z serwerem</summary>

Po zainicjowaniu serwera możesz wysyłać żądania lub powiadomienia:

```rust, ignore
// żądanie
let roots = server.list_roots().await?;

// lub wyślij powiadomienie
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Oczekiwanie na zamknięcie usługi</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// lub anuluj
let quit_reason = server.cancel().await?;
```
</details>


## Przykłady

Zobacz [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Wsparcie OAuth

Szczegóły w [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md).


## Powiązane zasoby

- [Specyfikacja MCP](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schemat](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Powiązane projekty
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Implementacja serwera MCP oparta na containerd

## Rozwój z Dev Container
Zobacz [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) po instrukcje dotyczące używania Dev Container do rozwoju.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---