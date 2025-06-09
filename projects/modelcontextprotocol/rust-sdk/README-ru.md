<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
Ожидайте первого релиза.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Официальная реализация SDK Model Context Protocol на Rust с использованием асинхронного рантайма tokio.


Этот репозиторий содержит следующие крейты:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): Основной крейт, предоставляющий реализацию протокола RMCP (Чтобы узнать больше, посетите [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): Крейты процедурных макросов для генерации реализаций инструментов RMCP (Чтобы узнать больше, посетите [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Использование

### Импорт крейта

```toml
rmcp = { version = "0.1", features = ["server"] }
## или dev-канал
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Сторонние зависимости
Базовые зависимости:
- [требуется tokio](https://github.com/tokio-rs/tokio)
- [требуется serde](https://github.com/serde-rs/serde)



### Создание клиента
<details>
<summary>Запуск клиента</summary>

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

### Создание сервера

<details>
<summary>Построение транспорта</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Построение сервиса</summary>

Вы можете легко построить сервис с помощью [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) или [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Запуск сервера</summary>

```rust, ignore
// этот вызов завершит процесс инициализации
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Взаимодействие с сервером</summary>

После инициализации сервера вы можете отправлять запросы или уведомления:

```rust, ignore
// запрос
let roots = server.list_roots().await?;

// или отправить уведомление
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Ожидание завершения работы сервиса</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// или отменить его
let quit_reason = server.cancel().await?;
```
</details>


## Примеры

См. [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Поддержка OAuth

Подробнее см. в [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md).


## Связанные ресурсы

- [MCP Specification](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Схема](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Связанные проекты
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) — Реализация MCP сервера на базе containerd

## Разработка с использованием Dev Container
Инструкции по использованию Dev Container для разработки см. в [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---