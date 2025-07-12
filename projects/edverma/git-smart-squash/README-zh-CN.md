# Git Smart Squash

别再浪费时间手动整理提交记录了。让 AI 替你完成这项工作。

## 问题

你一定遇到过这种情况：为一个功能分支提交了 15 次，有一半的提交信息是 “fix”、“typo” 或 “WIP”。现在你需要为 PR 审查进行整理。手动合并和重写提交记录非常繁琐。

## 解决方案

Git Smart Squash 会分析你的更改，并将它们重新组织为具有规范提交信息的逻辑提交：

```bash
# 之前：凌乱的分支
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# After: clean, logical commits
* feat: 实现 JWT 认证系统
* test: 增加认证端点的测试覆盖

```

## 快速开始

### 1. 安装

```bash
# 使用 pip
pip install git-smart-squash

# 使用 pipx（推荐隔离安装）
pipx install git-smart-squash

# 使用 uv（快速的 Python 包管理器）
uv tool install git-smart-squash
```
### 2. 设置 AI

**选项 A：本地（免费，私密）**
```bash
# 从 https://ollama.com 安装 Ollama
ollama pull devstral  # 默认模型
```

**选项 B：云端（效果更好）**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. 运行

```bash
cd your-repo
git-smart-squash
```
就是这样。请审核计划并批准。

## 命令行参数

| 参数 | 描述 | 默认值 |
|-----------|-------------|---------|
| `--base` | 用于比较的基准分支 | 配置文件或 `main` |
| `--ai-provider` | 要使用的AI提供商（openai、anthropic、local、gemini） | 在设置中配置 |
| `--model` | 要使用的具体AI模型（见下方推荐模型） | 提供商默认值 |
| `--config` | 自定义配置文件的路径 | `.git-smart-squash.yml` 或 `~/.git-smart-squash.yml` |
| `--auto-apply` | 无需确认提示自动应用提交计划 | `false` |
| `--instructions`, `-i` | AI的自定义指令（例如，“按功能区域分组”） | 无 |
| `--no-attribution` | 禁用提交中的归属信息 | `false` |
| `--debug` | 启用详细信息的调试日志 | `false` |

## 推荐模型

### 默认模型
- **OpenAI**：`gpt-4.1`（默认）
- **Anthropic**：`claude-sonnet-4-20250514`（默认）
- **Gemini**：`gemini-2.5-pro`（默认）
- **Local/Ollama**：`devstral`（默认）

### 模型选择
```bash
# 指定不同的模型
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# 本地 Ollama
git-smart-squash --ai-provider local --model llama-3.1
```

## 自定义指令

`--instructions` 参数可让你控制提交的组织方式：

### 示例
```bash
# 添加工单前缀
git-smart-squash -i "Prefix all commits with [ABC-1234]"

# 按类型分开
git-smart-squash -i "Keep backend and frontend changes in separate commits"
```
# 限制提交数量
git-smart-squash -i "最多创建 3 个提交"
```

### 提高效果的建议
- **要具体**：“将数据库迁移单独分组”比“整理得好看”更有效
- **每次只给一个指令**：复杂的多部分指令可能会被部分忽略
- **使用更好的模型**：大型模型比小型模型更能可靠地遵循指令

## 常见用例

### “我需要在 PR 审查前整理提交”
```bash
git-smart-squash              # 显示计划并提示确认
git-smart-squash --auto-apply # 自动应用，无需确认
```

### “我的主分支不是 main”
```bash
git-smart-squash --base develop
```
### “我想使用特定的 AI 提供商”
```bash
git-smart-squash --ai-provider openai
```

## 安全性

**你的代码是安全的：**
- 在进行更改前显示操作计划
- 自动创建备份分支
- 需要工作区干净无未提交更改
- 不会在未经你命令的情况下推送

**如果出现问题：**
```bash
# 查找备份
git branch | grep backup

# 恢复
git reset --hard your-branch-backup-[timestamp]
```

## AI 提供商

| 提供商    | 费用    | 隐私   |
|-----------|--------|--------|
| **Ollama**    | 免费   | 本地   |
| **OpenAI**    | ~$0.01 | 云端   |
| **Anthropic** | ~$0.01 | 云端   |
| **Gemini**    | ~$0.01 | 云端   |

## 高级配置（可选）

想要自定义？创建一个配置文件：

**项目专用**（在你的仓库中放置 `.git-smart-squash.yml`）:
```yaml
ai:
  provider: openai  # 该项目使用 OpenAI
base: develop       # 该项目使用 develop 作为基础分支
```
**全局默认**（`~/.git-smart-squash.yml`）:
```yaml
ai:
  provider: local   # 默认始终使用本地AI
base: main          # 所有项目的默认基础分支
```

## 故障排查

### “无效的 JSON” 错误
这通常意味着 AI 模型未能正确格式化响应内容：
- **对于 Ollama**：将 `llama2` 切换为 `mistral` 或 `mixtral`
- **解决方法**：运行 `ollama pull mistral` 后重试
- **替代方案**：使用带有 `--ai-provider openai` 的云服务商

### 模型未遵循指令
某些模型难以处理复杂指令：
- **使用更优的模型**：`--model gpt-4-turbo` 或 `--model claude-3-opus`
- **简化指令**：单一且明确的指令效果更好
- **明确表达**：“前缀加上 [ABC-123]” 比 “添加工单号” 更清楚
### “未找到 Ollama”
```bash
# 从 https://ollama.com 安装
ollama serve
ollama pull devstral  # 默认模型
```

### 提交分组不佳
如果 AI 创建了太多提交或分组不合理：
- **模型不足**：使用更大的模型
- **添加指令**：`-i "将相关更改分组，最多 3 个提交"`
- **提供反馈**：在 GitHub 上创建 issue 并告知我们发生了什么

### 安装问题（Mac）
如果你没有 pip 或者更喜欢隔离安装：
```bash
# 使用 pipx（推荐）
brew install pipx
pipx install git-smart-squash
```
### “没有可重组的更改”
```bash
git log --oneline main..HEAD  # 检查你是否有提交
git diff main                 # 检查你是否有更改
```

### 大型差异 / Token 限制
本地模型约有 32k token 限制。对于较大的更改：
- 使用 `--base` 指定一个更近的提交
- 切换到云端：`--ai-provider openai`
- 拆分为更小的 PR

### 需要更多帮助？

请查阅我们的[详细文档](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md)或提交 issue！

## 许可证

MIT 许可证 - 详情请参见 [LICENSE](LICENSE) 文件。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---