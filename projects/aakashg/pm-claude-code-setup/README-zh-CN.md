# PM Claude 代码设置

[![Stars](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![License](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

一个面向产品经理的生产就绪 Claude 代码配置。将这些文件放入您的项目中，Claude 代码即可立即理解产品经理的工作。

包括一个 `CLAUDE.md` 上下文文件，6 个产品经理技能和 4 个模板。设置仅需 60 秒。

**此设置可独立运行。完整的产品经理操作系统更进一步：41+ 技能，7 个子代理视角，完整的上下文库，发布模板，以及经过 100+ 次迭代完善的冲刺规划工作流。**

**[获取完整的产品经理操作系统 →](https://www.news.aakashg.com/p/pm-os)**

---

## 内容介绍

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## 快速设置

**步骤 1：** 将 `CLAUDE.md` 复制到您的项目根目录：
```bash
cp CLAUDE.md /path/to/your/project/
```

**步骤 2：** 复制 skills 文件夹：
```bash
cp -r .claude/ /path/to/your/project/
```
**步骤 3：** 在你的项目中打开 Claude Code。它会自动加载。

完成。Claude 现在知道你是产品经理，遵循你的写作风格，并能按命令撰写 PRD。

## CLAUDE.md 的作用

`CLAUDE.md` 是一个简洁的配置文件——不是手册。它告诉 Claude 你是谁，如何写作，以及需要遵守的规则。填写顶部的 `[FILL IN]` 字段（大约 2 分钟），其余部分立即生效：

- **你的背景** — 角色、产品、指标、OKR、术语
- **写作规则** — 强制语气、禁用词、输出标准
- **子代理角色** — 表格中的 6 个审阅者（工程师、设计师、高管、怀疑者、客户、数据分析师）
- **输出标准** — 生成前的澄清问题、带基线的指标、带缓解措施的风险
- **技能参考** — 指向 `.claude/skills/`，不重复其逻辑
- **MCP 连接** — 你的集成（Notion、Jira、Slack 等）

该文件刻意保持在 60 行以内。Claude 更善于遵循简短、具体的指令，而非冗长的说明。

## PRD 编写技能的作用

说“写一个 PRD”或“为[功能]创建 PRD”，Claude 会：

1. 先问 3-5 个澄清问题（绝不盲目生成）
2. 遵循结构化格式：假设、问题、解决方案、指标、非目标
3. 用 `[NEED: 来自 X 的数据]` 占位符标记缺失信息
4. 保持在 2 页以内，除非你要求更多
5. 包含具有具体数字和护栏的成功指标

## 如何最大化利用此设置

### 链式子代理

写一个 PRD → “作为工程师审查” → 修补漏洞 → “作为怀疑者审查” → 收紧假设 → “作为客户审查” → 简化价值主张。三轮审查，三分钟，极大提升规格质量。

### 使用 @ 引用

不要在聊天中粘贴文档——指向它们：


```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```
Claude 按需读取文件。你的上下文窗口保持干净。

### 使用计划模式（Shift+Tab）

在处理复杂任务前切换。强制 Claude 在执行前先概述其方法。你批准计划后，它再执行。最适合含有未解问题的产品需求文档、多文件编辑、以及“撤销”代价高的情况。

### 设置钩子

与 CLAUDE.md 指南（建议性）不同，钩子是确定性运行的：


```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```
通过 `/hooks` 或 `.claude/settings.json` 配置。退出码 0 = 继续，退出码 2 = 阻止并反馈。

### 会话管理

- **在不相关任务之间使用 `/clear`。** 上下文混淆是质量杀手第一名。
- **对话限制约 50 次交互。** 超过后质量下降。
- **使用交接。** 在结束长会话前：“写一个 HANDOFF.md。”下一次会话：“读取 @HANDOFF.md 并继续。”
- **运行并行会话。** 多个终端，每个终端运行独立的 Claude 实例和上下文窗口。
- **恢复会话。** `claude --continue` 继续上次会话，`claude --resume` 从历史中选择。

### 使 CLAUDE.md 自我改进

当 Claude 出错时，纠正它，然后：“向 CLAUDE.md 添加规则，以避免再次犯同样错误。” Claude 提出规则，你批准，它编辑文件。下一次会话自动加载规则。每季度修剪一次。

### 定制技能

技能附带通用示例。用你产品的真实示例替换它们。了解团队速度的冲刺计划器，始终优于通用计划器。

### 输入真实资料

不要描述你的 Slack 线程——粘贴它。不要总结用户访谈——粘贴访谈记录。技能提取并结构化杂乱信息；原始输入产生最佳输出。

### 快速参考


```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```

---

## 想要完整的设置？

此设置涵盖了核心的产品经理工作流程。完整的产品经理操作系统覆盖我每天进行的所有产品经理任务：

- 41+ 个自定义技能，适用于每个产品经理任务
- 7 个子代理视角（工程师、设计师、执行官、怀疑者、客户、数据分析师、法律）
- 包含您的 OKR、术语和团队结构的上下文库
- 发布、路线图、回顾和冲刺计划模板
- 自动拼写检查和文件保护的钩子

**[获取完整的产品经理操作系统 →](https://www.news.aakashg.com/p/pm-os)**

---

由 [Aakash Gupta](https://www.aakashg.com) 构建 | [产品增长通讯](https://www.news.aakashg.com)

---

## 故障排除

常见问题及解决方法。

### Claude 似乎不遵循我的 CLAUDE.md 指令

- **检查文件位置。** CLAUDE.md 必须位于您的项目根目录（您运行 `claude` 的目录）。Claude Code 会自动从工作目录加载它。
- **检查文件大小。** 超过约 150 行，Claude 会开始忽略指令。请积极精简。将领域知识移入技能中。
- **检查是否有冲突指令。** 矛盾的规则会导致不可预测的行为。审查是否有冲突。
- **重启会话。** 运行 `/clear` 或开启新的终端。Claude 会在会话开始时加载 CLAUDE.md。

### 技能没有触发

- **确认路径。** 技能必须位于 `.claude/skills/<skill-name>/SKILL.md`（大小写必须准确）。
- **检查触发条件。** SKILL.md 需要一个明确的触发短语，与您的提问方式相匹配。如果您的 SKILL.md 说“当用户要求写 PRD 时触发”，但您说“起草规格”，Claude 可能不会关联。
- **用明确请求测试。** 试试：“使用 prd-writer 技能为 X 写一个 PRD。” 如果这样有效但自然语言无效，请优化触发描述。
- **检查 SKILL.md 不为空且格式正确。** 打开文件确认有内容。

### Claude 在对话中途忘记上下文
- **上下文限制。** 长对话在大约50轮交流后会降级。使用 `/clear` 并以摘要重新开始。
- **使用交接。** 清除前，让 Claude 编写一个 HANDOFF.md，总结状态、决策和下一步。新会话以“阅读 @HANDOFF.md 并继续”开始。
- **避免粘贴巨量文档。** 使用 `@` 引用代替将整份文档粘贴到聊天中。

### 钩子未运行

- **检查 `.claude/settings.json`。** 钩子配置在此文件中，而非 CLAUDE.md。
- **检查退出码。** 钩子使用退出码 0（继续）和退出码 2（阻止+反馈）。其他退出码可能导致异常行为。
- **检查权限。** 钩子脚本需要可执行权限（`chmod +x`）。

### MCP 服务器无法连接

- **验证凭据。** 大多数 MCP 服务器需要 API 密钥或 OAuth 令牌。确认你的凭据有效。
- **检查服务器配置。** MCP 连接在 Claude Code 设置中配置，不在 CLAUDE.md 中。CLAUDE.md 仅做参考文档。
- **重启 Claude Code。** MCP 连接在启动时初始化。

### “我改了 CLAUDE.md 但没有变化”

Claude 在会话开始时读取 CLAUDE.md。会话中途修改需要重新加载：
1. 运行 `/clear` 重置上下文（CLAUDE.md 会自动重新加载）
2. 或启动一个新的终端会话



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---