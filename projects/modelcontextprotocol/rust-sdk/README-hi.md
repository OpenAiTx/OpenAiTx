<div align = "right">
<a href="docs/readme/README.zh-cn.md">简体中文(待更新)</a>
</div>

# RMCP
पहली रिलीज़ का इंतजार करें।
<!-- [![Crates.io Version](todo)](todo) -->
<!-- ![Release status](https://github.com/modelcontextprotocol/rust-sdk/actions/workflows/release.yml/badge.svg) -->
<!-- [![docs.rs](todo)](todo) -->
![Coverage](docs/coverage.svg)

tokio असिंक रनटाइम के साथ एक आधिकारिक rust Model Context Protocol SDK इम्प्लीमेंटेशन।

इस रिपॉजिटरी में निम्नलिखित क्रेट्स शामिल हैं:

- [rmcp](crates/rmcp): आरएमसीपी प्रोटोकॉल इम्प्लीमेंटेशन प्रदान करने वाला कोर क्रेट (अधिक जानकारी के लिए कृपया देखें [rmcp](crates/rmcp/README.md))
- [rmcp-macros](crates/rmcp-macros): आरएमसीपी टूल इम्प्लीमेंटेशन के लिए एक प्रक्रियात्मक मैक्रो क्रेट (अधिक जानकारी के लिए कृपया देखें [rmcp-macros](crates/rmcp-macros/README.md))

## उपयोग

### क्रेट इम्पोर्ट करें

```toml
rmcp = { version = "0.1", features = ["server"] }
## या dev चैनल
rmcp = { git = "https://github.com/modelcontextprotocol/rust-sdk", branch = "main" }
```
### तीसरे पक्ष की निर्भरताएँ
मूलभूत निर्भरताएँ:
- [tokio आवश्यक](https://github.com/tokio-rs/tokio)
- [serde आवश्यक](https://github.com/serde-rs/serde)



### क्लाइंट बनाएं
<details>
<summary>एक क्लाइंट शुरू करें</summary>

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

### सर्वर बनाएं

<details>
<summary>ट्रांसपोर्ट बनाएं</summary>

```rust, ignore
use tokio::io::{stdin, stdout};
let transport = (stdin(), stdout());
```

</details>

<details>
<summary>सर्विस बनाएं</summary>

आप आसानी से [`ServerHandler`](crates/rmcp/src/handler/server.rs) या [`ClientHandler`](crates/rmcp/src/handler/client.rs) का उपयोग करके एक सर्विस बना सकते हैं।

```rust, ignore
let service = common::counter::Counter::new();
```
</details>

<details>
<summary>सर्वर शुरू करें</summary>

```rust, ignore
// यह कॉल इनिशियलाइज़ेशन प्रक्रिया को पूरा कर देगा
let server = service.serve(transport).await?;
```
</details>

<details>
<summary>सर्वर के साथ इंटरैक्ट करें</summary>

एक बार सर्वर इनिशियलाइज़ हो जाने के बाद, आप अनुरोध या नोटिफिकेशन भेज सकते हैं:

```rust, ignore
// अनुरोध
let roots = server.list_roots().await?;

// या नोटिफिकेशन भेजें
server.notify_cancelled(...).await?;
```
</details>

<details>
<summary>सर्विस शटडाउन का इंतजार करना</summary>

```rust, ignore
let quit_reason = server.waiting().await?;
// या इसे रद्द करें
let quit_reason = server.cancel().await?;
```
</details>


## उदाहरण

देखें [examples](examples/README.md)

## OAuth सपोर्ट

विवरण के लिए देखें [oauth_support](docs/OAUTH_SUPPORT.md)।

## संबंधित संसाधन

- [MCP विनिर्देश](https://spec.modelcontextprotocol.io/specification/2024-11-05/)
- [Schema](https://github.com/modelcontextprotocol/specification/blob/main/schema/2024-11-05/schema.ts)

## संबंधित प्रोजेक्ट्स
- [containerd-mcp-server](https://github.com/jokemanfire/mcp-containerd) - एक containerd-आधारित MCP सर्वर इम्प्लीमेंटेशन

## Dev Container के साथ डेवलपमेंट
डेवलपमेंट के लिए Dev Container का उपयोग करने के निर्देशों के लिए देखें [docs/DEVCONTAINER.md](docs/DEVCONTAINER.md)।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---