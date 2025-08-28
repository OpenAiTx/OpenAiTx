
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>
# 增强版 PubChem MCP 服务器，助力 AI 助手

🧪 一款先进、强大且注重隐私的 MCP 服务器，使 AI 助手能够智能检索并访问 PubChem 的化合物信息。

此 PubChem MCP 服务器是 AI 助手（如 AnythingLLM 中的助手）与 PubChem 海量化学数据库之间的强大桥梁。它利用模型上下文协议（MCP），让 AI 模型能够智能、强韧地搜索化合物并以编程方式获取详细属性。

---

## ✨ 核心功能

这不仅仅是另一个 PubChem 封装器。该服务器从零开始重构，拥有极高的智能和鲁棒性：

-   **🧠 智能回退搜索**：如果对通用名称（如“维生素 D”）的搜索失败，服务器会自动在 PubChem Substance 数据库中进行更深入检索，找到正确化合物。此举显著提高了对模糊查询的成功率。
-   **🛡️ 强健的错误处理与重试机制**：服务器设计能优雅地处理 API 错误。如果遇到来自 PubChem 的“服务器繁忙”错误，会自动等待并重试请求，确保在高负载下也能成功查询。
-   **🔒 可选 Tor 代理支持**：您可以完全掌控隐私。简单的 `config.ini` 文件即可将所有请求通过 Tor 网络（SOCKS5 或 HTTP 代理）路由，防止您的 IP 地址被暴露。服务器默认安全，若代理连接失败，您的 IP **绝不会**被泄露。
-   **🔎 单/多化合物检索**：可在一次请求中无缝处理一个或多个化合物的查询。
-   **🧪 详细属性获取**：可访问关键化学属性，如 IUPAC 名称、分子式、分子量，尤其是**单同位素质量**。

---

---

### 🚀 无需安装：可在 Smithery.ai 在线体验

对于新接触 MCP 服务器或希望无需本地部署快速测试工具功能的用户，Smithery.ai 提供了在线托管版。您可直接在浏览器中与代理对话。

[**<-- 在 Smithery.ai 上体验 PubChem 在线代理 -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**快速开始指南：**

1.  点击上方链接进入服务器页面。
2.  使用您的 **GitHub** 或 **Google** 账号登录。
3.  点击 **“探索能力”** 按钮，打开聊天界面，即刻体验！

> **✅ 推荐模型，效果更佳**
>
> 为获得最高精度（尤其是长小数位的数值），强烈建议使用强大的模型。以下模型已测试并与该工具完美兼容：
>
> *   **Anthropic 的 Claude 3 Sonnet**

> *   **OpenAI 的 GPT-4 Turbo**（或更高版本，如 GPT-4o）
>
> 我们确认这两个模型都能正确处理工具返回的十进制数字的完整精度，无任何四舍五入。

---

## 🚀 快速开始与安装

本服务器设计为本地运行，可以在您的桌面或 AnythingLLM 的 Docker 环境中运行。

### 1. 依赖项

该项目依赖于一些 Python 库。请确保它们已安装在您的环境中。

创建一个 `requirements.txt` 文件，并填入以下内容：
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

使用 `uv` 或 `pip` 安装它们：
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(注意：只有在您计划使用 Tor SOCKS5 代理功能时，才需要 `PySocks`。)*

### 2. 配置

服务器通过一个 `config.ini` 文件进行配置，该文件在您首次运行时**会自动创建**。此文件将出现在与 `pubchem_server.py` 脚本相同的目录中。

**默认 `config.ini`：**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. 与 AnythingLLM 集成

按照官方文档将其添加为自定义 MCP 服务器。关键是将 `command` 指向你的 Python 可执行文件和 `pubchem_server.py` 脚本。

**AnythingLLM 桌面版示例（`plugins/anythingllm_mcp_servers.json`）：**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 使用 AnythingLLM 的实现示例

以下是与代理交互的一些示例。这些测试是使用 AnythingLLM 桌面版，通过 OpenRouter 连接到各种大型语言模型进行的。

我们测试中的一个关键发现是所选择模型的重要性。我们**强烈不建议使用小型或本地模型**来完成此任务。较小的模型往往难以正确解析工具返回的数据，导致错误，如幻觉值、格式错误，或最关键的，**对十进制数字进行四舍五入**，这违背了该高精度工具的初衷。

为了确保结果的完整性，始终建议验证 MCP 返回的原始数据。您可以在下一节学习如何操作：[3.2 如何在日志中验证 MCP 输出](#32-如何在日志中验证-mcp-输出)。

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

另一方面，多个模型表现出色。我们使用 **Google 的 `Gemini 2.5 Flash lite`** 取得了卓越的结果，它在处理长十进制数字和正确格式化最终 Markdown 表格方面表现出色。

Google gemini 2.5 flash lite 无提示和有提示时均保持完美小数（示例中使用了 0.6 温度）

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

针对这个特定任务，我个人最喜欢的是 **`Gemini 2.5 Flash lite`**，因为它表现出一致的准确性和可靠性。

### 3.2 如何在日志中验证 MCP 输出

确认代理接收正确数据且 LLM 无误的最佳方法是检查 MCP 服务器生成的调试日志文件。

该服务器配置为自动在项目目录的子文件夹中创建日志文件。文件位置为：

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```
在 `mcp_debug.log` 文件中，您将找到工具在模型处理之前发送回 LLM 的精确 JSON 数据。您可以手动检查此 JSON 以验证任何值，特别是来自诸如 `monoisotopic_mass` 这类属性的长小数，确保 LLM 在最终答案中未引入任何舍入错误或幻觉。

---

## 📊 使用方法

集成后，当询问化学信息时，您的 AI 助手将自动使用此工具。主要暴露的工具是 `search_compounds_by_name`。

### 示例提示

此提示演示了该工具处理包含不同名称类型的化合物列表并检索多个属性的能力。


```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
代理将调用 `search_compounds_by_name` 工具，该工具将智能地查找每个化合物，检索其数据，并将其返回给大型语言模型进行格式化。

---

## 🛠 MCP 工具暴露

### `search_compounds_by_name`

通过名称逐个搜索多个化合物，使用智能回退策略，配合暂停和重试以实现最大可靠性。

**参数：**
-   `names` (List[str]): 化合物名称列表。示例：`["Aspirin", "Ibuprofen"]`

**返回：** 一个字典列表，每个字典包含找到的化合物信息或详细说明该化合物搜索失败原因的错误信息。

---

## 🙏 致谢

本项目深受原始 [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) （由 **JackKuo666** 创建）基础的启发和构建。

虽然本仓库不是直接分支，但原始项目是关键起点。本版本增强了原始概念，重点在于极端的稳健性、智能搜索策略以及通过可选的 Tor 集成🧅保障用户隐私。

非常感谢原作者的精彩工作及其与社区的分享。

---

## ⚠️ 免责声明

本工具仅用于研究和教育目的。请尊重 PubChem 的服务条款，负责任地使用本工具。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---