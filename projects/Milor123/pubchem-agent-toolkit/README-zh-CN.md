# 面向AI助手的增强型PubChem MCP服务器

🧪 一款先进、强大且注重隐私的MCP服务器，使AI助手能够智能搜索并访问PubChem中的化合物信息。

此PubChem MCP服务器作为AI助手（如AnythingLLM中的助手）与PubChem庞大化学数据库之间的强大桥梁。它利用模型上下文协议（MCP），允许AI模型智能、稳健地搜索化学化合物，并以编程方式检索其详细属性。

---

## ✨ 核心功能

这不仅仅是另一个PubChem封装器。该服务器从头重建，具备高度的鲁棒性和智能性：

-   **🧠 智能回退搜索**：如果搜索常用名称（如“维生素D”）失败，服务器会自动在PubChem物质数据库中进行更深入的搜索，以找到正确的化合物。这大大提高了模糊查询的成功率。
-   **🛡️ 稳健的错误处理与重试**：服务器设计用以优雅地处理API错误。如果遇到PubChem的“服务器繁忙”错误，它会自动等待并重试请求，确保您的查询即使在高负载下也能成功。
-   **🔒 可选Tor代理支持**：您完全控制您的隐私。通过一个简单的`config.ini`文件，您可以将所有请求通过Tor网络（通过SOCKS5或HTTP代理）路由，防止IP地址泄露。服务器默认安全，代理连接失败时**绝不会**泄露您的IP。
-   **🔎 单个及多个化合物搜索**：无缝处理单个或多个化合物的请求。
-   **🧪 详细属性检索**：访问关键化学属性，如IUPAC名称、分子式、分子量，尤其是**单同位素质量**。

---

---

### 🚀 无需安装：在Smithery.ai上在线体验

对于MCP服务器新手或仅想测试此工具功能而无需本地设置的用户，Smithery.ai提供了一个在线托管版本。您可以直接在浏览器中与代理聊天。

[**<-- 在Smithery.ai上探索实时PubChem代理 -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**如何开始：**

1.  点击上方链接进入服务器页面。
2.  使用您的**GitHub**或**Google**账号登录。
3.  点击**“探索功能”**按钮，打开聊天界面开始测试！

> **✅ 推荐使用模型以获得最佳效果**
>
> 为了获得最高准确度，尤其是处理长小数数字时，我们强烈推荐使用强大的模型。以下模型已测试，表现优异：
>
> *   **Anthropic的Claude 3 Sonnet**
> *   **OpenAI的GPT-4 Turbo**（或更新版本如GPT-4o）
>
> 我们确认两个模型都能正确处理工具返回的十进制数字的全精度，且没有任何舍入。

---

## 🚀 快速开始与安装

此服务器设计为本地运行，可以在您的桌面或 AnythingLLM Docker 环境中运行。

### 1. 依赖项

该项目依赖于一些 Python 库。请确保它们已安装在您的环境中。

创建一个 `requirements.txt` 文件，内容如下：
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---