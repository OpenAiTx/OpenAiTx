# 🎭 Claude Code 的编排插件

> _类似 Claude Code 中的 N8N_

### 如果你喜欢这个项目，请考虑 ⭐ 支持！<br/>

## **多智能体工作流编排。** 链接 AI 代理，使用自然语言或声明式语法自动化复杂任务。

[![Claude Code](https://img.shields.io/badge/Claude%20Code-Compatible-blue)](https://claude.com/claude-code)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

---

## 安装

### 1. 添加插件市场

首先，将编排市场添加到你的 Claude Code：

```bash
/plugin marketplace add mbruhler/claude-orchestration
```
### 2. 安装插件


```bash
/plugin install orchestration@mbruhler
```
或使用交互式菜单：


```bash
/plugin
```

然后选择 **"浏览插件"** → 找到 **orchestration** → **安装**

### 3. 验证安装

检查插件是否已安装：

```bash
/help
```
你应该能看到类似 `/orchestration:menu`、`/orchestration:init` 等编排命令。

---

## 快速开始

### 0. 导入你的自定义代理（可选）

```
/orchestration:init
```

从 `~/.claude/agents/` 导入您的自定义代理到编排插件中。

**示例：**
```
/orchestration:init
→ Select agents to import
→ Agents become available as expert-code-implementer, etc. and the plugin can create workflows using them
```

### 1. 自然语言
```
"Create a workflow that fetches 10 Reddit posts about startups,
analyzes competition, and shows a ratings table"
```

该插件：
- ✅ 创建必要的临时脚本（Python/Node.js）
- ✅ 通过可点击的问题引导您
- ✅ 生成并执行优化的工作流程
- ✅ 返回格式化结果

### 2. 直接语法
```flow
# Parallel bug investigation
[
  Explore:"Find related code":code ||
  general-purpose:"Check recent changes":changes ||
  general-purpose:"Search similar issues":similar
] ->
general-purpose:"Identify root cause from {code}, {changes}, {similar}":analysis ->
@review:"Approve fix?" ->
general-purpose:"Implement fix and run tests":fix ->
general-purpose:"Commit changes with detailed message"
```

### 3. 模板
```
"Use the TDD implementation template"
```

---

## 核心功能

### 流程控制
```flow
# Sequential
step1 -> step2 -> step3

# Parallel
[task1 || task2 || task3]

# Conditional
test -> (if passed)~> deploy
     -> (if failed)~> rollback
```
### 自动化临时脚本
自动创建用于以下用途的 Python/Node.js 脚本：
- 🌐 网络爬虫（BeautifulSoup，Selenium）
- 📡 API 接口（Reddit，Twitter，GitHub）
- 📊 数据处理（pandas，NumPy）
- 🗄️ 数据库查询

### 手动检查点

```flow
build:"Compile app" ->
@review:"Check output. Continue?" ->
deploy:"Deploy to production"
```
### 视觉进度

```
╔════════════════════════════════════╗
║  TDD Implementation                ║
╠════════════════════════════════════╣
║    [Write Test] ●                  ║
║         │                          ║
║    [Implement] ○                   ║
║         │                          ║
║    [@Review] ○                     ║
╠════════════════════════════════════╣
║ Status: Writing test...            ║
╚════════════════════════════════════╝
```

---

## 语法参考

| 语法 | 含义 | 示例 |
|--------|---------|---------|
| `->` | 顺序 | `step1 -> step2` |
| `||` | 并行 | `[step1 \|\| step2]` |
| `~>` | 条件 | `(if passed)~> next` |
| `@label` | 检查点 | `@review-code` |
| `:var` | 捕获输出 | `analyze:"task":result` |
| `{var}` | 使用变量 | `"Process {result}"` |
| `$agent` | 临时代理 | `$scanner:"Scan"` |

---

## 内置代理

- **Explore** - 快速代码库探索与搜索
- **Plan** - 任务规划与拆解
- **general-purpose** - 用于复杂多步骤任务的多功能代理

---

## 示例

### Reddit 启动分析器
```flow
general-purpose:"Create Python PRAW script to fetch 10 r/startups posts.
                 Return JSON with title, url, description":posts ->

[
  general-purpose:"Research competition for post {posts[0]}":a1 ||
  general-purpose:"Research competition for post {posts[1]}":a2 ||
  # ... parallel analyses
] ->

general-purpose:"Rate ideas (1-10) on competition, market, feasibility.
                 Create markdown table":ratings ->

@review:"Review {ratings}. Ban any?" ->

general-purpose:"Generate top 3 opportunities summary"
```

### TDD 实现
```flow
# RED: Write failing test
general-purpose:"Write failing test for the feature":test ->
general-purpose:"Run test suite - verify it fails":red_result ->
@review-coverage:"Test coverage sufficient?" ->

# GREEN: Minimal implementation
general-purpose:"Write minimal code to pass the test":impl ->
general-purpose:"Run test suite - verify it passes":green_result ->
@review:"Code quality OK?" ->

# REFACTOR: Clean up
general-purpose:"Refactor code and add documentation":refactored ->
general-purpose:"Final test run and commit"
```

### 错误调查
```flow
# Parallel investigation
[
  Explore:"Find error pattern in codebase":code ||
  general-purpose:"Analyze error logs":logs ||
  general-purpose:"Check recent commits":commits ||
  general-purpose:"Search for similar bugs":known
] ->

# Diagnosis
general-purpose:"Identify root cause from {code}, {logs}, {commits}, {known}":cause ->
@review:"Diagnosis correct?" ->

# Fix with testing
general-purpose:"Write regression test for the bug":test ->
general-purpose:"Implement fix":fix ->

# Verification
[
  general-purpose:"Run regression test" ||
  general-purpose:"Run full test suite" ||
  general-purpose:"Perform smoke test"
] ->

@review:"Approve deployment?" ->
general-purpose:"Commit with detailed bug fix message"
```

---

## Project Structure

```
orchestration/
├── skills/              # Auto-activating skills
│   ├── creating-workflows/
│   ├── executing-workflows/
│   ├── managing-agents/
│   ├── managing-temp-scripts/
│   ├── designing-syntax/
│   ├── debugging-workflows/
│   └── using-templates/
├── agents/              # Permanent agents
├── temp-agents/         # Ephemeral (auto-cleaned)
├── temp-scripts/        # Generated scripts
├── examples/            # Templates (.flow)
└── docs/                # Documentation
```

---

## 高级

### 独立执行
```bash
# Headless (no checkpoints)
claude -p "Execute @examples/tdd-implementation.flow"

# With parameters
claude -p "/orchestration:run $(cat workflow.flow)" \
  --output-format json
```

### 代理推广
```
Workflow complete!

Temp agents: security-scanner, api-wrapper

Save as permanent?
[Save all] [Save security-scanner] [Delete all]
```

### 模板参数
```yaml
---
name: api-integration
parameters:
  - API_URL: "https://api.example.com"
  - NUM_ITEMS: 10
---

workflow: |
  general-purpose:"Fetch {{NUM_ITEMS}} from {{API_URL}}":data ->
  general-purpose:"Format results":output
```

---

## 故障排除

**工作流挂起**  
→ 检查点需要用户响应，或在无头模式下移除

**临时脚本失败**  
→ 检查 `temp-scripts/` 目录中的生成文件  
→ 验证 API 凭证和依赖项

**找不到代理**  
→ 内置：精确名称（Explore，通用）  
→ 插件：使用 `orchestration:` 前缀  
→ 临时：使用 `$` 前缀

## 星标历史

[![星标历史图表](https://api.star-history.com/svg?repos=mbruhler/claude-orchestration&type=date&legend=top-left)](https://www.star-history.com/#mbruhler/claude-orchestration&type=date&legend=top-left)

---

## 支持

- 📖 [文档](docs/)  
- 💬 [讨论](https://github.com/anthropics/orchestration/discussions)  
- 🐛 [问题](https://github.com/anthropics/orchestration/issues)

---

**MIT 许可证** | 为 Claude Code 社区构建


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---