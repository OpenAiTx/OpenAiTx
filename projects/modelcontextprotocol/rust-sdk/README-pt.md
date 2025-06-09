<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Aguarde o primeiro lançamento.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Uma implementação oficial do SDK Model Context Protocol em Rust com runtime assíncrono tokio.


Este repositório contém os seguintes crates:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): O crate principal que fornece a implementação do protocolo RMCP (Se quiser mais informações, visite [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Um crate de macros procedurais para geração de implementações de ferramentas RMCP (Se quiser mais informações, visite [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Uso

### Importe o crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## ou canal de desenvolvimento
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Dependências Terceiras
Dependências básicas:
- [tokio obrigatório](https://github.com/tokio-rs/tokio)
- [serde obrigatório](https://github.com/serde-rs/serde)



### Construir um Cliente
<details>
<summary>Iniciar um cliente</summary>

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

### Construir um Servidor

<details>
<summary>Construir um transporte</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Construir um serviço</summary>

Você pode facilmente construir um serviço utilizando [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) ou [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Iniciar o servidor</summary>

```rust, ignore
// esta chamada finalizará o processo de inicialização
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interagir com o servidor</summary>

Uma vez que o servidor esteja inicializado, você pode enviar requisições ou notificações:

```rust, ignore
// requisição
let roots = server.list_roots().await?;

// ou enviar notificação
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Aguardando o encerramento do serviço</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// ou cancelar
let quit_reason = server.cancel().await?;
```
</details>


## Exemplos

Veja [exemplos](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Suporte a OAuth

Veja [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) para detalhes.


## Recursos Relacionados

- [Especificação MCP](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Projetos Relacionados
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Uma implementação de servidor MCP baseada em containerd

## Desenvolvimento com Dev Container
Veja [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) para instruções sobre o uso do Dev Container para desenvolvimento.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---