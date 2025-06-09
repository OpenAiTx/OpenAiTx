<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
En attente de la première version.
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/coverage.svg)

Une implémentation officielle du SDK Rust Model Context Protocol avec l'environnement d'exécution asynchrone tokio.

Ce dépôt contient les crates suivantes :

- [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp) : La crate principale fournissant l’implémentation du protocole RMCP (Pour plus d’informations, veuillez consulter [rmcp](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/README.md))
- [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros) : Une crate de macros procédurales pour générer des outils RMCP (Pour plus d’informations, veuillez consulter [rmcp-macros](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp-macros/README.md))

## Utilisation

### Importer la crate

```toml
rmcp = { version = "0.1", features = ["server"] }
## ou canal dev
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### Dépendances tierces
Dépendances de base :
- [tokio requis](https://github.com/tokio-rs/tokio)
- [serde requis](https://github.com/serde-rs/serde)



### Construire un client
<details>
<summary>Démarrer un client</summary>

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

### Construire un serveur

<details>
<summary>Construire un transport</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>Construire un service</summary>

Vous pouvez facilement construire un service en utilisant [`ServerHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/server.rs) ou [`ClientHandler`](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/crates/rmcp/src/handler/client.rs).

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>Démarrer le serveur</summary>

```rust, ignore
// cet appel termine le processus d’initialisation
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>Interagir avec le serveur</summary>

Une fois le serveur initialisé, vous pouvez envoyer des requêtes ou des notifications :

```rust, ignore
// requête
let roots = server.list_roots().await?;

// ou envoyer une notification
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>Attendre l’arrêt du service</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// ou l'annuler
let quit_reason = server.cancel().await?;
```
</details>


## Exemples

Voir [examples](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/examples/README.md)

## Support OAuth

Voir [oauth_support](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/OAUTH_SUPPORT.md) pour plus de détails.


## Ressources associées

- [Spécification MCP](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schéma](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## Projets associés
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - Une implémentation du serveur MCP basée sur containerd

## Développement avec Dev Container
Voir [docs/DEVCONTAINER.md](https://raw.githubusercontent.com/modelcontextprotocol/rust-sdk/main/docs/DEVCONTAINER.md) pour les instructions d’utilisation de Dev Container pour le développement.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---