# VSCode 作为 MCP 服务器

[市场链接](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)

一款将你的 VSCode 转变为 MCP 服务器的扩展，支持来自 Claude Desktop 等 MCP 客户端的高级编码辅助。

## 主要功能

### 代码编辑支持
- 通过差异查看来自大语言模型（LLM）的代码变更建议，允许你接受、拒绝或提供反馈。
- 实时诊断信息（例如类型错误）即时发送给 LLM 以便快速修正。

![代码编辑差异](https://storage.googleapis.com/zenn-user-upload/778b7e9ad8c4-20250407.gif)

### 终端操作
- 在 VSCode 集成终端中执行命令（支持后台/前台执行及超时设置）。

### 预览工具
- 直接在 VSCode 内置浏览器中预览 URL（例如启动 Vite 服务器后自动打开浏览器预览）。

![预览工具](https://storage.googleapis.com/zenn-user-upload/8968c9ad3920-20250407.gif)

### 多实例切换
- 轻松在多个打开的 VSCode 窗口间切换 MCP 服务器。（只需点击状态栏项目）

![实例切换](https://storage.googleapis.com/zenn-user-upload/0a2bc2bee634-20250407.gif)

### 中继功能（实验性）
- 中继并对外暴露 VSCode 1.99 引入的内置 MCP 服务器。
- 允许外部访问其他 MCP 扩展提供的工具，如 GitHub Copilot。

## 可用内置工具

- **execute_command**：在 VSCode 集成终端中执行命令
- **code_checker**：获取当前代码的诊断信息
- **focus_editor**：聚焦文件中的特定位置
- **list_debug_sessions** / **start_debug_session** / **restart_debug_session** / **stop_debug_session**：管理调试会话
- **text_editor**：文件操作（查看、替换、创建、插入、撤销）
- **list_directory**：以树状结构列出目录内容
- **get_terminal_output**：获取指定终端的输出
- **list_vscode_commands** / **execute_vscode_command**：列出并执行任意 VSCode 命令
- **preview_url**：在 VSCode 集成浏览器中打开 URL

## 安装与设置

1. 从 [VSCode 市场](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server) 安装该扩展。

2. 配置你的 MCP 客户端：

    - **使用 mcp-installer**：你只需指示它“安装 vscode-as-mcp-server MCP 服务器”。
    - **其他客户端如 Claude Desktop**：将以下内容添加到你的配置文件 (`claude_desktop_config.json`)：

    ```json
    {
      "mcpServers": {
        "vscode": {
          "command": "npx",
          "args": ["vscode-as-mcp-server"]
        }
      }
    }
    ```
3. 在 VSCode 右下角状态栏检查 MCP 服务器状态：

    - （服务器图标）：服务器正在运行
    - ∅：点击启动服务器

![服务器状态指示器](https://storage.googleapis.com/zenn-user-upload/321704116d4a-20250408.png)

## 动机

此扩展开发旨在缓解计量编码工具（如 Roo Code 和 Cursor）带来的高成本。它是一个经济实惠的自托管替代方案，直接集成在 VSCode 中。

欢迎提交错误报告和反馈！🙇

## 未来路线图

- 可选择暴露哪些内置 MCP 服务器
- 基于 WebView 的审批界面（类似 Roo Code）
- 集成 VSCode 的文件历史（时间线）
- 自动审批和工具启用/禁用的即时切换
- 可自定义服务器端口配置



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---