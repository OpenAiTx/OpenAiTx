<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Espere el primer lanzamiento.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](docs/coverage.svg)

Una implementación oficial del SDK de Model Context Protocol en Rust con runtime asíncrono tokio.

Este repositorio contiene los siguientes crates:

- [rmcp](crates/rmcp): El crate principal que proporciona la implementación del protocolo RMCP (Si desea obtener más información, visite [rmcp](crates/rmcp/README.md))
- [rmcp-macros](crates/rmcp-macros): Un crate de macros procedurales para generar implementaciones de herramientas RMCP (Si desea obtener más información, visite [rmcp-macros](crates/rmcp-macros/README.md))

## Uso

### Importar el crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## o canal de desarrollo
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Dependencias de terceros
Dependencias básicas:
- [tokio requerido](https://github.com/tokio-rs/tokio)
- [serde requerido](https://github.com/serde-rs/serde)



### Construir un Cliente
<details>
<summary>Iniciar un cliente</summary>

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

### Construir un Servidor

<details>
<summary>Construir un transporte</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Construir un servicio</summary>

Puede construir fácilmente un servicio usando [`ServerHandler`](crates/rmcp/src/handler/server.rs) o [`ClientHandler`](crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Iniciar el servidor</summary>

```rust, ignore
// esta llamada completará el proceso de inicialización
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interactuar con el servidor</summary>

Una vez que el servidor está inicializado, puede enviar solicitudes o notificaciones:

```rust, ignore
// solicitud
let roots = server.list_roots().await?;

// o enviar una notificación
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Esperar el apagado del servicio</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// o cancelarlo
let quit_reason = server.cancel().await?;
```
</details>


## Ejemplos

Vea [examples](examples/README.md)

## Soporte OAuth

Vea [oauth_support](docs/OAUTH_SUPPORT.md) para más detalles.


## Recursos Relacionados

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Proyectos Relacionados
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Una implementación de servidor MCP basada en containerd

## Desarrollo con Dev Container
Vea [docs/DEVCONTAINER.md](docs/DEVCONTAINER.md) para instrucciones sobre el uso de Dev Container para desarrollo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---