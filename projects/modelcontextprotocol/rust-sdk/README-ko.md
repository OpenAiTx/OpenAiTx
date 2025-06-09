<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
첫 번째 릴리스를 기다려주세요.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

tokio async 런타임을 사용하는 공식 rust Model Context Protocol SDK 구현입니다.

이 저장소에는 다음 크레이트가 포함되어 있습니다:

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp): RMCP 프로토콜 구현을 제공하는 핵심 크레이트(자세한 정보를 원하시면 [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md)를 방문해 주세요)
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros): RMCP 도구 구현을 위한 프로시저 매크로 크레이트(자세한 정보를 원하시면 [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md)를 방문해 주세요)

## 사용법

### 크레이트 가져오기

```toml
rmcp = { version = "0.1", features = ["server"] }
## 또는 개발 채널
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### 서드파티 의존성
기본 의존성:
- [tokio 필수](https://github.com/tokio-rs/tokio)
- [serde 필수](https://github.com/serde-rs/serde)

### 클라이언트 구축
<details>
<summary>클라이언트 시작</summary>

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

### 서버 구축

<details>
<summary>트랜스포트 구축</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>서비스 구축</summary>

[`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) 또는 [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs)를 사용하여 쉽게 서비스를 구축할 수 있습니다.

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>서버 시작</summary>

```rust, ignore
// 이 호출은 초기화 과정을 마칩니다
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>서버와 상호작용</summary>

서버가 초기화되면 요청 또는 알림을 보낼 수 있습니다:

```rust, ignore
// 요청
let roots = server.list_roots().await?;

// 또는 알림 전송
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>서비스 종료 대기</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// 또는 취소
let quit_reason = server.cancel().await?;
```
</details>


## 예시

[examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)를 참조하세요.

## OAuth 지원

자세한 내용은 [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md)를 참조하세요.

## 관련 리소스

- [MCP 스펙](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [스키마](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## 관련 프로젝트
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - containerd 기반의 MCP 서버 구현

## Dev Container로 개발하기
Dev Container를 사용한 개발 방법은 [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md)를 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---