## 新功能：用 Gemini 阅读，用 Claude 编辑 + 差异比较

<div align="center">
  <img width="400" alt="screenshot 2025-07-13 at 07 09 45"
       src="https://github.com/user-attachments/assets/5fccba53-71ce-4546-8aed-b1095c5a1ca8" />
</div>

---

> **注意：**  
> - 如果你的 Gemini CLI 安装已经包含其他 MCP 工具，它们可能会与 gemini-mcp-tool 产生交互，导致冲突或当这些 MCP 直接写入 stdout 时出现意外的控制台输出。  
> - 你可以通过让 Gemini 调用自身来嵌套提示（例如，`ask gemini to ask gemini`），但如果请求超出你的配额，它不会自动回退。  
> - 要使用更快、更低成本的 flash 模型，请在命令后附加 `flash`（例如，`... using flash ...`）。

> 🚀 **分享你的体验！** [告诉我们你的感受](https://github.com/jamubc/gemini-mcp-tool/discussions/2)，帮助社区成长！

> 📚 [维基文档](https://github.com/jamubc/gemini-mcp-tool/wiki) 提供了更多指南和示例。  
>  
> 贡献框架目前处于测试阶段。我们的目标是利用 Gemini 创建 gemini-mcp-tool 扩展，自动化工具创建，并提供基于 TUI 的工具生成器。

# Gemini MCP 工具

<div align="center">

[![GitHub 发布](https://img.shields.io/github/v/release/jamubc/gemini-mcp-tool?logo=github&label=GitHub)](https://github.com/jamubc/gemini-mcp-tool/releases)
[![npm 版本](https://img.shields.io/npm/v/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![npm 下载量](https://img.shields.io/npm/dt/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![许可证: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![开源](https://img.shields.io/badge/Open%20Source-❤️-red.svg)](https://github.com/jamubc/gemini-mcp-tool)

</div>

<a href="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool/badge" alt="Gemini 工具 MCP 服务器" />
</a>

> 📚 **[查看完整文档](https://jamubc.github.io/gemini-mcp-tool/)** - 搜索我！示例，常见问题，故障排除，最佳实践

这是一个简单的模型上下文协议（MCP）服务器，允许 AI 助手与 [Gemini CLI](https://github.com/google-gemini/gemini-cli) 交互。它使 AI 能够利用 Gemini 大型令牌窗口的强大功能进行大规模分析，特别是使用 `@` 语法对大型文件和代码库进行指令。

## 简要说明: [![Claude](https://img.shields.io/badge/Claude-D97757?logo=claude&logoColor=fff)](#) + [![Google Gemini](https://img.shields.io/badge/Google%20Gemini-886FBF?logo=googlegemini&logoColor=fff)](#)

**目标**：直接在 Claude Code 中使用 Gemini 强大的分析能力，节省令牌并分析大型文件。

### 一行设置



```bash
claude mcp add gemini-cli -- npx -y gemini-mcp-tool
```
### 验证安装

在 Claude Code 中输入 `/mcp` 以验证 gemini-cli MCP 是否已激活。

---

### 备选方案：从 Claude Desktop 导入

如果你已经在 Claude Desktop 中配置了它：

1. 添加到你的 Claude Desktop 配置：

```json
"gemini-cli": {
  "command": "npx",
  "args": ["-y", "gemini-mcp-tool"]
}
```
2. 导入到Claude代码：

```bash
claude mcp add-from-claude-desktop
```
## 前提条件

在使用此工具之前，请确保您已具备：

1. **[Node.js](https://nodejs.org/)**（v16.0.0 或更高版本）
2. **[Google Gemini CLI](https://github.com/google-gemini/gemini-cli)** 已安装并配置

## 安装选项

### 选项1：NPX（推荐）
无需安装 - 该工具可直接通过 `npx` 运行。

### 选项2：全局安装

```bash
npm install -g gemini-mcp-tool
```
## 配置

使用您的 MCP 客户端注册 MCP 服务器：

### NPX 使用方法（推荐）

将此配置添加到您的 Claude Desktop 配置文件中：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "npx",
      "args": ["-y", "gemini-mcp-tool"]
    }
  }
}
```
### 全局安装

如果您进行了全局安装，请使用此配置：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "gemini-mcp"
    }
  }
}
```
**配置文件位置：**

- **Claude 桌面版**：
  - **macOS**：`~/Library/Application Support/Claude/claude_desktop_config.json`
  - **Windows**：`%APPDATA%\Claude\claude_desktop_config.json`
  - **Linux**：`~/.config/claude/claude_desktop_config.json`

更新配置后，请重启终端会话。

## 可用命令

- **自然语言**：“使用 gemini 解释 index.html”，“使用 gemini 理解大型项目”，“让 gemini 搜索最新新闻”
- **Claude 代码**：输入 `/gemini-cli`，命令将显示在 Claude 代码界面中。

## 使用示例

### 带文件引用（使用 @ 语法）

- `让 gemini 分析 @src/main.js 并解释它的功能`
- `使用 gemini 总结 @. 当前目录`
- `分析 @package.json 并告诉我依赖信息`

### 一般问题（无文件）

- `让 gemini 搜索最新技术新闻`
- `使用 gemini 解释 div 居中`
- `询问 gemini 关于 React 开发的最佳实践，关联文件 @file_im_confused_about`

### 使用 Gemini CLI 的沙箱模式（-s）

沙箱模式允许你在隔离环境中安全测试代码更改、运行脚本或执行潜在风险操作。

- `使用 gemini 沙箱创建并运行处理数据的 Python 脚本`
- `让 gemini 安全测试 @script.py 并解释它的作用`
- `使用 gemini 沙箱安装 numpy 并创建数据可视化`
- `安全测试此代码：创建一个向 API 发送 HTTP 请求的脚本`

### 工具（供 AI 使用）

这些工具设计供 AI 助手使用。

- **`ask-gemini`**：向 Google Gemini 询问观点。可用于一般问题或复杂文件分析。
  - **`prompt`**（必需）：分析请求。使用 `@` 语法包含文件或目录引用（例如 `@src/main.js 解释此代码`）或提出一般问题（例如 `请使用网络搜索查找最新新闻`）。
  - **`model`**（可选）：使用的 Gemini 模型。默认是 `gemini-2.5-flash`。
  - **`sandbox`**（可选）：设置为 `true` 以安全代码执行模式运行。
- **`sandbox-test`**：在 Gemini 沙箱环境中安全执行代码或命令。始终以沙箱模式运行。
  - **`prompt`**（必需）：代码测试请求（例如 `创建并运行一个 Python 脚本...` 或 `@script.py 安全运行此脚本`）。
  - **`model`**（可选）：使用的 Gemini 模型。
- **`Ping`**：一个简单的测试工具，回显消息。
- **`Help`**：显示 Gemini CLI 帮助文本。

### 斜杠命令（供用户使用）

你可以直接在 Claude 代码界面使用这些命令（其他客户端兼容性未测试）。

- **/analyze**：使用 Gemini 分析文件或目录，或提出一般问题。
  - **`prompt`**（必需）：分析提示。使用 `@` 语法包含文件（例如 `/analyze prompt:@src/ 总结此目录`）或提出一般问题（例如 `/analyze prompt:请使用网络搜索查找最新新闻`）。
- **/sandbox**：在 Gemini 沙箱环境中安全测试代码或脚本。
  - **`prompt`**（必需）：代码测试请求（例如 `/sandbox prompt:创建并运行处理 CSV 数据的 Python 脚本` 或 `/sandbox prompt:@script.py 安全测试此脚本`）。
- **/help**：显示 Gemini CLI 帮助信息。
- **/ping**：测试与服务器的连接。
  - **`message`**（可选）：要回显的消息。

## 贡献

欢迎贡献！请参阅我们的[贡献指南](https://raw.githubusercontent.com/jamubc/gemini-mcp-tool/main/CONTRIBUTING.md)了解如何提交拉取请求、报告问题及参与项目。

## 许可证

本项目采用 MIT 许可证。详情请见 [LICENSE](LICENSE) 文件。

**免责声明：** 本工具为非官方第三方工具，与 Google 无关联，未获其认可或赞助。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---