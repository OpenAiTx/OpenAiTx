# claude.sh

Claude 代码重写为 bash 脚本。约1,500行。零 npm 包。

## 为什么

原始 Claude 代码约38万行 TypeScript，依赖266个 npm 包。该脚本用 bash 仅依赖 `curl` 和 `jq` 实现相同核心功能。

## 功能

- **实时流式传输** 通过 FIFO 管道 — 文本随着 Claude 生成实时显示
- **6个工具**：Bash、Read、Edit、Write、Glob、Grep
- **工具链** — 每轮最多调用25个工具
- **权限提示** — 运行非安全命令前询问（`y/n/a`）
- **CLAUDE.md 加载** — 从目录树上读取项目指令的 CLAUDE.md 文件
- **Git 感知上下文** — 系统提示中包含分支、状态和最近提交
- **会话保存/恢复** — 退出时自动保存，使用 `--resume <id>` 恢复
- **带退避的重试** — 对429/529速率限制进行指数重试
- **费用跟踪** — 按轮次和会话总计
- **加载动画** — 使用原版加载动画动词（Clauding, Flibbertigibbeting 等）
- **斜杠命令** — `/help`、`/cost`、`/model`、`/clear`、`/save`、`/resume`、`/commit`、`/diff`
- **管道模式** — `echo "explain this" | ./claude.sh`

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-04

---