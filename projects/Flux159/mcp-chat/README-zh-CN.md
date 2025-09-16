
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

开源通用 MCP 客户端，用于测试和评估 MCP 服务器及代理

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## 快速开始

确保您已在环境变量或项目根目录下的 .env 文件中导出 `ANTHROPIC_API_KEY`。您可以在 [Anthropic 控制台密钥页面](https://console.anthropic.com/settings/keys) 注册并获取 API 密钥。

下面是一个简单用例，从命令行启动与文件系统 MCP 服务器的交互式聊天提示：

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```
这将打开一个聊天提示，您可以使用它与服务器交互并与大型语言模型聊天。

## 配置

您也可以直接指定您的 claude_desktop_config.json（Mac）：


```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```
或（Windows）：


```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
在网页模式下，您可以启动新的聊天，向模型发送消息，并通过界面动态配置 mcp 服务器——无需在命令行中指定。此外，通过网页界面创建的聊天会保存到 ~/.mcpchats/chats 中，就像通过命令行界面创建的聊天一样。

## 功能

- [x] 通过命令行界面以交互模式运行，或使用 `-p` 直接传递提示
- [x] 网页模式，通过网页界面与模型聊天 `--web`
- [x] 连接任何 MCP 服务器（JS、Python、Docker），适用于生产或开发环境
- [x] 通过 `-m` 选择模型
- [x] 使用 `--system` 自定义系统提示
- [x] 保存聊天历史及设置到 `~/.mcpchat/chats`，包括网页聊天
- [x] 在 `~/.mcpchat/history` 中保存和恢复命令
- [x] 直接在聊天中查看工具调用的输出和参数，帮助调试 mcp 服务器

## 命令行界面使用

使用 `-p` 标志通过命令行运行提示：


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

这会使用 Kubernetes mcp-server 运行提示，并在响应通过标准输出接收后退出。

通过使用 `-m` 参数在命令行界面选择要聊天的模型：

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

使用模型 `claude-3.5` 进行聊天。请注意，目前仅支持Anthropic模型。

自定义系统提示：

`--system` 标志可用于指定系统提示：

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## 环境变量

Mcp-chat 支持将环境变量传递给 mcp 服务器。虽然这在 mcp 规范中并未标准化，其他客户端可能不会使用动态环境变量值——更多信息请阅读[这里](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666)关于标准 stdio mcp 客户端。

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## 针对 mcp-servers 开发者

您可以传入本地构建的 python 或 node mcp-server，以便在 mcp-chat 中进行测试：

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python：

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## 开发

安装依赖并运行 CLI：

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
要在连接到 mcp-server 的情况下开发 mcp-chat，请构建并使用服务器标志运行 CLI：


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```
测试：


```shell
bun run test
```
建筑物：


```shell
bun run build
```
发布：


```shell
bun run publish
```
发布 Docker：


```shell
bun run dockerbuild
```

### 项目结构

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## 发布新版本

前往 [releases](https://github.com/Flux159/mcp-chat/releases) 页面，点击“Draft New Release”，点击“Choose a tag”，通过输入“v{major}.{minor}.{patch}”语义化版本格式的新版本号创建新标签。然后，填写发布标题“Release v{major}.{minor}.{patch}”和描述/更新日志（如有必要），点击“Publish Release”。

这将创建一个新标签，触发 cd.yml 工作流进行新的发布构建。构建成功后，新版本将发布到 npm。注意，无需手动更新 package.json 中的版本号，工作流会自动更新 package.json 文件中的版本号并推送提交到 main 分支。

## 许可证

[MIT 许可证](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---