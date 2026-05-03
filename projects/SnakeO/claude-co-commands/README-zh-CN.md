# Claude 协同命令插件

3 个适用于 Claude Code 的协作命令，使用 [Codex MCP 服务器](https://github.com/openai/codex) 生成并行计划、验证计划和头脑风暴想法。

## 命令

| 命令 | 描述 | 适用场景 |
|---------|-------------|-------------|
| `/co-brainstorm` | 与 Codex 交流想法 | 需要快速获得替代方案、批评和视角 |
| `/co-plan` | 通过 Codex 生成并行计划 | 需要对你的计划方法获取第二意见 |
| `/co-validate` | 获取资深工程师对计划的审查 | 计划定稿前需要关键反馈 |

## 前提条件

- [Node.js](https://nodejs.org/)（用于 `npx`）
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## 安装

### 选项 1：插件市场（推荐）

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### 选项 2：Git 克隆

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```

### 选项 3：手动复制

将 `plugins/co-commands/skills/` 内容复制到 `~/.claude/skills/`。

## MCP 服务器设置（必需）

这些命令需要 Codex MCP 服务器。

### 选项 A：命令行界面（推荐）

```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```

### 选项 B：手动

将此添加到 `~/.claude.json` 中的 `mcpServers` 对象：

```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```
如果您已经在 `mcpServers` 中有条目，请将此作为附加键合并。不要覆盖现有服务器。

### 验证

1. 重启 Claude Code（如果您手动编辑了 `~/.claude.json`）。
2. 运行 `claude mcp list` 以确认服务器已注册。
3. 使用 `/co-brainstorm test idea` 进行测试，确认它触发了 MCP 调用。

## 命令详情

### `/co-brainstorm`

启动与 Codex 的交互式头脑风暴会话。将您的主题或问题作为参数传递。


```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```

将 Codex 计划与您的计划进行比较，以发现遗漏的方法、更简单的替代方案或被忽视的边缘情况。

### `/co-validate`

将您的计划发送给 Codex，进行类似资深工程师的审查。传递您的计划文件路径。

```
/co-validate .claude/plans/my-plan.md
```
返回关键问题、简化机会和替代方法。支持来回讨论。

## 故障排除

| 问题 | 解决方案 |
|---------|----------|
| `npx: command not found` | 安装包含 npm/npx 的 [Node.js](https://nodejs.org/) |
| 会话中找不到 MCP 工具 | 确认 `~/.claude.json` 中服务器名称完全是 `validate-plans-and-brainstorm-ideas` |
| `~/.claude.json` 中的 JSON 解析错误 | 验证您的 JSON（检查逗号和大括号） |
| 安装后命令未出现 | 重启 Claude Code 并确认技能文件夹存在 |

## 许可证

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---