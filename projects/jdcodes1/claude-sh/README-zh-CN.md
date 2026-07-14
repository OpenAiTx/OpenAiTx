
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code 重新编写为 bash 脚本。约 1,500 行。完全不依赖 npm 包。

## 为什么

原版 Claude Code 是约 380,000 行的 TypeScript，包含 266 个 npm 依赖。这个版本只用 `curl` 和 `jq`，就能完成同样的核心工作。

## 功能

- **实时流式传输** 通过 FIFO 管道——文本在 Claude 生成时实时显示
- **6 种工具**：Bash、Read、Edit、Write、Glob、Grep
- **工具链式调用**——每轮最多调用 25 次工具
- **权限提示**——在运行不安全命令前询问（`y/n/a`）
- **CLAUDE.md 加载**——从目录树中的 CLAUDE.md 文件读取项目说明
- **Git 感知上下文**——分支、状态和最近提交在系统提示中显示
- **会话保存/恢复**——退出时自动保存，使用 `--resume <id>` 恢复
- **退避重试**——对 429/529 速率限制进行指数级重试
- **成本跟踪**——每轮和会话总成本
- **加载动画**——使用原始加载动词（Clauding、Flibbertigibbeting 等）
- **斜杠命令**——`/help`、`/cost`、`/model`、`/clear`、`/save`、`/resume`、`/commit`、`/diff`
- **管道模式**——`echo "explain this" | ./claude.sh`

## 安装

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## 依赖项

- `curl`
- `jq`
- 可选：`rg`（ripgrep）用于更好的搜索
- 可选：`python3` 用于编辑工具

运行时版本固定在 `.tool-versions` 中。使用 [mise](https://mise.jdx.dev/) 安装它们：

```bash
mise install
```

## 使用方法

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### 环境变量

| 变量 | 默认值 | 描述 |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | （必填） | 您的 Anthropic API 密钥 |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | 使用的模型 |
| `CLAUDE_MAX_TOKENS` | `8192` | 最大输出令牌数 |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API 基础 URL |
| `CLAUDE_SH_PERMISSIONS` | `ask` | 权限模式：`ask`，`allow` 或 `deny` |

### 命令

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### 恢复会话

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## 架构

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## 工作原理

1. 读取用户输入
2. 使用 `jq` 构建 JSON 请求（消息、工具、系统提示）
3. 通过 FIFO 管道使用 `curl` 流式传输响应
4. 按行解析 SSE 事件，实时打印文本增量
5. 当收到 tool_use 块时，执行工具
6. 将工具结果作为消息反馈
7. 循环直到 Claude 停止调用工具

## 比较

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| 代码行数 | ~1,500 | ~380,000 |
| 依赖项 | curl, jq | 266 个 npm 包 |
| 二进制大小 | 0（脚本） | ~200MB node_modules |
| 启动时间 | 即时 | ~500ms |

### 测试

测试使用 [bats](https://github.com/bats-core/bats-core)（Bash 自动化测试系统）：

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---